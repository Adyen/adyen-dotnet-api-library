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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Adyen.Util;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// CheckoutUtilityResponse
    /// </summary>
    [DataContract]
    public partial class CheckoutUtilityResponse : IEquatable<CheckoutUtilityResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutUtilityResponse" /> class.
        /// </summary>
        /// <param name="originKeys">The list of origin keys for all requested domains. For each list item, the key is the domain and the value is the origin key..</param>
        public CheckoutUtilityResponse(Dictionary<string, string> originKeys = default(Dictionary<string, string>))
        {
            this.OriginKeys = originKeys;
        }

        /// <summary>
        /// The list of origin keys for all requested domains. For each list item, the key is the domain and the value is the origin key.
        /// </summary>
        /// <value>The list of origin keys for all requested domains. For each list item, the key is the domain and the value is the origin key.</value>
        [DataMember(Name = "originKeys", EmitDefaultValue = false)]
        public Dictionary<string, string> OriginKeys { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckoutUtilityResponse {\n");
            sb.Append("  OriginKeys: ").Append(OriginKeys.ToCollectionsString()).Append("\n");
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
            return this.Equals(input as CheckoutUtilityResponse);
        }

        /// <summary>
        /// Returns true if CheckoutUtilityResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckoutUtilityResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckoutUtilityResponse input)
        {
            if (input == null)
                return false;

            return
                this.OriginKeys == input.OriginKeys ||
                this.OriginKeys != null &&
                input.OriginKeys != null &&
                this.OriginKeys.SequenceEqual(input.OriginKeys);
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
                if (this.OriginKeys != null)
                    hashCode = hashCode * 59 + this.OriginKeys.GetHashCode();
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