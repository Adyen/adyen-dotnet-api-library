﻿#region License
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
using Adyen.Model.Modification;
using Adyen.Model.Nexo;
using Adyen.Service;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Text;
using Adyen.HttpClient.Interfaces;
using Adyen.Model;
using Environment = System.Environment;
using Amount = Adyen.Model.Amount;
using PaymentResult = Adyen.Model.PaymentResult;
using Adyen.Model.Checkout;

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
            var client = CreateMockTestClientRequest(fileName);
            var payment = new Payment(client);
            var paymentRequest = MockPaymentData.CreateFullPaymentRequest();
            var paymentResult = payment.Authorise(paymentRequest);
            return GetAdditionaData(paymentResult);
        }

        protected PaymentResult CreatePaymentApiKeyBasedResultFromFile(string fileName)
        {
            var client = CreateMockTestClientApiKeyBasedRequest(fileName);
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

        protected AdjustAuthorisationRequest CreateAdjustAuthorisationRequest(string pspReference)
        {
            var adjustAuthorisationRequest = new AdjustAuthorisationRequest()
            {
                MerchantAccount = "MerchantAccount",
                ModificationAmount = new Amount("EUR", 150),
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
            var amount = new Model.Checkout.Amount("USD", 1000);
            var paymentsRequest = new Model.Checkout.PaymentRequest
            {
                Reference = "Your order number ",
                ReturnUrl = @"https://your-company.com/...",
                MerchantAccount = "MerchantAccount",
            };
            paymentsRequest.AddCardData("4111111111111111", "10", "2020", "737", "John Smith");
            return paymentsRequest;
        }

        /// <summary>
        /// Check out Apple Pay payment request
        /// </summary>
        /// <returns></returns>
        public Model.Checkout.PaymentRequest CreateApplePayPaymentRequestCheckout()
        {
            var amount = new Model.Checkout.Amount("USD", 1000);
            var applePay = new Model.Checkout.DefaultPaymentMethodDetails()
            {
                Type = "applepay",
                ApplePayToken = "VNRWtuNlNEWkRCSm1xWndjMDFFbktkQU..."
            };
            var paymentsRequest = new Model.Checkout.PaymentRequest
            {
                Amount = amount,
                Reference = "Your order number ",
                ReturnUrl = @"https://your-company.com/...",
                MerchantAccount = "MerchantAccount",
                PaymentMethod = applePay
            };
            return paymentsRequest;
        }

        /// <summary>
        /// Check out Google Pay payment request
        /// </summary>
        /// <returns></returns>
        public Model.Checkout.PaymentRequest CreateGooglePayPaymentRequestCheckout()
        {
            var amount = new Model.Checkout.Amount("USD", 1000);
            var googlePay = new Model.Checkout.DefaultPaymentMethodDetails()
            {
                Type = "paywithgoogle",
                GooglePayToken = "==Payload as retrieved from Google Pay response=="
            };
            var paymentsRequest = new Model.Checkout.PaymentRequest
            {
                Amount = amount,
                Reference = "Your order number ",
                ReturnUrl = @"https://your-company.com/...",
                MerchantAccount = "MerchantAccount",
                PaymentMethod = googlePay
            };
            return paymentsRequest;
        }

        /// <summary>
        /// 3DS2 payments request
        /// </summary>
        /// <returns></returns>
        public Model.Checkout.PaymentRequest CreatePaymentRequest3DS2()
        {
            var amount = new Model.Checkout.Amount("USD", 1000);
            var paymentsRequest = new Model.Checkout.PaymentRequest
            {
                Reference = "Your order number ",
                Amount = amount,
                ReturnUrl = @"https://your-company.com/...",
                MerchantAccount = "MerchantAccount",
                AdditionalData = new Dictionary<string, string>() { { "allow3DS2", "true" } },
                Channel = Model.Checkout.PaymentRequest.ChannelEnum.Web
            };
            paymentsRequest.AddCardData("4111111111111111", "10", "2020", "737", "John Smith");
            return paymentsRequest;
        }

        /// <summary>
        ///Checkout Details request
        /// </summary>
        /// <returns>Returns a sample PaymentsDetailsRequest object with test data</returns>
        protected Model.Checkout.PaymentsDetailsRequest CreateDetailsRequest()
        {
            string paymentData = "Ab02b4c0!BQABAgCJN1wRZuGJmq8dMncmypvknj9s7l5Tj...";
            var details = new Dictionary<string, string>
            {
                { "MD", "sdfsdfsdf..." },
                { "PaRes", "sdfsdfsdf..." }
            };
            var paymentsDetailsRequest = new Model.Checkout.PaymentsDetailsRequest(Details: details, PaymentData: paymentData);

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
        protected PaymentSessionRequest CreatePaymentSessionRequest()
        {
            return new PaymentSessionRequest(MerchantAccount: "MerchantAccount", Reference: "MerchantReference",
                 Amount: new Model.Checkout.Amount("EUR", 1200), ReturnUrl: @"https://your-company.com/...", CountryCode: "NL",
                 Channel: PaymentSessionRequest.ChannelEnum.Web, SdkVersion: "1.3.0");
        }

        /// <summary>
        /// Checkout paymentResultRequest
        /// </summary>
        /// <returns></returns>
        protected Model.Checkout.PaymentResultRequest CreatePaymentResultRequest()
        {
            string payload = @"Ab0oCC2/wy96FiEMLvoI8RfayxEmZHQZcw...riRbNBzP3pQscLYBHN/MfZkgfGHdqy7JfQoQbRUmA==";
            return new Model.Checkout.PaymentResultRequest(Payload: payload);
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

            clientInterfaceMock.Setup(x => x.Request(It.IsAny<string>(), It.IsAny<string>(), confMock, It.IsAny<bool>(), It.IsAny<RequestOptions>())).Returns(response);
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
        /// <param name="fileName">The file that is returned</param>
        /// <returns>IClient implementation</returns>
        protected Client CreateMockTestClientNullRequiredFieldsRequest(string fileName)
        {
            var mockPath = GetMockFilePath(fileName);
            var response = MockFileToString(mockPath);
            //Create a mock interface
            var clientInterfaceMock = new Mock<IClient>();
            var confMock = MockPaymentData.CreateConfingMock();

            clientInterfaceMock.Setup(x => x.Request(It.IsAny<string>(), It.IsAny<string>(), confMock)).Returns(response);
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
        /// <param name="fileName">The file that is returned</param>
        /// <returns>IClient implementation</returns>
        protected Client CreateMockTestClientApiKeyBasedRequest(string fileName)
        {
            var mockPath = GetMockFilePath(fileName);
            var response = MockFileToString(mockPath);
            //Create a mock interface
            var clientInterfaceMock = new Mock<IClient>();
            var confMock = MockPaymentData.CreateConfingApiKeyBasedMock();
            clientInterfaceMock.Setup(x => x.Request(It.IsAny<string>(),
                It.IsAny<string>(), It.IsAny<Config>(), It.IsAny<bool>(), It.IsAny<RequestOptions>())).Returns(response);
            var clientMock = new Client(It.IsAny<Config>())
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
            var mockPath = GetMockFilePath(fileName);
            var response = MockFileToString(mockPath);
            //Create a mock interface
            var clientInterfaceMock = new Mock<IClient>();
            var confMock = MockPaymentData.CreateConfingApiKeyBasedMock();
            clientInterfaceMock.Setup(x => x.RequestAsync(It.IsAny<string>(),
                    It.IsAny<string>(), It.IsAny<Config>(), It.IsAny<bool>(), It.IsAny<RequestOptions>()))
                .ReturnsAsync(response);
            var clientMock = new Client(It.IsAny<Config>())
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
            var config = new Config { Endpoint = ClientConfig.CloudApiEndPointTest };
            var mockPath = GetMockFilePath(fileName);
            var response = MockFileToString(mockPath);
            //Create a mock interface
            var clientInterfaceMock = new Mock<IClient>();
            clientInterfaceMock.Setup(x => x.Request(It.IsAny<string>(),
                It.IsAny<string>(), config, It.IsAny<bool>(), It.IsAny<RequestOptions>())).Returns(response);
            var clientMock = new Client(It.IsAny<Config>())
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
            var config = new Config { Endpoint = @"https://_terminal_:8443/nexo/" };
            var mockPath = GetMockFilePath(fileName);
            var response = MockFileToString(mockPath);
            //Create a mock interface
            var clientInterfaceMock = new Mock<IClient>();
            clientInterfaceMock.Setup(x => x.Request(It.IsAny<string>(),
                It.IsAny<string>(), config, It.IsAny<bool>(),
                It.IsAny<RequestOptions>()
               ))
                .Returns(response);
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
            var httpClientException =
                new HttpClientException(status, "An error occured", new WebHeaderCollection(), response);

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
        protected AuthenticationResultRequest CreateAuthenticationResultRequest()
        {
            return new AuthenticationResultRequest
            {
                MerchantAccount = "MerchantAccount",
                PspReference = "pspReference"
            };
        }


        /// <summary>
        /// Create dummy CreatePaymentLinkRequest
        /// </summary>
        /// <returns>CreatePaymentLinkRequest</returns>
        protected CreatePaymentLinkRequest CreatePaymentLinkRequestSuccess()
        {
            return new CreatePaymentLinkRequest()
            {
                Reference = "YOUR_REFERENCE_NUMBER",
                Amount = new Model.Checkout.Amount("EUR", 100),
                CountryCode = "GR",
                MerchantAccount = "MerchantAccount",
                ShopperReference = "ShopperReference",
                ShopperEmail = "info@ShopperEmail.com",
                ShopperLocale = "GR",
                ExpiresAt = "2019-12-17T10:59:29",
                BillingAddress = new Model.Checkout.Address(Country: "GR"),
                DeliveryAddress = new Model.Checkout.Address(Country: "GR"),
            };
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
