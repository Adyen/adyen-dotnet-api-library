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
    /// ScheduleTerminalActionsRequest
    /// </summary>
    [DataContract(Name = "ScheduleTerminalActionsRequest")]
    public partial class ScheduleTerminalActionsRequest : IEquatable<ScheduleTerminalActionsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleTerminalActionsRequest" /> class.
        /// </summary>
        /// <param name="actionDetails">actionDetails.</param>
        /// <param name="scheduledAt">The date and time when the action should happen.  Format: [RFC 3339](https://www.rfc-editor.org/rfc/rfc3339), but without the **Z** before the time offset. For example, **2021-11-15T12:16:21+0100**  The action is sent with the first [maintenance call](https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api#when-actions-take-effect) after the specified date and time in the time zone of the terminal.  An empty value causes the action to be sent as soon as possible: at the next maintenance call..</param>
        /// <param name="storeId">The unique ID of the [store](https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/stores). If present, all terminals in the &#x60;terminalIds&#x60; list must be assigned to this store..</param>
        /// <param name="terminalIds">A list of unique IDs of the terminals to apply the action to. You can extract the IDs from the [GET &#x60;/terminals&#x60;](https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/terminals) response. Maximum length: 100 IDs..</param>
        public ScheduleTerminalActionsRequest(ScheduleTerminalActionsRequestActionDetails actionDetails = default(ScheduleTerminalActionsRequestActionDetails), string scheduledAt = default(string), string storeId = default(string), List<string> terminalIds = default(List<string>))
        {
            this.ActionDetails = actionDetails;
            this.ScheduledAt = scheduledAt;
            this.StoreId = storeId;
            this.TerminalIds = terminalIds;
        }

        /// <summary>
        /// Gets or Sets ActionDetails
        /// </summary>
        [DataMember(Name = "actionDetails", EmitDefaultValue = false)]
        public ScheduleTerminalActionsRequestActionDetails ActionDetails { get; set; }

        /// <summary>
        /// The date and time when the action should happen.  Format: [RFC 3339](https://www.rfc-editor.org/rfc/rfc3339), but without the **Z** before the time offset. For example, **2021-11-15T12:16:21+0100**  The action is sent with the first [maintenance call](https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api#when-actions-take-effect) after the specified date and time in the time zone of the terminal.  An empty value causes the action to be sent as soon as possible: at the next maintenance call.
        /// </summary>
        /// <value>The date and time when the action should happen.  Format: [RFC 3339](https://www.rfc-editor.org/rfc/rfc3339), but without the **Z** before the time offset. For example, **2021-11-15T12:16:21+0100**  The action is sent with the first [maintenance call](https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api#when-actions-take-effect) after the specified date and time in the time zone of the terminal.  An empty value causes the action to be sent as soon as possible: at the next maintenance call.</value>
        [DataMember(Name = "scheduledAt", EmitDefaultValue = false)]
        public string ScheduledAt { get; set; }

        /// <summary>
        /// The unique ID of the [store](https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/stores). If present, all terminals in the &#x60;terminalIds&#x60; list must be assigned to this store.
        /// </summary>
        /// <value>The unique ID of the [store](https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/stores). If present, all terminals in the &#x60;terminalIds&#x60; list must be assigned to this store.</value>
        [DataMember(Name = "storeId", EmitDefaultValue = false)]
        public string StoreId { get; set; }

        /// <summary>
        /// A list of unique IDs of the terminals to apply the action to. You can extract the IDs from the [GET &#x60;/terminals&#x60;](https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/terminals) response. Maximum length: 100 IDs.
        /// </summary>
        /// <value>A list of unique IDs of the terminals to apply the action to. You can extract the IDs from the [GET &#x60;/terminals&#x60;](https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/terminals) response. Maximum length: 100 IDs.</value>
        [DataMember(Name = "terminalIds", EmitDefaultValue = false)]
        public List<string> TerminalIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScheduleTerminalActionsRequest {\n");
            sb.Append("  ActionDetails: ").Append(ActionDetails).Append("\n");
            sb.Append("  ScheduledAt: ").Append(ScheduledAt).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  TerminalIds: ").Append(TerminalIds).Append("\n");
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
            return this.Equals(input as ScheduleTerminalActionsRequest);
        }

        /// <summary>
        /// Returns true if ScheduleTerminalActionsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ScheduleTerminalActionsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleTerminalActionsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActionDetails == input.ActionDetails ||
                    (this.ActionDetails != null &&
                    this.ActionDetails.Equals(input.ActionDetails))
                ) && 
                (
                    this.ScheduledAt == input.ScheduledAt ||
                    (this.ScheduledAt != null &&
                    this.ScheduledAt.Equals(input.ScheduledAt))
                ) && 
                (
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
                ) && 
                (
                    this.TerminalIds == input.TerminalIds ||
                    this.TerminalIds != null &&
                    input.TerminalIds != null &&
                    this.TerminalIds.SequenceEqual(input.TerminalIds)
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
                if (this.ActionDetails != null)
                {
                    hashCode = (hashCode * 59) + this.ActionDetails.GetHashCode();
                }
                if (this.ScheduledAt != null)
                {
                    hashCode = (hashCode * 59) + this.ScheduledAt.GetHashCode();
                }
                if (this.StoreId != null)
                {
                    hashCode = (hashCode * 59) + this.StoreId.GetHashCode();
                }
                if (this.TerminalIds != null)
                {
                    hashCode = (hashCode * 59) + this.TerminalIds.GetHashCode();
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
