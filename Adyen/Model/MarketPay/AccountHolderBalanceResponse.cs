using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// AccountHolderBalanceResponse
    /// </summary>
    [DataContract]
    public class AccountHolderBalanceResponse : IEquatable<AccountHolderBalanceResponse>, IValidatableObject
    {
        /// <summary>
        /// A list of each account and their balances.
        /// </summary>
        /// <value>A list of each account and their balances.</value>
        [DataMember(Name = "balancePerAccount", EmitDefaultValue = false)]
        public List<AccountDetailBalance> BalancePerAccount { get; set; }

        /// <summary>
        /// Contains field validation errors that would prevent requests from being processed.
        /// </summary>
        /// <value>Contains field validation errors that would prevent requests from being processed.</value>
        [DataMember(Name = "invalidFields", EmitDefaultValue = false)]
        [JsonProperty(propertyName: "invalidFields")]
        public List<ErrorFieldType> InvalidFields { get; set; }

        /// <summary>
        /// The reference of a request.  Can be used to uniquely identify the request.
        /// </summary>
        /// <value>The reference of a request.  Can be used to uniquely identify the request.</value>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        [JsonProperty(propertyName: "pspReference")]
        public string PspReference { get; set; }

        /// <summary>
        /// The result code.
        /// </summary>
        /// <value>The result code.</value>
        [DataMember(Name = "resultCode", EmitDefaultValue = false)]
        [JsonProperty(propertyName: "resultCode")]
        public string ResultCode { get; set; }

        /// <summary>
        /// Gets or Sets TotalBalance
        /// </summary>
        [DataMember(Name = "totalBalance", EmitDefaultValue = false)]
        [JsonProperty(propertyName: "totalBalance")]
        public DetailBalance TotalBalance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountHolderBalanceResponse {\n");
            sb.Append("  BalancePerAccount: ").Append(BalancePerAccount).Append("\n");
            sb.Append("  InvalidFields: ").Append(InvalidFields).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
            sb.Append("  TotalBalance: ").Append(TotalBalance).Append("\n");
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
            return Equals(input as AccountHolderBalanceResponse);
        }

        /// <summary>
        /// Returns true if AccountHolderBalanceResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountHolderBalanceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountHolderBalanceResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    BalancePerAccount == input.BalancePerAccount ||
                    BalancePerAccount != null &&
                    input.BalancePerAccount != null
                ) &&
                (
                    InvalidFields == input.InvalidFields ||
                    InvalidFields != null &&
                    input.InvalidFields != null &&
                    InvalidFields.SequenceEqual(input.InvalidFields)
                ) &&
                (
                    PspReference == input.PspReference ||
                    (PspReference != null &&
                    PspReference.Equals(input.PspReference))
                ) &&
                (
                    ResultCode == input.ResultCode ||
                    (ResultCode != null &&
                    ResultCode.Equals(input.ResultCode))
                ) &&
                (
                    TotalBalance == input.TotalBalance ||
                    (TotalBalance != null &&
                    TotalBalance.Equals(input.TotalBalance))
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
                if (BalancePerAccount != null)
                    hashCode = hashCode * 59 + BalancePerAccount.GetHashCode();
                if (InvalidFields != null)
                    hashCode = hashCode * 59 + InvalidFields.GetHashCode();
                if (PspReference != null)
                    hashCode = hashCode * 59 + PspReference.GetHashCode();
                if (ResultCode != null)
                    hashCode = hashCode * 59 + ResultCode.GetHashCode();
                if (TotalBalance != null)
                    hashCode = hashCode * 59 + TotalBalance.GetHashCode();
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
