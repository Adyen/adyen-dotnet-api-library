/*
* Legal Entity Management API
*
*
* The version of the OpenAPI document: 3
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

namespace Adyen.Model.LegalEntityManagement
{
    /// <summary>
    /// PciDocumentInfo
    /// </summary>
    [DataContract(Name = "PciDocumentInfo")]
    public partial class PciDocumentInfo : IEquatable<PciDocumentInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PciDocumentInfo" /> class.
        /// </summary>
        /// <param name="createdAt">The date the questionnaire was created, in ISO 8601 extended format. For example, 2022-12-18T10:15:30+01:00.</param>
        /// <param name="id">The unique identifier of the signed questionnaire..</param>
        /// <param name="validUntil">The expiration date of the questionnaire, in ISO 8601 extended format. For example, 2022-12-18T10:15:30+01:00.</param>
        public PciDocumentInfo(DateTime createdAt = default(DateTime), string id = default(string), DateTime validUntil = default(DateTime))
        {
            this.CreatedAt = createdAt;
            this.Id = id;
            this.ValidUntil = validUntil;
        }

        /// <summary>
        /// The date the questionnaire was created, in ISO 8601 extended format. For example, 2022-12-18T10:15:30+01:00
        /// </summary>
        /// <value>The date the questionnaire was created, in ISO 8601 extended format. For example, 2022-12-18T10:15:30+01:00</value>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The unique identifier of the signed questionnaire.
        /// </summary>
        /// <value>The unique identifier of the signed questionnaire.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The expiration date of the questionnaire, in ISO 8601 extended format. For example, 2022-12-18T10:15:30+01:00
        /// </summary>
        /// <value>The expiration date of the questionnaire, in ISO 8601 extended format. For example, 2022-12-18T10:15:30+01:00</value>
        [DataMember(Name = "validUntil", EmitDefaultValue = false)]
        public DateTime ValidUntil { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PciDocumentInfo {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ValidUntil: ").Append(ValidUntil).Append("\n");
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
            return this.Equals(input as PciDocumentInfo);
        }

        /// <summary>
        /// Returns true if PciDocumentInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PciDocumentInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PciDocumentInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ValidUntil == input.ValidUntil ||
                    (this.ValidUntil != null &&
                    this.ValidUntil.Equals(input.ValidUntil))
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
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.ValidUntil != null)
                {
                    hashCode = (hashCode * 59) + this.ValidUntil.GetHashCode();
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