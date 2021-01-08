#region Licence

// 
//                        ######
//                        ######
//  ############    ####( ######  #####. ######  ############   ############
//  #############  #####( ######  #####. ######  #############  #############
//         ######  #####( ######  #####. ######  #####  ######  #####  ######
//  ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  ###### ######  #####( ######  #####. ######  #####          #####  ######
//  #############  #############  #############  #############  #####  ######
//   ############   ############  #############   ############  #####  ######
//                                       ######
//                                #############
//                                ############
// 
//  Adyen Dotnet API Library
// 
//  Copyright (c) 2020 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.

#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// CheckoutBankTransferAction
    /// </summary>
    [DataContract]
    public partial class CheckoutBankTransferAction : IEquatable<CheckoutBankTransferAction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutBankTransferAction" /> class.
        /// </summary>
        /// <param name="beneficiary">The name of the account holder..</param>
        /// <param name="bic">The BIC of the IBAN..</param>
        /// <param name="downloadUrl">The url to download payment details with..</param>
        /// <param name="iban">The IBAN of the bank transfer..</param>
        /// <param name="paymentData">When non-empty, contains a value that you must submit to the &#x60;/payments/details&#x60; endpoint. In some cases, required for polling..</param>
        /// <param name="paymentMethodType">Specifies the payment method..</param>
        /// <param name="reference">The transfer reference..</param>
        /// <param name="shopperEmail">The e-mail of the shopper, included if an e-mail was sent to the shopper..</param>
        /// <param name="totalAmount">totalAmount.</param>
        /// <param name="type">The type of bank transfer..</param>
        /// <param name="url">Specifies the URL to redirect to..</param>
        public CheckoutBankTransferAction(string beneficiary = default(string), string bic = default(string),
            string downloadUrl = default(string), string iban = default(string), string paymentData = default(string),
            string paymentMethodType = default(string), string reference = default(string),
            string shopperEmail = default(string), Amount totalAmount = default(Amount), string type = default(string),
            string url = default(string))
        {
            this.Beneficiary = beneficiary;
            this.Bic = bic;
            this.DownloadUrl = downloadUrl;
            this.Iban = iban;
            this.PaymentData = paymentData;
            this.PaymentMethodType = paymentMethodType;
            this.Reference = reference;
            this.ShopperEmail = shopperEmail;
            this.TotalAmount = totalAmount;
            this.Type = type;
            this.Url = url;
        }

        /// <summary>
        /// The name of the account holder.
        /// </summary>
        /// <value>The name of the account holder.</value>
        [DataMember(Name = "beneficiary", EmitDefaultValue = false)]
        public string Beneficiary { get; set; }

        /// <summary>
        /// The BIC of the IBAN.
        /// </summary>
        /// <value>The BIC of the IBAN.</value>
        [DataMember(Name = "bic", EmitDefaultValue = false)]
        public string Bic { get; set; }

        /// <summary>
        /// The url to download payment details with.
        /// </summary>
        /// <value>The url to download payment details with.</value>
        [DataMember(Name = "downloadUrl", EmitDefaultValue = false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// The IBAN of the bank transfer.
        /// </summary>
        /// <value>The IBAN of the bank transfer.</value>
        [DataMember(Name = "iban", EmitDefaultValue = false)]
        public string Iban { get; set; }

        /// <summary>
        /// When non-empty, contains a value that you must submit to the &#x60;/payments/details&#x60; endpoint. In some cases, required for polling.
        /// </summary>
        /// <value>When non-empty, contains a value that you must submit to the &#x60;/payments/details&#x60; endpoint. In some cases, required for polling.</value>
        [DataMember(Name = "paymentData", EmitDefaultValue = false)]
        public string PaymentData { get; set; }

        /// <summary>
        /// Specifies the payment method.
        /// </summary>
        /// <value>Specifies the payment method.</value>
        [DataMember(Name = "paymentMethodType", EmitDefaultValue = false)]
        public string PaymentMethodType { get; set; }

        /// <summary>
        /// The transfer reference.
        /// </summary>
        /// <value>The transfer reference.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// The e-mail of the shopper, included if an e-mail was sent to the shopper.
        /// </summary>
        /// <value>The e-mail of the shopper, included if an e-mail was sent to the shopper.</value>
        [DataMember(Name = "shopperEmail", EmitDefaultValue = false)]
        public string ShopperEmail { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmount
        /// </summary>
        [DataMember(Name = "totalAmount", EmitDefaultValue = false)]
        public Amount TotalAmount { get; set; }

        /// <summary>
        /// The type of bank transfer.
        /// </summary>
        /// <value>The type of bank transfer.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Specifies the URL to redirect to.
        /// </summary>
        /// <value>Specifies the URL to redirect to.</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckoutBankTransferAction {\n");
            sb.Append("  Beneficiary: ").Append(Beneficiary).Append("\n");
            sb.Append("  Bic: ").Append(Bic).Append("\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  PaymentData: ").Append(PaymentData).Append("\n");
            sb.Append("  PaymentMethodType: ").Append(PaymentMethodType).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  ShopperEmail: ").Append(ShopperEmail).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as CheckoutBankTransferAction);
        }

        /// <summary>
        /// Returns true if CheckoutBankTransferAction instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckoutBankTransferAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckoutBankTransferAction input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Beneficiary == input.Beneficiary ||
                    this.Beneficiary != null &&
                    this.Beneficiary.Equals(input.Beneficiary)
                ) &&
                (
                    this.Bic == input.Bic ||
                    this.Bic != null &&
                    this.Bic.Equals(input.Bic)
                ) &&
                (
                    this.DownloadUrl == input.DownloadUrl ||
                    this.DownloadUrl != null &&
                    this.DownloadUrl.Equals(input.DownloadUrl)
                ) &&
                (
                    this.Iban == input.Iban ||
                    this.Iban != null &&
                    this.Iban.Equals(input.Iban)
                ) &&
                (
                    this.PaymentData == input.PaymentData ||
                    this.PaymentData != null &&
                    this.PaymentData.Equals(input.PaymentData)
                ) &&
                (
                    this.PaymentMethodType == input.PaymentMethodType ||
                    this.PaymentMethodType != null &&
                    this.PaymentMethodType.Equals(input.PaymentMethodType)
                ) &&
                (
                    this.Reference == input.Reference ||
                    this.Reference != null &&
                    this.Reference.Equals(input.Reference)
                ) &&
                (
                    this.ShopperEmail == input.ShopperEmail ||
                    this.ShopperEmail != null &&
                    this.ShopperEmail.Equals(input.ShopperEmail)
                ) &&
                (
                    this.TotalAmount == input.TotalAmount ||
                    this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount)
                ) &&
                (
                    this.Type == input.Type ||
                    this.Type != null &&
                    this.Type.Equals(input.Type)
                ) &&
                (
                    this.Url == input.Url ||
                    this.Url != null &&
                    this.Url.Equals(input.Url)
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
                if (this.Beneficiary != null)
                    hashCode = hashCode * 59 + this.Beneficiary.GetHashCode();
                if (this.Bic != null)
                    hashCode = hashCode * 59 + this.Bic.GetHashCode();
                if (this.DownloadUrl != null)
                    hashCode = hashCode * 59 + this.DownloadUrl.GetHashCode();
                if (this.Iban != null)
                    hashCode = hashCode * 59 + this.Iban.GetHashCode();
                if (this.PaymentData != null)
                    hashCode = hashCode * 59 + this.PaymentData.GetHashCode();
                if (this.PaymentMethodType != null)
                    hashCode = hashCode * 59 + this.PaymentMethodType.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.ShopperEmail != null)
                    hashCode = hashCode * 59 + this.ShopperEmail.GetHashCode();
                if (this.TotalAmount != null)
                    hashCode = hashCode * 59 + this.TotalAmount.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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