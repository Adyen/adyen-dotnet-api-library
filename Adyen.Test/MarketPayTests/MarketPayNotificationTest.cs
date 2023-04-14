using Adyen.Model.MarketPay;
using Adyen.Model.MarketPay.Notification;
using Adyen.Webhooks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.MarketPayTest
{
    [TestClass]
    public class MarketPayNotificationTest : BaseTest
    {
        [TestMethod]
        public void MarketPayAccountClosedNotificationTest()
        {
            string json = GetFileContents("Mocks/marketpay/notification/account-closed-test.json");
            WebhookHandler webhookHandler = new WebhookHandler();
            IWebhookNotification notificationMessage = webhookHandler.HandleMarketpayNotificationJson(json);
            AccountCloseNotification accountCloseNotification = (AccountCloseNotification)notificationMessage;
            Assert.AreEqual(accountCloseNotification.EventType, "ACCOUNT_CLOSED");
            Assert.AreEqual(accountCloseNotification.PspReference, "TSTPSPR0001");
            Assert.AreEqual(accountCloseNotification.Content.ResultCode, "Success");
        }

        [TestMethod]
        public void MarketPayAccountCreatedNotificationTest()
        {
            string json = GetFileContents("Mocks/marketpay/notification/account-created-success.json");
           WebhookHandler webhookHandler = new WebhookHandler();
            IWebhookNotification notificationMessage = webhookHandler.HandleMarketpayNotificationJson(json);
            AccountCreateNotification accountCreateNotificationMessage = (AccountCreateNotification)notificationMessage;
            Assert.AreEqual("ACCOUNT_CREATED", accountCreateNotificationMessage.EventType);
            Assert.AreEqual("000", accountCreateNotificationMessage.Error.ErrorCode);
            Assert.AreEqual("test error message", accountCreateNotificationMessage.Error.Message);
            Assert.IsNotNull(accountCreateNotificationMessage.Content);

            CreateAccountResponse content = accountCreateNotificationMessage.Content;
            Assert.AreEqual("TestAccountHolder", content.AccountHolderCode);
            Assert.AreEqual("AC0000000001", content.AccountCode);
            Assert.AreEqual("account description", content.Description);
            Assert.AreEqual("MetaValue", content.Metadata["MetaKey"]);
            Assert.AreEqual(CreateAccountResponse.StatusEnum.Active, content.Status);

            PayoutScheduleResponse payoutSchedule = content.PayoutSchedule;
            Assert.AreEqual(PayoutScheduleResponse.ScheduleEnum.DAILY, payoutSchedule.Schedule);
            Assert.AreEqual(1, content.InvalidFields.Count);

            ErrorFieldType errorFieldType = content.InvalidFields[0];
            Assert.AreEqual(1, (long)errorFieldType.ErrorCode);
            Assert.AreEqual("Field is missing", errorFieldType.ErrorDescription);
            Assert.AreEqual("AccountHolderDetails.BusinessDetails.Shareholders.unknown", errorFieldType.FieldType.Field);
            Assert.AreEqual(FieldType.FieldNameEnum.Unknown, errorFieldType.FieldType.FieldName);
            Assert.AreEqual("SH00001", errorFieldType.FieldType.ShareholderCode);
        }

        [TestMethod]
        public void MarketPayAccountHolderCreatedNotificationTest()
        {
            string json = GetFileContents("Mocks/marketpay/notification/account-holder-created-success.json");
           WebhookHandler webhookHandler = new WebhookHandler();
            IWebhookNotification notificationMessage = webhookHandler.HandleMarketpayNotificationJson(json);
            AccountHolderCreateNotification accountHolderCreateNotificationMessage = (AccountHolderCreateNotification)notificationMessage;
            Assert.AreEqual("ACCOUNT_HOLDER_CREATED", accountHolderCreateNotificationMessage.EventType);
            Assert.IsNotNull(accountHolderCreateNotificationMessage.Content);
            Assert.AreEqual("AHC00000001", accountHolderCreateNotificationMessage.Content.AccountHolderCode);
            Assert.AreEqual("TSTPSPR0001", accountHolderCreateNotificationMessage.Content.PspReference);
            Assert.AreEqual("executing-user-key", accountHolderCreateNotificationMessage.ExecutingUserKey);
        }

        [TestMethod]
        public void MarketPayAccountHolderVerificationNotificationTest()
        {
            string json = GetFileContents("Mocks/marketpay/notification/account-holder-verification.json");
           WebhookHandler webhookHandler = new WebhookHandler();
            IWebhookNotification notificationMessage = webhookHandler.HandleMarketpayNotificationJson(json);
            AccountHolderVerificationNotification notification = (AccountHolderVerificationNotification)notificationMessage;
            Assert.AreEqual("ACCOUNT_HOLDER_VERIFICATION", notification.EventType);
            Assert.IsNotNull(notification.Content);
            Assert.AreEqual("AH0000001", notification.Content.AccountHolderCode);
        }

        [TestMethod]
        public void MarketPayAccountHolderStatusChangeNotificationTest()
        {
            string json = GetFileContents("Mocks/marketpay/notification/account-holder-status-change.json");
           WebhookHandler webhookHandler = new WebhookHandler();
            IWebhookNotification notificationMessage = webhookHandler.HandleMarketpayNotificationJson(json);
            AccountHolderStatusChangeNotification notification = (AccountHolderStatusChangeNotification)notificationMessage;
            Assert.AreEqual("ACCOUNT_HOLDER_STATUS_CHANGE", notification.EventType);
            Assert.IsNotNull(notification.Content);
            Assert.AreEqual("ah689", notification.Content.AccountHolderCode);
            Assert.IsNull(notification.Content.OldStatus.ProcessingState.ProcessedTo);
            Assert.AreEqual("GBP", notification.Content.NewStatus.ProcessingState.ProcessedTo.Currency);
        }

        [TestMethod]
        public void MarketPayAccountHolderPayoutFailNotificationTest()
        {
            string json = GetFileContents("Mocks/marketpay/notification/account-holder-payout-fail.json");
           WebhookHandler webhookHandler = new WebhookHandler();
            IWebhookNotification notificationMessage = webhookHandler.HandleMarketpayNotificationJson(json);
            AccountHolderPayoutNotification notification = (AccountHolderPayoutNotification)notificationMessage;
            Assert.AreEqual("ACCOUNT_HOLDER_PAYOUT", notification.EventType);
            Assert.IsNotNull(notification.Content);
            Assert.AreEqual("AC00000001", notification.Content.AccountCode);
            Assert.AreEqual(1, notification.Content.Amounts.Count);
            Assert.AreEqual(10L, notification.Content.Amounts[0].Value);
            Assert.AreEqual("10_069", notification.Content.Status.Message.Code);
        }

        [TestMethod]
        public void MarketPayAccountHolderUpdatedNotificationTest()
        {
            string json = GetFileContents("Mocks/marketpay/notification/account-holder-updated.json");
           WebhookHandler webhookHandler = new WebhookHandler();

            IWebhookNotification notificationMessage = webhookHandler.HandleMarketpayNotificationJson(json);
            AccountHolderUpdateNotification notification = (AccountHolderUpdateNotification)notificationMessage;
            Assert.AreEqual("ACCOUNT_HOLDER_UPDATED", notification.EventType);
            Assert.IsNotNull(notification.Content);
            Assert.AreEqual("accountHolderCode", notification.Content.AccountHolderCode);
            Assert.AreEqual(AccountHolderStatus.StatusEnum.Active, notification.Content.AccountHolderStatus.Status);
            Assert.AreEqual(KYCCheckStatusData.TypeEnum.COMPANYVERIFICATION, notification.Content.Verification.AccountHolder.Checks[0].Type);
            Assert.AreEqual(KYCCheckStatusData.StatusEnum.DATAPROVIDED, notification.Content.Verification.AccountHolder.Checks[0].Status);
        }

        [TestMethod]
        public void MarketPayBeneficiarySetupNotificationTest()
        {
            string json = GetFileContents("Mocks/marketpay/notification/beneficiary-setup.json");
           WebhookHandler webhookHandler = new WebhookHandler();
            IWebhookNotification notificationMessage = webhookHandler.HandleMarketpayNotificationJson(json);
            BeneficiarySetupNotification notification = (BeneficiarySetupNotification)notificationMessage;
            Assert.AreEqual("BENEFICIARY_SETUP", notification.EventType);
            Assert.IsNotNull(notification.Content);
            Assert.AreEqual("136058999", notification.Content.SourceAccountCode);
            Assert.AreEqual("117001608", notification.Content.DestinationAccountCode);
        }

        [TestMethod]
        public void MarketPayScheduledRefundsNotificationTest()
        {
            string json = GetFileContents("Mocks/marketpay/notification/scheduled-refunds-test.json");
           WebhookHandler webhookHandler = new WebhookHandler();

            IWebhookNotification notificationMessage = webhookHandler.HandleMarketpayNotificationJson(json);
            ScheduledRefundsNotification notification = (ScheduledRefundsNotification)notificationMessage;
            Assert.AreEqual("SCHEDULED_REFUNDS", notification.EventType);
            Assert.IsNotNull(notification.Content);
            Assert.AreEqual("1234567890", notification.Content.AccountCode);
            Assert.AreEqual(5000L, notification.Content.LastPayout.Amount.Value);
            Assert.AreEqual(Transaction.TransactionStatusEnum.PendingCredit, notification.Content.RefundResults[0].RefundResult.OriginalTransaction.TransactionStatus);
        }

        [TestMethod]
        public void MarketPayCompensateNegativeBalanceNotificationTest()
        {
            string json = GetFileContents("Mocks/marketpay/notification/compensate-negative-balance-test.json");
           WebhookHandler webhookHandler = new WebhookHandler();
            IWebhookNotification notificationMessage = webhookHandler.HandleMarketpayNotificationJson(json);
            CompensateNegativeBalanceNotification notification = (CompensateNegativeBalanceNotification)notificationMessage;
            Assert.AreEqual("COMPENSATE_NEGATIVE_BALANCE", notification.EventType);
            Assert.IsNotNull(notification.Content);
            Assert.AreEqual("AC000001", notification.Content.Records[0].AccountCode);
            Assert.AreEqual(10L, notification.Content.Records[0].Amount.Value);
        }

        [TestMethod]
        public void MarketPayPaymentFailureNotificationTest()
        {
            string json = GetFileContents("Mocks/marketpay/notification/payment-failure-test.json");
           WebhookHandler webhookHandler = new WebhookHandler();
            IWebhookNotification notificationMessage = webhookHandler.HandleMarketpayNotificationJson(json);
            PaymentFailureNotification notification = (PaymentFailureNotification)notificationMessage;
            Assert.AreEqual("PAYMENT_FAILURE", notification.EventType);
            Assert.IsNotNull(notification.Content);
            Assert.AreEqual(1L, notification.Content.ErrorFields[0].ErrorFieldType.ErrorCode.Value);
            Assert.AreEqual("10_062", notification.Content.ErrorMessage.Code);
        }

        [TestMethod]
        public void MarketPayReportAvailableNotificationTest()
        {
            string json = GetFileContents("Mocks/marketpay/notification/report-available-test.json");
           WebhookHandler webhookHandler = new WebhookHandler();
            IWebhookNotification notificationMessage = webhookHandler.HandleMarketpayNotificationJson(json);
            ReportAvailableNotification notification = (ReportAvailableNotification)notificationMessage;
            Assert.AreEqual("REPORT_AVAILABLE", notification.EventType);
            Assert.IsNotNull(notification.Content);
            Assert.IsNotNull(notification.Content.RemoteAccessUrl);
        }

        [TestMethod]
        public void MarketPayTransferFundsNotificationTest()
        {
            string json = GetFileContents("Mocks/marketpay/notification/transfer-funds-test.json");
           WebhookHandler webhookHandler = new WebhookHandler();
            IWebhookNotification notificationMessage = webhookHandler.HandleMarketpayNotificationJson(json);
            TransferFundsNotification notification = (TransferFundsNotification)notificationMessage;
            Assert.AreEqual("TRANSFER_FUNDS", notification.EventType);
            Assert.IsNotNull(notification.Content);
            Assert.AreEqual(1000L, notification.Content.Amount.Value);
            Assert.AreEqual("testTransferCode", notification.Content.TransferCode);
            Assert.IsNotNull(notification.Error);
            Assert.AreEqual("000", notification.Error.ErrorCode);
            Assert.AreEqual("test error message", notification.Error.Message);

            Assert.IsNotNull(notification.Content.InvalidFields);
            Assert.AreEqual(1, notification.Content.InvalidFields.Count);
        }
        
        [TestMethod]
        public void MarketPayAccountUpdatedNotificationTest()
        {
            string json = GetFileContents("Mocks/marketpay/notification/account-updated-test.json");
           WebhookHandler webhookHandler = new WebhookHandler();
            IWebhookNotification notificationMessage = webhookHandler.HandleMarketpayNotificationJson(json);
            AccountUpdateNotification notification = (AccountUpdateNotification)notificationMessage;
            Assert.AreEqual("ACCOUNT_UPDATED", notification.EventType);
            Assert.IsNotNull(notification.Content);
            Assert.AreEqual(1, notification.Content.InvalidFields.Count);
        }

        [TestMethod]
        public void MarketPayAccountFundsBelowThresholdTest()
        {
            string json = GetFileContents("Mocks/marketpay/notification/account-funds-below-thresold-test.json");
           WebhookHandler webhookHandler = new WebhookHandler();
            IWebhookNotification notificationMessage = webhookHandler.HandleMarketpayNotificationJson(json);
            AccountFundsBelowThresholdNotification notification = (AccountFundsBelowThresholdNotification)notificationMessage;
            Assert.AreEqual("ACCOUNT_FUNDS_BELOW_THRESHOLD", notification.EventType);
            Assert.IsNotNull(notification.Content);
            Assert.AreEqual("TestAccountHolder", notification.Content.AccountCode);
            Assert.AreEqual(100L, notification.Content.FundThreshold.Value);
            Assert.AreEqual(96, notification.Content.CurrentFunds.Value);
        }

        [TestMethod]
        public void MarketPayAccountHolderStoreStatusChangeTest()
        {
            string json = GetFileContents("Mocks/marketpay/notification/account-holder-store-status-change-test.json");
           WebhookHandler webhookHandler = new WebhookHandler();

            IWebhookNotification notificationMessage = webhookHandler.HandleMarketpayNotificationJson(json);
            AccountHolderStoreStatusChangeNotification notification = (AccountHolderStoreStatusChangeNotification)notificationMessage;

            Assert.AreEqual("ACCOUNT_HOLDER_STORE_STATUS_CHANGE", notification.EventType);
            Assert.IsNotNull(notification.Content);
            Assert.AreEqual("AH000001", notification.Content.AccountHolderCode);
            Assert.AreEqual("x00x00x00-xx00-0xx0-x000-00xx00xx000000", notification.Content.Store);
        }

        [TestMethod]
        public void MarketPayAccountHolderUpcomingDeadlineTest()
        {
            string json = GetFileContents("Mocks/marketpay/notification/account-holder-upcoming-deadline-test.json");
           WebhookHandler webhookHandler = new WebhookHandler();

            IWebhookNotification notificationMessage = webhookHandler.HandleMarketpayNotificationJson(json);
            AccountHolderUpcomingDeadlineNotification notification = (AccountHolderUpcomingDeadlineNotification)notificationMessage;

            Assert.AreEqual("ACCOUNT_HOLDER_UPCOMING_DEADLINE", notification.EventType);
            Assert.IsNotNull(notification.Content);
            Assert.AreEqual("testD47", notification.Content.AccountHolderCode);
            Assert.AreEqual("InactivateAccount", notification.Content.Event);
        }

        [TestMethod]
        public void MarketPayDirectDebitInitiatedTest()
        {
            string json = GetFileContents("Mocks/marketpay/notification/direct-debit-initiated-test.json");
           WebhookHandler webhookHandler = new WebhookHandler();
            IWebhookNotification notificationMessage = webhookHandler.HandleMarketpayNotificationJson(json);
            DirectDebitInitiatedNotification notification = (DirectDebitInitiatedNotification)notificationMessage;
            Assert.AreEqual("DIRECT_DEBIT_INITIATED", notification.EventType);
            Assert.IsNotNull(notification.Content);
            Assert.AreEqual("100000000", notification.Content.AccountCode);
            Assert.AreEqual("TestMarketPlaceMerchant", notification.Content.MerchantAccountCode);
        }
        
        [TestMethod]
        public void MarketPayRefundFundsTransferTest()
        {
            string json = GetFileContents("Mocks/marketpay/notification/refund-funds-transfer-test.json");
           WebhookHandler webhookHandler = new WebhookHandler();
            IWebhookNotification notificationMessage = webhookHandler.HandleMarketpayNotificationJson(json);
            RefundFundsTransferNotification notification = (RefundFundsTransferNotification)notificationMessage;
            Assert.AreEqual("REFUND_FUNDS_TRANSFER", notification.EventType);
            Assert.IsNotNull(notification.Content);
            Assert.AreEqual("MRef#000001", notification.Content.MerchantReference);
            Assert.AreEqual("TSTPSPR0000000PT", notification.Content.OriginalReference);
            Assert.IsTrue(notification.Content.InvalidFields.Count > 0);
        }


    }
}
