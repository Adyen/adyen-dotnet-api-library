/*
* Adyen Terminal API
*
*
* The version of the OpenAPI document: 1
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

namespace Adyen.Model.Terminal
{
    /// <summary>
    /// ICCResetData
    /// </summary>
    [DataContract(Name = "ICCResetData")]
    public partial class ICCResetData : IEquatable<ICCResetData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ICCResetData" /> class.
        /// </summary>
        /// <param name="aTRValue">aTRValue.</param>
        /// <param name="cardStatusWords">cardStatusWords.</param>
        public ICCResetData(byte[] aTRValue = default(byte[]), byte[] cardStatusWords = default(byte[]))
        {
            this.ATRValue = aTRValue;
            this.CardStatusWords = cardStatusWords;
        }

        /// <summary>
        /// Gets or Sets ATRValue
        /// </summary>
        [DataMember(Name = "ATRValue", EmitDefaultValue = false)]
        public byte[] ATRValue { get; set; }

        /// <summary>
        /// Gets or Sets CardStatusWords
        /// </summary>
        [DataMember(Name = "CardStatusWords", EmitDefaultValue = false)]
        public byte[] CardStatusWords { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ICCResetData {\n");
            sb.Append("  ATRValue: ").Append(ATRValue).Append("\n");
            sb.Append("  CardStatusWords: ").Append(CardStatusWords).Append("\n");
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
            return this.Equals(input as ICCResetData);
        }

        /// <summary>
        /// Returns true if ICCResetData instances are equal
        /// </summary>
        /// <param name="input">Instance of ICCResetData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ICCResetData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ATRValue == input.ATRValue ||
                    (this.ATRValue != null &&
                    this.ATRValue.Equals(input.ATRValue))
                ) && 
                (
                    this.CardStatusWords == input.CardStatusWords ||
                    (this.CardStatusWords != null &&
                    this.CardStatusWords.Equals(input.CardStatusWords))
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
                if (this.ATRValue != null)
                {
                    hashCode = (hashCode * 59) + this.ATRValue.GetHashCode();
                }
                if (this.CardStatusWords != null)
                {
                    hashCode = (hashCode * 59) + this.CardStatusWords.GetHashCode();
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
