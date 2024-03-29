/*
* Account API
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

namespace Adyen.Model.PlatformsAccount
{
    /// <summary>
    /// CreateAccountRequest
    /// </summary>
    [DataContract(Name = "CreateAccountRequest")]
    public partial class CreateAccountRequest : IEquatable<CreateAccountRequest>, IValidatableObject
    {
        /// <summary>
        /// The payout schedule of the prospective account. &gt;Permitted values: &#x60;DEFAULT&#x60;, &#x60;HOLD&#x60;, &#x60;DAILY&#x60;, &#x60;WEEKLY&#x60;, &#x60;MONTHLY&#x60;.
        /// </summary>
        /// <value>The payout schedule of the prospective account. &gt;Permitted values: &#x60;DEFAULT&#x60;, &#x60;HOLD&#x60;, &#x60;DAILY&#x60;, &#x60;WEEKLY&#x60;, &#x60;MONTHLY&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PayoutScheduleEnum
        {
            /// <summary>
            /// Enum BIWEEKLYON1STAND15THATMIDNIGHT for value: BIWEEKLY_ON_1ST_AND_15TH_AT_MIDNIGHT
            /// </summary>
            [EnumMember(Value = "BIWEEKLY_ON_1ST_AND_15TH_AT_MIDNIGHT")]
            BIWEEKLYON1STAND15THATMIDNIGHT = 1,

            /// <summary>
            /// Enum DAILY for value: DAILY
            /// </summary>
            [EnumMember(Value = "DAILY")]
            DAILY = 2,

            /// <summary>
            /// Enum DAILYAU for value: DAILY_AU
            /// </summary>
            [EnumMember(Value = "DAILY_AU")]
            DAILYAU = 3,

            /// <summary>
            /// Enum DAILYEU for value: DAILY_EU
            /// </summary>
            [EnumMember(Value = "DAILY_EU")]
            DAILYEU = 4,

            /// <summary>
            /// Enum DAILYSG for value: DAILY_SG
            /// </summary>
            [EnumMember(Value = "DAILY_SG")]
            DAILYSG = 5,

            /// <summary>
            /// Enum DAILYUS for value: DAILY_US
            /// </summary>
            [EnumMember(Value = "DAILY_US")]
            DAILYUS = 6,

            /// <summary>
            /// Enum HOLD for value: HOLD
            /// </summary>
            [EnumMember(Value = "HOLD")]
            HOLD = 7,

            /// <summary>
            /// Enum MONTHLY for value: MONTHLY
            /// </summary>
            [EnumMember(Value = "MONTHLY")]
            MONTHLY = 8,

            /// <summary>
            /// Enum WEEKLY for value: WEEKLY
            /// </summary>
            [EnumMember(Value = "WEEKLY")]
            WEEKLY = 9,

            /// <summary>
            /// Enum WEEKLYMONTOFRIAU for value: WEEKLY_MON_TO_FRI_AU
            /// </summary>
            [EnumMember(Value = "WEEKLY_MON_TO_FRI_AU")]
            WEEKLYMONTOFRIAU = 10,

            /// <summary>
            /// Enum WEEKLYMONTOFRIEU for value: WEEKLY_MON_TO_FRI_EU
            /// </summary>
            [EnumMember(Value = "WEEKLY_MON_TO_FRI_EU")]
            WEEKLYMONTOFRIEU = 11,

            /// <summary>
            /// Enum WEEKLYMONTOFRIUS for value: WEEKLY_MON_TO_FRI_US
            /// </summary>
            [EnumMember(Value = "WEEKLY_MON_TO_FRI_US")]
            WEEKLYMONTOFRIUS = 12,

            /// <summary>
            /// Enum WEEKLYONTUEFRIMIDNIGHT for value: WEEKLY_ON_TUE_FRI_MIDNIGHT
            /// </summary>
            [EnumMember(Value = "WEEKLY_ON_TUE_FRI_MIDNIGHT")]
            WEEKLYONTUEFRIMIDNIGHT = 13,

            /// <summary>
            /// Enum WEEKLYSUNTOTHUAU for value: WEEKLY_SUN_TO_THU_AU
            /// </summary>
            [EnumMember(Value = "WEEKLY_SUN_TO_THU_AU")]
            WEEKLYSUNTOTHUAU = 14,

            /// <summary>
            /// Enum WEEKLYSUNTOTHUUS for value: WEEKLY_SUN_TO_THU_US
            /// </summary>
            [EnumMember(Value = "WEEKLY_SUN_TO_THU_US")]
            WEEKLYSUNTOTHUUS = 15

        }


        /// <summary>
        /// The payout schedule of the prospective account. &gt;Permitted values: &#x60;DEFAULT&#x60;, &#x60;HOLD&#x60;, &#x60;DAILY&#x60;, &#x60;WEEKLY&#x60;, &#x60;MONTHLY&#x60;.
        /// </summary>
        /// <value>The payout schedule of the prospective account. &gt;Permitted values: &#x60;DEFAULT&#x60;, &#x60;HOLD&#x60;, &#x60;DAILY&#x60;, &#x60;WEEKLY&#x60;, &#x60;MONTHLY&#x60;.</value>
        [DataMember(Name = "payoutSchedule", EmitDefaultValue = false)]
        public PayoutScheduleEnum? PayoutSchedule { get; set; }
        /// <summary>
        /// Speed with which payouts for this account are processed. Permitted values: &#x60;STANDARD&#x60;, &#x60;SAME_DAY&#x60;.
        /// </summary>
        /// <value>Speed with which payouts for this account are processed. Permitted values: &#x60;STANDARD&#x60;, &#x60;SAME_DAY&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PayoutSpeedEnum
        {
            /// <summary>
            /// Enum INSTANT for value: INSTANT
            /// </summary>
            [EnumMember(Value = "INSTANT")]
            INSTANT = 1,

            /// <summary>
            /// Enum SAMEDAY for value: SAME_DAY
            /// </summary>
            [EnumMember(Value = "SAME_DAY")]
            SAMEDAY = 2,

            /// <summary>
            /// Enum STANDARD for value: STANDARD
            /// </summary>
            [EnumMember(Value = "STANDARD")]
            STANDARD = 3

        }


        /// <summary>
        /// Speed with which payouts for this account are processed. Permitted values: &#x60;STANDARD&#x60;, &#x60;SAME_DAY&#x60;.
        /// </summary>
        /// <value>Speed with which payouts for this account are processed. Permitted values: &#x60;STANDARD&#x60;, &#x60;SAME_DAY&#x60;.</value>
        [DataMember(Name = "payoutSpeed", EmitDefaultValue = false)]
        public PayoutSpeedEnum? PayoutSpeed { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccountRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateAccountRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccountRequest" /> class.
        /// </summary>
        /// <param name="accountHolderCode">The code of Account Holder under which to create the account. (required).</param>
        /// <param name="bankAccountUUID">The bankAccountUUID of the bank account held by the account holder to couple the account with. Scheduled payouts in currencies matching the currency of this bank account will be sent to this bank account. Payouts in different currencies will be sent to a matching bank account of the account holder..</param>
        /// <param name="description">A description of the account, maximum 256 characters. You can use alphanumeric characters (A-Z, a-z, 0-9), white spaces, and underscores &#x60;_&#x60;..</param>
        /// <param name="metadata">A set of key and value pairs for general use by the merchant. The keys do not have specific names and may be used for storing miscellaneous data as desired. &gt; Note that during an update of metadata, the omission of existing key-value pairs will result in the deletion of those key-value pairs..</param>
        /// <param name="payoutMethodCode">The payout method code held by the account holder to couple the account with. Scheduled card payouts will be sent using this payout method code..</param>
        /// <param name="payoutSchedule">The payout schedule of the prospective account. &gt;Permitted values: &#x60;DEFAULT&#x60;, &#x60;HOLD&#x60;, &#x60;DAILY&#x60;, &#x60;WEEKLY&#x60;, &#x60;MONTHLY&#x60;..</param>
        /// <param name="payoutScheduleReason">The reason for the payout schedule choice. &gt;Required if the payoutSchedule is &#x60;HOLD&#x60;..</param>
        /// <param name="payoutSpeed">Speed with which payouts for this account are processed. Permitted values: &#x60;STANDARD&#x60;, &#x60;SAME_DAY&#x60;. (default to PayoutSpeedEnum.STANDARD).</param>
        public CreateAccountRequest(string accountHolderCode = default(string), string bankAccountUUID = default(string), string description = default(string), Dictionary<string, string> metadata = default(Dictionary<string, string>), string payoutMethodCode = default(string), PayoutScheduleEnum? payoutSchedule = default(PayoutScheduleEnum?), string payoutScheduleReason = default(string), PayoutSpeedEnum? payoutSpeed = PayoutSpeedEnum.STANDARD)
        {
            this.AccountHolderCode = accountHolderCode;
            this.BankAccountUUID = bankAccountUUID;
            this.Description = description;
            this.Metadata = metadata;
            this.PayoutMethodCode = payoutMethodCode;
            this.PayoutSchedule = payoutSchedule;
            this.PayoutScheduleReason = payoutScheduleReason;
            this.PayoutSpeed = payoutSpeed;
        }

        /// <summary>
        /// The code of Account Holder under which to create the account.
        /// </summary>
        /// <value>The code of Account Holder under which to create the account.</value>
        [DataMember(Name = "accountHolderCode", IsRequired = false, EmitDefaultValue = false)]
        public string AccountHolderCode { get; set; }

        /// <summary>
        /// The bankAccountUUID of the bank account held by the account holder to couple the account with. Scheduled payouts in currencies matching the currency of this bank account will be sent to this bank account. Payouts in different currencies will be sent to a matching bank account of the account holder.
        /// </summary>
        /// <value>The bankAccountUUID of the bank account held by the account holder to couple the account with. Scheduled payouts in currencies matching the currency of this bank account will be sent to this bank account. Payouts in different currencies will be sent to a matching bank account of the account holder.</value>
        [DataMember(Name = "bankAccountUUID", EmitDefaultValue = false)]
        public string BankAccountUUID { get; set; }

        /// <summary>
        /// A description of the account, maximum 256 characters. You can use alphanumeric characters (A-Z, a-z, 0-9), white spaces, and underscores &#x60;_&#x60;.
        /// </summary>
        /// <value>A description of the account, maximum 256 characters. You can use alphanumeric characters (A-Z, a-z, 0-9), white spaces, and underscores &#x60;_&#x60;.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// A set of key and value pairs for general use by the merchant. The keys do not have specific names and may be used for storing miscellaneous data as desired. &gt; Note that during an update of metadata, the omission of existing key-value pairs will result in the deletion of those key-value pairs.
        /// </summary>
        /// <value>A set of key and value pairs for general use by the merchant. The keys do not have specific names and may be used for storing miscellaneous data as desired. &gt; Note that during an update of metadata, the omission of existing key-value pairs will result in the deletion of those key-value pairs.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The payout method code held by the account holder to couple the account with. Scheduled card payouts will be sent using this payout method code.
        /// </summary>
        /// <value>The payout method code held by the account holder to couple the account with. Scheduled card payouts will be sent using this payout method code.</value>
        [DataMember(Name = "payoutMethodCode", EmitDefaultValue = false)]
        public string PayoutMethodCode { get; set; }

        /// <summary>
        /// The reason for the payout schedule choice. &gt;Required if the payoutSchedule is &#x60;HOLD&#x60;.
        /// </summary>
        /// <value>The reason for the payout schedule choice. &gt;Required if the payoutSchedule is &#x60;HOLD&#x60;.</value>
        [DataMember(Name = "payoutScheduleReason", EmitDefaultValue = false)]
        public string PayoutScheduleReason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateAccountRequest {\n");
            sb.Append("  AccountHolderCode: ").Append(AccountHolderCode).Append("\n");
            sb.Append("  BankAccountUUID: ").Append(BankAccountUUID).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  PayoutMethodCode: ").Append(PayoutMethodCode).Append("\n");
            sb.Append("  PayoutSchedule: ").Append(PayoutSchedule).Append("\n");
            sb.Append("  PayoutScheduleReason: ").Append(PayoutScheduleReason).Append("\n");
            sb.Append("  PayoutSpeed: ").Append(PayoutSpeed).Append("\n");
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
            return this.Equals(input as CreateAccountRequest);
        }

        /// <summary>
        /// Returns true if CreateAccountRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateAccountRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateAccountRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountHolderCode == input.AccountHolderCode ||
                    (this.AccountHolderCode != null &&
                    this.AccountHolderCode.Equals(input.AccountHolderCode))
                ) && 
                (
                    this.BankAccountUUID == input.BankAccountUUID ||
                    (this.BankAccountUUID != null &&
                    this.BankAccountUUID.Equals(input.BankAccountUUID))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.PayoutMethodCode == input.PayoutMethodCode ||
                    (this.PayoutMethodCode != null &&
                    this.PayoutMethodCode.Equals(input.PayoutMethodCode))
                ) && 
                (
                    this.PayoutSchedule == input.PayoutSchedule ||
                    this.PayoutSchedule.Equals(input.PayoutSchedule)
                ) && 
                (
                    this.PayoutScheduleReason == input.PayoutScheduleReason ||
                    (this.PayoutScheduleReason != null &&
                    this.PayoutScheduleReason.Equals(input.PayoutScheduleReason))
                ) && 
                (
                    this.PayoutSpeed == input.PayoutSpeed ||
                    this.PayoutSpeed.Equals(input.PayoutSpeed)
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
                if (this.AccountHolderCode != null)
                {
                    hashCode = (hashCode * 59) + this.AccountHolderCode.GetHashCode();
                }
                if (this.BankAccountUUID != null)
                {
                    hashCode = (hashCode * 59) + this.BankAccountUUID.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.PayoutMethodCode != null)
                {
                    hashCode = (hashCode * 59) + this.PayoutMethodCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PayoutSchedule.GetHashCode();
                if (this.PayoutScheduleReason != null)
                {
                    hashCode = (hashCode * 59) + this.PayoutScheduleReason.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PayoutSpeed.GetHashCode();
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
