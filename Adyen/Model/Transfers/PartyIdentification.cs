/*
* Transfers API
*
*
* The version of the OpenAPI document: 4
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
    /// PartyIdentification
    /// </summary>
    [DataContract(Name = "PartyIdentification")]
    public partial class PartyIdentification : IEquatable<PartyIdentification>, IValidatableObject
    {
        /// <summary>
        /// The type of entity that owns the bank account or card.  Possible values: **individual**, **organization**, or **unknown**.  Required when &#x60;category&#x60; is **card**. In this case, the value must be **individual**.
        /// </summary>
        /// <value>The type of entity that owns the bank account or card.  Possible values: **individual**, **organization**, or **unknown**.  Required when &#x60;category&#x60; is **card**. In this case, the value must be **individual**.</value>
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
        /// The type of entity that owns the bank account or card.  Possible values: **individual**, **organization**, or **unknown**.  Required when &#x60;category&#x60; is **card**. In this case, the value must be **individual**.
        /// </summary>
        /// <value>The type of entity that owns the bank account or card.  Possible values: **individual**, **organization**, or **unknown**.  Required when &#x60;category&#x60; is **card**. In this case, the value must be **individual**.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PartyIdentification" /> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="dateOfBirth">The date of birth of the individual in [ISO-8601](https://www.w3.org/TR/NOTE-datetime) format. For example, **YYYY-MM-DD**.  Allowed only when &#x60;type&#x60; is **individual**..</param>
        /// <param name="firstName">The first name of the individual.  Supported characters: [a-z] [A-Z] - . / — and space.  This parameter is: - Allowed only when &#x60;type&#x60; is **individual**. - Required when &#x60;category&#x60; is **card**..</param>
        /// <param name="fullName">The full name of the entity that owns the bank account or card.  Supported characters: [a-z] [A-Z] [0-9] , . ; : - — / \\ + &amp; ! ? @ ( ) \&quot; &#39; and space.  Required when &#x60;category&#x60; is **bank**..</param>
        /// <param name="lastName">The last name of the individual.  Supported characters: [a-z] [A-Z] - . / — and space.  This parameter is: - Allowed only when &#x60;type&#x60; is **individual**. - Required when &#x60;category&#x60; is **card**..</param>
        /// <param name="reference">A unique reference to identify the party or counterparty involved in the transfer. For example, your client&#39;s unique wallet or payee ID.  Required when you include &#x60;cardIdentification.storedPaymentMethodId&#x60;..</param>
        /// <param name="type">The type of entity that owns the bank account or card.  Possible values: **individual**, **organization**, or **unknown**.  Required when &#x60;category&#x60; is **card**. In this case, the value must be **individual**. (default to TypeEnum.Unknown).</param>
        public PartyIdentification(Address address = default(Address), DateTime dateOfBirth = default(DateTime), string firstName = default(string), string fullName = default(string), string lastName = default(string), string reference = default(string), TypeEnum? type = TypeEnum.Unknown)
        {
            this.Address = address;
            this.DateOfBirth = dateOfBirth;
            this.FirstName = firstName;
            this.FullName = fullName;
            this.LastName = lastName;
            this.Reference = reference;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public Address Address { get; set; }

        /// <summary>
        /// The date of birth of the individual in [ISO-8601](https://www.w3.org/TR/NOTE-datetime) format. For example, **YYYY-MM-DD**.  Allowed only when &#x60;type&#x60; is **individual**.
        /// </summary>
        /// <value>The date of birth of the individual in [ISO-8601](https://www.w3.org/TR/NOTE-datetime) format. For example, **YYYY-MM-DD**.  Allowed only when &#x60;type&#x60; is **individual**.</value>
        [DataMember(Name = "dateOfBirth", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// The first name of the individual.  Supported characters: [a-z] [A-Z] - . / — and space.  This parameter is: - Allowed only when &#x60;type&#x60; is **individual**. - Required when &#x60;category&#x60; is **card**.
        /// </summary>
        /// <value>The first name of the individual.  Supported characters: [a-z] [A-Z] - . / — and space.  This parameter is: - Allowed only when &#x60;type&#x60; is **individual**. - Required when &#x60;category&#x60; is **card**.</value>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The full name of the entity that owns the bank account or card.  Supported characters: [a-z] [A-Z] [0-9] , . ; : - — / \\ + &amp; ! ? @ ( ) \&quot; &#39; and space.  Required when &#x60;category&#x60; is **bank**.
        /// </summary>
        /// <value>The full name of the entity that owns the bank account or card.  Supported characters: [a-z] [A-Z] [0-9] , . ; : - — / \\ + &amp; ! ? @ ( ) \&quot; &#39; and space.  Required when &#x60;category&#x60; is **bank**.</value>
        [DataMember(Name = "fullName", EmitDefaultValue = false)]
        public string FullName { get; set; }

        /// <summary>
        /// The last name of the individual.  Supported characters: [a-z] [A-Z] - . / — and space.  This parameter is: - Allowed only when &#x60;type&#x60; is **individual**. - Required when &#x60;category&#x60; is **card**.
        /// </summary>
        /// <value>The last name of the individual.  Supported characters: [a-z] [A-Z] - . / — and space.  This parameter is: - Allowed only when &#x60;type&#x60; is **individual**. - Required when &#x60;category&#x60; is **card**.</value>
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// A unique reference to identify the party or counterparty involved in the transfer. For example, your client&#39;s unique wallet or payee ID.  Required when you include &#x60;cardIdentification.storedPaymentMethodId&#x60;.
        /// </summary>
        /// <value>A unique reference to identify the party or counterparty involved in the transfer. For example, your client&#39;s unique wallet or payee ID.  Required when you include &#x60;cardIdentification.storedPaymentMethodId&#x60;.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PartyIdentification {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
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
            return this.Equals(input as PartyIdentification);
        }

        /// <summary>
        /// Returns true if PartyIdentification instances are equal
        /// </summary>
        /// <param name="input">Instance of PartyIdentification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartyIdentification input)
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
                    this.DateOfBirth == input.DateOfBirth ||
                    (this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(input.DateOfBirth))
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
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
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
                if (this.DateOfBirth != null)
                {
                    hashCode = (hashCode * 59) + this.DateOfBirth.GetHashCode();
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
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
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
            // Reference (string) maxLength
            if (this.Reference != null && this.Reference.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Reference, length must be less than 150.", new [] { "Reference" });
            }

            yield break;
        }
    }

}
