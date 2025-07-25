/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 71
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// AdditionalDataSubMerchant
    /// </summary>
    [DataContract(Name = "AdditionalDataSubMerchant")]
    public partial class AdditionalDataSubMerchant : IEquatable<AdditionalDataSubMerchant>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataSubMerchant" /> class.
        /// </summary>
        /// <param name="subMerchantNumberOfSubSellers">Required for transactions performed by registered payment facilitators. Indicates the number of sub-merchants contained in the request. For example, **3**..</param>
        /// <param name="subMerchantSubSellerSubSellerNrCity">Required for transactions performed by registered payment facilitators. The city of the sub-merchant&#39;s address. * Format: Alphanumeric * Maximum length: 13 characters.</param>
        /// <param name="subMerchantSubSellerSubSellerNrCountry">Required for transactions performed by registered payment facilitators. The three-letter country code of the sub-merchant&#39;s address. For example, **BRA** for Brazil.  * Format: [ISO 3166-1 alpha-3](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3) * Fixed length: 3 characters.</param>
        /// <param name="subMerchantSubSellerSubSellerNrEmail">Required for transactions performed by registered payment facilitators. The email address of the sub-merchant. * Format: Alphanumeric * Maximum length: 40 characters.</param>
        /// <param name="subMerchantSubSellerSubSellerNrId">Required for transactions performed by registered payment facilitators. A unique identifier that you create for the sub-merchant, used by schemes to identify the sub-merchant.  * Format: Alphanumeric * Maximum length: 15 characters.</param>
        /// <param name="subMerchantSubSellerSubSellerNrMcc">Required for transactions performed by registered payment facilitators. The sub-merchant&#39;s 4-digit Merchant Category Code (MCC).  * Format: Numeric * Fixed length: 4 digits.</param>
        /// <param name="subMerchantSubSellerSubSellerNrName">Required for transactions performed by registered payment facilitators. The name of the sub-merchant. Based on scheme specifications, this value will overwrite the shopper statement  that will appear in the card statement. Exception: for acquirers in Brazil, this value does not overwrite the shopper statement. * Format: Alphanumeric * Maximum length: 22 characters.</param>
        /// <param name="subMerchantSubSellerSubSellerNrPhoneNumber">Required for transactions performed by registered payment facilitators. The phone number of the sub-merchant.* Format: Alphanumeric * Maximum length: 20 characters.</param>
        /// <param name="subMerchantSubSellerSubSellerNrPostalCode">Required for transactions performed by registered payment facilitators. The postal code of the sub-merchant&#39;s address, without dashes. * Format: Numeric * Fixed length: 8 digits.</param>
        /// <param name="subMerchantSubSellerSubSellerNrState">Required for transactions performed by registered payment facilitators. The state code of the sub-merchant&#39;s address, if applicable to the country. * Format: Alphanumeric * Maximum length: 2 characters.</param>
        /// <param name="subMerchantSubSellerSubSellerNrStreet">Required for transactions performed by registered payment facilitators. The street name and house number of the sub-merchant&#39;s address. * Format: Alphanumeric * Maximum length: 60 characters.</param>
        /// <param name="subMerchantSubSellerSubSellerNrTaxId">Required for transactions performed by registered payment facilitators. The tax ID of the sub-merchant. * Format: Numeric * Fixed length: 11 digits for the CPF or 14 digits for the CNPJ.</param>
        public AdditionalDataSubMerchant(string subMerchantNumberOfSubSellers = default(string), string subMerchantSubSellerSubSellerNrCity = default(string), string subMerchantSubSellerSubSellerNrCountry = default(string), string subMerchantSubSellerSubSellerNrEmail = default(string), string subMerchantSubSellerSubSellerNrId = default(string), string subMerchantSubSellerSubSellerNrMcc = default(string), string subMerchantSubSellerSubSellerNrName = default(string), string subMerchantSubSellerSubSellerNrPhoneNumber = default(string), string subMerchantSubSellerSubSellerNrPostalCode = default(string), string subMerchantSubSellerSubSellerNrState = default(string), string subMerchantSubSellerSubSellerNrStreet = default(string), string subMerchantSubSellerSubSellerNrTaxId = default(string))
        {
            this.SubMerchantNumberOfSubSellers = subMerchantNumberOfSubSellers;
            this.SubMerchantSubSellerSubSellerNrCity = subMerchantSubSellerSubSellerNrCity;
            this.SubMerchantSubSellerSubSellerNrCountry = subMerchantSubSellerSubSellerNrCountry;
            this.SubMerchantSubSellerSubSellerNrEmail = subMerchantSubSellerSubSellerNrEmail;
            this.SubMerchantSubSellerSubSellerNrId = subMerchantSubSellerSubSellerNrId;
            this.SubMerchantSubSellerSubSellerNrMcc = subMerchantSubSellerSubSellerNrMcc;
            this.SubMerchantSubSellerSubSellerNrName = subMerchantSubSellerSubSellerNrName;
            this.SubMerchantSubSellerSubSellerNrPhoneNumber = subMerchantSubSellerSubSellerNrPhoneNumber;
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
        /// Required for transactions performed by registered payment facilitators. The city of the sub-merchant&#39;s address. * Format: Alphanumeric * Maximum length: 13 characters
        /// </summary>
        /// <value>Required for transactions performed by registered payment facilitators. The city of the sub-merchant&#39;s address. * Format: Alphanumeric * Maximum length: 13 characters</value>
        [DataMember(Name = "subMerchant.subSeller[subSellerNr].city", EmitDefaultValue = false)]
        public string SubMerchantSubSellerSubSellerNrCity { get; set; }

        /// <summary>
        /// Required for transactions performed by registered payment facilitators. The three-letter country code of the sub-merchant&#39;s address. For example, **BRA** for Brazil.  * Format: [ISO 3166-1 alpha-3](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3) * Fixed length: 3 characters
        /// </summary>
        /// <value>Required for transactions performed by registered payment facilitators. The three-letter country code of the sub-merchant&#39;s address. For example, **BRA** for Brazil.  * Format: [ISO 3166-1 alpha-3](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3) * Fixed length: 3 characters</value>
        [DataMember(Name = "subMerchant.subSeller[subSellerNr].country", EmitDefaultValue = false)]
        public string SubMerchantSubSellerSubSellerNrCountry { get; set; }

        /// <summary>
        /// Required for transactions performed by registered payment facilitators. The email address of the sub-merchant. * Format: Alphanumeric * Maximum length: 40 characters
        /// </summary>
        /// <value>Required for transactions performed by registered payment facilitators. The email address of the sub-merchant. * Format: Alphanumeric * Maximum length: 40 characters</value>
        [DataMember(Name = "subMerchant.subSeller[subSellerNr].email", EmitDefaultValue = false)]
        public string SubMerchantSubSellerSubSellerNrEmail { get; set; }

        /// <summary>
        /// Required for transactions performed by registered payment facilitators. A unique identifier that you create for the sub-merchant, used by schemes to identify the sub-merchant.  * Format: Alphanumeric * Maximum length: 15 characters
        /// </summary>
        /// <value>Required for transactions performed by registered payment facilitators. A unique identifier that you create for the sub-merchant, used by schemes to identify the sub-merchant.  * Format: Alphanumeric * Maximum length: 15 characters</value>
        [DataMember(Name = "subMerchant.subSeller[subSellerNr].id", EmitDefaultValue = false)]
        public string SubMerchantSubSellerSubSellerNrId { get; set; }

        /// <summary>
        /// Required for transactions performed by registered payment facilitators. The sub-merchant&#39;s 4-digit Merchant Category Code (MCC).  * Format: Numeric * Fixed length: 4 digits
        /// </summary>
        /// <value>Required for transactions performed by registered payment facilitators. The sub-merchant&#39;s 4-digit Merchant Category Code (MCC).  * Format: Numeric * Fixed length: 4 digits</value>
        [DataMember(Name = "subMerchant.subSeller[subSellerNr].mcc", EmitDefaultValue = false)]
        public string SubMerchantSubSellerSubSellerNrMcc { get; set; }

        /// <summary>
        /// Required for transactions performed by registered payment facilitators. The name of the sub-merchant. Based on scheme specifications, this value will overwrite the shopper statement  that will appear in the card statement. Exception: for acquirers in Brazil, this value does not overwrite the shopper statement. * Format: Alphanumeric * Maximum length: 22 characters
        /// </summary>
        /// <value>Required for transactions performed by registered payment facilitators. The name of the sub-merchant. Based on scheme specifications, this value will overwrite the shopper statement  that will appear in the card statement. Exception: for acquirers in Brazil, this value does not overwrite the shopper statement. * Format: Alphanumeric * Maximum length: 22 characters</value>
        [DataMember(Name = "subMerchant.subSeller[subSellerNr].name", EmitDefaultValue = false)]
        public string SubMerchantSubSellerSubSellerNrName { get; set; }

        /// <summary>
        /// Required for transactions performed by registered payment facilitators. The phone number of the sub-merchant.* Format: Alphanumeric * Maximum length: 20 characters
        /// </summary>
        /// <value>Required for transactions performed by registered payment facilitators. The phone number of the sub-merchant.* Format: Alphanumeric * Maximum length: 20 characters</value>
        [DataMember(Name = "subMerchant.subSeller[subSellerNr].phoneNumber", EmitDefaultValue = false)]
        public string SubMerchantSubSellerSubSellerNrPhoneNumber { get; set; }

        /// <summary>
        /// Required for transactions performed by registered payment facilitators. The postal code of the sub-merchant&#39;s address, without dashes. * Format: Numeric * Fixed length: 8 digits
        /// </summary>
        /// <value>Required for transactions performed by registered payment facilitators. The postal code of the sub-merchant&#39;s address, without dashes. * Format: Numeric * Fixed length: 8 digits</value>
        [DataMember(Name = "subMerchant.subSeller[subSellerNr].postalCode", EmitDefaultValue = false)]
        public string SubMerchantSubSellerSubSellerNrPostalCode { get; set; }

        /// <summary>
        /// Required for transactions performed by registered payment facilitators. The state code of the sub-merchant&#39;s address, if applicable to the country. * Format: Alphanumeric * Maximum length: 2 characters
        /// </summary>
        /// <value>Required for transactions performed by registered payment facilitators. The state code of the sub-merchant&#39;s address, if applicable to the country. * Format: Alphanumeric * Maximum length: 2 characters</value>
        [DataMember(Name = "subMerchant.subSeller[subSellerNr].state", EmitDefaultValue = false)]
        public string SubMerchantSubSellerSubSellerNrState { get; set; }

        /// <summary>
        /// Required for transactions performed by registered payment facilitators. The street name and house number of the sub-merchant&#39;s address. * Format: Alphanumeric * Maximum length: 60 characters
        /// </summary>
        /// <value>Required for transactions performed by registered payment facilitators. The street name and house number of the sub-merchant&#39;s address. * Format: Alphanumeric * Maximum length: 60 characters</value>
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
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdditionalDataSubMerchant {\n");
            sb.Append("  SubMerchantNumberOfSubSellers: ").Append(SubMerchantNumberOfSubSellers).Append("\n");
            sb.Append("  SubMerchantSubSellerSubSellerNrCity: ").Append(SubMerchantSubSellerSubSellerNrCity).Append("\n");
            sb.Append("  SubMerchantSubSellerSubSellerNrCountry: ").Append(SubMerchantSubSellerSubSellerNrCountry).Append("\n");
            sb.Append("  SubMerchantSubSellerSubSellerNrEmail: ").Append(SubMerchantSubSellerSubSellerNrEmail).Append("\n");
            sb.Append("  SubMerchantSubSellerSubSellerNrId: ").Append(SubMerchantSubSellerSubSellerNrId).Append("\n");
            sb.Append("  SubMerchantSubSellerSubSellerNrMcc: ").Append(SubMerchantSubSellerSubSellerNrMcc).Append("\n");
            sb.Append("  SubMerchantSubSellerSubSellerNrName: ").Append(SubMerchantSubSellerSubSellerNrName).Append("\n");
            sb.Append("  SubMerchantSubSellerSubSellerNrPhoneNumber: ").Append(SubMerchantSubSellerSubSellerNrPhoneNumber).Append("\n");
            sb.Append("  SubMerchantSubSellerSubSellerNrPostalCode: ").Append(SubMerchantSubSellerSubSellerNrPostalCode).Append("\n");
            sb.Append("  SubMerchantSubSellerSubSellerNrState: ").Append(SubMerchantSubSellerSubSellerNrState).Append("\n");
            sb.Append("  SubMerchantSubSellerSubSellerNrStreet: ").Append(SubMerchantSubSellerSubSellerNrStreet).Append("\n");
            sb.Append("  SubMerchantSubSellerSubSellerNrTaxId: ").Append(SubMerchantSubSellerSubSellerNrTaxId).Append("\n");
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
            {
                return false;
            }
            return 
                (
                    this.SubMerchantNumberOfSubSellers == input.SubMerchantNumberOfSubSellers ||
                    (this.SubMerchantNumberOfSubSellers != null &&
                    this.SubMerchantNumberOfSubSellers.Equals(input.SubMerchantNumberOfSubSellers))
                ) && 
                (
                    this.SubMerchantSubSellerSubSellerNrCity == input.SubMerchantSubSellerSubSellerNrCity ||
                    (this.SubMerchantSubSellerSubSellerNrCity != null &&
                    this.SubMerchantSubSellerSubSellerNrCity.Equals(input.SubMerchantSubSellerSubSellerNrCity))
                ) && 
                (
                    this.SubMerchantSubSellerSubSellerNrCountry == input.SubMerchantSubSellerSubSellerNrCountry ||
                    (this.SubMerchantSubSellerSubSellerNrCountry != null &&
                    this.SubMerchantSubSellerSubSellerNrCountry.Equals(input.SubMerchantSubSellerSubSellerNrCountry))
                ) && 
                (
                    this.SubMerchantSubSellerSubSellerNrEmail == input.SubMerchantSubSellerSubSellerNrEmail ||
                    (this.SubMerchantSubSellerSubSellerNrEmail != null &&
                    this.SubMerchantSubSellerSubSellerNrEmail.Equals(input.SubMerchantSubSellerSubSellerNrEmail))
                ) && 
                (
                    this.SubMerchantSubSellerSubSellerNrId == input.SubMerchantSubSellerSubSellerNrId ||
                    (this.SubMerchantSubSellerSubSellerNrId != null &&
                    this.SubMerchantSubSellerSubSellerNrId.Equals(input.SubMerchantSubSellerSubSellerNrId))
                ) && 
                (
                    this.SubMerchantSubSellerSubSellerNrMcc == input.SubMerchantSubSellerSubSellerNrMcc ||
                    (this.SubMerchantSubSellerSubSellerNrMcc != null &&
                    this.SubMerchantSubSellerSubSellerNrMcc.Equals(input.SubMerchantSubSellerSubSellerNrMcc))
                ) && 
                (
                    this.SubMerchantSubSellerSubSellerNrName == input.SubMerchantSubSellerSubSellerNrName ||
                    (this.SubMerchantSubSellerSubSellerNrName != null &&
                    this.SubMerchantSubSellerSubSellerNrName.Equals(input.SubMerchantSubSellerSubSellerNrName))
                ) && 
                (
                    this.SubMerchantSubSellerSubSellerNrPhoneNumber == input.SubMerchantSubSellerSubSellerNrPhoneNumber ||
                    (this.SubMerchantSubSellerSubSellerNrPhoneNumber != null &&
                    this.SubMerchantSubSellerSubSellerNrPhoneNumber.Equals(input.SubMerchantSubSellerSubSellerNrPhoneNumber))
                ) && 
                (
                    this.SubMerchantSubSellerSubSellerNrPostalCode == input.SubMerchantSubSellerSubSellerNrPostalCode ||
                    (this.SubMerchantSubSellerSubSellerNrPostalCode != null &&
                    this.SubMerchantSubSellerSubSellerNrPostalCode.Equals(input.SubMerchantSubSellerSubSellerNrPostalCode))
                ) && 
                (
                    this.SubMerchantSubSellerSubSellerNrState == input.SubMerchantSubSellerSubSellerNrState ||
                    (this.SubMerchantSubSellerSubSellerNrState != null &&
                    this.SubMerchantSubSellerSubSellerNrState.Equals(input.SubMerchantSubSellerSubSellerNrState))
                ) && 
                (
                    this.SubMerchantSubSellerSubSellerNrStreet == input.SubMerchantSubSellerSubSellerNrStreet ||
                    (this.SubMerchantSubSellerSubSellerNrStreet != null &&
                    this.SubMerchantSubSellerSubSellerNrStreet.Equals(input.SubMerchantSubSellerSubSellerNrStreet))
                ) && 
                (
                    this.SubMerchantSubSellerSubSellerNrTaxId == input.SubMerchantSubSellerSubSellerNrTaxId ||
                    (this.SubMerchantSubSellerSubSellerNrTaxId != null &&
                    this.SubMerchantSubSellerSubSellerNrTaxId.Equals(input.SubMerchantSubSellerSubSellerNrTaxId))
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
                {
                    hashCode = (hashCode * 59) + this.SubMerchantNumberOfSubSellers.GetHashCode();
                }
                if (this.SubMerchantSubSellerSubSellerNrCity != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchantSubSellerSubSellerNrCity.GetHashCode();
                }
                if (this.SubMerchantSubSellerSubSellerNrCountry != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchantSubSellerSubSellerNrCountry.GetHashCode();
                }
                if (this.SubMerchantSubSellerSubSellerNrEmail != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchantSubSellerSubSellerNrEmail.GetHashCode();
                }
                if (this.SubMerchantSubSellerSubSellerNrId != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchantSubSellerSubSellerNrId.GetHashCode();
                }
                if (this.SubMerchantSubSellerSubSellerNrMcc != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchantSubSellerSubSellerNrMcc.GetHashCode();
                }
                if (this.SubMerchantSubSellerSubSellerNrName != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchantSubSellerSubSellerNrName.GetHashCode();
                }
                if (this.SubMerchantSubSellerSubSellerNrPhoneNumber != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchantSubSellerSubSellerNrPhoneNumber.GetHashCode();
                }
                if (this.SubMerchantSubSellerSubSellerNrPostalCode != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchantSubSellerSubSellerNrPostalCode.GetHashCode();
                }
                if (this.SubMerchantSubSellerSubSellerNrState != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchantSubSellerSubSellerNrState.GetHashCode();
                }
                if (this.SubMerchantSubSellerSubSellerNrStreet != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchantSubSellerSubSellerNrStreet.GetHashCode();
                }
                if (this.SubMerchantSubSellerSubSellerNrTaxId != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchantSubSellerSubSellerNrTaxId.GetHashCode();
                }
                return hashCode;
            }
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
