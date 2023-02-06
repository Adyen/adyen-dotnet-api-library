/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 70
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
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// DeviceRenderOptions
    /// </summary>
    [DataContract(Name = "DeviceRenderOptions")]
    public partial class DeviceRenderOptions : IEquatable<DeviceRenderOptions>, IValidatableObject
    {
        /// <summary>
        /// Supported SDK interface types. Allowed values: * native * html * both
        /// </summary>
        /// <value>Supported SDK interface types. Allowed values: * native * html * both</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SdkInterfaceEnum
        {
            /// <summary>
            /// Enum Native for value: native
            /// </summary>
            [EnumMember(Value = "native")]
            Native = 1,

            /// <summary>
            /// Enum Html for value: html
            /// </summary>
            [EnumMember(Value = "html")]
            Html = 2,

            /// <summary>
            /// Enum Both for value: both
            /// </summary>
            [EnumMember(Value = "both")]
            Both = 3

        }


        /// <summary>
        /// Supported SDK interface types. Allowed values: * native * html * both
        /// </summary>
        /// <value>Supported SDK interface types. Allowed values: * native * html * both</value>
        [DataMember(Name = "sdkInterface", EmitDefaultValue = false)]
        public SdkInterfaceEnum? SdkInterface { get; set; }
        /// <summary>
        /// Defines SdkUiType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SdkUiTypeEnum
        {
            /// <summary>
            /// Enum MultiSelect for value: multiSelect
            /// </summary>
            [EnumMember(Value = "multiSelect")]
            MultiSelect = 1,

            /// <summary>
            /// Enum OtherHtml for value: otherHtml
            /// </summary>
            [EnumMember(Value = "otherHtml")]
            OtherHtml = 2,

            /// <summary>
            /// Enum OutOfBand for value: outOfBand
            /// </summary>
            [EnumMember(Value = "outOfBand")]
            OutOfBand = 3,

            /// <summary>
            /// Enum SingleSelect for value: singleSelect
            /// </summary>
            [EnumMember(Value = "singleSelect")]
            SingleSelect = 4,

            /// <summary>
            /// Enum Text for value: text
            /// </summary>
            [EnumMember(Value = "text")]
            Text = 5

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceRenderOptions" /> class.
        /// </summary>
        /// <param name="sdkInterface">Supported SDK interface types. Allowed values: * native * html * both (default to SdkInterfaceEnum.Both).</param>
        /// <param name="sdkUiType">UI types supported for displaying specific challenges. Allowed values: * text * singleSelect * outOfBand * otherHtml * multiSelect.</param>
        public DeviceRenderOptions(SdkInterfaceEnum? sdkInterface = SdkInterfaceEnum.Both, List<SdkUiTypeEnum> sdkUiType = default(List<SdkUiTypeEnum>))
        {
            this.SdkInterface = sdkInterface;
            this.SdkUiType = sdkUiType;
        }

        /// <summary>
        /// UI types supported for displaying specific challenges. Allowed values: * text * singleSelect * outOfBand * otherHtml * multiSelect
        /// </summary>
        /// <value>UI types supported for displaying specific challenges. Allowed values: * text * singleSelect * outOfBand * otherHtml * multiSelect</value>
        [DataMember(Name = "sdkUiType", EmitDefaultValue = false)]
        public List<DeviceRenderOptions.SdkUiTypeEnum> SdkUiType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeviceRenderOptions {\n");
            sb.Append("  SdkInterface: ").Append(SdkInterface).Append("\n");
            sb.Append("  SdkUiType: ").Append(SdkUiType).Append("\n");
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
            return this.Equals(input as DeviceRenderOptions);
        }

        /// <summary>
        /// Returns true if DeviceRenderOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceRenderOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceRenderOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SdkInterface == input.SdkInterface ||
                    this.SdkInterface.Equals(input.SdkInterface)
                ) && 
                (
                    this.SdkUiType == input.SdkUiType ||
                    this.SdkUiType != null &&
                    input.SdkUiType != null &&
                    this.SdkUiType.SequenceEqual(input.SdkUiType)
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
                hashCode = (hashCode * 59) + this.SdkInterface.GetHashCode();
                if (this.SdkUiType != null)
                {
                    hashCode = (hashCode * 59) + this.SdkUiType.GetHashCode();
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
