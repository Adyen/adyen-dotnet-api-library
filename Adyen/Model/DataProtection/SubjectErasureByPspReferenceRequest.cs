/*
* Adyen Data Protection API
*
*
* The version of the OpenAPI document: 1
* 
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

namespace Adyen.Model.DataProtection
{
    /// <summary>
    /// SubjectErasureByPspReferenceRequest
    /// </summary>
    [DataContract(Name = "SubjectErasureByPspReferenceRequest")]
    public partial class SubjectErasureByPspReferenceRequest : IEquatable<SubjectErasureByPspReferenceRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubjectErasureByPspReferenceRequest" /> class.
        /// </summary>
        /// <param name="forceErasure">Set this to **true** if you want to delete shopper-related data, even if the shopper has an existing recurring transaction. This only deletes the shopper-related data for the specific payment, but does not cancel the existing recurring transaction..</param>
        /// <param name="merchantAccount">Your merchant account.</param>
        /// <param name="pspReference">The PSP reference of the payment. We will delete all shopper-related data for this payment..</param>
        public SubjectErasureByPspReferenceRequest(bool forceErasure = default(bool), string merchantAccount = default(string), string pspReference = default(string))
        {
            this.ForceErasure = forceErasure;
            this.MerchantAccount = merchantAccount;
            this.PspReference = pspReference;
        }

        /// <summary>
        /// Set this to **true** if you want to delete shopper-related data, even if the shopper has an existing recurring transaction. This only deletes the shopper-related data for the specific payment, but does not cancel the existing recurring transaction.
        /// </summary>
        /// <value>Set this to **true** if you want to delete shopper-related data, even if the shopper has an existing recurring transaction. This only deletes the shopper-related data for the specific payment, but does not cancel the existing recurring transaction.</value>
        [DataMember(Name = "forceErasure", EmitDefaultValue = false)]
        public bool ForceErasure { get; set; }

        /// <summary>
        /// Your merchant account
        /// </summary>
        /// <value>Your merchant account</value>
        [DataMember(Name = "merchantAccount", EmitDefaultValue = false)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// The PSP reference of the payment. We will delete all shopper-related data for this payment.
        /// </summary>
        /// <value>The PSP reference of the payment. We will delete all shopper-related data for this payment.</value>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        public string PspReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubjectErasureByPspReferenceRequest {\n");
            sb.Append("  ForceErasure: ").Append(ForceErasure).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
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
            return this.Equals(input as SubjectErasureByPspReferenceRequest);
        }

        /// <summary>
        /// Returns true if SubjectErasureByPspReferenceRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SubjectErasureByPspReferenceRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubjectErasureByPspReferenceRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ForceErasure == input.ForceErasure ||
                    this.ForceErasure.Equals(input.ForceErasure)
                ) && 
                (
                    this.MerchantAccount == input.MerchantAccount ||
                    (this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(input.MerchantAccount))
                ) && 
                (
                    this.PspReference == input.PspReference ||
                    (this.PspReference != null &&
                    this.PspReference.Equals(input.PspReference))
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
                hashCode = (hashCode * 59) + this.ForceErasure.GetHashCode();
                if (this.MerchantAccount != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantAccount.GetHashCode();
                }
                if (this.PspReference != null)
                {
                    hashCode = (hashCode * 59) + this.PspReference.GetHashCode();
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
