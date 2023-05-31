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
    /// CALocalAccountIdentification
    /// </summary>
    [DataContract(Name = "CALocalAccountIdentification")]
    public partial class CALocalAccountIdentification : IEquatable<CALocalAccountIdentification>, IValidatableObject
    {
        /// <summary>
        /// The bank account type.  Possible values: **checking** or **savings**. Defaults to **checking**.
        /// </summary>
        /// <value>The bank account type.  Possible values: **checking** or **savings**. Defaults to **checking**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountTypeEnum
        {
            /// <summary>
            /// Enum Checking for value: checking
            /// </summary>
            [EnumMember(Value = "checking")]
            Checking = 1,

            /// <summary>
            /// Enum Savings for value: savings
            /// </summary>
            [EnumMember(Value = "savings")]
            Savings = 2

        }


        /// <summary>
        /// The bank account type.  Possible values: **checking** or **savings**. Defaults to **checking**.
        /// </summary>
        /// <value>The bank account type.  Possible values: **checking** or **savings**. Defaults to **checking**.</value>
        [DataMember(Name = "accountType", EmitDefaultValue = false)]
        public AccountTypeEnum? AccountType { get; set; }
        /// <summary>
        /// **caLocal**
        /// </summary>
        /// <value>**caLocal**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum CaLocal for value: caLocal
            /// </summary>
            [EnumMember(Value = "caLocal")]
            CaLocal = 1

        }


        /// <summary>
        /// **caLocal**
        /// </summary>
        /// <value>**caLocal**</value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CALocalAccountIdentification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CALocalAccountIdentification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CALocalAccountIdentification" /> class.
        /// </summary>
        /// <param name="accountNumber">The 5- to 12-digit bank account number, without separators or whitespace. (required).</param>
        /// <param name="accountType">The bank account type.  Possible values: **checking** or **savings**. Defaults to **checking**. (default to AccountTypeEnum.Checking).</param>
        /// <param name="institutionNumber">The 3-digit institution number, without separators or whitespace. (required).</param>
        /// <param name="transitNumber">The 5-digit transit number, without separators or whitespace. (required).</param>
        /// <param name="type">**caLocal** (required) (default to TypeEnum.CaLocal).</param>
        public CALocalAccountIdentification(string accountNumber = default(string), AccountTypeEnum? accountType = AccountTypeEnum.Checking, string institutionNumber = default(string), string transitNumber = default(string), TypeEnum type = TypeEnum.CaLocal)
        {
            this.AccountNumber = accountNumber;
            this.InstitutionNumber = institutionNumber;
            this.TransitNumber = transitNumber;
            this.Type = type;
            this.AccountType = accountType;
        }

        /// <summary>
        /// The 5- to 12-digit bank account number, without separators or whitespace.
        /// </summary>
        /// <value>The 5- to 12-digit bank account number, without separators or whitespace.</value>
        [DataMember(Name = "accountNumber", IsRequired = false, EmitDefaultValue = false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The 3-digit institution number, without separators or whitespace.
        /// </summary>
        /// <value>The 3-digit institution number, without separators or whitespace.</value>
        [DataMember(Name = "institutionNumber", IsRequired = false, EmitDefaultValue = false)]
        public string InstitutionNumber { get; set; }

        /// <summary>
        /// The 5-digit transit number, without separators or whitespace.
        /// </summary>
        /// <value>The 5-digit transit number, without separators or whitespace.</value>
        [DataMember(Name = "transitNumber", IsRequired = false, EmitDefaultValue = false)]
        public string TransitNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CALocalAccountIdentification {\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  InstitutionNumber: ").Append(InstitutionNumber).Append("\n");
            sb.Append("  TransitNumber: ").Append(TransitNumber).Append("\n");
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
            return this.Equals(input as CALocalAccountIdentification);
        }

        /// <summary>
        /// Returns true if CALocalAccountIdentification instances are equal
        /// </summary>
        /// <param name="input">Instance of CALocalAccountIdentification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CALocalAccountIdentification input)
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
                    this.AccountType == input.AccountType ||
                    this.AccountType.Equals(input.AccountType)
                ) && 
                (
                    this.InstitutionNumber == input.InstitutionNumber ||
                    (this.InstitutionNumber != null &&
                    this.InstitutionNumber.Equals(input.InstitutionNumber))
                ) && 
                (
                    this.TransitNumber == input.TransitNumber ||
                    (this.TransitNumber != null &&
                    this.TransitNumber.Equals(input.TransitNumber))
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
                hashCode = (hashCode * 59) + this.AccountType.GetHashCode();
                if (this.InstitutionNumber != null)
                {
                    hashCode = (hashCode * 59) + this.InstitutionNumber.GetHashCode();
                }
                if (this.TransitNumber != null)
                {
                    hashCode = (hashCode * 59) + this.TransitNumber.GetHashCode();
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
            if (this.AccountNumber != null && this.AccountNumber.Length > 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountNumber, length must be less than 12.", new [] { "AccountNumber" });
            }

            // AccountNumber (string) minLength
            if (this.AccountNumber != null && this.AccountNumber.Length < 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountNumber, length must be greater than 5.", new [] { "AccountNumber" });
            }

            // InstitutionNumber (string) maxLength
            if (this.InstitutionNumber != null && this.InstitutionNumber.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InstitutionNumber, length must be less than 3.", new [] { "InstitutionNumber" });
            }

            // InstitutionNumber (string) minLength
            if (this.InstitutionNumber != null && this.InstitutionNumber.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InstitutionNumber, length must be greater than 3.", new [] { "InstitutionNumber" });
            }

            // TransitNumber (string) maxLength
            if (this.TransitNumber != null && this.TransitNumber.Length > 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransitNumber, length must be less than 5.", new [] { "TransitNumber" });
            }

            // TransitNumber (string) minLength
            if (this.TransitNumber != null && this.TransitNumber.Length < 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransitNumber, length must be greater than 5.", new [] { "TransitNumber" });
            }

            yield break;
        }
    }

}