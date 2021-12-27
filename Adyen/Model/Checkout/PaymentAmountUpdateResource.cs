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
 * Copyright (c) 2021 Adyen B.V.
 * This file is open source and available under the MIT license.
 * See the LICENSE file for more info.
 */
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// PaymentAmountUpdateResource
    /// </summary>
    [DataContract]
    public partial class PaymentAmountUpdateResource : IEquatable<PaymentAmountUpdateResource>, IValidatableObject
    {
        /// <summary>
        /// The reason for the amount update. Possible values:  * **DelayedCharge**  * **NoShow**
        /// </summary>
        /// <value>The reason for the amount update. Possible values:  * **DelayedCharge**  * **NoShow**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReasonEnum
        {
            /// <summary>
            /// Enum DelayedCharge for value: delayedCharge
            /// </summary>
            [EnumMember(Value = "delayedCharge")] DelayedCharge = 1,

            /// <summary>
            /// Enum NoShow for value: noShow
            /// </summary>
            [EnumMember(Value = "noShow")] NoShow = 2
        }

        /// <summary>
        /// The reason for the amount update. Possible values:  * **DelayedCharge**  * **NoShow**
        /// </summary>
        /// <value>The reason for the amount update. Possible values:  * **DelayedCharge**  * **NoShow**</value>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        public ReasonEnum? Reason { get; set; }

        /// <summary>
        /// The status of your request. This will always have the value **received**.
        /// </summary>
        /// <value>The status of your request. This will always have the value **received**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Received for value: received
            /// </summary>
            [EnumMember(Value = "received")] Received = 1
        }

        /// <summary>
        /// The status of your request. This will always have the value **received**.
        /// </summary>
        /// <value>The status of your request. This will always have the value **received**.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAmountUpdateResource" /> class.
        /// </summary>
        /// <param name="amount">amount (required).</param>
        /// <param name="merchantAccount">The merchant account that is used to process the payment. (required).</param>
        /// <param name="paymentPspReference">The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment to update.  (required).</param>
        /// <param name="pspReference">Adyen&#x27;s 16-character reference associated with the amount update request. (required).</param>
        /// <param name="reason">The reason for the amount update. Possible values:  * **DelayedCharge**  * **NoShow**.</param>
        /// <param name="reference">Your reference for the amount update request. Maximum length: 80 characters. (required).</param>
        /// <param name="splits">An array of objects specifying how the amount should be split between accounts when using Adyen for Platforms. For details, refer to [Providing split information](https://docs.adyen.com/platforms/processing-payments#providing-split-information)..</param>
        /// <param name="status">The status of your request. This will always have the value **received**. (required).</param>
        public PaymentAmountUpdateResource(Amount amount = default(Amount), string merchantAccount = default(string),
            string paymentPspReference = default(string), string pspReference = default(string),
            ReasonEnum? reason = default(ReasonEnum?), string reference = default(string),
            List<Split> splits = default(List<Split>), StatusEnum status = default(StatusEnum))
        {
            this.Amount = amount;
            this.MerchantAccount = merchantAccount;
            this.PaymentPspReference = paymentPspReference;
            this.PspReference = pspReference;
            this.Reference = reference;
            this.Status = status;
            this.Reason = reason;
            this.Splits = splits;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Amount Amount { get; set; }

        /// <summary>
        /// The merchant account that is used to process the payment.
        /// </summary>
        /// <value>The merchant account that is used to process the payment.</value>
        [DataMember(Name = "merchantAccount", EmitDefaultValue = false)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment to update. 
        /// </summary>
        /// <value>The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment to update. </value>
        [DataMember(Name = "paymentPspReference", EmitDefaultValue = false)]
        public string PaymentPspReference { get; set; }

        /// <summary>
        /// Adyen&#x27;s 16-character reference associated with the amount update request.
        /// </summary>
        /// <value>Adyen&#x27;s 16-character reference associated with the amount update request.</value>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        public string PspReference { get; set; }


        /// <summary>
        /// Your reference for the amount update request. Maximum length: 80 characters.
        /// </summary>
        /// <value>Your reference for the amount update request. Maximum length: 80 characters.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// An array of objects specifying how the amount should be split between accounts when using Adyen for Platforms. For details, refer to [Providing split information](https://docs.adyen.com/platforms/processing-payments#providing-split-information).
        /// </summary>
        /// <value>An array of objects specifying how the amount should be split between accounts when using Adyen for Platforms. For details, refer to [Providing split information](https://docs.adyen.com/platforms/processing-payments#providing-split-information).</value>
        [DataMember(Name = "splits", EmitDefaultValue = false)]
        public List<Split> Splits { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentAmountUpdateResource {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  PaymentPspReference: ").Append(PaymentPspReference).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Splits: ").Append(Splits).Append("\n");
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
            return this.Equals(input as PaymentAmountUpdateResource);
        }

        /// <summary>
        /// Returns true if PaymentAmountUpdateResource instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentAmountUpdateResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentAmountUpdateResource input)
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
                    this.MerchantAccount == input.MerchantAccount ||
                    (this.MerchantAccount != null &&
                     this.MerchantAccount.Equals(input.MerchantAccount))
                ) &&
                (
                    this.PaymentPspReference == input.PaymentPspReference ||
                    (this.PaymentPspReference != null &&
                     this.PaymentPspReference.Equals(input.PaymentPspReference))
                ) &&
                (
                    this.PspReference == input.PspReference ||
                    (this.PspReference != null &&
                     this.PspReference.Equals(input.PspReference))
                ) &&
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                     this.Reason.Equals(input.Reason))
                ) &&
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                     this.Reference.Equals(input.Reference))
                ) &&
                (
                    this.Splits == input.Splits ||
                    this.Splits != null &&
                    input.Splits != null &&
                    this.Splits.SequenceEqual(input.Splits)
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.MerchantAccount != null)
                    hashCode = hashCode * 59 + this.MerchantAccount.GetHashCode();
                if (this.PaymentPspReference != null)
                    hashCode = hashCode * 59 + this.PaymentPspReference.GetHashCode();
                if (this.PspReference != null)
                    hashCode = hashCode * 59 + this.PspReference.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.Splits != null)
                    hashCode = hashCode * 59 + this.Splits.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(
            ValidationContext validationContext)
        {
            yield break;
        }
    }
}