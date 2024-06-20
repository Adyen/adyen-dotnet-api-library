/*
* Adyen Payment API
*
*
* The version of the OpenAPI document: 68
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

namespace Adyen.Model.Payment
{
    /// <summary>
    /// AdditionalDataWallets
    /// </summary>
    [DataContract(Name = "AdditionalDataWallets")]
    public partial class AdditionalDataWallets : IEquatable<AdditionalDataWallets>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataWallets" /> class.
        /// </summary>
        /// <param name="androidpayToken">The Android Pay token retrieved from the SDK..</param>
        /// <param name="masterpassTransactionId">The Mastercard Masterpass Transaction ID retrieved from the SDK..</param>
        /// <param name="paymentToken">The Apple Pay token retrieved from the SDK..</param>
        /// <param name="paywithgoogleToken">The Google Pay token retrieved from the SDK..</param>
        /// <param name="samsungpayToken">The Samsung Pay token retrieved from the SDK..</param>
        /// <param name="visacheckoutCallId">The Visa Checkout Call ID retrieved from the SDK..</param>
        public AdditionalDataWallets(string androidpayToken = default(string), string masterpassTransactionId = default(string), string paymentToken = default(string), string paywithgoogleToken = default(string), string samsungpayToken = default(string), string visacheckoutCallId = default(string))
        {
            this.AndroidpayToken = androidpayToken;
            this.MasterpassTransactionId = masterpassTransactionId;
            this.PaymentToken = paymentToken;
            this.PaywithgoogleToken = paywithgoogleToken;
            this.SamsungpayToken = samsungpayToken;
            this.VisacheckoutCallId = visacheckoutCallId;
        }

        /// <summary>
        /// The Android Pay token retrieved from the SDK.
        /// </summary>
        /// <value>The Android Pay token retrieved from the SDK.</value>
        [DataMember(Name = "androidpay.token", EmitDefaultValue = false)]
        public string AndroidpayToken { get; set; }

        /// <summary>
        /// The Mastercard Masterpass Transaction ID retrieved from the SDK.
        /// </summary>
        /// <value>The Mastercard Masterpass Transaction ID retrieved from the SDK.</value>
        [DataMember(Name = "masterpass.transactionId", EmitDefaultValue = false)]
        public string MasterpassTransactionId { get; set; }

        /// <summary>
        /// The Apple Pay token retrieved from the SDK.
        /// </summary>
        /// <value>The Apple Pay token retrieved from the SDK.</value>
        [DataMember(Name = "payment.token", EmitDefaultValue = false)]
        public string PaymentToken { get; set; }

        /// <summary>
        /// The Google Pay token retrieved from the SDK.
        /// </summary>
        /// <value>The Google Pay token retrieved from the SDK.</value>
        [DataMember(Name = "paywithgoogle.token", EmitDefaultValue = false)]
        public string PaywithgoogleToken { get; set; }

        /// <summary>
        /// The Samsung Pay token retrieved from the SDK.
        /// </summary>
        /// <value>The Samsung Pay token retrieved from the SDK.</value>
        [DataMember(Name = "samsungpay.token", EmitDefaultValue = false)]
        public string SamsungpayToken { get; set; }

        /// <summary>
        /// The Visa Checkout Call ID retrieved from the SDK.
        /// </summary>
        /// <value>The Visa Checkout Call ID retrieved from the SDK.</value>
        [DataMember(Name = "visacheckout.callId", EmitDefaultValue = false)]
        public string VisacheckoutCallId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdditionalDataWallets {\n");
            sb.Append("  AndroidpayToken: ").Append(AndroidpayToken).Append("\n");
            sb.Append("  MasterpassTransactionId: ").Append(MasterpassTransactionId).Append("\n");
            sb.Append("  PaymentToken: ").Append(PaymentToken).Append("\n");
            sb.Append("  PaywithgoogleToken: ").Append(PaywithgoogleToken).Append("\n");
            sb.Append("  SamsungpayToken: ").Append(SamsungpayToken).Append("\n");
            sb.Append("  VisacheckoutCallId: ").Append(VisacheckoutCallId).Append("\n");
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
        /// Returns the AdditionalDataWallets object from the json payload
        /// </summary>
        /// <returns>AdditionalDataWallets</returns>
        public static AdditionalDataWallets FromJson(string json)
        {
            return JsonConvert.DeserializeObject<AdditionalDataWallets>(json);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AdditionalDataWallets);
        }

        /// <summary>
        /// Returns true if AdditionalDataWallets instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalDataWallets to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalDataWallets input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AndroidpayToken == input.AndroidpayToken ||
                    (this.AndroidpayToken != null &&
                    this.AndroidpayToken.Equals(input.AndroidpayToken))
                ) && 
                (
                    this.MasterpassTransactionId == input.MasterpassTransactionId ||
                    (this.MasterpassTransactionId != null &&
                    this.MasterpassTransactionId.Equals(input.MasterpassTransactionId))
                ) && 
                (
                    this.PaymentToken == input.PaymentToken ||
                    (this.PaymentToken != null &&
                    this.PaymentToken.Equals(input.PaymentToken))
                ) && 
                (
                    this.PaywithgoogleToken == input.PaywithgoogleToken ||
                    (this.PaywithgoogleToken != null &&
                    this.PaywithgoogleToken.Equals(input.PaywithgoogleToken))
                ) && 
                (
                    this.SamsungpayToken == input.SamsungpayToken ||
                    (this.SamsungpayToken != null &&
                    this.SamsungpayToken.Equals(input.SamsungpayToken))
                ) && 
                (
                    this.VisacheckoutCallId == input.VisacheckoutCallId ||
                    (this.VisacheckoutCallId != null &&
                    this.VisacheckoutCallId.Equals(input.VisacheckoutCallId))
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
                if (this.AndroidpayToken != null)
                {
                    hashCode = (hashCode * 59) + this.AndroidpayToken.GetHashCode();
                }
                if (this.MasterpassTransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.MasterpassTransactionId.GetHashCode();
                }
                if (this.PaymentToken != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentToken.GetHashCode();
                }
                if (this.PaywithgoogleToken != null)
                {
                    hashCode = (hashCode * 59) + this.PaywithgoogleToken.GetHashCode();
                }
                if (this.SamsungpayToken != null)
                {
                    hashCode = (hashCode * 59) + this.SamsungpayToken.GetHashCode();
                }
                if (this.VisacheckoutCallId != null)
                {
                    hashCode = (hashCode * 59) + this.VisacheckoutCallId.GetHashCode();
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
