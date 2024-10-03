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
    /// GetTermsOfServiceDocumentRequest
    /// </summary>
    [DataContract(Name = "GetTermsOfServiceDocumentRequest")]
    public partial class GetTermsOfServiceDocumentRequest : IEquatable<GetTermsOfServiceDocumentRequest>, IValidatableObject
    {
        /// <summary>
        /// The type of Terms of Service.  Possible values: *  **adyenForPlatformsManage** *  **adyenIssuing** *  **adyenForPlatformsAdvanced** *  **adyenCapital** *  **adyenAccount** *  **adyenCard** *  **adyenFranchisee** *  **adyenPccr** *  **adyenChargeCard**  
        /// </summary>
        /// <value>The type of Terms of Service.  Possible values: *  **adyenForPlatformsManage** *  **adyenIssuing** *  **adyenForPlatformsAdvanced** *  **adyenCapital** *  **adyenAccount** *  **adyenCard** *  **adyenFranchisee** *  **adyenPccr** *  **adyenChargeCard**  </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum AdyenAccount for value: adyenAccount
            /// </summary>
            [EnumMember(Value = "adyenAccount")]
            AdyenAccount = 1,

            /// <summary>
            /// Enum AdyenCapital for value: adyenCapital
            /// </summary>
            [EnumMember(Value = "adyenCapital")]
            AdyenCapital = 2,

            /// <summary>
            /// Enum AdyenCard for value: adyenCard
            /// </summary>
            [EnumMember(Value = "adyenCard")]
            AdyenCard = 3,

            /// <summary>
            /// Enum AdyenChargeCard for value: adyenChargeCard
            /// </summary>
            [EnumMember(Value = "adyenChargeCard")]
            AdyenChargeCard = 4,

            /// <summary>
            /// Enum AdyenForPlatformsAdvanced for value: adyenForPlatformsAdvanced
            /// </summary>
            [EnumMember(Value = "adyenForPlatformsAdvanced")]
            AdyenForPlatformsAdvanced = 5,

            /// <summary>
            /// Enum AdyenForPlatformsManage for value: adyenForPlatformsManage
            /// </summary>
            [EnumMember(Value = "adyenForPlatformsManage")]
            AdyenForPlatformsManage = 6,

            /// <summary>
            /// Enum AdyenFranchisee for value: adyenFranchisee
            /// </summary>
            [EnumMember(Value = "adyenFranchisee")]
            AdyenFranchisee = 7,

            /// <summary>
            /// Enum AdyenIssuing for value: adyenIssuing
            /// </summary>
            [EnumMember(Value = "adyenIssuing")]
            AdyenIssuing = 8,

            /// <summary>
            /// Enum AdyenPccr for value: adyenPccr
            /// </summary>
            [EnumMember(Value = "adyenPccr")]
            AdyenPccr = 9

        }


        /// <summary>
        /// The type of Terms of Service.  Possible values: *  **adyenForPlatformsManage** *  **adyenIssuing** *  **adyenForPlatformsAdvanced** *  **adyenCapital** *  **adyenAccount** *  **adyenCard** *  **adyenFranchisee** *  **adyenPccr** *  **adyenChargeCard**  
        /// </summary>
        /// <value>The type of Terms of Service.  Possible values: *  **adyenForPlatformsManage** *  **adyenIssuing** *  **adyenForPlatformsAdvanced** *  **adyenCapital** *  **adyenAccount** *  **adyenCard** *  **adyenFranchisee** *  **adyenPccr** *  **adyenChargeCard**  </value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTermsOfServiceDocumentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetTermsOfServiceDocumentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTermsOfServiceDocumentRequest" /> class.
        /// </summary>
        /// <param name="language">The language to be used for the Terms of Service document, specified by the two-letter [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language code. Possible value: **en** for English. (required).</param>
        /// <param name="termsOfServiceDocumentFormat">The requested format for the Terms of Service document. Default value: JSON. Possible values: **JSON**, **PDF**, or **TXT**..</param>
        /// <param name="type">The type of Terms of Service.  Possible values: *  **adyenForPlatformsManage** *  **adyenIssuing** *  **adyenForPlatformsAdvanced** *  **adyenCapital** *  **adyenAccount** *  **adyenCard** *  **adyenFranchisee** *  **adyenPccr** *  **adyenChargeCard**   (required).</param>
        public GetTermsOfServiceDocumentRequest(string language = default(string), string termsOfServiceDocumentFormat = default(string), TypeEnum type = default(TypeEnum))
        {
            this.Language = language;
            this.Type = type;
            this.TermsOfServiceDocumentFormat = termsOfServiceDocumentFormat;
        }

        /// <summary>
        /// The language to be used for the Terms of Service document, specified by the two-letter [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language code. Possible value: **en** for English.
        /// </summary>
        /// <value>The language to be used for the Terms of Service document, specified by the two-letter [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language code. Possible value: **en** for English.</value>
        [DataMember(Name = "language", IsRequired = false, EmitDefaultValue = false)]
        public string Language { get; set; }

        /// <summary>
        /// The requested format for the Terms of Service document. Default value: JSON. Possible values: **JSON**, **PDF**, or **TXT**.
        /// </summary>
        /// <value>The requested format for the Terms of Service document. Default value: JSON. Possible values: **JSON**, **PDF**, or **TXT**.</value>
        [DataMember(Name = "termsOfServiceDocumentFormat", EmitDefaultValue = false)]
        public string TermsOfServiceDocumentFormat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetTermsOfServiceDocumentRequest {\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  TermsOfServiceDocumentFormat: ").Append(TermsOfServiceDocumentFormat).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as GetTermsOfServiceDocumentRequest);
        }

        /// <summary>
        /// Returns true if GetTermsOfServiceDocumentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTermsOfServiceDocumentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTermsOfServiceDocumentRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.TermsOfServiceDocumentFormat == input.TermsOfServiceDocumentFormat ||
                    (this.TermsOfServiceDocumentFormat != null &&
                    this.TermsOfServiceDocumentFormat.Equals(input.TermsOfServiceDocumentFormat))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.Language != null)
                {
                    hashCode = (hashCode * 59) + this.Language.GetHashCode();
                }
                if (this.TermsOfServiceDocumentFormat != null)
                {
                    hashCode = (hashCode * 59) + this.TermsOfServiceDocumentFormat.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
