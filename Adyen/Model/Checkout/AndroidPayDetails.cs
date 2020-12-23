#region Licence

// 
//                        ######
//                        ######
//  ############    ####( ######  #####. ######  ############   ############
//  #############  #####( ######  #####. ######  #############  #############
//         ######  #####( ######  #####. ######  #####  ######  #####  ######
//  ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  ###### ######  #####( ######  #####. ######  #####          #####  ######
//  #############  #############  #############  #############  #####  ######
//   ############   ############  #############   ############  #####  ######
//                                       ######
//                                #############
//                                ############
// 
//  Adyen Dotnet API Library
// 
//  Copyright (c) 2020 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.

#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// AndroidPayDetails
    /// </summary>
    [DataContract]
    public partial class AndroidPayDetails : IEquatable<AndroidPayDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AndroidPayDetails" /> class.
        /// </summary>
        /// <param name="androidPayToken">androidPayToken (required).</param>
        /// <param name="type">**androidpay** (default to &quot;androidpay&quot;).</param>
        public AndroidPayDetails(string androidPayToken = default(string), string type = "androidpay")
        {
            // to ensure "androidPayToken" is required (not null)
            if (androidPayToken == null)
            {
                throw new InvalidDataException(
                    "androidPayToken is a required property for AndroidPayDetails and cannot be null");
            }
            else
            {
                this.AndroidPayToken = androidPayToken;
            }
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "androidpay";
            }
            else
            {
                this.Type = type;
            }
        }

        /// <summary>
        /// Gets or Sets AndroidPayToken
        /// </summary>
        [DataMember(Name = "androidPayToken", EmitDefaultValue = false)]
        public string AndroidPayToken { get; set; }

        /// <summary>
        /// **androidpay**
        /// </summary>
        /// <value>**androidpay**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AndroidPayDetails {\n");
            sb.Append("  AndroidPayToken: ").Append(AndroidPayToken).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as AndroidPayDetails);
        }

        /// <summary>
        /// Returns true if AndroidPayDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of AndroidPayDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AndroidPayDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AndroidPayToken == input.AndroidPayToken ||
                    this.AndroidPayToken != null &&
                    this.AndroidPayToken.Equals(input.AndroidPayToken)
                ) &&
                (
                    this.Type == input.Type ||
                    this.Type != null &&
                    this.Type.Equals(input.Type)
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
                if (this.AndroidPayToken != null)
                    hashCode = hashCode * 59 + this.AndroidPayToken.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(
            ValidationContext validationContext)
        {
            yield break;
        }
    }
}