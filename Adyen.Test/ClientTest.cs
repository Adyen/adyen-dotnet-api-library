using System;
using Adyen.Constants;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Environment = Adyen.Model.Environment;

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
            client.SetEnvironment(Environment.Live, "testPrefix.adyen.com");
            
            Assert.AreEqual(Environment.Live, client.Config.Environment);
            Assert.AreEqual("testPrefix.adyen.com", client.Config.LiveEndpointUrlPrefix);
            Assert.AreEqual("https://terminal-api-live.adyen.com", client.Config.CloudApiEndPoint);
        
            client.SetEnvironment(Environment.Test, "");
            Assert.AreEqual(Environment.Test, client.Config.Environment);
            Assert.AreEqual("", client.Config.LiveEndpointUrlPrefix);
            Assert.AreEqual("https://terminal-api-test.adyen.com", client.Config.CloudApiEndPoint);
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
        [DataRow(Environment.Live, Region.EU, "https://terminal-api-live.adyen.com")]
        [DataRow(Environment.Live, Region.AU, "https://terminal-api-live-au.adyen.com")]
        [DataRow(Environment.Live, Region.US, "https://terminal-api-live-us.adyen.com")]
        [DataRow(Environment.Live, Region.APSE, "https://terminal-api-live-apse.adyen.com")]
        public void When_Region_Specified_Returns_TerminalApi_LiveEndpointUrl(Environment environment, Region region, string expectedEndpoint)
        {
            var config = new Config
            {
                Environment = environment,
                TerminalApiRegion = region
            };
            var client = new Client(config);
            Assert.AreEqual(expectedEndpoint, client.Config.CloudApiEndPoint);
        }

        [TestMethod]
        public void When_Region_Is_India_And_Environment_Is_Live_Throws_ArgumentOutOfRangeException()
        {
            var config = new Config
            {
                Environment = Environment.Live,
                TerminalApiRegion = Region.IN
            };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Client(config));
        }
        
        [DataTestMethod]
        [DataRow(Environment.Test, Region.EU, "https://terminal-api-test.adyen.com")]
        [DataRow(Environment.Test, Region.AU, "https://terminal-api-test.adyen.com")]
        [DataRow(Environment.Test, Region.US, "https://terminal-api-test.adyen.com")]
        [DataRow(Environment.Test, Region.APSE, "https://terminal-api-test.adyen.com")]
        [DataRow(Environment.Test, Region.IN, "https://terminal-api-test.adyen.com")]
        public void Client_Should_Always_Return_TerminalApi_TestEndpointUrl(Environment environment, Region region, string expectedEndpoint)
        {
            var config = new Config
            {
                Environment = environment,
                TerminalApiRegion = region
            };
            var client = new Client(config);
            Assert.AreEqual(expectedEndpoint, client.Config.CloudApiEndPoint);
        }
        
        [DataTestMethod]
        [DataRow(Environment.Live, Region.EU)]
        [DataRow(Environment.Live, Region.AU)]
        [DataRow(Environment.Live, Region.US)]
        [DataRow(Environment.Live, Region.APSE)]
        [DataRow(Environment.Live, Region.IN)]
        [DataRow(Environment.Test, Region.EU)]
        [DataRow(Environment.Test, Region.AU)]
        [DataRow(Environment.Test, Region.US)]
        [DataRow(Environment.Test, Region.APSE)]
        [DataRow(Environment.Test, Region.IN)]
        public void When_Custom_CloudApiEndpoint_Is_Specified_And_Environment_Is_Test_Or_Live_Should_Always_Return_Custom_CloudApiEndpoint(Environment environment, Region region)
        {
            var config = new Config
            {
                Environment = environment,
                TerminalApiRegion = region,
                CloudApiEndPoint = "https://localhost:443/nexo"
            };
            var client = new Client(config);
            Assert.AreEqual("https://localhost:443/nexo", client.Config.CloudApiEndPoint);
        }
        
        [TestMethod]
        public void TestSetTerminalApiRegion()
        {
            var clientAU = new Client(new Config
                {Environment = Environment.Live, TerminalApiRegion = Region.AU});
            Assert.AreEqual(clientAU.GetCloudApiEndpoint(), ClientConfig.CloudApiEndPointAULive);
            var clientEU = new Client(new Config
                {Environment = Environment.Live, TerminalApiRegion = Region.EU});
            Assert.AreEqual(clientEU.GetCloudApiEndpoint(), ClientConfig.CloudApiEndPointEULive);
            var clientUS = new Client(new Config
                {Environment = Environment.Live, TerminalApiRegion = Region.US});
            Assert.AreEqual(clientUS.GetCloudApiEndpoint(), ClientConfig.CloudApiEndPointUSLive);
            var clientAPSE = new Client(new Config
                {Environment = Environment.Live, TerminalApiRegion = Region.APSE});
            Assert.AreEqual(clientAPSE.GetCloudApiEndpoint(), ClientConfig.CloudApiEndPointAPSELive);
            var clientDefault = new Client(new Config {Environment = Environment.Live});
            Assert.AreEqual(clientDefault.GetCloudApiEndpoint(), ClientConfig.CloudApiEndPointEULive);
        }
    }
}