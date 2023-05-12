using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// GetUploadedDocumentsResponse
    /// </summary>
    [DataContract]
        public class GetUploadedDocumentsResponse :  IEquatable<GetUploadedDocumentsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUploadedDocumentsResponse" /> class.
        /// </summary>
        /// <param name="documentDetails">A list of the documents and their details..</param>
        /// <param name="invalidFields">Contains field validation errors that would prevent requests from being processed..</param>
        /// <param name="pspReference">The reference of a request.  Can be used to uniquely identify the request. (required).</param>
        /// <param name="resultCode">The result code..</param>
        public GetUploadedDocumentsResponse(List<DocumentDetail> documentDetails = default(List<DocumentDetail>), List<ErrorFieldType> invalidFields = default(List<ErrorFieldType>), string pspReference = default(string), string resultCode = default(string))
        {
            // to ensure "pspReference" is required (not null)
            if (pspReference == null)
            {
                throw new InvalidDataException("pspReference is a required property for GetUploadedDocumentsResponse and cannot be null");
            }

            PspReference = pspReference;
            DocumentDetails = documentDetails;
            InvalidFields = invalidFields;
            ResultCode = resultCode;
        }
        
        /// <summary>
        /// A list of the documents and their details.
        /// </summary>
        /// <value>A list of the documents and their details.</value>
        [DataMember(Name="documentDetails", EmitDefaultValue=false)]
        public List<DocumentDetail> DocumentDetails { get; set; }

        /// <summary>
        /// Contains field validation errors that would prevent requests from being processed.
        /// </summary>
        /// <value>Contains field validation errors that would prevent requests from being processed.</value>
        [DataMember(Name="invalidFields", EmitDefaultValue=false)]
        public List<ErrorFieldType> InvalidFields { get; set; }

        /// <summary>
        /// The reference of a request.  Can be used to uniquely identify the request.
        /// </summary>
        /// <value>The reference of a request.  Can be used to uniquely identify the request.</value>
        [DataMember(Name="pspReference", EmitDefaultValue=false)]
        public string PspReference { get; set; }

        /// <summary>
        /// The result code.
        /// </summary>
        /// <value>The result code.</value>
        [DataMember(Name="resultCode", EmitDefaultValue=false)]
        public string ResultCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetUploadedDocumentsResponse {\n");
            sb.Append("  DocumentDetails: ").Append(DocumentDetails).Append("\n");
            sb.Append("  InvalidFields: ").Append(InvalidFields).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
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
            return Equals(input as GetUploadedDocumentsResponse);
        }

        /// <summary>
        /// Returns true if GetUploadedDocumentsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetUploadedDocumentsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetUploadedDocumentsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    DocumentDetails == input.DocumentDetails ||
                    DocumentDetails != null &&
                    input.DocumentDetails != null &&
                    DocumentDetails.SequenceEqual(input.DocumentDetails)
                ) && 
                (
                    InvalidFields == input.InvalidFields ||
                    InvalidFields != null &&
                    input.InvalidFields != null &&
                    InvalidFields.SequenceEqual(input.InvalidFields)
                ) && 
                (
                    PspReference == input.PspReference ||
                    (PspReference != null &&
                    PspReference.Equals(input.PspReference))
                ) && 
                (
                    ResultCode == input.ResultCode ||
                    (ResultCode != null &&
                    ResultCode.Equals(input.ResultCode))
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
                if (DocumentDetails != null)
                    hashCode = hashCode * 59 + DocumentDetails.GetHashCode();
                if (InvalidFields != null)
                    hashCode = hashCode * 59 + InvalidFields.GetHashCode();
                if (PspReference != null)
                    hashCode = hashCode * 59 + PspReference.GetHashCode();
                if (ResultCode != null)
                    hashCode = hashCode * 59 + ResultCode.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
