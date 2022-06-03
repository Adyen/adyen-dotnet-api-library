// #region License
// 
//                         ######
//                         ######
//   ############    ####( ######  #####. ######  ############   ############
//   #############  #####( ######  #####. ######  #############  #############
//          ######  #####( ######  #####. ######  #####  ######  #####  ######
//   ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//   ###### ######  #####( ######  #####. ######  #####          #####  ######
//   #############  #############  #############  #############  #####  ######
//    ############   ############  #############   ############  #####  ######
//                                        ######
//                                 #############
//                                 ############
// 
//   Adyen Dotnet API Library
// 
//   Copyright (c) 2022 Adyen N.V.
//   This file is open source and available under the MIT license.
//   See the LICENSE file for more info.
// 
// #endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout.Details
{
    /// <summary>
    /// AfterpayDetails
    /// </summary>
    [DataContract]
    public partial class AfterpayDetails : IEquatable<AfterpayDetails>, IValidatableObject, IPaymentMethodDetails
    {
        //Possible types
        public const string AfterpayDefault = "afterpay_default";
        public const string AfterpayTouch = "afterpaytouch";
        public const string Afterpayb2b = "afterpay_b2b";


        /// <summary>
        /// **ach**
        /// </summary>
        /// <value>**ach**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AfterpayDetails" /> class.
        /// </summary>
        /// <param name="billingAddress">The address where to send the invoice..</param>
        /// <param name="deliveryAddress">The address where the goods should be delivered..</param>
        /// <param name="personalDetails">Shopper name, date of birth, phone number, and email address..</param>
        /// <param name="recurringDetailReference">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
        /// <param name="storedPaymentMethodId">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
        /// <param name="type">**afterpay_default** (required) (default to TypeEnum.Afterpaydefault).</param>
        public AfterpayDetails(string billingAddress = default(string), string deliveryAddress = default(string),
            string personalDetails = default(string), string recurringDetailReference = default(string),
            string storedPaymentMethodId = default(string), string type = default(string))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for AfterpayDetails and cannot be null");
            }
            else
            {
                this.Type = type;
            }

            this.BillingAddress = billingAddress;
            this.DeliveryAddress = deliveryAddress;
            this.PersonalDetails = personalDetails;
            this.RecurringDetailReference = recurringDetailReference;
            this.StoredPaymentMethodId = storedPaymentMethodId;
        }

        /// <summary>
        /// The address where to send the invoice.
        /// </summary>
        /// <value>The address where to send the invoice.</value>
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        public string BillingAddress { get; set; }

        /// <summary>
        /// The address where the goods should be delivered.
        /// </summary>
        /// <value>The address where the goods should be delivered.</value>
        [DataMember(Name = "deliveryAddress", EmitDefaultValue = false)]
        public string DeliveryAddress { get; set; }

        /// <summary>
        /// Shopper name, date of birth, phone number, and email address.
        /// </summary>
        /// <value>Shopper name, date of birth, phone number, and email address.</value>
        [DataMember(Name = "personalDetails", EmitDefaultValue = false)]
        public string PersonalDetails { get; set; }

        /// <summary>
        /// This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.
        /// </summary>
        /// <value>This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.</value>
        [DataMember(Name = "recurringDetailReference", EmitDefaultValue = false)]
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
            var sb = new StringBuilder();
            sb.Append("class AfterpayDetails {\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  DeliveryAddress: ").Append(DeliveryAddress).Append("\n");
            sb.Append("  PersonalDetails: ").Append(PersonalDetails).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AfterpayDetails);
        }

        /// <summary>
        /// Returns true if AfterpayDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of AfterpayDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AfterpayDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                     this.BillingAddress.Equals(input.BillingAddress))
                ) &&
                (
                    this.DeliveryAddress == input.DeliveryAddress ||
                    (this.DeliveryAddress != null &&
                     this.DeliveryAddress.Equals(input.DeliveryAddress))
                ) &&
                (
                    this.PersonalDetails == input.PersonalDetails ||
                    (this.PersonalDetails != null &&
                     this.PersonalDetails.Equals(input.PersonalDetails))
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
                if (this.BillingAddress != null)
                    hashCode = hashCode * 59 + this.BillingAddress.GetHashCode();
                if (this.DeliveryAddress != null)
                    hashCode = hashCode * 59 + this.DeliveryAddress.GetHashCode();
                if (this.PersonalDetails != null)
                    hashCode = hashCode * 59 + this.PersonalDetails.GetHashCode();
                if (this.RecurringDetailReference != null)
                    hashCode = hashCode * 59 + this.RecurringDetailReference.GetHashCode();
                if (this.StoredPaymentMethodId != null)
                    hashCode = hashCode * 59 + this.StoredPaymentMethodId.GetHashCode();
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(
            ValidationContext validationContext)
        {
            yield break;
        }
    }
}