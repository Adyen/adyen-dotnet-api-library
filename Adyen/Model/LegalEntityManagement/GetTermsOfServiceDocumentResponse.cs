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
    /// GetTermsOfServiceDocumentResponse
    /// </summary>
    [DataContract(Name = "GetTermsOfServiceDocumentResponse")]
    public partial class GetTermsOfServiceDocumentResponse : IEquatable<GetTermsOfServiceDocumentResponse>, IValidatableObject
    {
        /// <summary>
        /// The type of Terms of Service.
        /// </summary>
        /// <value>The type of Terms of Service.</value>
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
            /// Enum AdyenForPlatformsAdvanced for value: adyenForPlatformsAdvanced
            /// </summary>
            [EnumMember(Value = "adyenForPlatformsAdvanced")]
            AdyenForPlatformsAdvanced = 4,

            /// <summary>
            /// Enum AdyenForPlatformsManage for value: adyenForPlatformsManage
            /// </summary>
            [EnumMember(Value = "adyenForPlatformsManage")]
            AdyenForPlatformsManage = 5,

            /// <summary>
            /// Enum AdyenFranchisee for value: adyenFranchisee
            /// </summary>
            [EnumMember(Value = "adyenFranchisee")]
            AdyenFranchisee = 6,

            /// <summary>
            /// Enum AdyenIssuing for value: adyenIssuing
            /// </summary>
            [EnumMember(Value = "adyenIssuing")]
            AdyenIssuing = 7

        }


        /// <summary>
        /// The type of Terms of Service.
        /// </summary>
        /// <value>The type of Terms of Service.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTermsOfServiceDocumentResponse" /> class.
        /// </summary>
        /// <param name="document">The Terms of Service document in Base64-encoded format..</param>
        /// <param name="id">The unique identifier of the legal entity..</param>
        /// <param name="language">The language used for the Terms of Service document, specified by the two-letter [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language code. Possible value: **en** for English..</param>
        /// <param name="termsOfServiceDocumentId">The unique identifier of the Terms of Service document..</param>
        /// <param name="type">The type of Terms of Service..</param>
        public GetTermsOfServiceDocumentResponse(byte[] document = default(byte[]), string id = default(string), string language = default(string), string termsOfServiceDocumentId = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.Document = document;
            this.Id = id;
            this.Language = language;
            this.TermsOfServiceDocumentId = termsOfServiceDocumentId;
            this.Type = type;
        }

        /// <summary>
        /// The Terms of Service document in Base64-encoded format.
        /// </summary>
        /// <value>The Terms of Service document in Base64-encoded format.</value>
        [DataMember(Name = "document", EmitDefaultValue = false)]
        public byte[] Document { get; set; }

        /// <summary>
        /// The unique identifier of the legal entity.
        /// </summary>
        /// <value>The unique identifier of the legal entity.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The language used for the Terms of Service document, specified by the two-letter [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language code. Possible value: **en** for English.
        /// </summary>
        /// <value>The language used for the Terms of Service document, specified by the two-letter [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language code. Possible value: **en** for English.</value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public string Language { get; set; }

        /// <summary>
        /// The unique identifier of the Terms of Service document.
        /// </summary>
        /// <value>The unique identifier of the Terms of Service document.</value>
        [DataMember(Name = "termsOfServiceDocumentId", EmitDefaultValue = false)]
        public string TermsOfServiceDocumentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetTermsOfServiceDocumentResponse {\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  TermsOfServiceDocumentId: ").Append(TermsOfServiceDocumentId).Append("\n");
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
            return this.Equals(input as GetTermsOfServiceDocumentResponse);
        }

        /// <summary>
        /// Returns true if GetTermsOfServiceDocumentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTermsOfServiceDocumentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTermsOfServiceDocumentResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Document == input.Document ||
                    (this.Document != null &&
                    this.Document.Equals(input.Document))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.TermsOfServiceDocumentId == input.TermsOfServiceDocumentId ||
                    (this.TermsOfServiceDocumentId != null &&
                    this.TermsOfServiceDocumentId.Equals(input.TermsOfServiceDocumentId))
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
                if (this.Document != null)
                {
                    hashCode = (hashCode * 59) + this.Document.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Language != null)
                {
                    hashCode = (hashCode * 59) + this.Language.GetHashCode();
                }
                if (this.TermsOfServiceDocumentId != null)
                {
                    hashCode = (hashCode * 59) + this.TermsOfServiceDocumentId.GetHashCode();
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
