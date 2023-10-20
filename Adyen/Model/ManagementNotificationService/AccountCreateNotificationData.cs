/*
* Management Webhooks
*
*
* The version of the OpenAPI document: 3
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

namespace Adyen.Model.ManagementNotificationService
{
    /// <summary>
    /// AccountCreateNotificationData
    /// </summary>
    [DataContract(Name = "AccountCreateNotificationData")]
    public partial class AccountCreateNotificationData : IEquatable<AccountCreateNotificationData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountCreateNotificationData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountCreateNotificationData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountCreateNotificationData" /> class.
        /// </summary>
        /// <param name="capabilities">Key-value pairs that specify the actions that the merchant account can do and its settings. The key is a capability. For example, the **sendToTransferInstrument** is the capability required before you can pay out funds to the bank account. The value is an object containing the settings for the capability. (required).</param>
        /// <param name="companyId">The unique identifier of the company account. (required).</param>
        /// <param name="legalEntityId">The unique identifier of the [legal entity](https://docs.adyen.com/api-explorer/legalentity/latest/post/legalEntities#responses-200-id)..</param>
        /// <param name="merchantId">The unique identifier of the merchant account. (required).</param>
        /// <param name="status">The status of the merchant account.  Possible values:  * **PreActive**: The merchant account has been created. Users cannot access the merchant account in the Customer Area. The account cannot process payments. * **Active**: Users can access the merchant account in the Customer Area. If the company account is also **Active**, then payment processing and payouts are enabled. * **InactiveWithModifications**: Users can access the merchant account in the Customer Area. The account cannot process new payments but can still modify payments, for example issue refunds. The account can still receive payouts. * **Inactive**: Users can access the merchant account in the Customer Area. Payment processing and payouts are disabled. * **Closed**: The account is closed and this cannot be reversed. Users cannot log in. Payment processing and payouts are disabled. (required).</param>
        public AccountCreateNotificationData(Dictionary<string, AccountCapabilityData> capabilities = default(Dictionary<string, AccountCapabilityData>), string companyId = default(string), string legalEntityId = default(string), string merchantId = default(string), string status = default(string))
        {
            this.Capabilities = capabilities;
            this.CompanyId = companyId;
            this.MerchantId = merchantId;
            this.Status = status;
            this.LegalEntityId = legalEntityId;
        }

        /// <summary>
        /// Key-value pairs that specify the actions that the merchant account can do and its settings. The key is a capability. For example, the **sendToTransferInstrument** is the capability required before you can pay out funds to the bank account. The value is an object containing the settings for the capability.
        /// </summary>
        /// <value>Key-value pairs that specify the actions that the merchant account can do and its settings. The key is a capability. For example, the **sendToTransferInstrument** is the capability required before you can pay out funds to the bank account. The value is an object containing the settings for the capability.</value>
        [DataMember(Name = "capabilities", IsRequired = false, EmitDefaultValue = false)]
        public Dictionary<string, AccountCapabilityData> Capabilities { get; set; }

        /// <summary>
        /// The unique identifier of the company account.
        /// </summary>
        /// <value>The unique identifier of the company account.</value>
        [DataMember(Name = "companyId", IsRequired = false, EmitDefaultValue = false)]
        public string CompanyId { get; set; }

        /// <summary>
        /// The unique identifier of the [legal entity](https://docs.adyen.com/api-explorer/legalentity/latest/post/legalEntities#responses-200-id).
        /// </summary>
        /// <value>The unique identifier of the [legal entity](https://docs.adyen.com/api-explorer/legalentity/latest/post/legalEntities#responses-200-id).</value>
        [DataMember(Name = "legalEntityId", EmitDefaultValue = false)]
        public string LegalEntityId { get; set; }

        /// <summary>
        /// The unique identifier of the merchant account.
        /// </summary>
        /// <value>The unique identifier of the merchant account.</value>
        [DataMember(Name = "merchantId", IsRequired = false, EmitDefaultValue = false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// The status of the merchant account.  Possible values:  * **PreActive**: The merchant account has been created. Users cannot access the merchant account in the Customer Area. The account cannot process payments. * **Active**: Users can access the merchant account in the Customer Area. If the company account is also **Active**, then payment processing and payouts are enabled. * **InactiveWithModifications**: Users can access the merchant account in the Customer Area. The account cannot process new payments but can still modify payments, for example issue refunds. The account can still receive payouts. * **Inactive**: Users can access the merchant account in the Customer Area. Payment processing and payouts are disabled. * **Closed**: The account is closed and this cannot be reversed. Users cannot log in. Payment processing and payouts are disabled.
        /// </summary>
        /// <value>The status of the merchant account.  Possible values:  * **PreActive**: The merchant account has been created. Users cannot access the merchant account in the Customer Area. The account cannot process payments. * **Active**: Users can access the merchant account in the Customer Area. If the company account is also **Active**, then payment processing and payouts are enabled. * **InactiveWithModifications**: Users can access the merchant account in the Customer Area. The account cannot process new payments but can still modify payments, for example issue refunds. The account can still receive payouts. * **Inactive**: Users can access the merchant account in the Customer Area. Payment processing and payouts are disabled. * **Closed**: The account is closed and this cannot be reversed. Users cannot log in. Payment processing and payouts are disabled.</value>
        [DataMember(Name = "status", IsRequired = false, EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountCreateNotificationData {\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  LegalEntityId: ").Append(LegalEntityId).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as AccountCreateNotificationData);
        }

        /// <summary>
        /// Returns true if AccountCreateNotificationData instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountCreateNotificationData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountCreateNotificationData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Capabilities == input.Capabilities ||
                    this.Capabilities != null &&
                    input.Capabilities != null &&
                    this.Capabilities.SequenceEqual(input.Capabilities)
                ) && 
                (
                    this.CompanyId == input.CompanyId ||
                    (this.CompanyId != null &&
                    this.CompanyId.Equals(input.CompanyId))
                ) && 
                (
                    this.LegalEntityId == input.LegalEntityId ||
                    (this.LegalEntityId != null &&
                    this.LegalEntityId.Equals(input.LegalEntityId))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Capabilities != null)
                {
                    hashCode = (hashCode * 59) + this.Capabilities.GetHashCode();
                }
                if (this.CompanyId != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyId.GetHashCode();
                }
                if (this.LegalEntityId != null)
                {
                    hashCode = (hashCode * 59) + this.LegalEntityId.GetHashCode();
                }
                if (this.MerchantId != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantId.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
