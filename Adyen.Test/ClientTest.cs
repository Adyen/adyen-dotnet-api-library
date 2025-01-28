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

        [DataTestMethod]
        [DataRow(Model.Environment.Live, Region.EU, "https://terminal-api-live.adyen.com")]
        [DataRow(Model.Environment.Live, Region.AU, "https://terminal-api-live-au.adyen.com")]
        [DataRow(Model.Environment.Live, Region.US, "https://terminal-api-live-us.adyen.com")]
        [DataRow(Model.Environment.Live, Region.APSE, "https://terminal-api-live-apse.adyen.com")]
        public void GetCloudApiEndpoint_When_Region_Specified_Returns_TerminalApi_LiveEndpointUrl(Model.Environment environment, Region region, string expectedEndpoint)
        {
            var config = new Config
            {
                Environment = environment,
                TerminalApiRegion = region
            };
            var client = new Client(config);
            
            string actualEndpoint = client.GetCloudApiEndpoint();

            Assert.AreEqual(expectedEndpoint, actualEndpoint);
        }
        

        [TestMethod]
        public void GetCloudApiEndpoint_When_Region_Is_India_And_Environment_Is_Live_Throws_ArgumentOutOfRangeException()
        {
            var config = new Config
            {
                Environment = Model.Environment.Live,
                TerminalApiRegion = Region.IN
            };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Client(config));
        }

        [DataTestMethod]
        [DataRow(Model.Environment.Test, Region.EU, "https://terminal-api-test.adyen.com")]
        [DataRow(Model.Environment.Test, Region.AU, "https://terminal-api-test.adyen.com")]
        [DataRow(Model.Environment.Test, Region.US, "https://terminal-api-test.adyen.com")]
        [DataRow(Model.Environment.Test, Region.APSE, "https://terminal-api-test.adyen.com")]
        [DataRow(Model.Environment.Test, Region.IN, "https://terminal-api-test.adyen.com")]
        public void GetCloudApiEndpoint_Should_Return_TerminalApi_TestEndpointUrl(Model.Environment environment, Region region, string expectedEndpoint)
        {
            var config = new Config
            {
                Environment = environment,
                TerminalApiRegion = region
            };
            var client = new Client(config);

            string actualEndpoint = client.GetCloudApiEndpoint();


            Assert.AreEqual(expectedEndpoint, actualEndpoint);
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