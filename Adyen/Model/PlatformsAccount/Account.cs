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
    /// Account
    /// </summary>
    [DataContract(Name = "Account")]
    public partial class Account : IEquatable<Account>, IValidatableObject
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
            STANDARD = 3

        }


        /// <summary>
        /// Speed with which payouts for this account are processed. Permitted values: &#x60;STANDARD&#x60;, &#x60;SAME_DAY&#x60;.
        /// </summary>
        /// <value>Speed with which payouts for this account are processed. Permitted values: &#x60;STANDARD&#x60;, &#x60;SAME_DAY&#x60;.</value>
        [DataMember(Name = "payoutSpeed", EmitDefaultValue = false)]
        public PayoutSpeedEnum? PayoutSpeed { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        /// <param name="accountCode">The code of the account..</param>
        /// <param name="bankAccountUUID">The bankAccountUUID of the bank account held by the account holder to couple the account with. Scheduled payouts in currencies matching the currency of this bank account will be sent to this bank account. Payouts in different currencies will be sent to a matching bank account of the account holder..</param>
        /// <param name="beneficiaryAccount">The beneficiary of the account..</param>
        /// <param name="beneficiaryMerchantReference">The reason that a beneficiary has been set up for this account. This may have been supplied during the setup of a beneficiary at the discretion of the executing user..</param>
        /// <param name="description">A description of the account..</param>
        /// <param name="metadata">A set of key and value pairs for general use by the merchant. The keys do not have specific names and may be used for storing miscellaneous data as desired. &gt; Note that during an update of metadata, the omission of existing key-value pairs will result in the deletion of those key-value pairs..</param>
        /// <param name="payoutMethodCode">The payout method code held by the account holder to couple the account with. Scheduled card payouts will be sent using this payout method code..</param>
        /// <param name="payoutSchedule">payoutSchedule.</param>
        /// <param name="payoutSpeed">Speed with which payouts for this account are processed. Permitted values: &#x60;STANDARD&#x60;, &#x60;SAME_DAY&#x60;..</param>
        /// <param name="status">The status of the account. Possible values: &#x60;Active&#x60;, &#x60;Inactive&#x60;, &#x60;Suspended&#x60;, &#x60;Closed&#x60;..</param>
        public Account(string accountCode = default(string), string bankAccountUUID = default(string), string beneficiaryAccount = default(string), string beneficiaryMerchantReference = default(string), string description = default(string), Dictionary<string, string> metadata = default(Dictionary<string, string>), string payoutMethodCode = default(string), PayoutScheduleResponse payoutSchedule = default(PayoutScheduleResponse), PayoutSpeedEnum? payoutSpeed = default(PayoutSpeedEnum?), string status = default(string))
        {
            this.AccountCode = accountCode;
            this.BankAccountUUID = bankAccountUUID;
            this.BeneficiaryAccount = beneficiaryAccount;
            this.BeneficiaryMerchantReference = beneficiaryMerchantReference;
            this.Description = description;
            this.Metadata = metadata;
            this.PayoutMethodCode = payoutMethodCode;
            this.PayoutSchedule = payoutSchedule;
            this.PayoutSpeed = payoutSpeed;
            this.Status = status;
        }

        /// <summary>
        /// The code of the account.
        /// </summary>
        /// <value>The code of the account.</value>
        [DataMember(Name = "accountCode", EmitDefaultValue = false)]
        public string AccountCode { get; set; }

        /// <summary>
        /// The bankAccountUUID of the bank account held by the account holder to couple the account with. Scheduled payouts in currencies matching the currency of this bank account will be sent to this bank account. Payouts in different currencies will be sent to a matching bank account of the account holder.
        /// </summary>
        /// <value>The bankAccountUUID of the bank account held by the account holder to couple the account with. Scheduled payouts in currencies matching the currency of this bank account will be sent to this bank account. Payouts in different currencies will be sent to a matching bank account of the account holder.</value>
        [DataMember(Name = "bankAccountUUID", EmitDefaultValue = false)]
        public string BankAccountUUID { get; set; }

        /// <summary>
        /// The beneficiary of the account.
        /// </summary>
        /// <value>The beneficiary of the account.</value>
        [DataMember(Name = "beneficiaryAccount", EmitDefaultValue = false)]
        public string BeneficiaryAccount { get; set; }

        /// <summary>
        /// The reason that a beneficiary has been set up for this account. This may have been supplied during the setup of a beneficiary at the discretion of the executing user.
        /// </summary>
        /// <value>The reason that a beneficiary has been set up for this account. This may have been supplied during the setup of a beneficiary at the discretion of the executing user.</value>
        [DataMember(Name = "beneficiaryMerchantReference", EmitDefaultValue = false)]
        public string BeneficiaryMerchantReference { get; set; }

        /// <summary>
        /// A description of the account.
        /// </summary>
        /// <value>A description of the account.</value>
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
        /// Gets or Sets PayoutSchedule
        /// </summary>
        [DataMember(Name = "payoutSchedule", EmitDefaultValue = false)]
        public PayoutScheduleResponse PayoutSchedule { get; set; }

        /// <summary>
        /// The status of the account. Possible values: &#x60;Active&#x60;, &#x60;Inactive&#x60;, &#x60;Suspended&#x60;, &#x60;Closed&#x60;.
        /// </summary>
        /// <value>The status of the account. Possible values: &#x60;Active&#x60;, &#x60;Inactive&#x60;, &#x60;Suspended&#x60;, &#x60;Closed&#x60;.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Account {\n");
            sb.Append("  AccountCode: ").Append(AccountCode).Append("\n");
            sb.Append("  BankAccountUUID: ").Append(BankAccountUUID).Append("\n");
            sb.Append("  BeneficiaryAccount: ").Append(BeneficiaryAccount).Append("\n");
            sb.Append("  BeneficiaryMerchantReference: ").Append(BeneficiaryMerchantReference).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  PayoutMethodCode: ").Append(PayoutMethodCode).Append("\n");
            sb.Append("  PayoutSchedule: ").Append(PayoutSchedule).Append("\n");
            sb.Append("  PayoutSpeed: ").Append(PayoutSpeed).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as Account);
        }

        /// <summary>
        /// Returns true if Account instances are equal
        /// </summary>
        /// <param name="input">Instance of Account to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Account input)
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
                    this.BankAccountUUID == input.BankAccountUUID ||
                    (this.BankAccountUUID != null &&
                    this.BankAccountUUID.Equals(input.BankAccountUUID))
                ) && 
                (
                    this.BeneficiaryAccount == input.BeneficiaryAccount ||
                    (this.BeneficiaryAccount != null &&
                    this.BeneficiaryAccount.Equals(input.BeneficiaryAccount))
                ) && 
                (
                    this.BeneficiaryMerchantReference == input.BeneficiaryMerchantReference ||
                    (this.BeneficiaryMerchantReference != null &&
                    this.BeneficiaryMerchantReference.Equals(input.BeneficiaryMerchantReference))
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
                    this.PayoutSpeed.Equals(input.PayoutSpeed)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.BankAccountUUID != null)
                {
                    hashCode = (hashCode * 59) + this.BankAccountUUID.GetHashCode();
                }
                if (this.BeneficiaryAccount != null)
                {
                    hashCode = (hashCode * 59) + this.BeneficiaryAccount.GetHashCode();
                }
                if (this.BeneficiaryMerchantReference != null)
                {
                    hashCode = (hashCode * 59) + this.BeneficiaryMerchantReference.GetHashCode();
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
                if (this.PayoutSchedule != null)
                {
                    hashCode = (hashCode * 59) + this.PayoutSchedule.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PayoutSpeed.GetHashCode();
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
