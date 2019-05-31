using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.EcommLibrary.Model.Checkout
{
    /// <summary>
    /// SDKEphemPubKey
    /// </summary>
    [DataContract]
    public partial class SDKEphemPubKey : IEquatable<SDKEphemPubKey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SDKEphemPubKey" /> class.
        /// </summary>
        /// <param name="Crv">The &#x60;crv&#x60; value as received from the 3D Secure 2.0 SDK..</param>
        /// <param name="Kty">The &#x60;kty&#x60; value as received from the 3D Secure 2.0 SDK..</param>
        /// <param name="X">The &#x60;x&#x60; value as received from the 3D Secure 2.0 SDK..</param>
        /// <param name="Y">The &#x60;y&#x60; value as received from the 3D Secure 2.0 SDK..</param>
        public SDKEphemPubKey(string Crv = default(string), string Kty = default(string), string X = default(string),
            string Y = default(string))
        {
            this.Crv = Crv;
            this.Kty = Kty;
            this.X = X;
            this.Y = Y;
        }

        /// <summary>
        /// The &#x60;crv&#x60; value as received from the 3D Secure 2.0 SDK.
        /// </summary>
        /// <value>The &#x60;crv&#x60; value as received from the 3D Secure 2.0 SDK.</value>
        [DataMember(Name = "crv", EmitDefaultValue = false)]
        public string Crv { get; set; }

        /// <summary>
        /// The &#x60;kty&#x60; value as received from the 3D Secure 2.0 SDK.
        /// </summary>
        /// <value>The &#x60;kty&#x60; value as received from the 3D Secure 2.0 SDK.</value>
        [DataMember(Name = "kty", EmitDefaultValue = false)]
        public string Kty { get; set; }

        /// <summary>
        /// The &#x60;x&#x60; value as received from the 3D Secure 2.0 SDK.
        /// </summary>
        /// <value>The &#x60;x&#x60; value as received from the 3D Secure 2.0 SDK.</value>
        [DataMember(Name = "x", EmitDefaultValue = false)]
        public string X { get; set; }

        /// <summary>
        /// The &#x60;y&#x60; value as received from the 3D Secure 2.0 SDK.
        /// </summary>
        /// <value>The &#x60;y&#x60; value as received from the 3D Secure 2.0 SDK.</value>
        [DataMember(Name = "y", EmitDefaultValue = false)]
        public string Y { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
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
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as SDKEphemPubKey);
        }

        /// <summary>
        /// Returns true if SDKEphemPubKey instances are equal
        /// </summary>
        /// <param name="input">Instance of SDKEphemPubKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SDKEphemPubKey input)
        {
            if (input == null)
                return false;

            return
                (
                    Crv == input.Crv ||
                    Crv != null &&
                    Crv.Equals(input.Crv)
                ) &&
                (
                    Kty == input.Kty ||
                    Kty != null &&
                    Kty.Equals(input.Kty)
                ) &&
                (
                    X == input.X ||
                    X != null &&
                    X.Equals(input.X)
                ) &&
                (
                    Y == input.Y ||
                    Y != null &&
                    Y.Equals(input.Y)
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
                var hashCode = 41;
                if (Crv != null)
                    hashCode = hashCode * 59 + Crv.GetHashCode();
                if (Kty != null)
                    hashCode = hashCode * 59 + Kty.GetHashCode();
                if (X != null)
                    hashCode = hashCode * 59 + X.GetHashCode();
                if (Y != null)
                    hashCode = hashCode * 59 + Y.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}