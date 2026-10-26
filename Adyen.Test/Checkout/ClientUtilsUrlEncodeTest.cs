using Adyen.Checkout.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.Checkout
{
    [TestClass]
    public class ClientUtilsUrlEncodeTest
    {
        [TestMethod]
        public void GivenSurrogatePairAtChunkBoundary_WhenUrlEncoded_ThenPairRemainsIntact()
        {
            const int prefixLength = 32765;
            var input = new string('a', prefixLength) + "\U0001F60A" + "x";
            var expected = new string('a', prefixLength) + "%F0%9F%98%8A" + "x";

            Assert.AreEqual(expected, ClientUtils.UrlEncode(input));
        }
    }
}
