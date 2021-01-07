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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Adyen.Util;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// CheckoutUtilityRequest
    /// </summary>
    [DataContract]
    public partial class CheckoutUtilityRequest : IEquatable<CheckoutUtilityRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutUtilityRequest" /> class.
        /// </summary>
        /// <param name="originDomains">The list of origin domains, for which origin keys are requested. (required).</param>
        public CheckoutUtilityRequest(List<string> originDomains = default(List<string>))
        {
            // to ensure "originDomains" is required (not null)
            if (originDomains == null)
            {
                throw new InvalidDataException(
                    "originDomains is a required property for CheckoutUtilityRequest and cannot be null");
            }
            else
            {
                this.OriginDomains = originDomains;
            }
        }

        /// <summary>
        /// The list of origin domains, for which origin keys are requested.
        /// </summary>
        /// <value>The list of origin domains, for which origin keys are requested.</value>
        [DataMember(Name = "originDomains", EmitDefaultValue = false)]
        public List<string> OriginDomains { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckoutUtilityRequest {\n");
            sb.Append("  OriginDomains: ").Append(OriginDomains.ToListString()).Append("\n");
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
            return this.Equals(input as CheckoutUtilityRequest);
        }

        /// <summary>
        /// Returns true if CheckoutUtilityRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckoutUtilityRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckoutUtilityRequest input)
        {
            if (input == null)
                return false;

            return
                this.OriginDomains == input.OriginDomains ||
                this.OriginDomains != null &&
                input.OriginDomains != null &&
                this.OriginDomains.SequenceEqual(input.OriginDomains);
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
                if (this.OriginDomains != null)
                    hashCode = hashCode * 59 + this.OriginDomains.GetHashCode();
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