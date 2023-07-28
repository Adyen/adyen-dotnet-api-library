/*
* Legal Entity Management API
*
*
* The version of the OpenAPI document: 3
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
    /// PciSigningRequest
    /// </summary>
    [DataContract(Name = "PciSigningRequest")]
    public partial class PciSigningRequest : IEquatable<PciSigningRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PciSigningRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PciSigningRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PciSigningRequest" /> class.
        /// </summary>
        /// <param name="pciTemplateReferences">The array of Adyen-generated unique identifiers for the questionnaires. (required).</param>
        /// <param name="signedBy">The [legal entity ID](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/legalEntities__resParam_id) of the individual who signs the PCI questionnaire. (required).</param>
        public PciSigningRequest(List<string> pciTemplateReferences = default(List<string>), string signedBy = default(string))
        {
            this.PciTemplateReferences = pciTemplateReferences;
            this.SignedBy = signedBy;
        }

        /// <summary>
        /// The array of Adyen-generated unique identifiers for the questionnaires.
        /// </summary>
        /// <value>The array of Adyen-generated unique identifiers for the questionnaires.</value>
        [DataMember(Name = "pciTemplateReferences", IsRequired = false, EmitDefaultValue = false)]
        public List<string> PciTemplateReferences { get; set; }

        /// <summary>
        /// The [legal entity ID](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/legalEntities__resParam_id) of the individual who signs the PCI questionnaire.
        /// </summary>
        /// <value>The [legal entity ID](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/legalEntities__resParam_id) of the individual who signs the PCI questionnaire.</value>
        [DataMember(Name = "signedBy", IsRequired = false, EmitDefaultValue = false)]
        public string SignedBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PciSigningRequest {\n");
            sb.Append("  PciTemplateReferences: ").Append(PciTemplateReferences).Append("\n");
            sb.Append("  SignedBy: ").Append(SignedBy).Append("\n");
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
            return this.Equals(input as PciSigningRequest);
        }

        /// <summary>
        /// Returns true if PciSigningRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PciSigningRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PciSigningRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PciTemplateReferences == input.PciTemplateReferences ||
                    this.PciTemplateReferences != null &&
                    input.PciTemplateReferences != null &&
                    this.PciTemplateReferences.SequenceEqual(input.PciTemplateReferences)
                ) && 
                (
                    this.SignedBy == input.SignedBy ||
                    (this.SignedBy != null &&
                    this.SignedBy.Equals(input.SignedBy))
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
                if (this.PciTemplateReferences != null)
                {
                    hashCode = (hashCode * 59) + this.PciTemplateReferences.GetHashCode();
                }
                if (this.SignedBy != null)
                {
                    hashCode = (hashCode * 59) + this.SignedBy.GetHashCode();
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
