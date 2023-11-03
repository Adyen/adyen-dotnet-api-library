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
    /// AmazonPayDetails
    /// </summary>
    [DataContract(Name = "AmazonPayDetails")]
    public partial class AmazonPayDetails : IEquatable<AmazonPayDetails>, IValidatableObject
    {
        /// <summary>
        /// **amazonpay**
        /// </summary>
        /// <value>**amazonpay**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Amazonpay for value: amazonpay
            /// </summary>
            [EnumMember(Value = "amazonpay")]
            Amazonpay = 1

        }


        /// <summary>
        /// **amazonpay**
        /// </summary>
        /// <value>**amazonpay**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AmazonPayDetails" /> class.
        /// </summary>
        /// <param name="amazonPayToken">This is the &#x60;amazonPayToken&#x60; that you obtained from the [Get Checkout Session](https://amazon-pay-acquirer-guide.s3-eu-west-1.amazonaws.com/v1/amazon-pay-api-v2/checkout-session.html#get-checkout-session) response. This token is used for API only integration specifically..</param>
        /// <param name="checkoutAttemptId">The checkout attempt identifier..</param>
        /// <param name="checkoutSessionId">The &#x60;checkoutSessionId&#x60; is used to identify the checkout session at the Amazon Pay side. This field is required only for drop-in and components integration, where it replaces the amazonPayToken..</param>
        /// <param name="type">**amazonpay** (default to TypeEnum.Amazonpay).</param>
        public AmazonPayDetails(string amazonPayToken = default(string), string checkoutAttemptId = default(string), string checkoutSessionId = default(string), TypeEnum? type = TypeEnum.Amazonpay)
        {
            this.AmazonPayToken = amazonPayToken;
            this.CheckoutAttemptId = checkoutAttemptId;
            this.CheckoutSessionId = checkoutSessionId;
            this.Type = type;
        }

        /// <summary>
        /// This is the &#x60;amazonPayToken&#x60; that you obtained from the [Get Checkout Session](https://amazon-pay-acquirer-guide.s3-eu-west-1.amazonaws.com/v1/amazon-pay-api-v2/checkout-session.html#get-checkout-session) response. This token is used for API only integration specifically.
        /// </summary>
        /// <value>This is the &#x60;amazonPayToken&#x60; that you obtained from the [Get Checkout Session](https://amazon-pay-acquirer-guide.s3-eu-west-1.amazonaws.com/v1/amazon-pay-api-v2/checkout-session.html#get-checkout-session) response. This token is used for API only integration specifically.</value>
        [DataMember(Name = "amazonPayToken", EmitDefaultValue = false)]
        public string AmazonPayToken { get; set; }

        /// <summary>
        /// The checkout attempt identifier.
        /// </summary>
        /// <value>The checkout attempt identifier.</value>
        [DataMember(Name = "checkoutAttemptId", EmitDefaultValue = false)]
        public string CheckoutAttemptId { get; set; }

        /// <summary>
        /// The &#x60;checkoutSessionId&#x60; is used to identify the checkout session at the Amazon Pay side. This field is required only for drop-in and components integration, where it replaces the amazonPayToken.
        /// </summary>
        /// <value>The &#x60;checkoutSessionId&#x60; is used to identify the checkout session at the Amazon Pay side. This field is required only for drop-in and components integration, where it replaces the amazonPayToken.</value>
        [DataMember(Name = "checkoutSessionId", EmitDefaultValue = false)]
        public string CheckoutSessionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AmazonPayDetails {\n");
            sb.Append("  AmazonPayToken: ").Append(AmazonPayToken).Append("\n");
            sb.Append("  CheckoutAttemptId: ").Append(CheckoutAttemptId).Append("\n");
            sb.Append("  CheckoutSessionId: ").Append(CheckoutSessionId).Append("\n");
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
            return this.Equals(input as AmazonPayDetails);
        }

        /// <summary>
        /// Returns true if AmazonPayDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of AmazonPayDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AmazonPayDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AmazonPayToken == input.AmazonPayToken ||
                    (this.AmazonPayToken != null &&
                    this.AmazonPayToken.Equals(input.AmazonPayToken))
                ) && 
                (
                    this.CheckoutAttemptId == input.CheckoutAttemptId ||
                    (this.CheckoutAttemptId != null &&
                    this.CheckoutAttemptId.Equals(input.CheckoutAttemptId))
                ) && 
                (
                    this.CheckoutSessionId == input.CheckoutSessionId ||
                    (this.CheckoutSessionId != null &&
                    this.CheckoutSessionId.Equals(input.CheckoutSessionId))
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
                if (this.AmazonPayToken != null)
                {
                    hashCode = (hashCode * 59) + this.AmazonPayToken.GetHashCode();
                }
                if (this.CheckoutAttemptId != null)
                {
                    hashCode = (hashCode * 59) + this.CheckoutAttemptId.GetHashCode();
                }
                if (this.CheckoutSessionId != null)
                {
                    hashCode = (hashCode * 59) + this.CheckoutSessionId.GetHashCode();
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
