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
//   Copyright (c) 2021 Adyen B.V.
//   This file is open source and available under the MIT license.
//   See the LICENSE file for more info.
// 
// #endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// ThreeDSRequestorPriorAuthenticationInfo
    /// </summary>
    [DataContract]
        public partial class ThreeDSRequestorPriorAuthenticationInfo :  IEquatable<ThreeDSRequestorPriorAuthenticationInfo>, IValidatableObject
    {
        /// <summary>
        /// Mechanism used by the Cardholder to previously authenticate to the 3DS Requestor. Allowed values: * **01** — Frictionless authentication occurred by ACS. * **02** — Cardholder challenge occurred by ACS. * **03** — AVS verified. * **04** — Other issuer methods.
        /// </summary>
        /// <value>Mechanism used by the Cardholder to previously authenticate to the 3DS Requestor. Allowed values: * **01** — Frictionless authentication occurred by ACS. * **02** — Cardholder challenge occurred by ACS. * **03** — AVS verified. * **04** — Other issuer methods.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ThreeDSReqPriorAuthMethodEnum
        {
            /// <summary>
            /// Enum _01 for value: 01
            /// </summary>
            [EnumMember(Value = "01")]
            _01 = 1,
            /// <summary>
            /// Enum _02 for value: 02
            /// </summary>
            [EnumMember(Value = "02")]
            _02 = 2,
            /// <summary>
            /// Enum _03 for value: 03
            /// </summary>
            [EnumMember(Value = "03")]
            _03 = 3,
            /// <summary>
            /// Enum _04 for value: 04
            /// </summary>
            [EnumMember(Value = "04")]
            _04 = 4        }
        /// <summary>
        /// Mechanism used by the Cardholder to previously authenticate to the 3DS Requestor. Allowed values: * **01** — Frictionless authentication occurred by ACS. * **02** — Cardholder challenge occurred by ACS. * **03** — AVS verified. * **04** — Other issuer methods.
        /// </summary>
        /// <value>Mechanism used by the Cardholder to previously authenticate to the 3DS Requestor. Allowed values: * **01** — Frictionless authentication occurred by ACS. * **02** — Cardholder challenge occurred by ACS. * **03** — AVS verified. * **04** — Other issuer methods.</value>
        [DataMember(Name="threeDSReqPriorAuthMethod", EmitDefaultValue=false)]
        public ThreeDSReqPriorAuthMethodEnum? ThreeDSReqPriorAuthMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDSRequestorPriorAuthenticationInfo" /> class.
        /// </summary>
        /// <param name="threeDSReqPriorAuthData">Data that documents and supports a specific authentication process. Maximum length: 2048 bytes..</param>
        /// <param name="threeDSReqPriorAuthMethod">Mechanism used by the Cardholder to previously authenticate to the 3DS Requestor. Allowed values: * **01** — Frictionless authentication occurred by ACS. * **02** — Cardholder challenge occurred by ACS. * **03** — AVS verified. * **04** — Other issuer methods..</param>
        /// <param name="threeDSReqPriorAuthTimestamp">Date and time in UTC of the prior cardholder authentication. Format: YYYYMMDDHHMM.</param>
        /// <param name="threeDSReqPriorRef">This data element provides additional information to the ACS to determine the best approach for handing a request. This data element contains an ACS Transaction ID for a prior authenticated transaction. For example, the first recurring transaction that was authenticated with the cardholder. Length: 30 characters..</param>
        public ThreeDSRequestorPriorAuthenticationInfo(string threeDSReqPriorAuthData = default(string), ThreeDSReqPriorAuthMethodEnum? threeDSReqPriorAuthMethod = default(ThreeDSReqPriorAuthMethodEnum?), string threeDSReqPriorAuthTimestamp = default(string), string threeDSReqPriorRef = default(string))
        {
            this.ThreeDSReqPriorAuthData = threeDSReqPriorAuthData;
            this.ThreeDSReqPriorAuthMethod = threeDSReqPriorAuthMethod;
            this.ThreeDSReqPriorAuthTimestamp = threeDSReqPriorAuthTimestamp;
            this.ThreeDSReqPriorRef = threeDSReqPriorRef;
        }
        
        /// <summary>
        /// Data that documents and supports a specific authentication process. Maximum length: 2048 bytes.
        /// </summary>
        /// <value>Data that documents and supports a specific authentication process. Maximum length: 2048 bytes.</value>
        [DataMember(Name="threeDSReqPriorAuthData", EmitDefaultValue=false)]
        public string ThreeDSReqPriorAuthData { get; set; }


        /// <summary>
        /// Date and time in UTC of the prior cardholder authentication. Format: YYYYMMDDHHMM
        /// </summary>
        /// <value>Date and time in UTC of the prior cardholder authentication. Format: YYYYMMDDHHMM</value>
        [DataMember(Name="threeDSReqPriorAuthTimestamp", EmitDefaultValue=false)]
        public string ThreeDSReqPriorAuthTimestamp { get; set; }

        /// <summary>
        /// This data element provides additional information to the ACS to determine the best approach for handing a request. This data element contains an ACS Transaction ID for a prior authenticated transaction. For example, the first recurring transaction that was authenticated with the cardholder. Length: 30 characters.
        /// </summary>
        /// <value>This data element provides additional information to the ACS to determine the best approach for handing a request. This data element contains an ACS Transaction ID for a prior authenticated transaction. For example, the first recurring transaction that was authenticated with the cardholder. Length: 30 characters.</value>
        [DataMember(Name="threeDSReqPriorRef", EmitDefaultValue=false)]
        public string ThreeDSReqPriorRef { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThreeDSRequestorPriorAuthenticationInfo {\n");
            sb.Append("  ThreeDSReqPriorAuthData: ").Append(ThreeDSReqPriorAuthData).Append("\n");
            sb.Append("  ThreeDSReqPriorAuthMethod: ").Append(ThreeDSReqPriorAuthMethod).Append("\n");
            sb.Append("  ThreeDSReqPriorAuthTimestamp: ").Append(ThreeDSReqPriorAuthTimestamp).Append("\n");
            sb.Append("  ThreeDSReqPriorRef: ").Append(ThreeDSReqPriorRef).Append("\n");
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
            return this.Equals(input as ThreeDSRequestorPriorAuthenticationInfo);
        }

        /// <summary>
        /// Returns true if ThreeDSRequestorPriorAuthenticationInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ThreeDSRequestorPriorAuthenticationInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThreeDSRequestorPriorAuthenticationInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ThreeDSReqPriorAuthData == input.ThreeDSReqPriorAuthData ||
                    (this.ThreeDSReqPriorAuthData != null &&
                    this.ThreeDSReqPriorAuthData.Equals(input.ThreeDSReqPriorAuthData))
                ) && 
                (
                    this.ThreeDSReqPriorAuthMethod == input.ThreeDSReqPriorAuthMethod ||
                    (this.ThreeDSReqPriorAuthMethod != null &&
                    this.ThreeDSReqPriorAuthMethod.Equals(input.ThreeDSReqPriorAuthMethod))
                ) && 
                (
                    this.ThreeDSReqPriorAuthTimestamp == input.ThreeDSReqPriorAuthTimestamp ||
                    (this.ThreeDSReqPriorAuthTimestamp != null &&
                    this.ThreeDSReqPriorAuthTimestamp.Equals(input.ThreeDSReqPriorAuthTimestamp))
                ) && 
                (
                    this.ThreeDSReqPriorRef == input.ThreeDSReqPriorRef ||
                    (this.ThreeDSReqPriorRef != null &&
                    this.ThreeDSReqPriorRef.Equals(input.ThreeDSReqPriorRef))
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
                if (this.ThreeDSReqPriorAuthData != null)
                    hashCode = hashCode * 59 + this.ThreeDSReqPriorAuthData.GetHashCode();
                if (this.ThreeDSReqPriorAuthMethod != null)
                    hashCode = hashCode * 59 + this.ThreeDSReqPriorAuthMethod.GetHashCode();
                if (this.ThreeDSReqPriorAuthTimestamp != null)
                    hashCode = hashCode * 59 + this.ThreeDSReqPriorAuthTimestamp.GetHashCode();
                if (this.ThreeDSReqPriorRef != null)
                    hashCode = hashCode * 59 + this.ThreeDSReqPriorRef.GetHashCode();
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