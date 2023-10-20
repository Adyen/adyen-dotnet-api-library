/*
* Management Webhooks
*
*
* The version of the OpenAPI document: 3
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

namespace Adyen.Model.ManagmentNotificationService
{
    /// <summary>
    /// AccountCapabilityData
    /// </summary>
    [DataContract(Name = "AccountCapabilityData")]
    public partial class AccountCapabilityData : IEquatable<AccountCapabilityData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountCapabilityData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountCapabilityData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountCapabilityData" /> class.
        /// </summary>
        /// <param name="allowed">Indicates whether the capability is allowed. Adyen sets this to **true** if the verification is successful..</param>
        /// <param name="allowedLevel">The allowed level of the capability. Some capabilities have different levels which correspond to thresholds. Higher levels may require additional checks and increased monitoring.Possible values: **notApplicable**, **low**, **medium**, **high**..</param>
        /// <param name="capability">The name of the capability. For example, **sendToTransferInstrument**..</param>
        /// <param name="problems">List of entities that has problems with verification. The information includes the details of the errors and the actions that you can take to resolve them..</param>
        /// <param name="requested">Indicates whether you requested the capability. (required).</param>
        /// <param name="requestedLevel">The level that you requested for the capability. Some capabilities have different levels which correspond to thresholds. Higher levels may require additional checks and increased monitoring.Possible values: **notApplicable**, **low**, **medium**, **high**. (required).</param>
        /// <param name="verificationStatus">The status of the verification checks for the capability.  Possible values:  * **pending**: Adyen is running the verification.  * **invalid**: The verification failed. Check if the &#x60;errors&#x60; array contains more information.  * **valid**: The verification was successful.  * **rejected**: Adyen checked the information and found reasons to not allow the capability. .</param>
        public AccountCapabilityData(bool? allowed = default(bool?), string allowedLevel = default(string), string capability = default(string), List<CapabilityProblem> problems = default(List<CapabilityProblem>), bool? requested = default(bool?), string requestedLevel = default(string), string verificationStatus = default(string))
        {
            this.Requested = requested;
            this.RequestedLevel = requestedLevel;
            this.Allowed = allowed;
            this.AllowedLevel = allowedLevel;
            this.Capability = capability;
            this.Problems = problems;
            this.VerificationStatus = verificationStatus;
        }

        /// <summary>
        /// Indicates whether the capability is allowed. Adyen sets this to **true** if the verification is successful.
        /// </summary>
        /// <value>Indicates whether the capability is allowed. Adyen sets this to **true** if the verification is successful.</value>
        [DataMember(Name = "allowed", EmitDefaultValue = false)]
        public bool? Allowed { get; set; }

        /// <summary>
        /// The allowed level of the capability. Some capabilities have different levels which correspond to thresholds. Higher levels may require additional checks and increased monitoring.Possible values: **notApplicable**, **low**, **medium**, **high**.
        /// </summary>
        /// <value>The allowed level of the capability. Some capabilities have different levels which correspond to thresholds. Higher levels may require additional checks and increased monitoring.Possible values: **notApplicable**, **low**, **medium**, **high**.</value>
        [DataMember(Name = "allowedLevel", EmitDefaultValue = false)]
        public string AllowedLevel { get; set; }

        /// <summary>
        /// The name of the capability. For example, **sendToTransferInstrument**.
        /// </summary>
        /// <value>The name of the capability. For example, **sendToTransferInstrument**.</value>
        [DataMember(Name = "capability", EmitDefaultValue = false)]
        public string Capability { get; set; }

        /// <summary>
        /// List of entities that has problems with verification. The information includes the details of the errors and the actions that you can take to resolve them.
        /// </summary>
        /// <value>List of entities that has problems with verification. The information includes the details of the errors and the actions that you can take to resolve them.</value>
        [DataMember(Name = "problems", EmitDefaultValue = false)]
        public List<CapabilityProblem> Problems { get; set; }

        /// <summary>
        /// Indicates whether you requested the capability.
        /// </summary>
        /// <value>Indicates whether you requested the capability.</value>
        [DataMember(Name = "requested", IsRequired = false, EmitDefaultValue = false)]
        public bool? Requested { get; set; }

        /// <summary>
        /// The level that you requested for the capability. Some capabilities have different levels which correspond to thresholds. Higher levels may require additional checks and increased monitoring.Possible values: **notApplicable**, **low**, **medium**, **high**.
        /// </summary>
        /// <value>The level that you requested for the capability. Some capabilities have different levels which correspond to thresholds. Higher levels may require additional checks and increased monitoring.Possible values: **notApplicable**, **low**, **medium**, **high**.</value>
        [DataMember(Name = "requestedLevel", IsRequired = false, EmitDefaultValue = false)]
        public string RequestedLevel { get; set; }

        /// <summary>
        /// The status of the verification checks for the capability.  Possible values:  * **pending**: Adyen is running the verification.  * **invalid**: The verification failed. Check if the &#x60;errors&#x60; array contains more information.  * **valid**: The verification was successful.  * **rejected**: Adyen checked the information and found reasons to not allow the capability. 
        /// </summary>
        /// <value>The status of the verification checks for the capability.  Possible values:  * **pending**: Adyen is running the verification.  * **invalid**: The verification failed. Check if the &#x60;errors&#x60; array contains more information.  * **valid**: The verification was successful.  * **rejected**: Adyen checked the information and found reasons to not allow the capability. </value>
        [DataMember(Name = "verificationStatus", EmitDefaultValue = false)]
        public string VerificationStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountCapabilityData {\n");
            sb.Append("  Allowed: ").Append(Allowed).Append("\n");
            sb.Append("  AllowedLevel: ").Append(AllowedLevel).Append("\n");
            sb.Append("  Capability: ").Append(Capability).Append("\n");
            sb.Append("  Problems: ").Append(Problems).Append("\n");
            sb.Append("  Requested: ").Append(Requested).Append("\n");
            sb.Append("  RequestedLevel: ").Append(RequestedLevel).Append("\n");
            sb.Append("  VerificationStatus: ").Append(VerificationStatus).Append("\n");
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
            return this.Equals(input as AccountCapabilityData);
        }

        /// <summary>
        /// Returns true if AccountCapabilityData instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountCapabilityData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountCapabilityData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Allowed == input.Allowed ||
                    this.Allowed.Equals(input.Allowed)
                ) && 
                (
                    this.AllowedLevel == input.AllowedLevel ||
                    (this.AllowedLevel != null &&
                    this.AllowedLevel.Equals(input.AllowedLevel))
                ) && 
                (
                    this.Capability == input.Capability ||
                    (this.Capability != null &&
                    this.Capability.Equals(input.Capability))
                ) && 
                (
                    this.Problems == input.Problems ||
                    this.Problems != null &&
                    input.Problems != null &&
                    this.Problems.SequenceEqual(input.Problems)
                ) && 
                (
                    this.Requested == input.Requested ||
                    this.Requested.Equals(input.Requested)
                ) && 
                (
                    this.RequestedLevel == input.RequestedLevel ||
                    (this.RequestedLevel != null &&
                    this.RequestedLevel.Equals(input.RequestedLevel))
                ) && 
                (
                    this.VerificationStatus == input.VerificationStatus ||
                    (this.VerificationStatus != null &&
                    this.VerificationStatus.Equals(input.VerificationStatus))
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
                hashCode = (hashCode * 59) + this.Allowed.GetHashCode();
                if (this.AllowedLevel != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedLevel.GetHashCode();
                }
                if (this.Capability != null)
                {
                    hashCode = (hashCode * 59) + this.Capability.GetHashCode();
                }
                if (this.Problems != null)
                {
                    hashCode = (hashCode * 59) + this.Problems.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Requested.GetHashCode();
                if (this.RequestedLevel != null)
                {
                    hashCode = (hashCode * 59) + this.RequestedLevel.GetHashCode();
                }
                if (this.VerificationStatus != null)
                {
                    hashCode = (hashCode * 59) + this.VerificationStatus.GetHashCode();
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
