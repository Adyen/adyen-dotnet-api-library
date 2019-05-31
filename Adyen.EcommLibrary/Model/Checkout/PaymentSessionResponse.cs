using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.EcommLibrary.Model.Checkout
{
    /// <summary>
    /// PaymentSessionResponse
    /// </summary>
    [DataContract]
    public partial class PaymentSessionResponse : IEquatable<PaymentSessionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSessionResponse" /> class.
        /// </summary>
        /// <param name="PaymentSession">The encoded payment session that you need to pass to the SDK..</param>
        public PaymentSessionResponse(string PaymentSession = default(string))
        {
            this.PaymentSession = PaymentSession;
        }

        /// <summary>
        /// The encoded payment session that you need to pass to the SDK.
        /// </summary>
        /// <value>The encoded payment session that you need to pass to the SDK.</value>
        [DataMember(Name = "paymentSession", EmitDefaultValue = false)]
        public string PaymentSession { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentSessionResponse {\n");
            sb.Append("  PaymentSession: ").Append(PaymentSession).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as PaymentSessionResponse);
        }

        /// <summary>
        /// Returns true if PaymentSessionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentSessionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentSessionResponse input)
        {
            if (input == null)
                return false;

            return
                PaymentSession == input.PaymentSession ||
                PaymentSession != null &&
                PaymentSession.Equals(input.PaymentSession);
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (PaymentSession != null)
                    hashCode = hashCode * 59 + PaymentSession.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}