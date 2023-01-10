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
            Config config = new Config();
            config.Proxy = null;
            Client client = new Client(config);
            Assert.AreEqual(client.Config.Proxy, config.Proxy);
        }

        [TestMethod]
        public void CreateClientWithProxyConfiguration()
        {
            Config config = new Config();
            config.Proxy = new WebProxy();
            Client client = new Client(config);
            Assert.AreEqual(client.Config.Proxy, config.Proxy);
        }
    }
}