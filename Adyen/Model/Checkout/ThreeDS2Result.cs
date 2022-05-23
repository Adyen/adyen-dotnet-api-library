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
    /// ThreeDS2Result
    /// </summary>
    [DataContract]
        public partial class ThreeDS2Result :  IEquatable<ThreeDS2Result>, IValidatableObject
    {
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
            _07 = 7        }
        /// <summary>
        /// Indicator informing the Access Control Server (ACS) and the Directory Server (DS) that the authentication has been cancelled. For possible values, refer to [3D Secure API reference](https://docs.adyen.com/online-payments/3d-secure/api-reference#mpidata).
        /// </summary>
        /// <value>Indicator informing the Access Control Server (ACS) and the Directory Server (DS) that the authentication has been cancelled. For possible values, refer to [3D Secure API reference](https://docs.adyen.com/online-payments/3d-secure/api-reference#mpidata).</value>
        [DataMember(Name="challengeCancel", EmitDefaultValue=false)]
        public ChallengeCancelEnum? ChallengeCancel { get; set; }
        /// <summary>
        /// Specifies a preference for receiving a challenge from the issuer. Allowed values: * &#x60;noPreference&#x60; * &#x60;requestNoChallenge&#x60; * &#x60;requestChallenge&#x60; * &#x60;requestChallengeAsMandate&#x60; 
        /// </summary>
        /// <value>Specifies a preference for receiving a challenge from the issuer. Allowed values: * &#x60;noPreference&#x60; * &#x60;requestNoChallenge&#x60; * &#x60;requestChallenge&#x60; * &#x60;requestChallengeAsMandate&#x60; </value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ChallengeIndicatorEnum
        {
            /// <summary>
            /// Enum NoPreference for value: noPreference
            /// </summary>
            [EnumMember(Value = "noPreference")]
            NoPreference = 1,
            /// <summary>
            /// Enum RequestNoChallenge for value: requestNoChallenge
            /// </summary>
            [EnumMember(Value = "requestNoChallenge")]
            RequestNoChallenge = 2,
            /// <summary>
            /// Enum RequestChallenge for value: requestChallenge
            /// </summary>
            [EnumMember(Value = "requestChallenge")]
            RequestChallenge = 3,
            /// <summary>
            /// Enum RequestChallengeAsMandate for value: requestChallengeAsMandate
            /// </summary>
            [EnumMember(Value = "requestChallengeAsMandate")]
            RequestChallengeAsMandate = 4        }
        /// <summary>
        /// Specifies a preference for receiving a challenge from the issuer. Allowed values: * &#x60;noPreference&#x60; * &#x60;requestNoChallenge&#x60; * &#x60;requestChallenge&#x60; * &#x60;requestChallengeAsMandate&#x60; 
        /// </summary>
        /// <value>Specifies a preference for receiving a challenge from the issuer. Allowed values: * &#x60;noPreference&#x60; * &#x60;requestNoChallenge&#x60; * &#x60;requestChallenge&#x60; * &#x60;requestChallengeAsMandate&#x60; </value>
        [DataMember(Name="challengeIndicator", EmitDefaultValue=false)]
        public ChallengeIndicatorEnum? ChallengeIndicator { get; set; }
        /// <summary>
        /// Indicates the exemption type that was applied by the issuer to the authentication, if exemption applied. Allowed values: * &#x60;lowValue&#x60; * &#x60;secureCorporate&#x60; * &#x60;trustedBeneficiary&#x60; * &#x60;transactionRiskAnalysis&#x60; 
        /// </summary>
        /// <value>Indicates the exemption type that was applied by the issuer to the authentication, if exemption applied. Allowed values: * &#x60;lowValue&#x60; * &#x60;secureCorporate&#x60; * &#x60;trustedBeneficiary&#x60; * &#x60;transactionRiskAnalysis&#x60; </value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ExemptionIndicatorEnum
        {
            /// <summary>
            /// Enum LowValue for value: lowValue
            /// </summary>
            [EnumMember(Value = "lowValue")]
            LowValue = 1,
            /// <summary>
            /// Enum SecureCorporate for value: secureCorporate
            /// </summary>
            [EnumMember(Value = "secureCorporate")]
            SecureCorporate = 2,
            /// <summary>
            /// Enum TrustedBeneficiary for value: trustedBeneficiary
            /// </summary>
            [EnumMember(Value = "trustedBeneficiary")]
            TrustedBeneficiary = 3,
            /// <summary>
            /// Enum TransactionRiskAnalysis for value: transactionRiskAnalysis
            /// </summary>
            [EnumMember(Value = "transactionRiskAnalysis")]
            TransactionRiskAnalysis = 4        }
        /// <summary>
        /// Indicates the exemption type that was applied by the issuer to the authentication, if exemption applied. Allowed values: * &#x60;lowValue&#x60; * &#x60;secureCorporate&#x60; * &#x60;trustedBeneficiary&#x60; * &#x60;transactionRiskAnalysis&#x60; 
        /// </summary>
        /// <value>Indicates the exemption type that was applied by the issuer to the authentication, if exemption applied. Allowed values: * &#x60;lowValue&#x60; * &#x60;secureCorporate&#x60; * &#x60;trustedBeneficiary&#x60; * &#x60;transactionRiskAnalysis&#x60; </value>
        [DataMember(Name="exemptionIndicator", EmitDefaultValue=false)]
        public ExemptionIndicatorEnum? ExemptionIndicator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDS2Result" /> class.
        /// </summary>
        /// <param name="authenticationValue">The &#x60;authenticationValue&#x60; value as defined in the 3D Secure 2 specification..</param>
        /// <param name="cavvAlgorithm">The algorithm used by the ACS to calculate the authentication value, only for Cartes Bancaires integrations..</param>
        /// <param name="challengeCancel">Indicator informing the Access Control Server (ACS) and the Directory Server (DS) that the authentication has been cancelled. For possible values, refer to [3D Secure API reference](https://docs.adyen.com/online-payments/3d-secure/api-reference#mpidata)..</param>
        /// <param name="challengeIndicator">Specifies a preference for receiving a challenge from the issuer. Allowed values: * &#x60;noPreference&#x60; * &#x60;requestNoChallenge&#x60; * &#x60;requestChallenge&#x60; * &#x60;requestChallengeAsMandate&#x60; .</param>
        /// <param name="dsTransID">The &#x60;dsTransID&#x60; value as defined in the 3D Secure 2 specification..</param>
        /// <param name="eci">The &#x60;eci&#x60; value as defined in the 3D Secure 2 specification..</param>
        /// <param name="exemptionIndicator">Indicates the exemption type that was applied by the issuer to the authentication, if exemption applied. Allowed values: * &#x60;lowValue&#x60; * &#x60;secureCorporate&#x60; * &#x60;trustedBeneficiary&#x60; * &#x60;transactionRiskAnalysis&#x60; .</param>
        /// <param name="messageVersion">The &#x60;messageVersion&#x60; value as defined in the 3D Secure 2 specification..</param>
        /// <param name="riskScore">Risk score calculated by Cartes Bancaires Directory Server (DS)..</param>
        /// <param name="threeDSServerTransID">The &#x60;threeDSServerTransID&#x60; value as defined in the 3D Secure 2 specification..</param>
        /// <param name="timestamp">The &#x60;timestamp&#x60; value of the 3D Secure 2 authentication..</param>
        /// <param name="transStatus">The &#x60;transStatus&#x60; value as defined in the 3D Secure 2 specification..</param>
        /// <param name="transStatusReason">Provides information on why the &#x60;transStatus&#x60; field has the specified value. For possible values, refer to [our docs](https://docs.adyen.com/online-payments/3d-secure/api-reference#possible-transstatusreason-values)..</param>
        /// <param name="whiteListStatus">The &#x60;whiteListStatus&#x60; value as defined in the 3D Secure 2 specification..</param>
        public ThreeDS2Result(string authenticationValue = default(string), string cavvAlgorithm = default(string), ChallengeCancelEnum? challengeCancel = default(ChallengeCancelEnum?), ChallengeIndicatorEnum? challengeIndicator = default(ChallengeIndicatorEnum?), string dsTransID = default(string), string eci = default(string), ExemptionIndicatorEnum? exemptionIndicator = default(ExemptionIndicatorEnum?), string messageVersion = default(string), string riskScore = default(string), string threeDSServerTransID = default(string), string timestamp = default(string), string transStatus = default(string), string transStatusReason = default(string), string whiteListStatus = default(string))
        {
            this.AuthenticationValue = authenticationValue;
            this.CavvAlgorithm = cavvAlgorithm;
            this.ChallengeCancel = challengeCancel;
            this.ChallengeIndicator = challengeIndicator;
            this.DsTransID = dsTransID;
            this.Eci = eci;
            this.ExemptionIndicator = exemptionIndicator;
            this.MessageVersion = messageVersion;
            this.RiskScore = riskScore;
            this.ThreeDSServerTransID = threeDSServerTransID;
            this.Timestamp = timestamp;
            this.TransStatus = transStatus;
            this.TransStatusReason = transStatusReason;
            this.WhiteListStatus = whiteListStatus;
        }
        
        /// <summary>
        /// The &#x60;authenticationValue&#x60; value as defined in the 3D Secure 2 specification.
        /// </summary>
        /// <value>The &#x60;authenticationValue&#x60; value as defined in the 3D Secure 2 specification.</value>
        [DataMember(Name="authenticationValue", EmitDefaultValue=false)]
        public string AuthenticationValue { get; set; }

        /// <summary>
        /// The algorithm used by the ACS to calculate the authentication value, only for Cartes Bancaires integrations.
        /// </summary>
        /// <value>The algorithm used by the ACS to calculate the authentication value, only for Cartes Bancaires integrations.</value>
        [DataMember(Name="cavvAlgorithm", EmitDefaultValue=false)]
        public string CavvAlgorithm { get; set; }



        /// <summary>
        /// The &#x60;dsTransID&#x60; value as defined in the 3D Secure 2 specification.
        /// </summary>
        /// <value>The &#x60;dsTransID&#x60; value as defined in the 3D Secure 2 specification.</value>
        [DataMember(Name="dsTransID", EmitDefaultValue=false)]
        public string DsTransID { get; set; }

        /// <summary>
        /// The &#x60;eci&#x60; value as defined in the 3D Secure 2 specification.
        /// </summary>
        /// <value>The &#x60;eci&#x60; value as defined in the 3D Secure 2 specification.</value>
        [DataMember(Name="eci", EmitDefaultValue=false)]
        public string Eci { get; set; }


        /// <summary>
        /// The &#x60;messageVersion&#x60; value as defined in the 3D Secure 2 specification.
        /// </summary>
        /// <value>The &#x60;messageVersion&#x60; value as defined in the 3D Secure 2 specification.</value>
        [DataMember(Name="messageVersion", EmitDefaultValue=false)]
        public string MessageVersion { get; set; }

        /// <summary>
        /// Risk score calculated by Cartes Bancaires Directory Server (DS).
        /// </summary>
        /// <value>Risk score calculated by Cartes Bancaires Directory Server (DS).</value>
        [DataMember(Name="riskScore", EmitDefaultValue=false)]
        public string RiskScore { get; set; }

        /// <summary>
        /// The &#x60;threeDSServerTransID&#x60; value as defined in the 3D Secure 2 specification.
        /// </summary>
        /// <value>The &#x60;threeDSServerTransID&#x60; value as defined in the 3D Secure 2 specification.</value>
        [DataMember(Name="threeDSServerTransID", EmitDefaultValue=false)]
        public string ThreeDSServerTransID { get; set; }

        /// <summary>
        /// The &#x60;timestamp&#x60; value of the 3D Secure 2 authentication.
        /// </summary>
        /// <value>The &#x60;timestamp&#x60; value of the 3D Secure 2 authentication.</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public string Timestamp { get; set; }

        /// <summary>
        /// The &#x60;transStatus&#x60; value as defined in the 3D Secure 2 specification.
        /// </summary>
        /// <value>The &#x60;transStatus&#x60; value as defined in the 3D Secure 2 specification.</value>
        [DataMember(Name="transStatus", EmitDefaultValue=false)]
        public string TransStatus { get; set; }

        /// <summary>
        /// Provides information on why the &#x60;transStatus&#x60; field has the specified value. For possible values, refer to [our docs](https://docs.adyen.com/online-payments/3d-secure/api-reference#possible-transstatusreason-values).
        /// </summary>
        /// <value>Provides information on why the &#x60;transStatus&#x60; field has the specified value. For possible values, refer to [our docs](https://docs.adyen.com/online-payments/3d-secure/api-reference#possible-transstatusreason-values).</value>
        [DataMember(Name="transStatusReason", EmitDefaultValue=false)]
        public string TransStatusReason { get; set; }

        /// <summary>
        /// The &#x60;whiteListStatus&#x60; value as defined in the 3D Secure 2 specification.
        /// </summary>
        /// <value>The &#x60;whiteListStatus&#x60; value as defined in the 3D Secure 2 specification.</value>
        [DataMember(Name="whiteListStatus", EmitDefaultValue=false)]
        public string WhiteListStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThreeDS2Result {\n");
            sb.Append("  AuthenticationValue: ").Append(AuthenticationValue).Append("\n");
            sb.Append("  CavvAlgorithm: ").Append(CavvAlgorithm).Append("\n");
            sb.Append("  ChallengeCancel: ").Append(ChallengeCancel).Append("\n");
            sb.Append("  ChallengeIndicator: ").Append(ChallengeIndicator).Append("\n");
            sb.Append("  DsTransID: ").Append(DsTransID).Append("\n");
            sb.Append("  Eci: ").Append(Eci).Append("\n");
            sb.Append("  ExemptionIndicator: ").Append(ExemptionIndicator).Append("\n");
            sb.Append("  MessageVersion: ").Append(MessageVersion).Append("\n");
            sb.Append("  RiskScore: ").Append(RiskScore).Append("\n");
            sb.Append("  ThreeDSServerTransID: ").Append(ThreeDSServerTransID).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  TransStatus: ").Append(TransStatus).Append("\n");
            sb.Append("  TransStatusReason: ").Append(TransStatusReason).Append("\n");
            sb.Append("  WhiteListStatus: ").Append(WhiteListStatus).Append("\n");
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
            return this.Equals(input as ThreeDS2Result);
        }

        /// <summary>
        /// Returns true if ThreeDS2Result instances are equal
        /// </summary>
        /// <param name="input">Instance of ThreeDS2Result to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThreeDS2Result input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthenticationValue == input.AuthenticationValue ||
                    (this.AuthenticationValue != null &&
                    this.AuthenticationValue.Equals(input.AuthenticationValue))
                ) && 
                (
                    this.CavvAlgorithm == input.CavvAlgorithm ||
                    (this.CavvAlgorithm != null &&
                    this.CavvAlgorithm.Equals(input.CavvAlgorithm))
                ) && 
                (
                    this.ChallengeCancel == input.ChallengeCancel ||
                    (this.ChallengeCancel != null &&
                    this.ChallengeCancel.Equals(input.ChallengeCancel))
                ) && 
                (
                    this.ChallengeIndicator == input.ChallengeIndicator ||
                    (this.ChallengeIndicator != null &&
                    this.ChallengeIndicator.Equals(input.ChallengeIndicator))
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
                    this.ExemptionIndicator == input.ExemptionIndicator ||
                    (this.ExemptionIndicator != null &&
                    this.ExemptionIndicator.Equals(input.ExemptionIndicator))
                ) && 
                (
                    this.MessageVersion == input.MessageVersion ||
                    (this.MessageVersion != null &&
                    this.MessageVersion.Equals(input.MessageVersion))
                ) && 
                (
                    this.RiskScore == input.RiskScore ||
                    (this.RiskScore != null &&
                    this.RiskScore.Equals(input.RiskScore))
                ) && 
                (
                    this.ThreeDSServerTransID == input.ThreeDSServerTransID ||
                    (this.ThreeDSServerTransID != null &&
                    this.ThreeDSServerTransID.Equals(input.ThreeDSServerTransID))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.TransStatus == input.TransStatus ||
                    (this.TransStatus != null &&
                    this.TransStatus.Equals(input.TransStatus))
                ) && 
                (
                    this.TransStatusReason == input.TransStatusReason ||
                    (this.TransStatusReason != null &&
                    this.TransStatusReason.Equals(input.TransStatusReason))
                ) && 
                (
                    this.WhiteListStatus == input.WhiteListStatus ||
                    (this.WhiteListStatus != null &&
                    this.WhiteListStatus.Equals(input.WhiteListStatus))
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
                if (this.AuthenticationValue != null)
                    hashCode = hashCode * 59 + this.AuthenticationValue.GetHashCode();
                if (this.CavvAlgorithm != null)
                    hashCode = hashCode * 59 + this.CavvAlgorithm.GetHashCode();
                if (this.ChallengeCancel != null)
                    hashCode = hashCode * 59 + this.ChallengeCancel.GetHashCode();
                if (this.ChallengeIndicator != null)
                    hashCode = hashCode * 59 + this.ChallengeIndicator.GetHashCode();
                if (this.DsTransID != null)
                    hashCode = hashCode * 59 + this.DsTransID.GetHashCode();
                if (this.Eci != null)
                    hashCode = hashCode * 59 + this.Eci.GetHashCode();
                if (this.ExemptionIndicator != null)
                    hashCode = hashCode * 59 + this.ExemptionIndicator.GetHashCode();
                if (this.MessageVersion != null)
                    hashCode = hashCode * 59 + this.MessageVersion.GetHashCode();
                if (this.RiskScore != null)
                    hashCode = hashCode * 59 + this.RiskScore.GetHashCode();
                if (this.ThreeDSServerTransID != null)
                    hashCode = hashCode * 59 + this.ThreeDSServerTransID.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.TransStatus != null)
                    hashCode = hashCode * 59 + this.TransStatus.GetHashCode();
                if (this.TransStatusReason != null)
                    hashCode = hashCode * 59 + this.TransStatusReason.GetHashCode();
                if (this.WhiteListStatus != null)
                    hashCode = hashCode * 59 + this.WhiteListStatus.GetHashCode();
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