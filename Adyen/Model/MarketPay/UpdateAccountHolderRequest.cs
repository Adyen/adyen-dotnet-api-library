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
    /// UpdateAccountHolderRequest
    /// </summary>
    [DataContract]
        public class UpdateAccountHolderRequest :  IEquatable<UpdateAccountHolderRequest>, IValidatableObject
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
        public LegalEntityEnum? LegalEntity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAccountHolderRequest" /> class.
        /// </summary>
        /// <param name="accountHolderCode">The code of the Account Holder to be updated. (required).</param>
        /// <param name="accountHolderDetails">accountHolderDetails.</param>
        /// <param name="description">The description to which the Account Holder should be updated..</param>
        /// <param name="legalEntity">The entity type. Permitted values: &#x60;Business&#x60;, &#x60;Individual&#x60;  If an account holder is &#x27;Business&#x27;, then &#x60;accountHolderDetails.businessDetails&#x60; must be provided, as well as at least one entry in the &#x60;accountHolderDetails.businessDetails.shareholders&#x60; list.  If an account holder is &#x27;Individual&#x27;, then &#x60;accountHolderDetails.individualDetails&#x60; must be provided..</param>
        /// <param name="primaryCurrency">The primary three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes), to which the account holder should be updated..</param>
        /// <param name="processingTier">The processing tier to which the Account Holder should be updated. &gt;The processing tier can not be lowered through this request.  &gt;Required if accountHolderDetails are not provided..</param>
        public UpdateAccountHolderRequest(string accountHolderCode = default(string), AccountHolderDetails accountHolderDetails = default(AccountHolderDetails), string description = default(string), LegalEntityEnum? legalEntity = default(LegalEntityEnum?), string primaryCurrency = default(string), int? processingTier = default(int?))
        {
            // to ensure "accountHolderCode" is required (not null)
            if (accountHolderCode == null)
            {
                throw new InvalidDataException("accountHolderCode is a required property for UpdateAccountHolderRequest and cannot be null");
            }

            AccountHolderCode = accountHolderCode;
            AccountHolderDetails = accountHolderDetails;
            Description = description;
            LegalEntity = legalEntity;
            PrimaryCurrency = primaryCurrency;
            ProcessingTier = processingTier;
        }
        
        /// <summary>
        /// The code of the Account Holder to be updated.
        /// </summary>
        /// <value>The code of the Account Holder to be updated.</value>
        [DataMember(Name="accountHolderCode", EmitDefaultValue=false)]
        public string AccountHolderCode { get; set; }

        /// <summary>
        /// Gets or Sets AccountHolderDetails
        /// </summary>
        [DataMember(Name="accountHolderDetails", EmitDefaultValue=false)]
        public AccountHolderDetails AccountHolderDetails { get; set; }

        /// <summary>
        /// The description to which the Account Holder should be updated.
        /// </summary>
        /// <value>The description to which the Account Holder should be updated.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }


        /// <summary>
        /// The primary three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes), to which the account holder should be updated.
        /// </summary>
        /// <value>The primary three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes), to which the account holder should be updated.</value>
        [DataMember(Name="primaryCurrency", EmitDefaultValue=false)]
        public string PrimaryCurrency { get; set; }

        /// <summary>
        /// The processing tier to which the Account Holder should be updated. &gt;The processing tier can not be lowered through this request.  &gt;Required if accountHolderDetails are not provided.
        /// </summary>
        /// <value>The processing tier to which the Account Holder should be updated. &gt;The processing tier can not be lowered through this request.  &gt;Required if accountHolderDetails are not provided.</value>
        [DataMember(Name="processingTier", EmitDefaultValue=false)]
        public int? ProcessingTier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAccountHolderRequest {\n");
            sb.Append("  AccountHolderCode: ").Append(AccountHolderCode).Append("\n");
            sb.Append("  AccountHolderDetails: ").Append(AccountHolderDetails).Append("\n");
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
            return Equals(input as UpdateAccountHolderRequest);
        }

        /// <summary>
        /// Returns true if UpdateAccountHolderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateAccountHolderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateAccountHolderRequest input)
        {
            if (input == null)
                return false;

            return 
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
                    Description == input.Description ||
                    (Description != null &&
                    Description.Equals(input.Description))
                ) && 
                (
                    LegalEntity == input.LegalEntity ||
                    (LegalEntity != null &&
                    LegalEntity.Equals(input.LegalEntity))
                ) && 
                (
                    PrimaryCurrency == input.PrimaryCurrency ||
                    (PrimaryCurrency != null &&
                    PrimaryCurrency.Equals(input.PrimaryCurrency))
                ) && 
                (
                    ProcessingTier == input.ProcessingTier ||
                    (ProcessingTier != null &&
                    ProcessingTier.Equals(input.ProcessingTier))
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
                if (AccountHolderCode != null)
                    hashCode = hashCode * 59 + AccountHolderCode.GetHashCode();
                if (AccountHolderDetails != null)
                    hashCode = hashCode * 59 + AccountHolderDetails.GetHashCode();
                if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                if (LegalEntity != null)
                    hashCode = hashCode * 59 + LegalEntity.GetHashCode();
                if (PrimaryCurrency != null)
                    hashCode = hashCode * 59 + PrimaryCurrency.GetHashCode();
                if (ProcessingTier != null)
                    hashCode = hashCode * 59 + ProcessingTier.GetHashCode();
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
