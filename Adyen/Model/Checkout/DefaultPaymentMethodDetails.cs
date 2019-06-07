using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// DefaultPaymentMethodDetails
    /// </summary>
    [DataContract]
    public class DefaultPaymentMethodDetails : IValidatableObject
    {
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }
        [DataMember(Name = "number", EmitDefaultValue = false)]
        public string Number { get; set; }
        [DataMember(Name = "expiryMonth", EmitDefaultValue = false)]
        public string ExpiryMonth { get; set; }
        [DataMember(Name = "expiryYear", EmitDefaultValue = false)]
        public string ExpiryYear { get; set; }
        [DataMember(Name = "holderName", EmitDefaultValue = false)]
        public string HolderName { get; set; }
        [DataMember(Name = "cvc", EmitDefaultValue = false)]
        public string Cvc { get; set; }
        [DataMember(Name = "installmentConfigurationKey", EmitDefaultValue = false)]
        public string InstallmentConfigurationKey { get; set; }
        [DataMember(Name = "personalDetails", EmitDefaultValue = false)]
        public PersonalDetails PersonalDetails { get; set; }
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        public Address BillingAddress { get; set; }
        [DataMember(Name = "deliveryAddress", EmitDefaultValue = false)]
        public Address DeliveryAddress { get; set; }
        [DataMember(Name = "encryptedCardNumber", EmitDefaultValue = false)]
        public string EncryptedCardNumber { get; set; }
        [DataMember(Name = "encryptedExpiryMonth", EmitDefaultValue = false)]
        public string EncryptedExpiryMonth { get; set; }
        [DataMember(Name = "encryptedExpiryYear", EmitDefaultValue = false)]
        public string EncryptedExpiryYear { get; set; }
        [DataMember(Name = "encryptedSecurityCode", EmitDefaultValue = false)]
        public string EncryptedSecurityCode { get; set; }
        [DataMember(Name = "recurringDetailReference", EmitDefaultValue = false)]
        public string RecurringDetailReference { get; set; }
        [DataMember(Name = "storeDetails", EmitDefaultValue = false)]
        public bool StoreDetails { get; set; }
        [DataMember(Name = "idealIssuer", EmitDefaultValue = false)]
        public string IdealIssuer { get; set; }


        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PermitRestriction {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  ExpiryMonth: ").Append(ExpiryMonth).Append("\n");
            sb.Append("  ExpiryYear: ").Append(ExpiryYear).Append("\n");
            sb.Append("  HolderName: ").Append(HolderName).Append("\n");
            sb.Append("  Cvc: ").Append(Cvc).Append("\n");
            sb.Append("  InstallmentConfigurationKey: ").Append(InstallmentConfigurationKey).Append("\n");
            sb.Append("  PersonalDetails: ").Append(PersonalDetails).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  DeliveryAddress: ").Append(DeliveryAddress).Append("\n");
            sb.Append("  EncryptedCardNumber: ").Append(EncryptedCardNumber).Append("\n");
            sb.Append("  EncryptedExpiryMonth: ").Append(EncryptedExpiryMonth).Append("\n");
            sb.Append("  EncryptedExpiryYear: ").Append(EncryptedExpiryYear).Append("\n");
            sb.Append("  EncryptedSecurityCode: ").Append(EncryptedSecurityCode).Append("\n");
            sb.Append("  RecurringDetailReference: ").Append(RecurringDetailReference).Append("\n");
            sb.Append("  StoreDetails: ").Append(StoreDetails).Append("\n");
            sb.Append("  IdealIssuer: ").Append(IdealIssuer).Append("\n");
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
            return this.Equals(input as DefaultPaymentMethodDetails);
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
