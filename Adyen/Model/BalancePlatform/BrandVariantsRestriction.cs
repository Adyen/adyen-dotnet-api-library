/*
* Configuration API
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

namespace Adyen.Model.BalancePlatform
{
    /// <summary>
    /// BrandVariantsRestriction
    /// </summary>
    [DataContract(Name = "BrandVariantsRestriction")]
    public partial class BrandVariantsRestriction : IEquatable<BrandVariantsRestriction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrandVariantsRestriction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BrandVariantsRestriction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BrandVariantsRestriction" /> class.
        /// </summary>
        /// <param name="operation">Defines how the condition must be evaluated. (required).</param>
        /// <param name="value">List of card brand variants.  Possible values:   - **mc**, **mccredit**, **mccommercialcredit_b2b**, **mcdebit**, **mcbusinessdebit**, **mcbusinessworlddebit**, **mcprepaid**, **mcmaestro**   - **visa**, **visacredit**, **visadebit**, **visaprepaid**.  You can specify a rule for a generic variant. For example, to create a rule for all Mastercard payment instruments, use **mc**. The rule is applied to all payment instruments under **mc**, such as **mcbusinessdebit** and **mcdebit**.  .</param>
        public BrandVariantsRestriction(string operation = default(string), List<string> value = default(List<string>))
        {
            this.Operation = operation;
            this.Value = value;
        }

        /// <summary>
        /// Defines how the condition must be evaluated.
        /// </summary>
        /// <value>Defines how the condition must be evaluated.</value>
        [DataMember(Name = "operation", IsRequired = false, EmitDefaultValue = false)]
        public string Operation { get; set; }

        /// <summary>
        /// List of card brand variants.  Possible values:   - **mc**, **mccredit**, **mccommercialcredit_b2b**, **mcdebit**, **mcbusinessdebit**, **mcbusinessworlddebit**, **mcprepaid**, **mcmaestro**   - **visa**, **visacredit**, **visadebit**, **visaprepaid**.  You can specify a rule for a generic variant. For example, to create a rule for all Mastercard payment instruments, use **mc**. The rule is applied to all payment instruments under **mc**, such as **mcbusinessdebit** and **mcdebit**.  
        /// </summary>
        /// <value>List of card brand variants.  Possible values:   - **mc**, **mccredit**, **mccommercialcredit_b2b**, **mcdebit**, **mcbusinessdebit**, **mcbusinessworlddebit**, **mcprepaid**, **mcmaestro**   - **visa**, **visacredit**, **visadebit**, **visaprepaid**.  You can specify a rule for a generic variant. For example, to create a rule for all Mastercard payment instruments, use **mc**. The rule is applied to all payment instruments under **mc**, such as **mcbusinessdebit** and **mcdebit**.  </value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public List<string> Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BrandVariantsRestriction {\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as BrandVariantsRestriction);
        }

        /// <summary>
        /// Returns true if BrandVariantsRestriction instances are equal
        /// </summary>
        /// <param name="input">Instance of BrandVariantsRestriction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrandVariantsRestriction input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value != null &&
                    input.Value != null &&
                    this.Value.SequenceEqual(input.Value)
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
                if (this.Operation != null)
                {
                    hashCode = (hashCode * 59) + this.Operation.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
