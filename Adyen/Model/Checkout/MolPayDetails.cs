/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 70
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

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// MolPayDetails
    /// </summary>
    [DataContract(Name = "MolPayDetails")]
    public partial class MolPayDetails : IEquatable<MolPayDetails>, IValidatableObject
    {
        /// <summary>
        /// **molpay**
        /// </summary>
        /// <value>**molpay**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum FpxMY for value: molpay_ebanking_fpx_MY
            /// </summary>
            [EnumMember(Value = "molpay_ebanking_fpx_MY")]
            FpxMY = 1,

            /// <summary>
            /// Enum TH for value: molpay_ebanking_TH
            /// </summary>
            [EnumMember(Value = "molpay_ebanking_TH")]
            TH = 2

        }


        /// <summary>
        /// **molpay**
        /// </summary>
        /// <value>**molpay**</value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MolPayDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MolPayDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MolPayDetails" /> class.
        /// </summary>
        /// <param name="checkoutAttemptId">The checkout attempt identifier..</param>
        /// <param name="issuer">The shopper&#39;s bank. Specify this with the issuer value that corresponds to this bank. (required).</param>
        /// <param name="type">**molpay** (required).</param>
        public MolPayDetails(string checkoutAttemptId = default(string), string issuer = default(string), TypeEnum type = default(TypeEnum))
        {
            this.Issuer = issuer;
            this.Type = type;
            this.CheckoutAttemptId = checkoutAttemptId;
        }

        /// <summary>
        /// The checkout attempt identifier.
        /// </summary>
        /// <value>The checkout attempt identifier.</value>
        [DataMember(Name = "checkoutAttemptId", EmitDefaultValue = false)]
        public string CheckoutAttemptId { get; set; }

        /// <summary>
        /// The shopper&#39;s bank. Specify this with the issuer value that corresponds to this bank.
        /// </summary>
        /// <value>The shopper&#39;s bank. Specify this with the issuer value that corresponds to this bank.</value>
        [DataMember(Name = "issuer", IsRequired = false, EmitDefaultValue = true)]
        public string Issuer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MolPayDetails {\n");
            sb.Append("  CheckoutAttemptId: ").Append(CheckoutAttemptId).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
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
            return this.Equals(input as MolPayDetails);
        }

        /// <summary>
        /// Returns true if MolPayDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of MolPayDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MolPayDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CheckoutAttemptId == input.CheckoutAttemptId ||
                    (this.CheckoutAttemptId != null &&
                    this.CheckoutAttemptId.Equals(input.CheckoutAttemptId))
                ) && 
                (
                    this.Issuer == input.Issuer ||
                    (this.Issuer != null &&
                    this.Issuer.Equals(input.Issuer))
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
                if (this.CheckoutAttemptId != null)
                {
                    hashCode = (hashCode * 59) + this.CheckoutAttemptId.GetHashCode();
                }
                if (this.Issuer != null)
                {
                    hashCode = (hashCode * 59) + this.Issuer.GetHashCode();
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
