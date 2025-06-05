using System;
using System.Net.Http;
using Adyen.HttpClient;
using Adyen.Model.Checkout;
using Adyen.Service;
using Adyen.Service.Checkout;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amount = Adyen.Model.Payment.Amount;
using Card = Adyen.Model.Payment.Card;
using Environment = Adyen.Model.Environment;
using PaymentRequest = Adyen.Model.Payment.PaymentRequest;
using Recurring = Adyen.Model.Payment.Recurring;

namespace Adyen.IntegrationTest
{
    [TestClass]
    public class ErrorTest : BaseTest
    {
        private AdyenClient _adyenClient; 
        private static readonly string MerchantAccount = ClientConstants.MerchantAccount;
        private HttpClientWrapper _httpClientWrapper;

        [TestInitialize]
        public void Init()
        {
            _adyenClient = CreateApiKeyTestClient();
            _httpClientWrapper =
                new HttpClientWrapper(new Config() { Environment = Environment.Test, XApiKey = ClientConstants.Xapikey },
                    new System.Net.Http.HttpClient());
        }

        [TestMethod]
        public void TestClassicPaymentErrorHandling()
        {
            var payments = new PaymentService(_adyenClient);
            var request = new PaymentRequest {
                Amount = new Amount(){
                    Value = 1500,
                    Currency = "EUR"
                },
                Card = new Card(){
                    Number = "4111111111111111",
                    ExpiryMonth = "03",
                    ExpiryYear = "2030",
                    Cvc = "737",
                    HolderName = "John Smith"
                },
                ShopperEmail = "s.hopper@test.com",
                ShopperIP = "61.294.12.12",
                ShopperReference = "test-1234",
                Recurring = new Recurring()
                {
                    Contract = Recurring.ContractEnum.RECURRING
                },
                ShopperInteraction = PaymentRequest.ShopperInteractionEnum.Ecommerce,
                MerchantAccount = MerchantAccount
            };
            try
            {
                payments.Authorise(request);
            }
            catch(HttpClientException ex)
            {
                Assert.AreEqual(ex.ResponseBody, "{\"status\":422,\"errorCode\":\"130\",\"message\":\"Required field 'reference' is not provided.\",\"errorType\":\"validation\"}");
            }
        }
        
        [TestMethod]
        public void TestCheckoutErrorHandling()
        {
            var payments = new PaymentsService(_adyenClient);
            var request = new Model.Checkout.PaymentRequest {
                Amount = new Model.Checkout.Amount(){
                    Value = 1500,
                    Currency = "EUR"
                },
                CountryCode = "NL",
                PaymentMethod = new CheckoutPaymentMethod( new ApplePayDetails(type: ApplePayDetails.TypeEnum.Applepay)),
                Reference = "123456789",
                ShopperReference = "Test-Payment1234",
                ReturnUrl = "https://your-company.com/...",
                MerchantAccount = MerchantAccount
            };
            try
            {
                payments.Payments(request);
            }
            catch(HttpClientException ex)
            {
                Assert.IsTrue(ex.ResponseBody.Contains("{\"status\":422,\"errorCode\":\"14_004\",\"message\":\"Missing payment method details\",\"errorType\":\"validation\""));
            }
        }

        [TestMethod]
        public void TestManagementInvalidParametersHandling()
        {
            var request = @"{""merchantId"": """+ MerchantAccount + @""",
                ""description"": ""City centre store"",
                ""shopperStatement"": ""Springfield Shop"",
                ""phoneNumber"": ""+1813702551707653"",
                ""reference"": ""Spring_store_2"",
                ""address"": {
                    ""country"": ""US"",
                    ""line1"": ""200 Main Street"",
                    ""line2"": ""Building 5A"",
                    ""line3"": ""Suite 3"",
                    ""city"": ""Springfield"",
                    ""stateOrProvince"": ""NY"",
                    ""postalCode"": ""20250""
               }}";
            try
            {
                _httpClientWrapper.RequestAsync("https://management-test.adyen.com/v1/stores", request, null, HttpMethod.Post).GetAwaiter().GetResult();
            }
            catch (HttpClientException ex)
            {
                Assert.IsTrue(ex.ResponseBody.Contains(@"""title"":""Invalid parameters"",""status"":422,"));
            }
        }
        
        [TestMethod]
        public void TestManagementBadRequestHandling()
        {
            try
            {
                _httpClientWrapper.RequestAsync("https://management-test.adyen.com/v1/stores", "{}", null, HttpMethod.Post).GetAwaiter().GetResult();
            }
            catch (HttpClientException ex)
            {
                Assert.IsTrue(ex.ResponseBody.Contains(@"""title"":""Bad request"",""status"":400,""detail"""));
            }
        }
    }
}

