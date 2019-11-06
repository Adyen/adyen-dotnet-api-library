using Adyen.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.Model.Payout
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class SubmitRequest
    {
        /// <summary>
        /// This field contains additional data, which may be required for a particular request.
        /// </summary>
        /// <value>This field contains additional data, which may be required for a particular request.</value>
        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "additionalData")]
        public Dictionary<string,string> AdditionalData { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "amount")]
        public Amount Amount { get; set; }

        /// <summary>
        /// The date of birth. Format: ISO-8601; example: YYYY-MM-DD  For Paysafecard it must be the same as used when registering the Paysafecard account.  > This field is mandatory for natural persons.  > This field is required to update the existing `dateOfBirth` that is associated with this recurring contract.
        /// </summary>
        /// <value>The date of birth. Format: ISO-8601; example: YYYY-MM-DD  For Paysafecard it must be the same as used when registering the Paysafecard account.  > This field is mandatory for natural persons.  > This field is required to update the existing `dateOfBirth` that is associated with this recurring contract.</value>
        [DataMember(Name = "dateOfBirth", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dateOfBirth")]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// The type of the entity the payout is processed for.  Allowed values: * NaturalPerson * Company > This field is required to update the existing `entityType` that is associated with this recurring contract.
        /// </summary>
        /// <value>The type of the entity the payout is processed for.  Allowed values: * NaturalPerson * Company > This field is required to update the existing `entityType` that is associated with this recurring contract.</value>
        [DataMember(Name = "entityType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "entityType")]
        public string EntityType { get; set; }

        /// <summary>
        /// An integer value that is added to the normal fraud score. The value can be either positive or negative.
        /// </summary>
        /// <value>An integer value that is added to the normal fraud score. The value can be either positive or negative.</value>
        [DataMember(Name = "fraudOffset", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fraudOffset")]
        public int? FraudOffset { get; set; }

        /// <summary>
        /// The merchant account identifier you want to process the transaction request with.
        /// </summary>
        /// <value>The merchant account identifier you want to process the transaction request with.</value>
        [DataMember(Name = "merchantAccount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantAccount")]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// The shopper's nationality.  A valid value is an ISO 2-character country code (e.g. 'NL').  > This field is required to update the existing nationality that is associated with this recurring contract.
        /// </summary>
        /// <value>The shopper's nationality.  A valid value is an ISO 2-character country code (e.g. 'NL').  > This field is required to update the existing nationality that is associated with this recurring contract.</value>
        [DataMember(Name = "nationality", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nationality")]
        public string Nationality { get; set; }

        /// <summary>
        /// Gets or Sets Recurring
        /// </summary>
        [DataMember(Name = "recurring", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "recurring")]
        public Recurring.Recurring Recurring { get; set; }

        /// <summary>
        /// The merchant reference for this payout. This reference will be used in all communication to the merchant about the status of the payout. Although it is a good idea to make sure it is unique, this is not a requirement.
        /// </summary>
        /// <value>The merchant reference for this payout. This reference will be used in all communication to the merchant about the status of the payout. Although it is a good idea to make sure it is unique, this is not a requirement.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "reference")]
        public string Reference { get; set; }

        /// <summary>
        /// This is the `recurringDetailReference` you want to use for this payout.  You can use the value LATEST to select the most recently used recurring detail.
        /// </summary>
        /// <value>This is the `recurringDetailReference` you want to use for this payout.  You can use the value LATEST to select the most recently used recurring detail.</value>
        [DataMember(Name = "selectedRecurringDetailReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "selectedRecurringDetailReference")]
        public string SelectedRecurringDetailReference { get; set; }

        /// <summary>
        /// The shopper's email address.
        /// </summary>
        /// <value>The shopper's email address.</value>
        [DataMember(Name = "shopperEmail", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shopperEmail")]
        public string ShopperEmail { get; set; }

        /// <summary>
        /// Gets or Sets ShopperName
        /// </summary>
        [DataMember(Name = "shopperName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shopperName")]
        public Name ShopperName { get; set; }

        /// <summary>
        /// The shopper's reference for the payout transaction.
        /// </summary>
        /// <value>The shopper's reference for the payout transaction.</value>
        [DataMember(Name = "shopperReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shopperReference")]
        public string ShopperReference { get; set; }

        /// <summary>
        /// The description of this payout. This description is shown on the bank statement of the shopper (if this is supported by the chosen payment method).
        /// </summary>
        /// <value>The description of this payout. This description is shown on the bank statement of the shopper (if this is supported by the chosen payment method).</value>
        [DataMember(Name = "shopperStatement", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shopperStatement")]
        public string ShopperStatement { get; set; }

        /// <summary>
        /// The shopper's social security number.
        /// </summary>
        /// <value>The shopper's social security number.</value>
        [DataMember(Name = "socialSecurityNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "socialSecurityNumber")]
        public string SocialSecurityNumber { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubmitRequest {\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  FraudOffset: ").Append(FraudOffset).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  Nationality: ").Append(Nationality).Append("\n");
            sb.Append("  Recurring: ").Append(Recurring).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  SelectedRecurringDetailReference: ").Append(SelectedRecurringDetailReference).Append("\n");
            sb.Append("  ShopperEmail: ").Append(ShopperEmail).Append("\n");
            sb.Append("  ShopperName: ").Append(ShopperName).Append("\n");
            sb.Append("  ShopperReference: ").Append(ShopperReference).Append("\n");
            sb.Append("  ShopperStatement: ").Append(ShopperStatement).Append("\n");
            sb.Append("  SocialSecurityNumber: ").Append(SocialSecurityNumber).Append("\n");
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
