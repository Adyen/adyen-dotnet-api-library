// using Adyen.Model.PlatformsWebhooks;
// using Newtonsoft.Json;
//
// namespace Adyen.Webhooks
// {
//     public class ClassicPlatformWebhookHandler
//     {
//         /// <summary>
//         /// Deserializes <see cref="AccountCreateNotification"/> from the <paramref name="jsonPayload"/>.
//         /// </summary>
//         /// <param name="jsonPayload">The json payload of the webhook.</param>
//         /// <param name="result"><see cref="AccountCreateNotification"/>.</param>
//         /// <returns>A return value indicates whether the deserialization succeeded.</returns>
//         /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
//         public bool GetAccountCreateNotification(string jsonPayload, out AccountCreateNotification result)
//         {
//             result = null;
//             try
//             {
//                 result = JsonConvert.DeserializeObject<AccountCreateNotification>(jsonPayload);
//                 return "ACCOUNT_CREATED".Equals(result.EventType);
//             }
//             catch (JsonSerializationException)
//             {
//                 return false;
//             }
//         }
//         
//         /// <summary>
//         /// Deserializes <see cref="AccountCloseNotification"/> from the <paramref name="jsonPayload"/>.
//         /// </summary>
//         /// <param name="jsonPayload">The json payload of the webhook.</param>
//         /// <param name="result"><see cref="AccountCreateNotification"/>.</param>
//         /// <returns>A return value indicates whether the deserialization succeeded.</returns>
//         /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
//         public bool GetAccountCloseNotification(string jsonPayload, out AccountCloseNotification result)
//         {
//             result = null;
//             try
//             {
//                 result = JsonConvert.DeserializeObject<AccountCloseNotification>(jsonPayload);
//                 return "ACCOUNT_CLOSED".Equals(result.EventType);
//             }
//             catch (JsonSerializationException)
//             {
//                 return false;
//             }
//         }
//         
//         /// <summary>
//         /// Deserializes <see cref="AccountFundsBelowThresholdNotification"/> from the <paramref name="jsonPayload"/>.
//         /// </summary>
//         /// <param name="jsonPayload">The json payload of the webhook.</param>
//         /// <param name="result"><see cref="AccountFundsBelowThresholdNotification"/>.</param>
//         /// <returns>A return value indicates whether the deserialization succeeded.</returns>
//         /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
//         public bool GetAccountFundsBelowThresholdNotification(string jsonPayload, out AccountFundsBelowThresholdNotification result)
//         {
//             result = null;
//             try
//             {
//                 result = JsonConvert.DeserializeObject<AccountFundsBelowThresholdNotification>(jsonPayload);
//                 return "ACCOUNT_FUNDS_BELOW_THRESHOLD".Equals(result.EventType);
//             }
//             catch (JsonSerializationException)
//             {
//                 return false;
//             }
//         }
//         
//         /// <summary>
//         /// Deserializes <see cref="AccountHolderCreateNotification"/> from the <paramref name="jsonPayload"/>.
//         /// </summary>
//         /// <param name="jsonPayload">The json payload of the webhook.</param>
//         /// <param name="result"><see cref="AccountHolderCreateNotification"/>.</param>
//         /// <returns>A return value indicates whether the deserialization succeeded.</returns>
//         /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
//         public bool GetAccountHolderCreateNotification(string jsonPayload, out AccountHolderCreateNotification result)
//         {
//             result = null;
//             try
//             {
//                 result = JsonConvert.DeserializeObject<AccountHolderCreateNotification>(jsonPayload);
//                 return "ACCOUNT_HOLDER_CREATED".Equals(result.EventType);
//             }
//             catch (JsonSerializationException)
//             {
//                 return false;
//             }
//         }
//         
//         /// <summary>
//         /// Deserializes <see cref="AccountHolderPayoutNotification"/> from the <paramref name="jsonPayload"/>.
//         /// </summary>
//         /// <param name="jsonPayload">The json payload of the webhook.</param>
//         /// <param name="result"><see cref="AccountHolderPayoutNotification"/>.</param>
//         /// <returns>A return value indicates whether the deserialization succeeded.</returns>
//         /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
//         public bool GetAccountHolderPayoutNotification(string jsonPayload, out AccountHolderPayoutNotification result)
//         {
//             result = null;
//             try
//             {
//                 result = JsonConvert.DeserializeObject<AccountHolderPayoutNotification>(jsonPayload);
//                 return "ACCOUNT_HOLDER_PAYOUT".Equals(result.EventType);
//             }
//             catch (JsonSerializationException)
//             {
//                 return false;
//             }
//         }
//         
//         /// <summary>
//         /// Deserializes <see cref="AccountHolderStatusChangeNotification"/> from the <paramref name="jsonPayload"/>.
//         /// </summary>
//         /// <param name="jsonPayload">The json payload of the webhook.</param>
//         /// <param name="result"><see cref="AccountHolderStatusChangeNotification"/>.</param>
//         /// <returns>A return value indicates whether the deserialization succeeded.</returns>
//         /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
//         public bool GetAccountHolderStatusChangeNotification(string jsonPayload, out AccountHolderStatusChangeNotification result)
//         {
//             result = null;
//             try
//             {
//                 result = JsonConvert.DeserializeObject<AccountHolderStatusChangeNotification>(jsonPayload);
//                 return "ACCOUNT_HOLDER_STATUS_CHANGE".Equals(result.EventType);
//             }
//             catch (JsonSerializationException)
//             {
//                 return false;
//             }
//         }
//         
//         /// <summary>
//         /// Deserializes <see cref="AccountHolderUpcomingDeadlineNotification"/> from the <paramref name="jsonPayload"/>.
//         /// </summary>
//         /// <param name="jsonPayload">The json payload of the webhook.</param>
//         /// <param name="result"><see cref="AccountHolderUpcomingDeadlineNotification"/>.</param>
//         /// <returns>A return value indicates whether the deserialization succeeded.</returns>
//         /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
//         public bool GetAccountHolderUpcomingDeadlineNotification(string jsonPayload, out AccountHolderUpcomingDeadlineNotification result)
//         {
//             result = null;
//             try
//             {
//                 result = JsonConvert.DeserializeObject<AccountHolderUpcomingDeadlineNotification>(jsonPayload);
//                 return "ACCOUNT_HOLDER_UPCOMING_DEADLINE".Equals(result.EventType);
//             }
//             catch (JsonSerializationException)
//             {
//                 return false;
//             }
//         }
//         
//         /// <summary>
//         /// Deserializes <see cref="AccountHolderUpdateNotification"/> from the <paramref name="jsonPayload"/>.
//         /// </summary>
//         /// <param name="jsonPayload">The json payload of the webhook.</param>
//         /// <param name="result"><see cref="AccountHolderUpdateNotification"/>.</param>
//         /// <returns>A return value indicates whether the deserialization succeeded.</returns>
//         /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
//         public bool GetAccountHolderUpdateNotification(string jsonPayload, out AccountHolderUpdateNotification result)
//         {
//             result = null;
//             try
//             {
//                 result = JsonConvert.DeserializeObject<AccountHolderUpdateNotification>(jsonPayload);
//                 return "ACCOUNT_HOLDER_UPDATED".Equals(result.EventType);
//             }
//             catch (JsonSerializationException)
//             {
//                 return false;
//             }
//         }
//         
//         /// <summary>
//         /// Deserializes <see cref="AccountHolderVerificationNotification"/> from the <paramref name="jsonPayload"/>.
//         /// </summary>
//         /// <param name="jsonPayload">The json payload of the webhook.</param>
//         /// <param name="result"><see cref="AccountHolderVerificationNotification"/>.</param>
//         /// <returns>A return value indicates whether the deserialization succeeded.</returns>
//         /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
//         public bool GetAccountHolderVerificationNotification(string jsonPayload, out AccountHolderVerificationNotification result)
//         {
//             result = null;
//             try
//             {
//                 result = JsonConvert.DeserializeObject<AccountHolderVerificationNotification>(jsonPayload);
//                 return "ACCOUNT_HOLDER_VERIFICATION".Equals(result.EventType);
//             }
//             catch (JsonSerializationException)
//             {
//                 return false;
//             }
//         }
//         
//         /// <summary>
//         /// Deserializes <see cref="AccountUpdateNotification"/> from the <paramref name="jsonPayload"/>.
//         /// </summary>
//         /// <param name="jsonPayload">The json payload of the webhook.</param>
//         /// <param name="result"><see cref="AccountUpdateNotification"/>.</param>
//         /// <returns>A return value indicates whether the deserialization succeeded.</returns>
//         /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
//         public bool GetAccountUpdateNotification(string jsonPayload, out AccountUpdateNotification result)
//         {
//             result = null;
//             try
//             {
//                 result = JsonConvert.DeserializeObject<AccountUpdateNotification>(jsonPayload);
//                 return "ACCOUNT_UPDATED".Equals(result.EventType);
//             }
//             catch (JsonSerializationException)
//             {
//                 return false;
//             }
//         }
//         
//         /// <summary>
//         /// Deserializes <see cref="BeneficiarySetupNotification"/> from the <paramref name="jsonPayload"/>.
//         /// </summary>
//         /// <param name="jsonPayload">The json payload of the webhook.</param>
//         /// <param name="result"><see cref="BeneficiarySetupNotification"/>.</param>
//         /// <returns>A return value indicates whether the deserialization succeeded.</returns>
//         /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
//         public bool GetBeneficiarySetupNotification(string jsonPayload, out BeneficiarySetupNotification result)
//         {            
//             result = null;
//             try
//             {
//                 result = JsonConvert.DeserializeObject<BeneficiarySetupNotification>(jsonPayload);
//                 return "BENEFICIARY_SETUP".Equals(result.EventType);
//             }
//             catch (JsonSerializationException)
//             {
//                 return false;
//             }
//         }
//         
//         /// <summary>
//         /// Deserializes <see cref="CompensateNegativeBalanceNotification"/> from the <paramref name="jsonPayload"/>.
//         /// </summary>
//         /// <param name="jsonPayload">The json payload of the webhook.</param>
//         /// <param name="result"><see cref="CompensateNegativeBalanceNotification"/>.</param>
//         /// <returns>A return value indicates whether the deserialization succeeded.</returns>
//         /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
//         public bool GetCompensateNegativeBalanceNotification(string jsonPayload, out CompensateNegativeBalanceNotification result)
//         {
//             result = null;
//             try
//             {
//                 result = JsonConvert.DeserializeObject<CompensateNegativeBalanceNotification>(jsonPayload);
//                 return "COMPENSATE_NEGATIVE_BALANCE".Equals(result.EventType);
//             }
//             catch (JsonSerializationException)
//             {
//                 return false;
//             }
//         }
//         
//         /// <summary>
//         /// Deserializes <see cref="DirectDebitInitiatedNotification"/> from the <paramref name="jsonPayload"/>.
//         /// </summary>
//         /// <param name="jsonPayload">The json payload of the webhook.</param>
//         /// <param name="result"><see cref="DirectDebitInitiatedNotification"/>.</param>
//         /// <returns>A return value indicates whether the deserialization succeeded.</returns>
//         /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
//         public bool GetDirectDebitInitiatedNotification(string jsonPayload, out DirectDebitInitiatedNotification result)
//         {
//             result = null;
//             try
//             { 
//                 result = JsonConvert.DeserializeObject<DirectDebitInitiatedNotification>(jsonPayload);
//                 return "DIRECT_DEBIT_INITIATED".Equals(result.EventType);
//             }
//             catch (JsonSerializationException)
//             {
//                 return false;
//             }
//         }
//         
//         /// <summary>
//         /// Deserializes <see cref="PaymentFailureNotification"/> from the <paramref name="jsonPayload"/>.
//         /// </summary>
//         /// <param name="jsonPayload">The json payload of the webhook.</param>
//         /// <param name="result"><see cref="PaymentFailureNotification"/>.</param>
//         /// <returns>A return value indicates whether the deserialization succeeded.</returns>
//         /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
//         public bool GetPaymentFailureNotification(string jsonPayload, out PaymentFailureNotification result)
//         {
//             result = null;
//             try
//             {
//                 result = JsonConvert.DeserializeObject<PaymentFailureNotification>(jsonPayload);
//                 return "PAYMENT_FAILURE".Equals(result.EventType);
//             }
//             catch (JsonSerializationException)
//             {
//                 return false;
//             }
//         }
//         
//         /// <summary>
//         /// Deserializes <see cref="RefundFundsTransferNotification"/> from the <paramref name="jsonPayload"/>.
//         /// </summary>
//         /// <param name="jsonPayload">The json payload of the webhook.</param>
//         /// <param name="result"><see cref="RefundFundsTransferNotification"/>.</param>
//         /// <returns>A return value indicates whether the deserialization succeeded.</returns>
//         /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
//         public bool GetRefundFundsTransferNotification(string jsonPayload, out RefundFundsTransferNotification result)
//         {
//             result = null;
//             try
//             {
//                 result = JsonConvert.DeserializeObject<RefundFundsTransferNotification>(jsonPayload);
//                 return "REFUND_FUNDS_TRANSFER".Equals(result.EventType);
//             }
//             catch (JsonSerializationException)
//             {
//                 return false;
//             }
//         }
//         
//         /// <summary>
//         /// Deserializes <see cref="ReportAvailableNotification"/> from the <paramref name="jsonPayload"/>.
//         /// </summary>
//         /// <param name="jsonPayload">The json payload of the webhook.</param>
//         /// <param name="result"><see cref="ReportAvailableNotification"/>.</param>
//         /// <returns>A return value indicates whether the deserialization succeeded.</returns>
//         /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
//         public bool GetReportAvailableNotification(string jsonPayload, out ReportAvailableNotification result)
//         {
//             result = null;
//             try
//             {
//                 result = JsonConvert.DeserializeObject<ReportAvailableNotification>(jsonPayload);
//                 return "REPORT_AVAILABLE".Equals(result.EventType);
//             }
//             catch (JsonSerializationException)
//             {
//                 return false;
//             }
//         }
//         
//         /// <summary>
//         /// Deserializes <see cref="ScheduledRefundsNotification"/> from the <paramref name="jsonPayload"/>.
//         /// </summary>
//         /// <param name="jsonPayload">The json payload of the webhook.</param>
//         /// <param name="result"><see cref="ScheduledRefundsNotification"/>.</param>
//         /// <returns>A return value indicates whether the deserialization succeeded.</returns>
//         /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
//         public bool GetScheduledRefundsNotification(string jsonPayload, out ScheduledRefundsNotification result)
//         {
//             result = null;
//             try
//             {
//                 result = JsonConvert.DeserializeObject<ScheduledRefundsNotification>(jsonPayload);
//                 return "SCHEDULED_REFUNDS".Equals(result.EventType);
//             }
//             catch (JsonSerializationException)
//             {
//                 return false;
//             }
//         }
//         
//         /// <summary>
//         /// Deserializes <see cref="TransferFundsNotification"/> from the <paramref name="jsonPayload"/>.
//         /// </summary>
//         /// <param name="jsonPayload">The json payload of the webhook.</param>
//         /// <param name="result"><see cref="TransferFundsNotification"/>.</param>
//         /// <returns>A return value indicates whether the deserialization succeeded.</returns>
//         /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
//         public bool GetTransferFundsNotification(string jsonPayload, out TransferFundsNotification result)
//         {
//             result = null;
//             try
//             {
//                 result = JsonConvert.DeserializeObject<TransferFundsNotification>(jsonPayload);
//                 return "TRANSFER_FUNDS".Equals(result.EventType);
//             }
//             catch (JsonSerializationException)
//             {
//                 return false;
//             }
//         }
//     }
// }