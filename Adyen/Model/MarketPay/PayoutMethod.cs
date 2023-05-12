using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// PayoutMethod
    /// </summary>
    [DataContract]
        public class PayoutMethod :  IEquatable<PayoutMethod>, IValidatableObject
    {
        /// <summary>
        /// Defines PayoutMethodType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum PayoutMethodTypeEnum
        {
            /// <summary>
            /// Enum CardToken for value: CardToken
            /// </summary>
            [EnumMember(Value = "CardToken")]
            CardToken = 1        }
        /// <summary>
        /// Gets or Sets PayoutMethodType
        /// </summary>
        [DataMember(Name="payoutMethodType", EmitDefaultValue=false)]
        public PayoutMethodTypeEnum? PayoutMethodType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutMethod" /> class.
        /// </summary>
        /// <param name="merchantAccount">merchantAccount (required).</param>
        /// <param name="payoutMethodCode">payoutMethodCode.</param>
        /// <param name="payoutMethodType">payoutMethodType.</param>
        /// <param name="recurringDetailReference">recurringDetailReference (required).</param>
        /// <param name="shopperReference">shopperReference (required).</param>
        public PayoutMethod(string merchantAccount = default(string), string payoutMethodCode = default(string), PayoutMethodTypeEnum? payoutMethodType = default(PayoutMethodTypeEnum?), string recurringDetailReference = default(string), string shopperReference = default(string))
        {
            // to ensure "merchantAccount" is required (not null)
            if (merchantAccount == null)
            {
                throw new InvalidDataException("merchantAccount is a required property for PayoutMethod and cannot be null");
            }

            MerchantAccount = merchantAccount;
            // to ensure "recurringDetailReference" is required (not null)
            if (recurringDetailReference == null)
            {
                throw new InvalidDataException("recurringDetailReference is a required property for PayoutMethod and cannot be null");
            }

            RecurringDetailReference = recurringDetailReference;
            // to ensure "shopperReference" is required (not null)
            if (shopperReference == null)
            {
                throw new InvalidDataException("shopperReference is a required property for PayoutMethod and cannot be null");
            }

            ShopperReference = shopperReference;
            PayoutMethodCode = payoutMethodCode;
            PayoutMethodType = payoutMethodType;
        }
        
        /// <summary>
        /// Gets or Sets MerchantAccount
        /// </summary>
        [DataMember(Name="merchantAccount", EmitDefaultValue=false)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// Gets or Sets PayoutMethodCode
        /// </summary>
        [DataMember(Name="payoutMethodCode", EmitDefaultValue=false)]
        public string PayoutMethodCode { get; set; }


        /// <summary>
        /// Gets or Sets RecurringDetailReference
        /// </summary>
        [DataMember(Name="recurringDetailReference", EmitDefaultValue=false)]
        public string RecurringDetailReference { get; set; }

        /// <summary>
        /// Gets or Sets ShopperReference
        /// </summary>
        [DataMember(Name="shopperReference", EmitDefaultValue=false)]
        public string ShopperReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayoutMethod {\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  PayoutMethodCode: ").Append(PayoutMethodCode).Append("\n");
            sb.Append("  PayoutMethodType: ").Append(PayoutMethodType).Append("\n");
            sb.Append("  RecurringDetailReference: ").Append(RecurringDetailReference).Append("\n");
            sb.Append("  ShopperReference: ").Append(ShopperReference).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as PayoutMethod);
        }

        /// <summary>
        /// Returns true if PayoutMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of PayoutMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayoutMethod input)
        {
            if (input == null)
                return false;

            return 
                (
                    MerchantAccount == input.MerchantAccount ||
                    (MerchantAccount != null &&
                    MerchantAccount.Equals(input.MerchantAccount))
                ) && 
                (
                    PayoutMethodCode == input.PayoutMethodCode ||
                    (PayoutMethodCode != null &&
                    PayoutMethodCode.Equals(input.PayoutMethodCode))
                ) && 
                (
                    PayoutMethodType == input.PayoutMethodType ||
                    (PayoutMethodType != null &&
                    PayoutMethodType.Equals(input.PayoutMethodType))
                ) && 
                (
                    RecurringDetailReference == input.RecurringDetailReference ||
                    (RecurringDetailReference != null &&
                    RecurringDetailReference.Equals(input.RecurringDetailReference))
                ) && 
                (
                    ShopperReference == input.ShopperReference ||
                    (ShopperReference != null &&
                    ShopperReference.Equals(input.ShopperReference))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (MerchantAccount != null)
                    hashCode = hashCode * 59 + MerchantAccount.GetHashCode();
                if (PayoutMethodCode != null)
                    hashCode = hashCode * 59 + PayoutMethodCode.GetHashCode();
                if (PayoutMethodType != null)
                    hashCode = hashCode * 59 + PayoutMethodType.GetHashCode();
                if (RecurringDetailReference != null)
                    hashCode = hashCode * 59 + RecurringDetailReference.GetHashCode();
                if (ShopperReference != null)
                    hashCode = hashCode * 59 + ShopperReference.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
