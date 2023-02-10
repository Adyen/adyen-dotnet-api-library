/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 70
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
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// SDKEphemPubKey
    /// </summary>
    [DataContract(Name = "SDKEphemPubKey")]
    public partial class SDKEphemPubKey : IEquatable<SDKEphemPubKey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SDKEphemPubKey" /> class.
        /// </summary>
        /// <param name="crv">The &#x60;crv&#x60; value as received from the 3D Secure 2 SDK..</param>
        /// <param name="kty">The &#x60;kty&#x60; value as received from the 3D Secure 2 SDK..</param>
        /// <param name="x">The &#x60;x&#x60; value as received from the 3D Secure 2 SDK..</param>
        /// <param name="y">The &#x60;y&#x60; value as received from the 3D Secure 2 SDK..</param>
        public SDKEphemPubKey(string crv = default(string), string kty = default(string), string x = default(string), string y = default(string))
        {
            this.Crv = crv;
            this.Kty = kty;
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// The &#x60;crv&#x60; value as received from the 3D Secure 2 SDK.
        /// </summary>
        /// <value>The &#x60;crv&#x60; value as received from the 3D Secure 2 SDK.</value>
        [DataMember(Name = "crv", EmitDefaultValue = false)]
        public string Crv { get; set; }

        /// <summary>
        /// The &#x60;kty&#x60; value as received from the 3D Secure 2 SDK.
        /// </summary>
        /// <value>The &#x60;kty&#x60; value as received from the 3D Secure 2 SDK.</value>
        [DataMember(Name = "kty", EmitDefaultValue = false)]
        public string Kty { get; set; }

        /// <summary>
        /// The &#x60;x&#x60; value as received from the 3D Secure 2 SDK.
        /// </summary>
        /// <value>The &#x60;x&#x60; value as received from the 3D Secure 2 SDK.</value>
        [DataMember(Name = "x", EmitDefaultValue = false)]
        public string X { get; set; }

        /// <summary>
        /// The &#x60;y&#x60; value as received from the 3D Secure 2 SDK.
        /// </summary>
        /// <value>The &#x60;y&#x60; value as received from the 3D Secure 2 SDK.</value>
        [DataMember(Name = "y", EmitDefaultValue = false)]
        public string Y { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SDKEphemPubKey {\n");
            sb.Append("  Crv: ").Append(Crv).Append("\n");
            sb.Append("  Kty: ").Append(Kty).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
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
            return this.Equals(input as SDKEphemPubKey);
        }

        /// <summary>
        /// Returns true if SDKEphemPubKey instances are equal
        /// </summary>
        /// <param name="input">Instance of SDKEphemPubKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SDKEphemPubKey input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Crv == input.Crv ||
                    (this.Crv != null &&
                    this.Crv.Equals(input.Crv))
                ) && 
                (
                    this.Kty == input.Kty ||
                    (this.Kty != null &&
                    this.Kty.Equals(input.Kty))
                ) && 
                (
                    this.X == input.X ||
                    (this.X != null &&
                    this.X.Equals(input.X))
                ) && 
                (
                    this.Y == input.Y ||
                    (this.Y != null &&
                    this.Y.Equals(input.Y))
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
                if (this.Crv != null)
                {
                    hashCode = (hashCode * 59) + this.Crv.GetHashCode();
                }
                if (this.Kty != null)
                {
                    hashCode = (hashCode * 59) + this.Kty.GetHashCode();
                }
                if (this.X != null)
                {
                    hashCode = (hashCode * 59) + this.X.GetHashCode();
                }
                if (this.Y != null)
                {
                    hashCode = (hashCode * 59) + this.Y.GetHashCode();
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
