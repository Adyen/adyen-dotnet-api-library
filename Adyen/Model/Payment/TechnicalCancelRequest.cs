/*
* Adyen Payment API
*
*
* The version of the OpenAPI document: 68
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

namespace Adyen.Model.Payment
{
    /// <summary>
    /// TechnicalCancelRequest
    /// </summary>
    [DataContract(Name = "TechnicalCancelRequest")]
    public partial class TechnicalCancelRequest : IEquatable<TechnicalCancelRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TechnicalCancelRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TechnicalCancelRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TechnicalCancelRequest" /> class.
        /// </summary>
        /// <param name="additionalData">This field contains additional data, which may be required for a particular modification request.  The additionalData object consists of entries, each of which includes the key and value..</param>
        /// <param name="merchantAccount">The merchant account that is used to process the payment. (required).</param>
        /// <param name="modificationAmount">modificationAmount.</param>
        /// <param name="mpiData">mpiData.</param>
        /// <param name="originalMerchantReference">The original merchant reference to cancel. (required).</param>
        /// <param name="platformChargebackLogic">platformChargebackLogic.</param>
        /// <param name="reference">Your reference for the payment modification. This reference is visible in Customer Area and in reports. Maximum length: 80 characters..</param>
        /// <param name="splits">An array of objects specifying how the amount should be split between accounts when using Adyen for Platforms. For more information, see how to split payments for [platforms](https://docs.adyen.com/platforms/automatic-split-configuration/)..</param>
        /// <param name="tenderReference">The transaction reference provided by the PED. For point-of-sale integrations only..</param>
        /// <param name="uniqueTerminalId">Unique terminal ID for the PED that originally processed the request. For point-of-sale integrations only..</param>
        public TechnicalCancelRequest(Dictionary<string, string> additionalData = default(Dictionary<string, string>), string merchantAccount = default(string), Amount modificationAmount = default(Amount), ThreeDSecureData mpiData = default(ThreeDSecureData), string originalMerchantReference = default(string), PlatformChargebackLogic platformChargebackLogic = default(PlatformChargebackLogic), string reference = default(string), List<Split> splits = default(List<Split>), string tenderReference = default(string), string uniqueTerminalId = default(string))
        {
            this.MerchantAccount = merchantAccount;
            this.OriginalMerchantReference = originalMerchantReference;
            this.AdditionalData = additionalData;
            this.ModificationAmount = modificationAmount;
            this.MpiData = mpiData;
            this.PlatformChargebackLogic = platformChargebackLogic;
            this.Reference = reference;
            this.Splits = splits;
            this.TenderReference = tenderReference;
            this.UniqueTerminalId = uniqueTerminalId;
        }

        /// <summary>
        /// This field contains additional data, which may be required for a particular modification request.  The additionalData object consists of entries, each of which includes the key and value.
        /// </summary>
        /// <value>This field contains additional data, which may be required for a particular modification request.  The additionalData object consists of entries, each of which includes the key and value.</value>
        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// The merchant account that is used to process the payment.
        /// </summary>
        /// <value>The merchant account that is used to process the payment.</value>
        [DataMember(Name = "merchantAccount", IsRequired = false, EmitDefaultValue = false)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// Gets or Sets ModificationAmount
        /// </summary>
        [DataMember(Name = "modificationAmount", EmitDefaultValue = false)]
        public Amount ModificationAmount { get; set; }

        /// <summary>
        /// Gets or Sets MpiData
        /// </summary>
        [DataMember(Name = "mpiData", EmitDefaultValue = false)]
        public ThreeDSecureData MpiData { get; set; }

        /// <summary>
        /// The original merchant reference to cancel.
        /// </summary>
        /// <value>The original merchant reference to cancel.</value>
        [DataMember(Name = "originalMerchantReference", IsRequired = false, EmitDefaultValue = false)]
        public string OriginalMerchantReference { get; set; }

        /// <summary>
        /// Gets or Sets PlatformChargebackLogic
        /// </summary>
        [DataMember(Name = "platformChargebackLogic", EmitDefaultValue = false)]
        public PlatformChargebackLogic PlatformChargebackLogic { get; set; }

        /// <summary>
        /// Your reference for the payment modification. This reference is visible in Customer Area and in reports. Maximum length: 80 characters.
        /// </summary>
        /// <value>Your reference for the payment modification. This reference is visible in Customer Area and in reports. Maximum length: 80 characters.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// An array of objects specifying how the amount should be split between accounts when using Adyen for Platforms. For more information, see how to split payments for [platforms](https://docs.adyen.com/platforms/automatic-split-configuration/).
        /// </summary>
        /// <value>An array of objects specifying how the amount should be split between accounts when using Adyen for Platforms. For more information, see how to split payments for [platforms](https://docs.adyen.com/platforms/automatic-split-configuration/).</value>
        [DataMember(Name = "splits", EmitDefaultValue = false)]
        public List<Split> Splits { get; set; }

        /// <summary>
        /// The transaction reference provided by the PED. For point-of-sale integrations only.
        /// </summary>
        /// <value>The transaction reference provided by the PED. For point-of-sale integrations only.</value>
        [DataMember(Name = "tenderReference", EmitDefaultValue = false)]
        public string TenderReference { get; set; }

        /// <summary>
        /// Unique terminal ID for the PED that originally processed the request. For point-of-sale integrations only.
        /// </summary>
        /// <value>Unique terminal ID for the PED that originally processed the request. For point-of-sale integrations only.</value>
        [DataMember(Name = "uniqueTerminalId", EmitDefaultValue = false)]
        public string UniqueTerminalId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TechnicalCancelRequest {\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  ModificationAmount: ").Append(ModificationAmount).Append("\n");
            sb.Append("  MpiData: ").Append(MpiData).Append("\n");
            sb.Append("  OriginalMerchantReference: ").Append(OriginalMerchantReference).Append("\n");
            sb.Append("  PlatformChargebackLogic: ").Append(PlatformChargebackLogic).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Splits: ").Append(Splits).Append("\n");
            sb.Append("  TenderReference: ").Append(TenderReference).Append("\n");
            sb.Append("  UniqueTerminalId: ").Append(UniqueTerminalId).Append("\n");
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
            return this.Equals(input as TechnicalCancelRequest);
        }

        /// <summary>
        /// Returns true if TechnicalCancelRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TechnicalCancelRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TechnicalCancelRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AdditionalData == input.AdditionalData ||
                    this.AdditionalData != null &&
                    input.AdditionalData != null &&
                    this.AdditionalData.SequenceEqual(input.AdditionalData)
                ) && 
                (
                    this.MerchantAccount == input.MerchantAccount ||
                    (this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(input.MerchantAccount))
                ) && 
                (
                    this.ModificationAmount == input.ModificationAmount ||
                    (this.ModificationAmount != null &&
                    this.ModificationAmount.Equals(input.ModificationAmount))
                ) && 
                (
                    this.MpiData == input.MpiData ||
                    (this.MpiData != null &&
                    this.MpiData.Equals(input.MpiData))
                ) && 
                (
                    this.OriginalMerchantReference == input.OriginalMerchantReference ||
                    (this.OriginalMerchantReference != null &&
                    this.OriginalMerchantReference.Equals(input.OriginalMerchantReference))
                ) && 
                (
                    this.PlatformChargebackLogic == input.PlatformChargebackLogic ||
                    (this.PlatformChargebackLogic != null &&
                    this.PlatformChargebackLogic.Equals(input.PlatformChargebackLogic))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.Splits == input.Splits ||
                    this.Splits != null &&
                    input.Splits != null &&
                    this.Splits.SequenceEqual(input.Splits)
                ) && 
                (
                    this.TenderReference == input.TenderReference ||
                    (this.TenderReference != null &&
                    this.TenderReference.Equals(input.TenderReference))
                ) && 
                (
                    this.UniqueTerminalId == input.UniqueTerminalId ||
                    (this.UniqueTerminalId != null &&
                    this.UniqueTerminalId.Equals(input.UniqueTerminalId))
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
                if (this.AdditionalData != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalData.GetHashCode();
                }
                if (this.MerchantAccount != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantAccount.GetHashCode();
                }
                if (this.ModificationAmount != null)
                {
                    hashCode = (hashCode * 59) + this.ModificationAmount.GetHashCode();
                }
                if (this.MpiData != null)
                {
                    hashCode = (hashCode * 59) + this.MpiData.GetHashCode();
                }
                if (this.OriginalMerchantReference != null)
                {
                    hashCode = (hashCode * 59) + this.OriginalMerchantReference.GetHashCode();
                }
                if (this.PlatformChargebackLogic != null)
                {
                    hashCode = (hashCode * 59) + this.PlatformChargebackLogic.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.Splits != null)
                {
                    hashCode = (hashCode * 59) + this.Splits.GetHashCode();
                }
                if (this.TenderReference != null)
                {
                    hashCode = (hashCode * 59) + this.TenderReference.GetHashCode();
                }
                if (this.UniqueTerminalId != null)
                {
                    hashCode = (hashCode * 59) + this.UniqueTerminalId.GetHashCode();
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
