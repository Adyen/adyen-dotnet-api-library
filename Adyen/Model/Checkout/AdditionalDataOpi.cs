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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// AdditionalDataOpi
    /// </summary>
    [DataContract]
    public partial class AdditionalDataOpi : IEquatable<AdditionalDataOpi>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataOpi" /> class.
        /// </summary>
        /// <param name="opiIncludeTransToken">Optional boolean indicator. Set to **true** if you want an ecommerce transaction to return an &#x60;opi.transToken&#x60; as additional data in the response.  You can store this Oracle Payment Interface token in your Oracle Opera database. For more information and required settings, see [Oracle Opera](https://docs.adyen.com/plugins/oracle-opera#opi-token-ecommerce)..</param>
        public AdditionalDataOpi(string opiIncludeTransToken = default(string))
        {
            this.OpiIncludeTransToken = opiIncludeTransToken;
        }

        /// <summary>
        /// Optional boolean indicator. Set to **true** if you want an ecommerce transaction to return an &#x60;opi.transToken&#x60; as additional data in the response.  You can store this Oracle Payment Interface token in your Oracle Opera database. For more information and required settings, see [Oracle Opera](https://docs.adyen.com/plugins/oracle-opera#opi-token-ecommerce).
        /// </summary>
        /// <value>Optional boolean indicator. Set to **true** if you want an ecommerce transaction to return an &#x60;opi.transToken&#x60; as additional data in the response.  You can store this Oracle Payment Interface token in your Oracle Opera database. For more information and required settings, see [Oracle Opera](https://docs.adyen.com/plugins/oracle-opera#opi-token-ecommerce).</value>
        [DataMember(Name = "opi.includeTransToken", EmitDefaultValue = false)]
        public string OpiIncludeTransToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalDataOpi {\n");
            sb.Append("  OpiIncludeTransToken: ").Append(OpiIncludeTransToken).Append("\n");
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
            return this.Equals(input as AdditionalDataOpi);
        }

        /// <summary>
        /// Returns true if AdditionalDataOpi instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalDataOpi to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalDataOpi input)
        {
            if (input == null)
                return false;

            return
                this.OpiIncludeTransToken == input.OpiIncludeTransToken ||
                this.OpiIncludeTransToken != null &&
                this.OpiIncludeTransToken.Equals(input.OpiIncludeTransToken);
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
                if (this.OpiIncludeTransToken != null)
                    hashCode = hashCode * 59 + this.OpiIncludeTransToken.GetHashCode();
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