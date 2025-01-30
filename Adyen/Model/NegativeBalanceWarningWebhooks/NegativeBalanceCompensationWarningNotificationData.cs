/*
* Negative balance compensation warning 
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

namespace Adyen.Model.NegativeBalanceWarningWebhooks
{
    /// <summary>
    /// NegativeBalanceCompensationWarningNotificationData
    /// </summary>
    [DataContract(Name = "NegativeBalanceCompensationWarningNotificationData")]
    public partial class NegativeBalanceCompensationWarningNotificationData : IEquatable<NegativeBalanceCompensationWarningNotificationData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NegativeBalanceCompensationWarningNotificationData" /> class.
        /// </summary>
        /// <param name="accountHolder">accountHolder.</param>
        /// <param name="amount">amount.</param>
        /// <param name="balancePlatform">The unique identifier of the balance platform..</param>
        /// <param name="creationDate">The date and time when the event was triggered, in ISO 8601 extended format. For example, **2020-12-18T10:15:30+01:00**..</param>
        /// <param name="id">The ID of the resource..</param>
        /// <param name="liableBalanceAccountId">The balance account ID of the account that will be used to compensate the balance account whose balance is negative..</param>
        /// <param name="negativeBalanceSince">The date the balance for the account became negative..</param>
        /// <param name="scheduledCompensationAt">The date when a compensation transfer to the account is scheduled to happen..</param>
        public NegativeBalanceCompensationWarningNotificationData(ResourceReference accountHolder = default(ResourceReference), Amount amount = default(Amount), string balancePlatform = default(string), DateTime creationDate = default(DateTime), string id = default(string), string liableBalanceAccountId = default(string), DateTime negativeBalanceSince = default(DateTime), DateTime scheduledCompensationAt = default(DateTime))
        {
            this.AccountHolder = accountHolder;
            this.Amount = amount;
            this.BalancePlatform = balancePlatform;
            this.CreationDate = creationDate;
            this.Id = id;
            this.LiableBalanceAccountId = liableBalanceAccountId;
            this.NegativeBalanceSince = negativeBalanceSince;
            this.ScheduledCompensationAt = scheduledCompensationAt;
        }

        /// <summary>
        /// Gets or Sets AccountHolder
        /// </summary>
        [DataMember(Name = "accountHolder", EmitDefaultValue = false)]
        public ResourceReference AccountHolder { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Amount Amount { get; set; }

        /// <summary>
        /// The unique identifier of the balance platform.
        /// </summary>
        /// <value>The unique identifier of the balance platform.</value>
        [DataMember(Name = "balancePlatform", EmitDefaultValue = false)]
        public string BalancePlatform { get; set; }

        /// <summary>
        /// The date and time when the event was triggered, in ISO 8601 extended format. For example, **2020-12-18T10:15:30+01:00**.
        /// </summary>
        /// <value>The date and time when the event was triggered, in ISO 8601 extended format. For example, **2020-12-18T10:15:30+01:00**.</value>
        [DataMember(Name = "creationDate", EmitDefaultValue = false)]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// The ID of the resource.
        /// </summary>
        /// <value>The ID of the resource.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The balance account ID of the account that will be used to compensate the balance account whose balance is negative.
        /// </summary>
        /// <value>The balance account ID of the account that will be used to compensate the balance account whose balance is negative.</value>
        [DataMember(Name = "liableBalanceAccountId", EmitDefaultValue = false)]
        public string LiableBalanceAccountId { get; set; }

        /// <summary>
        /// The date the balance for the account became negative.
        /// </summary>
        /// <value>The date the balance for the account became negative.</value>
        [DataMember(Name = "negativeBalanceSince", EmitDefaultValue = false)]
        public DateTime NegativeBalanceSince { get; set; }

        /// <summary>
        /// The date when a compensation transfer to the account is scheduled to happen.
        /// </summary>
        /// <value>The date when a compensation transfer to the account is scheduled to happen.</value>
        [DataMember(Name = "scheduledCompensationAt", EmitDefaultValue = false)]
        public DateTime ScheduledCompensationAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NegativeBalanceCompensationWarningNotificationData {\n");
            sb.Append("  AccountHolder: ").Append(AccountHolder).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BalancePlatform: ").Append(BalancePlatform).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LiableBalanceAccountId: ").Append(LiableBalanceAccountId).Append("\n");
            sb.Append("  NegativeBalanceSince: ").Append(NegativeBalanceSince).Append("\n");
            sb.Append("  ScheduledCompensationAt: ").Append(ScheduledCompensationAt).Append("\n");
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
            return this.Equals(input as NegativeBalanceCompensationWarningNotificationData);
        }

        /// <summary>
        /// Returns true if NegativeBalanceCompensationWarningNotificationData instances are equal
        /// </summary>
        /// <param name="input">Instance of NegativeBalanceCompensationWarningNotificationData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NegativeBalanceCompensationWarningNotificationData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountHolder == input.AccountHolder ||
                    (this.AccountHolder != null &&
                    this.AccountHolder.Equals(input.AccountHolder))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.BalancePlatform == input.BalancePlatform ||
                    (this.BalancePlatform != null &&
                    this.BalancePlatform.Equals(input.BalancePlatform))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LiableBalanceAccountId == input.LiableBalanceAccountId ||
                    (this.LiableBalanceAccountId != null &&
                    this.LiableBalanceAccountId.Equals(input.LiableBalanceAccountId))
                ) && 
                (
                    this.NegativeBalanceSince == input.NegativeBalanceSince ||
                    (this.NegativeBalanceSince != null &&
                    this.NegativeBalanceSince.Equals(input.NegativeBalanceSince))
                ) && 
                (
                    this.ScheduledCompensationAt == input.ScheduledCompensationAt ||
                    (this.ScheduledCompensationAt != null &&
                    this.ScheduledCompensationAt.Equals(input.ScheduledCompensationAt))
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
                if (this.AccountHolder != null)
                {
                    hashCode = (hashCode * 59) + this.AccountHolder.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.BalancePlatform != null)
                {
                    hashCode = (hashCode * 59) + this.BalancePlatform.GetHashCode();
                }
                if (this.CreationDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreationDate.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.LiableBalanceAccountId != null)
                {
                    hashCode = (hashCode * 59) + this.LiableBalanceAccountId.GetHashCode();
                }
                if (this.NegativeBalanceSince != null)
                {
                    hashCode = (hashCode * 59) + this.NegativeBalanceSince.GetHashCode();
                }
                if (this.ScheduledCompensationAt != null)
                {
                    hashCode = (hashCode * 59) + this.ScheduledCompensationAt.GetHashCode();
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
