/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 70
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

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// CheckoutNativeRedirectAction
    /// </summary>
    [DataContract(Name = "CheckoutNativeRedirectAction")]
    public partial class CheckoutNativeRedirectAction : IEquatable<CheckoutNativeRedirectAction>, IValidatableObject
    {
        /// <summary>
        /// **nativeRedirect**
        /// </summary>
        /// <value>**nativeRedirect**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum NativeRedirect for value: nativeRedirect
            /// </summary>
            [EnumMember(Value = "nativeRedirect")]
            NativeRedirect = 1

        }


        /// <summary>
        /// **nativeRedirect**
        /// </summary>
        /// <value>**nativeRedirect**</value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutNativeRedirectAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CheckoutNativeRedirectAction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutNativeRedirectAction" /> class.
        /// </summary>
        /// <param name="data">When the redirect URL must be accessed via POST, use this data to post to the redirect URL..</param>
        /// <param name="method">Specifies the HTTP method, for example GET or POST..</param>
        /// <param name="nativeRedirectData">Native SDK&#39;s redirect data containing the direct issuer link and state data that must be submitted to the /v1/nativeRedirect/redirectResult..</param>
        /// <param name="paymentMethodType">Specifies the payment method..</param>
        /// <param name="type">**nativeRedirect** (required).</param>
        /// <param name="url">Specifies the URL to redirect to..</param>
        public CheckoutNativeRedirectAction(Dictionary<string, string> data = default(Dictionary<string, string>), string method = default(string), string nativeRedirectData = default(string), string paymentMethodType = default(string), TypeEnum type = default(TypeEnum), string url = default(string))
        {
            this.Type = type;
            this.Data = data;
            this.Method = method;
            this.NativeRedirectData = nativeRedirectData;
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
        /// Native SDK&#39;s redirect data containing the direct issuer link and state data that must be submitted to the /v1/nativeRedirect/redirectResult.
        /// </summary>
        /// <value>Native SDK&#39;s redirect data containing the direct issuer link and state data that must be submitted to the /v1/nativeRedirect/redirectResult.</value>
        [DataMember(Name = "nativeRedirectData", EmitDefaultValue = false)]
        public string NativeRedirectData { get; set; }

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
            StringBuilder sb = new StringBuilder();
            sb.Append("class CheckoutNativeRedirectAction {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  NativeRedirectData: ").Append(NativeRedirectData).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckoutNativeRedirectAction);
        }

        /// <summary>
        /// Returns true if CheckoutNativeRedirectAction instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckoutNativeRedirectAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckoutNativeRedirectAction input)
        {
            if (input == null)
            {
                return false;
            }
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
                    this.NativeRedirectData == input.NativeRedirectData ||
                    (this.NativeRedirectData != null &&
                    this.NativeRedirectData.Equals(input.NativeRedirectData))
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
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.Method != null)
                {
                    hashCode = (hashCode * 59) + this.Method.GetHashCode();
                }
                if (this.NativeRedirectData != null)
                {
                    hashCode = (hashCode * 59) + this.NativeRedirectData.GetHashCode();
                }
                if (this.PaymentMethodType != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentMethodType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
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
