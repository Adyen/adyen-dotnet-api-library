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
    /// RecurringDetailsResult
    /// </summary>
    [DataContract(Name = "RecurringDetailsResult")]
    public partial class RecurringDetailsResult : IEquatable<RecurringDetailsResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecurringDetailsResult" /> class.
        /// </summary>
        /// <param name="creationDate">The date when the recurring details were created..</param>
        /// <param name="details">Payment details stored for recurring payments..</param>
        /// <param name="lastKnownShopperEmail">The most recent email for this shopper (if available)..</param>
        /// <param name="shopperReference">The reference you use to uniquely identify the shopper (e.g. user ID or account ID)..</param>
        public RecurringDetailsResult(DateTime creationDate = default(DateTime), List<RecurringDetailWrapper> details = default(List<RecurringDetailWrapper>), string lastKnownShopperEmail = default(string), string shopperReference = default(string))
        {
            this.CreationDate = creationDate;
            this.Details = details;
            this.LastKnownShopperEmail = lastKnownShopperEmail;
            this.ShopperReference = shopperReference;
        }

        /// <summary>
        /// The date when the recurring details were created.
        /// </summary>
        /// <value>The date when the recurring details were created.</value>
        [DataMember(Name = "creationDate", EmitDefaultValue = false)]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Payment details stored for recurring payments.
        /// </summary>
        /// <value>Payment details stored for recurring payments.</value>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public List<RecurringDetailWrapper> Details { get; set; }

        /// <summary>
        /// The most recent email for this shopper (if available).
        /// </summary>
        /// <value>The most recent email for this shopper (if available).</value>
        [DataMember(Name = "lastKnownShopperEmail", EmitDefaultValue = false)]
        public string LastKnownShopperEmail { get; set; }

        /// <summary>
        /// The reference you use to uniquely identify the shopper (e.g. user ID or account ID).
        /// </summary>
        /// <value>The reference you use to uniquely identify the shopper (e.g. user ID or account ID).</value>
        [DataMember(Name = "shopperReference", EmitDefaultValue = false)]
        public string ShopperReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RecurringDetailsResult {\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  LastKnownShopperEmail: ").Append(LastKnownShopperEmail).Append("\n");
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
            return this.Equals(input as RecurringDetailsResult);
        }

        /// <summary>
        /// Returns true if RecurringDetailsResult instances are equal
        /// </summary>
        /// <param name="input">Instance of RecurringDetailsResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecurringDetailsResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    input.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                ) && 
                (
                    this.LastKnownShopperEmail == input.LastKnownShopperEmail ||
                    (this.LastKnownShopperEmail != null &&
                    this.LastKnownShopperEmail.Equals(input.LastKnownShopperEmail))
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
                if (this.CreationDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreationDate.GetHashCode();
                }
                if (this.Details != null)
                {
                    hashCode = (hashCode * 59) + this.Details.GetHashCode();
                }
                if (this.LastKnownShopperEmail != null)
                {
                    hashCode = (hashCode * 59) + this.LastKnownShopperEmail.GetHashCode();
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
