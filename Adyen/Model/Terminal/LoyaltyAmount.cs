/*
* Adyen Terminal API
*
*
* The version of the OpenAPI document: 1
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.Terminal
{
    /// <summary>
    /// An awarded amount or an amount to redeem to the loyalty account might be sent in the Payment request message. Amount of a loyalty account.
    /// </summary>
    [DataContract(Name = "LoyaltyAmount")]
    public partial class LoyaltyAmount : IEquatable<LoyaltyAmount>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets LoyaltyUnit
        /// </summary>
        [DataMember(Name = "LoyaltyUnit", EmitDefaultValue = false)]
        public LoyaltyUnit? LoyaltyUnit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyAmount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LoyaltyAmount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyAmount" /> class.
        /// </summary>
        /// <param name="loyaltyUnit">loyaltyUnit.</param>
        /// <param name="currency">currency.</param>
        /// <param name="amountValue">amountValue (required).</param>
        public LoyaltyAmount(LoyaltyUnit? loyaltyUnit = default(LoyaltyUnit?), string currency = default(string), decimal? amountValue = default(decimal?))
        {
            this.AmountValue = amountValue;
            this.LoyaltyUnit = loyaltyUnit;
            this.Currency = currency;
        }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "Currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets AmountValue
        /// </summary>
        [DataMember(Name = "AmountValue", IsRequired = false, EmitDefaultValue = false)]
        public decimal? AmountValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LoyaltyAmount {\n");
            sb.Append("  LoyaltyUnit: ").Append(LoyaltyUnit).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  AmountValue: ").Append(AmountValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as LoyaltyAmount);
        }

        /// <summary>
        /// Returns true if LoyaltyAmount instances are equal
        /// </summary>
        /// <param name="input">Instance of LoyaltyAmount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoyaltyAmount input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LoyaltyUnit == input.LoyaltyUnit ||
                    this.LoyaltyUnit.Equals(input.LoyaltyUnit)
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.AmountValue == input.AmountValue ||
                    this.AmountValue.Equals(input.AmountValue)
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
                hashCode = (hashCode * 59) + this.LoyaltyUnit.GetHashCode();
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AmountValue.GetHashCode();
                return hashCode;
            }
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // Currency (string) pattern
            Regex regexCurrency = new Regex(@"^[A-Z]{3,3}$", RegexOptions.CultureInvariant);
            if (false == regexCurrency.Match(this.Currency).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Currency, must match a pattern of " + regexCurrency, new [] { "Currency" });
            }

            // AmountValue (decimal) maximum
            if (this.AmountValue > (decimal)99999999.999999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AmountValue, must be a value less than or equal to 99999999.999999.", new [] { "AmountValue" });
            }

            // AmountValue (decimal) minimum
            if (this.AmountValue < (decimal)0.0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AmountValue, must be a value greater than or equal to 0.0.", new [] { "AmountValue" });
            }

            yield break;
        }
    }

}
