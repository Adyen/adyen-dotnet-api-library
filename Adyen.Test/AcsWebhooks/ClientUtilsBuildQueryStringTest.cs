using System.Collections.Specialized;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.AcsWebhooks
{
    /// <summary>
    /// Tests for the <c>BuildQueryString</c> method in <see cref="Adyen.AcsWebhooks.Client.ClientUtils"/>.
    ///
    /// The method uses minimal percent-encoding: only characters that would break query string
    /// structure are escaped (&amp;, =, #, space, %). Sub-delimiters (+, /, !) and ASCII
    /// printable characters are intentionally left unencoded. Non-ASCII characters are encoded
    /// via <see cref="Uri.EscapeDataString"/>.
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
            return (string)method!.Invoke(null, new object[] { parameters });
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
        public void Percent_InValue_IsEncoded_PreventingDoubleEncoding()
        {
            // regression: "50%off" must not produce "50%off" (leaving % raw)
            Assert.AreEqual("foo=50%25off", Invoke(Nvc(("foo", "50%off"))));
        }

        [TestMethod]
        public void AlreadyEncodedPercent20_IsNotDoubleEncoded()
        {
            // "%20" in input → "%" becomes "%25", so output is "%2520"
            Assert.AreEqual("foo=%2520", Invoke(Nvc(("foo", "%20"))));
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
    }
}
