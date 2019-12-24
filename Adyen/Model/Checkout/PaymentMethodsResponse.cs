#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2019 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// PaymentMethodsResponse
    /// </summary>
    [DataContract]
    public partial class PaymentMethodsResponse : IEquatable<PaymentMethodsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodsResponse" /> class.
        /// </summary>
        /// <param name="groups">Groups of payment methods..</param>
        /// <param name="oneClickPaymentMethods">Detailed list of one-click payment methods..</param>
        /// <param name="paymentMethods">Detailed list of payment methods required to generate payment forms..</param>
        /// <param name="storedPaymentMethods">List of all stored payment methods..</param>
        public PaymentMethodsResponse(List<PaymentMethodsGroup> groups = default(List<PaymentMethodsGroup>), List<RecurringDetail> oneClickPaymentMethods = default(List<RecurringDetail>), List<PaymentMethod> paymentMethods = default(List<PaymentMethod>), List<StoredPaymentMethod> storedPaymentMethods = default(List<StoredPaymentMethod>))
        {
            this.Groups = groups;
            this.OneClickPaymentMethods = oneClickPaymentMethods;
            this.PaymentMethods = paymentMethods;
            this.StoredPaymentMethods = storedPaymentMethods;
        }

        /// <summary>
        /// Groups of payment methods.
        /// </summary>
        /// <value>Groups of payment methods.</value>
        [DataMember(Name = "groups", EmitDefaultValue = false)]
        public List<PaymentMethodsGroup> Groups { get; set; }

        /// <summary>
        /// Detailed list of one-click payment methods.
        /// </summary>
        /// <value>Detailed list of one-click payment methods.</value>
        [DataMember(Name = "oneClickPaymentMethods", EmitDefaultValue = false)]
        public List<RecurringDetail> OneClickPaymentMethods { get; set; }

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
            var sb = new StringBuilder();
            sb.Append("class PaymentMethodsResponse {\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  OneClickPaymentMethods: ").Append(OneClickPaymentMethods).Append("\n");
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
                    input.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) &&
                (
                    this.OneClickPaymentMethods == input.OneClickPaymentMethods ||
                    this.OneClickPaymentMethods != null &&
                    input.OneClickPaymentMethods != null &&
                    this.OneClickPaymentMethods.SequenceEqual(input.OneClickPaymentMethods)
                ) &&
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
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.OneClickPaymentMethods != null)
                    hashCode = hashCode * 59 + this.OneClickPaymentMethods.GetHashCode();
                if (this.PaymentMethods != null)
                    hashCode = hashCode * 59 + this.PaymentMethods.GetHashCode();
                if (this.StoredPaymentMethods != null)
                    hashCode = hashCode * 59 + this.StoredPaymentMethods.GetHashCode();
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
