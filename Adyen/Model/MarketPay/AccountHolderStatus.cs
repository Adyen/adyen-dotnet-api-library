#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// AccountHolderStatus
    /// </summary>
    [DataContract]
    public partial class AccountHolderStatus : IEquatable<AccountHolderStatus>, IValidatableObject
    {
        /// <summary>
        /// The status of the account holder. &gt;Permitted values: &#x60;Active&#x60;, &#x60;Inactive&#x60;, &#x60;Suspended&#x60;, &#x60;Closed&#x60;.
        /// </summary>
        /// <value>The status of the account holder. &gt;Permitted values: &#x60;Active&#x60;, &#x60;Inactive&#x60;, &#x60;Suspended&#x60;, &#x60;Closed&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: Active
            /// </summary>
            [EnumMember(Value = "Active")]
            Active = 1,
            /// <summary>
            /// Enum Closed for value: Closed
            /// </summary>
            [EnumMember(Value = "Closed")]
            Closed = 2,
            /// <summary>
            /// Enum Inactive for value: Inactive
            /// </summary>
            [EnumMember(Value = "Inactive")]
            Inactive = 3,
            /// <summary>
            /// Enum Suspended for value: Suspended
            /// </summary>
            [EnumMember(Value = "Suspended")]
            Suspended = 4
        }
        /// <summary>
        /// The status of the account holder. &gt;Permitted values: &#x60;Active&#x60;, &#x60;Inactive&#x60;, &#x60;Suspended&#x60;, &#x60;Closed&#x60;.
        /// </summary>
        /// <value>The status of the account holder. &gt;Permitted values: &#x60;Active&#x60;, &#x60;Inactive&#x60;, &#x60;Suspended&#x60;, &#x60;Closed&#x60;.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountHolderStatus" /> class.
        /// </summary>
        /// <param name="events">A list of events scheduled for the account holder. (required).</param>
        /// <param name="payoutState">payoutState (required).</param>
        /// <param name="processingState">processingState (required).</param>
        /// <param name="status">The status of the account holder. &gt;Permitted values: &#x60;Active&#x60;, &#x60;Inactive&#x60;, &#x60;Suspended&#x60;, &#x60;Closed&#x60;. (required).</param>
        /// <param name="statusReason">The reason why the status was assigned to the account holder. (required).</param>
        public AccountHolderStatus(List<AccountEvent> events = default(List<AccountEvent>), AccountPayoutState payoutState = default(AccountPayoutState), AccountProcessingState processingState = default(AccountProcessingState), StatusEnum status = default(StatusEnum), string statusReason = default(string))
        {
            // to ensure "events" is required (not null)
            if (events == null)
            {
                throw new InvalidDataException("events is a required property for AccountHolderStatus and cannot be null");
            }
            else
            {
                this.Events = events;
            }
            // to ensure "payoutState" is required (not null)
            if (payoutState == null)
            {
                throw new InvalidDataException("payoutState is a required property for AccountHolderStatus and cannot be null");
            }
            else
            {
                this.PayoutState = payoutState;
            }
            // to ensure "processingState" is required (not null)
            if (processingState == null)
            {
                throw new InvalidDataException("processingState is a required property for AccountHolderStatus and cannot be null");
            }
            else
            {
                this.ProcessingState = processingState;
            }
            this.Status = status;
            this.StatusReason = statusReason;

        }

        /// <summary>
        /// A list of events scheduled for the account holder.
        /// </summary>
        /// <value>A list of events scheduled for the account holder.</value>
        [DataMember(Name = "events", EmitDefaultValue = false)]
        public List<AccountEvent> Events { get; set; }

        /// <summary>
        /// Gets or Sets PayoutState
        /// </summary>
        [DataMember(Name = "payoutState", EmitDefaultValue = false)]
        public AccountPayoutState PayoutState { get; set; }

        /// <summary>
        /// Gets or Sets ProcessingState
        /// </summary>
        [DataMember(Name = "processingState", EmitDefaultValue = false)]
        public AccountProcessingState ProcessingState { get; set; }


        /// <summary>
        /// The reason why the status was assigned to the account holder.
        /// </summary>
        /// <value>The reason why the status was assigned to the account holder.</value>
        [DataMember(Name = "statusReason", EmitDefaultValue = false)]
        public string StatusReason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountHolderStatus {\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  PayoutState: ").Append(PayoutState).Append("\n");
            sb.Append("  ProcessingState: ").Append(ProcessingState).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusReason: ").Append(StatusReason).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccountHolderStatus);
        }

        /// <summary>
        /// Returns true if AccountHolderStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountHolderStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountHolderStatus input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    input.Events != null &&
                    this.Events.SequenceEqual(input.Events)
                ) &&
                (
                    this.PayoutState == input.PayoutState ||
                    (this.PayoutState != null &&
                    this.PayoutState.Equals(input.PayoutState))
                ) &&
                (
                    this.ProcessingState == input.ProcessingState ||
                    (this.ProcessingState != null &&
                    this.ProcessingState.Equals(input.ProcessingState))
                ) &&
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) &&
                (
                    this.StatusReason == input.StatusReason ||
                    (this.StatusReason != null &&
                    this.StatusReason.Equals(input.StatusReason))
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
                if (this.Events != null)
                    hashCode = hashCode * 59 + this.Events.GetHashCode();
                if (this.PayoutState != null)
                    hashCode = hashCode * 59 + this.PayoutState.GetHashCode();
                if (this.ProcessingState != null)
                    hashCode = hashCode * 59 + this.ProcessingState.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusReason != null)
                    hashCode = hashCode * 59 + this.StatusReason.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
