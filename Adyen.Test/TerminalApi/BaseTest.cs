using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Constants;
using Adyen.HttpClient.Interfaces;
using Adyen.Model;
using Adyen.Model.TerminalApi;
using Adyen.Model.Payment;
using Adyen.Service;
using NSubstitute;
using Environment = System.Environment;
using PaymentResult = Adyen.Model.Payment.PaymentResult;

namespace Adyen.Test
{
    public class BaseTest
    {
        private protected IClient ClientInterfaceSubstitute;

        #region Modification objects

        protected CaptureRequest CreateCaptureTestRequest(string pspReference)
        {
            var captureRequest = new CaptureRequest
            {
                MerchantAccount = "MerchantAccount",
                ModificationAmount = new Model.Payment.Amount("EUR", 150),
                Reference = "capture - " + DateTime.Now.ToString("yyyyMMdd"),
                OriginalReference = pspReference,
                AdditionalData = new Dictionary<string, string> {{"authorisationType", "PreAuth"}}
            };
            return captureRequest;
        }


        protected CancelOrRefundRequest CreateCancelOrRefundTestRequest(string pspReference)
        {
            var cancelOrRefundRequest = new CancelOrRefundRequest
            {
                MerchantAccount = "MerchantAccount",
                Reference = "cancelOrRefund - " + DateTime.Now.ToString("yyyyMMdd"),
                OriginalReference = pspReference
            };
            return cancelOrRefundRequest;
        }

        protected RefundRequest CreateRefundTestRequest(string pspReference)
        {
            var refundRequest = new RefundRequest
            {
                MerchantAccount = "MerchantAccount",
                ModificationAmount = new Model.Payment.Amount("EUR", 150),
                Reference = "refund - " + DateTime.Now.ToString("yyyyMMdd"),
                OriginalReference = pspReference
            };
            return refundRequest;
        }

        protected CancelRequest CreateCancelTestRequest(string pspReference)
        {
            var cancelRequest = new CancelRequest
            {
                MerchantAccount = "MerchantAccount",
                Reference = "cancel - " + DateTime.Now.ToString("yyyyMMdd"),
                OriginalReference = pspReference
            };
            return cancelRequest;
        }

        protected AdjustAuthorisationRequest CreateAdjustAuthorisationRequest(string pspReference)
        {
            var adjustAuthorisationRequest = new AdjustAuthorisationRequest
            {
                MerchantAccount = "MerchantAccount",
                ModificationAmount = new Model.Payment.Amount("EUR", 150),
                Reference = "adjustAuthorisationRequest - " + DateTime.Now.ToString("yyyyMMdd"),
                OriginalReference = pspReference,
            };
            return adjustAuthorisationRequest;
        }
        #endregion
        
        /// <summary>
        /// Creates mock test client without any response
        /// </summary>
        /// <returns>IClient implementation</returns>
        protected Client CreateMockForAdyenClientTest(Config config)
        {
            //Create a mock interface
            ClientInterfaceSubstitute = Substitute.For<IClient>();
            
            ClientInterfaceSubstitute.RequestAsync(Arg.Any<string>(),
                Arg.Any<string>(), Arg.Any<RequestOptions>(), Arg.Any<HttpMethod>(),
                Arg.Any<CancellationToken>()).Returns(Task.FromResult(""));

            var clientMock = new Client(config)
            {
                HttpClient = ClientInterfaceSubstitute,
                Config = config
            };
            return clientMock;
        }

        /// <summary>
        /// Creates mock test client 
        /// </summary>
        /// <param name="fileName">The file that is returned</param>
        /// <returns>IClient implementation</returns>
        protected Client CreateMockTestClientRequest(string fileName)
        {
            var mockPath = GetMockFilePath(fileName);
            var response = MockFileToString(mockPath);
            
            ClientInterfaceSubstitute = Substitute.For<IClient>();
            
            ClientInterfaceSubstitute.RequestAsync(Arg.Any<string>(),
                Arg.Any<string>(), Arg.Any<RequestOptions>(), Arg.Any<HttpMethod>(),
                Arg.Any<CancellationToken>()).Returns(response);
            
            var config = new Config
            {
                Environment = Model.Environment.Test
            };
            var clientMock = new Client(config)
            {
                HttpClient = ClientInterfaceSubstitute,
                Config = new Config
                {
                    Username = "Username",
                    Password = "Password",
                    ApplicationName = "Appname"
                }
            };
            return clientMock;
        }

        /// <summary>
        /// Creates mock test client
        /// </summary>
        /// <param name="fileName">The file that is returned</param>
        /// <returns>IClient implementation</returns>
        protected Client CreateMockTestClientApiKeyBasedRequestAsync(string fileName)
        {
            var mockPath = GetMockFilePath(fileName);
            var response = MockFileToString(mockPath);
            //Create a mock interface
            ClientInterfaceSubstitute = Substitute.For<IClient>();
            
            ClientInterfaceSubstitute.RequestAsync(Arg.Any<string>(),
                Arg.Any<string>(), Arg.Any<RequestOptions>(), Arg.Any<HttpMethod>(),
                Arg.Any<CancellationToken>()).Returns(response);
            var config = new Config
            {
                Environment = Model.Environment.Test
            };
            var clientMock = new Client(config)
            {
                HttpClient = ClientInterfaceSubstitute,
                Config = new Config
                {
                    Username = "Username",
                    Password = "Password",
                    ApplicationName = "Appname"
                }
            };
            return clientMock;
        }
		
		/// <summary>
        /// Creates async mock test client
        /// </summary>
        /// <param name="fileName">The file that is returned</param>
        /// <returns>IClient implementation</returns>
        protected Client CreateAsyncMockTestClientApiKeyBasedRequest(string fileName)
        {
            var mockPath = GetMockFilePath(fileName);
            var response = MockFileToString(mockPath);
            
            var configWithApiKey = new Config
            {
                Environment = Model.Environment.Test,
                XApiKey = "AQEyhmfxK....LAG84XwzP5pSpVd"
            };
            
            ClientInterfaceSubstitute = Substitute.For<IClient>();
            
            ClientInterfaceSubstitute.RequestAsync(Arg.Any<string>(),
                Arg.Any<string>(), Arg.Any<RequestOptions>(), Arg.Any<HttpMethod>(),
                Arg.Any<CancellationToken>()).Returns(response);
            
            var config = new Config
            {
                Environment = Model.Environment.Test
            };
            var clientMock = new Client(config)
            {
                HttpClient = ClientInterfaceSubstitute,
                Config = configWithApiKey
            };
            return clientMock;
        }

        /// <summary>
        /// Creates mock test client for POS cloud. In case of cloud api the xapi should be included
        /// </summary>
        /// <param name="fileName">The file that is returned</param>
        /// <returns>IClient implementation</returns>
        protected Client CreateMockTestClientPosCloudApiRequest(string fileName)
        {
            var config = new Config { CloudApiEndPoint = ClientConfig.CloudApiEndPointTest };
            var mockPath = GetMockFilePath(fileName);
            var response = MockFileToString(mockPath);
            
            //Create a mock interface
            ClientInterfaceSubstitute = Substitute.For<IClient>();

            ClientInterfaceSubstitute.Request(Arg.Any<string>(),
                Arg.Any<string>(), Arg.Any<RequestOptions>(), Arg.Any<HttpMethod>()).Returns(response);
            
            ClientInterfaceSubstitute.RequestAsync(Arg.Any<string>(),
                Arg.Any<string>(), Arg.Any<RequestOptions>(), Arg.Any<HttpMethod>()).Returns(Task.FromResult(response));
            
            var anyConfig = new Config
            {
                Environment = Model.Environment.Test
            };
            var clientMock = new Client(anyConfig)
            {
                HttpClient = ClientInterfaceSubstitute,
                Config = config
            };
            return clientMock;
        }

        /// <summary>
        /// Creates mock test client for terminal api.
        /// </summary>
        /// <param name="fileName">The file that is returned</param>
        /// <returns>IClient implementation</returns>
        protected Client CreateMockTestClientPosLocalApiRequest(string fileName)
        {
            var config = new Config
            {
                Environment = Model.Environment.Test,
                LocalTerminalApiEndpoint = @"https://_terminal_:8443/nexo/"
            };
            var mockPath = GetMockFilePath(fileName);
            var response = MockFileToString(mockPath);
            //Create a mock interface
            ClientInterfaceSubstitute = Substitute.For<IClient>();
            
            ClientInterfaceSubstitute.Request(Arg.Any<string>(),
                Arg.Any<string>(), Arg.Any<RequestOptions>(), Arg.Any<HttpMethod>()).Returns(response);
            
            ClientInterfaceSubstitute.RequestAsync(Arg.Any<string>(),
                Arg.Any<string>(), Arg.Any<RequestOptions>(), Arg.Any<HttpMethod>()).Returns(Task.FromResult(response));
            
            
            var anyConfig = new Config
            {
                Environment = Model.Environment.Test
            };
            var clientMock = new Client(anyConfig)
            {
                HttpClient = ClientInterfaceSubstitute,
                Config = config
            };
            return clientMock;
        }
        
        protected string MockFileToString(string fileName)
        {
            string text = "";

            if (String.IsNullOrEmpty(fileName))
            {
                return text;
            }
            try
            {
                using (var streamReader = new StreamReader(fileName, Encoding.UTF8))
                {
                    text = streamReader.ReadToEnd();
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }

            return text;
        }

        /// <summary>
        /// Create dummy Nexo message header
        /// </summary>
        /// <returns></returns>
        protected MessageHeader MockNexoMessageHeaderRequest()
        {
            var header = new MessageHeader
            {
                MessageType = MessageType.Request,
                MessageClass = MessageClassType.Service,
                MessageCategory = MessageCategoryType.Payment,
                SaleID = "POSSystemID12345",
                POIID = "MX915-284251016",

                ServiceID = (new Random()).Next(1, 9999).ToString()
            };
            return header;
        }

        protected static string GetMockFilePath(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                return "";
            }
            var projectPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            var mockPath = Path.Combine(projectPath, fileName);
            return mockPath;
        }
    }
}
