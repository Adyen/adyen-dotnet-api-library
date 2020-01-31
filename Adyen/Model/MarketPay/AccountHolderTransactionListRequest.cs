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
    /// AccountHolderTransactionListRequest
    /// </summary>
    [DataContract]
    public class AccountHolderTransactionListRequest : IEquatable<AccountHolderTransactionListRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines TransactionStatuses
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransactionStatusesEnum
        {
            /// <summary>
            /// Enum Chargeback for value: Chargeback
            /// </summary>
            [EnumMember(Value = "Chargeback")]
            Chargeback = 1,
            /// <summary>
            /// Enum ChargebackCorrection for value: ChargebackCorrection
            /// </summary>
            [EnumMember(Value = "ChargebackCorrection")]
            ChargebackCorrection = 2,
            /// <summary>
            /// Enum ChargebackCorrectionReceived for value: ChargebackCorrectionReceived
            /// </summary>
            [EnumMember(Value = "ChargebackCorrectionReceived")]
            ChargebackCorrectionReceived = 3,
            /// <summary>
            /// Enum ChargebackReceived for value: ChargebackReceived
            /// </summary>
            [EnumMember(Value = "ChargebackReceived")]
            ChargebackReceived = 4,
            /// <summary>
            /// Enum ChargebackReversed for value: ChargebackReversed
            /// </summary>
            [EnumMember(Value = "ChargebackReversed")]
            ChargebackReversed = 5,
            /// <summary>
            /// Enum ChargebackReversedReceived for value: ChargebackReversedReceived
            /// </summary>
            [EnumMember(Value = "ChargebackReversedReceived")]
            ChargebackReversedReceived = 6,
            /// <summary>
            /// Enum Converted for value: Converted
            /// </summary>
            [EnumMember(Value = "Converted")]
            Converted = 7,
            /// <summary>
            /// Enum CreditFailed for value: CreditFailed
            /// </summary>
            [EnumMember(Value = "CreditFailed")]
            CreditFailed = 8,
            /// <summary>
            /// Enum CreditReversed for value: CreditReversed
            /// </summary>
            [EnumMember(Value = "CreditReversed")]
            CreditReversed = 9,
            /// <summary>
            /// Enum CreditReversedReceived for value: CreditReversedReceived
            /// </summary>
            [EnumMember(Value = "CreditReversedReceived")]
            CreditReversedReceived = 10,
            /// <summary>
            /// Enum Credited for value: Credited
            /// </summary>
            [EnumMember(Value = "Credited")]
            Credited = 11,
            /// <summary>
            /// Enum DebitFailed for value: DebitFailed
            /// </summary>
            [EnumMember(Value = "DebitFailed")]
            DebitFailed = 12,
            /// <summary>
            /// Enum DebitReversedReceived for value: DebitReversedReceived
            /// </summary>
            [EnumMember(Value = "DebitReversedReceived")]
            DebitReversedReceived = 13,
            /// <summary>
            /// Enum Debited for value: Debited
            /// </summary>
            [EnumMember(Value = "Debited")]
            Debited = 14,
            /// <summary>
            /// Enum DebitedReversed for value: DebitedReversed
            /// </summary>
            [EnumMember(Value = "DebitedReversed")]
            DebitedReversed = 15,
            /// <summary>
            /// Enum FundTransfer for value: FundTransfer
            /// </summary>
            [EnumMember(Value = "FundTransfer")]
            FundTransfer = 16,
            /// <summary>
            /// Enum FundTransferReversed for value: FundTransferReversed
            /// </summary>
            [EnumMember(Value = "FundTransferReversed")]
            FundTransferReversed = 17,
            /// <summary>
            /// Enum ManualCorrected for value: ManualCorrected
            /// </summary>
            [EnumMember(Value = "ManualCorrected")]
            ManualCorrected = 18,
            /// <summary>
            /// Enum Payout for value: Payout
            /// </summary>
            [EnumMember(Value = "Payout")]
            Payout = 19,
            /// <summary>
            /// Enum PayoutReversed for value: PayoutReversed
            /// </summary>
            [EnumMember(Value = "PayoutReversed")]
            PayoutReversed = 20,
            /// <summary>
            /// Enum PendingCredit for value: PendingCredit
            /// </summary>
            [EnumMember(Value = "PendingCredit")]
            PendingCredit = 21,
            /// <summary>
            /// Enum PendingDebit for value: PendingDebit
            /// </summary>
            [EnumMember(Value = "PendingDebit")]
            PendingDebit = 22,
            /// <summary>
            /// Enum PendingFundTransfer for value: PendingFundTransfer
            /// </summary>
            [EnumMember(Value = "PendingFundTransfer")]
            PendingFundTransfer = 23,
            /// <summary>
            /// Enum SecondChargeback for value: SecondChargeback
            /// </summary>
            [EnumMember(Value = "SecondChargeback")]
            SecondChargeback = 24,
            /// <summary>
            /// Enum SecondChargebackReceived for value: SecondChargebackReceived
            /// </summary>
            [EnumMember(Value = "SecondChargebackReceived")]
            SecondChargebackReceived = 25
        }
        /// <summary>
        /// A list of statuses to include in the transaction list. If left blank, all transactions will be included. &gt;Permitted values: &gt;* &#x60;PendingCredit&#x60; - a pending balance credit. &gt;* &#x60;CreditFailed&#x60; - a pending credit failure; the balance will not be credited. &gt;* &#x60;Credited&#x60; - a credited balance. &gt;* &#x60;PendingDebit&#x60; - a pending balance debit (e.g., a refund). &gt;* &#x60;DebitFailed&#x60; - a pending debit failure; the balance will not be debited. &gt;* &#x60;Debited&#x60; - a debited balance (e.g., a refund). &gt;* &#x60;DebitReversedReceived&#x60; - a pending refund reversal. &gt;* &#x60;DebitedReversed&#x60; - a reversed refund. &gt;* &#x60;ChargebackReceived&#x60; - a received chargeback request. &gt;* &#x60;Chargeback&#x60; - a processed chargeback. &gt;* &#x60;ChargebackReversedReceived&#x60; - a pending chargeback reversal. &gt;* &#x60;ChargebackReversed&#x60; - a reversed chargeback. &gt;* &#x60;Converted&#x60; - converted. &gt;* &#x60;ManualCorrected&#x60; - manual booking/adjustment by Adyen. &gt;* &#x60;Payout&#x60; - a payout. &gt;* &#x60;PayoutReversed&#x60; - a reversed payout. &gt;* &#x60;PendingFundTransfer&#x60; - a pending transfer of funds from one account to another. &gt;* &#x60;FundTransfer&#x60; - a transfer of funds from one account to another.
        /// </summary>
        /// <value>A list of statuses to include in the transaction list. If left blank, all transactions will be included. &gt;Permitted values: &gt;* &#x60;PendingCredit&#x60; - a pending balance credit. &gt;* &#x60;CreditFailed&#x60; - a pending credit failure; the balance will not be credited. &gt;* &#x60;Credited&#x60; - a credited balance. &gt;* &#x60;PendingDebit&#x60; - a pending balance debit (e.g., a refund). &gt;* &#x60;DebitFailed&#x60; - a pending debit failure; the balance will not be debited. &gt;* &#x60;Debited&#x60; - a debited balance (e.g., a refund). &gt;* &#x60;DebitReversedReceived&#x60; - a pending refund reversal. &gt;* &#x60;DebitedReversed&#x60; - a reversed refund. &gt;* &#x60;ChargebackReceived&#x60; - a received chargeback request. &gt;* &#x60;Chargeback&#x60; - a processed chargeback. &gt;* &#x60;ChargebackReversedReceived&#x60; - a pending chargeback reversal. &gt;* &#x60;ChargebackReversed&#x60; - a reversed chargeback. &gt;* &#x60;Converted&#x60; - converted. &gt;* &#x60;ManualCorrected&#x60; - manual booking/adjustment by Adyen. &gt;* &#x60;Payout&#x60; - a payout. &gt;* &#x60;PayoutReversed&#x60; - a reversed payout. &gt;* &#x60;PendingFundTransfer&#x60; - a pending transfer of funds from one account to another. &gt;* &#x60;FundTransfer&#x60; - a transfer of funds from one account to another.</value>
        [DataMember(Name = "transactionStatuses", EmitDefaultValue = false)]
        public List<TransactionStatusesEnum> TransactionStatuses { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountHolderTransactionListRequest" /> class.
        /// </summary>
        /// <param name="accountHolderCode">The code of the account holder that owns the account(s) of which retrieve the transaction list. (required).</param>
        /// <param name="transactionListsPerAccount">A list of accounts to include in the transaction list. If left blank, the last fifty (50) transactions for all accounts of the account holder will be included..</param>
        /// <param name="transactionStatuses">A list of statuses to include in the transaction list. If left blank, all transactions will be included. &gt;Permitted values: &gt;* &#x60;PendingCredit&#x60; - a pending balance credit. &gt;* &#x60;CreditFailed&#x60; - a pending credit failure; the balance will not be credited. &gt;* &#x60;Credited&#x60; - a credited balance. &gt;* &#x60;PendingDebit&#x60; - a pending balance debit (e.g., a refund). &gt;* &#x60;DebitFailed&#x60; - a pending debit failure; the balance will not be debited. &gt;* &#x60;Debited&#x60; - a debited balance (e.g., a refund). &gt;* &#x60;DebitReversedReceived&#x60; - a pending refund reversal. &gt;* &#x60;DebitedReversed&#x60; - a reversed refund. &gt;* &#x60;ChargebackReceived&#x60; - a received chargeback request. &gt;* &#x60;Chargeback&#x60; - a processed chargeback. &gt;* &#x60;ChargebackReversedReceived&#x60; - a pending chargeback reversal. &gt;* &#x60;ChargebackReversed&#x60; - a reversed chargeback. &gt;* &#x60;Converted&#x60; - converted. &gt;* &#x60;ManualCorrected&#x60; - manual booking/adjustment by Adyen. &gt;* &#x60;Payout&#x60; - a payout. &gt;* &#x60;PayoutReversed&#x60; - a reversed payout. &gt;* &#x60;PendingFundTransfer&#x60; - a pending transfer of funds from one account to another. &gt;* &#x60;FundTransfer&#x60; - a transfer of funds from one account to another..</param>
        public AccountHolderTransactionListRequest(string accountHolderCode = default(string), List<TransactionListForAccount> transactionListsPerAccount = default(List<TransactionListForAccount>), List<TransactionStatusesEnum> transactionStatuses = default(List<TransactionStatusesEnum>))
        {
            // to ensure "accountHolderCode" is required (not null)
            if (accountHolderCode == null)
            {
                throw new InvalidDataException("accountHolderCode is a required property for AccountHolderTransactionListRequest and cannot be null");
            }
            else
            {
                this.AccountHolderCode = accountHolderCode;
            }
            this.TransactionListsPerAccount = transactionListsPerAccount;
            this.TransactionStatuses = transactionStatuses;
        }

        /// <summary>
        /// The code of the account holder that owns the account(s) of which retrieve the transaction list.
        /// </summary>
        /// <value>The code of the account holder that owns the account(s) of which retrieve the transaction list.</value>
        [DataMember(Name = "accountHolderCode", EmitDefaultValue = false)]
        public string AccountHolderCode { get; set; }

        /// <summary>
        /// A list of accounts to include in the transaction list. If left blank, the last fifty (50) transactions for all accounts of the account holder will be included.
        /// </summary>
        /// <value>A list of accounts to include in the transaction list. If left blank, the last fifty (50) transactions for all accounts of the account holder will be included.</value>
        [DataMember(Name = "transactionListsPerAccount", EmitDefaultValue = false)]
        public List<TransactionListForAccount> TransactionListsPerAccount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountHolderTransactionListRequest {\n");
            sb.Append("  AccountHolderCode: ").Append(AccountHolderCode).Append("\n");
            sb.Append("  TransactionListsPerAccount: ").Append(TransactionListsPerAccount).Append("\n");
            sb.Append("  TransactionStatuses: ").Append(TransactionStatuses).Append("\n");
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
            return this.Equals(input as AccountHolderTransactionListRequest);
        }

        /// <summary>
        /// Returns true if AccountHolderTransactionListRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountHolderTransactionListRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountHolderTransactionListRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AccountHolderCode == input.AccountHolderCode ||
                    (this.AccountHolderCode != null &&
                    this.AccountHolderCode.Equals(input.AccountHolderCode))
                ) &&
                (
                    this.TransactionListsPerAccount == input.TransactionListsPerAccount ||
                    this.TransactionListsPerAccount != null &&
                    input.TransactionListsPerAccount != null &&
                    this.TransactionListsPerAccount.SequenceEqual(input.TransactionListsPerAccount)
                ) &&
                (
                    this.TransactionStatuses == input.TransactionStatuses ||
                    this.TransactionStatuses != null &&
                    input.TransactionStatuses != null &&
                    this.TransactionStatuses.SequenceEqual(input.TransactionStatuses)
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
                    hashCode = hashCode * 59 + this.AccountHolderCode.GetHashCode();
                if (this.TransactionListsPerAccount != null)
                    hashCode = hashCode * 59 + this.TransactionListsPerAccount.GetHashCode();
                if (this.TransactionStatuses != null)
                    hashCode = hashCode * 59 + this.TransactionStatuses.GetHashCode();
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
