#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

namespace Adyen.Model.Notification
{
    public class NotificationRequestConst
    {
        //Event codes
        public const string EventCodeAuthorisation = "AUTHORISATION";
        public const string EventCodeAuthorisationAdjustment = "AUTHORISATION_ADJUSTMENT";
        public const string EventCodeCancellation = "CANCELLATION";
        public const string EventCodeCancelOrRefund = "CANCEL_OR_REFUND";
        public const string EventCodeCapture = "CAPTURE";
        public const string EventCodeCaptureFailed = "CAPTURE_FAILED";
        public const string EventCodeChargeback = "CHARGEBACK";
        public const string EventCodeChargebackReversed = "CHARGEBACK_REVERSED";
        public const string EventCodeHandledExternally = "HANDLED_EXTERNALLY";
        public const string EventCodeManualReviewAccept = "MANUAL_REVIEW_ACCEPT";
        public const string EventCodeManualReviewReject = "MANUAL_REVIEW_REJECT";
        public const string EventCodeNotificationOfChargeback = "NOTIFICATION_OF_CHARGEBACK";
        public const string EventCodeNotificationOfFraud = "NOTIFICATION_OF_FRAUD";
        public const string EventCodeOfferClosed = "OFFER_CLOSED";
        public const string EventCodeOrderClosed = "ORDER_CLOSED";
        public const string EventCodeOrderOpened = "ORDER_OPENED";
        public const string EventCodePaidoutReversed = "PAIDOUT_REVERSED";
        public const string EventCodePayoutDecline = "PAYOUT_DECLINE";
        public const string EventCodePayoutExpire = "PAYOUT_EXPIRE";
        public const string EventCodePayoutThirdparty = "PAYOUT_THIRDPARTY";
        public const string EventCodePending = "PENDING";
        public const string EventCodePostponedRefund = "POSTPONED_REFUND";
        public const string EventCodePrearbitrationLost = "PREARBITRATION_LOST";
        public const string EventCodePrearbitrationWon = "PREARBITRATION_WON";
        public const string EventCodeProcessRetry = "PROCESS_RETRY";
        public const string EventCodeRecurringContract = "RECURRING_CONTRACT";
        public const string EventCodeRefund = "REFUND";
        public const string EventCodeRefundedReversed = "REFUNDED_REVERSED";
        public const string EventCodeRefundFailed = "REFUND_FAILED";
        public const string EventCodeRefundWithData = "REFUND_WITH_DATA";
        public const string EventCodeReportAvailable = "REPORT_AVAILABLE";
        public const string EventCodeRequestForInformation = "REQUEST_FOR_INFORMATION";
        public const string EventCodeSecondChargeback = "SECOND_CHARGEBACK";
        public const string EventCodeVoidPendingRefund = "VOID_PENDING_REFUND";

        //Additional Data
        public const string AdditionalDataTotalFraudScore = "totalFraudScore";
        public const string AdditionalDataFraudCheckPattern = "fraudCheck-(\\d+)-([A-Za-z0-9]+)";
    }
}