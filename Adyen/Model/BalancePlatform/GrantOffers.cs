/*
* Configuration API
*
*
* The version of the OpenAPI document: 2
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

namespace Adyen.Model.BalancePlatform
{
    /// <summary>
    /// GrantOffers
    /// </summary>
    [DataContract(Name = "GrantOffers")]
    public partial class GrantOffers : IEquatable<GrantOffers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GrantOffers" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GrantOffers() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GrantOffers" /> class.
        /// </summary>
        /// <param name="grantOffers">A list of available grant offers. (required).</param>
        public GrantOffers(List<GrantOffer> grantOffers = default(List<GrantOffer>))
        {
            this._GrantOffers = grantOffers;
        }

        /// <summary>
        /// A list of available grant offers.
        /// </summary>
        /// <value>A list of available grant offers.</value>
        [DataMember(Name = "grantOffers", IsRequired = false, EmitDefaultValue = false)]
        public List<GrantOffer> _GrantOffers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GrantOffers {\n");
            sb.Append("  _GrantOffers: ").Append(_GrantOffers).Append("\n");
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
            return this.Equals(input as GrantOffers);
        }

        /// <summary>
        /// Returns true if GrantOffers instances are equal
        /// </summary>
        /// <param name="input">Instance of GrantOffers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GrantOffers input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this._GrantOffers == input._GrantOffers ||
                    this._GrantOffers != null &&
                    input._GrantOffers != null &&
                    this._GrantOffers.SequenceEqual(input._GrantOffers)
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
                if (this._GrantOffers != null)
                {
                    hashCode = (hashCode * 59) + this._GrantOffers.GetHashCode();
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