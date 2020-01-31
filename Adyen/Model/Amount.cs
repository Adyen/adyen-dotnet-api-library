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
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Adyen.Model
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
        public Amount(string Currency = default(string), long? Value = default(long?))
        {
            this.Currency = Currency;
            this.Value = Value;
        }
       
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// The payable amount that can be charged for the transaction.  The transaction amount needs to be represented in minor units according to the [following table](https://docs.adyen.com/developers/currency-codes).
        /// </summary>
        /// <value>The payable amount that can be charged for the transaction.  The transaction amount needs to be represented in minor units according to the [following table](https://docs.adyen.com/developers/currency-codes).</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public long? Value { get; set; }

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
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            return this.Equals(obj as Amount);
        }

        /// <summary>
        /// Returns true if Amount instances are equal
        /// </summary>
        /// <param name="other">Instance of Amount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Amount other)
        {
            if (other == null)
                return false;

            return 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                return hash;
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
