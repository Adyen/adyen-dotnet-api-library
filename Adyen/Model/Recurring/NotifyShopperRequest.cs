#region License
/*
 *                       ######
 *                       ######
 * ############    ####( ######  #####. ######  ############   ############
 * #############  #####( ######  #####. ######  #############  #############
 *        ######  #####( ######  #####. ######  #####  ######  #####  ######
 * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
 * ###### ######  #####( ######  #####. ######  #####          #####  ######
 * #############  #############  #############  #############  #####  ######
 *  ############   ############  #############   ############  #####  ######
 *                                      ######
 *                               #############
 *                               ############
 *
 * Adyen Dotnet API Library
 *
 * Copyright (c) 2021 Adyen B.V.
 * This file is open source and available under the MIT license.
 * See the LICENSE file for more info.
 */
#endregion
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Adyen.Model.Recurring
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class NotifyShopperRequest
    {
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "amount")]
        public Amount Amount { get; set; }

        /// <summary>
        /// Date on which the subscription amount will be debited from the shopper. In YYYY-MM-DD format
        /// </summary>
        /// <value>Date on which the subscription amount will be debited from the shopper. In YYYY-MM-DD format</value>
        [DataMember(Name = "billingDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "billingDate")]
        public string BillingDate { get; set; }

        /// <summary>
        /// Sequence of the debit. Depends on Frequency and Billing Attempts Rule.
        /// </summary>
        /// <value>Sequence of the debit. Depends on Frequency and Billing Attempts Rule.</value>
        [DataMember(Name = "billingSequenceNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "billingSequenceNumber")]
        public string BillingSequenceNumber { get; set; }

        /// <summary>
        /// Reference of Pre-debit notification that is displayed to the shopper. Optional field. Maps to reference if missing
        /// </summary>
        /// <value>Reference of Pre-debit notification that is displayed to the shopper. Optional field. Maps to reference if missing</value>
        [DataMember(Name = "displayedReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "displayedReference")]
        public string DisplayedReference { get; set; }

        /// <summary>
        /// The merchant account identifier with which you want to process the transaction.
        /// </summary>
        /// <value>The merchant account identifier with which you want to process the transaction.</value>
        [DataMember(Name = "merchantAccount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantAccount")]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// This is the `recurringDetailReference` returned in the response when you created the token.
        /// </summary>
        /// <value>This is the `recurringDetailReference` returned in the response when you created the token.</value>
        [DataMember(Name = "recurringDetailReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "recurringDetailReference")]
        public string RecurringDetailReference { get; set; }

        /// <summary>
        /// Pre-debit notification reference sent by the merchant. This is a mandatory field
        /// </summary>
        /// <value>Pre-debit notification reference sent by the merchant. This is a mandatory field</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "reference")]
        public string Reference { get; set; }

        /// <summary>
        /// The ID that uniquely identifies the shopper.  This `shopperReference` must be the same as the `shopperReference` used in the initial payment.
        /// </summary>
        /// <value>The ID that uniquely identifies the shopper.  This `shopperReference` must be the same as the `shopperReference` used in the initial payment.</value>
        [DataMember(Name = "shopperReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shopperReference")]
        public string ShopperReference { get; set; }

        /// <summary>
        /// This is the `recurringDetailReference` returned in the response when you created the token.
        /// </summary>
        /// <value>This is the `recurringDetailReference` returned in the response when you created the token.</value>
        [DataMember(Name = "storedPaymentMethodId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "storedPaymentMethodId")]
        public string StoredPaymentMethodId { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NotifyShopperRequest {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BillingDate: ").Append(BillingDate).Append("\n");
            sb.Append("  BillingSequenceNumber: ").Append(BillingSequenceNumber).Append("\n");
            sb.Append("  DisplayedReference: ").Append(DisplayedReference).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  RecurringDetailReference: ").Append(RecurringDetailReference).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  ShopperReference: ").Append(ShopperReference).Append("\n");
            sb.Append("  StoredPaymentMethodId: ").Append(StoredPaymentMethodId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
