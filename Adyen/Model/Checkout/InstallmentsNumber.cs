/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 70
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

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// InstallmentsNumber
    /// </summary>
    [DataContract(Name = "InstallmentsNumber")]
    public partial class InstallmentsNumber : IEquatable<InstallmentsNumber>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstallmentsNumber" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InstallmentsNumber() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InstallmentsNumber" /> class.
        /// </summary>
        /// <param name="maxNumberOfInstallments">Maximum number of installments (required).</param>
        public InstallmentsNumber(int? maxNumberOfInstallments = default(int?))
        {
            this.MaxNumberOfInstallments = maxNumberOfInstallments;
        }

        /// <summary>
        /// Maximum number of installments
        /// </summary>
        /// <value>Maximum number of installments</value>
        [DataMember(Name = "maxNumberOfInstallments", IsRequired = false, EmitDefaultValue = false)]
        public int? MaxNumberOfInstallments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InstallmentsNumber {\n");
            sb.Append("  MaxNumberOfInstallments: ").Append(MaxNumberOfInstallments).Append("\n");
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
            return this.Equals(input as InstallmentsNumber);
        }

        /// <summary>
        /// Returns true if InstallmentsNumber instances are equal
        /// </summary>
        /// <param name="input">Instance of InstallmentsNumber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstallmentsNumber input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MaxNumberOfInstallments == input.MaxNumberOfInstallments ||
                    this.MaxNumberOfInstallments.Equals(input.MaxNumberOfInstallments)
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
                hashCode = (hashCode * 59) + this.MaxNumberOfInstallments.GetHashCode();
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
