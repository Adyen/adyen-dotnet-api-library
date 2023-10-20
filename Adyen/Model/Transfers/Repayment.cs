/*
* Transfers API
*
*
* The version of the OpenAPI document: 4
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

namespace Adyen.Model.Transfers
{
    /// <summary>
    /// Repayment
    /// </summary>
    [DataContract(Name = "Repayment")]
    public partial class Repayment : IEquatable<Repayment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Repayment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Repayment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Repayment" /> class.
        /// </summary>
        /// <param name="basisPoints">The repayment that is deducted daily from incoming net volume, in [basis points](https://www.investopedia.com/terms/b/basispoint.asp). (required).</param>
        /// <param name="term">term.</param>
        /// <param name="threshold">threshold.</param>
        public Repayment(int? basisPoints = default(int?), RepaymentTerm term = default(RepaymentTerm), ThresholdRepayment threshold = default(ThresholdRepayment))
        {
            this.BasisPoints = basisPoints;
            this.Term = term;
            this.Threshold = threshold;
        }

        /// <summary>
        /// The repayment that is deducted daily from incoming net volume, in [basis points](https://www.investopedia.com/terms/b/basispoint.asp).
        /// </summary>
        /// <value>The repayment that is deducted daily from incoming net volume, in [basis points](https://www.investopedia.com/terms/b/basispoint.asp).</value>
        [DataMember(Name = "basisPoints", IsRequired = false, EmitDefaultValue = false)]
        public int? BasisPoints { get; set; }

        /// <summary>
        /// Gets or Sets Term
        /// </summary>
        [DataMember(Name = "term", EmitDefaultValue = false)]
        public RepaymentTerm Term { get; set; }

        /// <summary>
        /// Gets or Sets Threshold
        /// </summary>
        [DataMember(Name = "threshold", EmitDefaultValue = false)]
        public ThresholdRepayment Threshold { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Repayment {\n");
            sb.Append("  BasisPoints: ").Append(BasisPoints).Append("\n");
            sb.Append("  Term: ").Append(Term).Append("\n");
            sb.Append("  Threshold: ").Append(Threshold).Append("\n");
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
            return this.Equals(input as Repayment);
        }

        /// <summary>
        /// Returns true if Repayment instances are equal
        /// </summary>
        /// <param name="input">Instance of Repayment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Repayment input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BasisPoints == input.BasisPoints ||
                    this.BasisPoints.Equals(input.BasisPoints)
                ) && 
                (
                    this.Term == input.Term ||
                    (this.Term != null &&
                    this.Term.Equals(input.Term))
                ) && 
                (
                    this.Threshold == input.Threshold ||
                    (this.Threshold != null &&
                    this.Threshold.Equals(input.Threshold))
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
                hashCode = (hashCode * 59) + this.BasisPoints.GetHashCode();
                if (this.Term != null)
                {
                    hashCode = (hashCode * 59) + this.Term.GetHashCode();
                }
                if (this.Threshold != null)
                {
                    hashCode = (hashCode * 59) + this.Threshold.GetHashCode();
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
