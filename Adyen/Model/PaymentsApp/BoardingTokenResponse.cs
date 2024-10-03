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
    /// BoardingTokenResponse
    /// </summary>
    [DataContract(Name = "BoardingTokenResponse")]
    public partial class BoardingTokenResponse : IEquatable<BoardingTokenResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoardingTokenResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BoardingTokenResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BoardingTokenResponse" /> class.
        /// </summary>
        /// <param name="boardingToken">The boarding token that allows the Payments App to board. (required).</param>
        /// <param name="installationId">The unique identifier of the Payments App instance. (required).</param>
        public BoardingTokenResponse(string boardingToken = default(string), string installationId = default(string))
        {
            this.BoardingToken = boardingToken;
            this.InstallationId = installationId;
        }

        /// <summary>
        /// The boarding token that allows the Payments App to board.
        /// </summary>
        /// <value>The boarding token that allows the Payments App to board.</value>
        [DataMember(Name = "boardingToken", IsRequired = false, EmitDefaultValue = false)]
        public string BoardingToken { get; set; }

        /// <summary>
        /// The unique identifier of the Payments App instance.
        /// </summary>
        /// <value>The unique identifier of the Payments App instance.</value>
        [DataMember(Name = "installationId", IsRequired = false, EmitDefaultValue = false)]
        public string InstallationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BoardingTokenResponse {\n");
            sb.Append("  BoardingToken: ").Append(BoardingToken).Append("\n");
            sb.Append("  InstallationId: ").Append(InstallationId).Append("\n");
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
            return this.Equals(input as BoardingTokenResponse);
        }

        /// <summary>
        /// Returns true if BoardingTokenResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of BoardingTokenResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoardingTokenResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BoardingToken == input.BoardingToken ||
                    (this.BoardingToken != null &&
                    this.BoardingToken.Equals(input.BoardingToken))
                ) && 
                (
                    this.InstallationId == input.InstallationId ||
                    (this.InstallationId != null &&
                    this.InstallationId.Equals(input.InstallationId))
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
                if (this.BoardingToken != null)
                {
                    hashCode = (hashCode * 59) + this.BoardingToken.GetHashCode();
                }
                if (this.InstallationId != null)
                {
                    hashCode = (hashCode * 59) + this.InstallationId.GetHashCode();
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