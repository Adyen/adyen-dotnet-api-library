#region Licence

// 
//                        ######
//                        ######
//  ############    ####( ######  #####. ######  ############   ############
//  #############  #####( ######  #####. ######  #############  #############
//         ######  #####( ######  #####. ######  #####  ######  #####  ######
//  ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  ###### ######  #####( ######  #####. ######  #####          #####  ######
//  #############  #############  #############  #############  #####  ######
//   ############   ############  #############   ############  #####  ######
//                                       ######
//                                #############
//                                ############
// 
//  Adyen Dotnet API Library
// 
//  Copyright (c) 2021 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.

#endregion

using System;
using Adyen.Model.MarketPay.Notification;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Adyen.Util
{
    internal class MarketPayNotificationConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IGenericNotification);
        }
        public override void WriteJson(JsonWriter writer,
            object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }

        public override object ReadJson(JsonReader reader,
           Type objectType, object existingValue,
           JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var notification = default(IGenericNotification);
            switch (jsonObject["eventType"].ToString())
            {
                case "ACCOUNT_CREATED":
                    notification = new AccountCreateNotification();
                    break;
                case "ACCOUNT_CLOSED":
                    notification = new AccountCloseNotification();
                    break;
                case "ACCOUNT_UPDATED":
                    notification = new AccountUpdateNotification();
                    break;
                case "ACCOUNT_FUNDS_BELOW_THRESHOLD":
                    notification = new AccountFundsBelowThresholdNotification();
                    break;
                case "ACCOUNT_HOLDER_CREATED":
                    notification = new AccountHolderCreateNotification();
                    break;
                case "ACCOUNT_HOLDER_VERIFICATION":
                    notification = new AccountHolderVerificationNotification();
                    break;
                case "ACCOUNT_HOLDER_STATUS_CHANGE":
                    notification = new AccountHolderStatusChangeNotification();
                    break;
                case "ACCOUNT_HOLDER_PAYOUT":
                    notification = new AccountHolderPayoutNotification();
                    break;
                case "ACCOUNT_HOLDER_UPDATED":
                    notification = new AccountHolderUpdateNotification();
                    break;
                case "ACCOUNT_HOLDER_STORE_STATUS_CHANGE":
                    notification = new AccountHolderStoreStatusChangeNotification();
                    break;
                case "ACCOUNT_HOLDER_UPCOMING_DEADLINE":
                    notification = new AccountHolderUpcomingDeadlineNotification();
                    break;
                case "BENEFICIARY_SETUP":
                    notification = new BeneficiarySetupNotification();
                    break;
                case "SCHEDULED_REFUNDS":
                    notification = new ScheduledRefundsNotification();
                    break;
                case "COMPENSATE_NEGATIVE_BALANCE":
                    notification = new CompensateNegativeBalanceNotification();
                    break;
                case "PAYMENT_FAILURE":
                    notification = new PaymentFailureNotification();
                    break;
                case "REPORT_AVAILABLE":
                    notification = new ReportAvailableNotification();
                    break;
                case "TRANSFER_FUNDS":
                    notification = new TransferFundsNotification();
                    break;
                case "DIRECT_DEBIT_INITIATED":
                    notification = new DirectDebitInitiatedNotification();
                    break;
                case "REFUND_FUNDS_TRANSFER":
                    notification = new RefundFundsTransferNotification();
                    break;
            }

            serializer.Populate(jsonObject.CreateReader(), notification);
            return notification;
        }
    }
} 