/*
* Classic Platforms - Notifications
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

namespace Adyen.Model.PlatformsWebhooks
{
    /// <summary>
    /// TransferFundsNotificationContent
    /// </summary>
    [DataContract(Name = "TransferFundsNotificationContent")]
    public partial class TransferFundsNotificationContent : IEquatable<TransferFundsNotificationContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferFundsNotificationContent" /> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="destinationAccountCode">The code of the Account to which funds were credited..</param>
        /// <param name="invalidFields">Invalid fields list..</param>
        /// <param name="merchantReference">The reference provided by the merchant..</param>
        /// <param name="sourceAccountCode">The code of the Account from which funds were debited..</param>
        /// <param name="status">status.</param>
        /// <param name="transferCode">The transfer code..</param>
        public TransferFundsNotificationContent(Amount amount = default(Amount), string destinationAccountCode = default(string), List<ErrorFieldType> invalidFields = default(List<ErrorFieldType>), string merchantReference = default(string), string sourceAccountCode = default(string), OperationStatus status = default(OperationStatus), string transferCode = default(string))
        {
            this.Amount = amount;
            this.DestinationAccountCode = destinationAccountCode;
            this.InvalidFields = invalidFields;
            this.MerchantReference = merchantReference;
            this.SourceAccountCode = sourceAccountCode;
            this.Status = status;
            this.TransferCode = transferCode;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Amount Amount { get; set; }

        /// <summary>
        /// The code of the Account to which funds were credited.
        /// </summary>
        /// <value>The code of the Account to which funds were credited.</value>
        [DataMember(Name = "destinationAccountCode", EmitDefaultValue = false)]
        public string DestinationAccountCode { get; set; }

        /// <summary>
        /// Invalid fields list.
        /// </summary>
        /// <value>Invalid fields list.</value>
        [DataMember(Name = "invalidFields", EmitDefaultValue = false)]
        public List<ErrorFieldType> InvalidFields { get; set; }

        /// <summary>
        /// The reference provided by the merchant.
        /// </summary>
        /// <value>The reference provided by the merchant.</value>
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        public string MerchantReference { get; set; }

        /// <summary>
        /// The code of the Account from which funds were debited.
        /// </summary>
        /// <value>The code of the Account from which funds were debited.</value>
        [DataMember(Name = "sourceAccountCode", EmitDefaultValue = false)]
        public string SourceAccountCode { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public OperationStatus Status { get; set; }

        /// <summary>
        /// The transfer code.
        /// </summary>
        /// <value>The transfer code.</value>
        [DataMember(Name = "transferCode", EmitDefaultValue = false)]
        public string TransferCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransferFundsNotificationContent {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  DestinationAccountCode: ").Append(DestinationAccountCode).Append("\n");
            sb.Append("  InvalidFields: ").Append(InvalidFields).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  SourceAccountCode: ").Append(SourceAccountCode).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TransferCode: ").Append(TransferCode).Append("\n");
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
            return this.Equals(input as TransferFundsNotificationContent);
        }

        /// <summary>
        /// Returns true if TransferFundsNotificationContent instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferFundsNotificationContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferFundsNotificationContent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.DestinationAccountCode == input.DestinationAccountCode ||
                    (this.DestinationAccountCode != null &&
                    this.DestinationAccountCode.Equals(input.DestinationAccountCode))
                ) && 
                (
                    this.InvalidFields == input.InvalidFields ||
                    this.InvalidFields != null &&
                    input.InvalidFields != null &&
                    this.InvalidFields.SequenceEqual(input.InvalidFields)
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
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TransferCode == input.TransferCode ||
                    (this.TransferCode != null &&
                    this.TransferCode.Equals(input.TransferCode))
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.DestinationAccountCode != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationAccountCode.GetHashCode();
                }
                if (this.InvalidFields != null)
                {
                    hashCode = (hashCode * 59) + this.InvalidFields.GetHashCode();
                }
                if (this.MerchantReference != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantReference.GetHashCode();
                }
                if (this.SourceAccountCode != null)
                {
                    hashCode = (hashCode * 59) + this.SourceAccountCode.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.TransferCode != null)
                {
                    hashCode = (hashCode * 59) + this.TransferCode.GetHashCode();
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
