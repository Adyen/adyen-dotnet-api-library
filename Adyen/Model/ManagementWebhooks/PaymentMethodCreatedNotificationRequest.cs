/*
* Management Webhooks
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

namespace Adyen.Model.ManagementWebhooks
{
    /// <summary>
    /// PaymentMethodCreatedNotificationRequest
    /// </summary>
    [DataContract(Name = "PaymentMethodCreatedNotificationRequest")]
    public partial class PaymentMethodCreatedNotificationRequest : IEquatable<PaymentMethodCreatedNotificationRequest>, IValidatableObject
    {
        /// <summary>
        /// Type of notification.
        /// </summary>
        /// <value>Type of notification.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum PaymentMethodCreated for value: paymentMethod.created
            /// </summary>
            [EnumMember(Value = "paymentMethod.created")]
            PaymentMethodCreated = 1

        }


        /// <summary>
        /// Type of notification.
        /// </summary>
        /// <value>Type of notification.</value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodCreatedNotificationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentMethodCreatedNotificationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodCreatedNotificationRequest" /> class.
        /// </summary>
        /// <param name="createdAt">Timestamp for when the webhook was created. (required).</param>
        /// <param name="data">data (required).</param>
        /// <param name="environment">The environment from which the webhook originated.  Possible values: **test**, **live**. (required).</param>
        /// <param name="type">Type of notification. (required).</param>
        public PaymentMethodCreatedNotificationRequest(DateTime createdAt = default(DateTime), MidServiceNotificationData data = default(MidServiceNotificationData), string environment = default(string), TypeEnum type = default(TypeEnum))
        {
            this.CreatedAt = createdAt;
            this.Data = data;
            this.Environment = environment;
            this.Type = type;
        }

        /// <summary>
        /// Timestamp for when the webhook was created.
        /// </summary>
        /// <value>Timestamp for when the webhook was created.</value>
        [DataMember(Name = "createdAt", IsRequired = false, EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = false, EmitDefaultValue = false)]
        public MidServiceNotificationData Data { get; set; }

        /// <summary>
        /// The environment from which the webhook originated.  Possible values: **test**, **live**.
        /// </summary>
        /// <value>The environment from which the webhook originated.  Possible values: **test**, **live**.</value>
        [DataMember(Name = "environment", IsRequired = false, EmitDefaultValue = false)]
        public string Environment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentMethodCreatedNotificationRequest {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Environment: ").Append(Environment).Append("\n");
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
            return this.Equals(input as PaymentMethodCreatedNotificationRequest);
        }

        /// <summary>
        /// Returns true if PaymentMethodCreatedNotificationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethodCreatedNotificationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodCreatedNotificationRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
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
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.Environment != null)
                {
                    hashCode = (hashCode * 59) + this.Environment.GetHashCode();
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
