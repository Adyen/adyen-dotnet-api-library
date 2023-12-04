/*
* Configuration API
*
*
* The version of the OpenAPI document: 2
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
    /// RestServiceError
    /// </summary>
    [DataContract(Name = "RestServiceError")]
    public partial class RestServiceError : IEquatable<RestServiceError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestServiceError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RestServiceError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RestServiceError" /> class.
        /// </summary>
        /// <param name="detail">A human-readable explanation specific to this occurrence of the problem. (required).</param>
        /// <param name="errorCode">A code that identifies the problem type. (required).</param>
        /// <param name="instance">A unique URI that identifies the specific occurrence of the problem..</param>
        /// <param name="invalidFields">Detailed explanation of each validation error, when applicable..</param>
        /// <param name="requestId">A unique reference for the request, essentially the same as &#x60;pspReference&#x60;..</param>
        /// <param name="response">response.</param>
        /// <param name="status">The HTTP status code. (required).</param>
        /// <param name="title">A short, human-readable summary of the problem type. (required).</param>
        /// <param name="type">A URI that identifies the problem type, pointing to human-readable documentation on this problem type. (required).</param>
        public RestServiceError(string detail = default(string), string errorCode = default(string), string instance = default(string), List<InvalidField> invalidFields = default(List<InvalidField>), string requestId = default(string), Object response = default(Object), int? status = default(int?), string title = default(string), string type = default(string))
        {
            this.Detail = detail;
            this.ErrorCode = errorCode;
            this.Status = status;
            this.Title = title;
            this.Type = type;
            this.Instance = instance;
            this.InvalidFields = invalidFields;
            this.RequestId = requestId;
            this.Response = response;
        }

        /// <summary>
        /// A human-readable explanation specific to this occurrence of the problem.
        /// </summary>
        /// <value>A human-readable explanation specific to this occurrence of the problem.</value>
        [DataMember(Name = "detail", IsRequired = false, EmitDefaultValue = false)]
        public string Detail { get; set; }

        /// <summary>
        /// A code that identifies the problem type.
        /// </summary>
        /// <value>A code that identifies the problem type.</value>
        [DataMember(Name = "errorCode", IsRequired = false, EmitDefaultValue = false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// A unique URI that identifies the specific occurrence of the problem.
        /// </summary>
        /// <value>A unique URI that identifies the specific occurrence of the problem.</value>
        [DataMember(Name = "instance", EmitDefaultValue = false)]
        public string Instance { get; set; }

        /// <summary>
        /// Detailed explanation of each validation error, when applicable.
        /// </summary>
        /// <value>Detailed explanation of each validation error, when applicable.</value>
        [DataMember(Name = "invalidFields", EmitDefaultValue = false)]
        public List<InvalidField> InvalidFields { get; set; }

        /// <summary>
        /// A unique reference for the request, essentially the same as &#x60;pspReference&#x60;.
        /// </summary>
        /// <value>A unique reference for the request, essentially the same as &#x60;pspReference&#x60;.</value>
        [DataMember(Name = "requestId", EmitDefaultValue = false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Gets or Sets Response
        /// </summary>
        [DataMember(Name = "response", EmitDefaultValue = false)]
        public Object Response { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        /// <value>The HTTP status code.</value>
        [DataMember(Name = "status", IsRequired = false, EmitDefaultValue = false)]
        public int? Status { get; set; }

        /// <summary>
        /// A short, human-readable summary of the problem type.
        /// </summary>
        /// <value>A short, human-readable summary of the problem type.</value>
        [DataMember(Name = "title", IsRequired = false, EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// A URI that identifies the problem type, pointing to human-readable documentation on this problem type.
        /// </summary>
        /// <value>A URI that identifies the problem type, pointing to human-readable documentation on this problem type.</value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RestServiceError {\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  Instance: ").Append(Instance).Append("\n");
            sb.Append("  InvalidFields: ").Append(InvalidFields).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  Response: ").Append(Response).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as RestServiceError);
        }

        /// <summary>
        /// Returns true if RestServiceError instances are equal
        /// </summary>
        /// <param name="input">Instance of RestServiceError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestServiceError input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.Instance == input.Instance ||
                    (this.Instance != null &&
                    this.Instance.Equals(input.Instance))
                ) && 
                (
                    this.InvalidFields == input.InvalidFields ||
                    this.InvalidFields != null &&
                    input.InvalidFields != null &&
                    this.InvalidFields.SequenceEqual(input.InvalidFields)
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.Response == input.Response ||
                    (this.Response != null &&
                    this.Response.Equals(input.Response))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Detail != null)
                {
                    hashCode = (hashCode * 59) + this.Detail.GetHashCode();
                }
                if (this.ErrorCode != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorCode.GetHashCode();
                }
                if (this.Instance != null)
                {
                    hashCode = (hashCode * 59) + this.Instance.GetHashCode();
                }
                if (this.InvalidFields != null)
                {
                    hashCode = (hashCode * 59) + this.InvalidFields.GetHashCode();
                }
                if (this.RequestId != null)
                {
                    hashCode = (hashCode * 59) + this.RequestId.GetHashCode();
                }
                if (this.Response != null)
                {
                    hashCode = (hashCode * 59) + this.Response.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
