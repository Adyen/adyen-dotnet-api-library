/*
* Management API
*
*
* The version of the OpenAPI document: 1
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

namespace Adyen.Model.Management
{
    /// <summary>
    /// CreateMerchantApiCredentialRequest
    /// </summary>
    [DataContract(Name = "CreateMerchantApiCredentialRequest")]
    public partial class CreateMerchantApiCredentialRequest : IEquatable<CreateMerchantApiCredentialRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMerchantApiCredentialRequest" /> class.
        /// </summary>
        /// <param name="allowedOrigins">The list of [allowed origins](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) for the new API credential..</param>
        /// <param name="description">Description of the API credential..</param>
        /// <param name="roles">List of [roles](https://docs.adyen.com/development-resources/api-credentials#roles-1) for the API credential..</param>
        public CreateMerchantApiCredentialRequest(List<string> allowedOrigins = default(List<string>), string description = default(string), List<string> roles = default(List<string>))
        {
            this.AllowedOrigins = allowedOrigins;
            this.Description = description;
            this.Roles = roles;
        }

        /// <summary>
        /// The list of [allowed origins](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) for the new API credential.
        /// </summary>
        /// <value>The list of [allowed origins](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) for the new API credential.</value>
        [DataMember(Name = "allowedOrigins", EmitDefaultValue = false)]
        public List<string> AllowedOrigins { get; set; }

        /// <summary>
        /// Description of the API credential.
        /// </summary>
        /// <value>Description of the API credential.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// List of [roles](https://docs.adyen.com/development-resources/api-credentials#roles-1) for the API credential.
        /// </summary>
        /// <value>List of [roles](https://docs.adyen.com/development-resources/api-credentials#roles-1) for the API credential.</value>
        [DataMember(Name = "roles", EmitDefaultValue = false)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateMerchantApiCredentialRequest {\n");
            sb.Append("  AllowedOrigins: ").Append(AllowedOrigins).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
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
            return this.Equals(input as CreateMerchantApiCredentialRequest);
        }

        /// <summary>
        /// Returns true if CreateMerchantApiCredentialRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateMerchantApiCredentialRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateMerchantApiCredentialRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AllowedOrigins == input.AllowedOrigins ||
                    this.AllowedOrigins != null &&
                    input.AllowedOrigins != null &&
                    this.AllowedOrigins.SequenceEqual(input.AllowedOrigins)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
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
                if (this.AllowedOrigins != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedOrigins.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Roles != null)
                {
                    hashCode = (hashCode * 59) + this.Roles.GetHashCode();
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
