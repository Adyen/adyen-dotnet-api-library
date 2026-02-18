using Adyen.TransferWebhooks.Client;
using Adyen.TransferWebhooks.Extensions;
using Adyen.TransferWebhooks.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Hosting;
using System.Text.Json;
using Adyen.TransferWebhooks.Handlers;

namespace Adyen.Test.TransferWebhooks
{
    [TestClass]
    public class TransferWebhooksTest
    {
        private readonly ITransferWebhooksHandler _transferWebhooksHandler;

        public TransferWebhooksTest()
        {
          IHost host = Host.CreateDefaultBuilder()
            .ConfigureTransferWebhooks((context, services, config) =>
            {
              services.AddTransferWebhooksHandler();
            })
            .Build();

          _transferWebhooksHandler = host.Services.GetRequiredService<ITransferWebhooksHandler>();
        }

        [TestMethod]
        public async Task Given_Deserialize_When_Transfer_Webhook_Notification_Of_Chargeback_Returns_Not_Null()
        {
            // Arrange
            string json = @"
{
  ""data"": {
    ""balancePlatform"": ""YOUR_BALANCE_PLATFORM"",
    ""creationDate"": ""2025-06-02T13:46:27+02:00"",
    ""id"": ""01234"",
    ""accountHolder"": {
      ""description"": ""The Account Holder"",
      ""id"": ""AH1234567890""
    },
    ""amount"": {
      ""currency"": ""EUR"",
      ""value"": 22700
    },
    ""balanceAccount"": {
      ""description"": ""The Liable Balance Account"",
      ""id"": ""BA1234567890""
    },
    ""category"": ""platformPayment"",
    ""categoryData"": {
      ""modificationMerchantReference"": ""<auto>"",
      ""modificationPspReference"": ""ZX1234567890"",
      ""paymentMerchantReference"": ""pv-test"",
      ""platformPaymentType"": ""Remainder"",
      ""pspPaymentReference"": ""PSP01234"",
      ""type"": ""platformPayment""
    },
    ""description"": ""Remainder Fee for pv-test"",
    ""direction"": ""incoming"",
    ""reason"": ""approved"",
    ""reference"": ""<auto>"",
    ""status"": ""authorised"",
    ""type"": ""capture"",
    ""balances"": [
      {
        ""currency"": ""EUR"",
        ""received"": 0,
        ""reserved"": 22700
      }
    ],
    ""eventId"": ""EV1234567890"",
    ""events"": [
      {
        ""bookingDate"": ""2025-06-02T13:46:27+02:00"",
        ""id"": ""EV1234567890"",
        ""mutations"": [
          {
            ""currency"": ""EUR"",
            ""received"": 22700
          }
        ],
        ""status"": ""received"",
        ""type"": ""accounting""
      },
      {
        ""bookingDate"": ""2025-06-02T13:46:27+02:00"",
        ""id"": ""EV1234567890-2"",
        ""mutations"": [
          {
            ""currency"": ""EUR"",
            ""received"": -22700,
            ""reserved"": 22700
          }
        ],
        ""status"": ""authorised"",
        ""type"": ""accounting""
      }
    ],
    ""sequenceNumber"": 2
  },
  ""environment"": ""test"",
  ""timestamp"": ""2025-06-02T11:46:28.635Z"",
  ""type"": ""balancePlatform.transfer.updated""
}
";
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
    }
}