/*
* POS Terminal Management API
*
*
* The version of the OpenAPI document: 1
* Contact: developer-experience@adyen.com
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Adyen.Model.PosTerminalManagement
{
    /// <summary>
    /// GetStoresUnderAccountRequest
    /// </summary>
    [DataContract]
    public partial class GetStoresUnderAccountRequest :  IEquatable<GetStoresUnderAccountRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetStoresUnderAccountRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetStoresUnderAccountRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetStoresUnderAccountRequest" /> class.
        /// </summary>
        /// <param name="companyAccount">The company account. If you only specify this parameter, the response includes the stores of all merchant accounts that are associated with the company account. (required).</param>
        /// <param name="merchantAccount">The merchant account. With this parameter, the response only includes the stores of the specified merchant account..</param>
        public GetStoresUnderAccountRequest(string companyAccount = default(string), string merchantAccount = default(string))
        {
            this.CompanyAccount = companyAccount;
            this.MerchantAccount = merchantAccount;
        }

        /// <summary>
        /// The company account. If you only specify this parameter, the response includes the stores of all merchant accounts that are associated with the company account.
        /// </summary>
        /// <value>The company account. If you only specify this parameter, the response includes the stores of all merchant accounts that are associated with the company account.</value>
        [DataMember(Name="companyAccount", EmitDefaultValue=true)]
        public string CompanyAccount { get; set; }

        /// <summary>
        /// The merchant account. With this parameter, the response only includes the stores of the specified merchant account.
        /// </summary>
        /// <value>The merchant account. With this parameter, the response only includes the stores of the specified merchant account.</value>
        [DataMember(Name="merchantAccount", EmitDefaultValue=false)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetStoresUnderAccountRequest {\n");
            sb.Append("  CompanyAccount: ").Append(CompanyAccount).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
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
            return this.Equals(input as GetStoresUnderAccountRequest);
        }

        /// <summary>
        /// Returns true if GetStoresUnderAccountRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetStoresUnderAccountRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetStoresUnderAccountRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CompanyAccount == input.CompanyAccount ||
                    (this.CompanyAccount != null &&
                    this.CompanyAccount.Equals(input.CompanyAccount))
                ) && 
                (
                    this.MerchantAccount == input.MerchantAccount ||
                    (this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(input.MerchantAccount))
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
                if (this.CompanyAccount != null)
                    hashCode = hashCode * 59 + this.CompanyAccount.GetHashCode();
                if (this.MerchantAccount != null)
                    hashCode = hashCode * 59 + this.MerchantAccount.GetHashCode();
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
