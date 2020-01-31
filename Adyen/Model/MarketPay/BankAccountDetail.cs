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

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// BankAccountDetail
    /// </summary>
    [DataContract]
    public class BankAccountDetail : IEquatable<BankAccountDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountDetail" /> class.
        /// </summary>
        /// <param name="accountNumber">The bank account number (without separators). &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements..</param>
        /// <param name="accountType">The type of bank account. Only applicable to bank accounts held in the USA. The permitted values are: &#x60;checking&#x60;, &#x60;savings&#x60;.  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements..</param>
        /// <param name="bankAccountName">The name of the bank account..</param>
        /// <param name="bankAccountReference">Merchant reference to the bank account..</param>
        /// <param name="bankAccountUUID">The unique identifier (UUID) of the Bank Account. &gt;If, during an account holder create or update request, this field is left blank (but other fields provided), a new Bank Account will be created with a procedurally-generated UUID.  &gt;If, during an account holder create request, a UUID is provided, the creation of the Bank Account will fail while the creation of the account holder will continue.  &gt;If, during an account holder update request, a UUID that is not correlated with an existing Bank Account is provided, the update of the account holder will fail.  &gt;If, during an account holder update request, a UUID that is correlated with an existing Bank Account is provided, the existing Bank Account will be updated. .</param>
        /// <param name="bankBicSwift">The bank identifier code. &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements..</param>
        /// <param name="bankCity">The city in which the bank branch is located.  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements..</param>
        /// <param name="bankCode">The bank code of the banking institution with which the bank account is registered.  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements..</param>
        /// <param name="bankName">The name of the banking institution with which the bank account is held.  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements..</param>
        /// <param name="branchCode">The branch code of the branch under which the bank account is registered. The value to be specified in this parameter depends on the country of the bank account: * United States - Routing number * United Kingdom - Sort code * Germany - Bankleitzahl &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements..</param>
        /// <param name="checkCode">The check code of the bank account.  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements..</param>
        /// <param name="countryCode">The two-letter country code in which the bank account is registered. &gt;The permitted country codes are defined in ISO-3166-1 alpha-2 (e.g. &#x27;NL&#x27;).  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements..</param>
        /// <param name="currencyCode">The currency in which the bank account deals. &gt;The permitted currency codes are defined in ISO-4217 (e.g. &#x27;EUR&#x27;).  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements..</param>
        /// <param name="iban">The international bank account number. &gt;The IBAN standard is defined in ISO-13616.  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements..</param>
        /// <param name="ownerCity">The city of residence of the bank account owner. &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements..</param>
        /// <param name="ownerCountryCode">The country code of the country of residence of the bank account owner. &gt;The permitted country codes are defined in ISO-3166-1 alpha-2 (e.g. &#x27;NL&#x27;).  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements..</param>
        /// <param name="ownerDateOfBirth">The date of birth of the bank account owner. .</param>
        /// <param name="ownerHouseNumberOrName">The house name or number of the residence of the bank account owner. &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements..</param>
        /// <param name="ownerName">The name of the bank account owner. &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements..</param>
        /// <param name="ownerNationality">The country code of the country of nationality of the bank account owner. &gt;The permitted country codes are defined in ISO-3166-1 alpha-2 (e.g. &#x27;NL&#x27;).  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements..</param>
        /// <param name="ownerPostalCode">The postal code of the residence of the bank account owner. &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements..</param>
        /// <param name="ownerState">The state of residence of the bank account owner. &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements..</param>
        /// <param name="ownerStreet">The street name of the residence of the bank account owner. &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements..</param>
        /// <param name="primaryAccount">If set to true, the bank account is a primary account..</param>
        /// <param name="taxId">The tax ID number.  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements..</param>
        /// <param name="urlForVerification">The URL to be used for bank account verification. This may be generated on bank account creation.  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements..</param>
        public BankAccountDetail(string accountNumber = default(string), string accountType = default(string), string bankAccountName = default(string), string bankAccountReference = default(string), string bankAccountUUID = default(string), string bankBicSwift = default(string), string bankCity = default(string), string bankCode = default(string), string bankName = default(string), string branchCode = default(string), string checkCode = default(string), string countryCode = default(string), string currencyCode = default(string), string iban = default(string), string ownerCity = default(string), string ownerCountryCode = default(string), string ownerDateOfBirth = default(string), string ownerHouseNumberOrName = default(string), string ownerName = default(string), string ownerNationality = default(string), string ownerPostalCode = default(string), string ownerState = default(string), string ownerStreet = default(string), bool? primaryAccount = default(bool?), string taxId = default(string), string urlForVerification = default(string))
        {
            this.AccountNumber = accountNumber;
            this.AccountType = accountType;
            this.BankAccountName = bankAccountName;
            this.BankAccountReference = bankAccountReference;
            this.BankAccountUUID = bankAccountUUID;
            this.BankBicSwift = bankBicSwift;
            this.BankCity = bankCity;
            this.BankCode = bankCode;
            this.BankName = bankName;
            this.BranchCode = branchCode;
            this.CheckCode = checkCode;
            this.CountryCode = countryCode;
            this.CurrencyCode = currencyCode;
            this.Iban = iban;
            this.OwnerCity = ownerCity;
            this.OwnerCountryCode = ownerCountryCode;
            this.OwnerDateOfBirth = ownerDateOfBirth;
            this.OwnerHouseNumberOrName = ownerHouseNumberOrName;
            this.OwnerName = ownerName;
            this.OwnerNationality = ownerNationality;
            this.OwnerPostalCode = ownerPostalCode;
            this.OwnerState = ownerState;
            this.OwnerStreet = ownerStreet;
            this.PrimaryAccount = primaryAccount;
            this.TaxId = taxId;
            this.UrlForVerification = urlForVerification;
        }

        /// <summary>
        /// The bank account number (without separators). &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.
        /// </summary>
        /// <value>The bank account number (without separators). &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.</value>
        [DataMember(Name = "accountNumber", EmitDefaultValue = false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The type of bank account. Only applicable to bank accounts held in the USA. The permitted values are: &#x60;checking&#x60;, &#x60;savings&#x60;.  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.
        /// </summary>
        /// <value>The type of bank account. Only applicable to bank accounts held in the USA. The permitted values are: &#x60;checking&#x60;, &#x60;savings&#x60;.  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.</value>
        [DataMember(Name = "accountType", EmitDefaultValue = false)]
        public string AccountType { get; set; }

        /// <summary>
        /// The name of the bank account.
        /// </summary>
        /// <value>The name of the bank account.</value>
        [DataMember(Name = "bankAccountName", EmitDefaultValue = false)]
        public string BankAccountName { get; set; }

        /// <summary>
        /// Merchant reference to the bank account.
        /// </summary>
        /// <value>Merchant reference to the bank account.</value>
        [DataMember(Name = "bankAccountReference", EmitDefaultValue = false)]
        public string BankAccountReference { get; set; }

        /// <summary>
        /// The unique identifier (UUID) of the Bank Account. &gt;If, during an account holder create or update request, this field is left blank (but other fields provided), a new Bank Account will be created with a procedurally-generated UUID.  &gt;If, during an account holder create request, a UUID is provided, the creation of the Bank Account will fail while the creation of the account holder will continue.  &gt;If, during an account holder update request, a UUID that is not correlated with an existing Bank Account is provided, the update of the account holder will fail.  &gt;If, during an account holder update request, a UUID that is correlated with an existing Bank Account is provided, the existing Bank Account will be updated. 
        /// </summary>
        /// <value>The unique identifier (UUID) of the Bank Account. &gt;If, during an account holder create or update request, this field is left blank (but other fields provided), a new Bank Account will be created with a procedurally-generated UUID.  &gt;If, during an account holder create request, a UUID is provided, the creation of the Bank Account will fail while the creation of the account holder will continue.  &gt;If, during an account holder update request, a UUID that is not correlated with an existing Bank Account is provided, the update of the account holder will fail.  &gt;If, during an account holder update request, a UUID that is correlated with an existing Bank Account is provided, the existing Bank Account will be updated. </value>
        [DataMember(Name = "bankAccountUUID", EmitDefaultValue = false)]
        public string BankAccountUUID { get; set; }

        /// <summary>
        /// The bank identifier code. &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.
        /// </summary>
        /// <value>The bank identifier code. &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.</value>
        [DataMember(Name = "bankBicSwift", EmitDefaultValue = false)]
        public string BankBicSwift { get; set; }

        /// <summary>
        /// The city in which the bank branch is located.  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.
        /// </summary>
        /// <value>The city in which the bank branch is located.  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.</value>
        [DataMember(Name = "bankCity", EmitDefaultValue = false)]
        public string BankCity { get; set; }

        /// <summary>
        /// The bank code of the banking institution with which the bank account is registered.  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.
        /// </summary>
        /// <value>The bank code of the banking institution with which the bank account is registered.  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.</value>
        [DataMember(Name = "bankCode", EmitDefaultValue = false)]
        public string BankCode { get; set; }

        /// <summary>
        /// The name of the banking institution with which the bank account is held.  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.
        /// </summary>
        /// <value>The name of the banking institution with which the bank account is held.  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.</value>
        [DataMember(Name = "bankName", EmitDefaultValue = false)]
        public string BankName { get; set; }

        /// <summary>
        /// The branch code of the branch under which the bank account is registered. The value to be specified in this parameter depends on the country of the bank account: * United States - Routing number * United Kingdom - Sort code * Germany - Bankleitzahl &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.
        /// </summary>
        /// <value>The branch code of the branch under which the bank account is registered. The value to be specified in this parameter depends on the country of the bank account: * United States - Routing number * United Kingdom - Sort code * Germany - Bankleitzahl &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.</value>
        [DataMember(Name = "branchCode", EmitDefaultValue = false)]
        public string BranchCode { get; set; }

        /// <summary>
        /// The check code of the bank account.  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.
        /// </summary>
        /// <value>The check code of the bank account.  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.</value>
        [DataMember(Name = "checkCode", EmitDefaultValue = false)]
        public string CheckCode { get; set; }

        /// <summary>
        /// The two-letter country code in which the bank account is registered. &gt;The permitted country codes are defined in ISO-3166-1 alpha-2 (e.g. &#x27;NL&#x27;).  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.
        /// </summary>
        /// <value>The two-letter country code in which the bank account is registered. &gt;The permitted country codes are defined in ISO-3166-1 alpha-2 (e.g. &#x27;NL&#x27;).  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.</value>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The currency in which the bank account deals. &gt;The permitted currency codes are defined in ISO-4217 (e.g. &#x27;EUR&#x27;).  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.
        /// </summary>
        /// <value>The currency in which the bank account deals. &gt;The permitted currency codes are defined in ISO-4217 (e.g. &#x27;EUR&#x27;).  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.</value>
        [DataMember(Name = "currencyCode", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The international bank account number. &gt;The IBAN standard is defined in ISO-13616.  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.
        /// </summary>
        /// <value>The international bank account number. &gt;The IBAN standard is defined in ISO-13616.  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.</value>
        [DataMember(Name = "iban", EmitDefaultValue = false)]
        public string Iban { get; set; }

        /// <summary>
        /// The city of residence of the bank account owner. &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.
        /// </summary>
        /// <value>The city of residence of the bank account owner. &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.</value>
        [DataMember(Name = "ownerCity", EmitDefaultValue = false)]
        public string OwnerCity { get; set; }

        /// <summary>
        /// The country code of the country of residence of the bank account owner. &gt;The permitted country codes are defined in ISO-3166-1 alpha-2 (e.g. &#x27;NL&#x27;).  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.
        /// </summary>
        /// <value>The country code of the country of residence of the bank account owner. &gt;The permitted country codes are defined in ISO-3166-1 alpha-2 (e.g. &#x27;NL&#x27;).  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.</value>
        [DataMember(Name = "ownerCountryCode", EmitDefaultValue = false)]
        public string OwnerCountryCode { get; set; }

        /// <summary>
        /// The date of birth of the bank account owner. 
        /// </summary>
        /// <value>The date of birth of the bank account owner. </value>
        [DataMember(Name = "ownerDateOfBirth", EmitDefaultValue = false)]
        public string OwnerDateOfBirth { get; set; }

        /// <summary>
        /// The house name or number of the residence of the bank account owner. &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.
        /// </summary>
        /// <value>The house name or number of the residence of the bank account owner. &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.</value>
        [DataMember(Name = "ownerHouseNumberOrName", EmitDefaultValue = false)]
        public string OwnerHouseNumberOrName { get; set; }

        /// <summary>
        /// The name of the bank account owner. &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.
        /// </summary>
        /// <value>The name of the bank account owner. &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.</value>
        [DataMember(Name = "ownerName", EmitDefaultValue = false)]
        public string OwnerName { get; set; }

        /// <summary>
        /// The country code of the country of nationality of the bank account owner. &gt;The permitted country codes are defined in ISO-3166-1 alpha-2 (e.g. &#x27;NL&#x27;).  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.
        /// </summary>
        /// <value>The country code of the country of nationality of the bank account owner. &gt;The permitted country codes are defined in ISO-3166-1 alpha-2 (e.g. &#x27;NL&#x27;).  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.</value>
        [DataMember(Name = "ownerNationality", EmitDefaultValue = false)]
        public string OwnerNationality { get; set; }

        /// <summary>
        /// The postal code of the residence of the bank account owner. &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.
        /// </summary>
        /// <value>The postal code of the residence of the bank account owner. &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.</value>
        [DataMember(Name = "ownerPostalCode", EmitDefaultValue = false)]
        public string OwnerPostalCode { get; set; }

        /// <summary>
        /// The state of residence of the bank account owner. &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.
        /// </summary>
        /// <value>The state of residence of the bank account owner. &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.</value>
        [DataMember(Name = "ownerState", EmitDefaultValue = false)]
        public string OwnerState { get; set; }

        /// <summary>
        /// The street name of the residence of the bank account owner. &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.
        /// </summary>
        /// <value>The street name of the residence of the bank account owner. &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.</value>
        [DataMember(Name = "ownerStreet", EmitDefaultValue = false)]
        public string OwnerStreet { get; set; }

        /// <summary>
        /// If set to true, the bank account is a primary account.
        /// </summary>
        /// <value>If set to true, the bank account is a primary account.</value>
        [DataMember(Name = "primaryAccount", EmitDefaultValue = false)]
        public bool? PrimaryAccount { get; set; }

        /// <summary>
        /// The tax ID number.  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.
        /// </summary>
        /// <value>The tax ID number.  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.</value>
        [DataMember(Name = "taxId", EmitDefaultValue = false)]
        public string TaxId { get; set; }

        /// <summary>
        /// The URL to be used for bank account verification. This may be generated on bank account creation.  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.
        /// </summary>
        /// <value>The URL to be used for bank account verification. This may be generated on bank account creation.  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on field requirements.</value>
        [DataMember(Name = "urlForVerification", EmitDefaultValue = false)]
        public string UrlForVerification { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankAccountDetail {\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  BankAccountName: ").Append(BankAccountName).Append("\n");
            sb.Append("  BankAccountReference: ").Append(BankAccountReference).Append("\n");
            sb.Append("  BankAccountUUID: ").Append(BankAccountUUID).Append("\n");
            sb.Append("  BankBicSwift: ").Append(BankBicSwift).Append("\n");
            sb.Append("  BankCity: ").Append(BankCity).Append("\n");
            sb.Append("  BankCode: ").Append(BankCode).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  BranchCode: ").Append(BranchCode).Append("\n");
            sb.Append("  CheckCode: ").Append(CheckCode).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  OwnerCity: ").Append(OwnerCity).Append("\n");
            sb.Append("  OwnerCountryCode: ").Append(OwnerCountryCode).Append("\n");
            sb.Append("  OwnerDateOfBirth: ").Append(OwnerDateOfBirth).Append("\n");
            sb.Append("  OwnerHouseNumberOrName: ").Append(OwnerHouseNumberOrName).Append("\n");
            sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
            sb.Append("  OwnerNationality: ").Append(OwnerNationality).Append("\n");
            sb.Append("  OwnerPostalCode: ").Append(OwnerPostalCode).Append("\n");
            sb.Append("  OwnerState: ").Append(OwnerState).Append("\n");
            sb.Append("  OwnerStreet: ").Append(OwnerStreet).Append("\n");
            sb.Append("  PrimaryAccount: ").Append(PrimaryAccount).Append("\n");
            sb.Append("  TaxId: ").Append(TaxId).Append("\n");
            sb.Append("  UrlForVerification: ").Append(UrlForVerification).Append("\n");
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
            return this.Equals(input as BankAccountDetail);
        }

        /// <summary>
        /// Returns true if BankAccountDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of BankAccountDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankAccountDetail input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) &&
                (
                    this.AccountType == input.AccountType ||
                    (this.AccountType != null &&
                    this.AccountType.Equals(input.AccountType))
                ) &&
                (
                    this.BankAccountName == input.BankAccountName ||
                    (this.BankAccountName != null &&
                    this.BankAccountName.Equals(input.BankAccountName))
                ) &&
                (
                    this.BankAccountReference == input.BankAccountReference ||
                    (this.BankAccountReference != null &&
                    this.BankAccountReference.Equals(input.BankAccountReference))
                ) &&
                (
                    this.BankAccountUUID == input.BankAccountUUID ||
                    (this.BankAccountUUID != null &&
                    this.BankAccountUUID.Equals(input.BankAccountUUID))
                ) &&
                (
                    this.BankBicSwift == input.BankBicSwift ||
                    (this.BankBicSwift != null &&
                    this.BankBicSwift.Equals(input.BankBicSwift))
                ) &&
                (
                    this.BankCity == input.BankCity ||
                    (this.BankCity != null &&
                    this.BankCity.Equals(input.BankCity))
                ) &&
                (
                    this.BankCode == input.BankCode ||
                    (this.BankCode != null &&
                    this.BankCode.Equals(input.BankCode))
                ) &&
                (
                    this.BankName == input.BankName ||
                    (this.BankName != null &&
                    this.BankName.Equals(input.BankName))
                ) &&
                (
                    this.BranchCode == input.BranchCode ||
                    (this.BranchCode != null &&
                    this.BranchCode.Equals(input.BranchCode))
                ) &&
                (
                    this.CheckCode == input.CheckCode ||
                    (this.CheckCode != null &&
                    this.CheckCode.Equals(input.CheckCode))
                ) &&
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) &&
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) &&
                (
                    this.Iban == input.Iban ||
                    (this.Iban != null &&
                    this.Iban.Equals(input.Iban))
                ) &&
                (
                    this.OwnerCity == input.OwnerCity ||
                    (this.OwnerCity != null &&
                    this.OwnerCity.Equals(input.OwnerCity))
                ) &&
                (
                    this.OwnerCountryCode == input.OwnerCountryCode ||
                    (this.OwnerCountryCode != null &&
                    this.OwnerCountryCode.Equals(input.OwnerCountryCode))
                ) &&
                (
                    this.OwnerDateOfBirth == input.OwnerDateOfBirth ||
                    (this.OwnerDateOfBirth != null &&
                    this.OwnerDateOfBirth.Equals(input.OwnerDateOfBirth))
                ) &&
                (
                    this.OwnerHouseNumberOrName == input.OwnerHouseNumberOrName ||
                    (this.OwnerHouseNumberOrName != null &&
                    this.OwnerHouseNumberOrName.Equals(input.OwnerHouseNumberOrName))
                ) &&
                (
                    this.OwnerName == input.OwnerName ||
                    (this.OwnerName != null &&
                    this.OwnerName.Equals(input.OwnerName))
                ) &&
                (
                    this.OwnerNationality == input.OwnerNationality ||
                    (this.OwnerNationality != null &&
                    this.OwnerNationality.Equals(input.OwnerNationality))
                ) &&
                (
                    this.OwnerPostalCode == input.OwnerPostalCode ||
                    (this.OwnerPostalCode != null &&
                    this.OwnerPostalCode.Equals(input.OwnerPostalCode))
                ) &&
                (
                    this.OwnerState == input.OwnerState ||
                    (this.OwnerState != null &&
                    this.OwnerState.Equals(input.OwnerState))
                ) &&
                (
                    this.OwnerStreet == input.OwnerStreet ||
                    (this.OwnerStreet != null &&
                    this.OwnerStreet.Equals(input.OwnerStreet))
                ) &&
                (
                    this.PrimaryAccount == input.PrimaryAccount ||
                    (this.PrimaryAccount != null &&
                    this.PrimaryAccount.Equals(input.PrimaryAccount))
                ) &&
                (
                    this.TaxId == input.TaxId ||
                    (this.TaxId != null &&
                    this.TaxId.Equals(input.TaxId))
                ) &&
                (
                    this.UrlForVerification == input.UrlForVerification ||
                    (this.UrlForVerification != null &&
                    this.UrlForVerification.Equals(input.UrlForVerification))
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
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
                if (this.AccountType != null)
                    hashCode = hashCode * 59 + this.AccountType.GetHashCode();
                if (this.BankAccountName != null)
                    hashCode = hashCode * 59 + this.BankAccountName.GetHashCode();
                if (this.BankAccountReference != null)
                    hashCode = hashCode * 59 + this.BankAccountReference.GetHashCode();
                if (this.BankAccountUUID != null)
                    hashCode = hashCode * 59 + this.BankAccountUUID.GetHashCode();
                if (this.BankBicSwift != null)
                    hashCode = hashCode * 59 + this.BankBicSwift.GetHashCode();
                if (this.BankCity != null)
                    hashCode = hashCode * 59 + this.BankCity.GetHashCode();
                if (this.BankCode != null)
                    hashCode = hashCode * 59 + this.BankCode.GetHashCode();
                if (this.BankName != null)
                    hashCode = hashCode * 59 + this.BankName.GetHashCode();
                if (this.BranchCode != null)
                    hashCode = hashCode * 59 + this.BranchCode.GetHashCode();
                if (this.CheckCode != null)
                    hashCode = hashCode * 59 + this.CheckCode.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.Iban != null)
                    hashCode = hashCode * 59 + this.Iban.GetHashCode();
                if (this.OwnerCity != null)
                    hashCode = hashCode * 59 + this.OwnerCity.GetHashCode();
                if (this.OwnerCountryCode != null)
                    hashCode = hashCode * 59 + this.OwnerCountryCode.GetHashCode();
                if (this.OwnerDateOfBirth != null)
                    hashCode = hashCode * 59 + this.OwnerDateOfBirth.GetHashCode();
                if (this.OwnerHouseNumberOrName != null)
                    hashCode = hashCode * 59 + this.OwnerHouseNumberOrName.GetHashCode();
                if (this.OwnerName != null)
                    hashCode = hashCode * 59 + this.OwnerName.GetHashCode();
                if (this.OwnerNationality != null)
                    hashCode = hashCode * 59 + this.OwnerNationality.GetHashCode();
                if (this.OwnerPostalCode != null)
                    hashCode = hashCode * 59 + this.OwnerPostalCode.GetHashCode();
                if (this.OwnerState != null)
                    hashCode = hashCode * 59 + this.OwnerState.GetHashCode();
                if (this.OwnerStreet != null)
                    hashCode = hashCode * 59 + this.OwnerStreet.GetHashCode();
                if (this.PrimaryAccount != null)
                    hashCode = hashCode * 59 + this.PrimaryAccount.GetHashCode();
                if (this.TaxId != null)
                    hashCode = hashCode * 59 + this.TaxId.GetHashCode();
                if (this.UrlForVerification != null)
                    hashCode = hashCode * 59 + this.UrlForVerification.GetHashCode();
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
