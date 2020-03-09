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
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// CreateAccountHolderRequest
    /// </summary>
    [DataContract]
        public partial class CreateAccountHolderRequest :  IEquatable<CreateAccountHolderRequest>, IValidatableObject
    {
        /// <summary>
        /// The entity type. Permitted values: &#x60;Business&#x60;, &#x60;Individual&#x60;  If an account holder is &#x27;Business&#x27;, then &#x60;accountHolderDetails.businessDetails&#x60; must be provided, as well as at least one entry in the &#x60;accountHolderDetails.businessDetails.shareholders&#x60; list.  If an account holder is &#x27;Individual&#x27;, then &#x60;accountHolderDetails.individualDetails&#x60; must be provided.
        /// </summary>
        /// <value>The entity type. Permitted values: &#x60;Business&#x60;, &#x60;Individual&#x60;  If an account holder is &#x27;Business&#x27;, then &#x60;accountHolderDetails.businessDetails&#x60; must be provided, as well as at least one entry in the &#x60;accountHolderDetails.businessDetails.shareholders&#x60; list.  If an account holder is &#x27;Individual&#x27;, then &#x60;accountHolderDetails.individualDetails&#x60; must be provided.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum LegalEntityEnum
        {
            /// <summary>
            /// Enum Business for value: Business
            /// </summary>
            [EnumMember(Value = "Business")]
            Business = 1,
            /// <summary>
            /// Enum Individual for value: Individual
            /// </summary>
            [EnumMember(Value = "Individual")]
            Individual = 2,
            /// <summary>
            /// Enum NonProfit for value: NonProfit
            /// </summary>
            [EnumMember(Value = "NonProfit")]
            NonProfit = 3,
            /// <summary>
            /// Enum PublicCompany for value: PublicCompany
            /// </summary>
            [EnumMember(Value = "PublicCompany")]
            PublicCompany = 4        }
        /// <summary>
        /// The entity type. Permitted values: &#x60;Business&#x60;, &#x60;Individual&#x60;  If an account holder is &#x27;Business&#x27;, then &#x60;accountHolderDetails.businessDetails&#x60; must be provided, as well as at least one entry in the &#x60;accountHolderDetails.businessDetails.shareholders&#x60; list.  If an account holder is &#x27;Individual&#x27;, then &#x60;accountHolderDetails.individualDetails&#x60; must be provided.
        /// </summary>
        /// <value>The entity type. Permitted values: &#x60;Business&#x60;, &#x60;Individual&#x60;  If an account holder is &#x27;Business&#x27;, then &#x60;accountHolderDetails.businessDetails&#x60; must be provided, as well as at least one entry in the &#x60;accountHolderDetails.businessDetails.shareholders&#x60; list.  If an account holder is &#x27;Individual&#x27;, then &#x60;accountHolderDetails.individualDetails&#x60; must be provided.</value>
        [DataMember(Name="legalEntity", EmitDefaultValue=false)]
        public LegalEntityEnum LegalEntity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccountHolderRequest" /> class.
        /// </summary>
        /// <param name="accountHolderCode">The desired code of the prospective account holder. &gt; Must be between three (3) and fifty (50) characters long. Only letters, digits, and hyphens (-) are permitted. (required).</param>
        /// <param name="accountHolderDetails">accountHolderDetails (required).</param>
        /// <param name="createDefaultAccount">If set to true, an account with the default options is created for this account holder. **Default Value:** true.</param>
        /// <param name="description">A description of the prospective account holder..</param>
        /// <param name="legalEntity">The entity type. Permitted values: &#x60;Business&#x60;, &#x60;Individual&#x60;  If an account holder is &#x27;Business&#x27;, then &#x60;accountHolderDetails.businessDetails&#x60; must be provided, as well as at least one entry in the &#x60;accountHolderDetails.businessDetails.shareholders&#x60; list.  If an account holder is &#x27;Individual&#x27;, then &#x60;accountHolderDetails.individualDetails&#x60; must be provided. (required).</param>
        /// <param name="primaryCurrency">The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes), with which the prospective account holder primarily deals..</param>
        /// <param name="processingTier">The starting [processing tier](https://docs.adyen.com/marketpay/onboarding-and-verification/verification-checks#tiers) for the prospective account holder..</param>
        public CreateAccountHolderRequest(string accountHolderCode = default(string), AccountHolderDetails accountHolderDetails = default(AccountHolderDetails), bool? createDefaultAccount = default(bool?), string description = default(string), LegalEntityEnum legalEntity = default(LegalEntityEnum), string primaryCurrency = default(string), int? processingTier = default(int?))
        {
            // to ensure "accountHolderCode" is required (not null)
            if (accountHolderCode == null)
            {
                throw new InvalidDataException("accountHolderCode is a required property for CreateAccountHolderRequest and cannot be null");
            }
            else
            {
                this.AccountHolderCode = accountHolderCode;
            }
            // to ensure "accountHolderDetails" is required (not null)
            if (accountHolderDetails == null)
            {
                throw new InvalidDataException("accountHolderDetails is a required property for CreateAccountHolderRequest and cannot be null");
            }
            else
            {
                this.AccountHolderDetails = accountHolderDetails;
            }
            // to ensure "legalEntity" is required (not null)
            if (legalEntity == null)
            {
                throw new InvalidDataException("legalEntity is a required property for CreateAccountHolderRequest and cannot be null");
            }
            else
            {
                this.LegalEntity = legalEntity;
            }
            this.CreateDefaultAccount = createDefaultAccount;
            this.Description = description;
            this.PrimaryCurrency = primaryCurrency;
            this.ProcessingTier = processingTier;
        }
        
        /// <summary>
        /// The desired code of the prospective account holder. &gt; Must be between three (3) and fifty (50) characters long. Only letters, digits, and hyphens (-) are permitted.
        /// </summary>
        /// <value>The desired code of the prospective account holder. &gt; Must be between three (3) and fifty (50) characters long. Only letters, digits, and hyphens (-) are permitted.</value>
        [DataMember(Name="accountHolderCode", EmitDefaultValue=false)]
        public string AccountHolderCode { get; set; }

        /// <summary>
        /// Gets or Sets AccountHolderDetails
        /// </summary>
        [DataMember(Name="accountHolderDetails", EmitDefaultValue=false)]
        public AccountHolderDetails AccountHolderDetails { get; set; }

        /// <summary>
        /// If set to true, an account with the default options is created for this account holder. **Default Value:** true
        /// </summary>
        /// <value>If set to true, an account with the default options is created for this account holder. **Default Value:** true</value>
        [DataMember(Name="createDefaultAccount", EmitDefaultValue=false)]
        public bool? CreateDefaultAccount { get; set; }

        /// <summary>
        /// A description of the prospective account holder.
        /// </summary>
        /// <value>A description of the prospective account holder.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }


        /// <summary>
        /// The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes), with which the prospective account holder primarily deals.
        /// </summary>
        /// <value>The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes), with which the prospective account holder primarily deals.</value>
        [DataMember(Name="primaryCurrency", EmitDefaultValue=false)]
        public string PrimaryCurrency { get; set; }

        /// <summary>
        /// The starting [processing tier](https://docs.adyen.com/marketpay/onboarding-and-verification/verification-checks#tiers) for the prospective account holder.
        /// </summary>
        /// <value>The starting [processing tier](https://docs.adyen.com/marketpay/onboarding-and-verification/verification-checks#tiers) for the prospective account holder.</value>
        [DataMember(Name="processingTier", EmitDefaultValue=false)]
        public int? ProcessingTier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAccountHolderRequest {\n");
            sb.Append("  AccountHolderCode: ").Append(AccountHolderCode).Append("\n");
            sb.Append("  AccountHolderDetails: ").Append(AccountHolderDetails).Append("\n");
            sb.Append("  CreateDefaultAccount: ").Append(CreateDefaultAccount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LegalEntity: ").Append(LegalEntity).Append("\n");
            sb.Append("  PrimaryCurrency: ").Append(PrimaryCurrency).Append("\n");
            sb.Append("  ProcessingTier: ").Append(ProcessingTier).Append("\n");
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
            return this.Equals(input as CreateAccountHolderRequest);
        }

        /// <summary>
        /// Returns true if CreateAccountHolderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateAccountHolderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateAccountHolderRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountHolderCode == input.AccountHolderCode ||
                    (this.AccountHolderCode != null &&
                    this.AccountHolderCode.Equals(input.AccountHolderCode))
                ) && 
                (
                    this.AccountHolderDetails == input.AccountHolderDetails ||
                    (this.AccountHolderDetails != null &&
                    this.AccountHolderDetails.Equals(input.AccountHolderDetails))
                ) && 
                (
                    this.CreateDefaultAccount == input.CreateDefaultAccount ||
                    (this.CreateDefaultAccount != null &&
                    this.CreateDefaultAccount.Equals(input.CreateDefaultAccount))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.LegalEntity == input.LegalEntity ||
                    (this.LegalEntity != null &&
                    this.LegalEntity.Equals(input.LegalEntity))
                ) && 
                (
                    this.PrimaryCurrency == input.PrimaryCurrency ||
                    (this.PrimaryCurrency != null &&
                    this.PrimaryCurrency.Equals(input.PrimaryCurrency))
                ) && 
                (
                    this.ProcessingTier == input.ProcessingTier ||
                    (this.ProcessingTier != null &&
                    this.ProcessingTier.Equals(input.ProcessingTier))
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
                if (this.AccountHolderCode != null)
                    hashCode = hashCode * 59 + this.AccountHolderCode.GetHashCode();
                if (this.AccountHolderDetails != null)
                    hashCode = hashCode * 59 + this.AccountHolderDetails.GetHashCode();
                if (this.CreateDefaultAccount != null)
                    hashCode = hashCode * 59 + this.CreateDefaultAccount.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.LegalEntity != null)
                    hashCode = hashCode * 59 + this.LegalEntity.GetHashCode();
                if (this.PrimaryCurrency != null)
                    hashCode = hashCode * 59 + this.PrimaryCurrency.GetHashCode();
                if (this.ProcessingTier != null)
                    hashCode = hashCode * 59 + this.ProcessingTier.GetHashCode();
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
