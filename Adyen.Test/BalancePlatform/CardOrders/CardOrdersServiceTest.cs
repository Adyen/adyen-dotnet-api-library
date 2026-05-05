using System.Net;
using System.Text;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;
using Adyen.Core;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.CardOrders
{
    [TestClass]
    public class CardOrdersServiceTest
    {
        public CardOrdersServiceTest() { }

        [TestMethod]
        public async Task ListCardOrdersAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/PaginatedGetCardOrderResponse.json");

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
                .ConfigureBalancePlatform((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddCardOrdersService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var cardOrdersService = testHost.Services.GetRequiredService<ICardOrdersService>();

            // Act
            IListCardOrdersApiResponse response = await cardOrdersService.ListCardOrdersAsync();

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            PaginatedGetCardOrderResponse? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.IsTrue(result.HasNext);
            Assert.IsFalse(result.HasPrevious);
            Assert.IsNotNull(result.CardOrders);
            Assert.AreEqual(1, result.CardOrders.Count);
            Assert.AreEqual("UNIQUE_CARD_ORDER_ID", result.CardOrders[0].Id);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/cardorders", capturedRequest.RequestUri?.AbsolutePath);
        }

        [TestMethod]
        public async Task ListCardOrdersAsync_WithStatusFilter_Includes_Status_In_QueryString()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/PaginatedGetCardOrderResponse.json");

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
                .ConfigureBalancePlatform((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddCardOrdersService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var cardOrdersService = testHost.Services.GetRequiredService<ICardOrdersService>();

            // Act
            IListCardOrdersApiResponse response = await cardOrdersService.ListCardOrdersAsync(status: new Option<string>("closed"));

            // Assert - response
            Assert.IsTrue(response.IsOk);

            // Assert - HTTP verb, path and query string
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/cardorders", capturedRequest.RequestUri?.AbsolutePath);
            string query = capturedRequest.RequestUri!.Query;
            Assert.IsTrue(query.Contains("status=closed"), $"Expected 'status=closed' in query, but was: {query}");
        }

        [TestMethod]
        public async Task GetCardOrderItemsAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/PaginatedGetCardOrderItemResponse.json");

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
                .ConfigureBalancePlatform((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddCardOrdersService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var cardOrdersService = testHost.Services.GetRequiredService<ICardOrdersService>();

            // Act
            IGetCardOrderItemsApiResponse response = await cardOrdersService.GetCardOrderItemsAsync("UNIQUE_CARD_ORDER_ID");

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            PaginatedGetCardOrderItemResponse? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.IsFalse(result.HasNext);
            Assert.IsFalse(result.HasPrevious);
            Assert.IsNotNull(result.Data);
            Assert.AreEqual(1, result.Data.Count);
            Assert.AreEqual("UNIQUE_CARD_ORDER_ITEM_ID", result.Data[0].CardOrderItemId);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/cardorders/UNIQUE_CARD_ORDER_ID/items", capturedRequest.RequestUri?.AbsolutePath);
        }
    }
}
