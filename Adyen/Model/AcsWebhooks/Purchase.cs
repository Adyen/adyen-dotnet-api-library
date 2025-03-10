/*
* Authentication webhooks
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

namespace Adyen.Model.AcsWebhooks
{
    /// <summary>
    /// Purchase
    /// </summary>
    [DataContract(Name = "Purchase")]
    public partial class Purchase : IEquatable<Purchase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Purchase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Purchase() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Purchase" /> class.
        /// </summary>
        /// <param name="date">The time of the purchase. (required).</param>
        /// <param name="merchantName">The name of the merchant. (required).</param>
        /// <param name="originalAmount">originalAmount (required).</param>
        public Purchase(DateTime date = default(DateTime), string merchantName = default(string), Amount originalAmount = default(Amount))
        {
            this.Date = date;
            this.MerchantName = merchantName;
            this.OriginalAmount = originalAmount;
        }

        /// <summary>
        /// The time of the purchase.
        /// </summary>
        /// <value>The time of the purchase.</value>
        [DataMember(Name = "date", IsRequired = false, EmitDefaultValue = false)]
        public DateTime Date { get; set; }

        /// <summary>
        /// The name of the merchant.
        /// </summary>
        /// <value>The name of the merchant.</value>
        [DataMember(Name = "merchantName", IsRequired = false, EmitDefaultValue = false)]
        public string MerchantName { get; set; }

        /// <summary>
        /// Gets or Sets OriginalAmount
        /// </summary>
        [DataMember(Name = "originalAmount", IsRequired = false, EmitDefaultValue = false)]
        public Amount OriginalAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Purchase {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  MerchantName: ").Append(MerchantName).Append("\n");
            sb.Append("  OriginalAmount: ").Append(OriginalAmount).Append("\n");
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
            return this.Equals(input as Purchase);
        }

        /// <summary>
        /// Returns true if Purchase instances are equal
        /// </summary>
        /// <param name="input">Instance of Purchase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Purchase input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.MerchantName == input.MerchantName ||
                    (this.MerchantName != null &&
                    this.MerchantName.Equals(input.MerchantName))
                ) && 
                (
                    this.OriginalAmount == input.OriginalAmount ||
                    (this.OriginalAmount != null &&
                    this.OriginalAmount.Equals(input.OriginalAmount))
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
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
                }
                if (this.MerchantName != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantName.GetHashCode();
                }
                if (this.OriginalAmount != null)
                {
                    hashCode = (hashCode * 59) + this.OriginalAmount.GetHashCode();
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
