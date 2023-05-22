/*
* Legal Entity Management API
*
*
* The version of the OpenAPI document: 3
* Contact: developer-experience@adyen.com
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

namespace Adyen.Model.LegalEntityManagement
{
    /// <summary>
    /// BankAccountInfo
    /// </summary>
    [DataContract(Name = "BankAccountInfo")]
    public partial class BankAccountInfo : IEquatable<BankAccountInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountInfo" /> class.
        /// </summary>
        /// <param name="accountIdentification">accountIdentification.</param>
        /// <param name="accountType">The type of bank account..</param>
        /// <param name="countryCode">The two-character [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code where the bank account is registered. For example, **NL**..</param>
        public BankAccountInfo(BankAccountInfoAccountIdentification accountIdentification = default(BankAccountInfoAccountIdentification), string accountType = default(string), string countryCode = default(string))
        {
            this.AccountIdentification = accountIdentification;
            this.AccountType = accountType;
            this.CountryCode = countryCode;
        }

        /// <summary>
        /// Gets or Sets AccountIdentification
        /// </summary>
        [DataMember(Name = "accountIdentification", EmitDefaultValue = false)]
        public BankAccountInfoAccountIdentification AccountIdentification { get; set; }

        /// <summary>
        /// The type of bank account.
        /// </summary>
        /// <value>The type of bank account.</value>
        [DataMember(Name = "accountType", EmitDefaultValue = false)]
        [Obsolete]
        public string AccountType { get; set; }

        /// <summary>
        /// The two-character [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code where the bank account is registered. For example, **NL**.
        /// </summary>
        /// <value>The two-character [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code where the bank account is registered. For example, **NL**.</value>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Identifies if the bank account was created through [instant bank verification](https://docs.adyen.com/release-notes/platforms-and-financial-products#releaseNote&#x3D;2023-05-08-hosted-onboarding).
        /// </summary>
        /// <value>Identifies if the bank account was created through [instant bank verification](https://docs.adyen.com/release-notes/platforms-and-financial-products#releaseNote&#x3D;2023-05-08-hosted-onboarding).</value>
        [DataMember(Name = "trustedSource", EmitDefaultValue = false)]
        public bool TrustedSource { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BankAccountInfo {\n");
            sb.Append("  AccountIdentification: ").Append(AccountIdentification).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  TrustedSource: ").Append(TrustedSource).Append("\n");
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
            return this.Equals(input as BankAccountInfo);
        }

        /// <summary>
        /// Returns true if BankAccountInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of BankAccountInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankAccountInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountIdentification == input.AccountIdentification ||
                    (this.AccountIdentification != null &&
                    this.AccountIdentification.Equals(input.AccountIdentification))
                ) && 
                (
                    this.AccountType == input.AccountType ||
                    (this.AccountType != null &&
                    this.AccountType.Equals(input.AccountType))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.TrustedSource == input.TrustedSource ||
                    this.TrustedSource.Equals(input.TrustedSource)
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
                if (this.AccountIdentification != null)
                {
                    hashCode = (hashCode * 59) + this.AccountIdentification.GetHashCode();
                }
                if (this.AccountType != null)
                {
                    hashCode = (hashCode * 59) + this.AccountType.GetHashCode();
                }
                if (this.CountryCode != null)
                {
                    hashCode = (hashCode * 59) + this.CountryCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TrustedSource.GetHashCode();
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
