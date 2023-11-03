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
    /// PaymentVerificationRequest
    /// </summary>
    [DataContract(Name = "PaymentVerificationRequest")]
    public partial class PaymentVerificationRequest : IEquatable<PaymentVerificationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentVerificationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentVerificationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentVerificationRequest" /> class.
        /// </summary>
        /// <param name="payload">Encrypted and signed payment result data. You should receive this value from the Checkout SDK after the shopper completes the payment. (required).</param>
        public PaymentVerificationRequest(string payload = default(string))
        {
            this.Payload = payload;
        }

        /// <summary>
        /// Encrypted and signed payment result data. You should receive this value from the Checkout SDK after the shopper completes the payment.
        /// </summary>
        /// <value>Encrypted and signed payment result data. You should receive this value from the Checkout SDK after the shopper completes the payment.</value>
        [DataMember(Name = "payload", IsRequired = false, EmitDefaultValue = false)]
        public string Payload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentVerificationRequest {\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
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
            return this.Equals(input as PaymentVerificationRequest);
        }

        /// <summary>
        /// Returns true if PaymentVerificationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentVerificationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentVerificationRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Payload == input.Payload ||
                    (this.Payload != null &&
                    this.Payload.Equals(input.Payload))
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
                if (this.Payload != null)
                {
                    hashCode = (hashCode * 59) + this.Payload.GetHashCode();
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
            // Payload (string) maxLength
            if (this.Payload != null && this.Payload.Length > 40000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Payload, length must be less than 40000.", new [] { "Payload" });
            }

            yield break;
        }
    }

}
