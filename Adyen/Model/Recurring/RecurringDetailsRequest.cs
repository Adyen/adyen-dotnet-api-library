/*
* Adyen Recurring API (deprecated)
*
*
* The version of the OpenAPI document: 68
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

namespace Adyen.Model.Recurring
{
    /// <summary>
    /// RecurringDetailsRequest
    /// </summary>
    [DataContract(Name = "RecurringDetailsRequest")]
    public partial class RecurringDetailsRequest : IEquatable<RecurringDetailsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecurringDetailsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RecurringDetailsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecurringDetailsRequest" /> class.
        /// </summary>
        /// <param name="merchantAccount">The merchant account identifier you want to process the (transaction) request with. (required).</param>
        /// <param name="recurring">recurring.</param>
        /// <param name="shopperReference">The reference you use to uniquely identify the shopper (e.g. user ID or account ID). (required).</param>
        public RecurringDetailsRequest(string merchantAccount = default(string), Recurring recurring = default(Recurring), string shopperReference = default(string))
        {
            this.MerchantAccount = merchantAccount;
            this.ShopperReference = shopperReference;
            this.Recurring = recurring;
        }

        /// <summary>
        /// The merchant account identifier you want to process the (transaction) request with.
        /// </summary>
        /// <value>The merchant account identifier you want to process the (transaction) request with.</value>
        [DataMember(Name = "merchantAccount", IsRequired = false, EmitDefaultValue = false)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// Gets or Sets Recurring
        /// </summary>
        [DataMember(Name = "recurring", EmitDefaultValue = false)]
        public Recurring Recurring { get; set; }

        /// <summary>
        /// The reference you use to uniquely identify the shopper (e.g. user ID or account ID).
        /// </summary>
        /// <value>The reference you use to uniquely identify the shopper (e.g. user ID or account ID).</value>
        [DataMember(Name = "shopperReference", IsRequired = false, EmitDefaultValue = false)]
        public string ShopperReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RecurringDetailsRequest {\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  Recurring: ").Append(Recurring).Append("\n");
            sb.Append("  ShopperReference: ").Append(ShopperReference).Append("\n");
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
            return this.Equals(input as RecurringDetailsRequest);
        }

        /// <summary>
        /// Returns true if RecurringDetailsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RecurringDetailsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecurringDetailsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MerchantAccount == input.MerchantAccount ||
                    (this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(input.MerchantAccount))
                ) && 
                (
                    this.Recurring == input.Recurring ||
                    (this.Recurring != null &&
                    this.Recurring.Equals(input.Recurring))
                ) && 
                (
                    this.ShopperReference == input.ShopperReference ||
                    (this.ShopperReference != null &&
                    this.ShopperReference.Equals(input.ShopperReference))
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
                if (this.MerchantAccount != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantAccount.GetHashCode();
                }
                if (this.Recurring != null)
                {
                    hashCode = (hashCode * 59) + this.Recurring.GetHashCode();
                }
                if (this.ShopperReference != null)
                {
                    hashCode = (hashCode * 59) + this.ShopperReference.GetHashCode();
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
