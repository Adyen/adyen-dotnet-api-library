#region Licence

// 
//                        ######
//                        ######
//  ############    ####( ######  #####. ######  ############   ############
//  #############  #####( ######  #####. ######  #############  #############
//         ######  #####( ######  #####. ######  #####  ######  #####  ######
//  ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  ###### ######  #####( ######  #####. ######  #####          #####  ######
//  #############  #############  #############  #############  #####  ######
//   ############   ############  #############   ############  #####  ######
//                                       ######
//                                #############
//                                ############
// 
//  Adyen Dotnet API Library
// 
//  Copyright (c) 2020 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.

#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Adyen.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// DeviceRenderOptions
    /// </summary>
    [DataContract]
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
            [EnumMember(Value = "native")] Native = 1,

            /// <summary>
            /// Enum Html for value: html
            /// </summary>
            [EnumMember(Value = "html")] Html = 2,

            /// <summary>
            /// Enum Both for value: both
            /// </summary>
            [EnumMember(Value = "both")] Both = 3
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
            [EnumMember(Value = "multiSelect")] MultiSelect = 1,

            /// <summary>
            /// Enum OtherHtml for value: otherHtml
            /// </summary>
            [EnumMember(Value = "otherHtml")] OtherHtml = 2,

            /// <summary>
            /// Enum OutOfBand for value: outOfBand
            /// </summary>
            [EnumMember(Value = "outOfBand")] OutOfBand = 3,

            /// <summary>
            /// Enum SingleSelect for value: singleSelect
            /// </summary>
            [EnumMember(Value = "singleSelect")] SingleSelect = 4,

            /// <summary>
            /// Enum Text for value: text
            /// </summary>
            [EnumMember(Value = "text")] Text = 5
        }

        /// <summary>
        /// UI types supported for displaying specific challenges. Allowed values: * text * singleSelect * outOfBand * otherHtml * multiSelect
        /// </summary>
        /// <value>UI types supported for displaying specific challenges. Allowed values: * text * singleSelect * outOfBand * otherHtml * multiSelect</value>
        [DataMember(Name = "sdkUiType", EmitDefaultValue = false)]
        public List<SdkUiTypeEnum> SdkUiType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceRenderOptions" /> class.
        /// </summary>
        /// <param name="sdkInterface">Supported SDK interface types. Allowed values: * native * html * both (default to SdkInterfaceEnum.Both).</param>
        /// <param name="sdkUiType">UI types supported for displaying specific challenges. Allowed values: * text * singleSelect * outOfBand * otherHtml * multiSelect.</param>
        public DeviceRenderOptions(SdkInterfaceEnum? sdkInterface = SdkInterfaceEnum.Both,
            List<SdkUiTypeEnum> sdkUiType = default(List<SdkUiTypeEnum>))
        {
            // use default value if no "sdkInterface" provided
            if (sdkInterface == null)
            {
                this.SdkInterface = SdkInterfaceEnum.Both;
            }
            else
            {
                this.SdkInterface = sdkInterface;
            }
            this.SdkUiType = sdkUiType;
        }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceRenderOptions {\n");
            sb.Append("  SdkInterface: ").Append(SdkInterface).Append("\n");
            sb.Append("  SdkUiType: ").Append(SdkUiType.ObjectListToString()).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
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
                return false;

            return
                (
                    this.SdkInterface == input.SdkInterface ||
                    this.SdkInterface != null &&
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
                if (this.SdkInterface != null)
                    hashCode = hashCode * 59 + this.SdkInterface.GetHashCode();
                if (this.SdkUiType != null)
                    hashCode = hashCode * 59 + this.SdkUiType.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(
            ValidationContext validationContext)
        {
            yield break;
        }
    }
}