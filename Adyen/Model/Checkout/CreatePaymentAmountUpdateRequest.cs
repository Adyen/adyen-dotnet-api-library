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
    /// CreatePaymentAmountUpdateRequest
    /// </summary>
    [DataContract]
    public partial class CreatePaymentAmountUpdateRequest : IEquatable<CreatePaymentAmountUpdateRequest>,
        IValidatableObject
    {
        /// <summary>
        /// The reason for the amount update. Possible values:  * **delayedCharge**  * **noShow**
        /// </summary>
        /// <value>The reason for the amount update. Possible values:  * **delayedCharge**  * **noShow**</value>
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
        /// The reason for the amount update. Possible values:  * **delayedCharge**  * **noShow**
        /// </summary>
        /// <value>The reason for the amount update. Possible values:  * **delayedCharge**  * **noShow**</value>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        public ReasonEnum? Reason { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePaymentAmountUpdateRequest" /> class.
        /// </summary>
        /// <param name="amount">amount (required).</param>
        /// <param name="merchantAccount">The merchant account that is used to process the payment. (required).</param>
        /// <param name="reason">The reason for the amount update. Possible values:  * **delayedCharge**  * **noShow**.</param>
        /// <param name="reference">Your reference for the amount update request. Maximum length: 80 characters..</param>
        /// <param name="splits">An array of objects specifying how the amount should be split between accounts when using Adyen for Platforms. For details, refer to [Providing split information](https://docs.adyen.com/platforms/processing-payments#providing-split-information)..</param>
        public CreatePaymentAmountUpdateRequest(Amount amount = default(Amount),
            string merchantAccount = default(string), ReasonEnum? reason = default(ReasonEnum?),
            string reference = default(string), List<Split> splits = default(List<Split>))
        {
            this.Amount = amount;
            this.MerchantAccount = merchantAccount;
            this.Reason = reason;
            this.Reference = reference;
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
            sb.Append("class CreatePaymentAmountUpdateRequest {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Splits: ").Append(Splits).Append("\n");
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
            return this.Equals(input as CreatePaymentAmountUpdateRequest);
        }

        /// <summary>
        /// Returns true if CreatePaymentAmountUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreatePaymentAmountUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePaymentAmountUpdateRequest input)
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
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.Splits != null)
                    hashCode = hashCode * 59 + this.Splits.GetHashCode();
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