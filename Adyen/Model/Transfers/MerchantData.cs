/*
* Transfers API
*
*
* The version of the OpenAPI document: 4
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

namespace Adyen.Model.Transfers
{
    /// <summary>
    /// MerchantData
    /// </summary>
    [DataContract(Name = "MerchantData")]
    public partial class MerchantData : IEquatable<MerchantData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantData" /> class.
        /// </summary>
        /// <param name="mcc">The merchant category code..</param>
        /// <param name="merchantId">The merchant identifier..</param>
        /// <param name="nameLocation">nameLocation.</param>
        /// <param name="postalCode">The merchant postal code..</param>
        public MerchantData(string mcc = default(string), string merchantId = default(string), NameLocation nameLocation = default(NameLocation), string postalCode = default(string))
        {
            this.Mcc = mcc;
            this.MerchantId = merchantId;
            this.NameLocation = nameLocation;
            this.PostalCode = postalCode;
        }

        /// <summary>
        /// The merchant category code.
        /// </summary>
        /// <value>The merchant category code.</value>
        [DataMember(Name = "mcc", EmitDefaultValue = false)]
        public string Mcc { get; set; }

        /// <summary>
        /// The merchant identifier.
        /// </summary>
        /// <value>The merchant identifier.</value>
        [DataMember(Name = "merchantId", EmitDefaultValue = false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// Gets or Sets NameLocation
        /// </summary>
        [DataMember(Name = "nameLocation", EmitDefaultValue = false)]
        public NameLocation NameLocation { get; set; }

        /// <summary>
        /// The merchant postal code.
        /// </summary>
        /// <value>The merchant postal code.</value>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MerchantData {\n");
            sb.Append("  Mcc: ").Append(Mcc).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  NameLocation: ").Append(NameLocation).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
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
            return this.Equals(input as MerchantData);
        }

        /// <summary>
        /// Returns true if MerchantData instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Mcc == input.Mcc ||
                    (this.Mcc != null &&
                    this.Mcc.Equals(input.Mcc))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.NameLocation == input.NameLocation ||
                    (this.NameLocation != null &&
                    this.NameLocation.Equals(input.NameLocation))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
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
                if (this.Mcc != null)
                {
                    hashCode = (hashCode * 59) + this.Mcc.GetHashCode();
                }
                if (this.MerchantId != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantId.GetHashCode();
                }
                if (this.NameLocation != null)
                {
                    hashCode = (hashCode * 59) + this.NameLocation.GetHashCode();
                }
                if (this.PostalCode != null)
                {
                    hashCode = (hashCode * 59) + this.PostalCode.GetHashCode();
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
