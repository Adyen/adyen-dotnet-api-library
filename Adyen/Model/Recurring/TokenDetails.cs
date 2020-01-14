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
//  * Copyright (c) 2019 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Recurring
{
    /// <summary>
    /// TokenDetails
    /// </summary>
    [DataContract]
    public partial class TokenDetails :  IEquatable<TokenDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenDetails" /> class.
        /// </summary>
        /// <param name="TokenData">TokenData.</param>
        /// <param name="TokenDataType">TokenDataType.</param>
        public TokenDetails(Dictionary<string, string> TokenData = default(Dictionary<string, string>), string TokenDataType = default(string))
        {
            this.TokenData = TokenData;
            this.TokenDataType = TokenDataType;
        }
        
        /// <summary>
        /// Gets or Sets TokenData
        /// </summary>
        [DataMember(Name="tokenData", EmitDefaultValue=false)]
        public Dictionary<string, string> TokenData { get; set; }

        /// <summary>
        /// Gets or Sets TokenDataType
        /// </summary>
        [DataMember(Name="tokenDataType", EmitDefaultValue=false)]
        public string TokenDataType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenDetails {\n");
            sb.Append("  TokenData: ").Append(TokenData).Append("\n");
            sb.Append("  TokenDataType: ").Append(TokenDataType).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as TokenDetails);
        }

        /// <summary>
        /// Returns true if TokenDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of TokenDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TokenData == other.TokenData ||
                    this.TokenData != null &&
                    this.TokenData.SequenceEqual(other.TokenData)
                ) && 
                (
                    this.TokenDataType == other.TokenDataType ||
                    this.TokenDataType != null &&
                    this.TokenDataType.Equals(other.TokenDataType)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.TokenData != null)
                    hash = hash * 59 + this.TokenData.GetHashCode();
                if (this.TokenDataType != null)
                    hash = hash * 59 + this.TokenDataType.GetHashCode();
                return hash;
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
