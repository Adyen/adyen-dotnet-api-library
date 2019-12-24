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
//  * Copyright (c) 2019 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// CheckoutPaymentsAction
    /// </summary>
    [DataContract]
    public class CheckoutPaymentsAction : IEquatable<CheckoutPaymentsAction>, IValidatableObject
    {

        [JsonConverter(typeof(StringEnumConverter))]
        public enum CheckoutActionType
        {
            /// <summary>
            /// Enum qrCode for value: qrCode
            /// </summary>
            [EnumMember(Value = "qrCode")]
            QrCode = 0,
            /// <summary>
            /// Enum threeDS2Fingerprint for value: threeDS2Fingerprint
            /// </summary>
            [EnumMember(Value = "threeDS2Fingerprint")]
            ThreeDS2Fingerprint = 1,
            /// <summary>
            /// Enum threeDS2Challenge for value: threeDS2Challenge
            /// </summary>
            [EnumMember(Value = "threeDS2Challenge")]
            ThreeDS2Challenge = 2,
            /// <summary>
            /// Enum voucher for value: voucher
            /// </summary>
            [EnumMember(Value = "voucher")]
            Voucher = 3,
            /// <summary>
            /// Enum redirect for value: redirect
            /// </summary>
            [EnumMember(Value = "redirect")]
            Redirect = 4,
        }

        [DataMember(Name = "type", EmitDefaultValue = false)]
        public CheckoutActionType Type { get; set; }

        [DataMember(Name = "paymentMethodType", EmitDefaultValue = false)]
        public string PaymentMethodType { get; set; }

        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        [DataMember(Name = "method", EmitDefaultValue = false)]
        public string Method { get; set; }

        [DataMember(Name = "token", EmitDefaultValue = false)]
        public string Token { get; set; }

        [DataMember(Name = "paymentData", EmitDefaultValue = false)]
        public string PaymentData { get; set; }

        [DataMember(Name = "qrCodeData", EmitDefaultValue = false)]
        public string QrCodeData { get; set; }

        [DataMember(Name = "data", EmitDefaultValue = false)]
        public Dictionary<string, string> Data { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckoutPaymentsAction {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  PaymentMethodType: ").Append(PaymentMethodType).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  QrCodeData: ").Append(QrCodeData).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  PaymentData: ").Append(PaymentData).Append("\n");
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
            return this.Equals(input as CheckoutPaymentsAction);
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }


        /// <summary>
        /// Returns true if CheckoutPaymentsAction instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckoutPaymentsAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckoutPaymentsAction input)
        {
            if (input == null)
                return false;
            return
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) &&
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) &&
                (
                    this.Url == input.Url ||
                    input.Url != null &&
                    this.Url.Equals(input.Url)
                ) &&
                (
                    this.PaymentMethodType == input.PaymentMethodType ||
                    (this.PaymentMethodType != null &&
                    this.PaymentMethodType.Equals(input.PaymentMethodType))
                ) &&
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) &&
                (
                    this.PaymentData == input.PaymentData ||
                    (this.PaymentData != null &&
                    this.PaymentData.Equals(input.PaymentData))
                ) &&
                (
                    this.QrCodeData == input.QrCodeData ||
                    (this.QrCodeData != null &&
                    this.QrCodeData.Equals(input.QrCodeData))
                ) &&
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.PaymentMethodType != null)
                    hashCode = hashCode * 59 + this.PaymentMethodType.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.PaymentData != null)
                    hashCode = hashCode * 59 + this.PaymentData.GetHashCode();
                if (this.QrCodeData != null)
                    hashCode = hashCode * 59 + this.QrCodeData.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
                return hashCode;
            }
        }
    }
}
