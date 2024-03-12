/*
* Configuration API
*
*
* The version of the OpenAPI document: 2
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

namespace Adyen.Model.BalancePlatform
{
    /// <summary>
    /// NZLocalAccountIdentification
    /// </summary>
    [DataContract(Name = "NZLocalAccountIdentification")]
    public partial class NZLocalAccountIdentification : IEquatable<NZLocalAccountIdentification>, IValidatableObject
    {
        /// <summary>
        /// **nzLocal**
        /// </summary>
        /// <value>**nzLocal**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum NzLocal for value: nzLocal
            /// </summary>
            [EnumMember(Value = "nzLocal")]
            NzLocal = 1

        }


        /// <summary>
        /// **nzLocal**
        /// </summary>
        /// <value>**nzLocal**</value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NZLocalAccountIdentification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NZLocalAccountIdentification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NZLocalAccountIdentification" /> class.
        /// </summary>
        /// <param name="accountNumber">The 15-16 digit bank account number. The first 2 digits are the bank number, the next 4 digits are the branch number, the next 7 digits are the account number, and the final 2-3 digits are the suffix. (required).</param>
        /// <param name="formFactor">The form factor of the account.  Possible values: **physical**, **virtual**. Default value: **physical**. (default to &quot;physical&quot;).</param>
        /// <param name="type">**nzLocal** (required) (default to TypeEnum.NzLocal).</param>
        public NZLocalAccountIdentification(string accountNumber = default(string), string formFactor = "physical", TypeEnum type = TypeEnum.NzLocal)
        {
            this.AccountNumber = accountNumber;
            this.Type = type;
            // use default value if no "formFactor" provided
            this.FormFactor = formFactor ?? "physical";
        }

        /// <summary>
        /// The 15-16 digit bank account number. The first 2 digits are the bank number, the next 4 digits are the branch number, the next 7 digits are the account number, and the final 2-3 digits are the suffix.
        /// </summary>
        /// <value>The 15-16 digit bank account number. The first 2 digits are the bank number, the next 4 digits are the branch number, the next 7 digits are the account number, and the final 2-3 digits are the suffix.</value>
        [DataMember(Name = "accountNumber", IsRequired = false, EmitDefaultValue = false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The form factor of the account.  Possible values: **physical**, **virtual**. Default value: **physical**.
        /// </summary>
        /// <value>The form factor of the account.  Possible values: **physical**, **virtual**. Default value: **physical**.</value>
        [DataMember(Name = "formFactor", EmitDefaultValue = false)]
        public string FormFactor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NZLocalAccountIdentification {\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  FormFactor: ").Append(FormFactor).Append("\n");
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
            return this.Equals(input as NZLocalAccountIdentification);
        }

        /// <summary>
        /// Returns true if NZLocalAccountIdentification instances are equal
        /// </summary>
        /// <param name="input">Instance of NZLocalAccountIdentification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NZLocalAccountIdentification input)
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
                    this.FormFactor == input.FormFactor ||
                    (this.FormFactor != null &&
                    this.FormFactor.Equals(input.FormFactor))
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
                if (this.FormFactor != null)
                {
                    hashCode = (hashCode * 59) + this.FormFactor.GetHashCode();
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
            if (this.AccountNumber != null && this.AccountNumber.Length > 16)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountNumber, length must be less than 16.", new [] { "AccountNumber" });
            }

            // AccountNumber (string) minLength
            if (this.AccountNumber != null && this.AccountNumber.Length < 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountNumber, length must be greater than 15.", new [] { "AccountNumber" });
            }

            yield break;
        }
    }

}
