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
    /// ScheduledRefundsNotificationContent
    /// </summary>
    [DataContract(Name = "ScheduledRefundsNotificationContent")]
    public partial class ScheduledRefundsNotificationContent : IEquatable<ScheduledRefundsNotificationContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledRefundsNotificationContent" /> class.
        /// </summary>
        /// <param name="accountCode">The code of the account..</param>
        /// <param name="accountHolderCode">The code of the Account Holder..</param>
        /// <param name="invalidFields">Invalid fields list..</param>
        /// <param name="lastPayout">lastPayout.</param>
        /// <param name="refundResults">A list of the refunds that have been scheduled and their results..</param>
        public ScheduledRefundsNotificationContent(string accountCode = default(string), string accountHolderCode = default(string), List<ErrorFieldType> invalidFields = default(List<ErrorFieldType>), Transaction lastPayout = default(Transaction), List<RefundResult> refundResults = default(List<RefundResult>))
        {
            this.AccountCode = accountCode;
            this.AccountHolderCode = accountHolderCode;
            this.InvalidFields = invalidFields;
            this.LastPayout = lastPayout;
            this.RefundResults = refundResults;
        }

        /// <summary>
        /// The code of the account.
        /// </summary>
        /// <value>The code of the account.</value>
        [DataMember(Name = "accountCode", EmitDefaultValue = false)]
        public string AccountCode { get; set; }

        /// <summary>
        /// The code of the Account Holder.
        /// </summary>
        /// <value>The code of the Account Holder.</value>
        [DataMember(Name = "accountHolderCode", EmitDefaultValue = false)]
        public string AccountHolderCode { get; set; }

        /// <summary>
        /// Invalid fields list.
        /// </summary>
        /// <value>Invalid fields list.</value>
        [DataMember(Name = "invalidFields", EmitDefaultValue = false)]
        public List<ErrorFieldType> InvalidFields { get; set; }

        /// <summary>
        /// Gets or Sets LastPayout
        /// </summary>
        [DataMember(Name = "lastPayout", EmitDefaultValue = false)]
        public Transaction LastPayout { get; set; }

        /// <summary>
        /// A list of the refunds that have been scheduled and their results.
        /// </summary>
        /// <value>A list of the refunds that have been scheduled and their results.</value>
        [DataMember(Name = "refundResults", EmitDefaultValue = false)]
        public List<RefundResult> RefundResults { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScheduledRefundsNotificationContent {\n");
            sb.Append("  AccountCode: ").Append(AccountCode).Append("\n");
            sb.Append("  AccountHolderCode: ").Append(AccountHolderCode).Append("\n");
            sb.Append("  InvalidFields: ").Append(InvalidFields).Append("\n");
            sb.Append("  LastPayout: ").Append(LastPayout).Append("\n");
            sb.Append("  RefundResults: ").Append(RefundResults).Append("\n");
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
            return this.Equals(input as ScheduledRefundsNotificationContent);
        }

        /// <summary>
        /// Returns true if ScheduledRefundsNotificationContent instances are equal
        /// </summary>
        /// <param name="input">Instance of ScheduledRefundsNotificationContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduledRefundsNotificationContent input)
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
                    this.AccountHolderCode == input.AccountHolderCode ||
                    (this.AccountHolderCode != null &&
                    this.AccountHolderCode.Equals(input.AccountHolderCode))
                ) && 
                (
                    this.InvalidFields == input.InvalidFields ||
                    this.InvalidFields != null &&
                    input.InvalidFields != null &&
                    this.InvalidFields.SequenceEqual(input.InvalidFields)
                ) && 
                (
                    this.LastPayout == input.LastPayout ||
                    (this.LastPayout != null &&
                    this.LastPayout.Equals(input.LastPayout))
                ) && 
                (
                    this.RefundResults == input.RefundResults ||
                    this.RefundResults != null &&
                    input.RefundResults != null &&
                    this.RefundResults.SequenceEqual(input.RefundResults)
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
                if (this.AccountHolderCode != null)
                {
                    hashCode = (hashCode * 59) + this.AccountHolderCode.GetHashCode();
                }
                if (this.InvalidFields != null)
                {
                    hashCode = (hashCode * 59) + this.InvalidFields.GetHashCode();
                }
                if (this.LastPayout != null)
                {
                    hashCode = (hashCode * 59) + this.LastPayout.GetHashCode();
                }
                if (this.RefundResults != null)
                {
                    hashCode = (hashCode * 59) + this.RefundResults.GetHashCode();
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
