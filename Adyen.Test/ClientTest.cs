using System;
using System.Linq;
using Adyen.Constants;
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
        public void TestSetEnvironment()
        {
            var client = new Client(new Config());
            client.SetEnvironment(Model.Environment.Live, "testPrefix.adyen.com");
            Assert.AreEqual(Model.Environment.Live, client.Config.Environment);
            Assert.AreEqual("testPrefix.adyen.com", client.Config.LiveEndpointUrlPrefix);
            Assert.AreEqual("https://terminal-api-live.adyen.com", client.GetCloudApiEndpoint());

            client.SetEnvironment(Model.Environment.Test, "");
            Assert.AreEqual("https://terminal-api-test.adyen.com", client.GetCloudApiEndpoint());
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

        [TestMethod]
        public void TestSetTerminalApiRegion()
        {
            var clientAU = new Client(new Config
                {Environment = Adyen.Model.Environment.Live, TerminalApiRegion = Region.AU});
            Assert.AreEqual(clientAU.GetCloudApiEndpoint(), ClientConfig.CloudApiEndPointAULive);
            var clientEU = new Client(new Config
                {Environment = Adyen.Model.Environment.Live, TerminalApiRegion = Region.EU});
            Assert.AreEqual(clientEU.GetCloudApiEndpoint(), ClientConfig.CloudApiEndPointEULive);
            var clientUS = new Client(new Config
                {Environment = Adyen.Model.Environment.Live, TerminalApiRegion = Region.US});
            Assert.AreEqual(clientUS.GetCloudApiEndpoint(), ClientConfig.CloudApiEndPointUSLive);
            var clientAPSE = new Client(new Config
                {Environment = Adyen.Model.Environment.Live, TerminalApiRegion = Region.APSE});
            Assert.AreEqual(clientAPSE.GetCloudApiEndpoint(), ClientConfig.CloudApiEndPointAPSELive);
            var clientDefault = new Client(new Config {Environment = Adyen.Model.Environment.Live});
            Assert.AreEqual(clientDefault.GetCloudApiEndpoint(), ClientConfig.CloudApiEndPointEULive);
        }
    }
}