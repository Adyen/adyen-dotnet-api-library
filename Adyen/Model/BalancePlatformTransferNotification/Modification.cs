/*
* Transfer webhooks
*
*
* The version of the OpenAPI document: 4
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

namespace Adyen.Model.BalancePlatformTransferNotification
{
    /// <summary>
    /// Modification
    /// </summary>
    [DataContract(Name = "Modification")]
    public partial class Modification : IEquatable<Modification>, IValidatableObject
    {
        /// <summary>
        /// The status of the transfer event.
        /// </summary>
        /// <value>The status of the transfer event.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum ApprovalPending for value: approvalPending
            /// </summary>
            [EnumMember(Value = "approvalPending")]
            ApprovalPending = 1,

            /// <summary>
            /// Enum AtmWithdrawal for value: atmWithdrawal
            /// </summary>
            [EnumMember(Value = "atmWithdrawal")]
            AtmWithdrawal = 2,

            /// <summary>
            /// Enum AtmWithdrawalReversalPending for value: atmWithdrawalReversalPending
            /// </summary>
            [EnumMember(Value = "atmWithdrawalReversalPending")]
            AtmWithdrawalReversalPending = 3,

            /// <summary>
            /// Enum AtmWithdrawalReversed for value: atmWithdrawalReversed
            /// </summary>
            [EnumMember(Value = "atmWithdrawalReversed")]
            AtmWithdrawalReversed = 4,

            /// <summary>
            /// Enum AuthAdjustmentAuthorised for value: authAdjustmentAuthorised
            /// </summary>
            [EnumMember(Value = "authAdjustmentAuthorised")]
            AuthAdjustmentAuthorised = 5,

            /// <summary>
            /// Enum AuthAdjustmentError for value: authAdjustmentError
            /// </summary>
            [EnumMember(Value = "authAdjustmentError")]
            AuthAdjustmentError = 6,

            /// <summary>
            /// Enum AuthAdjustmentRefused for value: authAdjustmentRefused
            /// </summary>
            [EnumMember(Value = "authAdjustmentRefused")]
            AuthAdjustmentRefused = 7,

            /// <summary>
            /// Enum Authorised for value: authorised
            /// </summary>
            [EnumMember(Value = "authorised")]
            Authorised = 8,

            /// <summary>
            /// Enum BankTransfer for value: bankTransfer
            /// </summary>
            [EnumMember(Value = "bankTransfer")]
            BankTransfer = 9,

            /// <summary>
            /// Enum BankTransferPending for value: bankTransferPending
            /// </summary>
            [EnumMember(Value = "bankTransferPending")]
            BankTransferPending = 10,

            /// <summary>
            /// Enum Booked for value: booked
            /// </summary>
            [EnumMember(Value = "booked")]
            Booked = 11,

            /// <summary>
            /// Enum BookingPending for value: bookingPending
            /// </summary>
            [EnumMember(Value = "bookingPending")]
            BookingPending = 12,

            /// <summary>
            /// Enum Cancelled for value: cancelled
            /// </summary>
            [EnumMember(Value = "cancelled")]
            Cancelled = 13,

            /// <summary>
            /// Enum CapturePending for value: capturePending
            /// </summary>
            [EnumMember(Value = "capturePending")]
            CapturePending = 14,

            /// <summary>
            /// Enum CaptureReversalPending for value: captureReversalPending
            /// </summary>
            [EnumMember(Value = "captureReversalPending")]
            CaptureReversalPending = 15,

            /// <summary>
            /// Enum CaptureReversed for value: captureReversed
            /// </summary>
            [EnumMember(Value = "captureReversed")]
            CaptureReversed = 16,

            /// <summary>
            /// Enum Captured for value: captured
            /// </summary>
            [EnumMember(Value = "captured")]
            Captured = 17,

            /// <summary>
            /// Enum CapturedExternally for value: capturedExternally
            /// </summary>
            [EnumMember(Value = "capturedExternally")]
            CapturedExternally = 18,

            /// <summary>
            /// Enum Chargeback for value: chargeback
            /// </summary>
            [EnumMember(Value = "chargeback")]
            Chargeback = 19,

            /// <summary>
            /// Enum ChargebackExternally for value: chargebackExternally
            /// </summary>
            [EnumMember(Value = "chargebackExternally")]
            ChargebackExternally = 20,

            /// <summary>
            /// Enum ChargebackPending for value: chargebackPending
            /// </summary>
            [EnumMember(Value = "chargebackPending")]
            ChargebackPending = 21,

            /// <summary>
            /// Enum ChargebackReversalPending for value: chargebackReversalPending
            /// </summary>
            [EnumMember(Value = "chargebackReversalPending")]
            ChargebackReversalPending = 22,

            /// <summary>
            /// Enum ChargebackReversed for value: chargebackReversed
            /// </summary>
            [EnumMember(Value = "chargebackReversed")]
            ChargebackReversed = 23,

            /// <summary>
            /// Enum Credited for value: credited
            /// </summary>
            [EnumMember(Value = "credited")]
            Credited = 24,

            /// <summary>
            /// Enum DepositCorrection for value: depositCorrection
            /// </summary>
            [EnumMember(Value = "depositCorrection")]
            DepositCorrection = 25,

            /// <summary>
            /// Enum DepositCorrectionPending for value: depositCorrectionPending
            /// </summary>
            [EnumMember(Value = "depositCorrectionPending")]
            DepositCorrectionPending = 26,

            /// <summary>
            /// Enum Dispute for value: dispute
            /// </summary>
            [EnumMember(Value = "dispute")]
            Dispute = 27,

            /// <summary>
            /// Enum DisputeClosed for value: disputeClosed
            /// </summary>
            [EnumMember(Value = "disputeClosed")]
            DisputeClosed = 28,

            /// <summary>
            /// Enum DisputeExpired for value: disputeExpired
            /// </summary>
            [EnumMember(Value = "disputeExpired")]
            DisputeExpired = 29,

            /// <summary>
            /// Enum DisputeNeedsReview for value: disputeNeedsReview
            /// </summary>
            [EnumMember(Value = "disputeNeedsReview")]
            DisputeNeedsReview = 30,

            /// <summary>
            /// Enum Error for value: error
            /// </summary>
            [EnumMember(Value = "error")]
            Error = 31,

            /// <summary>
            /// Enum Expired for value: expired
            /// </summary>
            [EnumMember(Value = "expired")]
            Expired = 32,

            /// <summary>
            /// Enum Failed for value: failed
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed = 33,

            /// <summary>
            /// Enum Fee for value: fee
            /// </summary>
            [EnumMember(Value = "fee")]
            Fee = 34,

            /// <summary>
            /// Enum FeePending for value: feePending
            /// </summary>
            [EnumMember(Value = "feePending")]
            FeePending = 35,

            /// <summary>
            /// Enum InternalTransfer for value: internalTransfer
            /// </summary>
            [EnumMember(Value = "internalTransfer")]
            InternalTransfer = 36,

            /// <summary>
            /// Enum InternalTransferPending for value: internalTransferPending
            /// </summary>
            [EnumMember(Value = "internalTransferPending")]
            InternalTransferPending = 37,

            /// <summary>
            /// Enum InvoiceDeduction for value: invoiceDeduction
            /// </summary>
            [EnumMember(Value = "invoiceDeduction")]
            InvoiceDeduction = 38,

            /// <summary>
            /// Enum InvoiceDeductionPending for value: invoiceDeductionPending
            /// </summary>
            [EnumMember(Value = "invoiceDeductionPending")]
            InvoiceDeductionPending = 39,

            /// <summary>
            /// Enum ManualCorrectionPending for value: manualCorrectionPending
            /// </summary>
            [EnumMember(Value = "manualCorrectionPending")]
            ManualCorrectionPending = 40,

            /// <summary>
            /// Enum ManuallyCorrected for value: manuallyCorrected
            /// </summary>
            [EnumMember(Value = "manuallyCorrected")]
            ManuallyCorrected = 41,

            /// <summary>
            /// Enum MatchedStatement for value: matchedStatement
            /// </summary>
            [EnumMember(Value = "matchedStatement")]
            MatchedStatement = 42,

            /// <summary>
            /// Enum MatchedStatementPending for value: matchedStatementPending
            /// </summary>
            [EnumMember(Value = "matchedStatementPending")]
            MatchedStatementPending = 43,

            /// <summary>
            /// Enum MerchantPayin for value: merchantPayin
            /// </summary>
            [EnumMember(Value = "merchantPayin")]
            MerchantPayin = 44,

            /// <summary>
            /// Enum MerchantPayinPending for value: merchantPayinPending
            /// </summary>
            [EnumMember(Value = "merchantPayinPending")]
            MerchantPayinPending = 45,

            /// <summary>
            /// Enum MerchantPayinReversed for value: merchantPayinReversed
            /// </summary>
            [EnumMember(Value = "merchantPayinReversed")]
            MerchantPayinReversed = 46,

            /// <summary>
            /// Enum MerchantPayinReversedPending for value: merchantPayinReversedPending
            /// </summary>
            [EnumMember(Value = "merchantPayinReversedPending")]
            MerchantPayinReversedPending = 47,

            /// <summary>
            /// Enum MiscCost for value: miscCost
            /// </summary>
            [EnumMember(Value = "miscCost")]
            MiscCost = 48,

            /// <summary>
            /// Enum MiscCostPending for value: miscCostPending
            /// </summary>
            [EnumMember(Value = "miscCostPending")]
            MiscCostPending = 49,

            /// <summary>
            /// Enum PaymentCost for value: paymentCost
            /// </summary>
            [EnumMember(Value = "paymentCost")]
            PaymentCost = 50,

            /// <summary>
            /// Enum PaymentCostPending for value: paymentCostPending
            /// </summary>
            [EnumMember(Value = "paymentCostPending")]
            PaymentCostPending = 51,

            /// <summary>
            /// Enum Received for value: received
            /// </summary>
            [EnumMember(Value = "received")]
            Received = 52,

            /// <summary>
            /// Enum RefundPending for value: refundPending
            /// </summary>
            [EnumMember(Value = "refundPending")]
            RefundPending = 53,

            /// <summary>
            /// Enum RefundReversalPending for value: refundReversalPending
            /// </summary>
            [EnumMember(Value = "refundReversalPending")]
            RefundReversalPending = 54,

            /// <summary>
            /// Enum RefundReversed for value: refundReversed
            /// </summary>
            [EnumMember(Value = "refundReversed")]
            RefundReversed = 55,

            /// <summary>
            /// Enum Refunded for value: refunded
            /// </summary>
            [EnumMember(Value = "refunded")]
            Refunded = 56,

            /// <summary>
            /// Enum RefundedExternally for value: refundedExternally
            /// </summary>
            [EnumMember(Value = "refundedExternally")]
            RefundedExternally = 57,

            /// <summary>
            /// Enum Refused for value: refused
            /// </summary>
            [EnumMember(Value = "refused")]
            Refused = 58,

            /// <summary>
            /// Enum ReserveAdjustment for value: reserveAdjustment
            /// </summary>
            [EnumMember(Value = "reserveAdjustment")]
            ReserveAdjustment = 59,

            /// <summary>
            /// Enum ReserveAdjustmentPending for value: reserveAdjustmentPending
            /// </summary>
            [EnumMember(Value = "reserveAdjustmentPending")]
            ReserveAdjustmentPending = 60,

            /// <summary>
            /// Enum Returned for value: returned
            /// </summary>
            [EnumMember(Value = "returned")]
            Returned = 61,

            /// <summary>
            /// Enum SecondChargeback for value: secondChargeback
            /// </summary>
            [EnumMember(Value = "secondChargeback")]
            SecondChargeback = 62,

            /// <summary>
            /// Enum SecondChargebackPending for value: secondChargebackPending
            /// </summary>
            [EnumMember(Value = "secondChargebackPending")]
            SecondChargebackPending = 63,

            /// <summary>
            /// Enum Undefined for value: undefined
            /// </summary>
            [EnumMember(Value = "undefined")]
            Undefined = 64

        }


        /// <summary>
        /// The status of the transfer event.
        /// </summary>
        /// <value>The status of the transfer event.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Modification" /> class.
        /// </summary>
        /// <param name="direction">The direction of the money movement..</param>
        /// <param name="id">Our reference for the modification..</param>
        /// <param name="reference">Your reference for the modification, used internally within your platform..</param>
        /// <param name="status">The status of the transfer event..</param>
        /// <param name="type">The type of transfer modification..</param>
        public Modification(string direction = default(string), string id = default(string), string reference = default(string), StatusEnum? status = default(StatusEnum?), string type = default(string))
        {
            this.Direction = direction;
            this.Id = id;
            this.Reference = reference;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// The direction of the money movement.
        /// </summary>
        /// <value>The direction of the money movement.</value>
        [DataMember(Name = "direction", EmitDefaultValue = false)]
        public string Direction { get; set; }

        /// <summary>
        /// Our reference for the modification.
        /// </summary>
        /// <value>Our reference for the modification.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Your reference for the modification, used internally within your platform.
        /// </summary>
        /// <value>Your reference for the modification, used internally within your platform.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// The type of transfer modification.
        /// </summary>
        /// <value>The type of transfer modification.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Modification {\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as Modification);
        }

        /// <summary>
        /// Returns true if Modification instances are equal
        /// </summary>
        /// <param name="input">Instance of Modification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Modification input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Direction != null)
                {
                    hashCode = (hashCode * 59) + this.Direction.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
