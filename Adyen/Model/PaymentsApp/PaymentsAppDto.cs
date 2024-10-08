/*
* Payments App API
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

namespace Adyen.Model.PaymentsApp
{
    /// <summary>
    /// PaymentsAppDto
    /// </summary>
    [DataContract(Name = "PaymentsAppDto")]
    public partial class PaymentsAppDto : IEquatable<PaymentsAppDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsAppDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentsAppDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsAppDto" /> class.
        /// </summary>
        /// <param name="installationId">The unique identifier of the Payments App instance. (required).</param>
        /// <param name="merchantAccountCode">The account code associated with the Payments App instance. (required).</param>
        /// <param name="merchantStoreCode">The store code associated with the Payments App instance..</param>
        /// <param name="status">The status of the Payments App instance. (required).</param>
        public PaymentsAppDto(string installationId = default(string), string merchantAccountCode = default(string), string merchantStoreCode = default(string), string status = default(string))
        {
            this.InstallationId = installationId;
            this.MerchantAccountCode = merchantAccountCode;
            this.Status = status;
            this.MerchantStoreCode = merchantStoreCode;
        }

        /// <summary>
        /// The unique identifier of the Payments App instance.
        /// </summary>
        /// <value>The unique identifier of the Payments App instance.</value>
        [DataMember(Name = "installationId", IsRequired = false, EmitDefaultValue = false)]
        public string InstallationId { get; set; }

        /// <summary>
        /// The account code associated with the Payments App instance.
        /// </summary>
        /// <value>The account code associated with the Payments App instance.</value>
        [DataMember(Name = "merchantAccountCode", IsRequired = false, EmitDefaultValue = false)]
        public string MerchantAccountCode { get; set; }

        /// <summary>
        /// The store code associated with the Payments App instance.
        /// </summary>
        /// <value>The store code associated with the Payments App instance.</value>
        [DataMember(Name = "merchantStoreCode", EmitDefaultValue = false)]
        public string MerchantStoreCode { get; set; }

        /// <summary>
        /// The status of the Payments App instance.
        /// </summary>
        /// <value>The status of the Payments App instance.</value>
        [DataMember(Name = "status", IsRequired = false, EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentsAppDto {\n");
            sb.Append("  InstallationId: ").Append(InstallationId).Append("\n");
            sb.Append("  MerchantAccountCode: ").Append(MerchantAccountCode).Append("\n");
            sb.Append("  MerchantStoreCode: ").Append(MerchantStoreCode).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as PaymentsAppDto);
        }

        /// <summary>
        /// Returns true if PaymentsAppDto instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentsAppDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentsAppDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InstallationId == input.InstallationId ||
                    (this.InstallationId != null &&
                    this.InstallationId.Equals(input.InstallationId))
                ) && 
                (
                    this.MerchantAccountCode == input.MerchantAccountCode ||
                    (this.MerchantAccountCode != null &&
                    this.MerchantAccountCode.Equals(input.MerchantAccountCode))
                ) && 
                (
                    this.MerchantStoreCode == input.MerchantStoreCode ||
                    (this.MerchantStoreCode != null &&
                    this.MerchantStoreCode.Equals(input.MerchantStoreCode))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.InstallationId != null)
                {
                    hashCode = (hashCode * 59) + this.InstallationId.GetHashCode();
                }
                if (this.MerchantAccountCode != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantAccountCode.GetHashCode();
                }
                if (this.MerchantStoreCode != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantStoreCode.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
