using System.Net;
using System.Text;
using Adyen.Core.Options;
using Adyen.Checkout.Extensions;
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;
using Adyen.Checkout.Client;
using Adyen.Core.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.Checkout
{
    [TestClass]
    public class UtilityServiceTest
    {
        public UtilityServiceTest() { }

        private static IHost CreateTestHost(MockDelegatingHandler mockHandler)
        {
            return Host.CreateDefaultBuilder()
                .ConfigureCheckout((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                        options.AdyenApiKey = "ADYEN_API_KEY";
                    });
                    services.AddUtilityService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();
        }

        private static CalculateTaxRequest CreateCalculateTaxRequest()
        {
            return new CalculateTaxRequest
            {
                MerchantAccount = "TestMerchantAccount",
                TaxCalculationContext = new TaxCalculationContext
                {
                    CalculationType = CalculationType.LRSTCS,
                    Lrs = new LrsContext
                    {
                        RemittancePurpose = RemittancePurpose.EDUCATION,
                        SublimitStatus = SublimitStatus.NOTEXCEEDED
                    },
                    TaxCountryCode = "IN"
                },
                TaxableAmount = new TaxableAmount
                {
                    Currency = "INR",
                    Value = 100000L
                }
            };
        }

        private static VerifyShopperTaxIdentificationRequest CreateVerifyShopperTaxIdentificationRequest()
        {
            return new VerifyShopperTaxIdentificationRequest
            {
                MerchantAccount = "TestMerchantAccount",
                ShopperReference = "TestShopperReference",
                ShopperTaxIdentification = new ShopperTaxIdentification
                {
                    TaxIdentificationType = TaxIdentificationType.PAN,
                    TaxCountryCode = "IN",
                    TaxIdentificationNumber = "ABCDE1234F"
                }
            };
        }

        [TestMethod]
        public async Task Given_CalculateTaxRequest_When_CalculateTaxAsync_Then_Posts_To_CalculateTax_And_Returns_TaxCalculation()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkoututility/calculate-tax-success.json");

            HttpRequestMessage? capturedRequest = null;
            string? capturedRequestBody = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                // The request content is disposed after sending, so capture the body here.
                capturedRequestBody = request.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            IHost testHost = CreateTestHost(mockHandler);
            var utilityService = testHost.Services.GetRequiredService<IUtilityService>();

            // Act
            ICalculateTaxApiResponse response = await utilityService.CalculateTaxAsync(
                CreateCalculateTaxRequest(),
                new RequestOptions().AddIdempotencyKey("idempotencyKey"));

            // Assert - response
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.IsTrue(response.IsOk);
            CalculateTaxResponse? calculateTaxResponse = response.Ok();
            Assert.IsNotNull(calculateTaxResponse);
            Assert.AreEqual("TAXCALC1234567890", calculateTaxResponse.TaxCalculationReference);
            Assert.AreEqual("Ab02b4c0!BQHAgM5Mw4Lj4+g82o1fictv2C4pHCX3kK2f4=-oKHnsFfIGT6=-a0f9c8e7d6b5", calculateTaxResponse.TaxCalculationToken);
            Assert.IsNotNull(calculateTaxResponse.TaxCalculation);
            Assert.AreEqual("INR", calculateTaxResponse.TaxCalculation.TotalAmount?.Currency);
            Assert.AreEqual(100000L, calculateTaxResponse.TaxCalculation.TotalAmount?.Value);
            Assert.AreEqual(0L, calculateTaxResponse.TaxCalculation.TotalTaxAmount?.Value, "Zero tax must survive deserialization.");
            Assert.AreEqual(1, calculateTaxResponse.TaxCalculation.TaxCalculations?.Count);
            Assert.AreEqual(CalculationType.LRSTCS, calculateTaxResponse.TaxCalculation.TaxCalculations?[0].Type);
            Assert.AreEqual(CalculationType.LRSTCS, calculateTaxResponse.TaxCalculation.TaxCalculationContext?.CalculationType);
            Assert.AreEqual(RemittancePurpose.EDUCATION, calculateTaxResponse.TaxCalculation.TaxCalculationContext?.Lrs?.RemittancePurpose);
            Assert.AreEqual(SublimitStatus.NOTEXCEEDED, calculateTaxResponse.TaxCalculation.TaxCalculationContext?.Lrs?.SublimitStatus);

            // Assert - HTTP verb, path, and idempotency header
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Post, capturedRequest.Method);
            Assert.AreEqual("/v72/calculateTax", capturedRequest.RequestUri?.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("Idempotency-Key", out IEnumerable<string>? idempotencyValues));
            Assert.AreEqual("idempotencyKey", idempotencyValues?.FirstOrDefault());

            // Assert - serialized request fields use the wire property names and enum values
            Assert.IsNotNull(capturedRequestBody);
            StringAssert.Contains(capturedRequestBody, "\"merchantAccount\":\"TestMerchantAccount\"");
            StringAssert.Contains(capturedRequestBody, "\"calculationType\":\"LRS_TCS\"");
            StringAssert.Contains(capturedRequestBody, "\"remittancePurpose\":\"EDUCATION\"");
            StringAssert.Contains(capturedRequestBody, "\"sublimitStatus\":\"NOT_EXCEEDED\"");
            StringAssert.Contains(capturedRequestBody, "\"taxableAmount\":{\"currency\":\"INR\",\"value\":100000}");
        }

        [TestMethod]
        public async Task Given_UnprocessableContent_Response_When_CalculateTaxAsync_Then_IsUnprocessableContent()
        {
            // Arrange
            const string errorJson = "{\"status\":422,\"errorCode\":\"702\",\"message\":\"Invalid taxable amount\",\"errorType\":\"validation\"}";

            var mockHandler = new MockDelegatingHandler(_ =>
                new HttpResponseMessage(HttpStatusCode.UnprocessableContent)
                {
                    Content = new StringContent(errorJson, Encoding.UTF8, "application/json")
                });

            IHost testHost = CreateTestHost(mockHandler);
            var utilityService = testHost.Services.GetRequiredService<IUtilityService>();

            // Act
            ICalculateTaxApiResponse response = await utilityService.CalculateTaxAsync(CreateCalculateTaxRequest());

            // Assert
            Assert.AreEqual(HttpStatusCode.UnprocessableContent, response.StatusCode);
            Assert.IsFalse(response.IsOk);
            Assert.IsTrue(response.IsUnprocessableContent);
            CheckoutErrorResponseEntity? errorResponse = response.UnprocessableContent();
            Assert.IsNotNull(errorResponse);
            Assert.AreEqual("702", errorResponse.ErrorCode);
            Assert.AreEqual("validation", errorResponse.ErrorType);
        }

        [TestMethod]
        public async Task Given_Valid_Tax_Identification_When_VerifyShopperTaxIdentificationAsync_Then_Posts_And_Returns_Valid_Result()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkoututility/verify-shopper-tax-identification-success.json");

            HttpRequestMessage? capturedRequest = null;
            string? capturedRequestBody = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                // The request content is disposed after sending, so capture the body here.
                capturedRequestBody = request.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            IHost testHost = CreateTestHost(mockHandler);
            var utilityService = testHost.Services.GetRequiredService<IUtilityService>();

            // Act
            IVerifyShopperTaxIdentificationApiResponse response = await utilityService.VerifyShopperTaxIdentificationAsync(CreateVerifyShopperTaxIdentificationRequest());

            // Assert - response
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.IsTrue(response.IsOk);
            VerifyShopperTaxIdentificationResponse? verifyResponse = response.Ok();
            Assert.IsNotNull(verifyResponse);
            Assert.AreEqual(Result.VALID, verifyResponse.Result);
            Assert.AreEqual("TAXVER1234567890", verifyResponse.TaxVerificationReference);
            Assert.AreEqual("Ab02b4c0!BQHAgM5Mw4Lj4+g82o1fictv2C4pHCX3kK2f4=-oKHnsFfIGT6=-b1a2c3d4e5f6", verifyResponse.VerifiedShopperTaxIdentificationToken);
            Assert.IsNotNull(verifyResponse.VerifiedShopperTaxIdentification);
            Assert.AreEqual(TaxIdentificationType.PAN, verifyResponse.VerifiedShopperTaxIdentification.TaxIdentificationType);
            Assert.AreEqual("J*** D**", verifyResponse.VerifiedShopperTaxIdentification.MaskedName);
            Assert.AreEqual("IN", verifyResponse.VerifiedShopperTaxIdentification.TaxCountryCode);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Post, capturedRequest.Method);
            Assert.AreEqual("/v72/verifyShopperTaxIdentification", capturedRequest.RequestUri?.AbsolutePath);

            // Assert - serialized request fields use the wire property names and enum values
            Assert.IsNotNull(capturedRequestBody);
            StringAssert.Contains(capturedRequestBody, "\"shopperReference\":\"TestShopperReference\"");
            StringAssert.Contains(capturedRequestBody, "\"taxIdentificationType\":\"PAN\"");
            StringAssert.Contains(capturedRequestBody, "\"taxIdentificationNumber\":\"ABCDE1234F\"");
        }

        [TestMethod]
        public async Task Given_Invalid_Tax_Identification_When_VerifyShopperTaxIdentificationAsync_Then_Returns_Ok_With_Invalid_Result()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkoututility/verify-shopper-tax-identification-invalid.json");

            var mockHandler = new MockDelegatingHandler(_ =>
                new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                });

            IHost testHost = CreateTestHost(mockHandler);
            var utilityService = testHost.Services.GetRequiredService<IUtilityService>();

            // Act
            IVerifyShopperTaxIdentificationApiResponse response = await utilityService.VerifyShopperTaxIdentificationAsync(CreateVerifyShopperTaxIdentificationRequest());

            // Assert - a declined verification is a business result, not an HTTP error
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.IsTrue(response.IsOk);
            VerifyShopperTaxIdentificationResponse? verifyResponse = response.Ok();
            Assert.IsNotNull(verifyResponse);
            Assert.AreEqual(Result.INVALID, verifyResponse.Result);
            Assert.AreEqual("The tax identification number could not be verified.", verifyResponse.Reason);
            Assert.AreEqual("TAX_IDENTIFICATION_INVALID", verifyResponse.ReasonCode);
            Assert.IsNull(verifyResponse.VerifiedShopperTaxIdentificationToken);
        }

        [TestMethod]
        public async Task Given_BadRequest_Response_When_VerifyShopperTaxIdentificationAsync_Then_IsBadRequest()
        {
            // Arrange
            const string errorJson = "{\"status\":400,\"errorCode\":\"702\",\"message\":\"Missing tax identification number\",\"errorType\":\"validation\"}";

            var mockHandler = new MockDelegatingHandler(_ =>
                new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent(errorJson, Encoding.UTF8, "application/json")
                });

            IHost testHost = CreateTestHost(mockHandler);
            var utilityService = testHost.Services.GetRequiredService<IUtilityService>();

            // Act
            IVerifyShopperTaxIdentificationApiResponse response = await utilityService.VerifyShopperTaxIdentificationAsync(CreateVerifyShopperTaxIdentificationRequest());

            // Assert
            Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode);
            Assert.IsFalse(response.IsOk);
            Assert.IsTrue(response.IsBadRequest);
            CheckoutErrorResponseEntity? errorResponse = response.BadRequest();
            Assert.IsNotNull(errorResponse);
            Assert.AreEqual("702", errorResponse.ErrorCode);
            Assert.AreEqual("Missing tax identification number", errorResponse.Message);
        }
    }
}
