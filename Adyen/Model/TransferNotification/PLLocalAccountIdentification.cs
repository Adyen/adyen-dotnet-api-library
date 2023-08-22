/*
* Transfer webhooks
*
*
* The version of the OpenAPI document: 3
* Contact: developer-experience@adyen.com
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

namespace Adyen.Model.TransferNotification
{
    /// <summary>
    /// PLLocalAccountIdentification
    /// </summary>
    [DataContract(Name = "PLLocalAccountIdentification")]
    public partial class PLLocalAccountIdentification : IEquatable<PLLocalAccountIdentification>, IValidatableObject
    {
        /// <summary>
        /// **plLocal**
        /// </summary>
        /// <value>**plLocal**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum PlLocal for value: plLocal
            /// </summary>
            [EnumMember(Value = "plLocal")]
            PlLocal = 1

        }


        /// <summary>
        /// **plLocal**
        /// </summary>
        /// <value>**plLocal**</value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PLLocalAccountIdentification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PLLocalAccountIdentification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PLLocalAccountIdentification" /> class.
        /// </summary>
        /// <param name="accountNumber">The 26-digit bank account number ([Numer rachunku](https://pl.wikipedia.org/wiki/Numer_Rachunku_Bankowego)), without separators or whitespace. (required).</param>
        /// <param name="type">**plLocal** (required) (default to TypeEnum.PlLocal).</param>
        public PLLocalAccountIdentification(string accountNumber = default(string), TypeEnum type = TypeEnum.PlLocal)
        {
            this.AccountNumber = accountNumber;
            this.Type = type;
        }

        /// <summary>
        /// The 26-digit bank account number ([Numer rachunku](https://pl.wikipedia.org/wiki/Numer_Rachunku_Bankowego)), without separators or whitespace.
        /// </summary>
        /// <value>The 26-digit bank account number ([Numer rachunku](https://pl.wikipedia.org/wiki/Numer_Rachunku_Bankowego)), without separators or whitespace.</value>
        [DataMember(Name = "accountNumber", IsRequired = false, EmitDefaultValue = false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PLLocalAccountIdentification {\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as PLLocalAccountIdentification);
        }

        /// <summary>
        /// Returns true if PLLocalAccountIdentification instances are equal
        /// </summary>
        /// <param name="input">Instance of PLLocalAccountIdentification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PLLocalAccountIdentification input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.AccountNumber != null)
                {
                    hashCode = (hashCode * 59) + this.AccountNumber.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
            // AccountNumber (string) maxLength
            if (this.AccountNumber != null && this.AccountNumber.Length > 26)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountNumber, length must be less than 26.", new [] { "AccountNumber" });
            }

            // AccountNumber (string) minLength
            if (this.AccountNumber != null && this.AccountNumber.Length < 26)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountNumber, length must be greater than 26.", new [] { "AccountNumber" });
            }

            yield break;
        }
    }

}
