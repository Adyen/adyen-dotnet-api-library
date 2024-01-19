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
    /// It conveys the data to print and the way to process the print. It contains the complete content to print. Content of the Print Request message.
    /// </summary>
    [DataContract(Name = "PrintRequest")]
    public partial class PrintRequest : IEquatable<PrintRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrintRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PrintRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PrintRequest" /> class.
        /// </summary>
        /// <param name="printOutput">printOutput (required).</param>
        public PrintRequest(PrintOutput printOutput = default(PrintOutput))
        {
            this.PrintOutput = printOutput;
        }

        /// <summary>
        /// Gets or Sets PrintOutput
        /// </summary>
        [DataMember(Name = "PrintOutput", IsRequired = false, EmitDefaultValue = false)]
        public PrintOutput PrintOutput { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PrintRequest {\n");
            sb.Append("  PrintOutput: ").Append(PrintOutput).Append("\n");
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
            return this.Equals(input as PrintRequest);
        }

        /// <summary>
        /// Returns true if PrintRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PrintRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrintRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PrintOutput == input.PrintOutput ||
                    (this.PrintOutput != null &&
                    this.PrintOutput.Equals(input.PrintOutput))
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
                if (this.PrintOutput != null)
                {
                    hashCode = (hashCode * 59) + this.PrintOutput.GetHashCode();
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
