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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// StandalonePaymentCancelResource
    /// </summary>
    [DataContract]
    public partial class StandalonePaymentCancelResource : IEquatable<StandalonePaymentCancelResource>,
        IValidatableObject
    {
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
        /// Initializes a new instance of the <see cref="StandalonePaymentCancelResource" /> class.
        /// </summary>
        /// <param name="merchantAccount">The merchant account that is used to process the payment. (required).</param>
        /// <param name="paymentReference">The [&#x60;reference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__reqParam_reference) of the payment to cancel. (required).</param>
        /// <param name="pspReference">Adyen&#x27;s 16-character reference associated with the cancel request. (required).</param>
        /// <param name="reference">Your reference for the cancel request..</param>
        /// <param name="status">The status of your request. This will always have the value **received**. (required).</param>
        public StandalonePaymentCancelResource(string merchantAccount = default(string),
            string paymentReference = default(string), string pspReference = default(string),
            string reference = default(string), StatusEnum status = default(StatusEnum))
        {
            this.MerchantAccount = merchantAccount;
            this.PaymentReference = paymentReference;
            this.PspReference = pspReference;
            this.Status = status;
            this.Reference = reference;
        }

        /// <summary>
        /// The merchant account that is used to process the payment.
        /// </summary>
        /// <value>The merchant account that is used to process the payment.</value>
        [DataMember(Name = "merchantAccount", EmitDefaultValue = false)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// The [&#x60;reference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__reqParam_reference) of the payment to cancel.
        /// </summary>
        /// <value>The [&#x60;reference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__reqParam_reference) of the payment to cancel.</value>
        [DataMember(Name = "paymentReference", EmitDefaultValue = false)]
        public string PaymentReference { get; set; }

        /// <summary>
        /// Adyen&#x27;s 16-character reference associated with the cancel request.
        /// </summary>
        /// <value>Adyen&#x27;s 16-character reference associated with the cancel request.</value>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        public string PspReference { get; set; }

        /// <summary>
        /// Your reference for the cancel request.
        /// </summary>
        /// <value>Your reference for the cancel request.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StandalonePaymentCancelResource {\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  PaymentReference: ").Append(PaymentReference).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
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
            return this.Equals(input as StandalonePaymentCancelResource);
        }

        /// <summary>
        /// Returns true if StandalonePaymentCancelResource instances are equal
        /// </summary>
        /// <param name="input">Instance of StandalonePaymentCancelResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StandalonePaymentCancelResource input)
        {
            if (input == null)
                return false;

            return
                (
                    this.MerchantAccount == input.MerchantAccount ||
                    (this.MerchantAccount != null &&
                     this.MerchantAccount.Equals(input.MerchantAccount))
                ) &&
                (
                    this.PaymentReference == input.PaymentReference ||
                    (this.PaymentReference != null &&
                     this.PaymentReference.Equals(input.PaymentReference))
                ) &&
                (
                    this.PspReference == input.PspReference ||
                    (this.PspReference != null &&
                     this.PspReference.Equals(input.PspReference))
                ) &&
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                     this.Reference.Equals(input.Reference))
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
                if (this.MerchantAccount != null)
                    hashCode = hashCode * 59 + this.MerchantAccount.GetHashCode();
                if (this.PaymentReference != null)
                    hashCode = hashCode * 59 + this.PaymentReference.GetHashCode();
                if (this.PspReference != null)
                    hashCode = hashCode * 59 + this.PspReference.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
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