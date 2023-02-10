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
    /// PaymentMethodsResponse
    /// </summary>
    [DataContract(Name = "PaymentMethodsResponse")]
    public partial class PaymentMethodsResponse : IEquatable<PaymentMethodsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodsResponse" /> class.
        /// </summary>
        /// <param name="paymentMethods">Detailed list of payment methods required to generate payment forms..</param>
        /// <param name="storedPaymentMethods">List of all stored payment methods..</param>
        public PaymentMethodsResponse(List<PaymentMethod> paymentMethods = default(List<PaymentMethod>), List<StoredPaymentMethod> storedPaymentMethods = default(List<StoredPaymentMethod>))
        {
            this.PaymentMethods = paymentMethods;
            this.StoredPaymentMethods = storedPaymentMethods;
        }

        /// <summary>
        /// Detailed list of payment methods required to generate payment forms.
        /// </summary>
        /// <value>Detailed list of payment methods required to generate payment forms.</value>
        [DataMember(Name = "paymentMethods", EmitDefaultValue = false)]
        public List<PaymentMethod> PaymentMethods { get; set; }

        /// <summary>
        /// List of all stored payment methods.
        /// </summary>
        /// <value>List of all stored payment methods.</value>
        [DataMember(Name = "storedPaymentMethods", EmitDefaultValue = false)]
        public List<StoredPaymentMethod> StoredPaymentMethods { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentMethodsResponse {\n");
            sb.Append("  PaymentMethods: ").Append(PaymentMethods).Append("\n");
            sb.Append("  StoredPaymentMethods: ").Append(StoredPaymentMethods).Append("\n");
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
            return this.Equals(input as PaymentMethodsResponse);
        }

        /// <summary>
        /// Returns true if PaymentMethodsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethodsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodsResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PaymentMethods == input.PaymentMethods ||
                    this.PaymentMethods != null &&
                    input.PaymentMethods != null &&
                    this.PaymentMethods.SequenceEqual(input.PaymentMethods)
                ) && 
                (
                    this.StoredPaymentMethods == input.StoredPaymentMethods ||
                    this.StoredPaymentMethods != null &&
                    input.StoredPaymentMethods != null &&
                    this.StoredPaymentMethods.SequenceEqual(input.StoredPaymentMethods)
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
                if (this.PaymentMethods != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentMethods.GetHashCode();
                }
                if (this.StoredPaymentMethods != null)
                {
                    hashCode = (hashCode * 59) + this.StoredPaymentMethods.GetHashCode();
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
