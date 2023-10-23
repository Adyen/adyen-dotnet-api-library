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
    /// Hardware
    /// </summary>
    [DataContract(Name = "Hardware")]
    public partial class Hardware : IEquatable<Hardware>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Hardware" /> class.
        /// </summary>
        /// <param name="displayMaximumBackLight">The brightness of the display when the terminal is being used, expressed as a percentage..</param>
        /// <param name="restartHour">The hour of the day when the terminal is set to reboot to apply the configuration and software updates. By default, the restart hour is at 6:00 AM in the timezone of the terminal Minimum vaoue: 0, maximum value: 23..</param>
        public Hardware(int? displayMaximumBackLight = default(int?), int? restartHour = default(int?))
        {
            this.DisplayMaximumBackLight = displayMaximumBackLight;
            this.RestartHour = restartHour;
        }

        /// <summary>
        /// The brightness of the display when the terminal is being used, expressed as a percentage.
        /// </summary>
        /// <value>The brightness of the display when the terminal is being used, expressed as a percentage.</value>
        [DataMember(Name = "displayMaximumBackLight", EmitDefaultValue = false)]
        public int? DisplayMaximumBackLight { get; set; }

        /// <summary>
        /// The hour of the day when the terminal is set to reboot to apply the configuration and software updates. By default, the restart hour is at 6:00 AM in the timezone of the terminal Minimum vaoue: 0, maximum value: 23.
        /// </summary>
        /// <value>The hour of the day when the terminal is set to reboot to apply the configuration and software updates. By default, the restart hour is at 6:00 AM in the timezone of the terminal Minimum vaoue: 0, maximum value: 23.</value>
        [DataMember(Name = "restartHour", EmitDefaultValue = false)]
        public int? RestartHour { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Hardware {\n");
            sb.Append("  DisplayMaximumBackLight: ").Append(DisplayMaximumBackLight).Append("\n");
            sb.Append("  RestartHour: ").Append(RestartHour).Append("\n");
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
            return this.Equals(input as Hardware);
        }

        /// <summary>
        /// Returns true if Hardware instances are equal
        /// </summary>
        /// <param name="input">Instance of Hardware to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Hardware input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DisplayMaximumBackLight == input.DisplayMaximumBackLight ||
                    this.DisplayMaximumBackLight.Equals(input.DisplayMaximumBackLight)
                ) && 
                (
                    this.RestartHour == input.RestartHour ||
                    this.RestartHour.Equals(input.RestartHour)
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
                hashCode = (hashCode * 59) + this.DisplayMaximumBackLight.GetHashCode();
                hashCode = (hashCode * 59) + this.RestartHour.GetHashCode();
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
