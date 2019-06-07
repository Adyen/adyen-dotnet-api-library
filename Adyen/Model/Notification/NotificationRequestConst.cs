namespace Adyen.Model.Notification
{
    public class NotificationRequestConst
    {
        public const string EventCodeAuthorisation = "AUTHORISATION";

        //Event codes
        public const string EventCodeCancellation = "CANCELLATION";
        public const string EventCodeRefund = "REFUND";
        public const string EventCodeCancelOrRefund = "CANCEL_OR_REFUND";
        public const string EventCodeCapture = "CAPTURE";
        public const string EventCodeCaptureFailed = "CAPTURE_FAILED";
        public const string EventCodeRefundFailed = "REFUND_FAILED";
        public const string EventCodeRefundedReversed = "REFUNDED_REVERSED";
        public const string EventCodePaidoutReversed = "PAIDOUT_REVERSED";

        //Additional Data
        public const string AdditionalDataTotalFraudScore = "totalFraudScore";
        public const string AdditionalDataFraudCheckPattern = "fraudCheck-(\\d+)-([A-Za-z0-9]+)";
    }
}