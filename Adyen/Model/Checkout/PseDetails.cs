/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 71
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

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// PseDetails
    /// </summary>
    [DataContract(Name = "PseDetails")]
    public partial class PseDetails : IEquatable<PseDetails>, IValidatableObject
    {
        /// <summary>
        /// The payment method type.
        /// </summary>
        /// <value>The payment method type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum PsePayulatam for value: pse_payulatam
            /// </summary>
            [EnumMember(Value = "pse_payulatam")]
            PsePayulatam = 1

        }


        /// <summary>
        /// The payment method type.
        /// </summary>
        /// <value>The payment method type.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PseDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PseDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PseDetails" /> class.
        /// </summary>
        /// <param name="bank">The shopper&#39;s bank. (required).</param>
        /// <param name="checkoutAttemptId">The checkout attempt identifier..</param>
        /// <param name="clientType">The client type. (required).</param>
        /// <param name="identification">The identification code. (required).</param>
        /// <param name="identificationType">The identification type. (required).</param>
        /// <param name="type">The payment method type..</param>
        public PseDetails(string bank = default(string), string checkoutAttemptId = default(string), string clientType = default(string), string identification = default(string), string identificationType = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.Bank = bank;
            this.ClientType = clientType;
            this.Identification = identification;
            this.IdentificationType = identificationType;
            this.CheckoutAttemptId = checkoutAttemptId;
            this.Type = type;
        }

        /// <summary>
        /// The shopper&#39;s bank.
        /// </summary>
        /// <value>The shopper&#39;s bank.</value>
        [DataMember(Name = "bank", IsRequired = false, EmitDefaultValue = false)]
        public string Bank { get; set; }

        /// <summary>
        /// The checkout attempt identifier.
        /// </summary>
        /// <value>The checkout attempt identifier.</value>
        [DataMember(Name = "checkoutAttemptId", EmitDefaultValue = false)]
        public string CheckoutAttemptId { get; set; }

        /// <summary>
        /// The client type.
        /// </summary>
        /// <value>The client type.</value>
        [DataMember(Name = "clientType", IsRequired = false, EmitDefaultValue = false)]
        public string ClientType { get; set; }

        /// <summary>
        /// The identification code.
        /// </summary>
        /// <value>The identification code.</value>
        [DataMember(Name = "identification", IsRequired = false, EmitDefaultValue = false)]
        public string Identification { get; set; }

        /// <summary>
        /// The identification type.
        /// </summary>
        /// <value>The identification type.</value>
        [DataMember(Name = "identificationType", IsRequired = false, EmitDefaultValue = false)]
        public string IdentificationType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PseDetails {\n");
            sb.Append("  Bank: ").Append(Bank).Append("\n");
            sb.Append("  CheckoutAttemptId: ").Append(CheckoutAttemptId).Append("\n");
            sb.Append("  ClientType: ").Append(ClientType).Append("\n");
            sb.Append("  Identification: ").Append(Identification).Append("\n");
            sb.Append("  IdentificationType: ").Append(IdentificationType).Append("\n");
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
            return this.Equals(input as PseDetails);
        }

        /// <summary>
        /// Returns true if PseDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of PseDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PseDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Bank == input.Bank ||
                    (this.Bank != null &&
                    this.Bank.Equals(input.Bank))
                ) && 
                (
                    this.CheckoutAttemptId == input.CheckoutAttemptId ||
                    (this.CheckoutAttemptId != null &&
                    this.CheckoutAttemptId.Equals(input.CheckoutAttemptId))
                ) && 
                (
                    this.ClientType == input.ClientType ||
                    (this.ClientType != null &&
                    this.ClientType.Equals(input.ClientType))
                ) && 
                (
                    this.Identification == input.Identification ||
                    (this.Identification != null &&
                    this.Identification.Equals(input.Identification))
                ) && 
                (
                    this.IdentificationType == input.IdentificationType ||
                    (this.IdentificationType != null &&
                    this.IdentificationType.Equals(input.IdentificationType))
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
                if (this.Bank != null)
                {
                    hashCode = (hashCode * 59) + this.Bank.GetHashCode();
                }
                if (this.CheckoutAttemptId != null)
                {
                    hashCode = (hashCode * 59) + this.CheckoutAttemptId.GetHashCode();
                }
                if (this.ClientType != null)
                {
                    hashCode = (hashCode * 59) + this.ClientType.GetHashCode();
                }
                if (this.Identification != null)
                {
                    hashCode = (hashCode * 59) + this.Identification.GetHashCode();
                }
                if (this.IdentificationType != null)
                {
                    hashCode = (hashCode * 59) + this.IdentificationType.GetHashCode();
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