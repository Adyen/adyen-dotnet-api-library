using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// CreateAccountHolderResponse
    /// </summary>
    [DataContract]
        public class CreateAccountHolderResponse :  IEquatable<CreateAccountHolderResponse>, IValidatableObject
    {
        /// <summary>
        /// The type of legal entity of the new account holder.
        /// </summary>
        /// <value>The type of legal entity of the new account holder.</value>
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
        /// The type of legal entity of the new account holder.
        /// </summary>
        /// <value>The type of legal entity of the new account holder.</value>
        [DataMember(Name="legalEntity", EmitDefaultValue=false)]
        public LegalEntityEnum LegalEntity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccountHolderResponse" /> class.
        /// </summary>
        /// <param name="accountCode">The code of a new account created for the account holder..</param>
        /// <param name="accountHolderCode">The code of the new account holder. (required).</param>
        /// <param name="accountHolderDetails">accountHolderDetails (required).</param>
        /// <param name="accountHolderStatus">accountHolderStatus (required).</param>
        /// <param name="description">The description of the new account holder..</param>
        /// <param name="invalidFields">A list of fields that caused the &#x60;/createAccountHolder&#x60; request to fail..</param>
        /// <param name="legalEntity">The type of legal entity of the new account holder. (required).</param>
        /// <param name="primaryCurrency">The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes), with which the prospective account holder primarily deals..</param>
        /// <param name="pspReference">The reference of a request.  Can be used to uniquely identify the request. (required).</param>
        /// <param name="resultCode">The result code..</param>
        /// <param name="verification">verification (required).</param>
        public CreateAccountHolderResponse(string accountCode = default(string), string accountHolderCode = default(string), AccountHolderDetails accountHolderDetails = default(AccountHolderDetails), AccountHolderStatus accountHolderStatus = default(AccountHolderStatus), string description = default(string), List<ErrorFieldType> invalidFields = default(List<ErrorFieldType>), LegalEntityEnum legalEntity = default(LegalEntityEnum), string primaryCurrency = default(string), string pspReference = default(string), string resultCode = default(string), KYCVerificationResult verification = default(KYCVerificationResult))
        { 
            PspReference = pspReference;
            AccountHolderStatus = accountHolderStatus;
            LegalEntity = legalEntity;
            Verification = verification;
            AccountHolderDetails = accountHolderDetails;
            AccountHolderCode = accountHolderCode;
            AccountCode = accountCode;
            Description = description;
            InvalidFields = invalidFields;
            PrimaryCurrency = primaryCurrency;
            ResultCode = resultCode;
        }
        
        /// <summary>
        /// The code of a new account created for the account holder.
        /// </summary>
        /// <value>The code of a new account created for the account holder.</value>
        [DataMember(Name="accountCode", EmitDefaultValue=false)]
        public string AccountCode { get; set; }

        /// <summary>
        /// The code of the new account holder.
        /// </summary>
        /// <value>The code of the new account holder.</value>
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
        /// The description of the new account holder.
        /// </summary>
        /// <value>The description of the new account holder.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// A list of fields that caused the &#x60;/createAccountHolder&#x60; request to fail.
        /// </summary>
        /// <value>A list of fields that caused the &#x60;/createAccountHolder&#x60; request to fail.</value>
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
            sb.Append("class CreateAccountHolderResponse {\n");
            sb.Append("  AccountCode: ").Append(AccountCode).Append("\n");
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
            return Equals(input as CreateAccountHolderResponse);
        }

        /// <summary>
        /// Returns true if CreateAccountHolderResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateAccountHolderResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateAccountHolderResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    AccountCode == input.AccountCode ||
                    (AccountCode != null &&
                    AccountCode.Equals(input.AccountCode))
                ) && 
                (
                    AccountHolderCode == input.AccountHolderCode ||
                    (AccountHolderCode != null &&
                    AccountHolderCode.Equals(input.AccountHolderCode))
                ) && 
                (
                    AccountHolderDetails == input.AccountHolderDetails ||
                    (AccountHolderDetails != null &&
                    AccountHolderDetails.Equals(input.AccountHolderDetails))
                ) && 
                (
                    AccountHolderStatus == input.AccountHolderStatus ||
                    (AccountHolderStatus != null &&
                    AccountHolderStatus.Equals(input.AccountHolderStatus))
                ) && 
                (
                    Description == input.Description ||
                    (Description != null &&
                    Description.Equals(input.Description))
                ) && 
                (
                    InvalidFields == input.InvalidFields ||
                    InvalidFields != null &&
                    input.InvalidFields != null &&
                    InvalidFields.SequenceEqual(input.InvalidFields)
                ) && 
                (
                    LegalEntity == input.LegalEntity ||
                    LegalEntity.Equals(input.LegalEntity)
                ) && 
                (
                    PrimaryCurrency == input.PrimaryCurrency ||
                    (PrimaryCurrency != null &&
                    PrimaryCurrency.Equals(input.PrimaryCurrency))
                ) && 
                (
                    PspReference == input.PspReference ||
                    (PspReference != null &&
                    PspReference.Equals(input.PspReference))
                ) && 
                (
                    ResultCode == input.ResultCode ||
                    (ResultCode != null &&
                    ResultCode.Equals(input.ResultCode))
                ) && 
                (
                    Verification == input.Verification ||
                    (Verification != null &&
                    Verification.Equals(input.Verification))
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
                if (AccountCode != null)
                    hashCode = hashCode * 59 + AccountCode.GetHashCode();
                if (AccountHolderCode != null)
                    hashCode = hashCode * 59 + AccountHolderCode.GetHashCode();
                if (AccountHolderDetails != null)
                    hashCode = hashCode * 59 + AccountHolderDetails.GetHashCode();
                if (AccountHolderStatus != null)
                    hashCode = hashCode * 59 + AccountHolderStatus.GetHashCode();
                if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                if (InvalidFields != null)
                    hashCode = hashCode * 59 + InvalidFields.GetHashCode();
                hashCode = hashCode * 59 + LegalEntity.GetHashCode();
                if (PrimaryCurrency != null)
                    hashCode = hashCode * 59 + PrimaryCurrency.GetHashCode();
                if (PspReference != null)
                    hashCode = hashCode * 59 + PspReference.GetHashCode();
                if (ResultCode != null)
                    hashCode = hashCode * 59 + ResultCode.GetHashCode();
                if (Verification != null)
                    hashCode = hashCode * 59 + Verification.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
