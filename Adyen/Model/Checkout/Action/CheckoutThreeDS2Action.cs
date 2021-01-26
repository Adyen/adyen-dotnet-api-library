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

namespace Adyen.Model.Checkout.Action
{
    /// <summary>
    /// CheckoutThreeDS2Action
    /// </summary>
    [DataContract]
    public partial class CheckoutThreeDS2Action : IEquatable<CheckoutThreeDS2Action>, IValidatableObject, IPaymentResponseAction
    {
        /// <summary>
        /// Unique identifier of action
        /// </summary>
        /// <value>Unique identifier of action</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; } = "threeDS2Action";
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutThreeDS2Action" /> class.
        /// </summary>
        /// <param name="authorisationToken">A token needed to authorise a payment..</param>
        /// <param name="paymentData">When non-empty, contains a value that you must submit to the &#x60;/payments/details&#x60; endpoint. In some cases, required for polling..</param>
        /// <param name="paymentMethodType">Specifies the payment method..</param>
        /// <param name="subtype">A subtype of the token..</param>
        /// <param name="token">A token to pass to the 3DS2 Component to get the fingerprint..</param>
        /// <param name="url">Specifies the URL to redirect to..</param>
        public CheckoutThreeDS2Action(string authorisationToken = default(string), string paymentData = default(string),
            string paymentMethodType = default(string), string subtype = default(string),
            string token = default(string), string url = default(string))
        {
            this.AuthorisationToken = authorisationToken;
            this.PaymentData = paymentData;
            this.PaymentMethodType = paymentMethodType;
            this.Subtype = subtype;
            this.Token = token;
            this.Url = url;
        }

        /// <summary>
        /// A token needed to authorise a payment.
        /// </summary>
        /// <value>A token needed to authorise a payment.</value>
        [DataMember(Name = "authorisationToken", EmitDefaultValue = false)]
        public string AuthorisationToken { get; set; }

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
        /// A subtype of the token.
        /// </summary>
        /// <value>A subtype of the token.</value>
        [DataMember(Name = "subtype", EmitDefaultValue = false)]
        public string Subtype { get; set; }

        /// <summary>
        /// A token to pass to the 3DS2 Component to get the fingerprint.
        /// </summary>
        /// <value>A token to pass to the 3DS2 Component to get the fingerprint.</value>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public string Token { get; set; }

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
            sb.Append("class CheckoutThreeDS2Action {\n");
            sb.Append("  AuthorisationToken: ").Append(AuthorisationToken).Append("\n");
            sb.Append("  PaymentData: ").Append(PaymentData).Append("\n");
            sb.Append("  PaymentMethodType: ").Append(PaymentMethodType).Append("\n");
            sb.Append("  Subtype: ").Append(Subtype).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
            return this.Equals(input as CheckoutThreeDS2Action);
        }

        /// <summary>
        /// Returns true if CheckoutThreeDS2Action instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckoutThreeDS2Action to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckoutThreeDS2Action input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AuthorisationToken == input.AuthorisationToken ||
                    this.AuthorisationToken != null &&
                    this.AuthorisationToken.Equals(input.AuthorisationToken)
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
                    this.Subtype == input.Subtype ||
                    this.Subtype != null &&
                    this.Subtype.Equals(input.Subtype)
                ) &&
                (
                    this.Token == input.Token ||
                    this.Token != null &&
                    this.Token.Equals(input.Token)
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
                if (this.AuthorisationToken != null)
                    hashCode = hashCode * 59 + this.AuthorisationToken.GetHashCode();
                if (this.PaymentData != null)
                    hashCode = hashCode * 59 + this.PaymentData.GetHashCode();
                if (this.PaymentMethodType != null)
                    hashCode = hashCode * 59 + this.PaymentMethodType.GetHashCode();
                if (this.Subtype != null)
                    hashCode = hashCode * 59 + this.Subtype.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
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