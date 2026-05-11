using System.Collections.Specialized;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.AcsWebhooks
{
    /// <summary>
    /// Tests for the <c>BuildQueryString</c> method in <see cref="Adyen.AcsWebhooks.Client.ClientUtils"/>.
    ///
    /// The method uses minimal percent-encoding: only characters that would break query string
    /// structure are escaped (&amp;, =, #, space). Sub-delimiters (+, /, !) and ASCII
    /// printable characters are intentionally left unencoded. The <c>%</c> character is also
    /// left unencoded so that already percent-encoded sequences pass through unchanged.
    /// Non-ASCII characters are encoded via <see cref="Uri.EscapeDataString"/>.
    ///
    /// Reflection is used because <c>BuildQueryString</c> is <c>internal</c> and the main assembly
    /// is strong-named, which prevents <c>InternalsVisibleTo</c> from granting access to an
    /// unsigned test assembly without embedding the test assembly's public key.
    ///
    /// </summary>
    [TestClass]
    public class ClientUtilsBuildQueryStringTest
    {
        private static string Invoke(NameValueCollection parameters)
        {
            var method = typeof(Adyen.AcsWebhooks.Client.ClientUtils)
                .GetMethod("BuildQueryString", BindingFlags.NonPublic | BindingFlags.Static);
            Assert.IsNotNull(method, "BuildQueryString method not found — it may have been renamed or removed.");
            return (string)method.Invoke(null, new object[] { parameters });
        }

        private static NameValueCollection Nvc(params (string key, string value)[] pairs)
        {
            var nvc = new NameValueCollection();
            foreach (var (k, v) in pairs)
                nvc.Add(k, v);
            return nvc;
        }

        [TestMethod]
        public void Baseline_NoSpecialChars_ReturnsUnchanged()
        {
            Assert.AreEqual("foo=bar", Invoke(Nvc(("foo", "bar"))));
        }

        [TestMethod]
        public void Ampersand_InValue_IsEncoded()
        {
            Assert.AreEqual("foo=a%26b", Invoke(Nvc(("foo", "a&b"))));
        }

        [TestMethod]
        public void Equals_InValue_IsEncoded()
        {
            Assert.AreEqual("foo=a%3Db", Invoke(Nvc(("foo", "a=b"))));
        }

        [TestMethod]
        public void Hash_InValue_IsEncoded()
        {
            Assert.AreEqual("foo=a%23b", Invoke(Nvc(("foo", "a#b"))));
        }

        [TestMethod]
        public void Space_InValue_IsEncoded()
        {
            Assert.AreEqual("foo=a%20b", Invoke(Nvc(("foo", "a b"))));
        }

        [TestMethod]
        public void Percent_InValue_PassesThrough()
        {
            // raw "%" is not a structural character, so it must not be encoded
            Assert.AreEqual("foo=50%off", Invoke(Nvc(("foo", "50%off"))));
        }

        [TestMethod]
        public void AlreadyEncodedPercent20_IsNotDoubleEncoded()
        {
            // already-encoded sequences must pass through unchanged — "%" is preserved
            Assert.AreEqual("foo=%20", Invoke(Nvc(("foo", "%20"))));
        }

        [TestMethod]
        public void Unicode_IsPercentEncoded()
        {
            // "café" → "caf%C3%A9"
            Assert.AreEqual("foo=caf%C3%A9", Invoke(Nvc(("foo", "café"))));
        }

        [TestMethod]
        public void SubDelimiters_ArePreserved()
        {
            // +, /, ! must NOT be encoded (minimal encoding contract)
            Assert.AreEqual("foo=a+b/c!", Invoke(Nvc(("foo", "a+b/c!"))));
        }

        [TestMethod]
        public void MultipleParams_AreJoinedWithAmpersand()
        {
            Assert.AreEqual("a=1&b=2", Invoke(Nvc(("a", "1"), ("b", "2"))));
        }

        [TestMethod]
        public void NullValue_RendersAsEmpty()
        {
            var nvc = new NameValueCollection();
            nvc.Add("foo", null);
            Assert.AreEqual("foo=", Invoke(nvc));
        }

        [TestMethod]
        public void ReservedCharsInKey_AreFullyEncoded()
        {
            // key contains "&" — must be fully escaped via Uri.EscapeDataString
            Assert.AreEqual("a%26b=1", Invoke(Nvc(("a&b", "1"))));
        }

        [TestMethod]
        public void EmptyCollection_ReturnsEmptyString()
        {
            Assert.AreEqual("", Invoke(new NameValueCollection()));
        }

        [TestMethod]
        public void EmptyValue_RendersKeyWithNoValue()
        {
            Assert.AreEqual("foo=", Invoke(Nvc(("foo", ""))));
        }

        [TestMethod]
        public void SurrogatePair_IsPercentEncoded()
        {
            // "😊" (U+1F60A) is stored as a surrogate pair in UTF-16; must encode to %F0%9F%98%8A
            Assert.AreEqual("foo=%F0%9F%98%8A", Invoke(Nvc(("foo", "😊"))));
        }

        [TestMethod]
        public void AlreadyEncodedToken_PassesThroughUnchanged()
        {
            // opaque tokens with pre-encoded sequences must not be double-encoded
            Assert.AreEqual("token=already%26encoded%20value", Invoke(Nvc(("token", "already%26encoded%20value"))));
        }

        [TestMethod]
        public void PercentFollowedByValidHex_PassesThroughUnchanged()
        {
            // "100%20rate": the caller is responsible for pre-encoding raw % — this method
            // treats any % as already encoded and leaves it unchanged
            Assert.AreEqual("foo=100%20rate", Invoke(Nvc(("foo", "100%20rate"))));
        }

        [TestMethod]
        public void UnpairedSurrogate_IsReplacedWithReplacementCharacter()
        {
            // Unpaired high surrogate \uD83D should be replaced with %EF%BF%BD to avoid crashes
            Assert.AreEqual("foo=%EF%BF%BD", Invoke(Nvc(("foo", "\uD83D"))));
        }

        [TestMethod]
        public void ControlCharacters_ArePercentEncoded()
        {
            // Control characters (c < 32) must be encoded for safety
            Assert.AreEqual("foo=%0A%0D%09", Invoke(Nvc(("foo", "\n\r\t"))));
        }

        [TestMethod]
        public void HighAscii_IsPercentEncoded()
        {
            // DEL (127) and non-ASCII characters (>= 128) should be encoded
            Assert.AreEqual("foo=%7F", Invoke(Nvc(("foo", "\u007F"))));
        }
    }
}
