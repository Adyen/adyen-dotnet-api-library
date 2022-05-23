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
    /// AuthenticationData
    /// </summary>
    [DataContract]
        public partial class AuthenticationData :  IEquatable<AuthenticationData>, IValidatableObject
    {
        /// <summary>
        /// Should perfrom 3DS. Overwrites all the rules like Dynamic3DS, Transaction Rules and ABG.
        /// </summary>
        /// <value>Should perfrom 3DS. Overwrites all the rules like Dynamic3DS, Transaction Rules and ABG.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum AttemptAuthenticationEnum
        {
            /// <summary>
            /// Enum Always for value: always
            /// </summary>
            [EnumMember(Value = "always")]
            Always = 1,
            /// <summary>
            /// Enum Never for value: never
            /// </summary>
            [EnumMember(Value = "never")]
            Never = 2,
            /// <summary>
            /// Enum PreferNo for value: preferNo
            /// </summary>
            [EnumMember(Value = "preferNo")]
            PreferNo = 3        }
        /// <summary>
        /// Should perfrom 3DS. Overwrites all the rules like Dynamic3DS, Transaction Rules and ABG.
        /// </summary>
        /// <value>Should perfrom 3DS. Overwrites all the rules like Dynamic3DS, Transaction Rules and ABG.</value>
        [DataMember(Name="attemptAuthentication", EmitDefaultValue=false)]
        public AttemptAuthenticationEnum? AttemptAuthentication { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationData" /> class.
        /// </summary>
        /// <param name="attemptAuthentication">Should perfrom 3DS. Overwrites all the rules like Dynamic3DS, Transaction Rules and ABG..</param>
        /// <param name="authenticationOnly">Should perform authentication without authorization..</param>
        /// <param name="threeDSRequestData">threeDSRequestData.</param>
        public AuthenticationData(AttemptAuthenticationEnum? attemptAuthentication = default(AttemptAuthenticationEnum?), bool? authenticationOnly = default(bool?), ThreeDSRequestData threeDSRequestData = default(ThreeDSRequestData))
        {
            this.AttemptAuthentication = attemptAuthentication;
            this.AuthenticationOnly = authenticationOnly;
            this.ThreeDSRequestData = threeDSRequestData;
        }
        

        /// <summary>
        /// Should perform authentication without authorization.
        /// </summary>
        /// <value>Should perform authentication without authorization.</value>
        [DataMember(Name="authenticationOnly", EmitDefaultValue=false)]
        public bool? AuthenticationOnly { get; set; }

        /// <summary>
        /// Gets or Sets ThreeDSRequestData
        /// </summary>
        [DataMember(Name="threeDSRequestData", EmitDefaultValue=false)]
        public ThreeDSRequestData ThreeDSRequestData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthenticationData {\n");
            sb.Append("  AttemptAuthentication: ").Append(AttemptAuthentication).Append("\n");
            sb.Append("  AuthenticationOnly: ").Append(AuthenticationOnly).Append("\n");
            sb.Append("  ThreeDSRequestData: ").Append(ThreeDSRequestData).Append("\n");
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
            return this.Equals(input as AuthenticationData);
        }

        /// <summary>
        /// Returns true if AuthenticationData instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthenticationData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthenticationData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AttemptAuthentication == input.AttemptAuthentication ||
                    (this.AttemptAuthentication != null &&
                    this.AttemptAuthentication.Equals(input.AttemptAuthentication))
                ) && 
                (
                    this.AuthenticationOnly == input.AuthenticationOnly ||
                    (this.AuthenticationOnly != null &&
                    this.AuthenticationOnly.Equals(input.AuthenticationOnly))
                ) && 
                (
                    this.ThreeDSRequestData == input.ThreeDSRequestData ||
                    (this.ThreeDSRequestData != null &&
                    this.ThreeDSRequestData.Equals(input.ThreeDSRequestData))
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
                if (this.AttemptAuthentication != null)
                    hashCode = hashCode * 59 + this.AttemptAuthentication.GetHashCode();
                if (this.AuthenticationOnly != null)
                    hashCode = hashCode * 59 + this.AuthenticationOnly.GetHashCode();
                if (this.ThreeDSRequestData != null)
                    hashCode = hashCode * 59 + this.ThreeDSRequestData.GetHashCode();
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