using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.Model.Payout
{
    /// <summary>
    /// StoreDetailRequest
    /// </summary>
    [DataContract]
    public class StoreDetailRequest
    {
        /// <summary>
        /// This field contains additional data, which may be required for a particular request.
        /// </summary>
        /// <value>This field contains additional data, which may be required for a particular request.</value>
        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "additionalData")]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// Gets or Sets Bank
        /// </summary>
        [DataMember(Name = "bank", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bank")]
        public BankAccount Bank { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "billingAddress")]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Gets or Sets Card
        /// </summary>
        [DataMember(Name = "card", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "card")]
        public Card Card { get; set; }

        /// <summary>
        /// The date of birth. Format: [ISO-8601](https://www.w3.org/TR/NOTE-datetime); example: YYYY-MM-DD For Paysafecard it must be the same as used when registering the Paysafecard account. > This field is mandatory for natural persons.
        /// </summary>
        /// <value>The date of birth. Format: [ISO-8601](https://www.w3.org/TR/NOTE-datetime); example: YYYY-MM-DD For Paysafecard it must be the same as used when registering the Paysafecard account. > This field is mandatory for natural persons.</value>
        [DataMember(Name = "dateOfBirth", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dateOfBirth")]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// The type of the entity the payout is processed for.
        /// </summary>
        /// <value>The type of the entity the payout is processed for.</value>
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
        /// The merchant account identifier, with which you want to process the transaction.
        /// </summary>
        /// <value>The merchant account identifier, with which you want to process the transaction.</value>
        [DataMember(Name = "merchantAccount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantAccount")]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// The shopper's nationality.  A valid value is an ISO 2-character country code (e.g. 'NL').
        /// </summary>
        /// <value>The shopper's nationality.  A valid value is an ISO 2-character country code (e.g. 'NL').</value>
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
        /// The name of the brand to make a payout to.  For Paysafecard it must be set to `paysafecard`.
        /// </summary>
        /// <value>The name of the brand to make a payout to.  For Paysafecard it must be set to `paysafecard`.</value>
        [DataMember(Name = "selectedBrand", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "selectedBrand")]
        public string SelectedBrand { get; set; }

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
        /// The shopper's reference for the payment transaction.
        /// </summary>
        /// <value>The shopper's reference for the payment transaction.</value>
        [DataMember(Name = "shopperReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shopperReference")]
        public string ShopperReference { get; set; }

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
            sb.Append("class StoreDetailRequest {\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("  Bank: ").Append(Bank).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  FraudOffset: ").Append(FraudOffset).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  Nationality: ").Append(Nationality).Append("\n");
            sb.Append("  Recurring: ").Append(Recurring).Append("\n");
            sb.Append("  SelectedBrand: ").Append(SelectedBrand).Append("\n");
            sb.Append("  ShopperEmail: ").Append(ShopperEmail).Append("\n");
            sb.Append("  ShopperName: ").Append(ShopperName).Append("\n");
            sb.Append("  ShopperReference: ").Append(ShopperReference).Append("\n");
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
