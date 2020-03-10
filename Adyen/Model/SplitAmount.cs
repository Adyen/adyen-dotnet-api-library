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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model
{
    /// <summary>
    /// SplitAmount
    /// </summary>
    [DataContract]
    public partial class SplitAmount : IEquatable<SplitAmount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SplitAmount" /> class.
        /// </summary>
        [JsonConstructor]
        protected SplitAmount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SplitAmount" /> class.
        /// </summary>
        /// <param name="Currency">The three-character [ISO currency code](https://docs.adyen.com/developers/development-resources/currency-codes).  If this value is not provided, the currency in which the payment is made will be used..</param>
        /// <param name="Value">The payable amount that can be charged for the transaction.  The transaction amount needs to be represented in minor units according to the [following table](https://docs.adyen.com/developers/development-resources/currency-codes). (required).</param>
        public SplitAmount(string Currency = default(string), long? Value = default(long?))
        {
            // to ensure "Value" is required (not null)
            if (Value == null)
            {
                throw new InvalidDataException("Value is a required property for SplitAmount and cannot be null");
            }
            else
            {
                this.Value = Value;
            }
            this.Currency = Currency;
        }

        /// <summary>
        /// The three-character [ISO currency code](https://docs.adyen.com/developers/development-resources/currency-codes).  If this value is not provided, the currency in which the payment is made will be used.
        /// </summary>
        /// <value>The three-character [ISO currency code](https://docs.adyen.com/developers/development-resources/currency-codes).  If this value is not provided, the currency in which the payment is made will be used.</value>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// The payable amount that can be charged for the transaction.  The transaction amount needs to be represented in minor units according to the [following table](https://docs.adyen.com/developers/development-resources/currency-codes).
        /// </summary>
        /// <value>The payable amount that can be charged for the transaction.  The transaction amount needs to be represented in minor units according to the [following table](https://docs.adyen.com/developers/development-resources/currency-codes).</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public long? Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SplitAmount {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as SplitAmount);
        }

        /// <summary>
        /// Returns true if SplitAmount instances are equal
        /// </summary>
        /// <param name="input">Instance of SplitAmount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SplitAmount input)
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
            if (this.Currency != null && this.Currency.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Currency, length must be less than 3.", new[] { "Currency" });
            }

            // Currency (string) minLength
            if (this.Currency != null && this.Currency.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Currency, length must be greater than 3.", new[] { "Currency" });
            }

            yield break;
        }
    }
}