/*
* Transaction webhooks
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

namespace Adyen.Model.TransactionWebhooks
{
    /// <summary>
    /// TransactionNotificationRequestV4
    /// </summary>
    [DataContract(Name = "TransactionNotificationRequestV4")]
    public partial class TransactionNotificationRequestV4 : IEquatable<TransactionNotificationRequestV4>, IValidatableObject
    {
        /// <summary>
        /// Type of the webhook.
        /// </summary>
        /// <value>Type of the webhook.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum BalancePlatformTransactionCreated for value: balancePlatform.transaction.created
            /// </summary>
            [EnumMember(Value = "balancePlatform.transaction.created")]
            BalancePlatformTransactionCreated = 1

        }


        /// <summary>
        /// Type of the webhook.
        /// </summary>
        /// <value>Type of the webhook.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionNotificationRequestV4" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionNotificationRequestV4() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionNotificationRequestV4" /> class.
        /// </summary>
        /// <param name="data">data (required).</param>
        /// <param name="environment">The environment from which the webhook originated.  Possible values: **test**, **live**. (required).</param>
        /// <param name="timestamp">When the event was queued..</param>
        /// <param name="type">Type of the webhook..</param>
        public TransactionNotificationRequestV4(Transaction data = default(Transaction), string environment = default(string), DateTime timestamp = default(DateTime), TypeEnum? type = default(TypeEnum?))
        {
            this.Data = data;
            this.Environment = environment;
            this.Timestamp = timestamp;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = false, EmitDefaultValue = false)]
        public Transaction Data { get; set; }

        /// <summary>
        /// The environment from which the webhook originated.  Possible values: **test**, **live**.
        /// </summary>
        /// <value>The environment from which the webhook originated.  Possible values: **test**, **live**.</value>
        [DataMember(Name = "environment", IsRequired = false, EmitDefaultValue = false)]
        public string Environment { get; set; }

        /// <summary>
        /// When the event was queued.
        /// </summary>
        /// <value>When the event was queued.</value>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionNotificationRequestV4 {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Environment: ").Append(Environment).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(input as TransactionNotificationRequestV4);
        }

        /// <summary>
        /// Returns true if TransactionNotificationRequestV4 instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionNotificationRequestV4 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionNotificationRequestV4 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Environment == input.Environment ||
                    (this.Environment != null &&
                    this.Environment.Equals(input.Environment))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
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
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.Environment != null)
                {
                    hashCode = (hashCode * 59) + this.Environment.GetHashCode();
                }
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
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
