/*
* Transfers API
*
*
* The version of the OpenAPI document: 4
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

namespace Adyen.Model.Transfers
{
    /// <summary>
    /// DirectDebitInformation
    /// </summary>
    [DataContract(Name = "DirectDebitInformation")]
    public partial class DirectDebitInformation : IEquatable<DirectDebitInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirectDebitInformation" /> class.
        /// </summary>
        /// <param name="dateOfSignature">The date when the direct debit mandate was accepted by your user, in [ISO-8601](https://www.w3.org/TR/NOTE-datetime) format..</param>
        /// <param name="dueDate">The date when the funds are deducted from your user&#39;s balance account..</param>
        /// <param name="mandateId">Your unique identifier for the direct debit mandate..</param>
        /// <param name="sequenceType">Identifies the direct debit transfer&#39;s type. Possible values: **OneOff**, **First**, **Recurring**, **Final**..</param>
        public DirectDebitInformation(DateTime dateOfSignature = default(DateTime), DateTime dueDate = default(DateTime), string mandateId = default(string), string sequenceType = default(string))
        {
            this.DateOfSignature = dateOfSignature;
            this.DueDate = dueDate;
            this.MandateId = mandateId;
            this.SequenceType = sequenceType;
        }

        /// <summary>
        /// The date when the direct debit mandate was accepted by your user, in [ISO-8601](https://www.w3.org/TR/NOTE-datetime) format.
        /// </summary>
        /// <value>The date when the direct debit mandate was accepted by your user, in [ISO-8601](https://www.w3.org/TR/NOTE-datetime) format.</value>
        [DataMember(Name = "dateOfSignature", EmitDefaultValue = false)]
        public DateTime DateOfSignature { get; set; }

        /// <summary>
        /// The date when the funds are deducted from your user&#39;s balance account.
        /// </summary>
        /// <value>The date when the funds are deducted from your user&#39;s balance account.</value>
        [DataMember(Name = "dueDate", EmitDefaultValue = false)]
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Your unique identifier for the direct debit mandate.
        /// </summary>
        /// <value>Your unique identifier for the direct debit mandate.</value>
        [DataMember(Name = "mandateId", EmitDefaultValue = false)]
        public string MandateId { get; set; }

        /// <summary>
        /// Identifies the direct debit transfer&#39;s type. Possible values: **OneOff**, **First**, **Recurring**, **Final**.
        /// </summary>
        /// <value>Identifies the direct debit transfer&#39;s type. Possible values: **OneOff**, **First**, **Recurring**, **Final**.</value>
        [DataMember(Name = "sequenceType", EmitDefaultValue = false)]
        public string SequenceType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DirectDebitInformation {\n");
            sb.Append("  DateOfSignature: ").Append(DateOfSignature).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  MandateId: ").Append(MandateId).Append("\n");
            sb.Append("  SequenceType: ").Append(SequenceType).Append("\n");
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
            return this.Equals(input as DirectDebitInformation);
        }

        /// <summary>
        /// Returns true if DirectDebitInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of DirectDebitInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DirectDebitInformation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DateOfSignature == input.DateOfSignature ||
                    (this.DateOfSignature != null &&
                    this.DateOfSignature.Equals(input.DateOfSignature))
                ) && 
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && 
                (
                    this.MandateId == input.MandateId ||
                    (this.MandateId != null &&
                    this.MandateId.Equals(input.MandateId))
                ) && 
                (
                    this.SequenceType == input.SequenceType ||
                    (this.SequenceType != null &&
                    this.SequenceType.Equals(input.SequenceType))
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
                if (this.DateOfSignature != null)
                {
                    hashCode = (hashCode * 59) + this.DateOfSignature.GetHashCode();
                }
                if (this.DueDate != null)
                {
                    hashCode = (hashCode * 59) + this.DueDate.GetHashCode();
                }
                if (this.MandateId != null)
                {
                    hashCode = (hashCode * 59) + this.MandateId.GetHashCode();
                }
                if (this.SequenceType != null)
                {
                    hashCode = (hashCode * 59) + this.SequenceType.GetHashCode();
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