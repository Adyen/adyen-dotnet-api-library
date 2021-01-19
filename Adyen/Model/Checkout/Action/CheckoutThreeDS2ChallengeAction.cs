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
    /// CheckoutThreeDS2ChallengeAction
    /// </summary>
    [DataContract]
    public partial class CheckoutThreeDS2ChallengeAction : IEquatable<CheckoutThreeDS2ChallengeAction>,
        IValidatableObject, IPaymentResponseAction
    {
        /// <summary>
        /// Unique identifier of action
        /// </summary>
        /// <value>Unique identifier of action</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; } = "threeDS2Challenge";

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutThreeDS2ChallengeAction" /> class.
        /// </summary>
        /// <param name="paymentData">When non-empty, contains a value that you must submit to the &#x60;/payments/details&#x60; endpoint. In some cases, required for polling..</param>
        /// <param name="paymentMethodType">Specifies the payment method..</param>
        /// <param name="token">A token to pass to the 3DS2 Component to get the challenge..</param>
        /// <param name="url">Specifies the URL to redirect to..</param>
        public CheckoutThreeDS2ChallengeAction(string paymentData = default(string),
            string paymentMethodType = default(string), string token = default(string), string url = default(string))
        {
            this.PaymentData = paymentData;
            this.PaymentMethodType = paymentMethodType;
            this.Token = token;
            this.Url = url;
        }

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
        /// A token to pass to the 3DS2 Component to get the challenge.
        /// </summary>
        /// <value>A token to pass to the 3DS2 Component to get the challenge.</value>
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
            sb.Append("class CheckoutThreeDS2ChallengeAction {\n");
            sb.Append("  PaymentData: ").Append(PaymentData).Append("\n");
            sb.Append("  PaymentMethodType: ").Append(PaymentMethodType).Append("\n");
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
            return this.Equals(input as CheckoutThreeDS2ChallengeAction);
        }

        /// <summary>
        /// Returns true if CheckoutThreeDS2ChallengeAction instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckoutThreeDS2ChallengeAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckoutThreeDS2ChallengeAction input)
        {
            if (input == null)
                return false;

            return
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
                if (this.PaymentData != null)
                    hashCode = hashCode * 59 + this.PaymentData.GetHashCode();
                if (this.PaymentMethodType != null)
                    hashCode = hashCode * 59 + this.PaymentMethodType.GetHashCode();
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