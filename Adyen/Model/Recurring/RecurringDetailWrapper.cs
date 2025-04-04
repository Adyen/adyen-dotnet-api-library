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
    /// RecurringDetailWrapper
    /// </summary>
    [DataContract(Name = "RecurringDetailWrapper")]
    public partial class RecurringDetailWrapper : IEquatable<RecurringDetailWrapper>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecurringDetailWrapper" /> class.
        /// </summary>
        /// <param name="recurringDetail">recurringDetail.</param>
        public RecurringDetailWrapper(RecurringDetail recurringDetail = default(RecurringDetail))
        {
            this.RecurringDetail = recurringDetail;
        }

        /// <summary>
        /// Gets or Sets RecurringDetail
        /// </summary>
        [DataMember(Name = "RecurringDetail", EmitDefaultValue = false)]
        public RecurringDetail RecurringDetail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RecurringDetailWrapper {\n");
            sb.Append("  RecurringDetail: ").Append(RecurringDetail).Append("\n");
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
            return this.Equals(input as RecurringDetailWrapper);
        }

        /// <summary>
        /// Returns true if RecurringDetailWrapper instances are equal
        /// </summary>
        /// <param name="input">Instance of RecurringDetailWrapper to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecurringDetailWrapper input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RecurringDetail == input.RecurringDetail ||
                    (this.RecurringDetail != null &&
                    this.RecurringDetail.Equals(input.RecurringDetail))
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
                if (this.RecurringDetail != null)
                {
                    hashCode = (hashCode * 59) + this.RecurringDetail.GetHashCode();
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
