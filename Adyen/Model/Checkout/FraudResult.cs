/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 69
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

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// FraudResult
    /// </summary>
    [DataContract(Name = "FraudResult")]
    public partial class FraudResult : IEquatable<FraudResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FraudResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FraudResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FraudResult" /> class.
        /// </summary>
        /// <param name="accountScore">The total fraud score generated by the risk checks. (required).</param>
        /// <param name="results">The result of the individual risk checks..</param>
        public FraudResult(int accountScore = default(int), List<FraudCheckResult> results = default(List<FraudCheckResult>))
        {
            this.AccountScore = accountScore;
            this.Results = results;
        }

        /// <summary>
        /// The total fraud score generated by the risk checks.
        /// </summary>
        /// <value>The total fraud score generated by the risk checks.</value>
        [DataMember(Name = "accountScore", IsRequired = false, EmitDefaultValue = true)]
        public int AccountScore { get; set; }

        /// <summary>
        /// The result of the individual risk checks.
        /// </summary>
        /// <value>The result of the individual risk checks.</value>
        [DataMember(Name = "results", EmitDefaultValue = false)]
        public List<FraudCheckResult> Results { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FraudResult {\n");
            sb.Append("  AccountScore: ").Append(AccountScore).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
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
            return this.Equals(input as FraudResult);
        }

        /// <summary>
        /// Returns true if FraudResult instances are equal
        /// </summary>
        /// <param name="input">Instance of FraudResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FraudResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountScore == input.AccountScore ||
                    this.AccountScore.Equals(input.AccountScore)
                ) && 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    input.Results != null &&
                    this.Results.SequenceEqual(input.Results)
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
                hashCode = (hashCode * 59) + this.AccountScore.GetHashCode();
                if (this.Results != null)
                {
                    hashCode = (hashCode * 59) + this.Results.GetHashCode();
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
