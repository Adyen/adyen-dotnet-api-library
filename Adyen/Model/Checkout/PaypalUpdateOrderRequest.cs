/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 71
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
    /// PaypalUpdateOrderRequest
    /// </summary>
    [DataContract(Name = "PaypalUpdateOrderRequest")]
    public partial class PaypalUpdateOrderRequest : IEquatable<PaypalUpdateOrderRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaypalUpdateOrderRequest" /> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="deliveryMethods">The list of new delivery methods and the cost of each..</param>
        /// <param name="paymentData">The &#x60;paymentData&#x60; from the client side. This value changes every time you make a &#x60;/paypal/updateOrder&#x60; request..</param>
        /// <param name="pspReference">The original &#x60;pspReference&#x60; from the &#x60;/payments&#x60; response..</param>
        /// <param name="sessionId">The original &#x60;sessionId&#x60; from the &#x60;/sessions&#x60; response..</param>
        public PaypalUpdateOrderRequest(Amount amount = default(Amount), List<DeliveryMethod> deliveryMethods = default(List<DeliveryMethod>), string paymentData = default(string), string pspReference = default(string), string sessionId = default(string))
        {
            this.Amount = amount;
            this.DeliveryMethods = deliveryMethods;
            this.PaymentData = paymentData;
            this.PspReference = pspReference;
            this.SessionId = sessionId;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Amount Amount { get; set; }

        /// <summary>
        /// The list of new delivery methods and the cost of each.
        /// </summary>
        /// <value>The list of new delivery methods and the cost of each.</value>
        [DataMember(Name = "deliveryMethods", EmitDefaultValue = false)]
        public List<DeliveryMethod> DeliveryMethods { get; set; }

        /// <summary>
        /// The &#x60;paymentData&#x60; from the client side. This value changes every time you make a &#x60;/paypal/updateOrder&#x60; request.
        /// </summary>
        /// <value>The &#x60;paymentData&#x60; from the client side. This value changes every time you make a &#x60;/paypal/updateOrder&#x60; request.</value>
        [DataMember(Name = "paymentData", EmitDefaultValue = false)]
        public string PaymentData { get; set; }

        /// <summary>
        /// The original &#x60;pspReference&#x60; from the &#x60;/payments&#x60; response.
        /// </summary>
        /// <value>The original &#x60;pspReference&#x60; from the &#x60;/payments&#x60; response.</value>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        public string PspReference { get; set; }

        /// <summary>
        /// The original &#x60;sessionId&#x60; from the &#x60;/sessions&#x60; response.
        /// </summary>
        /// <value>The original &#x60;sessionId&#x60; from the &#x60;/sessions&#x60; response.</value>
        [DataMember(Name = "sessionId", EmitDefaultValue = false)]
        public string SessionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaypalUpdateOrderRequest {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  DeliveryMethods: ").Append(DeliveryMethods).Append("\n");
            sb.Append("  PaymentData: ").Append(PaymentData).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
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
            return this.Equals(input as PaypalUpdateOrderRequest);
        }

        /// <summary>
        /// Returns true if PaypalUpdateOrderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PaypalUpdateOrderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaypalUpdateOrderRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.DeliveryMethods == input.DeliveryMethods ||
                    this.DeliveryMethods != null &&
                    input.DeliveryMethods != null &&
                    this.DeliveryMethods.SequenceEqual(input.DeliveryMethods)
                ) && 
                (
                    this.PaymentData == input.PaymentData ||
                    (this.PaymentData != null &&
                    this.PaymentData.Equals(input.PaymentData))
                ) && 
                (
                    this.PspReference == input.PspReference ||
                    (this.PspReference != null &&
                    this.PspReference.Equals(input.PspReference))
                ) && 
                (
                    this.SessionId == input.SessionId ||
                    (this.SessionId != null &&
                    this.SessionId.Equals(input.SessionId))
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.DeliveryMethods != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryMethods.GetHashCode();
                }
                if (this.PaymentData != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentData.GetHashCode();
                }
                if (this.PspReference != null)
                {
                    hashCode = (hashCode * 59) + this.PspReference.GetHashCode();
                }
                if (this.SessionId != null)
                {
                    hashCode = (hashCode * 59) + this.SessionId.GetHashCode();
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