#region License
/*
*                       ######
*                       ######
* ############    ####( ######  #####. ######  ############   ############
* #############  #####( ######  #####. ######  #############  #############
*        ######  #####( ######  #####. ######  #####  ######  #####  ######
* ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
* ###### ######  #####( ######  #####. ######  #####          #####  ######
* #############  #############  #############  #############  #####  ######
*  ############   ############  #############   ############  #####  ######
*                                      ######
*                               #############
*                               ############
*
* Adyen Dotnet API Library
*
* Copyright (c) 2021 Adyen B.V.
* This file is open source and available under the MIT license.
* See the LICENSE file for more info.
*/
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
  public partial class FieldType :  IEquatable<FieldType>, IValidatableObject
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
          /// Enum BalanceAccount for value: balanceAccount
          /// </summary>
          [EnumMember(Value = "balanceAccount")]
          BalanceAccount = 9,

          /// <summary>
          /// Enum BalanceAccountActive for value: balanceAccountActive
          /// </summary>
          [EnumMember(Value = "balanceAccountActive")]
          BalanceAccountActive = 10,

          /// <summary>
          /// Enum BalanceAccountCode for value: balanceAccountCode
          /// </summary>
          [EnumMember(Value = "balanceAccountCode")]
          BalanceAccountCode = 11,

          /// <summary>
          /// Enum BalanceAccountId for value: balanceAccountId
          /// </summary>
          [EnumMember(Value = "balanceAccountId")]
          BalanceAccountId = 12,

          /// <summary>
          /// Enum BankAccount for value: bankAccount
          /// </summary>
          [EnumMember(Value = "bankAccount")]
          BankAccount = 13,

          /// <summary>
          /// Enum BankAccountCode for value: bankAccountCode
          /// </summary>
          [EnumMember(Value = "bankAccountCode")]
          BankAccountCode = 14,

          /// <summary>
          /// Enum BankAccountName for value: bankAccountName
          /// </summary>
          [EnumMember(Value = "bankAccountName")]
          BankAccountName = 15,

          /// <summary>
          /// Enum BankAccountUUID for value: bankAccountUUID
          /// </summary>
          [EnumMember(Value = "bankAccountUUID")]
          BankAccountUUID = 16,

          /// <summary>
          /// Enum BankBicSwift for value: bankBicSwift
          /// </summary>
          [EnumMember(Value = "bankBicSwift")]
          BankBicSwift = 17,

          /// <summary>
          /// Enum BankCity for value: bankCity
          /// </summary>
          [EnumMember(Value = "bankCity")]
          BankCity = 18,

          /// <summary>
          /// Enum BankCode for value: bankCode
          /// </summary>
          [EnumMember(Value = "bankCode")]
          BankCode = 19,

          /// <summary>
          /// Enum BankName for value: bankName
          /// </summary>
          [EnumMember(Value = "bankName")]
          BankName = 20,

          /// <summary>
          /// Enum BankStatement for value: bankStatement
          /// </summary>
          [EnumMember(Value = "bankStatement")]
          BankStatement = 21,

          /// <summary>
          /// Enum BranchCode for value: branchCode
          /// </summary>
          [EnumMember(Value = "branchCode")]
          BranchCode = 22,

          /// <summary>
          /// Enum BusinessContact for value: businessContact
          /// </summary>
          [EnumMember(Value = "businessContact")]
          BusinessContact = 23,

          /// <summary>
          /// Enum CardToken for value: cardToken
          /// </summary>
          [EnumMember(Value = "cardToken")]
          CardToken = 24,

          /// <summary>
          /// Enum CheckCode for value: checkCode
          /// </summary>
          [EnumMember(Value = "checkCode")]
          CheckCode = 25,

          /// <summary>
          /// Enum City for value: city
          /// </summary>
          [EnumMember(Value = "city")]
          City = 26,

          /// <summary>
          /// Enum CompanyRegistration for value: companyRegistration
          /// </summary>
          [EnumMember(Value = "companyRegistration")]
          CompanyRegistration = 27,

          /// <summary>
          /// Enum ConstitutionalDocument for value: constitutionalDocument
          /// </summary>
          [EnumMember(Value = "constitutionalDocument")]
          ConstitutionalDocument = 28,

          /// <summary>
          /// Enum Country for value: country
          /// </summary>
          [EnumMember(Value = "country")]
          Country = 29,

          /// <summary>
          /// Enum CountryCode for value: countryCode
          /// </summary>
          [EnumMember(Value = "countryCode")]
          CountryCode = 30,

          /// <summary>
          /// Enum Currency for value: currency
          /// </summary>
          [EnumMember(Value = "currency")]
          Currency = 31,

          /// <summary>
          /// Enum CurrencyCode for value: currencyCode
          /// </summary>
          [EnumMember(Value = "currencyCode")]
          CurrencyCode = 32,

          /// <summary>
          /// Enum DateOfBirth for value: dateOfBirth
          /// </summary>
          [EnumMember(Value = "dateOfBirth")]
          DateOfBirth = 33,

          /// <summary>
          /// Enum Description for value: description
          /// </summary>
          [EnumMember(Value = "description")]
          Description = 34,

          /// <summary>
          /// Enum DestinationAccountCode for value: destinationAccountCode
          /// </summary>
          [EnumMember(Value = "destinationAccountCode")]
          DestinationAccountCode = 35,

          /// <summary>
          /// Enum Document for value: document
          /// </summary>
          [EnumMember(Value = "document")]
          Document = 36,

          /// <summary>
          /// Enum DocumentExpirationDate for value: documentExpirationDate
          /// </summary>
          [EnumMember(Value = "documentExpirationDate")]
          DocumentExpirationDate = 37,

          /// <summary>
          /// Enum DocumentIssuerCountry for value: documentIssuerCountry
          /// </summary>
          [EnumMember(Value = "documentIssuerCountry")]
          DocumentIssuerCountry = 38,

          /// <summary>
          /// Enum DocumentIssuerState for value: documentIssuerState
          /// </summary>
          [EnumMember(Value = "documentIssuerState")]
          DocumentIssuerState = 39,

          /// <summary>
          /// Enum DocumentName for value: documentName
          /// </summary>
          [EnumMember(Value = "documentName")]
          DocumentName = 40,

          /// <summary>
          /// Enum DocumentNumber for value: documentNumber
          /// </summary>
          [EnumMember(Value = "documentNumber")]
          DocumentNumber = 41,

          /// <summary>
          /// Enum DocumentType for value: documentType
          /// </summary>
          [EnumMember(Value = "documentType")]
          DocumentType = 42,

          /// <summary>
          /// Enum DoingBusinessAs for value: doingBusinessAs
          /// </summary>
          [EnumMember(Value = "doingBusinessAs")]
          DoingBusinessAs = 43,

          /// <summary>
          /// Enum DrivingLicence for value: drivingLicence
          /// </summary>
          [EnumMember(Value = "drivingLicence")]
          DrivingLicence = 44,

          /// <summary>
          /// Enum DrivingLicenceBack for value: drivingLicenceBack
          /// </summary>
          [EnumMember(Value = "drivingLicenceBack")]
          DrivingLicenceBack = 45,

          /// <summary>
          /// Enum DrivingLicense for value: drivingLicense
          /// </summary>
          [EnumMember(Value = "drivingLicense")]
          DrivingLicense = 46,

          /// <summary>
          /// Enum Email for value: email
          /// </summary>
          [EnumMember(Value = "email")]
          Email = 47,

          /// <summary>
          /// Enum FirstName for value: firstName
          /// </summary>
          [EnumMember(Value = "firstName")]
          FirstName = 48,

          /// <summary>
          /// Enum FormType for value: formType
          /// </summary>
          [EnumMember(Value = "formType")]
          FormType = 49,

          /// <summary>
          /// Enum FullPhoneNumber for value: fullPhoneNumber
          /// </summary>
          [EnumMember(Value = "fullPhoneNumber")]
          FullPhoneNumber = 50,

          /// <summary>
          /// Enum Gender for value: gender
          /// </summary>
          [EnumMember(Value = "gender")]
          Gender = 51,

          /// <summary>
          /// Enum HopWebserviceUser for value: hopWebserviceUser
          /// </summary>
          [EnumMember(Value = "hopWebserviceUser")]
          HopWebserviceUser = 52,

          /// <summary>
          /// Enum HouseNumberOrName for value: houseNumberOrName
          /// </summary>
          [EnumMember(Value = "houseNumberOrName")]
          HouseNumberOrName = 53,

          /// <summary>
          /// Enum Iban for value: iban
          /// </summary>
          [EnumMember(Value = "iban")]
          Iban = 54,

          /// <summary>
          /// Enum IdCard for value: idCard
          /// </summary>
          [EnumMember(Value = "idCard")]
          IdCard = 55,

          /// <summary>
          /// Enum IdCardBack for value: idCardBack
          /// </summary>
          [EnumMember(Value = "idCardBack")]
          IdCardBack = 56,

          /// <summary>
          /// Enum IdCardFront for value: idCardFront
          /// </summary>
          [EnumMember(Value = "idCardFront")]
          IdCardFront = 57,

          /// <summary>
          /// Enum IdNumber for value: idNumber
          /// </summary>
          [EnumMember(Value = "idNumber")]
          IdNumber = 58,

          /// <summary>
          /// Enum IdentityDocument for value: identityDocument
          /// </summary>
          [EnumMember(Value = "identityDocument")]
          IdentityDocument = 59,

          /// <summary>
          /// Enum IndividualDetails for value: individualDetails
          /// </summary>
          [EnumMember(Value = "individualDetails")]
          IndividualDetails = 60,

          /// <summary>
          /// Enum JobTitle for value: jobTitle
          /// </summary>
          [EnumMember(Value = "jobTitle")]
          JobTitle = 61,

          /// <summary>
          /// Enum LastName for value: lastName
          /// </summary>
          [EnumMember(Value = "lastName")]
          LastName = 62,

          /// <summary>
          /// Enum LastReviewDate for value: lastReviewDate
          /// </summary>
          [EnumMember(Value = "lastReviewDate")]
          LastReviewDate = 63,

          /// <summary>
          /// Enum LegalArrangement for value: legalArrangement
          /// </summary>
          [EnumMember(Value = "legalArrangement")]
          LegalArrangement = 64,

          /// <summary>
          /// Enum LegalArrangementCode for value: legalArrangementCode
          /// </summary>
          [EnumMember(Value = "legalArrangementCode")]
          LegalArrangementCode = 65,

          /// <summary>
          /// Enum LegalArrangementEntity for value: legalArrangementEntity
          /// </summary>
          [EnumMember(Value = "legalArrangementEntity")]
          LegalArrangementEntity = 66,

          /// <summary>
          /// Enum LegalArrangementEntityCode for value: legalArrangementEntityCode
          /// </summary>
          [EnumMember(Value = "legalArrangementEntityCode")]
          LegalArrangementEntityCode = 67,

          /// <summary>
          /// Enum LegalArrangementLegalForm for value: legalArrangementLegalForm
          /// </summary>
          [EnumMember(Value = "legalArrangementLegalForm")]
          LegalArrangementLegalForm = 68,

          /// <summary>
          /// Enum LegalArrangementMember for value: legalArrangementMember
          /// </summary>
          [EnumMember(Value = "legalArrangementMember")]
          LegalArrangementMember = 69,

          /// <summary>
          /// Enum LegalArrangementMembers for value: legalArrangementMembers
          /// </summary>
          [EnumMember(Value = "legalArrangementMembers")]
          LegalArrangementMembers = 70,

          /// <summary>
          /// Enum LegalArrangementName for value: legalArrangementName
          /// </summary>
          [EnumMember(Value = "legalArrangementName")]
          LegalArrangementName = 71,

          /// <summary>
          /// Enum LegalArrangementReference for value: legalArrangementReference
          /// </summary>
          [EnumMember(Value = "legalArrangementReference")]
          LegalArrangementReference = 72,

          /// <summary>
          /// Enum LegalArrangementRegistrationNumber for value: legalArrangementRegistrationNumber
          /// </summary>
          [EnumMember(Value = "legalArrangementRegistrationNumber")]
          LegalArrangementRegistrationNumber = 73,

          /// <summary>
          /// Enum LegalArrangementTaxNumber for value: legalArrangementTaxNumber
          /// </summary>
          [EnumMember(Value = "legalArrangementTaxNumber")]
          LegalArrangementTaxNumber = 74,

          /// <summary>
          /// Enum LegalArrangementType for value: legalArrangementType
          /// </summary>
          [EnumMember(Value = "legalArrangementType")]
          LegalArrangementType = 75,

          /// <summary>
          /// Enum LegalBusinessName for value: legalBusinessName
          /// </summary>
          [EnumMember(Value = "legalBusinessName")]
          LegalBusinessName = 76,

          /// <summary>
          /// Enum LegalEntity for value: legalEntity
          /// </summary>
          [EnumMember(Value = "legalEntity")]
          LegalEntity = 77,

          /// <summary>
          /// Enum LegalEntityType for value: legalEntityType
          /// </summary>
          [EnumMember(Value = "legalEntityType")]
          LegalEntityType = 78,

          /// <summary>
          /// Enum MerchantAccount for value: merchantAccount
          /// </summary>
          [EnumMember(Value = "merchantAccount")]
          MerchantAccount = 79,

          /// <summary>
          /// Enum MerchantCategoryCode for value: merchantCategoryCode
          /// </summary>
          [EnumMember(Value = "merchantCategoryCode")]
          MerchantCategoryCode = 80,

          /// <summary>
          /// Enum MerchantReference for value: merchantReference
          /// </summary>
          [EnumMember(Value = "merchantReference")]
          MerchantReference = 81,

          /// <summary>
          /// Enum MicroDeposit for value: microDeposit
          /// </summary>
          [EnumMember(Value = "microDeposit")]
          MicroDeposit = 82,

          /// <summary>
          /// Enum Name for value: name
          /// </summary>
          [EnumMember(Value = "name")]
          Name = 83,

          /// <summary>
          /// Enum Nationality for value: nationality
          /// </summary>
          [EnumMember(Value = "nationality")]
          Nationality = 84,

          /// <summary>
          /// Enum OriginalReference for value: originalReference
          /// </summary>
          [EnumMember(Value = "originalReference")]
          OriginalReference = 85,

          /// <summary>
          /// Enum OwnerCity for value: ownerCity
          /// </summary>
          [EnumMember(Value = "ownerCity")]
          OwnerCity = 86,

          /// <summary>
          /// Enum OwnerCountryCode for value: ownerCountryCode
          /// </summary>
          [EnumMember(Value = "ownerCountryCode")]
          OwnerCountryCode = 87,

          /// <summary>
          /// Enum OwnerHouseNumberOrName for value: ownerHouseNumberOrName
          /// </summary>
          [EnumMember(Value = "ownerHouseNumberOrName")]
          OwnerHouseNumberOrName = 88,

          /// <summary>
          /// Enum OwnerName for value: ownerName
          /// </summary>
          [EnumMember(Value = "ownerName")]
          OwnerName = 89,

          /// <summary>
          /// Enum OwnerPostalCode for value: ownerPostalCode
          /// </summary>
          [EnumMember(Value = "ownerPostalCode")]
          OwnerPostalCode = 90,

          /// <summary>
          /// Enum OwnerState for value: ownerState
          /// </summary>
          [EnumMember(Value = "ownerState")]
          OwnerState = 91,

          /// <summary>
          /// Enum OwnerStreet for value: ownerStreet
          /// </summary>
          [EnumMember(Value = "ownerStreet")]
          OwnerStreet = 92,

          /// <summary>
          /// Enum Passport for value: passport
          /// </summary>
          [EnumMember(Value = "passport")]
          Passport = 93,

          /// <summary>
          /// Enum PassportNumber for value: passportNumber
          /// </summary>
          [EnumMember(Value = "passportNumber")]
          PassportNumber = 94,

          /// <summary>
          /// Enum PayoutMethodCode for value: payoutMethodCode
          /// </summary>
          [EnumMember(Value = "payoutMethodCode")]
          PayoutMethodCode = 95,

          /// <summary>
          /// Enum PayoutSchedule for value: payoutSchedule
          /// </summary>
          [EnumMember(Value = "payoutSchedule")]
          PayoutSchedule = 96,

          /// <summary>
          /// Enum PciSelfAssessment for value: pciSelfAssessment
          /// </summary>
          [EnumMember(Value = "pciSelfAssessment")]
          PciSelfAssessment = 97,

          /// <summary>
          /// Enum PersonalData for value: personalData
          /// </summary>
          [EnumMember(Value = "personalData")]
          PersonalData = 98,

          /// <summary>
          /// Enum PhoneCountryCode for value: phoneCountryCode
          /// </summary>
          [EnumMember(Value = "phoneCountryCode")]
          PhoneCountryCode = 99,

          /// <summary>
          /// Enum PhoneNumber for value: phoneNumber
          /// </summary>
          [EnumMember(Value = "phoneNumber")]
          PhoneNumber = 100,

          /// <summary>
          /// Enum PostalCode for value: postalCode
          /// </summary>
          [EnumMember(Value = "postalCode")]
          PostalCode = 101,

          /// <summary>
          /// Enum PrimaryCurrency for value: primaryCurrency
          /// </summary>
          [EnumMember(Value = "primaryCurrency")]
          PrimaryCurrency = 102,

          /// <summary>
          /// Enum Reason for value: reason
          /// </summary>
          [EnumMember(Value = "reason")]
          Reason = 103,

          /// <summary>
          /// Enum RegistrationNumber for value: registrationNumber
          /// </summary>
          [EnumMember(Value = "registrationNumber")]
          RegistrationNumber = 104,

          /// <summary>
          /// Enum ReturnUrl for value: returnUrl
          /// </summary>
          [EnumMember(Value = "returnUrl")]
          ReturnUrl = 105,

          /// <summary>
          /// Enum Schedule for value: schedule
          /// </summary>
          [EnumMember(Value = "schedule")]
          Schedule = 106,

          /// <summary>
          /// Enum Shareholder for value: shareholder
          /// </summary>
          [EnumMember(Value = "shareholder")]
          Shareholder = 107,

          /// <summary>
          /// Enum ShareholderCode for value: shareholderCode
          /// </summary>
          [EnumMember(Value = "shareholderCode")]
          ShareholderCode = 108,

          /// <summary>
          /// Enum ShareholderCodeAndSignatoryCode for value: shareholderCodeAndSignatoryCode
          /// </summary>
          [EnumMember(Value = "shareholderCodeAndSignatoryCode")]
          ShareholderCodeAndSignatoryCode = 109,

          /// <summary>
          /// Enum ShareholderCodeOrSignatoryCode for value: shareholderCodeOrSignatoryCode
          /// </summary>
          [EnumMember(Value = "shareholderCodeOrSignatoryCode")]
          ShareholderCodeOrSignatoryCode = 110,

          /// <summary>
          /// Enum ShareholderType for value: shareholderType
          /// </summary>
          [EnumMember(Value = "shareholderType")]
          ShareholderType = 111,

          /// <summary>
          /// Enum ShopperInteraction for value: shopperInteraction
          /// </summary>
          [EnumMember(Value = "shopperInteraction")]
          ShopperInteraction = 112,

          /// <summary>
          /// Enum Signatory for value: signatory
          /// </summary>
          [EnumMember(Value = "signatory")]
          Signatory = 113,

          /// <summary>
          /// Enum SignatoryCode for value: signatoryCode
          /// </summary>
          [EnumMember(Value = "signatoryCode")]
          SignatoryCode = 114,

          /// <summary>
          /// Enum SocialSecurityNumber for value: socialSecurityNumber
          /// </summary>
          [EnumMember(Value = "socialSecurityNumber")]
          SocialSecurityNumber = 115,

          /// <summary>
          /// Enum SourceAccountCode for value: sourceAccountCode
          /// </summary>
          [EnumMember(Value = "sourceAccountCode")]
          SourceAccountCode = 116,

          /// <summary>
          /// Enum SplitAccount for value: splitAccount
          /// </summary>
          [EnumMember(Value = "splitAccount")]
          SplitAccount = 117,

          /// <summary>
          /// Enum SplitConfigurationUUID for value: splitConfigurationUUID
          /// </summary>
          [EnumMember(Value = "splitConfigurationUUID")]
          SplitConfigurationUUID = 118,

          /// <summary>
          /// Enum SplitCurrency for value: splitCurrency
          /// </summary>
          [EnumMember(Value = "splitCurrency")]
          SplitCurrency = 119,

          /// <summary>
          /// Enum SplitValue for value: splitValue
          /// </summary>
          [EnumMember(Value = "splitValue")]
          SplitValue = 120,

          /// <summary>
          /// Enum Splits for value: splits
          /// </summary>
          [EnumMember(Value = "splits")]
          Splits = 121,

          /// <summary>
          /// Enum StateOrProvince for value: stateOrProvince
          /// </summary>
          [EnumMember(Value = "stateOrProvince")]
          StateOrProvince = 122,

          /// <summary>
          /// Enum Status for value: status
          /// </summary>
          [EnumMember(Value = "status")]
          Status = 123,

          /// <summary>
          /// Enum StockExchange for value: stockExchange
          /// </summary>
          [EnumMember(Value = "stockExchange")]
          StockExchange = 124,

          /// <summary>
          /// Enum StockNumber for value: stockNumber
          /// </summary>
          [EnumMember(Value = "stockNumber")]
          StockNumber = 125,

          /// <summary>
          /// Enum StockTicker for value: stockTicker
          /// </summary>
          [EnumMember(Value = "stockTicker")]
          StockTicker = 126,

          /// <summary>
          /// Enum Store for value: store
          /// </summary>
          [EnumMember(Value = "store")]
          Store = 127,

          /// <summary>
          /// Enum StoreDetail for value: storeDetail
          /// </summary>
          [EnumMember(Value = "storeDetail")]
          StoreDetail = 128,

          /// <summary>
          /// Enum StoreName for value: storeName
          /// </summary>
          [EnumMember(Value = "storeName")]
          StoreName = 129,

          /// <summary>
          /// Enum StoreReference for value: storeReference
          /// </summary>
          [EnumMember(Value = "storeReference")]
          StoreReference = 130,

          /// <summary>
          /// Enum Street for value: street
          /// </summary>
          [EnumMember(Value = "street")]
          Street = 131,

          /// <summary>
          /// Enum TaxId for value: taxId
          /// </summary>
          [EnumMember(Value = "taxId")]
          TaxId = 132,

          /// <summary>
          /// Enum Tier for value: tier
          /// </summary>
          [EnumMember(Value = "tier")]
          Tier = 133,

          /// <summary>
          /// Enum TierNumber for value: tierNumber
          /// </summary>
          [EnumMember(Value = "tierNumber")]
          TierNumber = 134,

          /// <summary>
          /// Enum TransferCode for value: transferCode
          /// </summary>
          [EnumMember(Value = "transferCode")]
          TransferCode = 135,

          /// <summary>
          /// Enum UltimateParentCompany for value: ultimateParentCompany
          /// </summary>
          [EnumMember(Value = "ultimateParentCompany")]
          UltimateParentCompany = 136,

          /// <summary>
          /// Enum UltimateParentCompanyAddressDetails for value: ultimateParentCompanyAddressDetails
          /// </summary>
          [EnumMember(Value = "ultimateParentCompanyAddressDetails")]
          UltimateParentCompanyAddressDetails = 137,

          /// <summary>
          /// Enum UltimateParentCompanyAddressDetailsCountry for value: ultimateParentCompanyAddressDetailsCountry
          /// </summary>
          [EnumMember(Value = "ultimateParentCompanyAddressDetailsCountry")]
          UltimateParentCompanyAddressDetailsCountry = 138,

          /// <summary>
          /// Enum UltimateParentCompanyBusinessDetails for value: ultimateParentCompanyBusinessDetails
          /// </summary>
          [EnumMember(Value = "ultimateParentCompanyBusinessDetails")]
          UltimateParentCompanyBusinessDetails = 139,

          /// <summary>
          /// Enum UltimateParentCompanyBusinessDetailsLegalBusinessName for value: ultimateParentCompanyBusinessDetailsLegalBusinessName
          /// </summary>
          [EnumMember(Value = "ultimateParentCompanyBusinessDetailsLegalBusinessName")]
          UltimateParentCompanyBusinessDetailsLegalBusinessName = 140,

          /// <summary>
          /// Enum UltimateParentCompanyBusinessDetailsRegistrationNumber for value: ultimateParentCompanyBusinessDetailsRegistrationNumber
          /// </summary>
          [EnumMember(Value = "ultimateParentCompanyBusinessDetailsRegistrationNumber")]
          UltimateParentCompanyBusinessDetailsRegistrationNumber = 141,

          /// <summary>
          /// Enum UltimateParentCompanyCode for value: ultimateParentCompanyCode
          /// </summary>
          [EnumMember(Value = "ultimateParentCompanyCode")]
          UltimateParentCompanyCode = 142,

          /// <summary>
          /// Enum UltimateParentCompanyStockExchange for value: ultimateParentCompanyStockExchange
          /// </summary>
          [EnumMember(Value = "ultimateParentCompanyStockExchange")]
          UltimateParentCompanyStockExchange = 143,

          /// <summary>
          /// Enum UltimateParentCompanyStockNumber for value: ultimateParentCompanyStockNumber
          /// </summary>
          [EnumMember(Value = "ultimateParentCompanyStockNumber")]
          UltimateParentCompanyStockNumber = 144,

          /// <summary>
          /// Enum UltimateParentCompanyStockNumberOrStockTicker for value: ultimateParentCompanyStockNumberOrStockTicker
          /// </summary>
          [EnumMember(Value = "ultimateParentCompanyStockNumberOrStockTicker")]
          UltimateParentCompanyStockNumberOrStockTicker = 145,

          /// <summary>
          /// Enum UltimateParentCompanyStockTicker for value: ultimateParentCompanyStockTicker
          /// </summary>
          [EnumMember(Value = "ultimateParentCompanyStockTicker")]
          UltimateParentCompanyStockTicker = 146,

          /// <summary>
          /// Enum Unknown for value: unknown
          /// </summary>
          [EnumMember(Value = "unknown")]
          Unknown = 147,

          /// <summary>
          /// Enum Value for value: value
          /// </summary>
          [EnumMember(Value = "value")]
          Value = 148,

          /// <summary>
          /// Enum VerificationType for value: verificationType
          /// </summary>
          [EnumMember(Value = "verificationType")]
          VerificationType = 149,

          /// <summary>
          /// Enum VirtualAccount for value: virtualAccount
          /// </summary>
          [EnumMember(Value = "virtualAccount")]
          VirtualAccount = 150,

          /// <summary>
          /// Enum VisaNumber for value: visaNumber
          /// </summary>
          [EnumMember(Value = "visaNumber")]
          VisaNumber = 151,

          /// <summary>
          /// Enum WebAddress for value: webAddress
          /// </summary>
          [EnumMember(Value = "webAddress")]
          WebAddress = 152,

          /// <summary>
          /// Enum Year for value: year
          /// </summary>
          [EnumMember(Value = "year")]
          Year = 153

      }

      /// <summary>
      /// The type of the field.
      /// </summary>
      /// <value>The type of the field.</value>
      [DataMember(Name="fieldName", EmitDefaultValue=false)]
      public FieldNameEnum? fieldName { get; set; }
      /// <summary>
      /// Initializes a new instance of the <see cref="FieldType" /> class.
      /// </summary>
      /// <param name="field">The full name of the property..</param>
      /// <param name="fieldName">The type of the field..</param>
      /// <param name="shareholderCode">The code of the shareholder that the field belongs to. If empty, the field belongs to an account holder..</param>
      public FieldType(string field = default(string), FieldNameEnum? fieldName = default(FieldNameEnum?), string shareholderCode = default(string))
      {
          this.field = field;
          this.fieldName = fieldName;
          this.shareholderCode = shareholderCode;
      }

      /// <summary>
      /// The full name of the property.
      /// </summary>
      /// <value>The full name of the property.</value>
      [DataMember(Name="field", EmitDefaultValue=false)]
      public string field { get; set; }


      /// <summary>
      /// The code of the shareholder that the field belongs to. If empty, the field belongs to an account holder.
      /// </summary>
      /// <value>The code of the shareholder that the field belongs to. If empty, the field belongs to an account holder.</value>
      [DataMember(Name="shareholderCode", EmitDefaultValue=false)]
      public string shareholderCode { get; set; }

      /// <summary>
      /// Returns the string presentation of the object
      /// </summary>
      /// <returns>String presentation of the object</returns>
      public override string ToString()
      {
          var sb = new StringBuilder();
          sb.Append("class FieldType {\n");
          sb.Append("  field: ").Append(field).Append("\n");
          sb.Append("  fieldName: ").Append(fieldName).Append("\n");
          sb.Append("  shareholderCode: ").Append(shareholderCode).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
      }

      /// <summary>
      /// Returns the JSON string presentation of the object
      /// </summary>
      /// <returns>JSON string presentation of the object</returns>
      public virtual string ToJson()
      {
          return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
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
                  this.field == input.field ||
                  (this.field != null &&
                  this.field.Equals(input.field))
              ) && 
              (
                  this.fieldName == input.fieldName ||
                  (this.fieldName != null &&
                  this.fieldName.Equals(input.fieldName))
              ) && 
              (
                  this.shareholderCode == input.shareholderCode ||
                  (this.shareholderCode != null &&
                  this.shareholderCode.Equals(input.shareholderCode))
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
              if (this.field != null)
                  hashCode = hashCode * 59 + this.field.GetHashCode();
              if (this.fieldName != null)
                  hashCode = hashCode * 59 + this.fieldName.GetHashCode();
              if (this.shareholderCode != null)
                  hashCode = hashCode * 59 + this.shareholderCode.GetHashCode();
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
