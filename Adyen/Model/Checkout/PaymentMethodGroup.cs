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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// PaymentMethodGroup
    /// </summary>
    [DataContract]
    public partial class PaymentMethodGroup :  IEquatable<PaymentMethodGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodGroup" /> class.
        /// </summary>
        /// <param name="Name">The name of the group..</param>
        /// <param name="PaymentMethodData">Echo data to be used if the payment method is displayed as part of this group..</param>
        /// <param name="Type">The unique code of the group..</param>
        public PaymentMethodGroup(string Name = default(string), string PaymentMethodData = default(string), string Type = default(string))
        {
            this.Name = Name;
            this.PaymentMethodData = PaymentMethodData;
            this.Type = Type;
        }
        
        /// <summary>
        /// The name of the group.
        /// </summary>
        /// <value>The name of the group.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Echo data to be used if the payment method is displayed as part of this group.
        /// </summary>
        /// <value>Echo data to be used if the payment method is displayed as part of this group.</value>
        [DataMember(Name="paymentMethodData", EmitDefaultValue=false)]
        public string PaymentMethodData { get; set; }

        /// <summary>
        /// The unique code of the group.
        /// </summary>
        /// <value>The unique code of the group.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentMethodGroup {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PaymentMethodData: ").Append(PaymentMethodData).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as PaymentMethodGroup);
        }

        /// <summary>
        /// Returns true if PaymentMethodGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethodGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PaymentMethodData == input.PaymentMethodData ||
                    (this.PaymentMethodData != null &&
                    this.PaymentMethodData.Equals(input.PaymentMethodData))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PaymentMethodData != null)
                    hashCode = hashCode * 59 + this.PaymentMethodData.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
