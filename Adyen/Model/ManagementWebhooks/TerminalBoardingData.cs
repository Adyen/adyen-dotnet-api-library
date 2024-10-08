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

namespace Adyen.Model.ManagementWebhooks
{
    /// <summary>
    /// TerminalBoardingData
    /// </summary>
    [DataContract(Name = "TerminalBoardingData")]
    public partial class TerminalBoardingData : IEquatable<TerminalBoardingData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TerminalBoardingData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TerminalBoardingData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TerminalBoardingData" /> class.
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account. (required).</param>
        /// <param name="merchantId">The unique identifier of the merchant account..</param>
        /// <param name="storeId">The unique identifier of the store..</param>
        /// <param name="uniqueTerminalId">The unique identifier of the terminal. (required).</param>
        public TerminalBoardingData(string companyId = default(string), string merchantId = default(string), string storeId = default(string), string uniqueTerminalId = default(string))
        {
            this.CompanyId = companyId;
            this.UniqueTerminalId = uniqueTerminalId;
            this.MerchantId = merchantId;
            this.StoreId = storeId;
        }

        /// <summary>
        /// The unique identifier of the company account.
        /// </summary>
        /// <value>The unique identifier of the company account.</value>
        [DataMember(Name = "companyId", IsRequired = false, EmitDefaultValue = false)]
        public string CompanyId { get; set; }

        /// <summary>
        /// The unique identifier of the merchant account.
        /// </summary>
        /// <value>The unique identifier of the merchant account.</value>
        [DataMember(Name = "merchantId", EmitDefaultValue = false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// The unique identifier of the store.
        /// </summary>
        /// <value>The unique identifier of the store.</value>
        [DataMember(Name = "storeId", EmitDefaultValue = false)]
        public string StoreId { get; set; }

        /// <summary>
        /// The unique identifier of the terminal.
        /// </summary>
        /// <value>The unique identifier of the terminal.</value>
        [DataMember(Name = "uniqueTerminalId", IsRequired = false, EmitDefaultValue = false)]
        public string UniqueTerminalId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TerminalBoardingData {\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  UniqueTerminalId: ").Append(UniqueTerminalId).Append("\n");
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
            return this.Equals(input as TerminalBoardingData);
        }

        /// <summary>
        /// Returns true if TerminalBoardingData instances are equal
        /// </summary>
        /// <param name="input">Instance of TerminalBoardingData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TerminalBoardingData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CompanyId == input.CompanyId ||
                    (this.CompanyId != null &&
                    this.CompanyId.Equals(input.CompanyId))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
                ) && 
                (
                    this.UniqueTerminalId == input.UniqueTerminalId ||
                    (this.UniqueTerminalId != null &&
                    this.UniqueTerminalId.Equals(input.UniqueTerminalId))
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
                if (this.CompanyId != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyId.GetHashCode();
                }
                if (this.MerchantId != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantId.GetHashCode();
                }
                if (this.StoreId != null)
                {
                    hashCode = (hashCode * 59) + this.StoreId.GetHashCode();
                }
                if (this.UniqueTerminalId != null)
                {
                    hashCode = (hashCode * 59) + this.UniqueTerminalId.GetHashCode();
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
