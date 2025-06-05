using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class ProxyTest
    {
        [TestMethod]
        public void CreateClientWithNullProxyConfiguration()
        {
            var config = new Config();
            config.Proxy = null;
            var client = new AdyenClient(config);
            Assert.AreEqual(client.Config.Proxy, config.Proxy);
        }

        [TestMethod]
        public void CreateClientWithProxyConfiguration()
        {
            var config = new Config();
            config.Proxy = new WebProxy();
            var client = new AdyenClient(config);
            Assert.AreEqual(client.Config.Proxy, config.Proxy);
        }
    }
}