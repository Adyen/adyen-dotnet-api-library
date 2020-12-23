#region Licence

// 
//                        ######
//                        ######
//  ############    ####( ######  #####. ######  ############   ############
//  #############  #####( ######  #####. ######  #############  #############
//         ######  #####( ######  #####. ######  #####  ######  #####  ######
//  ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  ###### ######  #####( ######  #####. ######  #####          #####  ######
//  #############  #############  #############  #############  #####  ######
//   ############   ############  #############   ############  #####  ######
//                                       ######
//                                #############
//                                ############
// 
//  Adyen Dotnet API Library
// 
//  Copyright (c) 2020 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.

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
    /// AdditionalDataSubMerchant
    /// </summary>
    [DataContract]
    public partial class AdditionalDataSubMerchant : IEquatable<AdditionalDataSubMerchant>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataSubMerchant" /> class.
        /// </summary>
        /// <param name="subMerchantNumberOfSubSellers">Required for transactions performed by registered payment facilitators. Indicates the number of sub-merchants contained in the request. For example, **3**..</param>
        /// <param name="subMerchantSubSellerSubSellerNrCity">Required for transactions performed by registered payment facilitators. The city of the sub-merchant&#x27;s address. * Format: Alphanumeric * Maximum length: 13 characters.</param>
        /// <param name="subMerchantSubSellerSubSellerNrCountry">Required for transactions performed by registered payment facilitators. The three-letter country code of the sub-merchant&#x27;s address. For example, **BRA** for Brazil.  * Format: [ISO 3166-1 alpha-3](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3) * Fixed length: 3 characters.</param>
        /// <param name="subMerchantSubSellerSubSellerNrCreditSettlementAccount">The sub-merchant&#x27;s bank account number with the check digit number and without punctuations or dashes. * Format: Numeric * Maximum length: 12 digits.</param>
        /// <param name="subMerchantSubSellerSubSellerNrCreditSettlementAccountType">A two-letter indicator of the type of the sub-merchant&#x27;s bank account. Possible values:   - **CC** - Checking account  - **CD** - Deposit account  - **PG** - Payments account  - **PP** - Savings account .</param>
        /// <param name="subMerchantSubSellerSubSellerNrCreditSettlementAgency">The four-digit branch code of the sub-merchant&#x27;s bank, without the check digit, slashes, or dashes. * Format: Numeric * Fixed length: 4 digits.</param>
        /// <param name="subMerchantSubSellerSubSellerNrCreditSettlementBank">The identifier of the sub-merchant&#x27;s bank. In Brazil, this is the three-digit bank number format specified by the Central Bank of Brazil (BACEN). * Format: Numeric * Fixed length: 3 digits.</param>
        /// <param name="subMerchantSubSellerSubSellerNrDebitSettlementAccount">The sub-merchant&#x27;s bank account number with the check digit number and without punctuations or dashes. * Format: Numeric * Maximum length: 12 digits.</param>
        /// <param name="subMerchantSubSellerSubSellerNrDebitSettlementAccountType">A two-letter indicator of the type of the sub-merchant&#x27;s bank account. Possible values:   - **CC** - Checking account  - **CD** - Deposit account  - **PG** - Payments account  - **PP** - Savings account .</param>
        /// <param name="subMerchantSubSellerSubSellerNrDebitSettlementAgency">The four-digit branch code of the sub-merchant&#x27;s bank, without the check digit, slashes, or dashes. * Format: Numeric * Fixed length: 4 digits.</param>
        /// <param name="subMerchantSubSellerSubSellerNrDebitSettlementBank">The identifier of the sub-merchant&#x27;s bank. In Brazil, this is the three-digit bank number format specified by the Central Bank of Brazil (BACEN). * Format: Numeric * Fixed length: 3 digits.</param>
        /// <param name="subMerchantSubSellerSubSellerNrId">Required for transactions performed by registered payment facilitators. A unique identifier that you create for the sub-merchant, used by schemes to identify the sub-merchant.  * Format: Alphanumeric * Maximum length: 15 characters.</param>
        /// <param name="subMerchantSubSellerSubSellerNrMcc">Required for transactions performed by registered payment facilitators. The sub-merchant&#x27;s 4-digit Merchant Category Code (MCC).  * Format: Numeric * Fixed length: 4 digits.</param>
        /// <param name="subMerchantSubSellerSubSellerNrName">Required for transactions performed by registered payment facilitators. The name of the sub-merchant. Based on scheme specifications, this value will overwrite the shopper statement  that will appear in the card statement. * Format: Alphanumeric * Maximum length: 22 characters.</param>
        /// <param name="subMerchantSubSellerSubSellerNrPostalCode">Required for transactions performed by registered payment facilitators. The postal code of the sub-merchant&#x27;s address, without dashes. * Format: Numeric * Fixed length: 8 digits.</param>
        /// <param name="subMerchantSubSellerSubSellerNrState">Required for transactions performed by registered payment facilitators. The state code of the sub-merchant&#x27;s address, if applicable to the country. * Format: Alphanumeric * Maximum length: 2 characters.</param>
        /// <param name="subMerchantSubSellerSubSellerNrStreet">Required for transactions performed by registered payment facilitators. The street name and house number of the sub-merchant&#x27;s address. * Format: Alphanumeric * Maximum length: 60 characters.</param>
        /// <param name="subMerchantSubSellerSubSellerNrTaxId">Required for transactions performed by registered payment facilitators. The tax ID of the sub-merchant. * Format: Numeric * Fixed length: 11 digits for the CPF or 14 digits for the CNPJ.</param>
        public AdditionalDataSubMerchant(string subMerchantNumberOfSubSellers = default(string),
            string subMerchantSubSellerSubSellerNrCity = default(string),
            string subMerchantSubSellerSubSellerNrCountry = default(string),
            string subMerchantSubSellerSubSellerNrCreditSettlementAccount = default(string),
            string subMerchantSubSellerSubSellerNrCreditSettlementAccountType = default(string),
            string subMerchantSubSellerSubSellerNrCreditSettlementAgency = default(string),
            string subMerchantSubSellerSubSellerNrCreditSettlementBank = default(string),
            string subMerchantSubSellerSubSellerNrDebitSettlementAccount = default(string),
            string subMerchantSubSellerSubSellerNrDebitSettlementAccountType = default(string),
            string subMerchantSubSellerSubSellerNrDebitSettlementAgency = default(string),
            string subMerchantSubSellerSubSellerNrDebitSettlementBank = default(string),
            string subMerchantSubSellerSubSellerNrId = default(string),
            string subMerchantSubSellerSubSellerNrMcc = default(string),
            string subMerchantSubSellerSubSellerNrName = default(string),
            string subMerchantSubSellerSubSellerNrPostalCode = default(string),
            string subMerchantSubSellerSubSellerNrState = default(string),
            string subMerchantSubSellerSubSellerNrStreet = default(string),
            string subMerchantSubSellerSubSellerNrTaxId = default(string))
        {
            this.SubMerchantNumberOfSubSellers = subMerchantNumberOfSubSellers;
            this.SubMerchantSubSellerSubSellerNrCity = subMerchantSubSellerSubSellerNrCity;
            this.SubMerchantSubSellerSubSellerNrCountry = subMerchantSubSellerSubSellerNrCountry;
            this.SubMerchantSubSellerSubSellerNrCreditSettlementAccount =
                subMerchantSubSellerSubSellerNrCreditSettlementAccount;
            this.SubMerchantSubSellerSubSellerNrCreditSettlementAccountType =
                subMerchantSubSellerSubSellerNrCreditSettlementAccountType;
            this.SubMerchantSubSellerSubSellerNrCreditSettlementAgency =
                subMerchantSubSellerSubSellerNrCreditSettlementAgency;
            this.SubMerchantSubSellerSubSellerNrCreditSettlementBank =
                subMerchantSubSellerSubSellerNrCreditSettlementBank;
            this.SubMerchantSubSellerSubSellerNrDebitSettlementAccount =
                subMerchantSubSellerSubSellerNrDebitSettlementAccount;
            this.SubMerchantSubSellerSubSellerNrDebitSettlementAccountType =
                subMerchantSubSellerSubSellerNrDebitSettlementAccountType;
            this.SubMerchantSubSellerSubSellerNrDebitSettlementAgency =
                subMerchantSubSellerSubSellerNrDebitSettlementAgency;
            this.SubMerchantSubSellerSubSellerNrDebitSettlementBank =
                subMerchantSubSellerSubSellerNrDebitSettlementBank;
            this.SubMerchantSubSellerSubSellerNrId = subMerchantSubSellerSubSellerNrId;
            this.SubMerchantSubSellerSubSellerNrMcc = subMerchantSubSellerSubSellerNrMcc;
            this.SubMerchantSubSellerSubSellerNrName = subMerchantSubSellerSubSellerNrName;
            this.SubMerchantSubSellerSubSellerNrPostalCode = subMerchantSubSellerSubSellerNrPostalCode;
            this.SubMerchantSubSellerSubSellerNrState = subMerchantSubSellerSubSellerNrState;
            this.SubMerchantSubSellerSubSellerNrStreet = subMerchantSubSellerSubSellerNrStreet;
            this.SubMerchantSubSellerSubSellerNrTaxId = subMerchantSubSellerSubSellerNrTaxId;
        }

        /// <summary>
        /// Required for transactions performed by registered payment facilitators. Indicates the number of sub-merchants contained in the request. For example, **3**.
        /// </summary>
        /// <value>Required for transactions performed by registered payment facilitators. Indicates the number of sub-merchants contained in the request. For example, **3**.</value>
        [DataMember(Name = "subMerchant.numberOfSubSellers", EmitDefaultValue = false)]
        public string SubMerchantNumberOfSubSellers { get; set; }

        /// <summary>
        /// Required for transactions performed by registered payment facilitators. The city of the sub-merchant&#x27;s address. * Format: Alphanumeric * Maximum length: 13 characters
        /// </summary>
        /// <value>Required for transactions performed by registered payment facilitators. The city of the sub-merchant&#x27;s address. * Format: Alphanumeric * Maximum length: 13 characters</value>
        [DataMember(Name = "subMerchant.subSeller[subSellerNr].city", EmitDefaultValue = false)]
        public string SubMerchantSubSellerSubSellerNrCity { get; set; }

        /// <summary>
        /// Required for transactions performed by registered payment facilitators. The three-letter country code of the sub-merchant&#x27;s address. For example, **BRA** for Brazil.  * Format: [ISO 3166-1 alpha-3](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3) * Fixed length: 3 characters
        /// </summary>
        /// <value>Required for transactions performed by registered payment facilitators. The three-letter country code of the sub-merchant&#x27;s address. For example, **BRA** for Brazil.  * Format: [ISO 3166-1 alpha-3](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3) * Fixed length: 3 characters</value>
        [DataMember(Name = "subMerchant.subSeller[subSellerNr].country", EmitDefaultValue = false)]
        public string SubMerchantSubSellerSubSellerNrCountry { get; set; }

        /// <summary>
        /// The sub-merchant&#x27;s bank account number with the check digit number and without punctuations or dashes. * Format: Numeric * Maximum length: 12 digits
        /// </summary>
        /// <value>The sub-merchant&#x27;s bank account number with the check digit number and without punctuations or dashes. * Format: Numeric * Maximum length: 12 digits</value>
        [DataMember(Name = "subMerchant.subSeller[subSellerNr].creditSettlementAccount", EmitDefaultValue = false)]
        public string SubMerchantSubSellerSubSellerNrCreditSettlementAccount { get; set; }

        /// <summary>
        /// A two-letter indicator of the type of the sub-merchant&#x27;s bank account. Possible values:   - **CC** - Checking account  - **CD** - Deposit account  - **PG** - Payments account  - **PP** - Savings account 
        /// </summary>
        /// <value>A two-letter indicator of the type of the sub-merchant&#x27;s bank account. Possible values:   - **CC** - Checking account  - **CD** - Deposit account  - **PG** - Payments account  - **PP** - Savings account </value>
        [DataMember(Name = "subMerchant.subSeller[subSellerNr].creditSettlementAccountType", EmitDefaultValue = false)]
        public string SubMerchantSubSellerSubSellerNrCreditSettlementAccountType { get; set; }

        /// <summary>
        /// The four-digit branch code of the sub-merchant&#x27;s bank, without the check digit, slashes, or dashes. * Format: Numeric * Fixed length: 4 digits
        /// </summary>
        /// <value>The four-digit branch code of the sub-merchant&#x27;s bank, without the check digit, slashes, or dashes. * Format: Numeric * Fixed length: 4 digits</value>
        [DataMember(Name = "subMerchant.subSeller[subSellerNr].creditSettlementAgency", EmitDefaultValue = false)]
        public string SubMerchantSubSellerSubSellerNrCreditSettlementAgency { get; set; }

        /// <summary>
        /// The identifier of the sub-merchant&#x27;s bank. In Brazil, this is the three-digit bank number format specified by the Central Bank of Brazil (BACEN). * Format: Numeric * Fixed length: 3 digits
        /// </summary>
        /// <value>The identifier of the sub-merchant&#x27;s bank. In Brazil, this is the three-digit bank number format specified by the Central Bank of Brazil (BACEN). * Format: Numeric * Fixed length: 3 digits</value>
        [DataMember(Name = "subMerchant.subSeller[subSellerNr].creditSettlementBank", EmitDefaultValue = false)]
        public string SubMerchantSubSellerSubSellerNrCreditSettlementBank { get; set; }

        /// <summary>
        /// The sub-merchant&#x27;s bank account number with the check digit number and without punctuations or dashes. * Format: Numeric * Maximum length: 12 digits
        /// </summary>
        /// <value>The sub-merchant&#x27;s bank account number with the check digit number and without punctuations or dashes. * Format: Numeric * Maximum length: 12 digits</value>
        [DataMember(Name = "subMerchant.subSeller[subSellerNr].debitSettlementAccount", EmitDefaultValue = false)]
        public string SubMerchantSubSellerSubSellerNrDebitSettlementAccount { get; set; }

        /// <summary>
        /// A two-letter indicator of the type of the sub-merchant&#x27;s bank account. Possible values:   - **CC** - Checking account  - **CD** - Deposit account  - **PG** - Payments account  - **PP** - Savings account 
        /// </summary>
        /// <value>A two-letter indicator of the type of the sub-merchant&#x27;s bank account. Possible values:   - **CC** - Checking account  - **CD** - Deposit account  - **PG** - Payments account  - **PP** - Savings account </value>
        [DataMember(Name = "subMerchant.subSeller[subSellerNr].debitSettlementAccountType", EmitDefaultValue = false)]
        public string SubMerchantSubSellerSubSellerNrDebitSettlementAccountType { get; set; }

        /// <summary>
        /// The four-digit branch code of the sub-merchant&#x27;s bank, without the check digit, slashes, or dashes. * Format: Numeric * Fixed length: 4 digits
        /// </summary>
        /// <value>The four-digit branch code of the sub-merchant&#x27;s bank, without the check digit, slashes, or dashes. * Format: Numeric * Fixed length: 4 digits</value>
        [DataMember(Name = "subMerchant.subSeller[subSellerNr].debitSettlementAgency", EmitDefaultValue = false)]
        public string SubMerchantSubSellerSubSellerNrDebitSettlementAgency { get; set; }

        /// <summary>
        /// The identifier of the sub-merchant&#x27;s bank. In Brazil, this is the three-digit bank number format specified by the Central Bank of Brazil (BACEN). * Format: Numeric * Fixed length: 3 digits
        /// </summary>
        /// <value>The identifier of the sub-merchant&#x27;s bank. In Brazil, this is the three-digit bank number format specified by the Central Bank of Brazil (BACEN). * Format: Numeric * Fixed length: 3 digits</value>
        [DataMember(Name = "subMerchant.subSeller[subSellerNr].debitSettlementBank", EmitDefaultValue = false)]
        public string SubMerchantSubSellerSubSellerNrDebitSettlementBank { get; set; }

        /// <summary>
        /// Required for transactions performed by registered payment facilitators. A unique identifier that you create for the sub-merchant, used by schemes to identify the sub-merchant.  * Format: Alphanumeric * Maximum length: 15 characters
        /// </summary>
        /// <value>Required for transactions performed by registered payment facilitators. A unique identifier that you create for the sub-merchant, used by schemes to identify the sub-merchant.  * Format: Alphanumeric * Maximum length: 15 characters</value>
        [DataMember(Name = "subMerchant.subSeller[subSellerNr].id", EmitDefaultValue = false)]
        public string SubMerchantSubSellerSubSellerNrId { get; set; }

        /// <summary>
        /// Required for transactions performed by registered payment facilitators. The sub-merchant&#x27;s 4-digit Merchant Category Code (MCC).  * Format: Numeric * Fixed length: 4 digits
        /// </summary>
        /// <value>Required for transactions performed by registered payment facilitators. The sub-merchant&#x27;s 4-digit Merchant Category Code (MCC).  * Format: Numeric * Fixed length: 4 digits</value>
        [DataMember(Name = "subMerchant.subSeller[subSellerNr].mcc", EmitDefaultValue = false)]
        public string SubMerchantSubSellerSubSellerNrMcc { get; set; }

        /// <summary>
        /// Required for transactions performed by registered payment facilitators. The name of the sub-merchant. Based on scheme specifications, this value will overwrite the shopper statement  that will appear in the card statement. * Format: Alphanumeric * Maximum length: 22 characters
        /// </summary>
        /// <value>Required for transactions performed by registered payment facilitators. The name of the sub-merchant. Based on scheme specifications, this value will overwrite the shopper statement  that will appear in the card statement. * Format: Alphanumeric * Maximum length: 22 characters</value>
        [DataMember(Name = "subMerchant.subSeller[subSellerNr].name", EmitDefaultValue = false)]
        public string SubMerchantSubSellerSubSellerNrName { get; set; }

        /// <summary>
        /// Required for transactions performed by registered payment facilitators. The postal code of the sub-merchant&#x27;s address, without dashes. * Format: Numeric * Fixed length: 8 digits
        /// </summary>
        /// <value>Required for transactions performed by registered payment facilitators. The postal code of the sub-merchant&#x27;s address, without dashes. * Format: Numeric * Fixed length: 8 digits</value>
        [DataMember(Name = "subMerchant.subSeller[subSellerNr].postalCode", EmitDefaultValue = false)]
        public string SubMerchantSubSellerSubSellerNrPostalCode { get; set; }

        /// <summary>
        /// Required for transactions performed by registered payment facilitators. The state code of the sub-merchant&#x27;s address, if applicable to the country. * Format: Alphanumeric * Maximum length: 2 characters
        /// </summary>
        /// <value>Required for transactions performed by registered payment facilitators. The state code of the sub-merchant&#x27;s address, if applicable to the country. * Format: Alphanumeric * Maximum length: 2 characters</value>
        [DataMember(Name = "subMerchant.subSeller[subSellerNr].state", EmitDefaultValue = false)]
        public string SubMerchantSubSellerSubSellerNrState { get; set; }

        /// <summary>
        /// Required for transactions performed by registered payment facilitators. The street name and house number of the sub-merchant&#x27;s address. * Format: Alphanumeric * Maximum length: 60 characters
        /// </summary>
        /// <value>Required for transactions performed by registered payment facilitators. The street name and house number of the sub-merchant&#x27;s address. * Format: Alphanumeric * Maximum length: 60 characters</value>
        [DataMember(Name = "subMerchant.subSeller[subSellerNr].street", EmitDefaultValue = false)]
        public string SubMerchantSubSellerSubSellerNrStreet { get; set; }

        /// <summary>
        /// Required for transactions performed by registered payment facilitators. The tax ID of the sub-merchant. * Format: Numeric * Fixed length: 11 digits for the CPF or 14 digits for the CNPJ
        /// </summary>
        /// <value>Required for transactions performed by registered payment facilitators. The tax ID of the sub-merchant. * Format: Numeric * Fixed length: 11 digits for the CPF or 14 digits for the CNPJ</value>
        [DataMember(Name = "subMerchant.subSeller[subSellerNr].taxId", EmitDefaultValue = false)]
        public string SubMerchantSubSellerSubSellerNrTaxId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalDataSubMerchant {\n");
            sb.Append("  SubMerchantNumberOfSubSellers: ").Append(SubMerchantNumberOfSubSellers).Append("\n");
            sb.Append("  SubMerchantSubSellerSubSellerNrCity: ").Append(SubMerchantSubSellerSubSellerNrCity)
                .Append("\n");
            sb.Append("  SubMerchantSubSellerSubSellerNrCountry: ").Append(SubMerchantSubSellerSubSellerNrCountry)
                .Append("\n");
            sb.Append("  SubMerchantSubSellerSubSellerNrCreditSettlementAccount: ")
                .Append(SubMerchantSubSellerSubSellerNrCreditSettlementAccount).Append("\n");
            sb.Append("  SubMerchantSubSellerSubSellerNrCreditSettlementAccountType: ")
                .Append(SubMerchantSubSellerSubSellerNrCreditSettlementAccountType).Append("\n");
            sb.Append("  SubMerchantSubSellerSubSellerNrCreditSettlementAgency: ")
                .Append(SubMerchantSubSellerSubSellerNrCreditSettlementAgency).Append("\n");
            sb.Append("  SubMerchantSubSellerSubSellerNrCreditSettlementBank: ")
                .Append(SubMerchantSubSellerSubSellerNrCreditSettlementBank).Append("\n");
            sb.Append("  SubMerchantSubSellerSubSellerNrDebitSettlementAccount: ")
                .Append(SubMerchantSubSellerSubSellerNrDebitSettlementAccount).Append("\n");
            sb.Append("  SubMerchantSubSellerSubSellerNrDebitSettlementAccountType: ")
                .Append(SubMerchantSubSellerSubSellerNrDebitSettlementAccountType).Append("\n");
            sb.Append("  SubMerchantSubSellerSubSellerNrDebitSettlementAgency: ")
                .Append(SubMerchantSubSellerSubSellerNrDebitSettlementAgency).Append("\n");
            sb.Append("  SubMerchantSubSellerSubSellerNrDebitSettlementBank: ")
                .Append(SubMerchantSubSellerSubSellerNrDebitSettlementBank).Append("\n");
            sb.Append("  SubMerchantSubSellerSubSellerNrId: ").Append(SubMerchantSubSellerSubSellerNrId).Append("\n");
            sb.Append("  SubMerchantSubSellerSubSellerNrMcc: ").Append(SubMerchantSubSellerSubSellerNrMcc).Append("\n");
            sb.Append("  SubMerchantSubSellerSubSellerNrName: ").Append(SubMerchantSubSellerSubSellerNrName)
                .Append("\n");
            sb.Append("  SubMerchantSubSellerSubSellerNrPostalCode: ").Append(SubMerchantSubSellerSubSellerNrPostalCode)
                .Append("\n");
            sb.Append("  SubMerchantSubSellerSubSellerNrState: ").Append(SubMerchantSubSellerSubSellerNrState)
                .Append("\n");
            sb.Append("  SubMerchantSubSellerSubSellerNrStreet: ").Append(SubMerchantSubSellerSubSellerNrStreet)
                .Append("\n");
            sb.Append("  SubMerchantSubSellerSubSellerNrTaxId: ").Append(SubMerchantSubSellerSubSellerNrTaxId)
                .Append("\n");
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
            return this.Equals(input as AdditionalDataSubMerchant);
        }

        /// <summary>
        /// Returns true if AdditionalDataSubMerchant instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalDataSubMerchant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalDataSubMerchant input)
        {
            if (input == null)
                return false;

            return
                (
                    this.SubMerchantNumberOfSubSellers == input.SubMerchantNumberOfSubSellers ||
                    this.SubMerchantNumberOfSubSellers != null &&
                    this.SubMerchantNumberOfSubSellers.Equals(input.SubMerchantNumberOfSubSellers)
                ) &&
                (
                    this.SubMerchantSubSellerSubSellerNrCity == input.SubMerchantSubSellerSubSellerNrCity ||
                    this.SubMerchantSubSellerSubSellerNrCity != null &&
                    this.SubMerchantSubSellerSubSellerNrCity.Equals(input.SubMerchantSubSellerSubSellerNrCity)
                ) &&
                (
                    this.SubMerchantSubSellerSubSellerNrCountry == input.SubMerchantSubSellerSubSellerNrCountry ||
                    this.SubMerchantSubSellerSubSellerNrCountry != null &&
                    this.SubMerchantSubSellerSubSellerNrCountry.Equals(input.SubMerchantSubSellerSubSellerNrCountry)
                ) &&
                (
                    this.SubMerchantSubSellerSubSellerNrCreditSettlementAccount ==
                    input.SubMerchantSubSellerSubSellerNrCreditSettlementAccount ||
                    this.SubMerchantSubSellerSubSellerNrCreditSettlementAccount != null &&
                    this.SubMerchantSubSellerSubSellerNrCreditSettlementAccount.Equals(
                        input.SubMerchantSubSellerSubSellerNrCreditSettlementAccount)
                ) &&
                (
                    this.SubMerchantSubSellerSubSellerNrCreditSettlementAccountType ==
                    input.SubMerchantSubSellerSubSellerNrCreditSettlementAccountType ||
                    this.SubMerchantSubSellerSubSellerNrCreditSettlementAccountType != null &&
                    this.SubMerchantSubSellerSubSellerNrCreditSettlementAccountType.Equals(
                        input.SubMerchantSubSellerSubSellerNrCreditSettlementAccountType)
                ) &&
                (
                    this.SubMerchantSubSellerSubSellerNrCreditSettlementAgency ==
                    input.SubMerchantSubSellerSubSellerNrCreditSettlementAgency ||
                    this.SubMerchantSubSellerSubSellerNrCreditSettlementAgency != null &&
                    this.SubMerchantSubSellerSubSellerNrCreditSettlementAgency.Equals(
                        input.SubMerchantSubSellerSubSellerNrCreditSettlementAgency)
                ) &&
                (
                    this.SubMerchantSubSellerSubSellerNrCreditSettlementBank ==
                    input.SubMerchantSubSellerSubSellerNrCreditSettlementBank ||
                    this.SubMerchantSubSellerSubSellerNrCreditSettlementBank != null &&
                    this.SubMerchantSubSellerSubSellerNrCreditSettlementBank.Equals(input
                        .SubMerchantSubSellerSubSellerNrCreditSettlementBank)
                ) &&
                (
                    this.SubMerchantSubSellerSubSellerNrDebitSettlementAccount ==
                    input.SubMerchantSubSellerSubSellerNrDebitSettlementAccount ||
                    this.SubMerchantSubSellerSubSellerNrDebitSettlementAccount != null &&
                    this.SubMerchantSubSellerSubSellerNrDebitSettlementAccount.Equals(
                        input.SubMerchantSubSellerSubSellerNrDebitSettlementAccount)
                ) &&
                (
                    this.SubMerchantSubSellerSubSellerNrDebitSettlementAccountType ==
                    input.SubMerchantSubSellerSubSellerNrDebitSettlementAccountType ||
                    this.SubMerchantSubSellerSubSellerNrDebitSettlementAccountType != null &&
                    this.SubMerchantSubSellerSubSellerNrDebitSettlementAccountType.Equals(
                        input.SubMerchantSubSellerSubSellerNrDebitSettlementAccountType)
                ) &&
                (
                    this.SubMerchantSubSellerSubSellerNrDebitSettlementAgency ==
                    input.SubMerchantSubSellerSubSellerNrDebitSettlementAgency ||
                    this.SubMerchantSubSellerSubSellerNrDebitSettlementAgency != null &&
                    this.SubMerchantSubSellerSubSellerNrDebitSettlementAgency.Equals(
                        input.SubMerchantSubSellerSubSellerNrDebitSettlementAgency)
                ) &&
                (
                    this.SubMerchantSubSellerSubSellerNrDebitSettlementBank ==
                    input.SubMerchantSubSellerSubSellerNrDebitSettlementBank ||
                    this.SubMerchantSubSellerSubSellerNrDebitSettlementBank != null &&
                    this.SubMerchantSubSellerSubSellerNrDebitSettlementBank.Equals(input
                        .SubMerchantSubSellerSubSellerNrDebitSettlementBank)
                ) &&
                (
                    this.SubMerchantSubSellerSubSellerNrId == input.SubMerchantSubSellerSubSellerNrId ||
                    this.SubMerchantSubSellerSubSellerNrId != null &&
                    this.SubMerchantSubSellerSubSellerNrId.Equals(input.SubMerchantSubSellerSubSellerNrId)
                ) &&
                (
                    this.SubMerchantSubSellerSubSellerNrMcc == input.SubMerchantSubSellerSubSellerNrMcc ||
                    this.SubMerchantSubSellerSubSellerNrMcc != null &&
                    this.SubMerchantSubSellerSubSellerNrMcc.Equals(input.SubMerchantSubSellerSubSellerNrMcc)
                ) &&
                (
                    this.SubMerchantSubSellerSubSellerNrName == input.SubMerchantSubSellerSubSellerNrName ||
                    this.SubMerchantSubSellerSubSellerNrName != null &&
                    this.SubMerchantSubSellerSubSellerNrName.Equals(input.SubMerchantSubSellerSubSellerNrName)
                ) &&
                (
                    this.SubMerchantSubSellerSubSellerNrPostalCode == input.SubMerchantSubSellerSubSellerNrPostalCode ||
                    this.SubMerchantSubSellerSubSellerNrPostalCode != null &&
                    this.SubMerchantSubSellerSubSellerNrPostalCode.Equals(input
                        .SubMerchantSubSellerSubSellerNrPostalCode)
                ) &&
                (
                    this.SubMerchantSubSellerSubSellerNrState == input.SubMerchantSubSellerSubSellerNrState ||
                    this.SubMerchantSubSellerSubSellerNrState != null &&
                    this.SubMerchantSubSellerSubSellerNrState.Equals(input.SubMerchantSubSellerSubSellerNrState)
                ) &&
                (
                    this.SubMerchantSubSellerSubSellerNrStreet == input.SubMerchantSubSellerSubSellerNrStreet ||
                    this.SubMerchantSubSellerSubSellerNrStreet != null &&
                    this.SubMerchantSubSellerSubSellerNrStreet.Equals(input.SubMerchantSubSellerSubSellerNrStreet)
                ) &&
                (
                    this.SubMerchantSubSellerSubSellerNrTaxId == input.SubMerchantSubSellerSubSellerNrTaxId ||
                    this.SubMerchantSubSellerSubSellerNrTaxId != null &&
                    this.SubMerchantSubSellerSubSellerNrTaxId.Equals(input.SubMerchantSubSellerSubSellerNrTaxId)
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
                if (this.SubMerchantNumberOfSubSellers != null)
                    hashCode = hashCode * 59 + this.SubMerchantNumberOfSubSellers.GetHashCode();
                if (this.SubMerchantSubSellerSubSellerNrCity != null)
                    hashCode = hashCode * 59 + this.SubMerchantSubSellerSubSellerNrCity.GetHashCode();
                if (this.SubMerchantSubSellerSubSellerNrCountry != null)
                    hashCode = hashCode * 59 + this.SubMerchantSubSellerSubSellerNrCountry.GetHashCode();
                if (this.SubMerchantSubSellerSubSellerNrCreditSettlementAccount != null)
                    hashCode = hashCode * 59 +
                               this.SubMerchantSubSellerSubSellerNrCreditSettlementAccount.GetHashCode();
                if (this.SubMerchantSubSellerSubSellerNrCreditSettlementAccountType != null)
                    hashCode = hashCode * 59 +
                               this.SubMerchantSubSellerSubSellerNrCreditSettlementAccountType.GetHashCode();
                if (this.SubMerchantSubSellerSubSellerNrCreditSettlementAgency != null)
                    hashCode = hashCode * 59 + this.SubMerchantSubSellerSubSellerNrCreditSettlementAgency.GetHashCode();
                if (this.SubMerchantSubSellerSubSellerNrCreditSettlementBank != null)
                    hashCode = hashCode * 59 + this.SubMerchantSubSellerSubSellerNrCreditSettlementBank.GetHashCode();
                if (this.SubMerchantSubSellerSubSellerNrDebitSettlementAccount != null)
                    hashCode = hashCode * 59 + this.SubMerchantSubSellerSubSellerNrDebitSettlementAccount.GetHashCode();
                if (this.SubMerchantSubSellerSubSellerNrDebitSettlementAccountType != null)
                    hashCode = hashCode * 59 +
                               this.SubMerchantSubSellerSubSellerNrDebitSettlementAccountType.GetHashCode();
                if (this.SubMerchantSubSellerSubSellerNrDebitSettlementAgency != null)
                    hashCode = hashCode * 59 + this.SubMerchantSubSellerSubSellerNrDebitSettlementAgency.GetHashCode();
                if (this.SubMerchantSubSellerSubSellerNrDebitSettlementBank != null)
                    hashCode = hashCode * 59 + this.SubMerchantSubSellerSubSellerNrDebitSettlementBank.GetHashCode();
                if (this.SubMerchantSubSellerSubSellerNrId != null)
                    hashCode = hashCode * 59 + this.SubMerchantSubSellerSubSellerNrId.GetHashCode();
                if (this.SubMerchantSubSellerSubSellerNrMcc != null)
                    hashCode = hashCode * 59 + this.SubMerchantSubSellerSubSellerNrMcc.GetHashCode();
                if (this.SubMerchantSubSellerSubSellerNrName != null)
                    hashCode = hashCode * 59 + this.SubMerchantSubSellerSubSellerNrName.GetHashCode();
                if (this.SubMerchantSubSellerSubSellerNrPostalCode != null)
                    hashCode = hashCode * 59 + this.SubMerchantSubSellerSubSellerNrPostalCode.GetHashCode();
                if (this.SubMerchantSubSellerSubSellerNrState != null)
                    hashCode = hashCode * 59 + this.SubMerchantSubSellerSubSellerNrState.GetHashCode();
                if (this.SubMerchantSubSellerSubSellerNrStreet != null)
                    hashCode = hashCode * 59 + this.SubMerchantSubSellerSubSellerNrStreet.GetHashCode();
                if (this.SubMerchantSubSellerSubSellerNrTaxId != null)
                    hashCode = hashCode * 59 + this.SubMerchantSubSellerSubSellerNrTaxId.GetHashCode();
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