#region License
/*
 *                       ######
 *                       ######
 * ############    ####( ######  #####. ######  ############   ############
 * #############  #####( ######  #####. ######  #############  #############
 *        ######  #####( ######  #####. ######  #####  ######  #####  ######
 * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
 * ###### ######  #####( ######  #####. ######  #####          #####  ######
 * #############  #############  #############  #############  #####  ######
 *  ############   ############  #############   ############  #####  ######
 *                                      ######
 *                               #############
 *                               ############
 *
 * Adyen Dotnet API Library
 *
 * Copyright (c) 2022 Adyen N.V.
 * This file is open source and available under the MIT license.
 * See the LICENSE file for more info.
 */
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
    /// UpdateAccountRequest
    /// </summary>
    [DataContract]
        public partial class UpdateAccountRequest :  IEquatable<UpdateAccountRequest>, IValidatableObject
    {
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
            STANDARD = 3        }
        /// <summary>
        /// Speed with which payouts for this account are processed. Permitted values: &#x60;STANDARD&#x60;, &#x60;SAME_DAY&#x60;.
        /// </summary>
        /// <value>Speed with which payouts for this account are processed. Permitted values: &#x60;STANDARD&#x60;, &#x60;SAME_DAY&#x60;.</value>
        [DataMember(Name="payoutSpeed", EmitDefaultValue=false)]
        public PayoutSpeedEnum? PayoutSpeed { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAccountRequest" /> class.
        /// </summary>
        /// <param name="accountCode">The code of the account to update. (required).</param>
        /// <param name="bankAccountUUID">The bankAccountUUID of the bank account held by the account holder to couple the account with. Scheduled payouts in currencies matching the currency of this bank account will be sent to this bank account. Payouts in different currencies will be sent to a matching bank account of the account holder..</param>
        /// <param name="description">A description of the account, maximum 256 characters.You can use alphanumeric characters (A-Z, a-z, 0-9), white spaces, and underscores &#x60;_&#x60;..</param>
        /// <param name="metadata">A set of key and value pairs for general use by the merchant. The keys do not have specific names and may be used for storing miscellaneous data as desired. &gt; Note that during an update of metadata, the omission of existing key-value pairs will result in the deletion of those key-value pairs..</param>
        /// <param name="payoutMethodCode">The payout method code held by the account holder to couple the account with. Scheduled card payouts will be sent using this payout method code..</param>
        /// <param name="payoutSchedule">payoutSchedule.</param>
        /// <param name="payoutSpeed">Speed with which payouts for this account are processed. Permitted values: &#x60;STANDARD&#x60;, &#x60;SAME_DAY&#x60;..</param>
        public UpdateAccountRequest(string accountCode = default(string), string bankAccountUUID = default(string), string description = default(string), Dictionary<string, string> metadata = default(Dictionary<string, string>), string payoutMethodCode = default(string), UpdatePayoutScheduleRequest payoutSchedule = default(UpdatePayoutScheduleRequest), PayoutSpeedEnum? payoutSpeed = default(PayoutSpeedEnum?))
        {
            // to ensure "accountCode" is required (not null)
            if (accountCode == null)
            {
                throw new InvalidDataException("accountCode is a required property for UpdateAccountRequest and cannot be null");
            }
            else
            {
                this.AccountCode = accountCode;
            }
            this.BankAccountUUID = bankAccountUUID;
            this.Description = description;
            this.Metadata = metadata;
            this.PayoutMethodCode = payoutMethodCode;
            this.PayoutSchedule = payoutSchedule;
            this.PayoutSpeed = payoutSpeed;
        }
        
        /// <summary>
        /// The code of the account to update.
        /// </summary>
        /// <value>The code of the account to update.</value>
        [DataMember(Name="accountCode", EmitDefaultValue=false)]
        public string AccountCode { get; set; }

        /// <summary>
        /// The bankAccountUUID of the bank account held by the account holder to couple the account with. Scheduled payouts in currencies matching the currency of this bank account will be sent to this bank account. Payouts in different currencies will be sent to a matching bank account of the account holder.
        /// </summary>
        /// <value>The bankAccountUUID of the bank account held by the account holder to couple the account with. Scheduled payouts in currencies matching the currency of this bank account will be sent to this bank account. Payouts in different currencies will be sent to a matching bank account of the account holder.</value>
        [DataMember(Name="bankAccountUUID", EmitDefaultValue=false)]
        public string BankAccountUUID { get; set; }

        /// <summary>
        /// A description of the account, maximum 256 characters.You can use alphanumeric characters (A-Z, a-z, 0-9), white spaces, and underscores &#x60;_&#x60;.
        /// </summary>
        /// <value>A description of the account, maximum 256 characters.You can use alphanumeric characters (A-Z, a-z, 0-9), white spaces, and underscores &#x60;_&#x60;.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// A set of key and value pairs for general use by the merchant. The keys do not have specific names and may be used for storing miscellaneous data as desired. &gt; Note that during an update of metadata, the omission of existing key-value pairs will result in the deletion of those key-value pairs.
        /// </summary>
        /// <value>A set of key and value pairs for general use by the merchant. The keys do not have specific names and may be used for storing miscellaneous data as desired. &gt; Note that during an update of metadata, the omission of existing key-value pairs will result in the deletion of those key-value pairs.</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The payout method code held by the account holder to couple the account with. Scheduled card payouts will be sent using this payout method code.
        /// </summary>
        /// <value>The payout method code held by the account holder to couple the account with. Scheduled card payouts will be sent using this payout method code.</value>
        [DataMember(Name="payoutMethodCode", EmitDefaultValue=false)]
        public string PayoutMethodCode { get; set; }

        /// <summary>
        /// Gets or Sets PayoutSchedule
        /// </summary>
        [DataMember(Name="payoutSchedule", EmitDefaultValue=false)]
        public UpdatePayoutScheduleRequest PayoutSchedule { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAccountRequest {\n");
            sb.Append("  AccountCode: ").Append(AccountCode).Append("\n");
            sb.Append("  BankAccountUUID: ").Append(BankAccountUUID).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  PayoutMethodCode: ").Append(PayoutMethodCode).Append("\n");
            sb.Append("  PayoutSchedule: ").Append(PayoutSchedule).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateAccountRequest);
        }

        /// <summary>
        /// Returns true if UpdateAccountRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateAccountRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateAccountRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountCode == input.AccountCode ||
                    (this.AccountCode != null &&
                    this.AccountCode.Equals(input.AccountCode))
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
                    (this.PayoutSchedule != null &&
                    this.PayoutSchedule.Equals(input.PayoutSchedule))
                ) && 
                (
                    this.PayoutSpeed == input.PayoutSpeed ||
                    (this.PayoutSpeed != null &&
                    this.PayoutSpeed.Equals(input.PayoutSpeed))
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
                    hashCode = hashCode * 59 + this.AccountCode.GetHashCode();
                if (this.BankAccountUUID != null)
                    hashCode = hashCode * 59 + this.BankAccountUUID.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.PayoutMethodCode != null)
                    hashCode = hashCode * 59 + this.PayoutMethodCode.GetHashCode();
                if (this.PayoutSchedule != null)
                    hashCode = hashCode * 59 + this.PayoutSchedule.GetHashCode();
                if (this.PayoutSpeed != null)
                    hashCode = hashCode * 59 + this.PayoutSpeed.GetHashCode();
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
