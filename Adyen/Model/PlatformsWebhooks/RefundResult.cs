/*
* Classic Platforms - Notifications
*
*
* The version of the OpenAPI document: 6
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

namespace Adyen.Model.PlatformsWebhooks
{
    /// <summary>
    /// RefundResult
    /// </summary>
    [DataContract(Name = "RefundResult")]
    public partial class RefundResult : IEquatable<RefundResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundResult" /> class.
        /// </summary>
        /// <param name="originalTransaction">originalTransaction.</param>
        /// <param name="pspReference">The reference of the refund..</param>
        /// <param name="response">The response indicating if the refund has been received for processing..</param>
        public RefundResult(Transaction originalTransaction = default(Transaction), string pspReference = default(string), string response = default(string))
        {
            this.OriginalTransaction = originalTransaction;
            this.PspReference = pspReference;
            this.Response = response;
        }

        /// <summary>
        /// Gets or Sets OriginalTransaction
        /// </summary>
        [DataMember(Name = "originalTransaction", EmitDefaultValue = false)]
        public Transaction OriginalTransaction { get; set; }

        /// <summary>
        /// The reference of the refund.
        /// </summary>
        /// <value>The reference of the refund.</value>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        public string PspReference { get; set; }

        /// <summary>
        /// The response indicating if the refund has been received for processing.
        /// </summary>
        /// <value>The response indicating if the refund has been received for processing.</value>
        [DataMember(Name = "response", EmitDefaultValue = false)]
        public string Response { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RefundResult {\n");
            sb.Append("  OriginalTransaction: ").Append(OriginalTransaction).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  Response: ").Append(Response).Append("\n");
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
            return this.Equals(input as RefundResult);
        }

        /// <summary>
        /// Returns true if RefundResult instances are equal
        /// </summary>
        /// <param name="input">Instance of RefundResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefundResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OriginalTransaction == input.OriginalTransaction ||
                    (this.OriginalTransaction != null &&
                    this.OriginalTransaction.Equals(input.OriginalTransaction))
                ) && 
                (
                    this.PspReference == input.PspReference ||
                    (this.PspReference != null &&
                    this.PspReference.Equals(input.PspReference))
                ) && 
                (
                    this.Response == input.Response ||
                    (this.Response != null &&
                    this.Response.Equals(input.Response))
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
                if (this.OriginalTransaction != null)
                {
                    hashCode = (hashCode * 59) + this.OriginalTransaction.GetHashCode();
                }
                if (this.PspReference != null)
                {
                    hashCode = (hashCode * 59) + this.PspReference.GetHashCode();
                }
                if (this.Response != null)
                {
                    hashCode = (hashCode * 59) + this.Response.GetHashCode();
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
            yield break;
        }
    }

}
