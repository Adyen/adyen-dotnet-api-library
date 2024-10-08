/*
* Payments App API
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

namespace Adyen.Model.PaymentsApp
{
    /// <summary>
    /// PaymentsAppResponse
    /// </summary>
    [DataContract(Name = "PaymentsAppResponse")]
    public partial class PaymentsAppResponse : IEquatable<PaymentsAppResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsAppResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentsAppResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsAppResponse" /> class.
        /// </summary>
        /// <param name="paymentsApps">List of Payments Apps. (required).</param>
        public PaymentsAppResponse(List<PaymentsAppDto> paymentsApps = default(List<PaymentsAppDto>))
        {
            this.PaymentsApps = paymentsApps;
        }

        /// <summary>
        /// List of Payments Apps.
        /// </summary>
        /// <value>List of Payments Apps.</value>
        [DataMember(Name = "paymentsApps", IsRequired = false, EmitDefaultValue = false)]
        public List<PaymentsAppDto> PaymentsApps { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentsAppResponse {\n");
            sb.Append("  PaymentsApps: ").Append(PaymentsApps).Append("\n");
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
            return this.Equals(input as PaymentsAppResponse);
        }

        /// <summary>
        /// Returns true if PaymentsAppResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentsAppResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentsAppResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PaymentsApps == input.PaymentsApps ||
                    this.PaymentsApps != null &&
                    input.PaymentsApps != null &&
                    this.PaymentsApps.SequenceEqual(input.PaymentsApps)
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
                if (this.PaymentsApps != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentsApps.GetHashCode();
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
