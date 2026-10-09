using Adyen.TransactionWebhooks.Extensions;
using Adyen.TransactionWebhooks.Models;
using Adyen.TransactionWebhooks.Handlers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Hosting;

namespace Adyen.Test.TransactionWebhooks
{
    [TestClass]
    public class TransactionWebhooksTest
    {
        private static IHost _host;
        private static ITransactionWebhooksHandler _transactionWebhooksHandler;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            _host = Host.CreateDefaultBuilder()
                .ConfigureTransactionWebhooks((ctx, services, config) =>
                {
                    services.AddTransactionWebhooksHandler();
                })
                .Build();

            _transactionWebhooksHandler = _host.Services.GetRequiredService<ITransactionWebhooksHandler>();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            _host?.Dispose();
        }

        [TestMethod]
        public void Given_Deserialize_When_Transaction_Created_With_IssuedCard_Returns_Correct_Values()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/transactionwebhooks/balancePlatform.transaction.created.issuedCard.json");

            // Act
            TransactionNotificationRequestV4 r = _transactionWebhooksHandler.DeserializeTransactionNotificationRequestV4(json);

            // Assert
            Assert.IsNotNull(r);
            Assert.AreEqual(TransactionNotificationRequestV4.TypeEnum.BalancePlatformTransactionCreated, r.Type);
            Assert.AreEqual("test", r.Environment);
            Assert.AreEqual("EVJN00000000000000000000000004USD", r.Data.Id);

            // Issued card category data including the networkVariant
            Assert.IsNotNull(r.Data.Transfer);
            Assert.AreEqual("3JNC3O5ZVFLLGV4C", r.Data.Transfer.Id);
            Assert.IsNotNull(r.Data.Transfer.CategoryData);
            Assert.IsNotNull(r.Data.Transfer.CategoryData.IssuedCard);
            Assert.AreEqual(IssuedCard.TypeEnum.IssuedCard, r.Data.Transfer.CategoryData.IssuedCard.Type);
            Assert.AreEqual(IssuedCard.NetworkVariantEnum.MaestroUs, r.Data.Transfer.CategoryData.IssuedCard.NetworkVariant);
        }

        [TestMethod]
        public void Given_IssuedCard_NetworkVariantEnum_When_Mapping_WireValues_Then_KnownValuesMap_And_UnknownValuesReturnNull()
        {
            // Assert
            Assert.AreEqual("maestro_us", IssuedCard.NetworkVariantEnum.MaestroUs.Value);
            Assert.AreEqual("maestro_us", IssuedCard.NetworkVariantEnum.ToJsonValue(IssuedCard.NetworkVariantEnum.MaestroUs));
            Assert.AreEqual(IssuedCard.NetworkVariantEnum.Mastercard, IssuedCard.NetworkVariantEnum.FromStringOrDefault("mastercard"));
            Assert.AreEqual(IssuedCard.NetworkVariantEnum.Visa, IssuedCard.NetworkVariantEnum.FromStringOrDefault("visa"));
            Assert.IsNull(IssuedCard.NetworkVariantEnum.FromStringOrDefault("some_future_network"));
        }
    }
}
