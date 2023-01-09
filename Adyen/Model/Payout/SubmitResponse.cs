/*
* Adyen Payout API
*
*
* The version of the OpenAPI document: 68
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

namespace Adyen.Model.Payout
{
    /// <summary>
    /// SubmitResponse
    /// </summary>
    [DataContract(Name = "SubmitResponse")]
    public partial class SubmitResponse : IEquatable<SubmitResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubmitResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitResponse" /> class.
        /// </summary>
        /// <param name="additionalData">This field contains additional data, which may be returned in a particular response..</param>
        /// <param name="pspReference">A new reference to uniquely identify this request. (required).</param>
        /// <param name="refusalReason">In case of refusal, an informational message for the reason..</param>
        /// <param name="resultCode">The response: * In case of success, it is &#x60;payout-submit-received&#x60;. * In case of an error, an informational message is returned. (required).</param>
        public SubmitResponse(Dictionary<string, string> additionalData = default(Dictionary<string, string>), string pspReference = default(string), string refusalReason = default(string), string resultCode = default(string))
        {
            this.PspReference = pspReference;
            this.ResultCode = resultCode;
            this.AdditionalData = additionalData;
            this.RefusalReason = refusalReason;
        }

        /// <summary>
        /// This field contains additional data, which may be returned in a particular response.
        /// </summary>
        /// <value>This field contains additional data, which may be returned in a particular response.</value>
        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// A new reference to uniquely identify this request.
        /// </summary>
        /// <value>A new reference to uniquely identify this request.</value>
        [DataMember(Name = "pspReference", IsRequired = false, EmitDefaultValue = true)]
        public string PspReference { get; set; }

        /// <summary>
        /// In case of refusal, an informational message for the reason.
        /// </summary>
        /// <value>In case of refusal, an informational message for the reason.</value>
        [DataMember(Name = "refusalReason", EmitDefaultValue = false)]
        public string RefusalReason { get; set; }

        /// <summary>
        /// The response: * In case of success, it is &#x60;payout-submit-received&#x60;. * In case of an error, an informational message is returned.
        /// </summary>
        /// <value>The response: * In case of success, it is &#x60;payout-submit-received&#x60;. * In case of an error, an informational message is returned.</value>
        [DataMember(Name = "resultCode", IsRequired = false, EmitDefaultValue = true)]
        public string ResultCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubmitResponse {\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  RefusalReason: ").Append(RefusalReason).Append("\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
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
            return this.Equals(input as SubmitResponse);
        }

        /// <summary>
        /// Returns true if SubmitResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SubmitResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubmitResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AdditionalData == input.AdditionalData ||
                    this.AdditionalData != null &&
                    input.AdditionalData != null &&
                    this.AdditionalData.SequenceEqual(input.AdditionalData)
                ) && 
                (
                    this.PspReference == input.PspReference ||
                    (this.PspReference != null &&
                    this.PspReference.Equals(input.PspReference))
                ) && 
                (
                    this.RefusalReason == input.RefusalReason ||
                    (this.RefusalReason != null &&
                    this.RefusalReason.Equals(input.RefusalReason))
                ) && 
                (
                    this.ResultCode == input.ResultCode ||
                    (this.ResultCode != null &&
                    this.ResultCode.Equals(input.ResultCode))
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
                if (this.AdditionalData != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalData.GetHashCode();
                }
                if (this.PspReference != null)
                {
                    hashCode = (hashCode * 59) + this.PspReference.GetHashCode();
                }
                if (this.RefusalReason != null)
                {
                    hashCode = (hashCode * 59) + this.RefusalReason.GetHashCode();
                }
                if (this.ResultCode != null)
                {
                    hashCode = (hashCode * 59) + this.ResultCode.GetHashCode();
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
