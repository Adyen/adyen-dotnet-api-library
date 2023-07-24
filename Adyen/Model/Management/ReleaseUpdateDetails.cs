/*
* Management API
*
*
* The version of the OpenAPI document: 1
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
    /// ReleaseUpdateDetails
    /// </summary>
    [DataContract(Name = "ReleaseUpdateDetails")]
    public partial class ReleaseUpdateDetails : IEquatable<ReleaseUpdateDetails>, IValidatableObject
    {
        /// <summary>
        /// Type of terminal action: Update Release.
        /// </summary>
        /// <value>Type of terminal action: Update Release.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum ReleaseUpdate for value: ReleaseUpdate
            /// </summary>
            [EnumMember(Value = "ReleaseUpdate")]
            ReleaseUpdate = 1

        }


        /// <summary>
        /// Type of terminal action: Update Release.
        /// </summary>
        /// <value>Type of terminal action: Update Release.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseUpdateDetails" /> class.
        /// </summary>
        /// <param name="type">Type of terminal action: Update Release. (default to TypeEnum.ReleaseUpdate).</param>
        /// <param name="updateAtFirstMaintenanceCall">Boolean flag that tells if the terminal should update at the first next maintenance call. If false, terminal will update on its configured reboot time..</param>
        public ReleaseUpdateDetails(TypeEnum? type = TypeEnum.ReleaseUpdate, bool? updateAtFirstMaintenanceCall = default(bool?))
        {
            this.Type = type;
            this.UpdateAtFirstMaintenanceCall = updateAtFirstMaintenanceCall;
        }

        /// <summary>
        /// Boolean flag that tells if the terminal should update at the first next maintenance call. If false, terminal will update on its configured reboot time.
        /// </summary>
        /// <value>Boolean flag that tells if the terminal should update at the first next maintenance call. If false, terminal will update on its configured reboot time.</value>
        [DataMember(Name = "updateAtFirstMaintenanceCall", EmitDefaultValue = false)]
        public bool? UpdateAtFirstMaintenanceCall { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReleaseUpdateDetails {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UpdateAtFirstMaintenanceCall: ").Append(UpdateAtFirstMaintenanceCall).Append("\n");
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
            return this.Equals(input as ReleaseUpdateDetails);
        }

        /// <summary>
        /// Returns true if ReleaseUpdateDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ReleaseUpdateDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReleaseUpdateDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.UpdateAtFirstMaintenanceCall == input.UpdateAtFirstMaintenanceCall ||
                    this.UpdateAtFirstMaintenanceCall.Equals(input.UpdateAtFirstMaintenanceCall)
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                hashCode = (hashCode * 59) + this.UpdateAtFirstMaintenanceCall.GetHashCode();
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
