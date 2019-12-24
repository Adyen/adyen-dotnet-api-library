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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// RecurringDetail
    /// </summary>
    [DataContract]
    public partial class RecurringDetail :  IEquatable<RecurringDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecurringDetail" /> class.
        /// </summary>
        /// <param name="Configuration">The configuration of the payment method..</param>
        /// <param name="Details">All input details to be provided to complete the payment with this payment method..</param>
        /// <param name="Group">The group where this payment method belongs to..</param>
        /// <param name="Name">The displayable name of this payment method..</param>
        /// <param name="PaymentMethodData">Echo data required to send in next calls..</param>
        /// <param name="RecurringDetailReference">The reference that uniquely identifies the recurring detail..</param>
        /// <param name="StoredDetails">Contains information on previously stored payment details..</param>
        /// <param name="SupportsRecurring">Indicates whether this payment method supports tokenization or not..</param>
        /// <param name="Type">The unique payment method code..</param>
        public RecurringDetail(Dictionary<string, string> Configuration = default(Dictionary<string, string>), List<InputDetail> Details = default(List<InputDetail>), PaymentMethodGroup Group = default(PaymentMethodGroup), string Name = default(string), string PaymentMethodData = default(string), string RecurringDetailReference = default(string), StoredDetails StoredDetails = default(StoredDetails), bool? SupportsRecurring = default(bool?), string Type = default(string))
        {
            this.Configuration = Configuration;
            this.Details = Details;
            this.Group = Group;
            this.Name = Name;
            this.PaymentMethodData = PaymentMethodData;
            this.RecurringDetailReference = RecurringDetailReference;
            this.StoredDetails = StoredDetails;
            this.SupportsRecurring = SupportsRecurring;
            this.Type = Type;
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
        /// The reference that uniquely identifies the recurring detail.
        /// </summary>
        /// <value>The reference that uniquely identifies the recurring detail.</value>
        [DataMember(Name="recurringDetailReference", EmitDefaultValue=false)]
        public string RecurringDetailReference { get; set; }

        /// <summary>
        /// Contains information on previously stored payment details.
        /// </summary>
        /// <value>Contains information on previously stored payment details.</value>
        [DataMember(Name="storedDetails", EmitDefaultValue=false)]
        public StoredDetails StoredDetails { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecurringDetail {\n");
            sb.Append("  Configuration: ").Append(Configuration).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PaymentMethodData: ").Append(PaymentMethodData).Append("\n");
            sb.Append("  RecurringDetailReference: ").Append(RecurringDetailReference).Append("\n");
            sb.Append("  StoredDetails: ").Append(StoredDetails).Append("\n");
            sb.Append("  SupportsRecurring: ").Append(SupportsRecurring).Append("\n");
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
            return this.Equals(input as RecurringDetail);
        }

        /// <summary>
        /// Returns true if RecurringDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of RecurringDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecurringDetail input)
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
                    this.RecurringDetailReference == input.RecurringDetailReference ||
                    (this.RecurringDetailReference != null &&
                    this.RecurringDetailReference.Equals(input.RecurringDetailReference))
                ) && 
                (
                    this.StoredDetails == input.StoredDetails ||
                    (this.StoredDetails != null &&
                    this.StoredDetails.Equals(input.StoredDetails))
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
                if (this.RecurringDetailReference != null)
                    hashCode = hashCode * 59 + this.RecurringDetailReference.GetHashCode();
                if (this.StoredDetails != null)
                    hashCode = hashCode * 59 + this.StoredDetails.GetHashCode();
                if (this.SupportsRecurring != null)
                    hashCode = hashCode * 59 + this.SupportsRecurring.GetHashCode();
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
