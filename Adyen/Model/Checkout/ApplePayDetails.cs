/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 70
* Contact: developer-experience@adyen.com
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
    /// ApplePayDetails
    /// </summary>
    [DataContract(Name = "ApplePayDetails")]
    public partial class ApplePayDetails : IEquatable<ApplePayDetails>, IValidatableObject
    {
        /// <summary>
        /// The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**.
        /// </summary>
        /// <value>The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FundingSourceEnum
        {
            /// <summary>
            /// Enum Debit for value: debit
            /// </summary>
            [EnumMember(Value = "debit")]
            Debit = 1

        }


        /// <summary>
        /// The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**.
        /// </summary>
        /// <value>The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**.</value>
        [DataMember(Name = "fundingSource", EmitDefaultValue = false)]
        public FundingSourceEnum? FundingSource { get; set; }
        /// <summary>
        /// **applepay**
        /// </summary>
        /// <value>**applepay**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Applepay for value: applepay
            /// </summary>
            [EnumMember(Value = "applepay")]
            Applepay = 1

        }


        /// <summary>
        /// **applepay**
        /// </summary>
        /// <value>**applepay**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplePayDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApplePayDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplePayDetails" /> class.
        /// </summary>
        /// <param name="applePayToken">The stringified and base64 encoded &#x60;paymentData&#x60; you retrieved from the Apple framework. (required).</param>
        /// <param name="checkoutAttemptId">The checkout attempt identifier..</param>
        /// <param name="fundingSource">The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**..</param>
        /// <param name="recurringDetailReference">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
        /// <param name="storedPaymentMethodId">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
        /// <param name="type">**applepay** (default to TypeEnum.Applepay).</param>
        public ApplePayDetails(string applePayToken = default(string), string checkoutAttemptId = default(string), FundingSourceEnum? fundingSource = default(FundingSourceEnum?), string recurringDetailReference = default(string), string storedPaymentMethodId = default(string), TypeEnum? type = TypeEnum.Applepay)
        {
            this.ApplePayToken = applePayToken;
            this.CheckoutAttemptId = checkoutAttemptId;
            this.FundingSource = fundingSource;
            this.RecurringDetailReference = recurringDetailReference;
            this.StoredPaymentMethodId = storedPaymentMethodId;
            this.Type = type;
        }

        /// <summary>
        /// The stringified and base64 encoded &#x60;paymentData&#x60; you retrieved from the Apple framework.
        /// </summary>
        /// <value>The stringified and base64 encoded &#x60;paymentData&#x60; you retrieved from the Apple framework.</value>
        [DataMember(Name = "applePayToken", IsRequired = false, EmitDefaultValue = true)]
        public string ApplePayToken { get; set; }

        /// <summary>
        /// The checkout attempt identifier.
        /// </summary>
        /// <value>The checkout attempt identifier.</value>
        [DataMember(Name = "checkoutAttemptId", EmitDefaultValue = false)]
        public string CheckoutAttemptId { get; set; }

        /// <summary>
        /// This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.
        /// </summary>
        /// <value>This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.</value>
        [DataMember(Name = "recurringDetailReference", EmitDefaultValue = false)]
        [Obsolete]
        public string RecurringDetailReference { get; set; }

        /// <summary>
        /// This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.
        /// </summary>
        /// <value>This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.</value>
        [DataMember(Name = "storedPaymentMethodId", EmitDefaultValue = false)]
        public string StoredPaymentMethodId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplePayDetails {\n");
            sb.Append("  ApplePayToken: ").Append(ApplePayToken).Append("\n");
            sb.Append("  CheckoutAttemptId: ").Append(CheckoutAttemptId).Append("\n");
            sb.Append("  FundingSource: ").Append(FundingSource).Append("\n");
            sb.Append("  RecurringDetailReference: ").Append(RecurringDetailReference).Append("\n");
            sb.Append("  StoredPaymentMethodId: ").Append(StoredPaymentMethodId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ApplePayDetails);
        }

        /// <summary>
        /// Returns true if ApplePayDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplePayDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplePayDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApplePayToken == input.ApplePayToken ||
                    (this.ApplePayToken != null &&
                    this.ApplePayToken.Equals(input.ApplePayToken))
                ) && 
                (
                    this.CheckoutAttemptId == input.CheckoutAttemptId ||
                    (this.CheckoutAttemptId != null &&
                    this.CheckoutAttemptId.Equals(input.CheckoutAttemptId))
                ) && 
                (
                    this.FundingSource == input.FundingSource ||
                    this.FundingSource.Equals(input.FundingSource)
                ) && 
                (
                    this.RecurringDetailReference == input.RecurringDetailReference ||
                    (this.RecurringDetailReference != null &&
                    this.RecurringDetailReference.Equals(input.RecurringDetailReference))
                ) && 
                (
                    this.StoredPaymentMethodId == input.StoredPaymentMethodId ||
                    (this.StoredPaymentMethodId != null &&
                    this.StoredPaymentMethodId.Equals(input.StoredPaymentMethodId))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.ApplePayToken != null)
                {
                    hashCode = (hashCode * 59) + this.ApplePayToken.GetHashCode();
                }
                if (this.CheckoutAttemptId != null)
                {
                    hashCode = (hashCode * 59) + this.CheckoutAttemptId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FundingSource.GetHashCode();
                if (this.RecurringDetailReference != null)
                {
                    hashCode = (hashCode * 59) + this.RecurringDetailReference.GetHashCode();
                }
                if (this.StoredPaymentMethodId != null)
                {
                    hashCode = (hashCode * 59) + this.StoredPaymentMethodId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
            // ApplePayToken (string) maxLength
            if (this.ApplePayToken != null && this.ApplePayToken.Length > 10000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ApplePayToken, length must be less than 10000.", new [] { "ApplePayToken" });
            }

            yield break;
        }
    }

}
