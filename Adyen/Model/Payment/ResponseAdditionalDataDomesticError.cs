/*
* Adyen Payment API
*
*
* The version of the OpenAPI document: 68
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

namespace Adyen.Model.Payment
{
    /// <summary>
    /// ResponseAdditionalDataDomesticError
    /// </summary>
    [DataContract(Name = "ResponseAdditionalDataDomesticError")]
    public partial class ResponseAdditionalDataDomesticError : IEquatable<ResponseAdditionalDataDomesticError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAdditionalDataDomesticError" /> class.
        /// </summary>
        /// <param name="domesticRefusalReasonRaw">The reason the transaction was declined, given by the local issuer.  Currently available for merchants in Japan..</param>
        /// <param name="domesticShopperAdvice">The action the shopper should take, in a local language.  Currently available in Japanese, for merchants in Japan..</param>
        public ResponseAdditionalDataDomesticError(string domesticRefusalReasonRaw = default(string), string domesticShopperAdvice = default(string))
        {
            this.DomesticRefusalReasonRaw = domesticRefusalReasonRaw;
            this.DomesticShopperAdvice = domesticShopperAdvice;
        }

        /// <summary>
        /// The reason the transaction was declined, given by the local issuer.  Currently available for merchants in Japan.
        /// </summary>
        /// <value>The reason the transaction was declined, given by the local issuer.  Currently available for merchants in Japan.</value>
        [DataMember(Name = "domesticRefusalReasonRaw", EmitDefaultValue = false)]
        public string DomesticRefusalReasonRaw { get; set; }

        /// <summary>
        /// The action the shopper should take, in a local language.  Currently available in Japanese, for merchants in Japan.
        /// </summary>
        /// <value>The action the shopper should take, in a local language.  Currently available in Japanese, for merchants in Japan.</value>
        [DataMember(Name = "domesticShopperAdvice", EmitDefaultValue = false)]
        public string DomesticShopperAdvice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResponseAdditionalDataDomesticError {\n");
            sb.Append("  DomesticRefusalReasonRaw: ").Append(DomesticRefusalReasonRaw).Append("\n");
            sb.Append("  DomesticShopperAdvice: ").Append(DomesticShopperAdvice).Append("\n");
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
        /// Returns the ResponseAdditionalDataDomesticError object from the json payload
        /// </summary>
        /// <returns>ResponseAdditionalDataDomesticError</returns>
        public static ResponseAdditionalDataDomesticError FromJson(string json)
        {
            return JsonConvert.DeserializeObject<ResponseAdditionalDataDomesticError>(json);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResponseAdditionalDataDomesticError);
        }

        /// <summary>
        /// Returns true if ResponseAdditionalDataDomesticError instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponseAdditionalDataDomesticError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseAdditionalDataDomesticError input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DomesticRefusalReasonRaw == input.DomesticRefusalReasonRaw ||
                    (this.DomesticRefusalReasonRaw != null &&
                    this.DomesticRefusalReasonRaw.Equals(input.DomesticRefusalReasonRaw))
                ) && 
                (
                    this.DomesticShopperAdvice == input.DomesticShopperAdvice ||
                    (this.DomesticShopperAdvice != null &&
                    this.DomesticShopperAdvice.Equals(input.DomesticShopperAdvice))
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
                if (this.DomesticRefusalReasonRaw != null)
                {
                    hashCode = (hashCode * 59) + this.DomesticRefusalReasonRaw.GetHashCode();
                }
                if (this.DomesticShopperAdvice != null)
                {
                    hashCode = (hashCode * 59) + this.DomesticShopperAdvice.GetHashCode();
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
