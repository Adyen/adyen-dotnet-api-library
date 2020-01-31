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
using Newtonsoft.Json.Converters;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// FieldType
    /// </summary>
    [DataContract]
    public class FieldType : IEquatable<FieldType>, IValidatableObject
    {
        /// <summary>
        /// The type of the field.
        /// </summary>
        /// <value>The type of the field.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FieldNameEnum
        {
            /// <summary>
            /// Enum AccountCode for value: accountCode
            /// </summary>
            [EnumMember(Value = "accountCode")]
            AccountCode = 1,
            /// <summary>
            /// Enum AccountHolderCode for value: accountHolderCode
            /// </summary>
            [EnumMember(Value = "accountHolderCode")]
            AccountHolderCode = 2,
            /// <summary>
            /// Enum AccountHolderDetails for value: accountHolderDetails
            /// </summary>
            [EnumMember(Value = "accountHolderDetails")]
            AccountHolderDetails = 3,
            /// <summary>
            /// Enum AccountNumber for value: accountNumber
            /// </summary>
            [EnumMember(Value = "accountNumber")]
            AccountNumber = 4,
            /// <summary>
            /// Enum AccountStateType for value: accountStateType
            /// </summary>
            [EnumMember(Value = "accountStateType")]
            AccountStateType = 5,
            /// <summary>
            /// Enum AccountStatus for value: accountStatus
            /// </summary>
            [EnumMember(Value = "accountStatus")]
            AccountStatus = 6,
            /// <summary>
            /// Enum AccountType for value: accountType
            /// </summary>
            [EnumMember(Value = "accountType")]
            AccountType = 7,
            /// <summary>
            /// Enum Address for value: address
            /// </summary>
            [EnumMember(Value = "address")]
            Address = 8,
            /// <summary>
            /// Enum BankAccount for value: bankAccount
            /// </summary>
            [EnumMember(Value = "bankAccount")]
            BankAccount = 9,
            /// <summary>
            /// Enum BankAccountCode for value: bankAccountCode
            /// </summary>
            [EnumMember(Value = "bankAccountCode")]
            BankAccountCode = 10,
            /// <summary>
            /// Enum BankAccountName for value: bankAccountName
            /// </summary>
            [EnumMember(Value = "bankAccountName")]
            BankAccountName = 11,
            /// <summary>
            /// Enum BankAccountUUID for value: bankAccountUUID
            /// </summary>
            [EnumMember(Value = "bankAccountUUID")]
            BankAccountUUID = 12,
            /// <summary>
            /// Enum BankBicSwift for value: bankBicSwift
            /// </summary>
            [EnumMember(Value = "bankBicSwift")]
            BankBicSwift = 13,
            /// <summary>
            /// Enum BankCity for value: bankCity
            /// </summary>
            [EnumMember(Value = "bankCity")]
            BankCity = 14,
            /// <summary>
            /// Enum BankCode for value: bankCode
            /// </summary>
            [EnumMember(Value = "bankCode")]
            BankCode = 15,
            /// <summary>
            /// Enum BankName for value: bankName
            /// </summary>
            [EnumMember(Value = "bankName")]
            BankName = 16,
            /// <summary>
            /// Enum BankStatement for value: bankStatement
            /// </summary>
            [EnumMember(Value = "bankStatement")]
            BankStatement = 17,
            /// <summary>
            /// Enum BranchCode for value: branchCode
            /// </summary>
            [EnumMember(Value = "branchCode")]
            BranchCode = 18,
            /// <summary>
            /// Enum BusinessContact for value: businessContact
            /// </summary>
            [EnumMember(Value = "businessContact")]
            BusinessContact = 19,
            /// <summary>
            /// Enum CardToken for value: cardToken
            /// </summary>
            [EnumMember(Value = "cardToken")]
            CardToken = 20,
            /// <summary>
            /// Enum CheckCode for value: checkCode
            /// </summary>
            [EnumMember(Value = "checkCode")]
            CheckCode = 21,
            /// <summary>
            /// Enum City for value: city
            /// </summary>
            [EnumMember(Value = "city")]
            City = 22,
            /// <summary>
            /// Enum Country for value: country
            /// </summary>
            [EnumMember(Value = "country")]
            Country = 23,
            /// <summary>
            /// Enum CountryCode for value: countryCode
            /// </summary>
            [EnumMember(Value = "countryCode")]
            CountryCode = 24,
            /// <summary>
            /// Enum Currency for value: currency
            /// </summary>
            [EnumMember(Value = "currency")]
            Currency = 25,
            /// <summary>
            /// Enum CurrencyCode for value: currencyCode
            /// </summary>
            [EnumMember(Value = "currencyCode")]
            CurrencyCode = 26,
            /// <summary>
            /// Enum DateOfBirth for value: dateOfBirth
            /// </summary>
            [EnumMember(Value = "dateOfBirth")]
            DateOfBirth = 27,
            /// <summary>
            /// Enum Description for value: description
            /// </summary>
            [EnumMember(Value = "description")]
            Description = 28,
            /// <summary>
            /// Enum DestinationAccountCode for value: destinationAccountCode
            /// </summary>
            [EnumMember(Value = "destinationAccountCode")]
            DestinationAccountCode = 29,
            /// <summary>
            /// Enum Document for value: document
            /// </summary>
            [EnumMember(Value = "document")]
            Document = 30,
            /// <summary>
            /// Enum DocumentExpirationDate for value: documentExpirationDate
            /// </summary>
            [EnumMember(Value = "documentExpirationDate")]
            DocumentExpirationDate = 31,
            /// <summary>
            /// Enum DocumentIssuerCountry for value: documentIssuerCountry
            /// </summary>
            [EnumMember(Value = "documentIssuerCountry")]
            DocumentIssuerCountry = 32,
            /// <summary>
            /// Enum DocumentIssuerState for value: documentIssuerState
            /// </summary>
            [EnumMember(Value = "documentIssuerState")]
            DocumentIssuerState = 33,
            /// <summary>
            /// Enum DocumentName for value: documentName
            /// </summary>
            [EnumMember(Value = "documentName")]
            DocumentName = 34,
            /// <summary>
            /// Enum DocumentNumber for value: documentNumber
            /// </summary>
            [EnumMember(Value = "documentNumber")]
            DocumentNumber = 35,
            /// <summary>
            /// Enum DocumentType for value: documentType
            /// </summary>
            [EnumMember(Value = "documentType")]
            DocumentType = 36,
            /// <summary>
            /// Enum DoingBusinessAs for value: doingBusinessAs
            /// </summary>
            [EnumMember(Value = "doingBusinessAs")]
            DoingBusinessAs = 37,
            /// <summary>
            /// Enum DrivingLicence for value: drivingLicence
            /// </summary>
            [EnumMember(Value = "drivingLicence")]
            DrivingLicence = 38,
            /// <summary>
            /// Enum DrivingLicenceBack for value: drivingLicenceBack
            /// </summary>
            [EnumMember(Value = "drivingLicenceBack")]
            DrivingLicenceBack = 39,
            /// <summary>
            /// Enum DrivingLicense for value: drivingLicense
            /// </summary>
            [EnumMember(Value = "drivingLicense")]
            DrivingLicense = 40,
            /// <summary>
            /// Enum Email for value: email
            /// </summary>
            [EnumMember(Value = "email")]
            Email = 41,
            /// <summary>
            /// Enum FirstName for value: firstName
            /// </summary>
            [EnumMember(Value = "firstName")]
            FirstName = 42,
            /// <summary>
            /// Enum FullPhoneNumber for value: fullPhoneNumber
            /// </summary>
            [EnumMember(Value = "fullPhoneNumber")]
            FullPhoneNumber = 43,
            /// <summary>
            /// Enum Gender for value: gender
            /// </summary>
            [EnumMember(Value = "gender")]
            Gender = 44,
            /// <summary>
            /// Enum HopWebserviceUser for value: hopWebserviceUser
            /// </summary>
            [EnumMember(Value = "hopWebserviceUser")]
            HopWebserviceUser = 45,
            /// <summary>
            /// Enum HouseNumberOrName for value: houseNumberOrName
            /// </summary>
            [EnumMember(Value = "houseNumberOrName")]
            HouseNumberOrName = 46,
            /// <summary>
            /// Enum Iban for value: iban
            /// </summary>
            [EnumMember(Value = "iban")]
            Iban = 47,
            /// <summary>
            /// Enum IdCard for value: idCard
            /// </summary>
            [EnumMember(Value = "idCard")]
            IdCard = 48,
            /// <summary>
            /// Enum IdCardBack for value: idCardBack
            /// </summary>
            [EnumMember(Value = "idCardBack")]
            IdCardBack = 49,
            /// <summary>
            /// Enum IdCardFront for value: idCardFront
            /// </summary>
            [EnumMember(Value = "idCardFront")]
            IdCardFront = 50,
            /// <summary>
            /// Enum IdNumber for value: idNumber
            /// </summary>
            [EnumMember(Value = "idNumber")]
            IdNumber = 51,
            /// <summary>
            /// Enum IdentityDocument for value: identityDocument
            /// </summary>
            [EnumMember(Value = "identityDocument")]
            IdentityDocument = 52,
            /// <summary>
            /// Enum IncorporatedAt for value: incorporatedAt
            /// </summary>
            [EnumMember(Value = "incorporatedAt")]
            IncorporatedAt = 53,
            /// <summary>
            /// Enum IndividualDetails for value: individualDetails
            /// </summary>
            [EnumMember(Value = "individualDetails")]
            IndividualDetails = 54,
            /// <summary>
            /// Enum LastName for value: lastName
            /// </summary>
            [EnumMember(Value = "lastName")]
            LastName = 55,
            /// <summary>
            /// Enum LegalBusinessName for value: legalBusinessName
            /// </summary>
            [EnumMember(Value = "legalBusinessName")]
            LegalBusinessName = 56,
            /// <summary>
            /// Enum LegalEntity for value: legalEntity
            /// </summary>
            [EnumMember(Value = "legalEntity")]
            LegalEntity = 57,
            /// <summary>
            /// Enum LegalEntityType for value: legalEntityType
            /// </summary>
            [EnumMember(Value = "legalEntityType")]
            LegalEntityType = 58,
            /// <summary>
            /// Enum MerchantAccount for value: merchantAccount
            /// </summary>
            [EnumMember(Value = "merchantAccount")]
            MerchantAccount = 59,
            /// <summary>
            /// Enum MerchantCategoryCode for value: merchantCategoryCode
            /// </summary>
            [EnumMember(Value = "merchantCategoryCode")]
            MerchantCategoryCode = 60,
            /// <summary>
            /// Enum MerchantReference for value: merchantReference
            /// </summary>
            [EnumMember(Value = "merchantReference")]
            MerchantReference = 61,
            /// <summary>
            /// Enum MicroDeposit for value: microDeposit
            /// </summary>
            [EnumMember(Value = "microDeposit")]
            MicroDeposit = 62,
            /// <summary>
            /// Enum Name for value: name
            /// </summary>
            [EnumMember(Value = "name")]
            Name = 63,
            /// <summary>
            /// Enum Nationality for value: nationality
            /// </summary>
            [EnumMember(Value = "nationality")]
            Nationality = 64,
            /// <summary>
            /// Enum OriginalReference for value: originalReference
            /// </summary>
            [EnumMember(Value = "originalReference")]
            OriginalReference = 65,
            /// <summary>
            /// Enum OwnerCity for value: ownerCity
            /// </summary>
            [EnumMember(Value = "ownerCity")]
            OwnerCity = 66,
            /// <summary>
            /// Enum OwnerCountryCode for value: ownerCountryCode
            /// </summary>
            [EnumMember(Value = "ownerCountryCode")]
            OwnerCountryCode = 67,
            /// <summary>
            /// Enum OwnerHouseNumberOrName for value: ownerHouseNumberOrName
            /// </summary>
            [EnumMember(Value = "ownerHouseNumberOrName")]
            OwnerHouseNumberOrName = 68,
            /// <summary>
            /// Enum OwnerName for value: ownerName
            /// </summary>
            [EnumMember(Value = "ownerName")]
            OwnerName = 69,
            /// <summary>
            /// Enum OwnerPostalCode for value: ownerPostalCode
            /// </summary>
            [EnumMember(Value = "ownerPostalCode")]
            OwnerPostalCode = 70,
            /// <summary>
            /// Enum OwnerState for value: ownerState
            /// </summary>
            [EnumMember(Value = "ownerState")]
            OwnerState = 71,
            /// <summary>
            /// Enum OwnerStreet for value: ownerStreet
            /// </summary>
            [EnumMember(Value = "ownerStreet")]
            OwnerStreet = 72,
            /// <summary>
            /// Enum Passport for value: passport
            /// </summary>
            [EnumMember(Value = "passport")]
            Passport = 73,
            /// <summary>
            /// Enum PassportNumber for value: passportNumber
            /// </summary>
            [EnumMember(Value = "passportNumber")]
            PassportNumber = 74,
            /// <summary>
            /// Enum PayoutMethodCode for value: payoutMethodCode
            /// </summary>
            [EnumMember(Value = "payoutMethodCode")]
            PayoutMethodCode = 75,
            /// <summary>
            /// Enum PersonalData for value: personalData
            /// </summary>
            [EnumMember(Value = "personalData")]
            PersonalData = 76,
            /// <summary>
            /// Enum PhoneCountryCode for value: phoneCountryCode
            /// </summary>
            [EnumMember(Value = "phoneCountryCode")]
            PhoneCountryCode = 77,
            /// <summary>
            /// Enum PhoneNumber for value: phoneNumber
            /// </summary>
            [EnumMember(Value = "phoneNumber")]
            PhoneNumber = 78,
            /// <summary>
            /// Enum PostalCode for value: postalCode
            /// </summary>
            [EnumMember(Value = "postalCode")]
            PostalCode = 79,
            /// <summary>
            /// Enum PrimaryCurrency for value: primaryCurrency
            /// </summary>
            [EnumMember(Value = "primaryCurrency")]
            PrimaryCurrency = 80,
            /// <summary>
            /// Enum Reason for value: reason
            /// </summary>
            [EnumMember(Value = "reason")]
            Reason = 81,
            /// <summary>
            /// Enum RegistrationNumber for value: registrationNumber
            /// </summary>
            [EnumMember(Value = "registrationNumber")]
            RegistrationNumber = 82,
            /// <summary>
            /// Enum ReturnUrl for value: returnUrl
            /// </summary>
            [EnumMember(Value = "returnUrl")]
            ReturnUrl = 83,
            /// <summary>
            /// Enum Schedule for value: schedule
            /// </summary>
            [EnumMember(Value = "schedule")]
            Schedule = 84,
            /// <summary>
            /// Enum Shareholder for value: shareholder
            /// </summary>
            [EnumMember(Value = "shareholder")]
            Shareholder = 85,
            /// <summary>
            /// Enum ShareholderCode for value: shareholderCode
            /// </summary>
            [EnumMember(Value = "shareholderCode")]
            ShareholderCode = 86,
            /// <summary>
            /// Enum SocialSecurityNumber for value: socialSecurityNumber
            /// </summary>
            [EnumMember(Value = "socialSecurityNumber")]
            SocialSecurityNumber = 87,
            /// <summary>
            /// Enum SourceAccountCode for value: sourceAccountCode
            /// </summary>
            [EnumMember(Value = "sourceAccountCode")]
            SourceAccountCode = 88,
            /// <summary>
            /// Enum StateOrProvince for value: stateOrProvince
            /// </summary>
            [EnumMember(Value = "stateOrProvince")]
            StateOrProvince = 89,
            /// <summary>
            /// Enum Status for value: status
            /// </summary>
            [EnumMember(Value = "status")]
            Status = 90,
            /// <summary>
            /// Enum Store for value: store
            /// </summary>
            [EnumMember(Value = "store")]
            Store = 91,
            /// <summary>
            /// Enum StoreDetail for value: storeDetail
            /// </summary>
            [EnumMember(Value = "storeDetail")]
            StoreDetail = 92,
            /// <summary>
            /// Enum StoreReference for value: storeReference
            /// </summary>
            [EnumMember(Value = "storeReference")]
            StoreReference = 93,
            /// <summary>
            /// Enum Street for value: street
            /// </summary>
            [EnumMember(Value = "street")]
            Street = 94,
            /// <summary>
            /// Enum TaxId for value: taxId
            /// </summary>
            [EnumMember(Value = "taxId")]
            TaxId = 95,
            /// <summary>
            /// Enum Tier for value: tier
            /// </summary>
            [EnumMember(Value = "tier")]
            Tier = 96,
            /// <summary>
            /// Enum TierNumber for value: tierNumber
            /// </summary>
            [EnumMember(Value = "tierNumber")]
            TierNumber = 97,
            /// <summary>
            /// Enum TransferCode for value: transferCode
            /// </summary>
            [EnumMember(Value = "transferCode")]
            TransferCode = 98,
            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown = 99,
            /// <summary>
            /// Enum Value for value: value
            /// </summary>
            [EnumMember(Value = "value")]
            Value = 100,
            /// <summary>
            /// Enum VirtualAccount for value: virtualAccount
            /// </summary>
            [EnumMember(Value = "virtualAccount")]
            VirtualAccount = 101,
            /// <summary>
            /// Enum VisaNumber for value: visaNumber
            /// </summary>
            [EnumMember(Value = "visaNumber")]
            VisaNumber = 102,
            /// <summary>
            /// Enum WebAddress for value: webAddress
            /// </summary>
            [EnumMember(Value = "webAddress")]
            WebAddress = 103
        }
        /// <summary>
        /// The type of the field.
        /// </summary>
        /// <value>The type of the field.</value>
        [DataMember(Name = "fieldName", EmitDefaultValue = false)]
        public FieldNameEnum? FieldName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldType" /> class.
        /// </summary>
        /// <param name="field">The full name of the property..</param>
        /// <param name="fieldName">The type of the field..</param>
        /// <param name="shareholderCode">The code of the shareholder that the field belongs to. If empty, the field belongs to an account holder..</param>
        public FieldType(string field = default(string), FieldNameEnum? fieldName = default(FieldNameEnum?), string shareholderCode = default(string))
        {
            this.Field = field;
            this.FieldName = fieldName;
            this.ShareholderCode = shareholderCode;
        }

        /// <summary>
        /// The full name of the property.
        /// </summary>
        /// <value>The full name of the property.</value>
        [DataMember(Name = "field", EmitDefaultValue = false)]
        public string Field { get; set; }


        /// <summary>
        /// The code of the shareholder that the field belongs to. If empty, the field belongs to an account holder.
        /// </summary>
        /// <value>The code of the shareholder that the field belongs to. If empty, the field belongs to an account holder.</value>
        [DataMember(Name = "shareholderCode", EmitDefaultValue = false)]
        public string ShareholderCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldType {\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  ShareholderCode: ").Append(ShareholderCode).Append("\n");
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
            return this.Equals(input as FieldType);
        }

        /// <summary>
        /// Returns true if FieldType instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldType input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Field == input.Field ||
                    (this.Field != null &&
                    this.Field.Equals(input.Field))
                ) &&
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) &&
                (
                    this.ShareholderCode == input.ShareholderCode ||
                    (this.ShareholderCode != null &&
                    this.ShareholderCode.Equals(input.ShareholderCode))
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
                if (this.Field != null)
                    hashCode = hashCode * 59 + this.Field.GetHashCode();
                if (this.FieldName != null)
                    hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.ShareholderCode != null)
                    hashCode = hashCode * 59 + this.ShareholderCode.GetHashCode();
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
