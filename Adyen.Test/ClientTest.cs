using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class ClientTest
    {
        [TestMethod]
        public void HttpClientFirstCallReturnsDefaultHttpClient()
        {
            var client = new Client(new Config()); 
            var httpClient = client.HttpClient;
            Assert.IsNotNull(httpClient);
        }

        [TestMethod]
        [Ignore]
        public void TestSetEnvironment()
        {
            var client = new Client(new Config());
            client.SetEnvironment(Model.Environment.Live, "testPrefix.adyen.com");
            Assert.AreEqual(Model.Environment.Live, client.Config.Environment);
            Assert.AreEqual("testPrefix.adyen.com", client.Config.LiveEndpointUrlPrefix);
            Assert.AreEqual("https://terminal-api-live.adyen.com", client.Config.CloudApiEndPoint);
        }

        Client testClient;
        String logLine;

        [TestInitialize]
        public void TestSetup()
        {
            testClient = new Client(new Config());
            testClient.LogCallback += new Client.CallbackLogHandler((message) => {
                logLine = message;
            });

        }
        [TestMethod]
        public void TestLogLine()
        {
            testClient.LogLine("testMessage");
            Assert.AreEqual("testMessage", logLine);
        }
    }
}