using Adyen.EcommLibrary.Constants;
using Adyen.EcommLibrary.HttpClientHandler;
using Adyen.EcommLibrary.HttpClientHandler.Interfaces;
<<<<<<< HEAD
using Adyen.EcommLibrary.Model.Modification;
using Adyen.EcommLibrary.Model.Nexo;
=======

using Adyen.EcommLibrary.Model.Enum;
using Adyen.EcommLibrary.Model.Modification;
using Adyen.EcommLibrary.Model.Nexo.Message;
>>>>>>> c8d8d7aa0e209a3eb009ca5104afd52e2233b372
using Adyen.EcommLibrary.Service;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
<<<<<<< HEAD
=======
using Adyen.EcommLibrary.Model.Nexo;
using Adyen.EcommLibrary.Model;
>>>>>>> c8d8d7aa0e209a3eb009ca5104afd52e2233b372
using Environment = System.Environment;

namespace Adyen.EcommLibrary.Test
{
    public class BaseTest
    {

        #region Payment request
        public Model.PaymentResult CreatePaymentResultFromFile(string fileName)
        {
            var client = CreateMockTestClientRequest(fileName);
            var payment = new Payment(client);
            var paymentRequest = MockPaymentData.CreateFullPaymentRequest();

            var paymentResult = payment.Authorise(paymentRequest);
            return GetAdditionaData(paymentResult);
        }

        #endregion

        #region Modification objects

        protected CaptureRequest CreateCaptureTestRequest(string pspReference)
        {
            var captureRequest = new CaptureRequest
            {
                MerchantAccount = "MerchantAccount",
                ModificationAmount = new Model.Amount("EUR", 150),
                Reference = "capture - " + DateTime.Now.ToString("yyyyMMdd"),
                OriginalReference = pspReference
            };
            return captureRequest;
        }


        protected CancelOrRefundRequest CreateCancelOrRefundTestRequest(string pspReference)
        {
            var cancelOrRefundRequest = new CancelOrRefundRequest()
            {
                MerchantAccount = "MerchantAccount",
                Reference = "cancelOrRefund - " + DateTime.Now.ToString("yyyyMMdd"),
                OriginalReference = pspReference
            };
            return cancelOrRefundRequest;
        }

        protected RefundRequest CreateRefundTestRequest(string pspReference)
        {
            var refundRequest = new RefundRequest()
            {
                MerchantAccount = "MerchantAccount",
                ModificationAmount = new Model.Amount("EUR", 150),
                Reference = "refund - " + DateTime.Now.ToString("yyyyMMdd"),
                OriginalReference = pspReference
            };
            return refundRequest;
        }

        protected CancelRequest CreateCancelTestRequest(string pspReference)
        {
            var cancelRequest = new CancelRequest()
            {
                MerchantAccount = "MerchantAccount",
                Reference = "cancel - " + DateTime.Now.ToString("yyyyMMdd"),
                OriginalReference = pspReference
            };
            return cancelRequest;
        }

        protected static Dictionary<string, string> CreateAdditionalData()
        {
            return new Dictionary<string, string>
            {
                { "liabilityShift", "true"},
                { "fraudResultType", "GREEN"},
                { "authCode", "43733"},
                { "avsResult", "4 AVS not supported for this card type"}
            };
        }
        #endregion

        /// <summary>
        /// Creates mock test client 
        /// </summary>
        /// <param name="fileName">The file that is returned</param>
        /// <returns>IClient implementation</returns>
        protected Client CreateMockTestClientRequest(string fileName)
        {
            var mockPath = GetMockFilePath(fileName);
            var response = MockFileToString(mockPath);
            //Create a mock interface
            var clientInterfaceMock = new Mock<IClient>();
            var confMock = MockPaymentData.CreateConfingMock();
            clientInterfaceMock.Setup(x => x.Request(It.IsAny<string>(),
                It.IsAny<string>(), confMock)).Returns(response);
            var clientMock = new Client(It.IsAny<Config>())
            {
                HttpClient = clientInterfaceMock.Object,
                Config = confMock
            };
            return clientMock;
        }

        /// <summary>
<<<<<<< HEAD
        /// Creates mock test client for pos cloud and terminal api. In case of cloud api the xapi should be included
        /// </summary>
        /// <param name="fileName">The file that is returned</param>
        /// <returns>IClient implementation</returns>
        protected Client CreateMockTestClientPosApiRequest(string fileName)
        {
            var config = new Config();
=======
        /// Creates mock test client for pos cloud api. In that case the xapi should be included
        /// </summary>
        /// <param name="fileName">The file that is returned</param>
        /// <param name="config">config file includes XApiKey</param>
        /// <returns>IClient implementation</returns>
        protected Client CreateMockTestClientCloudAPiRequest(string fileName,Config config)
        {
>>>>>>> c8d8d7aa0e209a3eb009ca5104afd52e2233b372
            var mockPath = GetMockFilePath(fileName);
            var response = MockFileToString(mockPath);
            //Create a mock interface
            var clientInterfaceMock = new Mock<IClient>();
            clientInterfaceMock.Setup(x => x.Request(It.IsAny<string>(),
                It.IsAny<string>(), config)).Returns(response);
            var clientMock = new Client(It.IsAny<Config>())
            {
                HttpClient = clientInterfaceMock.Object,
                Config = config
            };
            return clientMock;
        }

        /// <summary>
        /// Creates mock test client 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        protected Client CreateMockTestClientPost(string fileName)
        {
            var mockPath = GetMockFilePath(fileName);
            var response = MockFileToString(mockPath);
            //Create a mock interface
            var clientInterfaceMock = new Mock<IClient>();
            var confMock = MockPaymentData.CreateConfingMock();

            clientInterfaceMock.Setup(x => x.Post(It.IsAny<string>(),
                It.IsAny<Dictionary<string, string>>(), confMock)).Returns(response);
            var clientMock = new Client(It.IsAny<Config>())
            {
                HttpClient = clientInterfaceMock.Object,
                Config = confMock
            };
            return clientMock;
        }

        /// <summary>
        /// Creates mock test client errors
        /// </summary>
        /// <param name="status"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        protected Client CreateMockTestClientForErrors(int status, string fileName)
        {
            var mockPath = GetMockFilePath(fileName);
            var response = MockFileToString(mockPath);
            //Create a mock interface
            var clientInterfaceMock = new Mock<IClient>();
            var confMock = MockPaymentData.CreateConfingMock();
            var httpClientException = new HttpClientException(status, "An error occured", new Dictionary<string, List<string>>(), response);

            clientInterfaceMock.Setup(x => x.Request(It.IsAny<string>(),
                It.IsAny<string>(), confMock)).Throws(httpClientException);

            var clientMock = new Client(It.IsAny<Config>())
            {
                HttpClient = clientInterfaceMock.Object,
                Config = confMock
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
            return new MessageHeader
            {
                MessageType = "Request",
                MessageClass = "Service",
                MessageCategory = "Payment",
                SaleID = "POSSystemID12345",
                POIID = "MX915-284251016",
                ProtocolVersion = "3.0",
                ServiceID = (new Random()).Next(1, 9999).ToString()
            };
        }

       
        private Model.PaymentResult GetAdditionaData(Model.PaymentResult paymentResult)
        {
            var paymentResultAdditionalData = paymentResult.AdditionalData;

            foreach (var additionalData in paymentResultAdditionalData)
            {
                switch (additionalData.Key)
                {
                    case AdditionalData.AvsResult:
                        paymentResult.AvsResult = additionalData.Value;
                        break;
                    case AdditionalData.PaymentMethod:
                        paymentResult.PaymentMethod = additionalData.Value;
                        break;
                    case AdditionalData.BoletoData:
                        paymentResult.BoletoData = additionalData.Value;
                        break;
                    case AdditionalData.CardBin:
                        paymentResult.CardBin = additionalData.Value;
                        break;
                    case AdditionalData.CardHolderName:
                        paymentResult.CardHolderName = additionalData.Value;
                        break;
                }
            }
            return paymentResult;
        }

        protected static string GetMockFilePath(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                return "";
            }
            var projectPath = System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            var mockPath = Path.Combine(projectPath, fileName);
            return mockPath;
        }
    }
}
