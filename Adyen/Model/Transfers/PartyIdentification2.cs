/*
* Transfers API
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

namespace Adyen.Model.Transfers
{
    /// <summary>
    /// PartyIdentification2
    /// </summary>
    [DataContract(Name = "PartyIdentification-2")]
    public partial class PartyIdentification2 : IEquatable<PartyIdentification2>, IValidatableObject
    {
        /// <summary>
        /// The type of entity that owns the bank account.   Possible values: **individual**, **organization**, or **unknown**.
        /// </summary>
        /// <value>The type of entity that owns the bank account.   Possible values: **individual**, **organization**, or **unknown**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Individual for value: individual
            /// </summary>
            [EnumMember(Value = "individual")]
            Individual = 1,

            /// <summary>
            /// Enum Organization for value: organization
            /// </summary>
            [EnumMember(Value = "organization")]
            Organization = 2,

            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown = 3

        }


        /// <summary>
        /// The type of entity that owns the bank account.   Possible values: **individual**, **organization**, or **unknown**.
        /// </summary>
        /// <value>The type of entity that owns the bank account.   Possible values: **individual**, **organization**, or **unknown**.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PartyIdentification2" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PartyIdentification2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PartyIdentification2" /> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="firstName">First name of the individual. Required when &#x60;type&#x60; is **individual**..</param>
        /// <param name="fullName">The name of the entity. (required).</param>
        /// <param name="lastName">Last name of the individual. Required when &#x60;type&#x60; is **individual**..</param>
        /// <param name="type">The type of entity that owns the bank account.   Possible values: **individual**, **organization**, or **unknown**. (default to TypeEnum.Unknown).</param>
        public PartyIdentification2(Address2 address = default(Address2), string firstName = default(string), string fullName = default(string), string lastName = default(string), TypeEnum? type = TypeEnum.Unknown)
        {
            this.FullName = fullName;
            this.Address = address;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public Address2 Address { get; set; }

        /// <summary>
        /// First name of the individual. Required when &#x60;type&#x60; is **individual**.
        /// </summary>
        /// <value>First name of the individual. Required when &#x60;type&#x60; is **individual**.</value>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The name of the entity.
        /// </summary>
        /// <value>The name of the entity.</value>
        [DataMember(Name = "fullName", IsRequired = false, EmitDefaultValue = false)]
        public string FullName { get; set; }

        /// <summary>
        /// Last name of the individual. Required when &#x60;type&#x60; is **individual**.
        /// </summary>
        /// <value>Last name of the individual. Required when &#x60;type&#x60; is **individual**.</value>
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PartyIdentification2 {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
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
            return this.Equals(input as PartyIdentification2);
        }

        /// <summary>
        /// Returns true if PartyIdentification2 instances are equal
        /// </summary>
        /// <param name="input">Instance of PartyIdentification2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartyIdentification2 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.FullName != null)
                {
                    hashCode = (hashCode * 59) + this.FullName.GetHashCode();
                }
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
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
