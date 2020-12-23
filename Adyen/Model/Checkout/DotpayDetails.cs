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
    /// DotpayDetails
    /// </summary>
    [DataContract]
    public partial class DotpayDetails : IEquatable<DotpayDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DotpayDetails" /> class.
        /// </summary>
        /// <param name="issuer">The Dotpay issuer value of the shopper&#x27;s selected bank. Set this to an **id** of a Dotpay issuer to preselect it. (required).</param>
        /// <param name="type">**dotpay** (default to &quot;dotpay&quot;).</param>
        public DotpayDetails(string issuer = default(string), string type = "dotpay")
        {
            // to ensure "issuer" is required (not null)
            if (issuer == null)
            {
                throw new InvalidDataException("issuer is a required property for DotpayDetails and cannot be null");
            }
            else
            {
                this.Issuer = issuer;
            }
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "dotpay";
            }
            else
            {
                this.Type = type;
            }
        }

        /// <summary>
        /// The Dotpay issuer value of the shopper&#x27;s selected bank. Set this to an **id** of a Dotpay issuer to preselect it.
        /// </summary>
        /// <value>The Dotpay issuer value of the shopper&#x27;s selected bank. Set this to an **id** of a Dotpay issuer to preselect it.</value>
        [DataMember(Name = "issuer", EmitDefaultValue = false)]
        public string Issuer { get; set; }

        /// <summary>
        /// **dotpay**
        /// </summary>
        /// <value>**dotpay**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DotpayDetails {\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
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
            return this.Equals(input as DotpayDetails);
        }

        /// <summary>
        /// Returns true if DotpayDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of DotpayDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DotpayDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Issuer == input.Issuer ||
                    this.Issuer != null &&
                    this.Issuer.Equals(input.Issuer)
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
                if (this.Issuer != null)
                    hashCode = hashCode * 59 + this.Issuer.GetHashCode();
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