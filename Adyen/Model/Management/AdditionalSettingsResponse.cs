/*
* Management API
*
*
* The version of the OpenAPI document: 1
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
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.Management
{
    /// <summary>
    /// AdditionalSettingsResponse
    /// </summary>
    [DataContract(Name = "AdditionalSettingsResponse")]
    public partial class AdditionalSettingsResponse : IEquatable<AdditionalSettingsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalSettingsResponse" /> class.
        /// </summary>
        /// <param name="excludeEventCodes">Object containing list of event codes for which the notifcation will not be sent. .</param>
        /// <param name="includeEventCodes">Object containing list of event codes for which the notifcation will be sent. .</param>
        /// <param name="properties">Object containing boolean key-value pairs. The key can be any [standard webhook additional setting](https://docs.adyen.com/development-resources/webhooks/additional-settings), and the value indicates if the setting is enabled. For example, &#x60;captureDelayHours&#x60;: **true** means the standard notifications you get will contain the number of hours remaining until the payment will be captured..</param>
        public AdditionalSettingsResponse(List<string> excludeEventCodes = default(List<string>), List<string> includeEventCodes = default(List<string>), Dictionary<string, bool> properties = default(Dictionary<string, bool>))
        {
            this.ExcludeEventCodes = excludeEventCodes;
            this.IncludeEventCodes = includeEventCodes;
            this.Properties = properties;
        }

        /// <summary>
        /// Object containing list of event codes for which the notifcation will not be sent. 
        /// </summary>
        /// <value>Object containing list of event codes for which the notifcation will not be sent. </value>
        [DataMember(Name = "excludeEventCodes", EmitDefaultValue = false)]
        public List<string> ExcludeEventCodes { get; set; }

        /// <summary>
        /// Object containing list of event codes for which the notifcation will be sent. 
        /// </summary>
        /// <value>Object containing list of event codes for which the notifcation will be sent. </value>
        [DataMember(Name = "includeEventCodes", EmitDefaultValue = false)]
        public List<string> IncludeEventCodes { get; set; }

        /// <summary>
        /// Object containing boolean key-value pairs. The key can be any [standard webhook additional setting](https://docs.adyen.com/development-resources/webhooks/additional-settings), and the value indicates if the setting is enabled. For example, &#x60;captureDelayHours&#x60;: **true** means the standard notifications you get will contain the number of hours remaining until the payment will be captured.
        /// </summary>
        /// <value>Object containing boolean key-value pairs. The key can be any [standard webhook additional setting](https://docs.adyen.com/development-resources/webhooks/additional-settings), and the value indicates if the setting is enabled. For example, &#x60;captureDelayHours&#x60;: **true** means the standard notifications you get will contain the number of hours remaining until the payment will be captured.</value>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        public Dictionary<string, bool> Properties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdditionalSettingsResponse {\n");
            sb.Append("  ExcludeEventCodes: ").Append(ExcludeEventCodes).Append("\n");
            sb.Append("  IncludeEventCodes: ").Append(IncludeEventCodes).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(input as AdditionalSettingsResponse);
        }

        /// <summary>
        /// Returns true if AdditionalSettingsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalSettingsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalSettingsResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExcludeEventCodes == input.ExcludeEventCodes ||
                    this.ExcludeEventCodes != null &&
                    input.ExcludeEventCodes != null &&
                    this.ExcludeEventCodes.SequenceEqual(input.ExcludeEventCodes)
                ) && 
                (
                    this.IncludeEventCodes == input.IncludeEventCodes ||
                    this.IncludeEventCodes != null &&
                    input.IncludeEventCodes != null &&
                    this.IncludeEventCodes.SequenceEqual(input.IncludeEventCodes)
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
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
                if (this.ExcludeEventCodes != null)
                {
                    hashCode = (hashCode * 59) + this.ExcludeEventCodes.GetHashCode();
                }
                if (this.IncludeEventCodes != null)
                {
                    hashCode = (hashCode * 59) + this.IncludeEventCodes.GetHashCode();
                }
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
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
