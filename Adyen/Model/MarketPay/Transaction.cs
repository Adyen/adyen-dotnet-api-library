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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// Transaction
    /// </summary>
    [DataContract]
    public class Transaction : IEquatable<Transaction>, IValidatableObject
    {
        /// <summary>
        /// The status of the transaction. &gt;Permitted values: &#x60;PendingCredit&#x60;, &#x60;CreditFailed&#x60;, &#x60;Credited&#x60;, &#x60;Converted&#x60;, &#x60;PendingDebit&#x60;, &#x60;DebitFailed&#x60;, &#x60;Debited&#x60;, &#x60;DebitReversedReceived&#x60;, &#x60;DebitedReversed&#x60;, &#x60;ChargebackReceived&#x60;, &#x60;Chargeback&#x60;, &#x60;ChargebackReversedReceived&#x60;, &#x60;ChargebackReversed&#x60;, &#x60;Payout&#x60;, &#x60;PayoutReversed&#x60;, &#x60;FundTransfer&#x60;, &#x60;PendingFundTransfer&#x60;, &#x60;ManualCorrected&#x60;.
        /// </summary>
        /// <value>The status of the transaction. &gt;Permitted values: &#x60;PendingCredit&#x60;, &#x60;CreditFailed&#x60;, &#x60;Credited&#x60;, &#x60;Converted&#x60;, &#x60;PendingDebit&#x60;, &#x60;DebitFailed&#x60;, &#x60;Debited&#x60;, &#x60;DebitReversedReceived&#x60;, &#x60;DebitedReversed&#x60;, &#x60;ChargebackReceived&#x60;, &#x60;Chargeback&#x60;, &#x60;ChargebackReversedReceived&#x60;, &#x60;ChargebackReversed&#x60;, &#x60;Payout&#x60;, &#x60;PayoutReversed&#x60;, &#x60;FundTransfer&#x60;, &#x60;PendingFundTransfer&#x60;, &#x60;ManualCorrected&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransactionStatusEnum
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
        /// The status of the transaction. &gt;Permitted values: &#x60;PendingCredit&#x60;, &#x60;CreditFailed&#x60;, &#x60;Credited&#x60;, &#x60;Converted&#x60;, &#x60;PendingDebit&#x60;, &#x60;DebitFailed&#x60;, &#x60;Debited&#x60;, &#x60;DebitReversedReceived&#x60;, &#x60;DebitedReversed&#x60;, &#x60;ChargebackReceived&#x60;, &#x60;Chargeback&#x60;, &#x60;ChargebackReversedReceived&#x60;, &#x60;ChargebackReversed&#x60;, &#x60;Payout&#x60;, &#x60;PayoutReversed&#x60;, &#x60;FundTransfer&#x60;, &#x60;PendingFundTransfer&#x60;, &#x60;ManualCorrected&#x60;.
        /// </summary>
        /// <value>The status of the transaction. &gt;Permitted values: &#x60;PendingCredit&#x60;, &#x60;CreditFailed&#x60;, &#x60;Credited&#x60;, &#x60;Converted&#x60;, &#x60;PendingDebit&#x60;, &#x60;DebitFailed&#x60;, &#x60;Debited&#x60;, &#x60;DebitReversedReceived&#x60;, &#x60;DebitedReversed&#x60;, &#x60;ChargebackReceived&#x60;, &#x60;Chargeback&#x60;, &#x60;ChargebackReversedReceived&#x60;, &#x60;ChargebackReversed&#x60;, &#x60;Payout&#x60;, &#x60;PayoutReversed&#x60;, &#x60;FundTransfer&#x60;, &#x60;PendingFundTransfer&#x60;, &#x60;ManualCorrected&#x60;.</value>
        [DataMember(Name = "transactionStatus", EmitDefaultValue = false)]
        public TransactionStatusEnum? TransactionStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Transaction" /> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="bankAccountDetail">bankAccountDetail.</param>
        /// <param name="captureMerchantReference">The merchant reference of a related capture..</param>
        /// <param name="capturePspReference">The psp reference of a related capture..</param>
        /// <param name="creationDate">The date on which the transaction was performed..</param>
        /// <param name="description">A description of the transaction..</param>
        /// <param name="destinationAccountCode">The code of the account to which funds were credited during an outgoing fund transfer..</param>
        /// <param name="disputePspReference">The psp reference of the related dispute..</param>
        /// <param name="disputeReasonCode">The reason code of a dispute..</param>
        /// <param name="merchantReference">The merchant reference of a transaction..</param>
        /// <param name="paymentPspReference">The psp reference of the related authorisation or transfer..</param>
        /// <param name="payoutPspReference">The psp reference of the related payout..</param>
        /// <param name="pspReference">The psp reference of a transaction..</param>
        /// <param name="sourceAccountCode">The code of the account from which funds were debited during an incoming fund transfer..</param>
        /// <param name="transactionStatus">The status of the transaction. &gt;Permitted values: &#x60;PendingCredit&#x60;, &#x60;CreditFailed&#x60;, &#x60;Credited&#x60;, &#x60;Converted&#x60;, &#x60;PendingDebit&#x60;, &#x60;DebitFailed&#x60;, &#x60;Debited&#x60;, &#x60;DebitReversedReceived&#x60;, &#x60;DebitedReversed&#x60;, &#x60;ChargebackReceived&#x60;, &#x60;Chargeback&#x60;, &#x60;ChargebackReversedReceived&#x60;, &#x60;ChargebackReversed&#x60;, &#x60;Payout&#x60;, &#x60;PayoutReversed&#x60;, &#x60;FundTransfer&#x60;, &#x60;PendingFundTransfer&#x60;, &#x60;ManualCorrected&#x60;..</param>
        /// <param name="transferCode">The transfer code of the transaction..</param>
        public Transaction(Amount amount = default(Amount), BankAccountDetail bankAccountDetail = default(BankAccountDetail), string captureMerchantReference = default(string), string capturePspReference = default(string), DateTime? creationDate = default(DateTime?), string description = default(string), string destinationAccountCode = default(string), string disputePspReference = default(string), string disputeReasonCode = default(string), string merchantReference = default(string), string paymentPspReference = default(string), string payoutPspReference = default(string), string pspReference = default(string), string sourceAccountCode = default(string), TransactionStatusEnum? transactionStatus = default(TransactionStatusEnum?), string transferCode = default(string))
        {
            this.Amount = amount;
            this.BankAccountDetail = bankAccountDetail;
            this.CaptureMerchantReference = captureMerchantReference;
            this.CapturePspReference = capturePspReference;
            this.CreationDate = creationDate;
            this.Description = description;
            this.DestinationAccountCode = destinationAccountCode;
            this.DisputePspReference = disputePspReference;
            this.DisputeReasonCode = disputeReasonCode;
            this.MerchantReference = merchantReference;
            this.PaymentPspReference = paymentPspReference;
            this.PayoutPspReference = payoutPspReference;
            this.PspReference = pspReference;
            this.SourceAccountCode = sourceAccountCode;
            this.TransactionStatus = transactionStatus;
            this.TransferCode = transferCode;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Amount Amount { get; set; }

        /// <summary>
        /// Gets or Sets BankAccountDetail
        /// </summary>
        [DataMember(Name = "bankAccountDetail", EmitDefaultValue = false)]
        public BankAccountDetail BankAccountDetail { get; set; }

        /// <summary>
        /// The merchant reference of a related capture.
        /// </summary>
        /// <value>The merchant reference of a related capture.</value>
        [DataMember(Name = "captureMerchantReference", EmitDefaultValue = false)]
        public string CaptureMerchantReference { get; set; }

        /// <summary>
        /// The psp reference of a related capture.
        /// </summary>
        /// <value>The psp reference of a related capture.</value>
        [DataMember(Name = "capturePspReference", EmitDefaultValue = false)]
        public string CapturePspReference { get; set; }

        /// <summary>
        /// The date on which the transaction was performed.
        /// </summary>
        /// <value>The date on which the transaction was performed.</value>
        [DataMember(Name = "creationDate", EmitDefaultValue = false)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// A description of the transaction.
        /// </summary>
        /// <value>A description of the transaction.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The code of the account to which funds were credited during an outgoing fund transfer.
        /// </summary>
        /// <value>The code of the account to which funds were credited during an outgoing fund transfer.</value>
        [DataMember(Name = "destinationAccountCode", EmitDefaultValue = false)]
        public string DestinationAccountCode { get; set; }

        /// <summary>
        /// The psp reference of the related dispute.
        /// </summary>
        /// <value>The psp reference of the related dispute.</value>
        [DataMember(Name = "disputePspReference", EmitDefaultValue = false)]
        public string DisputePspReference { get; set; }

        /// <summary>
        /// The reason code of a dispute.
        /// </summary>
        /// <value>The reason code of a dispute.</value>
        [DataMember(Name = "disputeReasonCode", EmitDefaultValue = false)]
        public string DisputeReasonCode { get; set; }

        /// <summary>
        /// The merchant reference of a transaction.
        /// </summary>
        /// <value>The merchant reference of a transaction.</value>
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        public string MerchantReference { get; set; }

        /// <summary>
        /// The psp reference of the related authorisation or transfer.
        /// </summary>
        /// <value>The psp reference of the related authorisation or transfer.</value>
        [DataMember(Name = "paymentPspReference", EmitDefaultValue = false)]
        public string PaymentPspReference { get; set; }

        /// <summary>
        /// The psp reference of the related payout.
        /// </summary>
        /// <value>The psp reference of the related payout.</value>
        [DataMember(Name = "payoutPspReference", EmitDefaultValue = false)]
        public string PayoutPspReference { get; set; }

        /// <summary>
        /// The psp reference of a transaction.
        /// </summary>
        /// <value>The psp reference of a transaction.</value>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        public string PspReference { get; set; }

        /// <summary>
        /// The code of the account from which funds were debited during an incoming fund transfer.
        /// </summary>
        /// <value>The code of the account from which funds were debited during an incoming fund transfer.</value>
        [DataMember(Name = "sourceAccountCode", EmitDefaultValue = false)]
        public string SourceAccountCode { get; set; }


        /// <summary>
        /// The transfer code of the transaction.
        /// </summary>
        /// <value>The transfer code of the transaction.</value>
        [DataMember(Name = "transferCode", EmitDefaultValue = false)]
        public string TransferCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Transaction {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BankAccountDetail: ").Append(BankAccountDetail).Append("\n");
            sb.Append("  CaptureMerchantReference: ").Append(CaptureMerchantReference).Append("\n");
            sb.Append("  CapturePspReference: ").Append(CapturePspReference).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DestinationAccountCode: ").Append(DestinationAccountCode).Append("\n");
            sb.Append("  DisputePspReference: ").Append(DisputePspReference).Append("\n");
            sb.Append("  DisputeReasonCode: ").Append(DisputeReasonCode).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  PaymentPspReference: ").Append(PaymentPspReference).Append("\n");
            sb.Append("  PayoutPspReference: ").Append(PayoutPspReference).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  SourceAccountCode: ").Append(SourceAccountCode).Append("\n");
            sb.Append("  TransactionStatus: ").Append(TransactionStatus).Append("\n");
            sb.Append("  TransferCode: ").Append(TransferCode).Append("\n");
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
            return this.Equals(input as Transaction);
        }

        /// <summary>
        /// Returns true if Transaction instances are equal
        /// </summary>
        /// <param name="input">Instance of Transaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Transaction input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) &&
                (
                    this.BankAccountDetail == input.BankAccountDetail ||
                    (this.BankAccountDetail != null &&
                    this.BankAccountDetail.Equals(input.BankAccountDetail))
                ) &&
                (
                    this.CaptureMerchantReference == input.CaptureMerchantReference ||
                    (this.CaptureMerchantReference != null &&
                    this.CaptureMerchantReference.Equals(input.CaptureMerchantReference))
                ) &&
                (
                    this.CapturePspReference == input.CapturePspReference ||
                    (this.CapturePspReference != null &&
                    this.CapturePspReference.Equals(input.CapturePspReference))
                ) &&
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) &&
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) &&
                (
                    this.DestinationAccountCode == input.DestinationAccountCode ||
                    (this.DestinationAccountCode != null &&
                    this.DestinationAccountCode.Equals(input.DestinationAccountCode))
                ) &&
                (
                    this.DisputePspReference == input.DisputePspReference ||
                    (this.DisputePspReference != null &&
                    this.DisputePspReference.Equals(input.DisputePspReference))
                ) &&
                (
                    this.DisputeReasonCode == input.DisputeReasonCode ||
                    (this.DisputeReasonCode != null &&
                    this.DisputeReasonCode.Equals(input.DisputeReasonCode))
                ) &&
                (
                    this.MerchantReference == input.MerchantReference ||
                    (this.MerchantReference != null &&
                    this.MerchantReference.Equals(input.MerchantReference))
                ) &&
                (
                    this.PaymentPspReference == input.PaymentPspReference ||
                    (this.PaymentPspReference != null &&
                    this.PaymentPspReference.Equals(input.PaymentPspReference))
                ) &&
                (
                    this.PayoutPspReference == input.PayoutPspReference ||
                    (this.PayoutPspReference != null &&
                    this.PayoutPspReference.Equals(input.PayoutPspReference))
                ) &&
                (
                    this.PspReference == input.PspReference ||
                    (this.PspReference != null &&
                    this.PspReference.Equals(input.PspReference))
                ) &&
                (
                    this.SourceAccountCode == input.SourceAccountCode ||
                    (this.SourceAccountCode != null &&
                    this.SourceAccountCode.Equals(input.SourceAccountCode))
                ) &&
                (
                    this.TransactionStatus == input.TransactionStatus ||
                    (this.TransactionStatus != null &&
                    this.TransactionStatus.Equals(input.TransactionStatus))
                ) &&
                (
                    this.TransferCode == input.TransferCode ||
                    (this.TransferCode != null &&
                    this.TransferCode.Equals(input.TransferCode))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.BankAccountDetail != null)
                    hashCode = hashCode * 59 + this.BankAccountDetail.GetHashCode();
                if (this.CaptureMerchantReference != null)
                    hashCode = hashCode * 59 + this.CaptureMerchantReference.GetHashCode();
                if (this.CapturePspReference != null)
                    hashCode = hashCode * 59 + this.CapturePspReference.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DestinationAccountCode != null)
                    hashCode = hashCode * 59 + this.DestinationAccountCode.GetHashCode();
                if (this.DisputePspReference != null)
                    hashCode = hashCode * 59 + this.DisputePspReference.GetHashCode();
                if (this.DisputeReasonCode != null)
                    hashCode = hashCode * 59 + this.DisputeReasonCode.GetHashCode();
                if (this.MerchantReference != null)
                    hashCode = hashCode * 59 + this.MerchantReference.GetHashCode();
                if (this.PaymentPspReference != null)
                    hashCode = hashCode * 59 + this.PaymentPspReference.GetHashCode();
                if (this.PayoutPspReference != null)
                    hashCode = hashCode * 59 + this.PayoutPspReference.GetHashCode();
                if (this.PspReference != null)
                    hashCode = hashCode * 59 + this.PspReference.GetHashCode();
                if (this.SourceAccountCode != null)
                    hashCode = hashCode * 59 + this.SourceAccountCode.GetHashCode();
                if (this.TransactionStatus != null)
                    hashCode = hashCode * 59 + this.TransactionStatus.GetHashCode();
                if (this.TransferCode != null)
                    hashCode = hashCode * 59 + this.TransferCode.GetHashCode();
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
