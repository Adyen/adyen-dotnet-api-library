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
    /// UpdateAccountHolderStateRequest
    /// </summary>
    [DataContract]
        public class UpdateAccountHolderStateRequest :  IEquatable<UpdateAccountHolderStateRequest>, IValidatableObject
    {
        /// <summary>
        /// The state to be updated. &gt;Permitted values are: &#x60;Processing&#x60;, &#x60;Payout&#x60;
        /// </summary>
        /// <value>The state to be updated. &gt;Permitted values are: &#x60;Processing&#x60;, &#x60;Payout&#x60;</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StateTypeEnum
        {
            /// <summary>
            /// Enum LimitedPayout for value: LimitedPayout
            /// </summary>
            [EnumMember(Value = "LimitedPayout")]
            LimitedPayout = 1,
            /// <summary>
            /// Enum LimitedProcessing for value: LimitedProcessing
            /// </summary>
            [EnumMember(Value = "LimitedProcessing")]
            LimitedProcessing = 2,
            /// <summary>
            /// Enum LimitlessPayout for value: LimitlessPayout
            /// </summary>
            [EnumMember(Value = "LimitlessPayout")]
            LimitlessPayout = 3,
            /// <summary>
            /// Enum LimitlessProcessing for value: LimitlessProcessing
            /// </summary>
            [EnumMember(Value = "LimitlessProcessing")]
            LimitlessProcessing = 4,
            /// <summary>
            /// Enum Payout for value: Payout
            /// </summary>
            [EnumMember(Value = "Payout")]
            Payout = 5,
            /// <summary>
            /// Enum Processing for value: Processing
            /// </summary>
            [EnumMember(Value = "Processing")]
            Processing = 6        }
        /// <summary>
        /// The state to be updated. &gt;Permitted values are: &#x60;Processing&#x60;, &#x60;Payout&#x60;
        /// </summary>
        /// <value>The state to be updated. &gt;Permitted values are: &#x60;Processing&#x60;, &#x60;Payout&#x60;</value>
        [DataMember(Name="stateType", EmitDefaultValue=false)]
        public StateTypeEnum StateType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAccountHolderStateRequest" /> class.
        /// </summary>
        /// <param name="accountHolderCode">The code of the Account Holder on which to update the state. (required).</param>
        /// <param name="disable">If true, disable the requested state.  If false, enable the requested state. (required).</param>
        /// <param name="reason">The reason that the state is being updated. &gt;Required if the state is being disabled..</param>
        /// <param name="stateType">The state to be updated. &gt;Permitted values are: &#x60;Processing&#x60;, &#x60;Payout&#x60; (required).</param>
        public UpdateAccountHolderStateRequest(string accountHolderCode = default(string), bool? disable = default(bool?), string reason = default(string), StateTypeEnum stateType = default(StateTypeEnum))
        {
            // to ensure "accountHolderCode" is required (not null)
            if (accountHolderCode == null)
            {
                throw new InvalidDataException("accountHolderCode is a required property for UpdateAccountHolderStateRequest and cannot be null");
            }

            AccountHolderCode = accountHolderCode;
            // to ensure "disable" is required (not null)
            if (disable == null)
            {
                throw new InvalidDataException("disable is a required property for UpdateAccountHolderStateRequest and cannot be null");
            }

            Disable = disable;

            StateType = stateType;       
            Reason = reason;
        }
        
        /// <summary>
        /// The code of the Account Holder on which to update the state.
        /// </summary>
        /// <value>The code of the Account Holder on which to update the state.</value>
        [DataMember(Name="accountHolderCode", EmitDefaultValue=false)]
        public string AccountHolderCode { get; set; }

        /// <summary>
        /// If true, disable the requested state.  If false, enable the requested state.
        /// </summary>
        /// <value>If true, disable the requested state.  If false, enable the requested state.</value>
        [DataMember(Name="disable", EmitDefaultValue=false)]
        public bool? Disable { get; set; }

        /// <summary>
        /// The reason that the state is being updated. &gt;Required if the state is being disabled.
        /// </summary>
        /// <value>The reason that the state is being updated. &gt;Required if the state is being disabled.</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAccountHolderStateRequest {\n");
            sb.Append("  AccountHolderCode: ").Append(AccountHolderCode).Append("\n");
            sb.Append("  Disable: ").Append(Disable).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  StateType: ").Append(StateType).Append("\n");
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
            return Equals(input as UpdateAccountHolderStateRequest);
        }

        /// <summary>
        /// Returns true if UpdateAccountHolderStateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateAccountHolderStateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateAccountHolderStateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    AccountHolderCode == input.AccountHolderCode ||
                    (AccountHolderCode != null &&
                    AccountHolderCode.Equals(input.AccountHolderCode))
                ) && 
                (
                    Disable == input.Disable ||
                    (Disable != null &&
                    Disable.Equals(input.Disable))
                ) && 
                (
                    Reason == input.Reason ||
                    (Reason != null &&
                    Reason.Equals(input.Reason))
                ) && 
                (
                    StateType == input.StateType ||
                    StateType.Equals(input.StateType)
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
                if (AccountHolderCode != null)
                    hashCode = hashCode * 59 + AccountHolderCode.GetHashCode();
                if (Disable != null)
                    hashCode = hashCode * 59 + Disable.GetHashCode();
                if (Reason != null)
                    hashCode = hashCode * 59 + Reason.GetHashCode();
                hashCode = hashCode * 59 + StateType.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
