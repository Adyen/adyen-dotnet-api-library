#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using Adyen.Constants;
using Adyen.HttpClient;
using Adyen.Model.Payments;
using Adyen.Model.Nexo;
using Adyen.Service;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using Adyen.HttpClient.Interfaces;
using Adyen.Model;
using Environment = System.Environment;
using Amount = Adyen.Model.Amount;
using PaymentResult = Adyen.Model.Payments.PaymentResult;
using Adyen.Model.Checkout;
using System.Threading.Tasks;
using CardDetails = Adyen.Service.Resource.Checkout.CardDetails;
using CommonField = Adyen.Model.Checkout.CommonField;
using PaymentRequest = Adyen.Model.Payments.PaymentRequest;

namespace Adyen.Test
{
    public class BaseTest
    {

        #region Payment request 
        /// <summary>
        /// Payment with basic authentication
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        protected PaymentResult CreatePaymentResultFromFile(string fileName)
        {
            Client client = CreateMockTestClientRequest(fileName);
            Payment payment = new Payment(client);
            PaymentRequest paymentRequest = MockPaymentData.CreateFullPaymentRequest();
            PaymentResult paymentResult = payment.Authorise(paymentRequest);
            return paymentResult;
        }

        protected PaymentResult CreatePaymentApiKeyBasedResultFromFile(string fileName)
        {
            Client client = CreateMockTestClientApiKeyBasedRequest(fileName);
            Payment payment = new Payment(client);
            PaymentRequest paymentRequest = MockPaymentData.CreateFullPaymentRequest();

            PaymentResult paymentResult = payment.Authorise(paymentRequest);
            return paymentResult;
        }
        #endregion

        #region Modification objects

        protected CaptureRequest CreateCaptureTestRequest(string pspReference)
        {
            CaptureRequest captureRequest = new CaptureRequest
            {
                MerchantAccount = "MerchantAccount",
                ModificationAmount = new Model.Payments.Amount("EUR", 150),
                Reference = "capture - " + DateTime.Now.ToString("yyyyMMdd"),
                OriginalReference = pspReference,
                AdditionalData = new Dictionary<string, string> {{"authorisationType", "PreAuth"}}
            };
            return captureRequest;
        }


        protected CancelOrRefundRequest CreateCancelOrRefundTestRequest(string pspReference)
        {
            CancelOrRefundRequest cancelOrRefundRequest = new CancelOrRefundRequest()
            {
                MerchantAccount = "MerchantAccount",
                Reference = "cancelOrRefund - " + DateTime.Now.ToString("yyyyMMdd"),
                OriginalReference = pspReference
            };
            return cancelOrRefundRequest;
        }

        protected RefundRequest CreateRefundTestRequest(string pspReference)
        {
            RefundRequest refundRequest = new RefundRequest()
            {
                MerchantAccount = "MerchantAccount",
                ModificationAmount = new Model.Payments.Amount("EUR", 150),
                Reference = "refund - " + DateTime.Now.ToString("yyyyMMdd"),
                OriginalReference = pspReference
            };
            return refundRequest;
        }

        protected CancelRequest CreateCancelTestRequest(string pspReference)
        {
            CancelRequest cancelRequest = new CancelRequest()
            {
                MerchantAccount = "MerchantAccount",
                Reference = "cancel - " + DateTime.Now.ToString("yyyyMMdd"),
                OriginalReference = pspReference
            };
            return cancelRequest;
        }

        protected AdjustAuthorisationRequest CreateAdjustAuthorisationRequest(string pspReference)
        {
            AdjustAuthorisationRequest adjustAuthorisationRequest = new AdjustAuthorisationRequest()
            {
                MerchantAccount = "MerchantAccount",
                ModificationAmount = new Model.Payments.Amount("EUR", 150),
                Reference = "adjustAuthorisationRequest - " + DateTime.Now.ToString("yyyyMMdd"),
                OriginalReference = pspReference,
            };
            return adjustAuthorisationRequest;
        }
        #endregion

        #region Checkout
        /// <summary>
        /// Check out payment request
        /// </summary>
        /// <param name="merchantAccount"></param>
        /// <returns></returns>
        public Model.Checkout.PaymentRequest CreatePaymentRequestCheckout()
        {
            Model.Checkout.Amount amount = new Model.Checkout.Amount("USD", 1000);
            Model.Checkout.PaymentRequest paymentsRequest = new Model.Checkout.PaymentRequest
            {
                Reference = "Your order number ",
                ReturnUrl = @"https://your-company.com/...",
                MerchantAccount = "MerchantAccount",
            };
            Model.Checkout.CardDetails cardDetails = new Model.Checkout.CardDetails()
            {
                Number = "4111111111111111",
                ExpiryMonth = "10",
                ExpiryYear = "2020",
                HolderName = "John Smith"
            };
            paymentsRequest.PaymentMethod = new PaymentDonationRequestPaymentMethod(cardDetails);
            paymentsRequest.ApplicationInfo = new Model.Checkout.ApplicationInfo(adyenLibrary: new CommonField());
            return paymentsRequest;
        }
        
       
        /// <summary>
        /// 3DS2 payments request
        /// </summary>
        /// <returns></returns>
        public Model.Checkout.PaymentRequest CreatePaymentRequest3DS2()
        {
            Model.Checkout.Amount amount = new Model.Checkout.Amount("USD", 1000);
            Model.Checkout.PaymentRequest paymentsRequest = new Model.Checkout.PaymentRequest
            {
                Reference = "Your order number ",
                Amount = amount,
                ReturnUrl = @"https://your-company.com/...",
                MerchantAccount = "MerchantAccount",
                Channel = Model.Checkout.PaymentRequest.ChannelEnum.Web
            };
            Model.Checkout.CardDetails cardDetails = new Model.Checkout.CardDetails()
            {
                Number = "4111111111111111",
                ExpiryMonth = "10",
                ExpiryYear = "2020",
                HolderName = "John Smith"
            };
            paymentsRequest.PaymentMethod = new PaymentDonationRequestPaymentMethod(cardDetails);
            return paymentsRequest;
        }

        /// <summary>
        ///Checkout Details request
        /// </summary>
        /// <returns>Returns a sample PaymentsDetailsRequest object with test data</returns>
        protected DetailsRequest CreateDetailsRequest()
        {
            string paymentData = "Ab02b4c0!BQABAgCJN1wRZuGJmq8dMncmypvknj9s7l5Tj...";
            PaymentCompletionDetails details = new PaymentCompletionDetails()
            {
                MD= "sdfsdfsdf...",
                PaReq = "sdfsdfsdf..."
            };
            DetailsRequest paymentsDetailsRequest = new DetailsRequest(details: details, paymentData: paymentData);

            return paymentsDetailsRequest;
        }

        /// <summary>
        /// Checkout paymentMethodsRequest
        /// </summary>
        /// <returns></returns>
        protected PaymentMethodsRequest CreatePaymentMethodRequest(string merchantAccount)
        {
            return new PaymentMethodsRequest(merchantAccount: merchantAccount);
        }

        /// <summary>
        /// Checkout paymentsessionRequest
        /// </summary>
        /// <returns></returns>
        protected PaymentSetupRequest CreatePaymentSetupRequest()
        {
            return new PaymentSetupRequest(merchantAccount: "MerchantAccount", reference: "MerchantReference",
                 amount: new Model.Checkout.Amount("EUR", 1200), returnUrl: @"https://your-company.com/...", countryCode: "NL",
                 channel: PaymentSetupRequest.ChannelEnum.Web, sdkVersion: "1.3.0");
        }

        /// <summary>
        /// Checkout paymentResultRequest
        /// </summary>
        /// <returns></returns>
        protected PaymentVerificationRequest CreatePaymentVerificationRequest()
        {
            string payload = @"Ab0oCC2/wy96FiEMLvoI8RfayxEmZHQZcw...riRbNBzP3pQscLYBHN/MfZkgfGHdqy7JfQoQbRUmA==";
            return new PaymentVerificationRequest(payload: payload);
        }

        #endregion

        /// <summary>
        /// Creates mock test client 
        /// </summary>
        /// <param name="fileName">The file that is returned</param>
        /// <returns>IClient implementation</returns>
        protected Client CreateMockTestClientRequest(string fileName)
        {
            string mockPath = GetMockFilePath(fileName);
            string response = MockFileToString(mockPath);
            //Create a mock interface
            Mock<IClient> clientInterfaceMock = new Mock<IClient>();
            Config confMock = MockPaymentData.CreateConfigMock();

            clientInterfaceMock.Setup(x => x.Request(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<RequestOptions>(), null)).Returns(response);
            Config config = new Config()
            {
                Environment = It.IsAny<Model.Enum.Environment>()
            };
            Client clientMock = new Client(config)
            {
                HttpClient = clientInterfaceMock.Object,
                Config = confMock
            };
            return clientMock;
        }

        /// <summary>
        /// Creates mock test client 
        /// </summary>
        /// <param name="fileName">The file that is returned</param>
        /// <returns>IClient implementation</returns>
        protected Client CreateMockTestClientNullRequiredFieldsRequest(string fileName)
        {
            string mockPath = GetMockFilePath(fileName);
            string response = MockFileToString(mockPath);
            //Create a mock interface
            Mock<IClient> clientInterfaceMock = new Mock<IClient>();
            Config confMock = MockPaymentData.CreateConfigMock();

            clientInterfaceMock.Setup(x => x.Request(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<RequestOptions>(), null)).Returns(response);
            clientInterfaceMock.Setup(x => x.Request(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<RequestOptions>(), null)).Returns(response);
            clientInterfaceMock.Setup(x => x.RequestAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<RequestOptions>(), null)).Returns(Task.FromResult(response));
            Config config = new Config()
            {
                Environment = It.IsAny<Model.Enum.Environment>()
            };
            Client clientMock = new Client(config)
            {
                HttpClient = clientInterfaceMock.Object,
                Config = confMock
            };
            return clientMock;
        }

        /// <summary>
        /// Creates mock test client 
        /// </summary>
        /// <param name="fileName">The file that is returned</param>
        /// <returns>IClient implementation</returns>
        protected Client CreateMockTestClientApiKeyBasedRequest(string fileName)
        {
            string mockPath = GetMockFilePath(fileName);
            string response = MockFileToString(mockPath);
            //Create a mock interface
            Mock<IClient> clientInterfaceMock = new Mock<IClient>();
            Config confMock = MockPaymentData.CreateConfigApiKeyBasedMock();
            clientInterfaceMock.Setup(x => x.Request(It.IsAny<string>(),
                It.IsAny<string>(), It.IsAny<RequestOptions>(), null)).Returns(response);
            Config config = new Config()
            {
                Environment = It.IsAny<Model.Enum.Environment>()
            };
            Client clientMock = new Client(config)
            {
                HttpClient = clientInterfaceMock.Object,
                Config = confMock
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
            string mockPath = GetMockFilePath(fileName);
            string response = MockFileToString(mockPath);
            //Create a mock interface
            Mock<IClient> clientInterfaceMock = new Mock<IClient>();
            Config confMock = MockPaymentData.CreateConfigApiKeyBasedMock();
            clientInterfaceMock.Setup(x => x.RequestAsync(It.IsAny<string>(),
                It.IsAny<string>(), It.IsAny<RequestOptions>(), It.IsAny<HttpMethod>())).ReturnsAsync(response);
            Config config = new Config()
            {
                Environment = It.IsAny<Model.Enum.Environment>()
            };
            Client clientMock = new Client(config)
            {
                HttpClient = clientInterfaceMock.Object,
                Config = confMock
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
            string mockPath = GetMockFilePath(fileName);
            string response = MockFileToString(mockPath);
            //Create a mock interface
            Mock<IClient> clientInterfaceMock = new Mock<IClient>();
            Config confMock = MockPaymentData.CreateConfigApiKeyBasedMock();
            clientInterfaceMock.Setup(x => x.RequestAsync(It.IsAny<string>(),
                    It.IsAny<string>(), It.IsAny<RequestOptions>(), null))
                .ReturnsAsync(response);
            Config config = new Config()
            {
                Environment = It.IsAny<Model.Enum.Environment>()
            };
            Client clientMock = new Client(config)
            {
                HttpClient = clientInterfaceMock.Object,
                Config = confMock
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
            Config config = new Config { CloudApiEndPoint = ClientConfig.CloudApiEndPointTest };
            string mockPath = GetMockFilePath(fileName);
            string response = MockFileToString(mockPath);
            //Create a mock interface
            Mock<IClient> clientInterfaceMock = new Mock<IClient>();
            clientInterfaceMock.Setup(x => x.Request(It.IsAny<string>(),
                It.IsAny<string>(), It.IsAny<RequestOptions>(), null)).Returns(response);
            Config anyConfig = new Config()
            {
                Environment = It.IsAny<Model.Enum.Environment>()
            };
            Client clientMock = new Client(anyConfig)
            {
                HttpClient = clientInterfaceMock.Object,
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
            Config config = new Config { Endpoint = @"https://_terminal_:8443/nexo/" };
            string mockPath = GetMockFilePath(fileName);
            string response = MockFileToString(mockPath);
            //Create a mock interface
            Mock<IClient> clientInterfaceMock = new Mock<IClient>();
            clientInterfaceMock.Setup(x => x.Request(It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<RequestOptions>(), null
               ))
                .Returns(response);
            Config anyConfig = new Config()
            {
                Environment = It.IsAny<Model.Enum.Environment>()
            };
            Client clientMock = new Client(anyConfig)
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
            string mockPath = GetMockFilePath(fileName);
            string response = MockFileToString(mockPath);
            //Create a mock interface
            Mock<IClient> clientInterfaceMock = new Mock<IClient>();
            Config confMock = MockPaymentData.CreateConfigMock();

            clientInterfaceMock.Setup(x => x.Post(It.IsAny<string>(),
                It.IsAny<Dictionary<string, string>>())).Returns(response);
            Config config = new Config()
            {
                Environment = It.IsAny<Model.Enum.Environment>()
            };
            Client clientMock = new Client(config)
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
        protected Client CreateAsyncMockTestClientForErrors(int status, string fileName)
        {
            string mockPath = GetMockFilePath(fileName);
            string response = MockFileToString(mockPath);
            //Create a mock interface
            Mock<IClient> clientInterfaceMock = new Mock<IClient>();
            Config confMock = MockPaymentData.CreateConfigMock();
            HttpClientException httpClientException =
                new HttpClientException(status, "An error occured", new WebHeaderCollection(), response);

            clientInterfaceMock.Setup(x => x.RequestAsync(It.IsAny<string>(),
                It.IsAny<string>(), It.IsAny<RequestOptions>(), null)).Throws(httpClientException);
            Config config = new Config()
            {
                Environment = It.IsAny<Model.Enum.Environment>()
            };
            Client clientMock = new Client(config)
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
            string mockPath = GetMockFilePath(fileName);
            string response = MockFileToString(mockPath);
            //Create a mock interface
            Mock<IClient> clientInterfaceMock = new Mock<IClient>();
            Config confMock = MockPaymentData.CreateConfigMock();
            HttpClientException httpClientException =
                new HttpClientException(status, "An error occured", new WebHeaderCollection(), response);

            clientInterfaceMock.Setup(x => x.Request(It.IsAny<string>(),
                It.IsAny<string>(), It.IsAny<RequestOptions>(), null)).Throws(httpClientException);
            Config config = new Config()
            {
                Environment = It.IsAny<Model.Enum.Environment>()
            };
            Client clientMock = new Client(config)
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
                using (StreamReader streamReader = new StreamReader(fileName, Encoding.UTF8))
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
        /// Helper for file reading
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public string GetFileContents(string fileName)
        {
            string mockPath = GetMockFilePath(fileName);
            return MockFileToString(mockPath);
        }


        /// <summary>
        /// Create dummy Nexo message header
        /// </summary>
        /// <returns></returns>
        protected MessageHeader MockNexoMessageHeaderRequest()
        {
            MessageHeader header = new MessageHeader
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

        /// <summary>
        /// Create dummy VoidPendingRefundRequest
        /// </summary>
        /// <returns>VoidPendingRefundRequest</returns>
        protected VoidPendingRefundRequest CreateVoidPendingRefundRequest()
        {
            return new VoidPendingRefundRequest
            {
                TenderReference = "TenderReference"
            };
        }

        /// <summary>
        /// Create dummy AuthenticationResultRequest
        /// </summary>
        /// <returns>AuthenticationResultRequest</returns>
        protected Model.Payments.AuthenticationResultRequest CreateAuthenticationResultRequest()
        {
            return new Model.Payments.AuthenticationResultRequest
            {
                MerchantAccount = "MerchantAccount",
                PspReference = "pspReference"
            };
        }

        protected static string GetMockFilePath(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                return "";
            }
            string projectPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string mockPath = Path.Combine(projectPath, fileName);
            return mockPath;
        }
    }
}
