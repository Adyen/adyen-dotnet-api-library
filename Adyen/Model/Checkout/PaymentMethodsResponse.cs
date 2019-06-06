
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// PaymentMethodsResponse
    /// </summary>
    [DataContract]
    public partial class PaymentMethodsResponse :  IEquatable<PaymentMethodsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodsResponse" /> class.
        /// </summary>
        /// <param name="Groups">Groups of payment methods..</param>
        /// <param name="OneClickPaymentMethods">Detailed list of one-click payment methods..</param>
        /// <param name="PaymentMethods">Detailed list of payment methods required to generate payment forms..</param>
        public PaymentMethodsResponse(List<PaymentMethodsGroup> Groups = default(List<PaymentMethodsGroup>), List<RecurringDetail> OneClickPaymentMethods = default(List<RecurringDetail>), List<PaymentMethod> PaymentMethods = default(List<PaymentMethod>))
        {
            this.Groups = Groups;
            this.OneClickPaymentMethods = OneClickPaymentMethods;
            this.PaymentMethods = PaymentMethods;
        }
        
        /// <summary>
        /// Groups of payment methods.
        /// </summary>
        /// <value>Groups of payment methods.</value>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<PaymentMethodsGroup> Groups { get; set; }

        /// <summary>
        /// Detailed list of one-click payment methods.
        /// </summary>
        /// <value>Detailed list of one-click payment methods.</value>
        [DataMember(Name="oneClickPaymentMethods", EmitDefaultValue=false)]
        public List<RecurringDetail> OneClickPaymentMethods { get; set; }

        /// <summary>
        /// Detailed list of payment methods required to generate payment forms.
        /// </summary>
        /// <value>Detailed list of payment methods required to generate payment forms.</value>
        [DataMember(Name="paymentMethods", EmitDefaultValue=false)]
        public List<PaymentMethod> PaymentMethods { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentMethodsResponse {\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  OneClickPaymentMethods: ").Append(OneClickPaymentMethods).Append("\n");
            sb.Append("  PaymentMethods: ").Append(PaymentMethods).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
                return false;

            return 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) && 
                (
                    this.OneClickPaymentMethods == input.OneClickPaymentMethods ||
                    this.OneClickPaymentMethods != null &&
                    this.OneClickPaymentMethods.SequenceEqual(input.OneClickPaymentMethods)
                ) && 
                (
                    this.PaymentMethods == input.PaymentMethods ||
                    this.PaymentMethods != null &&
                    this.PaymentMethods.SequenceEqual(input.PaymentMethods)
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
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.OneClickPaymentMethods != null)
                    hashCode = hashCode * 59 + this.OneClickPaymentMethods.GetHashCode();
                if (this.PaymentMethods != null)
                    hashCode = hashCode * 59 + this.PaymentMethods.GetHashCode();
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
