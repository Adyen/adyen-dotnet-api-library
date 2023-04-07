/*
* Configuration API
*
*
* The version of the OpenAPI document: 2
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

namespace Adyen.Model.BalancePlatform
{
    /// <summary>
    /// AccountHolder
    /// </summary>
    [DataContract(Name = "AccountHolder")]
    public partial class AccountHolder : IEquatable<AccountHolder>, IValidatableObject
    {
        /// <summary>
        /// The status of the account holder.  Possible values:    * **active**: The account holder is active. This is the default status when creating an account holder.    * **inactive (Deprecated)**: The account holder is temporarily inactive due to missing KYC details. You can set the account back to active by providing the missing KYC details.    * **suspended**: The account holder is permanently deactivated by Adyen. This action cannot be undone.   * **closed**: The account holder is permanently deactivated by you. This action cannot be undone.
        /// </summary>
        /// <value>The status of the account holder.  Possible values:    * **active**: The account holder is active. This is the default status when creating an account holder.    * **inactive (Deprecated)**: The account holder is temporarily inactive due to missing KYC details. You can set the account back to active by providing the missing KYC details.    * **suspended**: The account holder is permanently deactivated by Adyen. This action cannot be undone.   * **closed**: The account holder is permanently deactivated by you. This action cannot be undone.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 1,

            /// <summary>
            /// Enum Closed for value: closed
            /// </summary>
            [EnumMember(Value = "closed")]
            Closed = 2,

            /// <summary>
            /// Enum Inactive for value: inactive
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive = 3,

            /// <summary>
            /// Enum Suspended for value: suspended
            /// </summary>
            [EnumMember(Value = "suspended")]
            Suspended = 4

        }


        /// <summary>
        /// The status of the account holder.  Possible values:    * **active**: The account holder is active. This is the default status when creating an account holder.    * **inactive (Deprecated)**: The account holder is temporarily inactive due to missing KYC details. You can set the account back to active by providing the missing KYC details.    * **suspended**: The account holder is permanently deactivated by Adyen. This action cannot be undone.   * **closed**: The account holder is permanently deactivated by you. This action cannot be undone.
        /// </summary>
        /// <value>The status of the account holder.  Possible values:    * **active**: The account holder is active. This is the default status when creating an account holder.    * **inactive (Deprecated)**: The account holder is temporarily inactive due to missing KYC details. You can set the account back to active by providing the missing KYC details.    * **suspended**: The account holder is permanently deactivated by Adyen. This action cannot be undone.   * **closed**: The account holder is permanently deactivated by you. This action cannot be undone.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountHolder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountHolder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountHolder" /> class.
        /// </summary>
        /// <param name="balancePlatform">The unique identifier of the [balance platform](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balancePlatforms/{id}__queryParam_id) to which the account holder belongs. Required in the request if your API credentials can be used for multiple balance platforms..</param>
        /// <param name="capabilities">Contains key-value pairs that specify the actions that an account holder can do in your platform. The key is a capability required for your integration. For example, **issueCard** for Issuing. The value is an object containing the settings for the capability..</param>
        /// <param name="contactDetails">contactDetails.</param>
        /// <param name="description">Your description for the account holder, maximum 300 characters..</param>
        /// <param name="legalEntityId">The unique identifier of the [legal entity](https://docs.adyen.com/api-explorer/legalentity/latest/post/legalEntities#responses-200-id) associated with the account holder. Adyen performs a verification process against the legal entity of the account holder. (required).</param>
        /// <param name="primaryBalanceAccount">The ID of the account holder&#39;s primary balance account. By default, this is set to the first balance account that you create for the account holder. To assign a different balance account, send a PATCH request..</param>
        /// <param name="reference">Your reference for the account holder, maximum 150 characters..</param>
        /// <param name="status">The status of the account holder.  Possible values:    * **active**: The account holder is active. This is the default status when creating an account holder.    * **inactive (Deprecated)**: The account holder is temporarily inactive due to missing KYC details. You can set the account back to active by providing the missing KYC details.    * **suspended**: The account holder is permanently deactivated by Adyen. This action cannot be undone.   * **closed**: The account holder is permanently deactivated by you. This action cannot be undone..</param>
        /// <param name="timeZone">The [time zone](https://www.iana.org/time-zones) of the account holder. For example, **Europe/Amsterdam**. Defaults to the time zone of the balance platform if no time zone is set. For possible values, see the [list of time zone codes](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones)..</param>
        public AccountHolder(string balancePlatform = default(string), Dictionary<string, AccountHolderCapability> capabilities = default(Dictionary<string, AccountHolderCapability>), ContactDetails contactDetails = default(ContactDetails), string description = default(string), string legalEntityId = default(string), string primaryBalanceAccount = default(string), string reference = default(string), StatusEnum? status = default(StatusEnum?), string timeZone = default(string))
        {
            this.LegalEntityId = legalEntityId;
            this.BalancePlatform = balancePlatform;
            this.Capabilities = capabilities;
            this.ContactDetails = contactDetails;
            this.Description = description;
            this.PrimaryBalanceAccount = primaryBalanceAccount;
            this.Reference = reference;
            this.Status = status;
            this.TimeZone = timeZone;
        }

        /// <summary>
        /// The unique identifier of the [balance platform](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balancePlatforms/{id}__queryParam_id) to which the account holder belongs. Required in the request if your API credentials can be used for multiple balance platforms.
        /// </summary>
        /// <value>The unique identifier of the [balance platform](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balancePlatforms/{id}__queryParam_id) to which the account holder belongs. Required in the request if your API credentials can be used for multiple balance platforms.</value>
        [DataMember(Name = "balancePlatform", EmitDefaultValue = false)]
        public string BalancePlatform { get; set; }

        /// <summary>
        /// Contains key-value pairs that specify the actions that an account holder can do in your platform. The key is a capability required for your integration. For example, **issueCard** for Issuing. The value is an object containing the settings for the capability.
        /// </summary>
        /// <value>Contains key-value pairs that specify the actions that an account holder can do in your platform. The key is a capability required for your integration. For example, **issueCard** for Issuing. The value is an object containing the settings for the capability.</value>
        [DataMember(Name = "capabilities", EmitDefaultValue = false)]
        public Dictionary<string, AccountHolderCapability> Capabilities { get; set; }

        /// <summary>
        /// Gets or Sets ContactDetails
        /// </summary>
        [DataMember(Name = "contactDetails", EmitDefaultValue = false)]
        public ContactDetails ContactDetails { get; set; }

        /// <summary>
        /// Your description for the account holder, maximum 300 characters.
        /// </summary>
        /// <value>Your description for the account holder, maximum 300 characters.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The unique identifier of the account holder.
        /// </summary>
        /// <value>The unique identifier of the account holder.</value>
        [DataMember(Name = "id", IsRequired = false, EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// The unique identifier of the [legal entity](https://docs.adyen.com/api-explorer/legalentity/latest/post/legalEntities#responses-200-id) associated with the account holder. Adyen performs a verification process against the legal entity of the account holder.
        /// </summary>
        /// <value>The unique identifier of the [legal entity](https://docs.adyen.com/api-explorer/legalentity/latest/post/legalEntities#responses-200-id) associated with the account holder. Adyen performs a verification process against the legal entity of the account holder.</value>
        [DataMember(Name = "legalEntityId", IsRequired = false, EmitDefaultValue = false)]
        public string LegalEntityId { get; set; }

        /// <summary>
        /// The ID of the account holder&#39;s primary balance account. By default, this is set to the first balance account that you create for the account holder. To assign a different balance account, send a PATCH request.
        /// </summary>
        /// <value>The ID of the account holder&#39;s primary balance account. By default, this is set to the first balance account that you create for the account holder. To assign a different balance account, send a PATCH request.</value>
        [DataMember(Name = "primaryBalanceAccount", EmitDefaultValue = false)]
        public string PrimaryBalanceAccount { get; set; }

        /// <summary>
        /// Your reference for the account holder, maximum 150 characters.
        /// </summary>
        /// <value>Your reference for the account holder, maximum 150 characters.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// The [time zone](https://www.iana.org/time-zones) of the account holder. For example, **Europe/Amsterdam**. Defaults to the time zone of the balance platform if no time zone is set. For possible values, see the [list of time zone codes](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones).
        /// </summary>
        /// <value>The [time zone](https://www.iana.org/time-zones) of the account holder. For example, **Europe/Amsterdam**. Defaults to the time zone of the balance platform if no time zone is set. For possible values, see the [list of time zone codes](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones).</value>
        [DataMember(Name = "timeZone", EmitDefaultValue = false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// List of verification deadlines and the capabilities that will be disallowed if verification errors are not resolved.
        /// </summary>
        /// <value>List of verification deadlines and the capabilities that will be disallowed if verification errors are not resolved.</value>
        [DataMember(Name = "verificationDeadlines", EmitDefaultValue = false)]
        public List<VerificationDeadline> VerificationDeadlines { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountHolder {\n");
            sb.Append("  BalancePlatform: ").Append(BalancePlatform).Append("\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
            sb.Append("  ContactDetails: ").Append(ContactDetails).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LegalEntityId: ").Append(LegalEntityId).Append("\n");
            sb.Append("  PrimaryBalanceAccount: ").Append(PrimaryBalanceAccount).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  VerificationDeadlines: ").Append(VerificationDeadlines).Append("\n");
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
            return this.Equals(input as AccountHolder);
        }

        /// <summary>
        /// Returns true if AccountHolder instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountHolder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountHolder input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BalancePlatform == input.BalancePlatform ||
                    (this.BalancePlatform != null &&
                    this.BalancePlatform.Equals(input.BalancePlatform))
                ) && 
                (
                    this.Capabilities == input.Capabilities ||
                    this.Capabilities != null &&
                    input.Capabilities != null &&
                    this.Capabilities.SequenceEqual(input.Capabilities)
                ) && 
                (
                    this.ContactDetails == input.ContactDetails ||
                    (this.ContactDetails != null &&
                    this.ContactDetails.Equals(input.ContactDetails))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LegalEntityId == input.LegalEntityId ||
                    (this.LegalEntityId != null &&
                    this.LegalEntityId.Equals(input.LegalEntityId))
                ) && 
                (
                    this.PrimaryBalanceAccount == input.PrimaryBalanceAccount ||
                    (this.PrimaryBalanceAccount != null &&
                    this.PrimaryBalanceAccount.Equals(input.PrimaryBalanceAccount))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
                ) && 
                (
                    this.VerificationDeadlines == input.VerificationDeadlines ||
                    this.VerificationDeadlines != null &&
                    input.VerificationDeadlines != null &&
                    this.VerificationDeadlines.SequenceEqual(input.VerificationDeadlines)
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
                if (this.BalancePlatform != null)
                {
                    hashCode = (hashCode * 59) + this.BalancePlatform.GetHashCode();
                }
                if (this.Capabilities != null)
                {
                    hashCode = (hashCode * 59) + this.Capabilities.GetHashCode();
                }
                if (this.ContactDetails != null)
                {
                    hashCode = (hashCode * 59) + this.ContactDetails.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.LegalEntityId != null)
                {
                    hashCode = (hashCode * 59) + this.LegalEntityId.GetHashCode();
                }
                if (this.PrimaryBalanceAccount != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryBalanceAccount.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.TimeZone != null)
                {
                    hashCode = (hashCode * 59) + this.TimeZone.GetHashCode();
                }
                if (this.VerificationDeadlines != null)
                {
                    hashCode = (hashCode * 59) + this.VerificationDeadlines.GetHashCode();
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
            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 300)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 300.", new [] { "Description" });
            }

            // Reference (string) maxLength
            if (this.Reference != null && this.Reference.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Reference, length must be less than 150.", new [] { "Reference" });
            }

            yield break;
        }
    }

}
