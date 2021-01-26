#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// SDKEphemPubKey
    /// </summary>
    [DataContract]
    public partial class SDKEphemPubKey :  IEquatable<SDKEphemPubKey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SDKEphemPubKey" /> class.
        /// </summary>
        /// <param name="Crv">The &#x60;crv&#x60; value as received from the 3D Secure 2.0 SDK..</param>
        /// <param name="Kty">The &#x60;kty&#x60; value as received from the 3D Secure 2.0 SDK..</param>
        /// <param name="X">The &#x60;x&#x60; value as received from the 3D Secure 2.0 SDK..</param>
        /// <param name="Y">The &#x60;y&#x60; value as received from the 3D Secure 2.0 SDK..</param>
        public SDKEphemPubKey(string Crv = default(string), string Kty = default(string), string X = default(string), string Y = default(string))
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
        [DataMember(Name="crv", EmitDefaultValue=false)]
        public string Crv { get; set; }

        /// <summary>
        /// The &#x60;kty&#x60; value as received from the 3D Secure 2.0 SDK.
        /// </summary>
        /// <value>The &#x60;kty&#x60; value as received from the 3D Secure 2.0 SDK.</value>
        [DataMember(Name="kty", EmitDefaultValue=false)]
        public string Kty { get; set; }

        /// <summary>
        /// The &#x60;x&#x60; value as received from the 3D Secure 2.0 SDK.
        /// </summary>
        /// <value>The &#x60;x&#x60; value as received from the 3D Secure 2.0 SDK.</value>
        [DataMember(Name="x", EmitDefaultValue=false)]
        public string X { get; set; }

        /// <summary>
        /// The &#x60;y&#x60; value as received from the 3D Secure 2.0 SDK.
        /// </summary>
        /// <value>The &#x60;y&#x60; value as received from the 3D Secure 2.0 SDK.</value>
        [DataMember(Name="y", EmitDefaultValue=false)]
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
                return false;

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
                    hashCode = hashCode * 59 + this.Crv.GetHashCode();
                if (this.Kty != null)
                    hashCode = hashCode * 59 + this.Kty.GetHashCode();
                if (this.X != null)
                    hashCode = hashCode * 59 + this.X.GetHashCode();
                if (this.Y != null)
                    hashCode = hashCode * 59 + this.Y.GetHashCode();
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
