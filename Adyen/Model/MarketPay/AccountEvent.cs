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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// AccountEvent
    /// </summary>
    [DataContract]
        public partial class AccountEvent :  IEquatable<AccountEvent>, IValidatableObject
    {
        /// <summary>
        /// The event. &gt;Permitted values: &#x60;InactivateAccount&#x60;, &#x60;RefundNotPaidOutTransfers&#x60;. For more information, refer to [Verification checks](https://docs.adyen.com/marketpay/onboarding-and-verification/verification-checks).
        /// </summary>
        /// <value>The event. &gt;Permitted values: &#x60;InactivateAccount&#x60;, &#x60;RefundNotPaidOutTransfers&#x60;. For more information, refer to [Verification checks](https://docs.adyen.com/marketpay/onboarding-and-verification/verification-checks).</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum EventEnum
        {
            /// <summary>
            /// Enum InactivateAccount for value: InactivateAccount
            /// </summary>
            [EnumMember(Value = "InactivateAccount")]
            InactivateAccount = 1,
            /// <summary>
            /// Enum RefundNotPaidOutTransfers for value: RefundNotPaidOutTransfers
            /// </summary>
            [EnumMember(Value = "RefundNotPaidOutTransfers")]
            RefundNotPaidOutTransfers = 2        }
        /// <summary>
        /// The event. &gt;Permitted values: &#x60;InactivateAccount&#x60;, &#x60;RefundNotPaidOutTransfers&#x60;. For more information, refer to [Verification checks](https://docs.adyen.com/marketpay/onboarding-and-verification/verification-checks).
        /// </summary>
        /// <value>The event. &gt;Permitted values: &#x60;InactivateAccount&#x60;, &#x60;RefundNotPaidOutTransfers&#x60;. For more information, refer to [Verification checks](https://docs.adyen.com/marketpay/onboarding-and-verification/verification-checks).</value>
        [DataMember(Name="event", EmitDefaultValue=false)]
        public EventEnum Event { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountEvent" /> class.
        /// </summary>
        /// <param name="_event">The event. &gt;Permitted values: &#x60;InactivateAccount&#x60;, &#x60;RefundNotPaidOutTransfers&#x60;. For more information, refer to [Verification checks](https://docs.adyen.com/marketpay/onboarding-and-verification/verification-checks). (required).</param>
        /// <param name="executionDate">The date on which the event will take place. (required).</param>
        /// <param name="reason">The reason why this event has been created. (required).</param>
        public AccountEvent(EventEnum _event = default(EventEnum), DateTime? executionDate = default(DateTime?), string reason = default(string))
        {
            // to ensure "_event" is required (not null)
            if (_event == null)
            {
                throw new InvalidDataException("_event is a required property for AccountEvent and cannot be null");
            }
            else
            {
                this.Event = _event;
            }
            // to ensure "executionDate" is required (not null)
            if (executionDate == null)
            {
                throw new InvalidDataException("executionDate is a required property for AccountEvent and cannot be null");
            }
            else
            {
                this.ExecutionDate = executionDate;
            }
            // to ensure "reason" is required (not null)
            if (reason == null)
            {
                throw new InvalidDataException("reason is a required property for AccountEvent and cannot be null");
            }
            else
            {
                this.Reason = reason;
            }
        }
        

        /// <summary>
        /// The date on which the event will take place.
        /// </summary>
        /// <value>The date on which the event will take place.</value>
        [DataMember(Name="executionDate", EmitDefaultValue=false)]
        public DateTime? ExecutionDate { get; set; }

        /// <summary>
        /// The reason why this event has been created.
        /// </summary>
        /// <value>The reason why this event has been created.</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountEvent {\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  ExecutionDate: ").Append(ExecutionDate).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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
            return this.Equals(input as AccountEvent);
        }

        /// <summary>
        /// Returns true if AccountEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Event == input.Event ||
                    (this.Event != null &&
                    this.Event.Equals(input.Event))
                ) && 
                (
                    this.ExecutionDate == input.ExecutionDate ||
                    (this.ExecutionDate != null &&
                    this.ExecutionDate.Equals(input.ExecutionDate))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
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
                if (this.Event != null)
                    hashCode = hashCode * 59 + this.Event.GetHashCode();
                if (this.ExecutionDate != null)
                    hashCode = hashCode * 59 + this.ExecutionDate.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
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
