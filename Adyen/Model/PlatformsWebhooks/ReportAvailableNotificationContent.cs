/*
* Classic Platforms - Notifications
*
*
* The version of the OpenAPI document: 6
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

namespace Adyen.Model.PlatformsWebhooks
{
    /// <summary>
    /// ReportAvailableNotificationContent
    /// </summary>
    [DataContract(Name = "ReportAvailableNotificationContent")]
    public partial class ReportAvailableNotificationContent : IEquatable<ReportAvailableNotificationContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportAvailableNotificationContent" /> class.
        /// </summary>
        /// <param name="accountCode">The code of the Account to which the report applies..</param>
        /// <param name="accountType">The type of Account to which the report applies..</param>
        /// <param name="eventDate">The date of the event to which the report applies..</param>
        /// <param name="remoteAccessUrl">The URL at which the report can be accessed..</param>
        /// <param name="success">Indicates whether the event resulted in a success..</param>
        public ReportAvailableNotificationContent(string accountCode = default(string), string accountType = default(string), DateTime eventDate = default(DateTime), string remoteAccessUrl = default(string), bool? success = default(bool?))
        {
            this.AccountCode = accountCode;
            this.AccountType = accountType;
            this.EventDate = eventDate;
            this.RemoteAccessUrl = remoteAccessUrl;
            this.Success = success;
        }

        /// <summary>
        /// The code of the Account to which the report applies.
        /// </summary>
        /// <value>The code of the Account to which the report applies.</value>
        [DataMember(Name = "accountCode", EmitDefaultValue = false)]
        public string AccountCode { get; set; }

        /// <summary>
        /// The type of Account to which the report applies.
        /// </summary>
        /// <value>The type of Account to which the report applies.</value>
        [DataMember(Name = "accountType", EmitDefaultValue = false)]
        public string AccountType { get; set; }

        /// <summary>
        /// The date of the event to which the report applies.
        /// </summary>
        /// <value>The date of the event to which the report applies.</value>
        [DataMember(Name = "eventDate", EmitDefaultValue = false)]
        public DateTime EventDate { get; set; }

        /// <summary>
        /// The URL at which the report can be accessed.
        /// </summary>
        /// <value>The URL at which the report can be accessed.</value>
        [DataMember(Name = "remoteAccessUrl", EmitDefaultValue = false)]
        public string RemoteAccessUrl { get; set; }

        /// <summary>
        /// Indicates whether the event resulted in a success.
        /// </summary>
        /// <value>Indicates whether the event resulted in a success.</value>
        [DataMember(Name = "success", EmitDefaultValue = false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReportAvailableNotificationContent {\n");
            sb.Append("  AccountCode: ").Append(AccountCode).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  EventDate: ").Append(EventDate).Append("\n");
            sb.Append("  RemoteAccessUrl: ").Append(RemoteAccessUrl).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
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
            return this.Equals(input as ReportAvailableNotificationContent);
        }

        /// <summary>
        /// Returns true if ReportAvailableNotificationContent instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportAvailableNotificationContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportAvailableNotificationContent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountCode == input.AccountCode ||
                    (this.AccountCode != null &&
                    this.AccountCode.Equals(input.AccountCode))
                ) && 
                (
                    this.AccountType == input.AccountType ||
                    (this.AccountType != null &&
                    this.AccountType.Equals(input.AccountType))
                ) && 
                (
                    this.EventDate == input.EventDate ||
                    (this.EventDate != null &&
                    this.EventDate.Equals(input.EventDate))
                ) && 
                (
                    this.RemoteAccessUrl == input.RemoteAccessUrl ||
                    (this.RemoteAccessUrl != null &&
                    this.RemoteAccessUrl.Equals(input.RemoteAccessUrl))
                ) && 
                (
                    this.Success == input.Success ||
                    this.Success.Equals(input.Success)
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
                if (this.AccountCode != null)
                {
                    hashCode = (hashCode * 59) + this.AccountCode.GetHashCode();
                }
                if (this.AccountType != null)
                {
                    hashCode = (hashCode * 59) + this.AccountType.GetHashCode();
                }
                if (this.EventDate != null)
                {
                    hashCode = (hashCode * 59) + this.EventDate.GetHashCode();
                }
                if (this.RemoteAccessUrl != null)
                {
                    hashCode = (hashCode * 59) + this.RemoteAccessUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Success.GetHashCode();
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
