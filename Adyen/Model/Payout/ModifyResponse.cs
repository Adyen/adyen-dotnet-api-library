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
    /// ModifyResponse
    /// </summary>
    [DataContract(Name = "ModifyResponse")]
    public partial class ModifyResponse : IEquatable<ModifyResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ModifyResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyResponse" /> class.
        /// </summary>
        /// <param name="additionalData">This field contains additional data, which may be returned in a particular response..</param>
        /// <param name="pspReference">Adyen&#39;s 16-character string reference associated with the transaction. This value is globally unique; quote it when communicating with us about this response. (required).</param>
        /// <param name="response">The response: * In case of success, it is either &#x60;payout-confirm-received&#x60; or &#x60;payout-decline-received&#x60;. * In case of an error, an informational message is returned. (required).</param>
        public ModifyResponse(Dictionary<string, string> additionalData = default(Dictionary<string, string>), string pspReference = default(string), string response = default(string))
        {
            this.PspReference = pspReference;
            this.Response = response;
            this.AdditionalData = additionalData;
        }

        /// <summary>
        /// This field contains additional data, which may be returned in a particular response.
        /// </summary>
        /// <value>This field contains additional data, which may be returned in a particular response.</value>
        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// Adyen&#39;s 16-character string reference associated with the transaction. This value is globally unique; quote it when communicating with us about this response.
        /// </summary>
        /// <value>Adyen&#39;s 16-character string reference associated with the transaction. This value is globally unique; quote it when communicating with us about this response.</value>
        [DataMember(Name = "pspReference", IsRequired = false, EmitDefaultValue = true)]
        public string PspReference { get; set; }

        /// <summary>
        /// The response: * In case of success, it is either &#x60;payout-confirm-received&#x60; or &#x60;payout-decline-received&#x60;. * In case of an error, an informational message is returned.
        /// </summary>
        /// <value>The response: * In case of success, it is either &#x60;payout-confirm-received&#x60; or &#x60;payout-decline-received&#x60;. * In case of an error, an informational message is returned.</value>
        [DataMember(Name = "response", IsRequired = false, EmitDefaultValue = true)]
        public string Response { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ModifyResponse {\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
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
            return this.Equals(input as ModifyResponse);
        }

        /// <summary>
        /// Returns true if ModifyResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ModifyResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModifyResponse input)
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
                if (this.AdditionalData != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalData.GetHashCode();
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
