/*
* Dispute webhooks
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

namespace Adyen.Model.DisputeWebhooks
{
    /// <summary>
    /// DisputeEventNotification
    /// </summary>
    [DataContract(Name = "DisputeEventNotification")]
    public partial class DisputeEventNotification : IEquatable<DisputeEventNotification>, IValidatableObject
    {
        /// <summary>
        /// The type of dispute raised for the transaction.
        /// </summary>
        /// <value>The type of dispute raised for the transaction.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Fraud for value: fraud
            /// </summary>
            [EnumMember(Value = "fraud")]
            Fraud = 1,

            /// <summary>
            /// Enum NotDelivered for value: notDelivered
            /// </summary>
            [EnumMember(Value = "notDelivered")]
            NotDelivered = 2

        }


        /// <summary>
        /// The type of dispute raised for the transaction.
        /// </summary>
        /// <value>The type of dispute raised for the transaction.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DisputeEventNotification" /> class.
        /// </summary>
        /// <param name="arn">The unique Acquirer Reference Number (arn) generated by the card scheme for each capture. You can use the arn to trace the transaction through its lifecycle..</param>
        /// <param name="balancePlatform">The unique identifier of the balance platform..</param>
        /// <param name="creationDate">The date and time when the event was triggered, in ISO 8601 extended format. For example, **2020-12-18T10:15:30+01:00**..</param>
        /// <param name="description">Contains information about the dispute..</param>
        /// <param name="disputedAmount">disputedAmount.</param>
        /// <param name="id">The ID of the resource..</param>
        /// <param name="status">The current status of the dispute..</param>
        /// <param name="statusDetail">Additional information about the status of the dispute, when available..</param>
        /// <param name="transactionId">The unique reference of the transaction for which the dispute is requested..</param>
        /// <param name="type">The type of dispute raised for the transaction..</param>
        public DisputeEventNotification(string arn = default(string), string balancePlatform = default(string), DateTime creationDate = default(DateTime), string description = default(string), Amount disputedAmount = default(Amount), string id = default(string), string status = default(string), string statusDetail = default(string), string transactionId = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.Arn = arn;
            this.BalancePlatform = balancePlatform;
            this.CreationDate = creationDate;
            this.Description = description;
            this.DisputedAmount = disputedAmount;
            this.Id = id;
            this.Status = status;
            this.StatusDetail = statusDetail;
            this.TransactionId = transactionId;
            this.Type = type;
        }

        /// <summary>
        /// The unique Acquirer Reference Number (arn) generated by the card scheme for each capture. You can use the arn to trace the transaction through its lifecycle.
        /// </summary>
        /// <value>The unique Acquirer Reference Number (arn) generated by the card scheme for each capture. You can use the arn to trace the transaction through its lifecycle.</value>
        [DataMember(Name = "arn", EmitDefaultValue = false)]
        public string Arn { get; set; }

        /// <summary>
        /// The unique identifier of the balance platform.
        /// </summary>
        /// <value>The unique identifier of the balance platform.</value>
        [DataMember(Name = "balancePlatform", EmitDefaultValue = false)]
        public string BalancePlatform { get; set; }

        /// <summary>
        /// The date and time when the event was triggered, in ISO 8601 extended format. For example, **2020-12-18T10:15:30+01:00**.
        /// </summary>
        /// <value>The date and time when the event was triggered, in ISO 8601 extended format. For example, **2020-12-18T10:15:30+01:00**.</value>
        [DataMember(Name = "creationDate", EmitDefaultValue = false)]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Contains information about the dispute.
        /// </summary>
        /// <value>Contains information about the dispute.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DisputedAmount
        /// </summary>
        [DataMember(Name = "disputedAmount", EmitDefaultValue = false)]
        public Amount DisputedAmount { get; set; }

        /// <summary>
        /// The ID of the resource.
        /// </summary>
        /// <value>The ID of the resource.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The current status of the dispute.
        /// </summary>
        /// <value>The current status of the dispute.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Additional information about the status of the dispute, when available.
        /// </summary>
        /// <value>Additional information about the status of the dispute, when available.</value>
        [DataMember(Name = "statusDetail", EmitDefaultValue = false)]
        public string StatusDetail { get; set; }

        /// <summary>
        /// The unique reference of the transaction for which the dispute is requested.
        /// </summary>
        /// <value>The unique reference of the transaction for which the dispute is requested.</value>
        [DataMember(Name = "transactionId", EmitDefaultValue = false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DisputeEventNotification {\n");
            sb.Append("  Arn: ").Append(Arn).Append("\n");
            sb.Append("  BalancePlatform: ").Append(BalancePlatform).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisputedAmount: ").Append(DisputedAmount).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDetail: ").Append(StatusDetail).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
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
            return this.Equals(input as DisputeEventNotification);
        }

        /// <summary>
        /// Returns true if DisputeEventNotification instances are equal
        /// </summary>
        /// <param name="input">Instance of DisputeEventNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DisputeEventNotification input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Arn == input.Arn ||
                    (this.Arn != null &&
                    this.Arn.Equals(input.Arn))
                ) && 
                (
                    this.BalancePlatform == input.BalancePlatform ||
                    (this.BalancePlatform != null &&
                    this.BalancePlatform.Equals(input.BalancePlatform))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DisputedAmount == input.DisputedAmount ||
                    (this.DisputedAmount != null &&
                    this.DisputedAmount.Equals(input.DisputedAmount))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StatusDetail == input.StatusDetail ||
                    (this.StatusDetail != null &&
                    this.StatusDetail.Equals(input.StatusDetail))
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
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
                if (this.Arn != null)
                {
                    hashCode = (hashCode * 59) + this.Arn.GetHashCode();
                }
                if (this.BalancePlatform != null)
                {
                    hashCode = (hashCode * 59) + this.BalancePlatform.GetHashCode();
                }
                if (this.CreationDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreationDate.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.DisputedAmount != null)
                {
                    hashCode = (hashCode * 59) + this.DisputedAmount.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.StatusDetail != null)
                {
                    hashCode = (hashCode * 59) + this.StatusDetail.GetHashCode();
                }
                if (this.TransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionId.GetHashCode();
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