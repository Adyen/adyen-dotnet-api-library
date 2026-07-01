using System.Text.Json;
using Adyen.Core.Options;
using Adyen.ManagementWebhooks.Extensions;
using Adyen.ManagementWebhooks.Handlers;
using Adyen.ManagementWebhooks.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.ManagementWebhooks
{
    [TestClass]
    public class ManagementWebhooksTest
    {
        private readonly IManagementWebhooksHandler _managementWebhooksHandler;

        public ManagementWebhooksTest()
        {
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureManagementWebhooks((context, services, config) =>
                {
                    services.AddManagementWebhooksHandler();
                })
                .Build();

            _managementWebhooksHandler = host.Services.GetRequiredService<IManagementWebhooksHandler>();
        }

        [TestMethod]
        public void Given_Deserialize_When_Event_Is_Merchant_Created()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/managementwebhooks/merchant.created.json");

            // Act
            var r = _managementWebhooksHandler.DeserializeMerchantCreatedNotificationRequest(json);

            // Assert
            Assert.IsNotNull(r);
            Assert.AreEqual("test", r.Environment);
            Assert.AreEqual(MerchantCreatedNotificationRequest.TypeEnum.MerchantCreated, r.Type);
            Assert.AreEqual(DateTimeOffset.Parse("2022-08-12T10:50:01+02:00"), r.CreatedAt);

            Assert.IsNotNull(r.Data);
            Assert.AreEqual("YOUR_COMPANY_ID", r.Data.CompanyId);
            Assert.AreEqual("MC3224X22322535GH8D537TJR", r.Data.MerchantId);
            Assert.AreEqual("PreActive", r.Data.Status);

            Assert.IsNotNull(r.Data.Capabilities);
            Assert.IsTrue(r.Data.Capabilities.ContainsKey("sendToTransferInstrument"));
            var capability = r.Data.Capabilities["sendToTransferInstrument"];
            Assert.IsTrue(capability.Requested);
            Assert.AreEqual("notApplicable", capability.RequestedLevel);
        }

        [TestMethod]
        public void Given_Deserialize_When_Event_Is_PaymentMethod_Created()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/managementwebhooks/paymentMethod.created.json");

            // Act
            var r = _managementWebhooksHandler.DeserializePaymentMethodCreatedNotificationRequest(json);

            // Assert
            Assert.IsNotNull(r);
            Assert.AreEqual("test", r.Environment);
            Assert.AreEqual(PaymentMethodCreatedNotificationRequest.TypeEnum.PaymentMethodCreated, r.Type);
            Assert.AreEqual(DateTimeOffset.Parse("2022-01-24T14:59:11+01:00"), r.CreatedAt);

            Assert.IsNotNull(r.Data);
            Assert.AreEqual("PM3224R223224K5FH4M2K9B86", r.Data.Id);
            Assert.AreEqual("MERCHANT_ACCOUNT", r.Data.MerchantId);
            Assert.AreEqual(MidServiceNotificationData.StatusEnum.Success, r.Data.Status);
            Assert.AreEqual("ST322LJ223223K5F4SQNR9XL5", r.Data.StoreId);
            Assert.AreEqual("visa", r.Data.Type);
        }

        [TestMethod]
        public void Given_Deserialize_When_Event_Is_Merchant_Created_With_Unknown_Attribute()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/managementwebhooks/merchant.created.unknown.attribute.json");

            // Act
            var r = _managementWebhooksHandler.DeserializeMerchantCreatedNotificationRequest(json);

            // Assert
            Assert.IsNotNull(r);
            Assert.AreEqual("test", r.Environment);
            Assert.AreEqual(MerchantCreatedNotificationRequest.TypeEnum.MerchantCreated, r.Type);
            Assert.AreEqual("YOUR_COMPANY_ID", r.Data.CompanyId);
            Assert.AreEqual("MC3224X22322535GH8D537TJR", r.Data.MerchantId);
        }

        [TestMethod]
        public void Given_Deserialize_When_Event_Is_PaymentMethod_Created_With_Unknown_Status_Enum()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/managementwebhooks/paymentMethod.created.unknown.status.enum.json");

            // Act
            var r = _managementWebhooksHandler.DeserializePaymentMethodCreatedNotificationRequest(json);

            // Assert
            Assert.IsNotNull(r);
            Assert.AreEqual("test", r.Environment);
            Assert.AreEqual(PaymentMethodCreatedNotificationRequest.TypeEnum.PaymentMethodCreated, r.Type);
            Assert.AreEqual("PM3224R223224K5FH4M2K9B86", r.Data.Id);
            Assert.AreEqual("unknown-future-status", r.Data.Status.Value);
        }

        [TestMethod]
        public void Given_Deserialize_When_Event_Is_Merchant_Created_With_Multiple_Capabilities()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/managementwebhooks/merchant.created.multiple.capabilities.json");

            // Act
            var r = _managementWebhooksHandler.DeserializeMerchantCreatedNotificationRequest(json);

            // Assert
            Assert.IsNotNull(r);
            Assert.AreEqual(3, r.Data.Capabilities.Count);

            Assert.IsTrue(r.Data.Capabilities.ContainsKey("sendToTransferInstrument"));
            var sendToTransferInstrument = r.Data.Capabilities["sendToTransferInstrument"];
            Assert.IsTrue(sendToTransferInstrument.Requested);
            Assert.AreEqual("notApplicable", sendToTransferInstrument.RequestedLevel);
            Assert.IsNull(sendToTransferInstrument.Allowed);
            Assert.IsNull(sendToTransferInstrument.VerificationStatus);

            Assert.IsTrue(r.Data.Capabilities.ContainsKey("receivePayments"));
            var receivePayments = r.Data.Capabilities["receivePayments"];
            Assert.IsTrue(receivePayments.Requested);
            Assert.AreEqual("notApplicable", receivePayments.RequestedLevel);
            Assert.IsTrue(receivePayments.Allowed);
            Assert.AreEqual("valid", receivePayments.VerificationStatus);

            Assert.IsTrue(r.Data.Capabilities.ContainsKey("receiveFromPlatformPayments"));
            var receiveFromPlatformPayments = r.Data.Capabilities["receiveFromPlatformPayments"];
            Assert.IsFalse(receiveFromPlatformPayments.Requested);
            Assert.AreEqual("low", receiveFromPlatformPayments.RequestedLevel);
            Assert.IsNull(receiveFromPlatformPayments.Allowed);
        }

        [TestMethod]
        public void Given_Deserialize_When_Event_Is_Merchant_Updated_With_Capability_Having_Only_Required_Fields()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/managementwebhooks/merchant.updated.capability.required.fields.only.json");

            // Act
            var r = _managementWebhooksHandler.DeserializeMerchantUpdatedNotificationRequest(json);

            // Assert
            Assert.IsNotNull(r);
            Assert.AreEqual(1, r.Data.Capabilities.Count);

            Assert.IsTrue(r.Data.Capabilities.ContainsKey("receivePayments"));
            var receivePayments = r.Data.Capabilities["receivePayments"];
            Assert.IsTrue(receivePayments.Requested);
            Assert.AreEqual("notApplicable", receivePayments.RequestedLevel);

            Assert.IsNull(receivePayments.Allowed);
            Assert.IsNull(receivePayments.AllowedLevel);
            Assert.IsNull(receivePayments.Capability);
            Assert.IsNull(receivePayments.Problems);
            Assert.IsNull(receivePayments.VerificationDeadline);
            Assert.IsNull(receivePayments.VerificationStatus);
            Assert.IsNull(r.Data.LegalEntityId);
        }

        [TestMethod]
        public void Given_Deserialize_When_Required_Fields_Are_Missing_Then_Returns_Null_Properties()
        {
            // Arrange
            string json = @"{ ""type"": ""merchant.created"" }"; // No data, no environment (which are required)!

            // Act
            var result = _managementWebhooksHandler.DeserializeMerchantCreatedNotificationRequest(json);

            // Assert - lenient deserialization: missing required fields result in null properties, not exceptions
            Assert.IsNotNull(result);
            Assert.IsNull(result.Data);
            Assert.IsNull(result.Environment);
        }

        [TestMethod]
        public void Given_Deserialize_When_Json_Is_Invalid_Then_Throws_JsonException()
        {
            // Arrange
            string json = "{ invalid,.json; }";

            // Act & Assert
            Assert.ThrowsException<JsonException>(() =>
            {
                _managementWebhooksHandler.DeserializeMerchantCreatedNotificationRequest(json);
            });
        }

        [TestMethod]
        public void Given_IsValidHmacSignature_When_Hmac_Key_Is_Not_Configured_Then_Throws_InvalidOperationException()
        {
            // Arrange - handler built without HMAC key
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureManagementWebhooks((context, services, config) =>
                {
                    services.AddManagementWebhooksHandler();
                })
                .Build();
            var handler = host.Services.GetRequiredService<IManagementWebhooksHandler>();

            // Act & Assert
            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                handler.IsValidHmacSignature("{}", "some-signature");
            });
        }

        [TestMethod]
        public void Given_IsValidHmacSignature_When_Hmac_Signature_Is_Invalid_Then_Returns_False()
        {
            // Arrange - key must be a valid 64-char hex string
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureManagementWebhooks((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.AdyenHmacKey = "0102030405060708090a0b0c0d0e0f101112131415161718191a1b1c1d1e1f20";
                    });
                    services.AddManagementWebhooksHandler();
                })
                .Build();
            var handler = host.Services.GetRequiredService<IManagementWebhooksHandler>();

            // Act
            bool isValid = handler.IsValidHmacSignature("{ \"test\": \"value\" }", "invalid-hmac-signature");

            // Assert
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void Given_Deserialize_When_Event_Is_Merchant_Updated()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/managementwebhooks/merchant.updated.json");

            // Act
            var r = _managementWebhooksHandler.DeserializeMerchantUpdatedNotificationRequest(json);

            // Assert
            Assert.IsNotNull(r);
            Assert.AreEqual("test", r.Environment);
            Assert.AreEqual(MerchantUpdatedNotificationRequest.TypeEnum.MerchantUpdated, r.Type);
            Assert.AreEqual(DateTimeOffset.Parse("2022-09-20T13:42:31+02:00"), r.CreatedAt);

            Assert.IsNotNull(r.Data);
            Assert.AreEqual("YOUR_MERCHANT_ID", r.Data.MerchantId);
            Assert.AreEqual("PreActive", r.Data.Status);
            Assert.AreEqual("LE322KH223222F5GNNW694PZN", r.Data.LegalEntityId);

            Assert.IsNotNull(r.Data.Capabilities);
            Assert.IsTrue(r.Data.Capabilities.ContainsKey("receivePayments"));
            var capability = r.Data.Capabilities["receivePayments"];
            Assert.IsTrue(capability.Allowed);
            Assert.IsTrue(capability.Requested);
            Assert.AreEqual("notApplicable", capability.RequestedLevel);
        }
    }
}
