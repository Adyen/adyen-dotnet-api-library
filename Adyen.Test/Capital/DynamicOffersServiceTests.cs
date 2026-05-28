using System.Linq;
using System.Net;
using System.Text;
using Adyen.Core.Options;
using Adyen.Capital.Extensions;
using Adyen.Capital.Models;
using Adyen.Capital.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.Capital
{
    [TestClass]
    public class DynamicOffersServiceTests
    {
        [TestMethod]
        public async Task GetAllDynamicOffersAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/capital/dynamic-offers-success.json");
            var accountHolderId = "AH00000000000000000000001";

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureCapital((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                        options.AdyenApiKey = "test-api-key";
                    });
                    services.AddDynamicOffersService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var dynamicOffersService = testHost.Services.GetRequiredService<IDynamicOffersService>();

            // Act
            var response = await dynamicOffersService.GetAllDynamicOffersAsync(accountHolderId);

            // Assert - response
            Assert.IsTrue(response.TryDeserializeOkResponse(out var result));
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.DynamicOffers.Count);
            Assert.AreEqual("DO00000000000000000000001", result.DynamicOffers[0].Id);
            Assert.AreEqual("AH00000000000000000000001", result.DynamicOffers[0].AccountHolderId);
            Assert.AreEqual("EUR", result.DynamicOffers[0].MinimumAmount.Currency);
            Assert.AreEqual(5000, result.DynamicOffers[0].MinimumAmount.Value);
            Assert.AreEqual("EUR", result.DynamicOffers[0].MaximumAmount.Currency);
            Assert.AreEqual(25000, result.DynamicOffers[0].MaximumAmount.Value);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.IsNotNull(capturedRequest.RequestUri);
            Assert.AreEqual("/capital/v1/dynamicOffers", capturedRequest.RequestUri.AbsolutePath);
            StringAssert.Contains(capturedRequest.RequestUri.Query, $"accountHolderId={accountHolderId}");
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var getValues));
            Assert.AreEqual("test-api-key", getValues.First());
        }

        [TestMethod]
        public async Task CalculatePreliminaryOfferFromDynamicOfferAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/capital/dynamic-offer-calculate-preliminary.json");
            var dynamicOfferId = "DO00000000000000000000001";
            var request = new CalculateGrantOfferRequest { Amount = new Amount { Currency = "EUR", Value = 10000 } };

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(req =>
            {
                capturedRequest = req;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureCapital((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                        options.AdyenApiKey = "test-api-key";
                    });
                    services.AddDynamicOffersService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var dynamicOffersService = testHost.Services.GetRequiredService<IDynamicOffersService>();

            // Act
            var response = await dynamicOffersService.CalculatePreliminaryOfferFromDynamicOfferAsync(dynamicOfferId, request);

            // Assert - response
            Assert.IsTrue(response.TryDeserializeOkResponse(out var result));
            Assert.IsNotNull(result);
            Assert.AreEqual("EUR", result.Amount.Currency);
            Assert.AreEqual(10000, result.Amount.Value);
            Assert.AreEqual("EUR", result.Fee.Amount.Currency);
            Assert.AreEqual(1000, result.Fee.Amount.Value);
            Assert.AreEqual(1000, result.Repayment.BasisPoints);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Post, capturedRequest.Method);
            Assert.IsNotNull(capturedRequest.RequestUri);
            Assert.AreEqual($"/capital/v1/dynamicOffers/{dynamicOfferId}/calculate", capturedRequest.RequestUri.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var calculateValues));
            Assert.AreEqual("test-api-key", calculateValues.First());
        }

        [TestMethod]
        public async Task CreateStaticOfferFromDynamicOfferAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/capital/dynamic-offer-create-static-offer.json");
            var dynamicOfferId = "DO00000000000000000000001";
            var request = new CreateGrantOfferRequest { Amount = new Amount { Currency = "EUR", Value = 10000 } };

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(req =>
            {
                capturedRequest = req;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureCapital((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                        options.AdyenApiKey = "test-api-key";
                    });
                    services.AddDynamicOffersService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var dynamicOffersService = testHost.Services.GetRequiredService<IDynamicOffersService>();

            // Act
            var response = await dynamicOffersService.CreateStaticOfferFromDynamicOfferAsync(dynamicOfferId, request);

            // Assert - response
            Assert.IsTrue(response.TryDeserializeOkResponse(out var result));
            Assert.IsNotNull(result);
            Assert.AreEqual("GO00000000000000000000002", result.Id);
            Assert.AreEqual("AH00000000000000000000001", result.AccountHolderId);
            Assert.AreEqual(GrantOffer.ContractTypeEnum.CashAdvance, result.ContractType);
            Assert.AreEqual("EUR", result.Amount.Currency);
            Assert.AreEqual(10000, result.Amount.Value);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Post, capturedRequest.Method);
            Assert.IsNotNull(capturedRequest.RequestUri);
            Assert.AreEqual($"/capital/v1/dynamicOffers/{dynamicOfferId}/grantOffer", capturedRequest.RequestUri.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var createValues));
            Assert.AreEqual("test-api-key", createValues.First());
        }
    }
}
