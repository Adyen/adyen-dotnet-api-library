/*
* Adyen Terminal API
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

namespace Adyen.Model.Terminal
{
    /// <summary>
    /// LoyaltyAccountReq
    /// </summary>
    [DataContract(Name = "LoyaltyAccountReq")]
    public partial class LoyaltyAccountReq : IEquatable<LoyaltyAccountReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyAccountReq" /> class.
        /// </summary>
        /// <param name="cardAcquisitionReference">cardAcquisitionReference.</param>
        /// <param name="loyaltyAccountID">loyaltyAccountID.</param>
        public LoyaltyAccountReq(TransactionIDType cardAcquisitionReference = default(TransactionIDType), LoyaltyAccountID loyaltyAccountID = default(LoyaltyAccountID))
        {
            this.CardAcquisitionReference = cardAcquisitionReference;
            this.LoyaltyAccountID = loyaltyAccountID;
        }

        /// <summary>
        /// Gets or Sets CardAcquisitionReference
        /// </summary>
        [DataMember(Name = "CardAcquisitionReference", EmitDefaultValue = false)]
        public TransactionIDType CardAcquisitionReference { get; set; }

        /// <summary>
        /// Gets or Sets LoyaltyAccountID
        /// </summary>
        [DataMember(Name = "LoyaltyAccountID", EmitDefaultValue = false)]
        public LoyaltyAccountID LoyaltyAccountID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LoyaltyAccountReq {\n");
            sb.Append("  CardAcquisitionReference: ").Append(CardAcquisitionReference).Append("\n");
            sb.Append("  LoyaltyAccountID: ").Append(LoyaltyAccountID).Append("\n");
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
            return this.Equals(input as LoyaltyAccountReq);
        }

        /// <summary>
        /// Returns true if LoyaltyAccountReq instances are equal
        /// </summary>
        /// <param name="input">Instance of LoyaltyAccountReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoyaltyAccountReq input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CardAcquisitionReference == input.CardAcquisitionReference ||
                    (this.CardAcquisitionReference != null &&
                    this.CardAcquisitionReference.Equals(input.CardAcquisitionReference))
                ) && 
                (
                    this.LoyaltyAccountID == input.LoyaltyAccountID ||
                    (this.LoyaltyAccountID != null &&
                    this.LoyaltyAccountID.Equals(input.LoyaltyAccountID))
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
                if (this.CardAcquisitionReference != null)
                {
                    hashCode = (hashCode * 59) + this.CardAcquisitionReference.GetHashCode();
                }
                if (this.LoyaltyAccountID != null)
                {
                    hashCode = (hashCode * 59) + this.LoyaltyAccountID.GetHashCode();
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
