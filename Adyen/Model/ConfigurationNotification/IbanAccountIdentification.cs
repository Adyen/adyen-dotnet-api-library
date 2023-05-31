/*
* Configuration webhooks
*
*
* The version of the OpenAPI document: 1
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

namespace Adyen.Model.ConfigurationNotification
{
    /// <summary>
    /// IbanAccountIdentification
    /// </summary>
    [DataContract(Name = "IbanAccountIdentification")]
    public partial class IbanAccountIdentification : IEquatable<IbanAccountIdentification>, IValidatableObject
    {
        /// <summary>
        /// **iban**
        /// </summary>
        /// <value>**iban**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Iban for value: iban
            /// </summary>
            [EnumMember(Value = "iban")]
            Iban = 1

        }


        /// <summary>
        /// **iban**
        /// </summary>
        /// <value>**iban**</value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IbanAccountIdentification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IbanAccountIdentification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IbanAccountIdentification" /> class.
        /// </summary>
        /// <param name="iban">The international bank account number as defined in the [ISO-13616](https://www.iso.org/standard/81090.html) standard. (required).</param>
        /// <param name="type">**iban** (required) (default to TypeEnum.Iban).</param>
        public IbanAccountIdentification(string iban = default(string), TypeEnum type = TypeEnum.Iban)
        {
            this.Iban = iban;
            this.Type = type;
        }

        /// <summary>
        /// The international bank account number as defined in the [ISO-13616](https://www.iso.org/standard/81090.html) standard.
        /// </summary>
        /// <value>The international bank account number as defined in the [ISO-13616](https://www.iso.org/standard/81090.html) standard.</value>
        [DataMember(Name = "iban", IsRequired = false, EmitDefaultValue = false)]
        public string Iban { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IbanAccountIdentification {\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
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
            return this.Equals(input as IbanAccountIdentification);
        }

        /// <summary>
        /// Returns true if IbanAccountIdentification instances are equal
        /// </summary>
        /// <param name="input">Instance of IbanAccountIdentification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IbanAccountIdentification input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Iban == input.Iban ||
                    (this.Iban != null &&
                    this.Iban.Equals(input.Iban))
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
                if (this.Iban != null)
                {
                    hashCode = (hashCode * 59) + this.Iban.GetHashCode();
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
            yield break;
        }
    }

}
