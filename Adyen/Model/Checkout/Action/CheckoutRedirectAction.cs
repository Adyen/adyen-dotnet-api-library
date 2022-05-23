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
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Adyen.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout.Action
{
    /// <summary>
    /// CheckoutRedirectAction
    /// </summary>
    [DataContract]
    public partial class CheckoutRedirectAction : IEquatable<CheckoutRedirectAction>, IValidatableObject, IPaymentResponseAction
    {
        /// <summary>
        /// **redirect**
        /// </summary>
        /// <value>**redirect**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public String Type { get; set; } = "redirect";

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutRedirectAction" /> class.
        /// </summary>
        /// <param name="data">When the redirect URL must be accessed via POST, use this data to post to the redirect URL..</param>
        /// <param name="method">Specifies the HTTP method, for example GET or POST..</param>
        /// <param name="paymentMethodType">Specifies the payment method..</param>
        /// <param name="type">**redirect** (required).</param>
        /// <param name="url">Specifies the URL to redirect to..</param>
        public CheckoutRedirectAction(Dictionary<string, string> data = default(Dictionary<string, string>),
            string method = default(string), string paymentMethodType = default(string), string url = default(string))
        {
            this.Data = data;
            this.Method = method;
            this.PaymentMethodType = paymentMethodType;
            this.Url = url;
        }

        /// <summary>
        /// When the redirect URL must be accessed via POST, use this data to post to the redirect URL.
        /// </summary>
        /// <value>When the redirect URL must be accessed via POST, use this data to post to the redirect URL.</value>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public Dictionary<string, string> Data { get; set; }

        /// <summary>
        /// Specifies the HTTP method, for example GET or POST.
        /// </summary>
        /// <value>Specifies the HTTP method, for example GET or POST.</value>
        [DataMember(Name = "method", EmitDefaultValue = false)]
        public string Method { get; set; }

        /// <summary>
        /// Specifies the payment method.
        /// </summary>
        /// <value>Specifies the payment method.</value>
        [DataMember(Name = "paymentMethodType", EmitDefaultValue = false)]
        public string PaymentMethodType { get; set; }


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
            sb.Append("class CheckoutRedirectAction {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
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
            return this.Equals(input as CheckoutRedirectAction);
        }

        /// <summary>
        /// Returns true if CheckoutRedirectAction instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckoutRedirectAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckoutRedirectAction input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) &&
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                     this.Method.Equals(input.Method))
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(
            ValidationContext validationContext)
        {
            yield break;
        }
    }
}