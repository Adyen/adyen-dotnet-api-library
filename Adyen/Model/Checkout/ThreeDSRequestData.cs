// #region License
// 
//                         ######
//                         ######
//   ############    ####( ######  #####. ######  ############   ############
//   #############  #####( ######  #####. ######  #############  #############
//          ######  #####( ######  #####. ######  #####  ######  #####  ######
//   ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//   ###### ######  #####( ######  #####. ######  #####          #####  ######
//   #############  #############  #############  #############  #####  ######
//    ############   ############  #############   ############  #####  ######
//                                        ######
//                                 #############
//                                 ############
// 
//   Adyen Dotnet API Library
// 
//   Copyright (c) 2022 Adyen N.V.
//   This file is open source and available under the MIT license.
//   See the LICENSE file for more info.
// 
// #endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout
{
   /// <summary>
    /// ThreeDSRequestData
    /// </summary>
    [DataContract]
        public partial class ThreeDSRequestData :  IEquatable<ThreeDSRequestData>, IValidatableObject
    {
        /// <summary>
        /// Should native 3DS be used if possible.
        /// </summary>
        /// <value>Should native 3DS be used if possible.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum NativeThreeDSEnum
        {
            /// <summary>
            /// Enum Preferred for value: preferred
            /// </summary>
            [EnumMember(Value = "preferred")]
            Preferred = 1        }
        /// <summary>
        /// Should native 3DS be used if possible.
        /// </summary>
        /// <value>Should native 3DS be used if possible.</value>
        [DataMember(Name="nativeThreeDS", EmitDefaultValue=false)]
        public NativeThreeDSEnum? NativeThreeDS { get; set; }
        /// <summary>
        /// Which version of 3DS should be used.
        /// </summary>
        /// <value>Which version of 3DS should be used.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ThreeDSVersionEnum
        {
            /// <summary>
            /// Enum _102 for value: V_1_0_2
            /// </summary>
            [EnumMember(Value = "V_1_0_2")]
            _102 = 1,
            /// <summary>
            /// Enum _210 for value: V_2_1_0
            /// </summary>
            [EnumMember(Value = "V_2_1_0")]
            _210 = 2,
            /// <summary>
            /// Enum _220 for value: V_2_2_0
            /// </summary>
            [EnumMember(Value = "V_2_2_0")]
            _220 = 3        }
        /// <summary>
        /// Which version of 3DS should be used.
        /// </summary>
        /// <value>Which version of 3DS should be used.</value>
        [DataMember(Name="threeDSVersion", EmitDefaultValue=false)]
        public ThreeDSVersionEnum? ThreeDSVersion { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDSRequestData" /> class.
        /// </summary>
        /// <param name="nativeThreeDS">Should native 3DS be used if possible..</param>
        /// <param name="threeDSVersion">Which version of 3DS should be used..</param>
        public ThreeDSRequestData(NativeThreeDSEnum? nativeThreeDS = default(NativeThreeDSEnum?), ThreeDSVersionEnum? threeDSVersion = default(ThreeDSVersionEnum?))
        {
            this.NativeThreeDS = nativeThreeDS;
            this.ThreeDSVersion = threeDSVersion;
        }
        


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThreeDSRequestData {\n");
            sb.Append("  NativeThreeDS: ").Append(NativeThreeDS).Append("\n");
            sb.Append("  ThreeDSVersion: ").Append(ThreeDSVersion).Append("\n");
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
            return this.Equals(input as ThreeDSRequestData);
        }

        /// <summary>
        /// Returns true if ThreeDSRequestData instances are equal
        /// </summary>
        /// <param name="input">Instance of ThreeDSRequestData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThreeDSRequestData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NativeThreeDS == input.NativeThreeDS ||
                    (this.NativeThreeDS != null &&
                    this.NativeThreeDS.Equals(input.NativeThreeDS))
                ) && 
                (
                    this.ThreeDSVersion == input.ThreeDSVersion ||
                    (this.ThreeDSVersion != null &&
                    this.ThreeDSVersion.Equals(input.ThreeDSVersion))
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
                if (this.NativeThreeDS != null)
                    hashCode = hashCode * 59 + this.NativeThreeDS.GetHashCode();
                if (this.ThreeDSVersion != null)
                    hashCode = hashCode * 59 + this.ThreeDSVersion.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}