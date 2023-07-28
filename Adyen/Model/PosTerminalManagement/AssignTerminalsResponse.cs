/*
* POS Terminal Management API
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

namespace Adyen.Model.PosTerminalManagement
{
    /// <summary>
    /// AssignTerminalsResponse
    /// </summary>
    [DataContract(Name = "AssignTerminalsResponse")]
    public partial class AssignTerminalsResponse : IEquatable<AssignTerminalsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssignTerminalsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssignTerminalsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssignTerminalsResponse" /> class.
        /// </summary>
        /// <param name="results">Array that returns a list of the terminals, and for each terminal the result of assigning it to an account or store.  The results can be:    - &#x60;Done&#x60;: The terminal has been assigned.   - &#x60;AssignmentScheduled&#x60;: The terminal will be assigned asynschronously.   - &#x60;RemoveConfigScheduled&#x60;: The terminal was previously assigned and boarded. Wait for the terminal to synchronize with the Adyen platform. For more information, refer to [Reassigning boarded terminals](https://docs.adyen.com/point-of-sale/managing-terminals/assign-terminals#reassign-boarded-terminals).   - &#x60;Error&#x60;: There was an error when assigning the terminal.  (required).</param>
        public AssignTerminalsResponse(Dictionary<string, string> results = default(Dictionary<string, string>))
        {
            this.Results = results;
        }

        /// <summary>
        /// Array that returns a list of the terminals, and for each terminal the result of assigning it to an account or store.  The results can be:    - &#x60;Done&#x60;: The terminal has been assigned.   - &#x60;AssignmentScheduled&#x60;: The terminal will be assigned asynschronously.   - &#x60;RemoveConfigScheduled&#x60;: The terminal was previously assigned and boarded. Wait for the terminal to synchronize with the Adyen platform. For more information, refer to [Reassigning boarded terminals](https://docs.adyen.com/point-of-sale/managing-terminals/assign-terminals#reassign-boarded-terminals).   - &#x60;Error&#x60;: There was an error when assigning the terminal. 
        /// </summary>
        /// <value>Array that returns a list of the terminals, and for each terminal the result of assigning it to an account or store.  The results can be:    - &#x60;Done&#x60;: The terminal has been assigned.   - &#x60;AssignmentScheduled&#x60;: The terminal will be assigned asynschronously.   - &#x60;RemoveConfigScheduled&#x60;: The terminal was previously assigned and boarded. Wait for the terminal to synchronize with the Adyen platform. For more information, refer to [Reassigning boarded terminals](https://docs.adyen.com/point-of-sale/managing-terminals/assign-terminals#reassign-boarded-terminals).   - &#x60;Error&#x60;: There was an error when assigning the terminal. </value>
        [DataMember(Name = "results", IsRequired = false, EmitDefaultValue = false)]
        public Dictionary<string, string> Results { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AssignTerminalsResponse {\n");
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
            return this.Equals(input as AssignTerminalsResponse);
        }

        /// <summary>
        /// Returns true if AssignTerminalsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AssignTerminalsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssignTerminalsResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
