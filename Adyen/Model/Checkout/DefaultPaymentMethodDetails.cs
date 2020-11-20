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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// DefaultPaymentMethodDetails
    /// </summary>
    [DataContract]
    public class DefaultPaymentMethodDetails : IValidatableObject, IPaymentMethodDetails
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
        [Obsolete("Deprecated. Use StoredPaymentMethodId instead")]
        [DataMember(Name = "recurringDetailReference", EmitDefaultValue = false)]
        public string RecurringDetailReference { get; set; }
        [DataMember(Name = "storedPaymentMethodId", EmitDefaultValue = false)]
        public string StoredPaymentMethodId { get; set; }
        [DataMember(Name = "storeDetails", EmitDefaultValue = false)]
        public bool StoreDetails { get; set; }
        [DataMember(Name = "issuer", EmitDefaultValue = false)]
        public string Issuer { get; set; }
        [DataMember(Name = "sepa.ownerName", EmitDefaultValue = false)]
        public string SepaOwnerName { get; set; }
        [DataMember(Name = "sepa.ibanNumber", EmitDefaultValue = false)]
        public string SepaIbanNumber { get; set; }
        [DataMember(Name = "bankAccount", EmitDefaultValue = false)]
        public BankAccount BankAccount { get; set; }
        [DataMember(Name = "applepay.token", EmitDefaultValue = false)]
        public string ApplePayToken { get; set; }
        [DataMember(Name = "paywithgoogle.token", EmitDefaultValue = false)]
        public string GooglePayToken { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DefaultPaymentMethodDetails {\n");
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
#pragma warning disable 618
            sb.Append("  RecurringDetailReference: ").Append(RecurringDetailReference).Append("\n");
#pragma warning restore 618
            sb.Append("  StoredPaymentMethodId: ").Append(StoredPaymentMethodId).Append("\n");
            sb.Append("  StoreDetails: ").Append(StoreDetails).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  SepaOwnerName: ").Append(SepaOwnerName).Append("\n");
            sb.Append("  SepaIbanNumber: ").Append(SepaIbanNumber).Append("\n");
            sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
            sb.Append("  ApplePayToken: ").Append(BankAccount).Append("\n");
            sb.Append("  GooglePayToken: ").Append(BankAccount).Append("\n");
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
        /// Returns true if DefaultPaymentMethodDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of DefaultPaymentMethodDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DefaultPaymentMethodDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) &&
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) &&
                (
                    this.ExpiryMonth == input.ExpiryMonth ||
                    (this.ExpiryMonth != null &&
                    this.ExpiryMonth.Equals(input.ExpiryMonth))
                ) &&
                (
                    this.ExpiryYear == input.ExpiryYear ||
                    (this.ExpiryYear != null &&
                    this.ExpiryYear.Equals(input.ExpiryYear))
                ) &&
                (
                    this.HolderName == input.HolderName ||
                    (this.HolderName != null &&
                    this.HolderName.Equals(input.HolderName))
                ) &&
                (
                    this.Cvc == input.Cvc ||
                    (this.Cvc != null &&
                    this.Cvc.Equals(input.Cvc))
                ) &&
                (
                    this.InstallmentConfigurationKey == input.InstallmentConfigurationKey ||
                    (this.InstallmentConfigurationKey != null &&
                    this.InstallmentConfigurationKey.Equals(input.InstallmentConfigurationKey))
                ) &&
                (
                    this.PersonalDetails == input.PersonalDetails ||
                    (this.PersonalDetails != null &&
                    this.PersonalDetails.Equals(input.PersonalDetails))
                ) &&
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
                    this.EncryptedCardNumber == input.EncryptedCardNumber ||
                    (this.EncryptedCardNumber != null &&
                    this.EncryptedCardNumber.Equals(input.EncryptedCardNumber))
                ) &&
                (
                    this.EncryptedExpiryMonth == input.EncryptedExpiryMonth ||
                    (this.EncryptedExpiryMonth != null &&
                    this.EncryptedExpiryMonth.Equals(input.EncryptedExpiryMonth))
                ) &&
                (
                    this.EncryptedExpiryYear == input.EncryptedExpiryYear ||
                    (this.EncryptedExpiryYear != null &&
                    this.EncryptedExpiryYear.Equals(input.EncryptedExpiryYear))
                ) &&
                (
                    this.EncryptedSecurityCode == input.EncryptedSecurityCode ||
                    (this.EncryptedSecurityCode != null &&
                    this.EncryptedSecurityCode.Equals(input.EncryptedSecurityCode))
                ) &&
                (
#pragma warning disable CS0618 // Type or member is obsolete
                    this.RecurringDetailReference == input.RecurringDetailReference ||
                    (this.RecurringDetailReference != null &&
                     this.RecurringDetailReference.Equals(input.RecurringDetailReference))
#pragma warning restore CS0618 // Type or member is obsolete

                ) &&
                (
                    this.StoredPaymentMethodId == input.StoredPaymentMethodId ||
                    (this.StoredPaymentMethodId != null &&
                     this.StoredPaymentMethodId.Equals(input.StoredPaymentMethodId))
                ) &&
                (
                    this.StoreDetails == input.StoreDetails ||
                    (this.StoreDetails.Equals(input.StoreDetails))
                ) &&
                (
                    this.Issuer == input.Issuer ||
                    (this.Issuer != null &&
                    this.Issuer.Equals(input.Issuer))
                ) &&
                (
                    this.SepaOwnerName == input.SepaOwnerName ||
                    (this.SepaOwnerName != null &&
                    this.SepaOwnerName.Equals(input.SepaOwnerName))
                ) &&
                (
                    this.SepaIbanNumber == input.SepaIbanNumber ||
                    (this.SepaIbanNumber != null &&
                    this.SepaIbanNumber.Equals(input.SepaIbanNumber))
                ) &&
                (
                    this.BankAccount == input.BankAccount ||
                    (this.BankAccount != null &&
                    this.BankAccount.Equals(input.BankAccount))
                ) &&
                (
                    this.ApplePayToken == input.ApplePayToken ||
                    (this.ApplePayToken != null &&
                    this.ApplePayToken.Equals(input.ApplePayToken))
                ) &&
                (
                    this.GooglePayToken == input.GooglePayToken ||
                    (this.GooglePayToken != null &&
                    this.GooglePayToken.Equals(input.GooglePayToken))
                );
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


        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.ExpiryMonth != null)
                    hashCode = hashCode * 59 + this.ExpiryMonth.GetHashCode();
                if (this.ExpiryYear != null)
                    hashCode = hashCode * 59 + this.ExpiryYear.GetHashCode();
                if (this.HolderName != null)
                    hashCode = hashCode * 59 + this.HolderName.GetHashCode();
                if (this.Cvc != null)
                    hashCode = hashCode * 59 + this.Cvc.GetHashCode();
                if (this.InstallmentConfigurationKey != null)
                    hashCode = hashCode * 59 + this.InstallmentConfigurationKey.GetHashCode();
                if (this.PersonalDetails != null)
                    hashCode = hashCode * 59 + this.PersonalDetails.GetHashCode();
                if (this.BillingAddress != null)
                    hashCode = hashCode * 59 + this.BillingAddress.GetHashCode();
                if (this.DeliveryAddress != null)
                    hashCode = hashCode * 59 + this.DeliveryAddress.GetHashCode();
                if (this.EncryptedCardNumber != null)
                    hashCode = hashCode * 59 + this.EncryptedCardNumber.GetHashCode();
                if (this.EncryptedExpiryMonth != null)
                    hashCode = hashCode * 59 + this.EncryptedExpiryMonth.GetHashCode();
                if (this.EncryptedExpiryYear != null)
                    hashCode = hashCode * 59 + this.EncryptedExpiryYear.GetHashCode();
                if (this.EncryptedSecurityCode != null)
                    hashCode = hashCode * 59 + this.EncryptedSecurityCode.GetHashCode();
#pragma warning disable 618
                if (this.RecurringDetailReference != null)
                    hashCode = hashCode * 59 + this.RecurringDetailReference.GetHashCode();
#pragma warning restore 618
                if (this.StoredPaymentMethodId != null)
                    hashCode = hashCode * 59 + this.StoredPaymentMethodId.GetHashCode();
                hashCode = hashCode * 59 + this.StoreDetails.GetHashCode();
                if (this.Issuer != null)
                    hashCode = hashCode * 59 + this.Issuer.GetHashCode();
                if (this.SepaOwnerName != null)
                    hashCode = hashCode * 59 + this.SepaOwnerName.GetHashCode();
                if (this.SepaIbanNumber != null)
                    hashCode = hashCode * 59 + this.SepaIbanNumber.GetHashCode();
                if (this.BankAccount != null)
                    hashCode = hashCode * 59 + this.BankAccount.GetHashCode();
                if (this.Issuer != null)
                    hashCode = hashCode * 59 + this.Issuer.GetHashCode();
                if (this.ApplePayToken != null)
                    hashCode = hashCode * 59 + this.ApplePayToken.GetHashCode();
                if (this.GooglePayToken != null)
                    hashCode = hashCode * 59 + this.GooglePayToken.GetHashCode();
                return hashCode;
            }

        }
    }
}