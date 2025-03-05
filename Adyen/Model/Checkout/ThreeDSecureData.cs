/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 71
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
    /// ThreeDSecureData
    /// </summary>
    [DataContract(Name = "ThreeDSecureData")]
    public partial class ThreeDSecureData : IEquatable<ThreeDSecureData>, IValidatableObject
    {
        /// <summary>
        /// In 3D Secure 2, this is the &#x60;transStatus&#x60; from the challenge result. If the transaction was frictionless, omit this parameter.  
        /// </summary>
        /// <value>In 3D Secure 2, this is the &#x60;transStatus&#x60; from the challenge result. If the transaction was frictionless, omit this parameter.  </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthenticationResponseEnum
        {
            /// <summary>
            /// Enum Y for value: Y
            /// </summary>
            [EnumMember(Value = "Y")]
            Y = 1,

            /// <summary>
            /// Enum N for value: N
            /// </summary>
            [EnumMember(Value = "N")]
            N = 2,

            /// <summary>
            /// Enum U for value: U
            /// </summary>
            [EnumMember(Value = "U")]
            U = 3,

            /// <summary>
            /// Enum A for value: A
            /// </summary>
            [EnumMember(Value = "A")]
            A = 4

        }


        /// <summary>
        /// In 3D Secure 2, this is the &#x60;transStatus&#x60; from the challenge result. If the transaction was frictionless, omit this parameter.  
        /// </summary>
        /// <value>In 3D Secure 2, this is the &#x60;transStatus&#x60; from the challenge result. If the transaction was frictionless, omit this parameter.  </value>
        [DataMember(Name = "authenticationResponse", EmitDefaultValue = false)]
        public AuthenticationResponseEnum? AuthenticationResponse { get; set; }
        /// <summary>
        /// Indicator informing the Access Control Server (ACS) and the Directory Server (DS) that the authentication has been cancelled. For possible values, refer to [3D Secure API reference](https://docs.adyen.com/online-payments/3d-secure/api-reference#mpidata).
        /// </summary>
        /// <value>Indicator informing the Access Control Server (ACS) and the Directory Server (DS) that the authentication has been cancelled. For possible values, refer to [3D Secure API reference](https://docs.adyen.com/online-payments/3d-secure/api-reference#mpidata).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChallengeCancelEnum
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
            _04 = 4,

            /// <summary>
            /// Enum _05 for value: 05
            /// </summary>
            [EnumMember(Value = "05")]
            _05 = 5,

            /// <summary>
            /// Enum _06 for value: 06
            /// </summary>
            [EnumMember(Value = "06")]
            _06 = 6,

            /// <summary>
            /// Enum _07 for value: 07
            /// </summary>
            [EnumMember(Value = "07")]
            _07 = 7

        }


        /// <summary>
        /// Indicator informing the Access Control Server (ACS) and the Directory Server (DS) that the authentication has been cancelled. For possible values, refer to [3D Secure API reference](https://docs.adyen.com/online-payments/3d-secure/api-reference#mpidata).
        /// </summary>
        /// <value>Indicator informing the Access Control Server (ACS) and the Directory Server (DS) that the authentication has been cancelled. For possible values, refer to [3D Secure API reference](https://docs.adyen.com/online-payments/3d-secure/api-reference#mpidata).</value>
        [DataMember(Name = "challengeCancel", EmitDefaultValue = false)]
        public ChallengeCancelEnum? ChallengeCancel { get; set; }
        /// <summary>
        /// In 3D Secure 2, this is the &#x60;transStatus&#x60; from the &#x60;ARes&#x60;.  
        /// </summary>
        /// <value>In 3D Secure 2, this is the &#x60;transStatus&#x60; from the &#x60;ARes&#x60;.  </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DirectoryResponseEnum
        {
            /// <summary>
            /// Enum A for value: A
            /// </summary>
            [EnumMember(Value = "A")]
            A = 1,

            /// <summary>
            /// Enum C for value: C
            /// </summary>
            [EnumMember(Value = "C")]
            C = 2,

            /// <summary>
            /// Enum D for value: D
            /// </summary>
            [EnumMember(Value = "D")]
            D = 3,

            /// <summary>
            /// Enum I for value: I
            /// </summary>
            [EnumMember(Value = "I")]
            I = 4,

            /// <summary>
            /// Enum N for value: N
            /// </summary>
            [EnumMember(Value = "N")]
            N = 5,

            /// <summary>
            /// Enum R for value: R
            /// </summary>
            [EnumMember(Value = "R")]
            R = 6,

            /// <summary>
            /// Enum U for value: U
            /// </summary>
            [EnumMember(Value = "U")]
            U = 7,

            /// <summary>
            /// Enum Y for value: Y
            /// </summary>
            [EnumMember(Value = "Y")]
            Y = 8

        }


        /// <summary>
        /// In 3D Secure 2, this is the &#x60;transStatus&#x60; from the &#x60;ARes&#x60;.  
        /// </summary>
        /// <value>In 3D Secure 2, this is the &#x60;transStatus&#x60; from the &#x60;ARes&#x60;.  </value>
        [DataMember(Name = "directoryResponse", EmitDefaultValue = false)]
        public DirectoryResponseEnum? DirectoryResponse { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDSecureData" /> class.
        /// </summary>
        /// <param name="authenticationResponse">In 3D Secure 2, this is the &#x60;transStatus&#x60; from the challenge result. If the transaction was frictionless, omit this parameter.  .</param>
        /// <param name="cavv">The cardholder authentication value (base64 encoded, 20 bytes in a decoded form)..</param>
        /// <param name="cavvAlgorithm">The CAVV algorithm used. Include this only for 3D Secure 1..</param>
        /// <param name="challengeCancel">Indicator informing the Access Control Server (ACS) and the Directory Server (DS) that the authentication has been cancelled. For possible values, refer to [3D Secure API reference](https://docs.adyen.com/online-payments/3d-secure/api-reference#mpidata)..</param>
        /// <param name="directoryResponse">In 3D Secure 2, this is the &#x60;transStatus&#x60; from the &#x60;ARes&#x60;.  .</param>
        /// <param name="dsTransID">Supported for 3D Secure 2. The unique transaction identifier assigned by the Directory Server (DS) to identify a single transaction..</param>
        /// <param name="eci">The electronic commerce indicator..</param>
        /// <param name="riskScore">Risk score calculated by Directory Server (DS). Required for Cartes Bancaires integrations..</param>
        /// <param name="threeDSVersion">The version of the 3D Secure protocol..</param>
        /// <param name="tokenAuthenticationVerificationValue">Network token authentication verification value (TAVV). The network token cryptogram..</param>
        /// <param name="transStatusReason">Provides information on why the &#x60;transStatus&#x60; field has the specified value. For possible values, refer to [our docs](https://docs.adyen.com/online-payments/3d-secure/api-reference#possible-transstatusreason-values)..</param>
        /// <param name="xid">Supported for 3D Secure 1. The transaction identifier (Base64-encoded, 20 bytes in a decoded form)..</param>
        public ThreeDSecureData(AuthenticationResponseEnum? authenticationResponse = default(AuthenticationResponseEnum?), byte[] cavv = default(byte[]), string cavvAlgorithm = default(string), ChallengeCancelEnum? challengeCancel = default(ChallengeCancelEnum?), DirectoryResponseEnum? directoryResponse = default(DirectoryResponseEnum?), string dsTransID = default(string), string eci = default(string), string riskScore = default(string), string threeDSVersion = default(string), byte[] tokenAuthenticationVerificationValue = default(byte[]), string transStatusReason = default(string), byte[] xid = default(byte[]))
        {
            this.AuthenticationResponse = authenticationResponse;
            this.Cavv = cavv;
            this.CavvAlgorithm = cavvAlgorithm;
            this.ChallengeCancel = challengeCancel;
            this.DirectoryResponse = directoryResponse;
            this.DsTransID = dsTransID;
            this.Eci = eci;
            this.RiskScore = riskScore;
            this.ThreeDSVersion = threeDSVersion;
            this.TokenAuthenticationVerificationValue = tokenAuthenticationVerificationValue;
            this.TransStatusReason = transStatusReason;
            this.Xid = xid;
        }

        /// <summary>
        /// The cardholder authentication value (base64 encoded, 20 bytes in a decoded form).
        /// </summary>
        /// <value>The cardholder authentication value (base64 encoded, 20 bytes in a decoded form).</value>
        [DataMember(Name = "cavv", EmitDefaultValue = false)]
        public byte[] Cavv { get; set; }

        /// <summary>
        /// The CAVV algorithm used. Include this only for 3D Secure 1.
        /// </summary>
        /// <value>The CAVV algorithm used. Include this only for 3D Secure 1.</value>
        [DataMember(Name = "cavvAlgorithm", EmitDefaultValue = false)]
        public string CavvAlgorithm { get; set; }

        /// <summary>
        /// Supported for 3D Secure 2. The unique transaction identifier assigned by the Directory Server (DS) to identify a single transaction.
        /// </summary>
        /// <value>Supported for 3D Secure 2. The unique transaction identifier assigned by the Directory Server (DS) to identify a single transaction.</value>
        [DataMember(Name = "dsTransID", EmitDefaultValue = false)]
        public string DsTransID { get; set; }

        /// <summary>
        /// The electronic commerce indicator.
        /// </summary>
        /// <value>The electronic commerce indicator.</value>
        [DataMember(Name = "eci", EmitDefaultValue = false)]
        public string Eci { get; set; }

        /// <summary>
        /// Risk score calculated by Directory Server (DS). Required for Cartes Bancaires integrations.
        /// </summary>
        /// <value>Risk score calculated by Directory Server (DS). Required for Cartes Bancaires integrations.</value>
        [DataMember(Name = "riskScore", EmitDefaultValue = false)]
        public string RiskScore { get; set; }

        /// <summary>
        /// The version of the 3D Secure protocol.
        /// </summary>
        /// <value>The version of the 3D Secure protocol.</value>
        [DataMember(Name = "threeDSVersion", EmitDefaultValue = false)]
        public string ThreeDSVersion { get; set; }

        /// <summary>
        /// Network token authentication verification value (TAVV). The network token cryptogram.
        /// </summary>
        /// <value>Network token authentication verification value (TAVV). The network token cryptogram.</value>
        [DataMember(Name = "tokenAuthenticationVerificationValue", EmitDefaultValue = false)]
        public byte[] TokenAuthenticationVerificationValue { get; set; }

        /// <summary>
        /// Provides information on why the &#x60;transStatus&#x60; field has the specified value. For possible values, refer to [our docs](https://docs.adyen.com/online-payments/3d-secure/api-reference#possible-transstatusreason-values).
        /// </summary>
        /// <value>Provides information on why the &#x60;transStatus&#x60; field has the specified value. For possible values, refer to [our docs](https://docs.adyen.com/online-payments/3d-secure/api-reference#possible-transstatusreason-values).</value>
        [DataMember(Name = "transStatusReason", EmitDefaultValue = false)]
        public string TransStatusReason { get; set; }

        /// <summary>
        /// Supported for 3D Secure 1. The transaction identifier (Base64-encoded, 20 bytes in a decoded form).
        /// </summary>
        /// <value>Supported for 3D Secure 1. The transaction identifier (Base64-encoded, 20 bytes in a decoded form).</value>
        [DataMember(Name = "xid", EmitDefaultValue = false)]
        public byte[] Xid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ThreeDSecureData {\n");
            sb.Append("  AuthenticationResponse: ").Append(AuthenticationResponse).Append("\n");
            sb.Append("  Cavv: ").Append(Cavv).Append("\n");
            sb.Append("  CavvAlgorithm: ").Append(CavvAlgorithm).Append("\n");
            sb.Append("  ChallengeCancel: ").Append(ChallengeCancel).Append("\n");
            sb.Append("  DirectoryResponse: ").Append(DirectoryResponse).Append("\n");
            sb.Append("  DsTransID: ").Append(DsTransID).Append("\n");
            sb.Append("  Eci: ").Append(Eci).Append("\n");
            sb.Append("  RiskScore: ").Append(RiskScore).Append("\n");
            sb.Append("  ThreeDSVersion: ").Append(ThreeDSVersion).Append("\n");
            sb.Append("  TokenAuthenticationVerificationValue: ").Append(TokenAuthenticationVerificationValue).Append("\n");
            sb.Append("  TransStatusReason: ").Append(TransStatusReason).Append("\n");
            sb.Append("  Xid: ").Append(Xid).Append("\n");
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
            return this.Equals(input as ThreeDSecureData);
        }

        /// <summary>
        /// Returns true if ThreeDSecureData instances are equal
        /// </summary>
        /// <param name="input">Instance of ThreeDSecureData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThreeDSecureData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuthenticationResponse == input.AuthenticationResponse ||
                    this.AuthenticationResponse.Equals(input.AuthenticationResponse)
                ) && 
                (
                    this.Cavv == input.Cavv ||
                    (this.Cavv != null &&
                    this.Cavv.Equals(input.Cavv))
                ) && 
                (
                    this.CavvAlgorithm == input.CavvAlgorithm ||
                    (this.CavvAlgorithm != null &&
                    this.CavvAlgorithm.Equals(input.CavvAlgorithm))
                ) && 
                (
                    this.ChallengeCancel == input.ChallengeCancel ||
                    this.ChallengeCancel.Equals(input.ChallengeCancel)
                ) && 
                (
                    this.DirectoryResponse == input.DirectoryResponse ||
                    this.DirectoryResponse.Equals(input.DirectoryResponse)
                ) && 
                (
                    this.DsTransID == input.DsTransID ||
                    (this.DsTransID != null &&
                    this.DsTransID.Equals(input.DsTransID))
                ) && 
                (
                    this.Eci == input.Eci ||
                    (this.Eci != null &&
                    this.Eci.Equals(input.Eci))
                ) && 
                (
                    this.RiskScore == input.RiskScore ||
                    (this.RiskScore != null &&
                    this.RiskScore.Equals(input.RiskScore))
                ) && 
                (
                    this.ThreeDSVersion == input.ThreeDSVersion ||
                    (this.ThreeDSVersion != null &&
                    this.ThreeDSVersion.Equals(input.ThreeDSVersion))
                ) && 
                (
                    this.TokenAuthenticationVerificationValue == input.TokenAuthenticationVerificationValue ||
                    (this.TokenAuthenticationVerificationValue != null &&
                    this.TokenAuthenticationVerificationValue.Equals(input.TokenAuthenticationVerificationValue))
                ) && 
                (
                    this.TransStatusReason == input.TransStatusReason ||
                    (this.TransStatusReason != null &&
                    this.TransStatusReason.Equals(input.TransStatusReason))
                ) && 
                (
                    this.Xid == input.Xid ||
                    (this.Xid != null &&
                    this.Xid.Equals(input.Xid))
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
                hashCode = (hashCode * 59) + this.AuthenticationResponse.GetHashCode();
                if (this.Cavv != null)
                {
                    hashCode = (hashCode * 59) + this.Cavv.GetHashCode();
                }
                if (this.CavvAlgorithm != null)
                {
                    hashCode = (hashCode * 59) + this.CavvAlgorithm.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ChallengeCancel.GetHashCode();
                hashCode = (hashCode * 59) + this.DirectoryResponse.GetHashCode();
                if (this.DsTransID != null)
                {
                    hashCode = (hashCode * 59) + this.DsTransID.GetHashCode();
                }
                if (this.Eci != null)
                {
                    hashCode = (hashCode * 59) + this.Eci.GetHashCode();
                }
                if (this.RiskScore != null)
                {
                    hashCode = (hashCode * 59) + this.RiskScore.GetHashCode();
                }
                if (this.ThreeDSVersion != null)
                {
                    hashCode = (hashCode * 59) + this.ThreeDSVersion.GetHashCode();
                }
                if (this.TokenAuthenticationVerificationValue != null)
                {
                    hashCode = (hashCode * 59) + this.TokenAuthenticationVerificationValue.GetHashCode();
                }
                if (this.TransStatusReason != null)
                {
                    hashCode = (hashCode * 59) + this.TransStatusReason.GetHashCode();
                }
                if (this.Xid != null)
                {
                    hashCode = (hashCode * 59) + this.Xid.GetHashCode();
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
