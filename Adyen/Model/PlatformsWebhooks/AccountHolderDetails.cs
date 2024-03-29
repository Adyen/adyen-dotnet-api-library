/*
* Classic Platforms - Notifications
*
*
* The version of the OpenAPI document: 6
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

namespace Adyen.Model.PlatformsWebhooks
{
    /// <summary>
    /// AccountHolderDetails
    /// </summary>
    [DataContract(Name = "AccountHolderDetails")]
    public partial class AccountHolderDetails : IEquatable<AccountHolderDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountHolderDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountHolderDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountHolderDetails" /> class.
        /// </summary>
        /// <param name="address">address (required).</param>
        /// <param name="bankAccountDetails">Array of bank accounts associated with the account holder. For details about the required &#x60;bankAccountDetail&#x60; fields, see [Required information](https://docs.adyen.com/marketplaces-and-platforms/classic/verification-process/required-information)..</param>
        /// <param name="bankAggregatorDataReference">The opaque reference value returned by the Adyen API during bank account login..</param>
        /// <param name="businessDetails">businessDetails.</param>
        /// <param name="email">The email address of the account holder..</param>
        /// <param name="fullPhoneNumber">The phone number of the account holder provided as a single string. It will be handled as a landline phone. **Examples:** \&quot;0031 6 11 22 33 44\&quot;, \&quot;+316/1122-3344\&quot;, \&quot;(0031) 611223344\&quot;.</param>
        /// <param name="individualDetails">individualDetails.</param>
        /// <param name="lastReviewDate">Date when you last reviewed the account holder&#39;s information, in ISO-8601 YYYY-MM-DD format. For example, **2020-01-31**..</param>
        /// <param name="legalArrangements">An array containing information about the account holder&#39;s [legal arrangements](https://docs.adyen.com/marketplaces-and-platforms/classic/verification-process/legal-arrangements)..</param>
        /// <param name="merchantCategoryCode">The Merchant Category Code of the account holder. &gt; If not specified in the request, this will be derived from the platform account (which is configured by Adyen)..</param>
        /// <param name="metadata">A set of key and value pairs for general use by the account holder or merchant. The keys do not have specific names and may be used for storing miscellaneous data as desired. &gt; The values being stored have a maximum length of eighty (80) characters and will be truncated if necessary. &gt; Note that during an update of metadata, the omission of existing key-value pairs will result in the deletion of those key-value pairs..</param>
        /// <param name="payoutMethods">Array of tokenized card details associated with the account holder. For details about how you can use the tokens to pay out, refer to [Pay out to cards](https://docs.adyen.com/marketplaces-and-platforms/classic/payout-to-cards)..</param>
        /// <param name="principalBusinessAddress">principalBusinessAddress.</param>
        /// <param name="storeDetails">Array of stores associated with the account holder. Required when onboarding account holders that have an Adyen [point of sale](https://docs.adyen.com/marketplaces-and-platforms/classic/platforms-for-pos)..</param>
        /// <param name="webAddress">The URL of the website of the account holder..</param>
        public AccountHolderDetails(ViasAddress address = default(ViasAddress), List<BankAccountDetail> bankAccountDetails = default(List<BankAccountDetail>), string bankAggregatorDataReference = default(string), BusinessDetails businessDetails = default(BusinessDetails), string email = default(string), string fullPhoneNumber = default(string), IndividualDetails individualDetails = default(IndividualDetails), string lastReviewDate = default(string), List<LegalArrangementDetail> legalArrangements = default(List<LegalArrangementDetail>), string merchantCategoryCode = default(string), Dictionary<string, string> metadata = default(Dictionary<string, string>), List<PayoutMethod> payoutMethods = default(List<PayoutMethod>), ViasAddress principalBusinessAddress = default(ViasAddress), List<StoreDetail> storeDetails = default(List<StoreDetail>), string webAddress = default(string))
        {
            this.Address = address;
            this.BankAccountDetails = bankAccountDetails;
            this.BankAggregatorDataReference = bankAggregatorDataReference;
            this.BusinessDetails = businessDetails;
            this.Email = email;
            this.FullPhoneNumber = fullPhoneNumber;
            this.IndividualDetails = individualDetails;
            this.LastReviewDate = lastReviewDate;
            this.LegalArrangements = legalArrangements;
            this.MerchantCategoryCode = merchantCategoryCode;
            this.Metadata = metadata;
            this.PayoutMethods = payoutMethods;
            this.PrincipalBusinessAddress = principalBusinessAddress;
            this.StoreDetails = storeDetails;
            this.WebAddress = webAddress;
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", IsRequired = false, EmitDefaultValue = false)]
        public ViasAddress Address { get; set; }

        /// <summary>
        /// Array of bank accounts associated with the account holder. For details about the required &#x60;bankAccountDetail&#x60; fields, see [Required information](https://docs.adyen.com/marketplaces-and-platforms/classic/verification-process/required-information).
        /// </summary>
        /// <value>Array of bank accounts associated with the account holder. For details about the required &#x60;bankAccountDetail&#x60; fields, see [Required information](https://docs.adyen.com/marketplaces-and-platforms/classic/verification-process/required-information).</value>
        [DataMember(Name = "bankAccountDetails", EmitDefaultValue = false)]
        public List<BankAccountDetail> BankAccountDetails { get; set; }

        /// <summary>
        /// The opaque reference value returned by the Adyen API during bank account login.
        /// </summary>
        /// <value>The opaque reference value returned by the Adyen API during bank account login.</value>
        [DataMember(Name = "bankAggregatorDataReference", EmitDefaultValue = false)]
        public string BankAggregatorDataReference { get; set; }

        /// <summary>
        /// Gets or Sets BusinessDetails
        /// </summary>
        [DataMember(Name = "businessDetails", EmitDefaultValue = false)]
        public BusinessDetails BusinessDetails { get; set; }

        /// <summary>
        /// The email address of the account holder.
        /// </summary>
        /// <value>The email address of the account holder.</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// The phone number of the account holder provided as a single string. It will be handled as a landline phone. **Examples:** \&quot;0031 6 11 22 33 44\&quot;, \&quot;+316/1122-3344\&quot;, \&quot;(0031) 611223344\&quot;
        /// </summary>
        /// <value>The phone number of the account holder provided as a single string. It will be handled as a landline phone. **Examples:** \&quot;0031 6 11 22 33 44\&quot;, \&quot;+316/1122-3344\&quot;, \&quot;(0031) 611223344\&quot;</value>
        [DataMember(Name = "fullPhoneNumber", EmitDefaultValue = false)]
        public string FullPhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets IndividualDetails
        /// </summary>
        [DataMember(Name = "individualDetails", EmitDefaultValue = false)]
        public IndividualDetails IndividualDetails { get; set; }

        /// <summary>
        /// Date when you last reviewed the account holder&#39;s information, in ISO-8601 YYYY-MM-DD format. For example, **2020-01-31**.
        /// </summary>
        /// <value>Date when you last reviewed the account holder&#39;s information, in ISO-8601 YYYY-MM-DD format. For example, **2020-01-31**.</value>
        [DataMember(Name = "lastReviewDate", EmitDefaultValue = false)]
        public string LastReviewDate { get; set; }

        /// <summary>
        /// An array containing information about the account holder&#39;s [legal arrangements](https://docs.adyen.com/marketplaces-and-platforms/classic/verification-process/legal-arrangements).
        /// </summary>
        /// <value>An array containing information about the account holder&#39;s [legal arrangements](https://docs.adyen.com/marketplaces-and-platforms/classic/verification-process/legal-arrangements).</value>
        [DataMember(Name = "legalArrangements", EmitDefaultValue = false)]
        public List<LegalArrangementDetail> LegalArrangements { get; set; }

        /// <summary>
        /// The Merchant Category Code of the account holder. &gt; If not specified in the request, this will be derived from the platform account (which is configured by Adyen).
        /// </summary>
        /// <value>The Merchant Category Code of the account holder. &gt; If not specified in the request, this will be derived from the platform account (which is configured by Adyen).</value>
        [DataMember(Name = "merchantCategoryCode", EmitDefaultValue = false)]
        public string MerchantCategoryCode { get; set; }

        /// <summary>
        /// A set of key and value pairs for general use by the account holder or merchant. The keys do not have specific names and may be used for storing miscellaneous data as desired. &gt; The values being stored have a maximum length of eighty (80) characters and will be truncated if necessary. &gt; Note that during an update of metadata, the omission of existing key-value pairs will result in the deletion of those key-value pairs.
        /// </summary>
        /// <value>A set of key and value pairs for general use by the account holder or merchant. The keys do not have specific names and may be used for storing miscellaneous data as desired. &gt; The values being stored have a maximum length of eighty (80) characters and will be truncated if necessary. &gt; Note that during an update of metadata, the omission of existing key-value pairs will result in the deletion of those key-value pairs.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Array of tokenized card details associated with the account holder. For details about how you can use the tokens to pay out, refer to [Pay out to cards](https://docs.adyen.com/marketplaces-and-platforms/classic/payout-to-cards).
        /// </summary>
        /// <value>Array of tokenized card details associated with the account holder. For details about how you can use the tokens to pay out, refer to [Pay out to cards](https://docs.adyen.com/marketplaces-and-platforms/classic/payout-to-cards).</value>
        [DataMember(Name = "payoutMethods", EmitDefaultValue = false)]
        public List<PayoutMethod> PayoutMethods { get; set; }

        /// <summary>
        /// Gets or Sets PrincipalBusinessAddress
        /// </summary>
        [DataMember(Name = "principalBusinessAddress", EmitDefaultValue = false)]
        public ViasAddress PrincipalBusinessAddress { get; set; }

        /// <summary>
        /// Array of stores associated with the account holder. Required when onboarding account holders that have an Adyen [point of sale](https://docs.adyen.com/marketplaces-and-platforms/classic/platforms-for-pos).
        /// </summary>
        /// <value>Array of stores associated with the account holder. Required when onboarding account holders that have an Adyen [point of sale](https://docs.adyen.com/marketplaces-and-platforms/classic/platforms-for-pos).</value>
        [DataMember(Name = "storeDetails", EmitDefaultValue = false)]
        public List<StoreDetail> StoreDetails { get; set; }

        /// <summary>
        /// The URL of the website of the account holder.
        /// </summary>
        /// <value>The URL of the website of the account holder.</value>
        [DataMember(Name = "webAddress", EmitDefaultValue = false)]
        public string WebAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountHolderDetails {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  BankAccountDetails: ").Append(BankAccountDetails).Append("\n");
            sb.Append("  BankAggregatorDataReference: ").Append(BankAggregatorDataReference).Append("\n");
            sb.Append("  BusinessDetails: ").Append(BusinessDetails).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FullPhoneNumber: ").Append(FullPhoneNumber).Append("\n");
            sb.Append("  IndividualDetails: ").Append(IndividualDetails).Append("\n");
            sb.Append("  LastReviewDate: ").Append(LastReviewDate).Append("\n");
            sb.Append("  LegalArrangements: ").Append(LegalArrangements).Append("\n");
            sb.Append("  MerchantCategoryCode: ").Append(MerchantCategoryCode).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  PayoutMethods: ").Append(PayoutMethods).Append("\n");
            sb.Append("  PrincipalBusinessAddress: ").Append(PrincipalBusinessAddress).Append("\n");
            sb.Append("  StoreDetails: ").Append(StoreDetails).Append("\n");
            sb.Append("  WebAddress: ").Append(WebAddress).Append("\n");
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
            return this.Equals(input as AccountHolderDetails);
        }

        /// <summary>
        /// Returns true if AccountHolderDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountHolderDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountHolderDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.BankAccountDetails == input.BankAccountDetails ||
                    this.BankAccountDetails != null &&
                    input.BankAccountDetails != null &&
                    this.BankAccountDetails.SequenceEqual(input.BankAccountDetails)
                ) && 
                (
                    this.BankAggregatorDataReference == input.BankAggregatorDataReference ||
                    (this.BankAggregatorDataReference != null &&
                    this.BankAggregatorDataReference.Equals(input.BankAggregatorDataReference))
                ) && 
                (
                    this.BusinessDetails == input.BusinessDetails ||
                    (this.BusinessDetails != null &&
                    this.BusinessDetails.Equals(input.BusinessDetails))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.FullPhoneNumber == input.FullPhoneNumber ||
                    (this.FullPhoneNumber != null &&
                    this.FullPhoneNumber.Equals(input.FullPhoneNumber))
                ) && 
                (
                    this.IndividualDetails == input.IndividualDetails ||
                    (this.IndividualDetails != null &&
                    this.IndividualDetails.Equals(input.IndividualDetails))
                ) && 
                (
                    this.LastReviewDate == input.LastReviewDate ||
                    (this.LastReviewDate != null &&
                    this.LastReviewDate.Equals(input.LastReviewDate))
                ) && 
                (
                    this.LegalArrangements == input.LegalArrangements ||
                    this.LegalArrangements != null &&
                    input.LegalArrangements != null &&
                    this.LegalArrangements.SequenceEqual(input.LegalArrangements)
                ) && 
                (
                    this.MerchantCategoryCode == input.MerchantCategoryCode ||
                    (this.MerchantCategoryCode != null &&
                    this.MerchantCategoryCode.Equals(input.MerchantCategoryCode))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.PayoutMethods == input.PayoutMethods ||
                    this.PayoutMethods != null &&
                    input.PayoutMethods != null &&
                    this.PayoutMethods.SequenceEqual(input.PayoutMethods)
                ) && 
                (
                    this.PrincipalBusinessAddress == input.PrincipalBusinessAddress ||
                    (this.PrincipalBusinessAddress != null &&
                    this.PrincipalBusinessAddress.Equals(input.PrincipalBusinessAddress))
                ) && 
                (
                    this.StoreDetails == input.StoreDetails ||
                    this.StoreDetails != null &&
                    input.StoreDetails != null &&
                    this.StoreDetails.SequenceEqual(input.StoreDetails)
                ) && 
                (
                    this.WebAddress == input.WebAddress ||
                    (this.WebAddress != null &&
                    this.WebAddress.Equals(input.WebAddress))
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.BankAccountDetails != null)
                {
                    hashCode = (hashCode * 59) + this.BankAccountDetails.GetHashCode();
                }
                if (this.BankAggregatorDataReference != null)
                {
                    hashCode = (hashCode * 59) + this.BankAggregatorDataReference.GetHashCode();
                }
                if (this.BusinessDetails != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessDetails.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.FullPhoneNumber != null)
                {
                    hashCode = (hashCode * 59) + this.FullPhoneNumber.GetHashCode();
                }
                if (this.IndividualDetails != null)
                {
                    hashCode = (hashCode * 59) + this.IndividualDetails.GetHashCode();
                }
                if (this.LastReviewDate != null)
                {
                    hashCode = (hashCode * 59) + this.LastReviewDate.GetHashCode();
                }
                if (this.LegalArrangements != null)
                {
                    hashCode = (hashCode * 59) + this.LegalArrangements.GetHashCode();
                }
                if (this.MerchantCategoryCode != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantCategoryCode.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.PayoutMethods != null)
                {
                    hashCode = (hashCode * 59) + this.PayoutMethods.GetHashCode();
                }
                if (this.PrincipalBusinessAddress != null)
                {
                    hashCode = (hashCode * 59) + this.PrincipalBusinessAddress.GetHashCode();
                }
                if (this.StoreDetails != null)
                {
                    hashCode = (hashCode * 59) + this.StoreDetails.GetHashCode();
                }
                if (this.WebAddress != null)
                {
                    hashCode = (hashCode * 59) + this.WebAddress.GetHashCode();
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
