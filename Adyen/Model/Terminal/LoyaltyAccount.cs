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
    /// This data structure conveys the identification of the account and the associated loyalty brand. Data related to a loyalty account processed in the transaction.
    /// </summary>
    [DataContract(Name = "LoyaltyAccount")]
    public partial class LoyaltyAccount : IEquatable<LoyaltyAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyAccount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LoyaltyAccount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyAccount" /> class.
        /// </summary>
        /// <param name="loyaltyAccountID">loyaltyAccountID (required).</param>
        /// <param name="loyaltyBrand">If a card is analysed..</param>
        public LoyaltyAccount(LoyaltyAccountID loyaltyAccountID = default(LoyaltyAccountID), string loyaltyBrand = default(string))
        {
            this.LoyaltyAccountID = loyaltyAccountID;
            this.LoyaltyBrand = loyaltyBrand;
        }

        /// <summary>
        /// Gets or Sets LoyaltyAccountID
        /// </summary>
        [DataMember(Name = "LoyaltyAccountID", IsRequired = false, EmitDefaultValue = false)]
        public LoyaltyAccountID LoyaltyAccountID { get; set; }

        /// <summary>
        /// If a card is analysed.
        /// </summary>
        /// <value>If a card is analysed.</value>
        [DataMember(Name = "LoyaltyBrand", EmitDefaultValue = false)]
        public string LoyaltyBrand { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LoyaltyAccount {\n");
            sb.Append("  LoyaltyAccountID: ").Append(LoyaltyAccountID).Append("\n");
            sb.Append("  LoyaltyBrand: ").Append(LoyaltyBrand).Append("\n");
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
            return this.Equals(input as LoyaltyAccount);
        }

        /// <summary>
        /// Returns true if LoyaltyAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of LoyaltyAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoyaltyAccount input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LoyaltyAccountID == input.LoyaltyAccountID ||
                    (this.LoyaltyAccountID != null &&
                    this.LoyaltyAccountID.Equals(input.LoyaltyAccountID))
                ) && 
                (
                    this.LoyaltyBrand == input.LoyaltyBrand ||
                    (this.LoyaltyBrand != null &&
                    this.LoyaltyBrand.Equals(input.LoyaltyBrand))
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
                if (this.LoyaltyAccountID != null)
                {
                    hashCode = (hashCode * 59) + this.LoyaltyAccountID.GetHashCode();
                }
                if (this.LoyaltyBrand != null)
                {
                    hashCode = (hashCode * 59) + this.LoyaltyBrand.GetHashCode();
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
            // LoyaltyBrand (string) pattern
            Regex regexLoyaltyBrand = new Regex(@"^.+$", RegexOptions.CultureInvariant);
            if (false == regexLoyaltyBrand.Match(this.LoyaltyBrand).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LoyaltyBrand, must match a pattern of " + regexLoyaltyBrand, new [] { "LoyaltyBrand" });
            }

            yield break;
        }
    }

}
