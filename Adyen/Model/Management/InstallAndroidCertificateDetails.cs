/*
* Management API
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

namespace Adyen.Model.Management
{
    /// <summary>
    /// InstallAndroidCertificateDetails
    /// </summary>
    [DataContract(Name = "InstallAndroidCertificateDetails")]
    public partial class InstallAndroidCertificateDetails : IEquatable<InstallAndroidCertificateDetails>, IValidatableObject
    {
        /// <summary>
        /// Type of terminal action: Install an Android certificate.
        /// </summary>
        /// <value>Type of terminal action: Install an Android certificate.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum InstallAndroidCertificate for value: InstallAndroidCertificate
            /// </summary>
            [EnumMember(Value = "InstallAndroidCertificate")]
            InstallAndroidCertificate = 1

        }


        /// <summary>
        /// Type of terminal action: Install an Android certificate.
        /// </summary>
        /// <value>Type of terminal action: Install an Android certificate.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InstallAndroidCertificateDetails" /> class.
        /// </summary>
        /// <param name="certificateId">The unique identifier of the certificate to be installed..</param>
        /// <param name="type">Type of terminal action: Install an Android certificate. (default to TypeEnum.InstallAndroidCertificate).</param>
        public InstallAndroidCertificateDetails(string certificateId = default(string), TypeEnum? type = TypeEnum.InstallAndroidCertificate)
        {
            this.CertificateId = certificateId;
            this.Type = type;
        }

        /// <summary>
        /// The unique identifier of the certificate to be installed.
        /// </summary>
        /// <value>The unique identifier of the certificate to be installed.</value>
        [DataMember(Name = "certificateId", EmitDefaultValue = false)]
        public string CertificateId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InstallAndroidCertificateDetails {\n");
            sb.Append("  CertificateId: ").Append(CertificateId).Append("\n");
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
            return this.Equals(input as InstallAndroidCertificateDetails);
        }

        /// <summary>
        /// Returns true if InstallAndroidCertificateDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of InstallAndroidCertificateDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstallAndroidCertificateDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CertificateId == input.CertificateId ||
                    (this.CertificateId != null &&
                    this.CertificateId.Equals(input.CertificateId))
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
                if (this.CertificateId != null)
                {
                    hashCode = (hashCode * 59) + this.CertificateId.GetHashCode();
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
