/*
* Adyen Terminal API
*
*
* The version of the OpenAPI document: 1
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

namespace Adyen.Model.Terminal
{
    /// <summary>
    /// It conveys Information related to the Loyalty transaction to process. Content of the Loyalty Request message.
    /// </summary>
    [DataContract(Name = "LoyaltyRequest")]
    public partial class LoyaltyRequest : IEquatable<LoyaltyRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LoyaltyRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyRequest" /> class.
        /// </summary>
        /// <param name="saleData">saleData (required).</param>
        /// <param name="loyaltyTransaction">loyaltyTransaction (required).</param>
        /// <param name="loyaltyData">loyaltyData (required).</param>
        public LoyaltyRequest(SaleData saleData = default(SaleData), LoyaltyTransaction loyaltyTransaction = default(LoyaltyTransaction), LoyaltyData loyaltyData = default(LoyaltyData))
        {
            this.SaleData = saleData;
            this.LoyaltyTransaction = loyaltyTransaction;
            this.LoyaltyData = loyaltyData;
        }

        /// <summary>
        /// Gets or Sets SaleData
        /// </summary>
        [DataMember(Name = "SaleData", IsRequired = false, EmitDefaultValue = false)]
        public SaleData SaleData { get; set; }

        /// <summary>
        /// Gets or Sets LoyaltyTransaction
        /// </summary>
        [DataMember(Name = "LoyaltyTransaction", IsRequired = false, EmitDefaultValue = false)]
        public LoyaltyTransaction LoyaltyTransaction { get; set; }

        /// <summary>
        /// Gets or Sets LoyaltyData
        /// </summary>
        [DataMember(Name = "LoyaltyData", IsRequired = false, EmitDefaultValue = false)]
        public LoyaltyData LoyaltyData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LoyaltyRequest {\n");
            sb.Append("  SaleData: ").Append(SaleData).Append("\n");
            sb.Append("  LoyaltyTransaction: ").Append(LoyaltyTransaction).Append("\n");
            sb.Append("  LoyaltyData: ").Append(LoyaltyData).Append("\n");
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
            return this.Equals(input as LoyaltyRequest);
        }

        /// <summary>
        /// Returns true if LoyaltyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LoyaltyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoyaltyRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SaleData == input.SaleData ||
                    (this.SaleData != null &&
                    this.SaleData.Equals(input.SaleData))
                ) && 
                (
                    this.LoyaltyTransaction == input.LoyaltyTransaction ||
                    (this.LoyaltyTransaction != null &&
                    this.LoyaltyTransaction.Equals(input.LoyaltyTransaction))
                ) && 
                (
                    this.LoyaltyData == input.LoyaltyData ||
                    (this.LoyaltyData != null &&
                    this.LoyaltyData.Equals(input.LoyaltyData))
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
                if (this.SaleData != null)
                {
                    hashCode = (hashCode * 59) + this.SaleData.GetHashCode();
                }
                if (this.LoyaltyTransaction != null)
                {
                    hashCode = (hashCode * 59) + this.LoyaltyTransaction.GetHashCode();
                }
                if (this.LoyaltyData != null)
                {
                    hashCode = (hashCode * 59) + this.LoyaltyData.GetHashCode();
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
