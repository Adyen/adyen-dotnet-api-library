/*
* Legal Entity Management API
*
*
* The version of the OpenAPI document: 2
* Contact: developer-experience@adyen.com
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Adyen.Model.LegalEntityManagement
{
    /// <summary>
    /// SupportingEntityCapability
    /// </summary>
    [DataContract]
    public partial class SupportingEntityCapability :  IEquatable<SupportingEntityCapability>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportingEntityCapability" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SupportingEntityCapability()
        {
        }

        /// <summary>
        /// Indicates whether the supporting entity capability is allowed.  If a supporting entity is allowed but its parent legal entity is not, it means there are other supporting entities that failed validation.  **The allowed supporting entity can still be used**
        /// </summary>
        /// <value>Indicates whether the supporting entity capability is allowed.  If a supporting entity is allowed but its parent legal entity is not, it means there are other supporting entities that failed validation.  **The allowed supporting entity can still be used**</value>
        [DataMember(Name="allowed", EmitDefaultValue=false)]
        public bool Allowed { get; private set; }

        /// <summary>
        /// Supporting entity reference 
        /// </summary>
        /// <value>Supporting entity reference </value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// Contains verification errors and the actions that you can take to resolve them.
        /// </summary>
        /// <value>Contains verification errors and the actions that you can take to resolve them.</value>
        [DataMember(Name="problems", EmitDefaultValue=false)]
        public List<CapabilityProblem> Problems { get; private set; }

        /// <summary>
        /// Indicates whether the supporting entity capability is requested. 
        /// </summary>
        /// <value>Indicates whether the supporting entity capability is requested. </value>
        [DataMember(Name="requested", EmitDefaultValue=false)]
        public bool Requested { get; private set; }

        /// <summary>
        /// The status of the verification checks for the supporting entity capability.  Possible values:  * **pending**: Adyen is running the verification.  * **invalid**: The verification failed. Check if the &#x60;errors&#x60; array contains more information.  * **valid**: The verification has been successfully completed.  * **rejected**: Adyen has verified the information, but found reasons to not allow the capability. 
        /// </summary>
        /// <value>The status of the verification checks for the supporting entity capability.  Possible values:  * **pending**: Adyen is running the verification.  * **invalid**: The verification failed. Check if the &#x60;errors&#x60; array contains more information.  * **valid**: The verification has been successfully completed.  * **rejected**: Adyen has verified the information, but found reasons to not allow the capability. </value>
        [DataMember(Name="verificationStatus", EmitDefaultValue=false)]
        public string VerificationStatus { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupportingEntityCapability {\n");
            sb.Append("  Allowed: ").Append(Allowed).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Problems: ").Append(Problems).Append("\n");
            sb.Append("  Requested: ").Append(Requested).Append("\n");
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
            return this.Equals(input as SupportingEntityCapability);
        }

        /// <summary>
        /// Returns true if SupportingEntityCapability instances are equal
        /// </summary>
        /// <param name="input">Instance of SupportingEntityCapability to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupportingEntityCapability input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Allowed == input.Allowed ||
                    (this.Allowed != null &&
                    this.Allowed.Equals(input.Allowed))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Problems == input.Problems ||
                    this.Problems != null &&
                    input.Problems != null &&
                    this.Problems.SequenceEqual(input.Problems)
                ) && 
                (
                    this.Requested == input.Requested ||
                    (this.Requested != null &&
                    this.Requested.Equals(input.Requested))
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
                if (this.Allowed != null)
                    hashCode = hashCode * 59 + this.Allowed.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Problems != null)
                    hashCode = hashCode * 59 + this.Problems.GetHashCode();
                if (this.Requested != null)
                    hashCode = hashCode * 59 + this.Requested.GetHashCode();
                if (this.VerificationStatus != null)
                    hashCode = hashCode * 59 + this.VerificationStatus.GetHashCode();
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