/*
* Legal Entity Management API
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

namespace Adyen.Model.LegalEntityManagement
{
    /// <summary>
    /// BusinessLineInfo
    /// </summary>
    [DataContract(Name = "BusinessLineInfo")]
    public partial class BusinessLineInfo : IEquatable<BusinessLineInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLineInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BusinessLineInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLineInfo" /> class.
        /// </summary>
        /// <param name="capability">The capability for which you are creating the business line. For example, **receivePayments**. (required).</param>
        /// <param name="industryCode">A code that represents the industry of the legal entity. For example, **4431A** for computer software stores. (required).</param>
        /// <param name="legalEntityId">Unique identifier of the [legal entity](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/legalEntities__resParam_id) that owns the business line. (required).</param>
        /// <param name="salesChannels">A list of channels where goods or services are sold.  Possible values:  - For point of sale: **pos** and **posMoto**  - For ecommerce: **eCommerce** and **ecomMoto**  - For Pay by Link: **payByLink**  Required only in combination with the &#x60;capability&#x60; to **receivePayments** or **receiveFromPlatformPayments**..</param>
        /// <param name="sourceOfFunds">sourceOfFunds.</param>
        /// <param name="webData">List of website URLs where your user&#39;s goods or services are sold. When this is required for a capability but your user does not have an online presence, provide the reason in the &#x60;webDataExemption&#x60; object..</param>
        /// <param name="webDataExemption">webDataExemption.</param>
        public BusinessLineInfo(string capability = default(string), string industryCode = default(string), string legalEntityId = default(string), List<string> salesChannels = default(List<string>), SourceOfFunds sourceOfFunds = default(SourceOfFunds), List<WebData> webData = default(List<WebData>), WebDataExemption webDataExemption = default(WebDataExemption))
        {
            this.Capability = capability;
            this.IndustryCode = industryCode;
            this.LegalEntityId = legalEntityId;
            this.SalesChannels = salesChannels;
            this.SourceOfFunds = sourceOfFunds;
            this.WebData = webData;
            this.WebDataExemption = webDataExemption;
        }

        /// <summary>
        /// The capability for which you are creating the business line. For example, **receivePayments**.
        /// </summary>
        /// <value>The capability for which you are creating the business line. For example, **receivePayments**.</value>
        [DataMember(Name = "capability", IsRequired = false, EmitDefaultValue = false)]
        public string Capability { get; set; }

        /// <summary>
        /// A code that represents the industry of the legal entity. For example, **4431A** for computer software stores.
        /// </summary>
        /// <value>A code that represents the industry of the legal entity. For example, **4431A** for computer software stores.</value>
        [DataMember(Name = "industryCode", IsRequired = false, EmitDefaultValue = false)]
        public string IndustryCode { get; set; }

        /// <summary>
        /// Unique identifier of the [legal entity](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/legalEntities__resParam_id) that owns the business line.
        /// </summary>
        /// <value>Unique identifier of the [legal entity](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/legalEntities__resParam_id) that owns the business line.</value>
        [DataMember(Name = "legalEntityId", IsRequired = false, EmitDefaultValue = false)]
        public string LegalEntityId { get; set; }

        /// <summary>
        /// A list of channels where goods or services are sold.  Possible values:  - For point of sale: **pos** and **posMoto**  - For ecommerce: **eCommerce** and **ecomMoto**  - For Pay by Link: **payByLink**  Required only in combination with the &#x60;capability&#x60; to **receivePayments** or **receiveFromPlatformPayments**.
        /// </summary>
        /// <value>A list of channels where goods or services are sold.  Possible values:  - For point of sale: **pos** and **posMoto**  - For ecommerce: **eCommerce** and **ecomMoto**  - For Pay by Link: **payByLink**  Required only in combination with the &#x60;capability&#x60; to **receivePayments** or **receiveFromPlatformPayments**.</value>
        [DataMember(Name = "salesChannels", EmitDefaultValue = false)]
        public List<string> SalesChannels { get; set; }

        /// <summary>
        /// Gets or Sets SourceOfFunds
        /// </summary>
        [DataMember(Name = "sourceOfFunds", EmitDefaultValue = false)]
        public SourceOfFunds SourceOfFunds { get; set; }

        /// <summary>
        /// List of website URLs where your user&#39;s goods or services are sold. When this is required for a capability but your user does not have an online presence, provide the reason in the &#x60;webDataExemption&#x60; object.
        /// </summary>
        /// <value>List of website URLs where your user&#39;s goods or services are sold. When this is required for a capability but your user does not have an online presence, provide the reason in the &#x60;webDataExemption&#x60; object.</value>
        [DataMember(Name = "webData", EmitDefaultValue = false)]
        public List<WebData> WebData { get; set; }

        /// <summary>
        /// Gets or Sets WebDataExemption
        /// </summary>
        [DataMember(Name = "webDataExemption", EmitDefaultValue = false)]
        public WebDataExemption WebDataExemption { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BusinessLineInfo {\n");
            sb.Append("  Capability: ").Append(Capability).Append("\n");
            sb.Append("  IndustryCode: ").Append(IndustryCode).Append("\n");
            sb.Append("  LegalEntityId: ").Append(LegalEntityId).Append("\n");
            sb.Append("  SalesChannels: ").Append(SalesChannels).Append("\n");
            sb.Append("  SourceOfFunds: ").Append(SourceOfFunds).Append("\n");
            sb.Append("  WebData: ").Append(WebData).Append("\n");
            sb.Append("  WebDataExemption: ").Append(WebDataExemption).Append("\n");
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
            return this.Equals(input as BusinessLineInfo);
        }

        /// <summary>
        /// Returns true if BusinessLineInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessLineInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessLineInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Capability == input.Capability ||
                    (this.Capability != null &&
                    this.Capability.Equals(input.Capability))
                ) && 
                (
                    this.IndustryCode == input.IndustryCode ||
                    (this.IndustryCode != null &&
                    this.IndustryCode.Equals(input.IndustryCode))
                ) && 
                (
                    this.LegalEntityId == input.LegalEntityId ||
                    (this.LegalEntityId != null &&
                    this.LegalEntityId.Equals(input.LegalEntityId))
                ) && 
                (
                    this.SalesChannels == input.SalesChannels ||
                    this.SalesChannels != null &&
                    input.SalesChannels != null &&
                    this.SalesChannels.SequenceEqual(input.SalesChannels)
                ) && 
                (
                    this.SourceOfFunds == input.SourceOfFunds ||
                    (this.SourceOfFunds != null &&
                    this.SourceOfFunds.Equals(input.SourceOfFunds))
                ) && 
                (
                    this.WebData == input.WebData ||
                    this.WebData != null &&
                    input.WebData != null &&
                    this.WebData.SequenceEqual(input.WebData)
                ) && 
                (
                    this.WebDataExemption == input.WebDataExemption ||
                    (this.WebDataExemption != null &&
                    this.WebDataExemption.Equals(input.WebDataExemption))
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
                if (this.Capability != null)
                {
                    hashCode = (hashCode * 59) + this.Capability.GetHashCode();
                }
                if (this.IndustryCode != null)
                {
                    hashCode = (hashCode * 59) + this.IndustryCode.GetHashCode();
                }
                if (this.LegalEntityId != null)
                {
                    hashCode = (hashCode * 59) + this.LegalEntityId.GetHashCode();
                }
                if (this.SalesChannels != null)
                {
                    hashCode = (hashCode * 59) + this.SalesChannels.GetHashCode();
                }
                if (this.SourceOfFunds != null)
                {
                    hashCode = (hashCode * 59) + this.SourceOfFunds.GetHashCode();
                }
                if (this.WebData != null)
                {
                    hashCode = (hashCode * 59) + this.WebData.GetHashCode();
                }
                if (this.WebDataExemption != null)
                {
                    hashCode = (hashCode * 59) + this.WebDataExemption.GetHashCode();
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
