// #region License
// 
//                         ######
//                         ######
//   ############    ####( ######  #####. ######  ############   ############
//   #############  #####( ######  #####. ######  #############  #############
//          ######  #####( ######  #####. ######  #####  ######  #####  ######
//   ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//   ###### ######  #####( ######  #####. ######  #####          #####  ######
//   #############  #############  #############  #############  #####  ######
//    ############   ############  #############   ############  #####  ######
//                                        ######
//                                 #############
//                                 ############
// 
//   Adyen Dotnet API Library
// 
//   Copyright (c) 2021 Adyen B.V.
//   This file is open source and available under the MIT license.
//   See the LICENSE file for more info.
// 
// #endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout
{
     /// <summary>
    /// CheckoutDonationAction
    /// </summary>
    [DataContract]
        public partial class CheckoutDonationAction :  IEquatable<CheckoutDonationAction>, IValidatableObject
    {
        /// <summary>
        /// The type of the action.
        /// </summary>
        /// <value>The type of the action.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Donate for value: donate
            /// </summary>
            [EnumMember(Value = "donate")]
            Donate = 1        }
        /// <summary>
        /// The type of the action.
        /// </summary>
        /// <value>The type of the action.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutDonationAction" /> class.
        /// </summary>
        /// <param name="paymentData">A value that must be submitted to the &#x60;/payments/details&#x60; endpoint to verify this payment..</param>
        /// <param name="paymentMethodType">Specifies the payment method..</param>
        /// <param name="type">The type of the action. (required).</param>
        /// <param name="url">Specifies the URL to redirect to..</param>
        public CheckoutDonationAction(string paymentData = default(string), string paymentMethodType = default(string), TypeEnum type = default(TypeEnum), string url = default(string))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for CheckoutDonationAction and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.PaymentData = paymentData;
            this.PaymentMethodType = paymentMethodType;
            this.Url = url;
        }
        
        /// <summary>
        /// A value that must be submitted to the &#x60;/payments/details&#x60; endpoint to verify this payment.
        /// </summary>
        /// <value>A value that must be submitted to the &#x60;/payments/details&#x60; endpoint to verify this payment.</value>
        [DataMember(Name="paymentData", EmitDefaultValue=false)]
        public string PaymentData { get; set; }

        /// <summary>
        /// Specifies the payment method.
        /// </summary>
        /// <value>Specifies the payment method.</value>
        [DataMember(Name="paymentMethodType", EmitDefaultValue=false)]
        public string PaymentMethodType { get; set; }


        /// <summary>
        /// Specifies the URL to redirect to.
        /// </summary>
        /// <value>Specifies the URL to redirect to.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckoutDonationAction {\n");
            sb.Append("  PaymentData: ").Append(PaymentData).Append("\n");
            sb.Append("  PaymentMethodType: ").Append(PaymentMethodType).Append("\n");
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
            return this.Equals(input as CheckoutDonationAction);
        }

        /// <summary>
        /// Returns true if CheckoutDonationAction instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckoutDonationAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckoutDonationAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PaymentData == input.PaymentData ||
                    (this.PaymentData != null &&
                    this.PaymentData.Equals(input.PaymentData))
                ) && 
                (
                    this.PaymentMethodType == input.PaymentMethodType ||
                    (this.PaymentMethodType != null &&
                    this.PaymentMethodType.Equals(input.PaymentMethodType))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}