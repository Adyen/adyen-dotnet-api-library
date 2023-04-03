using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// Account
    /// </summary>
    [DataContract]
    public class Account : IEquatable<Account>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        /// <param name="accountCode">The code of the account..</param>
        /// <param name="bankAccountUUID">The bankAccountUUID of the bank account held by the account holder to couple the account with.</param>
        /// <param name="beneficiaryAccount">The beneficiary of the account..</param>
        /// <param name="beneficiaryMerchantReference">The reason that a beneficiary has been set up for this account. This may have been supplied during the setup of a beneficiary at the discretion of the executing user..</param>
        /// <param name="description">A description of the account..</param>
        /// <param name="metadata">A set of key and value pairs for general use by the merchant. The keys do not have specific names and may be used for storing miscellaneous data as desired. &gt; Note that during an update of metadata, the omission of existing key-value pairs will result in the deletion of those key-value pairs..</param>
        /// <param name="payoutMethodCode">The payout method code held by the account holder to couple the account with. Scheduled card payouts will be sent using this payout method code.</param>
        /// <param name="payoutSchedule">payoutSchedule.</param>
        /// <param name="payoutSpeed">Speed with which payouts for this account are processed. Permitted values: STANDARD, SAME_DAY.</param>
        /// <param name="status">The status of the account. Possible values: &#x60;Active&#x60;, &#x60;Inactive&#x60;, &#x60;Suspended&#x60;, &#x60;Closed&#x60;..</param>
        public Account(string accountCode = default(string), string bankAccountUUID = default(string), string beneficiaryAccount = default(string), string beneficiaryMerchantReference = default(string), string description = default(string), Object metadata = default(Object), string payoutMethodCode = default(string), PayoutScheduleResponse payoutSchedule = default(PayoutScheduleResponse), string payoutSpeed = default(string), string status = default(string))
        {
            AccountCode = accountCode;
            BankAccountUUID = bankAccountUUID;
            BeneficiaryAccount = beneficiaryAccount;
            BeneficiaryMerchantReference = beneficiaryMerchantReference;
            Description = description;
            Metadata = metadata;
            PayoutMethodCode = payoutMethodCode;
            PayoutSchedule = payoutSchedule;
            PayoutSpeed = payoutSpeed;
            Status = status;
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
        public Object Metadata { get; set; }

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
        /// Speed with which payouts for this account are processed. Permitted values: STANDARD, SAME_DAY.
        /// </summary>
        /// <value>Speed with which payouts for this account are processed. Permitted values: STANDARD, SAME_DAY.</value>
        [DataMember(Name = "payoutSpeed", EmitDefaultValue = false)]
        public string PayoutSpeed { get; set; }

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
            var sb = new StringBuilder();
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as Account);
        }

        /// <summary>
        /// Returns true if Account instances are equal
        /// </summary>
        /// <param name="input">Instance of Account to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Account input)
        {
            if (input == null)
                return false;

            return
                (
                    AccountCode == input.AccountCode ||
                    (AccountCode != null &&
                    AccountCode.Equals(input.AccountCode))
                ) &&
                (
                    BankAccountUUID == input.BankAccountUUID ||
                    (BankAccountUUID != null &&
                     BankAccountUUID.Equals(input.BankAccountUUID))
                ) &&
                (
                    BeneficiaryAccount == input.BeneficiaryAccount ||
                    (BeneficiaryAccount != null &&
                    BeneficiaryAccount.Equals(input.BeneficiaryAccount))
                ) &&
                (
                    BeneficiaryMerchantReference == input.BeneficiaryMerchantReference ||
                    (BeneficiaryMerchantReference != null &&
                    BeneficiaryMerchantReference.Equals(input.BeneficiaryMerchantReference))
                ) &&
                (
                    Description == input.Description ||
                    (Description != null &&
                    Description.Equals(input.Description))
                ) &&
                (
                    Metadata == input.Metadata ||
                    (Metadata != null &&
                    Metadata.Equals(input.Metadata))
                ) &&
                (
                    PayoutMethodCode == input.PayoutMethodCode ||
                    (PayoutMethodCode != null &&
                     PayoutMethodCode.Equals(input.PayoutMethodCode))
                ) &&
                (
                    PayoutSchedule == input.PayoutSchedule ||
                    (PayoutSchedule != null)
                ) &&
                (
                    PayoutSpeed == input.PayoutSpeed ||
                    (PayoutSpeed != null &&
                     PayoutSpeed.Equals(input.PayoutSpeed))
                ) &&
                (
                    Status == input.Status ||
                    (Status != null &&
                    Status.Equals(input.Status))
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
                if (AccountCode != null)
                    hashCode = hashCode * 59 + AccountCode.GetHashCode();
                if (BankAccountUUID != null)
                    hashCode = hashCode * 59 + BankAccountUUID.GetHashCode();
                if (BeneficiaryAccount != null)
                    hashCode = hashCode * 59 + BeneficiaryAccount.GetHashCode();
                if (BeneficiaryMerchantReference != null)
                    hashCode = hashCode * 59 + BeneficiaryMerchantReference.GetHashCode();
                if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                if (Metadata != null)
                    hashCode = hashCode * 59 + Metadata.GetHashCode();
                if (PayoutMethodCode != null)
                    hashCode = hashCode * 59 + PayoutMethodCode.GetHashCode();
                if (PayoutSchedule != null)
                    hashCode = hashCode * 59 + PayoutSchedule.GetHashCode();
                if (PayoutSpeed != null)
                    hashCode = hashCode * 59 + PayoutSpeed.GetHashCode();
                if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
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
