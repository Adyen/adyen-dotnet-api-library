/*
* POS Terminal Management API
*
*
* The version of the OpenAPI document: 1
* Contact: developer-experience@adyen.com
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Adyen.Model.PosTerminalManagement
{
    /// <summary>
    /// FindTerminalRequest
    /// </summary>
    [DataContract]
    public partial class FindTerminalRequest :  IEquatable<FindTerminalRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FindTerminalRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FindTerminalRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FindTerminalRequest" /> class.
        /// </summary>
        /// <param name="terminal">The unique terminal ID in the format &#x60;[Device model]-[Serial number]&#x60;.   For example, **V400m-324689776**. (required).</param>
        public FindTerminalRequest(string terminal = default(string))
        {
            this.Terminal = terminal;
        }

        /// <summary>
        /// The unique terminal ID in the format &#x60;[Device model]-[Serial number]&#x60;.   For example, **V400m-324689776**.
        /// </summary>
        /// <value>The unique terminal ID in the format &#x60;[Device model]-[Serial number]&#x60;.   For example, **V400m-324689776**.</value>
        [DataMember(Name="terminal", EmitDefaultValue=true)]
        public string Terminal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FindTerminalRequest {\n");
            sb.Append("  Terminal: ").Append(Terminal).Append("\n");
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
            return this.Equals(input as FindTerminalRequest);
        }

        /// <summary>
        /// Returns true if FindTerminalRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of FindTerminalRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FindTerminalRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Terminal == input.Terminal ||
                    (this.Terminal != null &&
                    this.Terminal.Equals(input.Terminal))
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
                if (this.Terminal != null)
                    hashCode = hashCode * 59 + this.Terminal.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
