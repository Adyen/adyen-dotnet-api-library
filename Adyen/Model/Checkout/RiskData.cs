/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 70
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
    /// RiskData
    /// </summary>
    [DataContract(Name = "RiskData")]
    public partial class RiskData : IEquatable<RiskData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskData" /> class.
        /// </summary>
        /// <param name="clientData">Contains client-side data, like the device fingerprint, cookies, and specific browser settings..</param>
        /// <param name="customFields">Any custom fields used as part of the input to configured risk rules..</param>
        /// <param name="fraudOffset">An integer value that is added to the normal fraud score. The value can be either positive or negative..</param>
        /// <param name="profileReference">The risk profile to assign to this payment. When left empty, the merchant-level account&#39;s default risk profile will be applied..</param>
        public RiskData(string clientData = default(string), Dictionary<string, string> customFields = default(Dictionary<string, string>), int? fraudOffset = default(int?), string profileReference = default(string))
        {
            this.ClientData = clientData;
            this.CustomFields = customFields;
            this.FraudOffset = fraudOffset;
            this.ProfileReference = profileReference;
        }

        /// <summary>
        /// Contains client-side data, like the device fingerprint, cookies, and specific browser settings.
        /// </summary>
        /// <value>Contains client-side data, like the device fingerprint, cookies, and specific browser settings.</value>
        [DataMember(Name = "clientData", EmitDefaultValue = false)]
        public string ClientData { get; set; }

        /// <summary>
        /// Any custom fields used as part of the input to configured risk rules.
        /// </summary>
        /// <value>Any custom fields used as part of the input to configured risk rules.</value>
        [DataMember(Name = "customFields", EmitDefaultValue = false)]
        public Dictionary<string, string> CustomFields { get; set; }

        /// <summary>
        /// An integer value that is added to the normal fraud score. The value can be either positive or negative.
        /// </summary>
        /// <value>An integer value that is added to the normal fraud score. The value can be either positive or negative.</value>
        [DataMember(Name = "fraudOffset", EmitDefaultValue = false)]
        public int? FraudOffset { get; set; }

        /// <summary>
        /// The risk profile to assign to this payment. When left empty, the merchant-level account&#39;s default risk profile will be applied.
        /// </summary>
        /// <value>The risk profile to assign to this payment. When left empty, the merchant-level account&#39;s default risk profile will be applied.</value>
        [DataMember(Name = "profileReference", EmitDefaultValue = false)]
        public string ProfileReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RiskData {\n");
            sb.Append("  ClientData: ").Append(ClientData).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  FraudOffset: ").Append(FraudOffset).Append("\n");
            sb.Append("  ProfileReference: ").Append(ProfileReference).Append("\n");
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
            return this.Equals(input as RiskData);
        }

        /// <summary>
        /// Returns true if RiskData instances are equal
        /// </summary>
        /// <param name="input">Instance of RiskData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RiskData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ClientData == input.ClientData ||
                    (this.ClientData != null &&
                    this.ClientData.Equals(input.ClientData))
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    this.CustomFields != null &&
                    input.CustomFields != null &&
                    this.CustomFields.SequenceEqual(input.CustomFields)
                ) && 
                (
                    this.FraudOffset == input.FraudOffset ||
                    this.FraudOffset.Equals(input.FraudOffset)
                ) && 
                (
                    this.ProfileReference == input.ProfileReference ||
                    (this.ProfileReference != null &&
                    this.ProfileReference.Equals(input.ProfileReference))
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
                if (this.ClientData != null)
                {
                    hashCode = (hashCode * 59) + this.ClientData.GetHashCode();
                }
                if (this.CustomFields != null)
                {
                    hashCode = (hashCode * 59) + this.CustomFields.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FraudOffset.GetHashCode();
                if (this.ProfileReference != null)
                {
                    hashCode = (hashCode * 59) + this.ProfileReference.GetHashCode();
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
