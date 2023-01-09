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
    /// CheckoutUtilityRequest
    /// </summary>
    [DataContract(Name = "CheckoutUtilityRequest")]
    public partial class CheckoutUtilityRequest : IEquatable<CheckoutUtilityRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutUtilityRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CheckoutUtilityRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutUtilityRequest" /> class.
        /// </summary>
        /// <param name="originDomains">The list of origin domains, for which origin keys are requested. (required).</param>
        public CheckoutUtilityRequest(List<string> originDomains = default(List<string>))
        {
            this.OriginDomains = originDomains;
        }

        /// <summary>
        /// The list of origin domains, for which origin keys are requested.
        /// </summary>
        /// <value>The list of origin domains, for which origin keys are requested.</value>
        [DataMember(Name = "originDomains", IsRequired = false, EmitDefaultValue = true)]
        public List<string> OriginDomains { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CheckoutUtilityRequest {\n");
            sb.Append("  OriginDomains: ").Append(OriginDomains).Append("\n");
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
            return this.Equals(input as CheckoutUtilityRequest);
        }

        /// <summary>
        /// Returns true if CheckoutUtilityRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckoutUtilityRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckoutUtilityRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OriginDomains == input.OriginDomains ||
                    this.OriginDomains != null &&
                    input.OriginDomains != null &&
                    this.OriginDomains.SequenceEqual(input.OriginDomains)
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
                if (this.OriginDomains != null)
                {
                    hashCode = (hashCode * 59) + this.OriginDomains.GetHashCode();
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
