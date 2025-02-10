using System;
using Adyen.Model.ManagementWebhooks;
using Adyen.Webhooks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.WebhooksTests
{
    [TestClass]
    public class ManagementWebhookHandlerTest : BaseTest
    {
        private readonly ManagementWebhookHandler _managementWebhookHandler = new ManagementWebhookHandler();

        [TestMethod]
        public void Test_Management_Webhook_PaymentMethodCreated()
        {
            // Arrange
            const string jsonPayload = @"
{
    'createdAt': '2022-01-24T14:59:11+01:00',
    'data': {
        'id': 'PM3224R223224K5FH4M2K9B86',
        'merchantId': 'MERCHANT_ACCOUNT',
        'status': 'SUCCESS',
        'storeId': 'ST322LJ223223K5F4SQNR9XL5',
        'type': 'visa'
    },
    'environment': 'test',
    'type': 'paymentMethod.created'
}";
            // Act
            _managementWebhookHandler.GetPaymentMethodCreatedNotificationRequest(jsonPayload, out PaymentMethodCreatedNotificationRequest paymentMethodCreatedWebhook);

            // Assert
            Assert.IsNotNull(paymentMethodCreatedWebhook);
            Assert.AreEqual(PaymentMethodCreatedNotificationRequest.TypeEnum.PaymentMethodCreated, paymentMethodCreatedWebhook.Type);
            Assert.AreEqual(paymentMethodCreatedWebhook.Data.Id, "PM3224R223224K5FH4M2K9B86");
            Assert.AreEqual(paymentMethodCreatedWebhook.Data.MerchantId, "MERCHANT_ACCOUNT");
            Assert.AreEqual(paymentMethodCreatedWebhook.Data.Status, MidServiceNotificationData.StatusEnum.Success);
            Assert.AreEqual(paymentMethodCreatedWebhook.Data.StoreId, "ST322LJ223223K5F4SQNR9XL5");
            Assert.AreEqual(paymentMethodCreatedWebhook.Data.Type, "visa");
            Assert.AreEqual(DateTime.Parse("2022-01-24T14:59:11+01:00"), paymentMethodCreatedWebhook.CreatedAt);
            Assert.AreEqual("test", paymentMethodCreatedWebhook.Environment);
        }

        [TestMethod]
        public void Test_Management_Webhook_MerchantUpdated()
        {
            // Arrange
            const string jsonPayload = @"
{
    'type': 'merchant.updated',
    'environment': 'test',
    'createdAt': '2022-09-20T13:42:31+02:00',
    'data': {
        'capabilities': {
            'receivePayments': {
                'allowed': true,
                'requested': true,
                'requestedLevel': 'notApplicable',
                'verificationStatus': 'valid'
            }
        },
        'legalEntityId': 'LE322KH223222F5GNNW694PZN',
        'merchantId': 'YOUR_MERCHANT_ID',
        'status': 'PreActive'
    }
}";
            // Act
            _managementWebhookHandler.GetMerchantUpdatedNotificationRequest(jsonPayload, out MerchantUpdatedNotificationRequest target);
            
            // Assert
            Assert.IsNotNull(target);
            Assert.AreEqual(target.Type, MerchantUpdatedNotificationRequest.TypeEnum.MerchantUpdated);
            Assert.AreEqual("LE322KH223222F5GNNW694PZN", target.Data.LegalEntityId);
            Assert.AreEqual("YOUR_MERCHANT_ID", target.Data.MerchantId);
            Assert.AreEqual("PreActive", target.Data.Status);
            Assert.AreEqual(DateTime.Parse("2022-09-20T13:42:31+02:00"), target.CreatedAt);
            Assert.AreEqual("test", target.Environment);
            
            Assert.IsTrue(target.Data.Capabilities.TryGetValue("receivePayments", out AccountCapabilityData accountCapabilityData));
            Assert.AreEqual(true, accountCapabilityData.Requested);
            Assert.AreEqual("notApplicable", accountCapabilityData.RequestedLevel);
        }

        [TestMethod]
        public void Test_Management_Webhook_MerchantCreated()
        {
            // Arrange
            const string jsonPayload = @"
{
    'type': 'merchant.created',
    'environment': 'test',
    'createdAt': '2022-08-12T10:50:01+02:00',
    'data': {
        'capabilities': {
            'sendToTransferInstrument': {
                'requested': true,
                'requestedLevel': 'notApplicable'
            }
        },
        'companyId': 'YOUR_COMPANY_ID',
        'merchantId': 'MC3224X22322535GH8D537TJR',
        'status': 'PreActive'
    }
}";
            Assert.IsFalse(_managementWebhookHandler.GetMerchantUpdatedNotificationRequest(jsonPayload, out _));
            
            // Act
            _managementWebhookHandler.GetMerchantCreatedNotificationRequest(jsonPayload, out MerchantCreatedNotificationRequest target);
            
            // Assert
            Assert.IsNotNull(target);
            Assert.AreEqual(MerchantCreatedNotificationRequest.TypeEnum.MerchantCreated, target.Type);
            Assert.AreEqual("test", target.Environment);
            Assert.AreEqual("YOUR_COMPANY_ID", target.Data.CompanyId);
            Assert.AreEqual("MC3224X22322535GH8D537TJR", target.Data.MerchantId);
            Assert.AreEqual("PreActive", target.Data.Status);
            Assert.AreEqual(DateTime.Parse("2022-08-12T10:50:01+02:00"), target.CreatedAt);
            Assert.IsTrue(target.Data.Capabilities.TryGetValue("sendToTransferInstrument", out AccountCapabilityData data));
            Assert.AreEqual("notApplicable", data.RequestedLevel);
            Assert.AreEqual(true, data.Requested);
        }
    }
}