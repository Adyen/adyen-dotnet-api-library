using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.EcommLibrary.Model.Checkout
{
    /// <summary>
    /// DefaultPaymentMethodDetails
    /// </summary>
    [DataContract]
    public class DefaultPaymentMethodDetails
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


    }
}
