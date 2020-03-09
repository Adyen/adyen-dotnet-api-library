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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// UpdateAccountHolderResponse
    /// </summary>
    [DataContract]
        public partial class UpdateAccountHolderResponse :  IEquatable<UpdateAccountHolderResponse>, IValidatableObject
    {
        /// <summary>
        /// The legal entity of the account holder.
        /// </summary>
        /// <value>The legal entity of the account holder.</value>
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
        /// The legal entity of the account holder.
        /// </summary>
        /// <value>The legal entity of the account holder.</value>
        [DataMember(Name="legalEntity", EmitDefaultValue=false)]
        public LegalEntityEnum LegalEntity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAccountHolderResponse" /> class.
        /// </summary>
        /// <param name="accountHolderCode">The code of the account holder..</param>
        /// <param name="accountHolderDetails">accountHolderDetails.</param>
        /// <param name="accountHolderStatus">accountHolderStatus (required).</param>
        /// <param name="description">The description of the account holder..</param>
        /// <param name="invalidFields">in case the account holder has not been updated, contains account holder fields, that did not pass the validation..</param>
        /// <param name="legalEntity">The legal entity of the account holder. (required).</param>
        /// <param name="primaryCurrency">The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes), with which the prospective account holder primarily deals..</param>
        /// <param name="pspReference">The reference of a request.  Can be used to uniquely identify the request. (required).</param>
        /// <param name="resultCode">The result code..</param>
        /// <param name="verification">verification (required).</param>
        public UpdateAccountHolderResponse(string accountHolderCode = default(string), AccountHolderDetails accountHolderDetails = default(AccountHolderDetails), AccountHolderStatus accountHolderStatus = default(AccountHolderStatus), string description = default(string), List<ErrorFieldType> invalidFields = default(List<ErrorFieldType>), LegalEntityEnum legalEntity = default(LegalEntityEnum), string primaryCurrency = default(string), string pspReference = default(string), string resultCode = default(string), KYCVerificationResult verification = default(KYCVerificationResult))
        {
            this.AccountHolderStatus = accountHolderStatus;
            this.LegalEntity = legalEntity;
            this.PspReference = pspReference;
            this.Verification = verification;
            this.AccountHolderCode = accountHolderCode;
            this.AccountHolderDetails = accountHolderDetails;
            this.Description = description;
            this.InvalidFields = invalidFields;
            this.PrimaryCurrency = primaryCurrency;
            this.ResultCode = resultCode;
        }
        
        /// <summary>
        /// The code of the account holder.
        /// </summary>
        /// <value>The code of the account holder.</value>
        [DataMember(Name="accountHolderCode", EmitDefaultValue=false)]
        public string AccountHolderCode { get; set; }

        /// <summary>
        /// Gets or Sets AccountHolderDetails
        /// </summary>
        [DataMember(Name="accountHolderDetails", EmitDefaultValue=false)]
        public AccountHolderDetails AccountHolderDetails { get; set; }

        /// <summary>
        /// Gets or Sets AccountHolderStatus
        /// </summary>
        [DataMember(Name="accountHolderStatus", EmitDefaultValue=false)]
        public AccountHolderStatus AccountHolderStatus { get; set; }

        /// <summary>
        /// The description of the account holder.
        /// </summary>
        /// <value>The description of the account holder.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// in case the account holder has not been updated, contains account holder fields, that did not pass the validation.
        /// </summary>
        /// <value>in case the account holder has not been updated, contains account holder fields, that did not pass the validation.</value>
        [DataMember(Name="invalidFields", EmitDefaultValue=false)]
        public List<ErrorFieldType> InvalidFields { get; set; }


        /// <summary>
        /// The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes), with which the prospective account holder primarily deals.
        /// </summary>
        /// <value>The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes), with which the prospective account holder primarily deals.</value>
        [DataMember(Name="primaryCurrency", EmitDefaultValue=false)]
        public string PrimaryCurrency { get; set; }

        /// <summary>
        /// The reference of a request.  Can be used to uniquely identify the request.
        /// </summary>
        /// <value>The reference of a request.  Can be used to uniquely identify the request.</value>
        [DataMember(Name="pspReference", EmitDefaultValue=false)]
        public string PspReference { get; set; }

        /// <summary>
        /// The result code.
        /// </summary>
        /// <value>The result code.</value>
        [DataMember(Name="resultCode", EmitDefaultValue=false)]
        public string ResultCode { get; set; }

        /// <summary>
        /// Gets or Sets Verification
        /// </summary>
        [DataMember(Name="verification", EmitDefaultValue=false)]
        public KYCVerificationResult Verification { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAccountHolderResponse {\n");
            sb.Append("  AccountHolderCode: ").Append(AccountHolderCode).Append("\n");
            sb.Append("  AccountHolderDetails: ").Append(AccountHolderDetails).Append("\n");
            sb.Append("  AccountHolderStatus: ").Append(AccountHolderStatus).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  InvalidFields: ").Append(InvalidFields).Append("\n");
            sb.Append("  LegalEntity: ").Append(LegalEntity).Append("\n");
            sb.Append("  PrimaryCurrency: ").Append(PrimaryCurrency).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
            sb.Append("  Verification: ").Append(Verification).Append("\n");
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
            return this.Equals(input as UpdateAccountHolderResponse);
        }

        /// <summary>
        /// Returns true if UpdateAccountHolderResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateAccountHolderResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateAccountHolderResponse input)
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
                    this.AccountHolderStatus == input.AccountHolderStatus ||
                    (this.AccountHolderStatus != null &&
                    this.AccountHolderStatus.Equals(input.AccountHolderStatus))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.InvalidFields == input.InvalidFields ||
                    this.InvalidFields != null &&
                    input.InvalidFields != null &&
                    this.InvalidFields.SequenceEqual(input.InvalidFields)
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
                    this.PspReference == input.PspReference ||
                    (this.PspReference != null &&
                    this.PspReference.Equals(input.PspReference))
                ) && 
                (
                    this.ResultCode == input.ResultCode ||
                    (this.ResultCode != null &&
                    this.ResultCode.Equals(input.ResultCode))
                ) && 
                (
                    this.Verification == input.Verification ||
                    (this.Verification != null &&
                    this.Verification.Equals(input.Verification))
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
                if (this.AccountHolderStatus != null)
                    hashCode = hashCode * 59 + this.AccountHolderStatus.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.InvalidFields != null)
                    hashCode = hashCode * 59 + this.InvalidFields.GetHashCode();
                if (this.LegalEntity != null)
                    hashCode = hashCode * 59 + this.LegalEntity.GetHashCode();
                if (this.PrimaryCurrency != null)
                    hashCode = hashCode * 59 + this.PrimaryCurrency.GetHashCode();
                if (this.PspReference != null)
                    hashCode = hashCode * 59 + this.PspReference.GetHashCode();
                if (this.ResultCode != null)
                    hashCode = hashCode * 59 + this.ResultCode.GetHashCode();
                if (this.Verification != null)
                    hashCode = hashCode * 59 + this.Verification.GetHashCode();
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
