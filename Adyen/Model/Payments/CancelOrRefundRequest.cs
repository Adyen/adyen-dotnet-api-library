/*
* Adyen Payment API
*
*
* The version of the OpenAPI document: 68
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

namespace Adyen.Model.Payments
{
    /// <summary>
    /// CancelOrRefundRequest
    /// </summary>
    [DataContract(Name = "CancelOrRefundRequest")]
    public partial class CancelOrRefundRequest : IEquatable<CancelOrRefundRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelOrRefundRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CancelOrRefundRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelOrRefundRequest" /> class.
        /// </summary>
        /// <param name="additionalData">This field contains additional data, which may be required for a particular modification request.  The additionalData object consists of entries, each of which includes the key and value..</param>
        /// <param name="merchantAccount">The merchant account that is used to process the payment. (required).</param>
        /// <param name="mpiData">mpiData.</param>
        /// <param name="originalMerchantReference">The original merchant reference to cancel..</param>
        /// <param name="originalReference">The original pspReference of the payment to modify. This reference is returned in: * authorisation response * authorisation notification   (required).</param>
        /// <param name="reference">Your reference for the payment modification. This reference is visible in Customer Area and in reports. Maximum length: 80 characters..</param>
        /// <param name="tenderReference">The transaction reference provided by the PED. For point-of-sale integrations only..</param>
        /// <param name="uniqueTerminalId">Unique terminal ID for the PED that originally processed the request. For point-of-sale integrations only..</param>
        public CancelOrRefundRequest(Dictionary<string, string> additionalData = default(Dictionary<string, string>), string merchantAccount = default(string), ThreeDSecureData mpiData = default(ThreeDSecureData), string originalMerchantReference = default(string), string originalReference = default(string), string reference = default(string), string tenderReference = default(string), string uniqueTerminalId = default(string))
        {
            this.MerchantAccount = merchantAccount;
            this.OriginalReference = originalReference;
            this.AdditionalData = additionalData;
            this.MpiData = mpiData;
            this.OriginalMerchantReference = originalMerchantReference;
            this.Reference = reference;
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
        [DataMember(Name = "merchantAccount", IsRequired = false, EmitDefaultValue = true)]
        public string MerchantAccount { get; set; }
        
        /// <summary>
        /// Gets or Sets MpiData
        /// </summary>
        [DataMember(Name = "mpiData", EmitDefaultValue = false)]
        public ThreeDSecureData MpiData { get; set; }
        
        /// <summary>
        /// The original merchant reference to cancel.
        /// </summary>
        /// <value>The original merchant reference to cancel.</value>
        [DataMember(Name = "originalMerchantReference", EmitDefaultValue = false)]
        public string OriginalMerchantReference { get; set; }
        
        /// <summary>
        /// The original pspReference of the payment to modify. This reference is returned in: * authorisation response * authorisation notification  
        /// </summary>
        /// <value>The original pspReference of the payment to modify. This reference is returned in: * authorisation response * authorisation notification  </value>
        [DataMember(Name = "originalReference", IsRequired = false, EmitDefaultValue = true)]
        public string OriginalReference { get; set; }
        
        /// <summary>
        /// Your reference for the payment modification. This reference is visible in Customer Area and in reports. Maximum length: 80 characters.
        /// </summary>
        /// <value>Your reference for the payment modification. This reference is visible in Customer Area and in reports. Maximum length: 80 characters.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }
        
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
            sb.Append("class CancelOrRefundRequest {\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  MpiData: ").Append(MpiData).Append("\n");
            sb.Append("  OriginalMerchantReference: ").Append(OriginalMerchantReference).Append("\n");
            sb.Append("  OriginalReference: ").Append(OriginalReference).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
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
            return this.Equals(input as CancelOrRefundRequest);
        }

        /// <summary>
        /// Returns true if CancelOrRefundRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CancelOrRefundRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CancelOrRefundRequest input)
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
                    this.OriginalReference == input.OriginalReference ||
                    (this.OriginalReference != null &&
                    this.OriginalReference.Equals(input.OriginalReference))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
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
                if (this.MpiData != null)
                {
                    hashCode = (hashCode * 59) + this.MpiData.GetHashCode();
                }
                if (this.OriginalMerchantReference != null)
                {
                    hashCode = (hashCode * 59) + this.OriginalMerchantReference.GetHashCode();
                }
                if (this.OriginalReference != null)
                {
                    hashCode = (hashCode * 59) + this.OriginalReference.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
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