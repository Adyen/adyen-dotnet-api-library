using Adyen.TransferWebhooks.Extensions;
using Adyen.TransferWebhooks.Models;
using Adyen.TransferWebhooks.Handlers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Hosting;

namespace Adyen.Test.TransferWebhooks
{
    [TestClass]
    public class TransferWebhooksTest
    {
        private static IHost _host;
        private static ITransferWebhooksHandler _transferWebhooksHandler;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            _host = Host.CreateDefaultBuilder()
                .ConfigureTransferWebhooks((ctx, services, config) =>
                {
                    services.AddTransferWebhooksHandler();
                })
                .Build();

            _transferWebhooksHandler = _host.Services.GetRequiredService<ITransferWebhooksHandler>();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            _host?.Dispose();
        }

        [TestMethod]
        public void Given_Deserialize_When_Transfer_Webhook_Notification_Of_Chargeback_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/transferwebhooks/balancePlatform.transfer.updated.json");

            // Act
            TransferNotificationRequest r = _transferWebhooksHandler.DeserializeTransferNotificationRequest(json);

            // Assert
            Assert.IsNotNull(r);
            Assert.AreEqual("test", r.Environment);
            Assert.AreEqual(TransferNotificationRequest.TypeEnum.BalancePlatformTransferUpdated, r.Type);

            Assert.AreEqual("YOUR_BALANCE_PLATFORM", r.Data.BalancePlatform);
            Assert.AreEqual(DateTimeOffset.Parse("2025-06-02T13:46:27+02:00"), r.Data.CreationDate);
            Assert.AreEqual("01234", r.Data.Id);

            Assert.AreEqual("The Account Holder", r.Data.AccountHolder.Description);
            Assert.AreEqual("AH1234567890", r.Data.AccountHolder.Id);

            Assert.AreEqual("EUR", r.Data.Amount.Currency);
            Assert.AreEqual(22700, r.Data.Amount.Value);
            Assert.IsNotNull(r.Data.BalanceAccount);
            Assert.AreEqual("The Liable Balance Account", r.Data.BalanceAccount.Description);
            Assert.AreEqual("BA1234567890", r.Data.BalanceAccount.Id);
            Assert.AreEqual(TransferData.CategoryEnum.PlatformPayment, r.Data.Category);

            Assert.AreEqual("<auto>", r.Data.CategoryData.PlatformPayment.ModificationMerchantReference);
            Assert.AreEqual("ZX1234567890", r.Data.CategoryData.PlatformPayment.ModificationPspReference);
            Assert.AreEqual("pv-test", r.Data.CategoryData.PlatformPayment.PaymentMerchantReference);
            Assert.AreEqual(PlatformPayment.PlatformPaymentTypeEnum.Remainder, r.Data.CategoryData.PlatformPayment.PlatformPaymentType);
            Assert.AreEqual("PSP01234", r.Data.CategoryData.PlatformPayment.PspPaymentReference);
            Assert.AreEqual("Remainder Fee for pv-test", r.Data.Description);
            Assert.AreEqual(TransferData.DirectionEnum.Incoming, r.Data.Direction);
            Assert.AreEqual(TransferData.ReasonEnum.Approved, r.Data.Reason);
            Assert.AreEqual("<auto>", r.Data.Reference);
            Assert.AreEqual(TransferData.StatusEnum.Authorised, r.Data.Status);
            Assert.AreEqual(TransferData.TypeEnum.Capture, r.Data.Type);

            Assert.AreEqual(1, r.Data.Balances.Count);
            Assert.AreEqual("EUR", r.Data.Balances[0].Currency);
            Assert.AreEqual(0, r.Data.Balances[0].Received);
            Assert.AreEqual(22700, r.Data.Balances[0].Reserved);
            Assert.AreEqual("EV1234567890", r.Data.EventId);

            Assert.AreEqual(2, r.Data.Events.Count);

            Assert.AreEqual(DateTimeOffset.Parse("2025-06-02T13:46:27+02:00"), r.Data.Events[0].BookingDate);
            Assert.AreEqual("EV1234567890", r.Data.Events[0].Id);
            Assert.AreEqual(TransferEvent.StatusEnum.Received, r.Data.Events[0].Status);
            Assert.AreEqual(TransferEvent.TypeEnum.Accounting, r.Data.Events[0].Type);

            Assert.AreEqual(1, r.Data.Events[0].Mutations.Count);
            Assert.AreEqual("EUR", r.Data.Events[0].Mutations[0].Currency);
            Assert.AreEqual(22700, r.Data.Events[0].Mutations[0].Received);

            Assert.AreEqual(DateTimeOffset.Parse("2025-06-02T13:46:27+02:00"), r.Data.Events[1].BookingDate);
            Assert.AreEqual("EV1234567890-2", r.Data.Events[1].Id);
            Assert.AreEqual(TransferEvent.StatusEnum.Authorised, r.Data.Events[1].Status);
            Assert.AreEqual(TransferEvent.TypeEnum.Accounting, r.Data.Events[1].Type);

            Assert.IsNotNull(r.Data.Events[1].Mutations);
            Assert.AreEqual(1, r.Data.Events[1].Mutations.Count);
            Assert.AreEqual("EUR", r.Data.Events[1].Mutations[0].Currency);
            Assert.AreEqual(-22700, r.Data.Events[1].Mutations[0].Received);
            Assert.AreEqual(22700, r.Data.Events[1].Mutations[0].Reserved);

            Assert.AreEqual(2, r.Data.SequenceNumber);
            Assert.AreEqual(DateTimeOffset.Parse("2025-06-02T11:46:28.635Z"), r.Timestamp);
        }

        [TestMethod]
        public void Given_Deserialize_When_DirectDebit_Booked_With_BankCategoryData_And_IbanAccountIdentification_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/transferwebhooks/balancePlatform.transfer.updated.directDebit.booked.json");

            // Act
            TransferNotificationRequest r = _transferWebhooksHandler.DeserializeTransferNotificationRequest(json);

            // Assert
            Assert.IsNotNull(r);
            Assert.AreEqual(TransferNotificationRequest.TypeEnum.BalancePlatformTransferUpdated, r.Type);
            Assert.AreEqual("test", r.Environment);

            Assert.AreEqual(TransferData.CategoryEnum.Bank, r.Data.Category);
            Assert.IsNotNull(r.Data.CategoryData.BankCategoryData);
            Assert.IsNull(r.Data.CategoryData.BankCategoryData.Priority);

            Assert.IsNotNull(r.Data.Counterparty);
            Assert.IsNotNull(r.Data.Counterparty.BankAccount);
            Assert.AreEqual("John Smith", r.Data.Counterparty.BankAccount.AccountHolder.FullName);

            var accountIdentification = r.Data.Counterparty.BankAccount.AccountIdentification;
            Assert.IsNotNull(accountIdentification);
            Assert.IsNotNull(accountIdentification.IbanAccountIdentification);
            Assert.AreEqual("FR0000000000000000000000117", accountIdentification.IbanAccountIdentification.Iban);

            Assert.AreEqual("2WT1N05XXY7P9XH9", r.Data.Id);
            Assert.AreEqual(TransferData.StatusEnum.Booked, r.Data.Status);
            Assert.AreEqual(3, r.Data.SequenceNumber);
            Assert.AreEqual(3, r.Data.Events.Count);
        }

        [TestMethod]
        public void Given_Deserialize_When_Transfer_Updated_With_EstimationTrackingData_In_Event_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/transferwebhooks/balancePlatform.transfer.updated.tracking.estimation.json");

            // Act
            TransferNotificationRequest r = _transferWebhooksHandler.DeserializeTransferNotificationRequest(json);

            // Assert
            Assert.IsNotNull(r);
            Assert.AreEqual(TransferNotificationRequest.TypeEnum.BalancePlatformTransferUpdated, r.Type);
            Assert.AreEqual(TransferData.CategoryEnum.Bank, r.Data.Category);
            Assert.AreEqual(3, r.Data.Events.Count);

            var trackingEvent = r.Data.Events[2];
            Assert.AreEqual(TransferEvent.TypeEnum.Tracking, trackingEvent.Type);
            Assert.IsNotNull(trackingEvent.TrackingData);
            Assert.IsNotNull(trackingEvent.TrackingData.EstimationTrackingData);
            Assert.AreEqual(
                DateTimeOffset.Parse("2023-03-01T12:00:00+01:00"),
                trackingEvent.TrackingData.EstimationTrackingData.EstimatedArrivalTime
            );
        }

        [TestMethod]
        public void Given_Deserialize_When_Transfer_Updated_With_ConfirmationTrackingData_In_Event_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/transferwebhooks/balancePlatform.transfer.updated.tracking.confirmation.json");

            // Act
            TransferNotificationRequest r = _transferWebhooksHandler.DeserializeTransferNotificationRequest(json);

            // Assert
            Assert.IsNotNull(r);
            Assert.AreEqual(TransferNotificationRequest.TypeEnum.BalancePlatformTransferUpdated, r.Type);
            Assert.AreEqual(1, r.Data.Events.Count);

            var trackingEvent = r.Data.Events[0];
            Assert.AreEqual(TransferEvent.TypeEnum.Tracking, trackingEvent.Type);
            Assert.IsNotNull(trackingEvent.TrackingData);
            Assert.IsNotNull(trackingEvent.TrackingData.ConfirmationTrackingData);
            Assert.AreEqual(ConfirmationTrackingData.StatusEnum.Credited, trackingEvent.TrackingData.ConfirmationTrackingData.Status);
        }

        [TestMethod]
        public void Given_Deserialize_When_Transfer_Updated_With_TopLevel_EstimationTracking_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/transferwebhooks/balancePlatform.transfer.updated.toplevel.tracking.json");

            // Act
            TransferNotificationRequest r = _transferWebhooksHandler.DeserializeTransferNotificationRequest(json);

            // Assert
            Assert.IsNotNull(r);
            Assert.AreEqual(TransferNotificationRequest.TypeEnum.BalancePlatformTransferUpdated, r.Type);
            Assert.AreEqual(TransferData.CategoryEnum.Bank, r.Data.Category);

            Assert.IsNotNull(r.Data.Tracking);
            Assert.IsNotNull(r.Data.Tracking.EstimationTrackingData);
            Assert.AreEqual(
                DateTimeOffset.Parse("2023-03-01T12:00:00+01:00"),
                r.Data.Tracking.EstimationTrackingData.EstimatedArrivalTime
            );
        }

        [TestMethod]
        public void Given_Deserialize_When_Transfer_Webhook_With_UnknownCategoryEnum_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/transferwebhooks/balancePlatform.transfer.created.unknown.category.enum.json");

            // Act
            TransferNotificationRequest r = _transferWebhooksHandler.DeserializeTransferNotificationRequest(json);

            // Assert
            Assert.IsNotNull(r);
            Assert.AreEqual(TransferNotificationRequest.TypeEnum.BalancePlatformTransferCreated, r.Type);
            Assert.AreEqual("test", r.Environment);
            Assert.AreEqual("unknown-value-grants", r.Data.Category.Value);
            Assert.AreEqual(TransferData.StatusEnum.Booked, r.Data.Status);
            Assert.AreEqual("EVJN42272224224B5JN8H8B4G", r.Data.Id);
            Assert.AreEqual(1000000, r.Data.Amount.Value);
            Assert.AreEqual("EUR", r.Data.Amount.Currency);
            Assert.AreEqual("your-reference", r.Data.Reference);
            Assert.AreEqual("AH00000000000000000000001", r.Data.AccountHolder.Id);
            Assert.AreEqual("BA00000000000000000000001", r.Data.BalanceAccount.Id);
        }
    }
}