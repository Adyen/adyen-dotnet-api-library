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
    /// It conveys data to display and the way to process the display, and contains the complete content to display. In addition to the display on the Input Device, it might contain an operation (the DisplayOutput element) per Display Device type. Content of the Input Request message.
    /// </summary>
    [DataContract(Name = "InputRequest")]
    public partial class InputRequest : IEquatable<InputRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InputRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InputRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InputRequest" /> class.
        /// </summary>
        /// <param name="displayOutput">displayOutput.</param>
        /// <param name="inputData">inputData (required).</param>
        public InputRequest(DisplayOutput displayOutput = default(DisplayOutput), InputData inputData = default(InputData))
        {
            this.InputData = inputData;
            this.DisplayOutput = displayOutput;
        }

        /// <summary>
        /// Gets or Sets DisplayOutput
        /// </summary>
        [DataMember(Name = "DisplayOutput", EmitDefaultValue = false)]
        public DisplayOutput DisplayOutput { get; set; }

        /// <summary>
        /// Gets or Sets InputData
        /// </summary>
        [DataMember(Name = "InputData", IsRequired = false, EmitDefaultValue = false)]
        public InputData InputData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InputRequest {\n");
            sb.Append("  DisplayOutput: ").Append(DisplayOutput).Append("\n");
            sb.Append("  InputData: ").Append(InputData).Append("\n");
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
            return this.Equals(input as InputRequest);
        }

        /// <summary>
        /// Returns true if InputRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of InputRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InputRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DisplayOutput == input.DisplayOutput ||
                    (this.DisplayOutput != null &&
                    this.DisplayOutput.Equals(input.DisplayOutput))
                ) && 
                (
                    this.InputData == input.InputData ||
                    (this.InputData != null &&
                    this.InputData.Equals(input.InputData))
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
                if (this.DisplayOutput != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayOutput.GetHashCode();
                }
                if (this.InputData != null)
                {
                    hashCode = (hashCode * 59) + this.InputData.GetHashCode();
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
