/*
* Adyen BinLookup API
*
*
* The version of the OpenAPI document: 52
* Contact: developer-experience@adyen.com
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Adyen.Model.Client.OpenAPIDateConverter;

namespace Adyen.Model.BinLookup
{
    /// <summary>
    /// Amount
    /// </summary>
    [DataContract]
    public partial class Amount :  IEquatable<Amount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Amount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Amount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Amount" /> class.
        /// </summary>
        /// <param name="currency">The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes). (required).</param>
        /// <param name="value">The amount of the transaction, in [minor units](https://docs.adyen.com/development-resources/currency-codes). (required).</param>
        public Amount(string currency = default(string), long value = default(long))
        {
            this.Currency = currency;
            this.Value = value;
        }

        /// <summary>
        /// The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes).
        /// </summary>
        /// <value>The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes).</value>
        [DataMember(Name="currency", EmitDefaultValue=true)]
        public string Currency { get; set; }

        /// <summary>
        /// The amount of the transaction, in [minor units](https://docs.adyen.com/development-resources/currency-codes).
        /// </summary>
        /// <value>The amount of the transaction, in [minor units](https://docs.adyen.com/development-resources/currency-codes).</value>
        [DataMember(Name="value", EmitDefaultValue=true)]
        public long Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Amount {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as Amount);
        }

        /// <summary>
        /// Returns true if Amount instances are equal
        /// </summary>
        /// <param name="input">Instance of Amount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Amount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Currency (string) maxLength
            if(this.Currency != null && this.Currency.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Currency, length must be less than 3.", new [] { "Currency" });
            }

            // Currency (string) minLength
            if(this.Currency != null && this.Currency.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Currency, length must be greater than 3.", new [] { "Currency" });
            }

            yield break;
        }
    }

}
