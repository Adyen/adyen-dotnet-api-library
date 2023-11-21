/*
* Fund API
*
*
* The version of the OpenAPI document: 6
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

namespace Adyen.Model.PlatformsFund
{
    /// <summary>
    /// SetupBeneficiaryRequest
    /// </summary>
    [DataContract(Name = "SetupBeneficiaryRequest")]
    public partial class SetupBeneficiaryRequest : IEquatable<SetupBeneficiaryRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetupBeneficiaryRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SetupBeneficiaryRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SetupBeneficiaryRequest" /> class.
        /// </summary>
        /// <param name="destinationAccountCode">The destination account code. (required).</param>
        /// <param name="merchantReference">A value that can be supplied at the discretion of the executing user..</param>
        /// <param name="sourceAccountCode">The benefactor account. (required).</param>
        public SetupBeneficiaryRequest(string destinationAccountCode = default(string), string merchantReference = default(string), string sourceAccountCode = default(string))
        {
            this.DestinationAccountCode = destinationAccountCode;
            this.SourceAccountCode = sourceAccountCode;
            this.MerchantReference = merchantReference;
        }

        /// <summary>
        /// The destination account code.
        /// </summary>
        /// <value>The destination account code.</value>
        [DataMember(Name = "destinationAccountCode", IsRequired = false, EmitDefaultValue = false)]
        public string DestinationAccountCode { get; set; }

        /// <summary>
        /// A value that can be supplied at the discretion of the executing user.
        /// </summary>
        /// <value>A value that can be supplied at the discretion of the executing user.</value>
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        public string MerchantReference { get; set; }

        /// <summary>
        /// The benefactor account.
        /// </summary>
        /// <value>The benefactor account.</value>
        [DataMember(Name = "sourceAccountCode", IsRequired = false, EmitDefaultValue = false)]
        public string SourceAccountCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SetupBeneficiaryRequest {\n");
            sb.Append("  DestinationAccountCode: ").Append(DestinationAccountCode).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  SourceAccountCode: ").Append(SourceAccountCode).Append("\n");
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
            return this.Equals(input as SetupBeneficiaryRequest);
        }

        /// <summary>
        /// Returns true if SetupBeneficiaryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SetupBeneficiaryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetupBeneficiaryRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DestinationAccountCode == input.DestinationAccountCode ||
                    (this.DestinationAccountCode != null &&
                    this.DestinationAccountCode.Equals(input.DestinationAccountCode))
                ) && 
                (
                    this.MerchantReference == input.MerchantReference ||
                    (this.MerchantReference != null &&
                    this.MerchantReference.Equals(input.MerchantReference))
                ) && 
                (
                    this.SourceAccountCode == input.SourceAccountCode ||
                    (this.SourceAccountCode != null &&
                    this.SourceAccountCode.Equals(input.SourceAccountCode))
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
                if (this.DestinationAccountCode != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationAccountCode.GetHashCode();
                }
                if (this.MerchantReference != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantReference.GetHashCode();
                }
                if (this.SourceAccountCode != null)
                {
                    hashCode = (hashCode * 59) + this.SourceAccountCode.GetHashCode();
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