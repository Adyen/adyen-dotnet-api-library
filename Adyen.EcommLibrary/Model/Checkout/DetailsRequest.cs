
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.EcommLibrary.Model.Checkout
{
    /// <summary>
    /// DetailsRequest
    /// </summary>
    [DataContract]
    public partial class DetailsRequest :  IEquatable<DetailsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsRequest" /> class.
        /// </summary>
        [JsonConstructor]
        protected DetailsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsRequest" /> class.
        /// </summary>
        /// <param name="Details">Use this collection to submit the details that were returned as a result of the &#x60;/payments&#x60; call. (required).</param>
        /// <param name="PaymentData">The &#x60;paymentData&#x60; value that you received in the response to the &#x60;/payments&#x60; call. (required).</param>
        public DetailsRequest(Dictionary<string, string> Details = default(Dictionary<string, string>), string PaymentData = default(string))
        {
            // to ensure "Details" is required (not null)
            if (Details == null)
            {
                throw new InvalidDataException("Details is a required property for DetailsRequest and cannot be null");
            }
            else
            {
                this.Details = Details;
            }
            // to ensure "PaymentData" is required (not null)
            if (PaymentData == null)
            {
                throw new InvalidDataException("PaymentData is a required property for DetailsRequest and cannot be null");
            }
            else
            {
                this.PaymentData = PaymentData;
            }
        }
        
        /// <summary>
        /// Use this collection to submit the details that were returned as a result of the &#x60;/payments&#x60; call.
        /// </summary>
        /// <value>Use this collection to submit the details that were returned as a result of the &#x60;/payments&#x60; call.</value>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public Dictionary<string, string> Details { get; set; }

        /// <summary>
        /// The &#x60;paymentData&#x60; value that you received in the response to the &#x60;/payments&#x60; call.
        /// </summary>
        /// <value>The &#x60;paymentData&#x60; value that you received in the response to the &#x60;/payments&#x60; call.</value>
        [DataMember(Name="paymentData", EmitDefaultValue=false)]
        public string PaymentData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetailsRequest {\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  PaymentData: ").Append(PaymentData).Append("\n");
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
            return this.Equals(input as DetailsRequest);
        }

        /// <summary>
        /// Returns true if DetailsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DetailsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetailsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                ) && 
                (
                    this.PaymentData == input.PaymentData ||
                    (this.PaymentData != null &&
                    this.PaymentData.Equals(input.PaymentData))
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
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.PaymentData != null)
                    hashCode = hashCode * 59 + this.PaymentData.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
