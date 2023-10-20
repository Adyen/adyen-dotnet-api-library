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
    /// VerificationErrorRecursive
    /// </summary>
    [DataContract(Name = "VerificationError-recursive")]
    public partial class VerificationErrorRecursive : IEquatable<VerificationErrorRecursive>, IValidatableObject
    {
        /// <summary>
        /// The type of verification error.  Possible values: **invalidInput**, **dataMissing**, and **pendingStatus**.
        /// </summary>
        /// <value>The type of verification error.  Possible values: **invalidInput**, **dataMissing**, and **pendingStatus**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum DataMissing for value: dataMissing
            /// </summary>
            [EnumMember(Value = "dataMissing")]
            DataMissing = 1,

            /// <summary>
            /// Enum InvalidInput for value: invalidInput
            /// </summary>
            [EnumMember(Value = "invalidInput")]
            InvalidInput = 2,

            /// <summary>
            /// Enum PendingStatus for value: pendingStatus
            /// </summary>
            [EnumMember(Value = "pendingStatus")]
            PendingStatus = 3

        }


        /// <summary>
        /// The type of verification error.  Possible values: **invalidInput**, **dataMissing**, and **pendingStatus**.
        /// </summary>
        /// <value>The type of verification error.  Possible values: **invalidInput**, **dataMissing**, and **pendingStatus**.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VerificationErrorRecursive" /> class.
        /// </summary>
        /// <param name="code">The verification error code..</param>
        /// <param name="message">The verification error message..</param>
        /// <param name="type">The type of verification error.  Possible values: **invalidInput**, **dataMissing**, and **pendingStatus**..</param>
        /// <param name="remediatingActions">The actions that you can take to resolve the verification error..</param>
        public VerificationErrorRecursive(string code = default(string), string message = default(string), TypeEnum? type = default(TypeEnum?), List<RemediatingAction> remediatingActions = default(List<RemediatingAction>))
        {
            this.Code = code;
            this.Message = message;
            this.Type = type;
            this.RemediatingActions = remediatingActions;
        }

        /// <summary>
        /// The verification error code.
        /// </summary>
        /// <value>The verification error code.</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// The verification error message.
        /// </summary>
        /// <value>The verification error message.</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// The actions that you can take to resolve the verification error.
        /// </summary>
        /// <value>The actions that you can take to resolve the verification error.</value>
        [DataMember(Name = "remediatingActions", EmitDefaultValue = false)]
        public List<RemediatingAction> RemediatingActions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VerificationErrorRecursive {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  RemediatingActions: ").Append(RemediatingActions).Append("\n");
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
            return this.Equals(input as VerificationErrorRecursive);
        }

        /// <summary>
        /// Returns true if VerificationErrorRecursive instances are equal
        /// </summary>
        /// <param name="input">Instance of VerificationErrorRecursive to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerificationErrorRecursive input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.RemediatingActions == input.RemediatingActions ||
                    this.RemediatingActions != null &&
                    input.RemediatingActions != null &&
                    this.RemediatingActions.SequenceEqual(input.RemediatingActions)
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
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.RemediatingActions != null)
                {
                    hashCode = (hashCode * 59) + this.RemediatingActions.GetHashCode();
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
