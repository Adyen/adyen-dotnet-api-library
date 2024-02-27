/*
* Configuration API
*
*
* The version of the OpenAPI document: 2
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
    /// RevealPinResponse
    /// </summary>
    [DataContract(Name = "RevealPinResponse")]
    public partial class RevealPinResponse : IEquatable<RevealPinResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RevealPinResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RevealPinResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RevealPinResponse" /> class.
        /// </summary>
        /// <param name="encryptedPinBlock">The encrypted [PIN block](https://www.pcisecuritystandards.org/glossary/pin-block). (required).</param>
        /// <param name="token">The 16-digit token that you need to extract the &#x60;encryptedPinBlock&#x60;. (required).</param>
        public RevealPinResponse(string encryptedPinBlock = default(string), string token = default(string))
        {
            this.EncryptedPinBlock = encryptedPinBlock;
            this.Token = token;
        }

        /// <summary>
        /// The encrypted [PIN block](https://www.pcisecuritystandards.org/glossary/pin-block).
        /// </summary>
        /// <value>The encrypted [PIN block](https://www.pcisecuritystandards.org/glossary/pin-block).</value>
        [DataMember(Name = "encryptedPinBlock", IsRequired = false, EmitDefaultValue = false)]
        public string EncryptedPinBlock { get; set; }

        /// <summary>
        /// The 16-digit token that you need to extract the &#x60;encryptedPinBlock&#x60;.
        /// </summary>
        /// <value>The 16-digit token that you need to extract the &#x60;encryptedPinBlock&#x60;.</value>
        [DataMember(Name = "token", IsRequired = false, EmitDefaultValue = false)]
        public string Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RevealPinResponse {\n");
            sb.Append("  EncryptedPinBlock: ").Append(EncryptedPinBlock).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
            return this.Equals(input as RevealPinResponse);
        }

        /// <summary>
        /// Returns true if RevealPinResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RevealPinResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RevealPinResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EncryptedPinBlock == input.EncryptedPinBlock ||
                    (this.EncryptedPinBlock != null &&
                    this.EncryptedPinBlock.Equals(input.EncryptedPinBlock))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
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
                if (this.EncryptedPinBlock != null)
                {
                    hashCode = (hashCode * 59) + this.EncryptedPinBlock.GetHashCode();
                }
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
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
