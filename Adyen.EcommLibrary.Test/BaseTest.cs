using Adyen.EcommLibrary.Constants;
using Adyen.EcommLibrary.HttpClient;
using Adyen.EcommLibrary.HttpClient.Interfaces;
using Adyen.EcommLibrary.Model;
using Adyen.EcommLibrary.Model.Modification;
using Adyen.EcommLibrary.Service;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Adyen.EcommLibrary.Model.Enum;
using Adyen.EcommLibrary.Model.Nexo.Message;
using Environment = System.Environment;

namespace Adyen.EcommLibrary.Test
{
    public class BaseTest
    {

        #region Payment request
        public PaymentResult CreatePaymentResultFromFile(string fileName)
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
                ModificationAmount = new Amount("EUR", 150),
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
                ModificationAmount = new Amount("EUR", 150),
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
        /// <param name="fileName"></param>
        /// <returns></returns>
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


        //Nexo

        /// <summary>
        /// Create dummy Nexo message header
        /// </summary>
        /// <returns></returns>
        protected MessageHeader MockNexoMessageHeaderRequest()
        {

            return new MessageHeader
            {

                MessageType = MessageType.Request,
                MessageClass = MessageClass.Service,
                MessageCategory = MessageCategory.Payment,
                SaleID = "John",
                POIID = "MX915-284251016",
                ProtocolVersion = "3.0",
                ServiceID = (new Random()).Next(1, 9999).ToString()

            };
        }
        
        /// <summary>
        /// Returns dummy Nexo json request
        /// </summary>
        /// <returns></returns>
        protected string MockNexoJsonRequest()
        {
            return "{\r\n\t\"SaleToPOIRequest\" : {\r\n\t\t\"MessageHeader\" : {\r\n\t\t\t\"ProtocolVersion\" : \"3.0\",\r\n\t\t\t\"MessageClass\" : " +
                   "\"Service\",\r\n\t\t\t\"MessageCategory\" : \"Payment\",\r\n\t\t\t\"MessageType\" : \"Request\",\r\n\t\t\t\"ServiceID\" : \"6487\",\r\n\t\t\t\"SaleID\" : \"John\"," +
                   "\r\n\t\t\t\"POIID\" : \"MX915-284251016\"\r\n\t\t},\r\n\t\t\"PaymentRequest\" : {\r\n\t\t\t\"SaleData\" : " +
                   "{\r\n\t\t\t\t\"SaleTransactionID\" : {\r\n\t\t\t\t\t\"TransactionID\" : \"22485\",\r\n\t\t\t\t\t\"TimeStamp\" : \"2018-05-23T12:09:19\"\r\n\t\t\t\t}," +
                   "\r\n\t\t\t\t\"SaleReferenceID\" : \"SalesRefABC\",\r\n\t\t\t\t\"TokenRequestedType\" : \"Customer\"\r\n\t\t\t},\r\n\t\t\t\"PaymentTransaction\" : " +
                   "{\r\n\t\t\t\t\"AmountsReq\" : {\r\n\t\t\t\t\t\"Currency\" : \"EUR\",\r\n\t\t\t\t\t\"RequestedAmount\" : 10.99\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t}\r\n\t}\r\n}\r\n";
        }
        

        private PaymentResult GetAdditionaData(PaymentResult paymentResult)
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

        private static string GetMockFilePath(string fileName)
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
