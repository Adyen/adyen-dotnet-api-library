/*
* Configuration API
*
*
* The version of the OpenAPI document: 2
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

namespace Adyen.Model.BalancePlatform
{
    /// <summary>
    /// Device
    /// </summary>
    [DataContract(Name = "Device")]
    public partial class Device : IEquatable<Device>, IValidatableObject
    {
        /// <summary>
        /// The type of device.  Possible values: **ios**, **android**, **browser**.
        /// </summary>
        /// <value>The type of device.  Possible values: **ios**, **android**, **browser**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Ios for value: ios
            /// </summary>
            [EnumMember(Value = "ios")]
            Ios = 1,

            /// <summary>
            /// Enum Android for value: android
            /// </summary>
            [EnumMember(Value = "android")]
            Android = 2,

            /// <summary>
            /// Enum Browser for value: browser
            /// </summary>
            [EnumMember(Value = "browser")]
            Browser = 3

        }


        /// <summary>
        /// The type of device.  Possible values: **ios**, **android**, **browser**.
        /// </summary>
        /// <value>The type of device.  Possible values: **ios**, **android**, **browser**.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Device" /> class.
        /// </summary>
        /// <param name="id">The unique identifier of the SCA device..</param>
        /// <param name="name">The name of the SCA device. You can show this name to your user to help them identify the device..</param>
        /// <param name="paymentInstrumentId">The unique identifier of the payment instrument that is associated with the SCA device..</param>
        /// <param name="type">The type of device.  Possible values: **ios**, **android**, **browser**..</param>
        public Device(string id = default(string), string name = default(string), string paymentInstrumentId = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.Id = id;
            this.Name = name;
            this.PaymentInstrumentId = paymentInstrumentId;
            this.Type = type;
        }

        /// <summary>
        /// The unique identifier of the SCA device.
        /// </summary>
        /// <value>The unique identifier of the SCA device.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The name of the SCA device. You can show this name to your user to help them identify the device.
        /// </summary>
        /// <value>The name of the SCA device. You can show this name to your user to help them identify the device.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The unique identifier of the payment instrument that is associated with the SCA device.
        /// </summary>
        /// <value>The unique identifier of the payment instrument that is associated with the SCA device.</value>
        [DataMember(Name = "paymentInstrumentId", EmitDefaultValue = false)]
        public string PaymentInstrumentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Device {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PaymentInstrumentId: ").Append(PaymentInstrumentId).Append("\n");
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
            return this.Equals(input as Device);
        }

        /// <summary>
        /// Returns true if Device instances are equal
        /// </summary>
        /// <param name="input">Instance of Device to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Device input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PaymentInstrumentId == input.PaymentInstrumentId ||
                    (this.PaymentInstrumentId != null &&
                    this.PaymentInstrumentId.Equals(input.PaymentInstrumentId))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.PaymentInstrumentId != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentInstrumentId.GetHashCode();
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