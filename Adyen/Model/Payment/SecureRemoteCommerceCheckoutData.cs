/*
* Adyen Payment API
*
*
* The version of the OpenAPI document: 68
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

namespace Adyen.Model.Payment
{
    /// <summary>
    /// SecureRemoteCommerceCheckoutData
    /// </summary>
    [DataContract(Name = "SecureRemoteCommerceCheckoutData")]
    public partial class SecureRemoteCommerceCheckoutData : IEquatable<SecureRemoteCommerceCheckoutData>, IValidatableObject
    {
        /// <summary>
        /// The Secure Remote Commerce scheme.
        /// </summary>
        /// <value>The Secure Remote Commerce scheme.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SchemeEnum
        {
            /// <summary>
            /// Enum Mc for value: mc
            /// </summary>
            [EnumMember(Value = "mc")]
            Mc = 1,

            /// <summary>
            /// Enum Visa for value: visa
            /// </summary>
            [EnumMember(Value = "visa")]
            Visa = 2

        }


        /// <summary>
        /// The Secure Remote Commerce scheme.
        /// </summary>
        /// <value>The Secure Remote Commerce scheme.</value>
        [DataMember(Name = "scheme", EmitDefaultValue = false)]
        public SchemeEnum? Scheme { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecureRemoteCommerceCheckoutData" /> class.
        /// </summary>
        /// <param name="checkoutPayload">The Secure Remote Commerce checkout payload to process the payment with..</param>
        /// <param name="correlationId">This is the unique identifier generated by SRC system to track and link SRC messages. Available within the present checkout session (e.g. received in an earlier API response during the present session)..</param>
        /// <param name="cvc">The [card verification code](https://docs.adyen.com/get-started-with-adyen/payment-glossary/#card-security-code-cvc-cvv-cid)..</param>
        /// <param name="digitalCardId">A unique identifier that represents the token associated with a card enrolled. Required for scheme &#39;mc&#39;..</param>
        /// <param name="scheme">The Secure Remote Commerce scheme..</param>
        /// <param name="tokenReference">A unique identifier that represents the token associated with a card enrolled. Required for scheme &#39;visa&#39;..</param>
        public SecureRemoteCommerceCheckoutData(string checkoutPayload = default(string), string correlationId = default(string), string cvc = default(string), string digitalCardId = default(string), SchemeEnum? scheme = default(SchemeEnum?), string tokenReference = default(string))
        {
            this.CheckoutPayload = checkoutPayload;
            this.CorrelationId = correlationId;
            this.Cvc = cvc;
            this.DigitalCardId = digitalCardId;
            this.Scheme = scheme;
            this.TokenReference = tokenReference;
        }

        /// <summary>
        /// The Secure Remote Commerce checkout payload to process the payment with.
        /// </summary>
        /// <value>The Secure Remote Commerce checkout payload to process the payment with.</value>
        [DataMember(Name = "checkoutPayload", EmitDefaultValue = false)]
        public string CheckoutPayload { get; set; }

        /// <summary>
        /// This is the unique identifier generated by SRC system to track and link SRC messages. Available within the present checkout session (e.g. received in an earlier API response during the present session).
        /// </summary>
        /// <value>This is the unique identifier generated by SRC system to track and link SRC messages. Available within the present checkout session (e.g. received in an earlier API response during the present session).</value>
        [DataMember(Name = "correlationId", EmitDefaultValue = false)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// The [card verification code](https://docs.adyen.com/get-started-with-adyen/payment-glossary/#card-security-code-cvc-cvv-cid).
        /// </summary>
        /// <value>The [card verification code](https://docs.adyen.com/get-started-with-adyen/payment-glossary/#card-security-code-cvc-cvv-cid).</value>
        [DataMember(Name = "cvc", EmitDefaultValue = false)]
        public string Cvc { get; set; }

        /// <summary>
        /// A unique identifier that represents the token associated with a card enrolled. Required for scheme &#39;mc&#39;.
        /// </summary>
        /// <value>A unique identifier that represents the token associated with a card enrolled. Required for scheme &#39;mc&#39;.</value>
        [DataMember(Name = "digitalCardId", EmitDefaultValue = false)]
        public string DigitalCardId { get; set; }

        /// <summary>
        /// A unique identifier that represents the token associated with a card enrolled. Required for scheme &#39;visa&#39;.
        /// </summary>
        /// <value>A unique identifier that represents the token associated with a card enrolled. Required for scheme &#39;visa&#39;.</value>
        [DataMember(Name = "tokenReference", EmitDefaultValue = false)]
        public string TokenReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SecureRemoteCommerceCheckoutData {\n");
            sb.Append("  CheckoutPayload: ").Append(CheckoutPayload).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  Cvc: ").Append(Cvc).Append("\n");
            sb.Append("  DigitalCardId: ").Append(DigitalCardId).Append("\n");
            sb.Append("  Scheme: ").Append(Scheme).Append("\n");
            sb.Append("  TokenReference: ").Append(TokenReference).Append("\n");
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
            return this.Equals(input as SecureRemoteCommerceCheckoutData);
        }

        /// <summary>
        /// Returns true if SecureRemoteCommerceCheckoutData instances are equal
        /// </summary>
        /// <param name="input">Instance of SecureRemoteCommerceCheckoutData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecureRemoteCommerceCheckoutData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CheckoutPayload == input.CheckoutPayload ||
                    (this.CheckoutPayload != null &&
                    this.CheckoutPayload.Equals(input.CheckoutPayload))
                ) && 
                (
                    this.CorrelationId == input.CorrelationId ||
                    (this.CorrelationId != null &&
                    this.CorrelationId.Equals(input.CorrelationId))
                ) && 
                (
                    this.Cvc == input.Cvc ||
                    (this.Cvc != null &&
                    this.Cvc.Equals(input.Cvc))
                ) && 
                (
                    this.DigitalCardId == input.DigitalCardId ||
                    (this.DigitalCardId != null &&
                    this.DigitalCardId.Equals(input.DigitalCardId))
                ) && 
                (
                    this.Scheme == input.Scheme ||
                    this.Scheme.Equals(input.Scheme)
                ) && 
                (
                    this.TokenReference == input.TokenReference ||
                    (this.TokenReference != null &&
                    this.TokenReference.Equals(input.TokenReference))
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
                if (this.CheckoutPayload != null)
                {
                    hashCode = (hashCode * 59) + this.CheckoutPayload.GetHashCode();
                }
                if (this.CorrelationId != null)
                {
                    hashCode = (hashCode * 59) + this.CorrelationId.GetHashCode();
                }
                if (this.Cvc != null)
                {
                    hashCode = (hashCode * 59) + this.Cvc.GetHashCode();
                }
                if (this.DigitalCardId != null)
                {
                    hashCode = (hashCode * 59) + this.DigitalCardId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Scheme.GetHashCode();
                if (this.TokenReference != null)
                {
                    hashCode = (hashCode * 59) + this.TokenReference.GetHashCode();
                }
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
            // CheckoutPayload (string) maxLength
            if (this.CheckoutPayload != null && this.CheckoutPayload.Length > 10000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CheckoutPayload, length must be less than 10000.", new [] { "CheckoutPayload" });
            }

            // CorrelationId (string) maxLength
            if (this.CorrelationId != null && this.CorrelationId.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CorrelationId, length must be less than 40.", new [] { "CorrelationId" });
            }

            // CorrelationId (string) minLength
            if (this.CorrelationId != null && this.CorrelationId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CorrelationId, length must be greater than 1.", new [] { "CorrelationId" });
            }

            // Cvc (string) maxLength
            if (this.Cvc != null && this.Cvc.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Cvc, length must be less than 20.", new [] { "Cvc" });
            }

            // Cvc (string) minLength
            if (this.Cvc != null && this.Cvc.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Cvc, length must be greater than 1.", new [] { "Cvc" });
            }

            // DigitalCardId (string) maxLength
            if (this.DigitalCardId != null && this.DigitalCardId.Length > 80)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DigitalCardId, length must be less than 80.", new [] { "DigitalCardId" });
            }

            // TokenReference (string) maxLength
            if (this.TokenReference != null && this.TokenReference.Length > 80)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TokenReference, length must be less than 80.", new [] { "TokenReference" });
            }

            yield break;
        }
    }

}