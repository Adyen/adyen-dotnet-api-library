/*
* Disputes API
*
*
* The version of the OpenAPI document: 30
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

namespace Adyen.Model.Disputes
{
    /// <summary>
    /// DefendDisputeRequest
    /// </summary>
    [DataContract(Name = "DefendDisputeRequest")]
    public partial class DefendDisputeRequest : IEquatable<DefendDisputeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefendDisputeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DefendDisputeRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DefendDisputeRequest" /> class.
        /// </summary>
        /// <param name="defenseReasonCode">The defense reason code that was selected to defend this dispute. (required).</param>
        /// <param name="disputePspReference">The PSP reference assigned to the dispute. (required).</param>
        /// <param name="merchantAccountCode">The merchant account identifier, for which you want to process the dispute transaction. (required).</param>
        public DefendDisputeRequest(string defenseReasonCode = default(string), string disputePspReference = default(string), string merchantAccountCode = default(string))
        {
            this.DefenseReasonCode = defenseReasonCode;
            this.DisputePspReference = disputePspReference;
            this.MerchantAccountCode = merchantAccountCode;
        }

        /// <summary>
        /// The defense reason code that was selected to defend this dispute.
        /// </summary>
        /// <value>The defense reason code that was selected to defend this dispute.</value>
        [DataMember(Name = "defenseReasonCode", IsRequired = false, EmitDefaultValue = false)]
        public string DefenseReasonCode { get; set; }

        /// <summary>
        /// The PSP reference assigned to the dispute.
        /// </summary>
        /// <value>The PSP reference assigned to the dispute.</value>
        [DataMember(Name = "disputePspReference", IsRequired = false, EmitDefaultValue = false)]
        public string DisputePspReference { get; set; }

        /// <summary>
        /// The merchant account identifier, for which you want to process the dispute transaction.
        /// </summary>
        /// <value>The merchant account identifier, for which you want to process the dispute transaction.</value>
        [DataMember(Name = "merchantAccountCode", IsRequired = false, EmitDefaultValue = false)]
        public string MerchantAccountCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DefendDisputeRequest {\n");
            sb.Append("  DefenseReasonCode: ").Append(DefenseReasonCode).Append("\n");
            sb.Append("  DisputePspReference: ").Append(DisputePspReference).Append("\n");
            sb.Append("  MerchantAccountCode: ").Append(MerchantAccountCode).Append("\n");
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
            return this.Equals(input as DefendDisputeRequest);
        }

        /// <summary>
        /// Returns true if DefendDisputeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DefendDisputeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DefendDisputeRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DefenseReasonCode == input.DefenseReasonCode ||
                    (this.DefenseReasonCode != null &&
                    this.DefenseReasonCode.Equals(input.DefenseReasonCode))
                ) && 
                (
                    this.DisputePspReference == input.DisputePspReference ||
                    (this.DisputePspReference != null &&
                    this.DisputePspReference.Equals(input.DisputePspReference))
                ) && 
                (
                    this.MerchantAccountCode == input.MerchantAccountCode ||
                    (this.MerchantAccountCode != null &&
                    this.MerchantAccountCode.Equals(input.MerchantAccountCode))
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
                if (this.DefenseReasonCode != null)
                {
                    hashCode = (hashCode * 59) + this.DefenseReasonCode.GetHashCode();
                }
                if (this.DisputePspReference != null)
                {
                    hashCode = (hashCode * 59) + this.DisputePspReference.GetHashCode();
                }
                if (this.MerchantAccountCode != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantAccountCode.GetHashCode();
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
