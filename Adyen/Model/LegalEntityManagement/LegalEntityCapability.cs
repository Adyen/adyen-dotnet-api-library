/*
* Legal Entity Management API
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

namespace Adyen.Model.LegalEntityManagement
{
    /// <summary>
    /// LegalEntityCapability
    /// </summary>
    [DataContract(Name = "LegalEntityCapability")]
    public partial class LegalEntityCapability : IEquatable<LegalEntityCapability>, IValidatableObject
    {
        /// <summary>
        /// The capability level that is allowed for the legal entity.  Possible values: **notApplicable**, **low**, **medium**, **high**.
        /// </summary>
        /// <value>The capability level that is allowed for the legal entity.  Possible values: **notApplicable**, **low**, **medium**, **high**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AllowedLevelEnum
        {
            /// <summary>
            /// Enum High for value: high
            /// </summary>
            [EnumMember(Value = "high")]
            High = 1,

            /// <summary>
            /// Enum Low for value: low
            /// </summary>
            [EnumMember(Value = "low")]
            Low = 2,

            /// <summary>
            /// Enum Medium for value: medium
            /// </summary>
            [EnumMember(Value = "medium")]
            Medium = 3,

            /// <summary>
            /// Enum NotApplicable for value: notApplicable
            /// </summary>
            [EnumMember(Value = "notApplicable")]
            NotApplicable = 4

        }


        /// <summary>
        /// The capability level that is allowed for the legal entity.  Possible values: **notApplicable**, **low**, **medium**, **high**.
        /// </summary>
        /// <value>The capability level that is allowed for the legal entity.  Possible values: **notApplicable**, **low**, **medium**, **high**.</value>
        [DataMember(Name = "allowedLevel", EmitDefaultValue = false)]
        public AllowedLevelEnum? AllowedLevel { get; set; }

        /// <summary>
        /// Returns false as AllowedLevel should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAllowedLevel()
        {
            return false;
        }
        /// <summary>
        /// The requested level of the capability. Some capabilities, such as those used in [card issuing](https://docs.adyen.com/issuing/add-capabilities#capability-levels), have different levels. Levels increase the capability, but also require additional checks and increased monitoring.  Possible values: **notApplicable**, **low**, **medium**, **high**.
        /// </summary>
        /// <value>The requested level of the capability. Some capabilities, such as those used in [card issuing](https://docs.adyen.com/issuing/add-capabilities#capability-levels), have different levels. Levels increase the capability, but also require additional checks and increased monitoring.  Possible values: **notApplicable**, **low**, **medium**, **high**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RequestedLevelEnum
        {
            /// <summary>
            /// Enum High for value: high
            /// </summary>
            [EnumMember(Value = "high")]
            High = 1,

            /// <summary>
            /// Enum Low for value: low
            /// </summary>
            [EnumMember(Value = "low")]
            Low = 2,

            /// <summary>
            /// Enum Medium for value: medium
            /// </summary>
            [EnumMember(Value = "medium")]
            Medium = 3,

            /// <summary>
            /// Enum NotApplicable for value: notApplicable
            /// </summary>
            [EnumMember(Value = "notApplicable")]
            NotApplicable = 4

        }


        /// <summary>
        /// The requested level of the capability. Some capabilities, such as those used in [card issuing](https://docs.adyen.com/issuing/add-capabilities#capability-levels), have different levels. Levels increase the capability, but also require additional checks and increased monitoring.  Possible values: **notApplicable**, **low**, **medium**, **high**.
        /// </summary>
        /// <value>The requested level of the capability. Some capabilities, such as those used in [card issuing](https://docs.adyen.com/issuing/add-capabilities#capability-levels), have different levels. Levels increase the capability, but also require additional checks and increased monitoring.  Possible values: **notApplicable**, **low**, **medium**, **high**.</value>
        [DataMember(Name = "requestedLevel", EmitDefaultValue = false)]
        public RequestedLevelEnum? RequestedLevel { get; set; }

        /// <summary>
        /// Returns false as RequestedLevel should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRequestedLevel()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="LegalEntityCapability" /> class.
        /// </summary>
        /// <param name="allowedSettings">allowedSettings.</param>
        /// <param name="requestedSettings">requestedSettings.</param>
        public LegalEntityCapability(CapabilitySettings allowedSettings = default(CapabilitySettings), CapabilitySettings requestedSettings = default(CapabilitySettings))
        {
            this.AllowedSettings = allowedSettings;
            this.RequestedSettings = requestedSettings;
        }

        /// <summary>
        /// Indicates whether the capability is allowed. Adyen sets this to **true** if the verification is successful 
        /// </summary>
        /// <value>Indicates whether the capability is allowed. Adyen sets this to **true** if the verification is successful </value>
        [DataMember(Name = "allowed", EmitDefaultValue = false)]
        public bool? Allowed { get; private set; }

        /// <summary>
        /// Gets or Sets AllowedSettings
        /// </summary>
        [DataMember(Name = "allowedSettings", EmitDefaultValue = false)]
        public CapabilitySettings AllowedSettings { get; set; }

        /// <summary>
        /// Indicates whether the capability is requested. To check whether the Legal Entity is permitted to use the capability, 
        /// </summary>
        /// <value>Indicates whether the capability is requested. To check whether the Legal Entity is permitted to use the capability, </value>
        [DataMember(Name = "requested", EmitDefaultValue = false)]
        public bool? Requested { get; private set; }

        /// <summary>
        /// Gets or Sets RequestedSettings
        /// </summary>
        [DataMember(Name = "requestedSettings", EmitDefaultValue = false)]
        public CapabilitySettings RequestedSettings { get; set; }

        /// <summary>
        /// Capability status for transfer instruments associated with legal entity
        /// </summary>
        /// <value>Capability status for transfer instruments associated with legal entity</value>
        [DataMember(Name = "transferInstruments", EmitDefaultValue = false)]
        public List<SupportingEntityCapability> TransferInstruments { get; private set; }

        /// <summary>
        /// The status of the verification checks for the capability.  Possible values:  * **pending**: Adyen is running the verification.  * **invalid**: The verification failed. Check if the &#x60;errors&#x60; array contains more information.  * **valid**: The verification has been successfully completed.  * **rejected**: Adyen has verified the information, but found reasons to not allow the capability. 
        /// </summary>
        /// <value>The status of the verification checks for the capability.  Possible values:  * **pending**: Adyen is running the verification.  * **invalid**: The verification failed. Check if the &#x60;errors&#x60; array contains more information.  * **valid**: The verification has been successfully completed.  * **rejected**: Adyen has verified the information, but found reasons to not allow the capability. </value>
        [DataMember(Name = "verificationStatus", EmitDefaultValue = false)]
        public string VerificationStatus { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LegalEntityCapability {\n");
            sb.Append("  Allowed: ").Append(Allowed).Append("\n");
            sb.Append("  AllowedLevel: ").Append(AllowedLevel).Append("\n");
            sb.Append("  AllowedSettings: ").Append(AllowedSettings).Append("\n");
            sb.Append("  Requested: ").Append(Requested).Append("\n");
            sb.Append("  RequestedLevel: ").Append(RequestedLevel).Append("\n");
            sb.Append("  RequestedSettings: ").Append(RequestedSettings).Append("\n");
            sb.Append("  TransferInstruments: ").Append(TransferInstruments).Append("\n");
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
            return this.Equals(input as LegalEntityCapability);
        }

        /// <summary>
        /// Returns true if LegalEntityCapability instances are equal
        /// </summary>
        /// <param name="input">Instance of LegalEntityCapability to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LegalEntityCapability input)
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
                    this.AllowedLevel.Equals(input.AllowedLevel)
                ) && 
                (
                    this.AllowedSettings == input.AllowedSettings ||
                    (this.AllowedSettings != null &&
                    this.AllowedSettings.Equals(input.AllowedSettings))
                ) && 
                (
                    this.Requested == input.Requested ||
                    this.Requested.Equals(input.Requested)
                ) && 
                (
                    this.RequestedLevel == input.RequestedLevel ||
                    this.RequestedLevel.Equals(input.RequestedLevel)
                ) && 
                (
                    this.RequestedSettings == input.RequestedSettings ||
                    (this.RequestedSettings != null &&
                    this.RequestedSettings.Equals(input.RequestedSettings))
                ) && 
                (
                    this.TransferInstruments == input.TransferInstruments ||
                    this.TransferInstruments != null &&
                    input.TransferInstruments != null &&
                    this.TransferInstruments.SequenceEqual(input.TransferInstruments)
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
                hashCode = (hashCode * 59) + this.AllowedLevel.GetHashCode();
                if (this.AllowedSettings != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedSettings.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Requested.GetHashCode();
                hashCode = (hashCode * 59) + this.RequestedLevel.GetHashCode();
                if (this.RequestedSettings != null)
                {
                    hashCode = (hashCode * 59) + this.RequestedSettings.GetHashCode();
                }
                if (this.TransferInstruments != null)
                {
                    hashCode = (hashCode * 59) + this.TransferInstruments.GetHashCode();
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
