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
    /// TransferInstrumentReference
    /// </summary>
    [DataContract(Name = "TransferInstrumentReference")]
    public partial class TransferInstrumentReference : IEquatable<TransferInstrumentReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferInstrumentReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransferInstrumentReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferInstrumentReference" /> class.
        /// </summary>
        /// <param name="accountIdentifier">The masked IBAN or bank account number. (required).</param>
        /// <param name="id">The unique identifier of the resource. (required).</param>
        /// <param name="realLastFour">Four last digits of the bank account number..</param>
        public TransferInstrumentReference(string accountIdentifier = default(string), string id = default(string), string realLastFour = default(string))
        {
            this.AccountIdentifier = accountIdentifier;
            this.Id = id;
            this.RealLastFour = realLastFour;
        }

        /// <summary>
        /// The masked IBAN or bank account number.
        /// </summary>
        /// <value>The masked IBAN or bank account number.</value>
        [DataMember(Name = "accountIdentifier", IsRequired = false, EmitDefaultValue = false)]
        public string AccountIdentifier { get; set; }

        /// <summary>
        /// The unique identifier of the resource.
        /// </summary>
        /// <value>The unique identifier of the resource.</value>
        [DataMember(Name = "id", IsRequired = false, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Four last digits of the bank account number.
        /// </summary>
        /// <value>Four last digits of the bank account number.</value>
        [DataMember(Name = "realLastFour", EmitDefaultValue = false)]
        public string RealLastFour { get; set; }

        /// <summary>
        /// Identifies if the bank account was created through [instant bank verification](https://docs.adyen.com/release-notes/platforms-and-financial-products#releaseNote&#x3D;2023-05-08-hosted-onboarding).
        /// </summary>
        /// <value>Identifies if the bank account was created through [instant bank verification](https://docs.adyen.com/release-notes/platforms-and-financial-products#releaseNote&#x3D;2023-05-08-hosted-onboarding).</value>
        [DataMember(Name = "trustedSource", EmitDefaultValue = false)]
        public bool? TrustedSource { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransferInstrumentReference {\n");
            sb.Append("  AccountIdentifier: ").Append(AccountIdentifier).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RealLastFour: ").Append(RealLastFour).Append("\n");
            sb.Append("  TrustedSource: ").Append(TrustedSource).Append("\n");
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
            return this.Equals(input as TransferInstrumentReference);
        }

        /// <summary>
        /// Returns true if TransferInstrumentReference instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferInstrumentReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferInstrumentReference input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountIdentifier == input.AccountIdentifier ||
                    (this.AccountIdentifier != null &&
                    this.AccountIdentifier.Equals(input.AccountIdentifier))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.RealLastFour == input.RealLastFour ||
                    (this.RealLastFour != null &&
                    this.RealLastFour.Equals(input.RealLastFour))
                ) && 
                (
                    this.TrustedSource == input.TrustedSource ||
                    this.TrustedSource.Equals(input.TrustedSource)
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
                if (this.AccountIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.AccountIdentifier.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.RealLastFour != null)
                {
                    hashCode = (hashCode * 59) + this.RealLastFour.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TrustedSource.GetHashCode();
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
