using System.Text.Json;
using Adyen.BalancePlatform.Client;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.CardOrders
{
    [TestClass]
    public class CardOrdersTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public CardOrdersTest()
        {
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureBalancePlatform((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                    });
                })
                .Build();

            _jsonSerializerOptionsProvider = host.Services.GetRequiredService<JsonSerializerOptionsProvider>();
        }

        [TestMethod]
        public void Given_PaginatedGetCardOrderResponse_When_Deserialized_Then_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/PaginatedGetCardOrderResponse.json");

            // Act
            PaginatedGetCardOrderResponse result = JsonSerializer.Deserialize<PaginatedGetCardOrderResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.HasNext);
            Assert.IsFalse(result.HasPrevious);
            Assert.IsNotNull(result.CardOrders);
            Assert.AreEqual(1, result.CardOrders.Count);

            CardOrder order = result.CardOrders[0];
            Assert.AreEqual("UNIQUE_CARD_ORDER_ID", order.Id);
            Assert.AreEqual("UNIQUE_CARD_MANUFACTURER_PROFILE_ID", order.CardManufacturingProfileId);
            Assert.AreEqual("IDEMIA Sittard", order.ServiceCenter);
            Assert.AreEqual(CardOrder.StatusEnum.Closed, order.Status);
            Assert.IsNotNull(order.BeginDate);
            Assert.IsNotNull(order.EndDate);
            Assert.IsNotNull(order.LockDate);
        }

        [TestMethod]
        public void Given_PaginatedGetCardOrderItemResponse_When_Deserialized_Then_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/PaginatedGetCardOrderItemResponse.json");

            // Act
            PaginatedGetCardOrderItemResponse result = JsonSerializer.Deserialize<PaginatedGetCardOrderItemResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsFalse(result.HasNext);
            Assert.IsFalse(result.HasPrevious);
            Assert.IsNotNull(result.Data);
            Assert.AreEqual(1, result.Data.Count);

            CardOrderItem item = result.Data[0];
            Assert.AreEqual("UNIQUE_CARD_ORDER_ITEM_ID", item.CardOrderItemId);
            Assert.AreEqual("UNIQUE_PAYMENT_INSTRUMENT_ID", item.PaymentInstrumentId);
            Assert.AreEqual("Cardholder Post Basic National", item.ShippingMethod);
            Assert.IsNotNull(item.Card);
            Assert.AreEqual(CardOrderItemDeliveryStatus.StatusEnum.Shipped, item.Card.Status);
            Assert.IsNotNull(item.Pin);
            Assert.AreEqual(CardOrderItemDeliveryStatus.StatusEnum.Produced, item.Pin.Status);
        }
    }
}
