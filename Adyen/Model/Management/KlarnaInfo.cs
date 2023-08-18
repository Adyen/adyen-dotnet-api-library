/*
* Management API
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

namespace Adyen.Model.Management
{
    /// <summary>
    /// KlarnaInfo
    /// </summary>
    [DataContract(Name = "KlarnaInfo")]
    public partial class KlarnaInfo : IEquatable<KlarnaInfo>, IValidatableObject
    {
        /// <summary>
        /// The region of operation. For example, **NA**, **EU**, **CH**, **AU**.
        /// </summary>
        /// <value>The region of operation. For example, **NA**, **EU**, **CH**, **AU**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RegionEnum
        {
            /// <summary>
            /// Enum NA for value: NA
            /// </summary>
            [EnumMember(Value = "NA")]
            NA = 1,

            /// <summary>
            /// Enum EU for value: EU
            /// </summary>
            [EnumMember(Value = "EU")]
            EU = 2,

            /// <summary>
            /// Enum CH for value: CH
            /// </summary>
            [EnumMember(Value = "CH")]
            CH = 3,

            /// <summary>
            /// Enum AU for value: AU
            /// </summary>
            [EnumMember(Value = "AU")]
            AU = 4

        }


        /// <summary>
        /// The region of operation. For example, **NA**, **EU**, **CH**, **AU**.
        /// </summary>
        /// <value>The region of operation. For example, **NA**, **EU**, **CH**, **AU**.</value>
        [DataMember(Name = "region", EmitDefaultValue = false)]
        public RegionEnum? Region { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KlarnaInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KlarnaInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KlarnaInfo" /> class.
        /// </summary>
        /// <param name="autoCapture">Indicates the status of [Automatic capture](https://docs.adyen.com/online-payments/capture#automatic-capture). Default value: **false**..</param>
        /// <param name="disputeEmail">The email address for disputes. (required).</param>
        /// <param name="region">The region of operation. For example, **NA**, **EU**, **CH**, **AU**..</param>
        /// <param name="supportEmail">The email address of merchant support. (required).</param>
        public KlarnaInfo(bool? autoCapture = default(bool?), string disputeEmail = default(string), RegionEnum? region = default(RegionEnum?), string supportEmail = default(string))
        {
            this.DisputeEmail = disputeEmail;
            this.SupportEmail = supportEmail;
            this.AutoCapture = autoCapture;
            this.Region = region;
        }

        /// <summary>
        /// Indicates the status of [Automatic capture](https://docs.adyen.com/online-payments/capture#automatic-capture). Default value: **false**.
        /// </summary>
        /// <value>Indicates the status of [Automatic capture](https://docs.adyen.com/online-payments/capture#automatic-capture). Default value: **false**.</value>
        [DataMember(Name = "autoCapture", EmitDefaultValue = false)]
        public bool? AutoCapture { get; set; }

        /// <summary>
        /// The email address for disputes.
        /// </summary>
        /// <value>The email address for disputes.</value>
        [DataMember(Name = "disputeEmail", IsRequired = false, EmitDefaultValue = false)]
        public string DisputeEmail { get; set; }

        /// <summary>
        /// The email address of merchant support.
        /// </summary>
        /// <value>The email address of merchant support.</value>
        [DataMember(Name = "supportEmail", IsRequired = false, EmitDefaultValue = false)]
        public string SupportEmail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KlarnaInfo {\n");
            sb.Append("  AutoCapture: ").Append(AutoCapture).Append("\n");
            sb.Append("  DisputeEmail: ").Append(DisputeEmail).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  SupportEmail: ").Append(SupportEmail).Append("\n");
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
            return this.Equals(input as KlarnaInfo);
        }

        /// <summary>
        /// Returns true if KlarnaInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of KlarnaInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KlarnaInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AutoCapture == input.AutoCapture ||
                    this.AutoCapture.Equals(input.AutoCapture)
                ) && 
                (
                    this.DisputeEmail == input.DisputeEmail ||
                    (this.DisputeEmail != null &&
                    this.DisputeEmail.Equals(input.DisputeEmail))
                ) && 
                (
                    this.Region == input.Region ||
                    this.Region.Equals(input.Region)
                ) && 
                (
                    this.SupportEmail == input.SupportEmail ||
                    (this.SupportEmail != null &&
                    this.SupportEmail.Equals(input.SupportEmail))
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
                hashCode = (hashCode * 59) + this.AutoCapture.GetHashCode();
                if (this.DisputeEmail != null)
                {
                    hashCode = (hashCode * 59) + this.DisputeEmail.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Region.GetHashCode();
                if (this.SupportEmail != null)
                {
                    hashCode = (hashCode * 59) + this.SupportEmail.GetHashCode();
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
