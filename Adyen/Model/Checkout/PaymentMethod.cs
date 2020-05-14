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
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

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
    /// PaymentMethod
    /// </summary>
    [DataContract]
    public partial class PaymentMethod :  IEquatable<PaymentMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethod" /> class.
        /// </summary>
        /// <param name="Configuration">The configuration of the payment method..</param>
        /// <param name="Details">All input details to be provided to complete the payment with this payment method..</param>
        /// <param name="Group">The group where this payment method belongs to..</param>
        /// <param name="Name">The displayable name of this payment method..</param>
        /// <param name="PaymentMethodData">Echo data required to send in next calls..</param>
        /// <param name="SupportsRecurring">Indicates whether this payment method supports tokenization or not..</param>
        /// <param name="Type">The unique payment method code..</param>
        /// <param name="Brands">List of card brands</param>
        public PaymentMethod(Dictionary<string, string> Configuration = default(Dictionary<string, string>), List<InputDetail> Details = default(List<InputDetail>), PaymentMethodGroup Group = default(PaymentMethodGroup), string Name = default(string), string PaymentMethodData = default(string), bool? SupportsRecurring = default(bool?), string Type = default(string), List<string> Brands = default(List<string>))
        {
            this.Configuration = Configuration;
            this.Details = Details;
            this.Group = Group;
            this.Name = Name;
            this.PaymentMethodData = PaymentMethodData;
            this.SupportsRecurring = SupportsRecurring;
            this.Type = Type;
            this.Brands = Brands;
        }
        
        /// <summary>
        /// The configuration of the payment method.
        /// </summary>
        /// <value>The configuration of the payment method.</value>
        [DataMember(Name="configuration", EmitDefaultValue=false)]
        public Dictionary<string, string> Configuration { get; set; }

        /// <summary>
        /// All input details to be provided to complete the payment with this payment method.
        /// </summary>
        /// <value>All input details to be provided to complete the payment with this payment method.</value>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public List<InputDetail> Details { get; set; }

        /// <summary>
        /// The group where this payment method belongs to.
        /// </summary>
        /// <value>The group where this payment method belongs to.</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public PaymentMethodGroup Group { get; set; }

        /// <summary>
        /// The displayable name of this payment method.
        /// </summary>
        /// <value>The displayable name of this payment method.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Echo data required to send in next calls.
        /// </summary>
        /// <value>Echo data required to send in next calls.</value>
        [DataMember(Name="paymentMethodData", EmitDefaultValue=false)]
        public string PaymentMethodData { get; set; }

        /// <summary>
        /// Indicates whether this payment method supports tokenization or not.
        /// </summary>
        /// <value>Indicates whether this payment method supports tokenization or not.</value>
        [DataMember(Name="supportsRecurring", EmitDefaultValue=false)]
        public bool? SupportsRecurring { get; set; }

        /// <summary>
        /// The unique payment method code.
        /// </summary>
        /// <value>The unique payment method code.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// List of brand codes
        /// </summary>
        /// <value>The unique payment method code.</value>
        [DataMember(Name = "brands", EmitDefaultValue = false)]
        public List<string> Brands { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentMethod {\n");
            sb.Append("  Configuration: ").Append(Configuration).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PaymentMethodData: ").Append(PaymentMethodData).Append("\n");
            sb.Append("  SupportsRecurring: ").Append(SupportsRecurring).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Brands: ").Append(Brands).Append("\n");
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
            return this.Equals(input as PaymentMethod);
        }

        /// <summary>
        /// Returns true if PaymentMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethod input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Configuration == input.Configuration ||
                    this.Configuration != null &&
                    this.Configuration.SequenceEqual(input.Configuration)
                ) && 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
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
                    this.SupportsRecurring == input.SupportsRecurring ||
                    (this.SupportsRecurring != null &&
                    this.SupportsRecurring.Equals(input.SupportsRecurring))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) &&
                (
                    this.Brands == input.Brands ||
                    (this.Brands != null &&
                    this.Brands.Equals(input.Brands))
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
                if (this.Configuration != null)
                    hashCode = hashCode * 59 + this.Configuration.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PaymentMethodData != null)
                    hashCode = hashCode * 59 + this.PaymentMethodData.GetHashCode();
                if (this.SupportsRecurring != null)
                    hashCode = hashCode * 59 + this.SupportsRecurring.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Brands != null)
                    hashCode = hashCode * 59 + this.Brands.GetHashCode();
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
