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

namespace Adyen.Model.Checkout
{
  /// <summary>
    /// ThreeDS2ResponseData
    /// </summary>
    [DataContract]
        public partial class ThreeDS2ResponseData :  IEquatable<ThreeDS2ResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDS2ResponseData" /> class.
        /// </summary>
        /// <param name="acsChallengeMandated">acsChallengeMandated.</param>
        /// <param name="acsOperatorID">acsOperatorID.</param>
        /// <param name="acsReferenceNumber">acsReferenceNumber.</param>
        /// <param name="acsSignedContent">acsSignedContent.</param>
        /// <param name="acsTransID">acsTransID.</param>
        /// <param name="acsURL">acsURL.</param>
        /// <param name="authenticationType">authenticationType.</param>
        /// <param name="cardHolderInfo">cardHolderInfo.</param>
        /// <param name="cavvAlgorithm">cavvAlgorithm.</param>
        /// <param name="challengeIndicator">challengeIndicator.</param>
        /// <param name="dsReferenceNumber">dsReferenceNumber.</param>
        /// <param name="dsTransID">dsTransID.</param>
        /// <param name="exemptionIndicator">exemptionIndicator.</param>
        /// <param name="messageVersion">messageVersion.</param>
        /// <param name="riskScore">riskScore.</param>
        /// <param name="sdkEphemPubKey">sdkEphemPubKey.</param>
        /// <param name="threeDSServerTransID">threeDSServerTransID.</param>
        /// <param name="transStatus">transStatus.</param>
        /// <param name="transStatusReason">transStatusReason.</param>
        public ThreeDS2ResponseData(string acsChallengeMandated = default(string), string acsOperatorID = default(string), string acsReferenceNumber = default(string), string acsSignedContent = default(string), string acsTransID = default(string), string acsURL = default(string), string authenticationType = default(string), string cardHolderInfo = default(string), string cavvAlgorithm = default(string), string challengeIndicator = default(string), string dsReferenceNumber = default(string), string dsTransID = default(string), string exemptionIndicator = default(string), string messageVersion = default(string), string riskScore = default(string), string sdkEphemPubKey = default(string), string threeDSServerTransID = default(string), string transStatus = default(string), string transStatusReason = default(string))
        {
            this.AcsChallengeMandated = acsChallengeMandated;
            this.AcsOperatorID = acsOperatorID;
            this.AcsReferenceNumber = acsReferenceNumber;
            this.AcsSignedContent = acsSignedContent;
            this.AcsTransID = acsTransID;
            this.AcsURL = acsURL;
            this.AuthenticationType = authenticationType;
            this.CardHolderInfo = cardHolderInfo;
            this.CavvAlgorithm = cavvAlgorithm;
            this.ChallengeIndicator = challengeIndicator;
            this.DsReferenceNumber = dsReferenceNumber;
            this.DsTransID = dsTransID;
            this.ExemptionIndicator = exemptionIndicator;
            this.MessageVersion = messageVersion;
            this.RiskScore = riskScore;
            this.SdkEphemPubKey = sdkEphemPubKey;
            this.ThreeDSServerTransID = threeDSServerTransID;
            this.TransStatus = transStatus;
            this.TransStatusReason = transStatusReason;
        }
        
        /// <summary>
        /// Gets or Sets AcsChallengeMandated
        /// </summary>
        [DataMember(Name="acsChallengeMandated", EmitDefaultValue=false)]
        public string AcsChallengeMandated { get; set; }

        /// <summary>
        /// Gets or Sets AcsOperatorID
        /// </summary>
        [DataMember(Name="acsOperatorID", EmitDefaultValue=false)]
        public string AcsOperatorID { get; set; }

        /// <summary>
        /// Gets or Sets AcsReferenceNumber
        /// </summary>
        [DataMember(Name="acsReferenceNumber", EmitDefaultValue=false)]
        public string AcsReferenceNumber { get; set; }

        /// <summary>
        /// Gets or Sets AcsSignedContent
        /// </summary>
        [DataMember(Name="acsSignedContent", EmitDefaultValue=false)]
        public string AcsSignedContent { get; set; }

        /// <summary>
        /// Gets or Sets AcsTransID
        /// </summary>
        [DataMember(Name="acsTransID", EmitDefaultValue=false)]
        public string AcsTransID { get; set; }

        /// <summary>
        /// Gets or Sets AcsURL
        /// </summary>
        [DataMember(Name="acsURL", EmitDefaultValue=false)]
        public string AcsURL { get; set; }

        /// <summary>
        /// Gets or Sets AuthenticationType
        /// </summary>
        [DataMember(Name="authenticationType", EmitDefaultValue=false)]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// Gets or Sets CardHolderInfo
        /// </summary>
        [DataMember(Name="cardHolderInfo", EmitDefaultValue=false)]
        public string CardHolderInfo { get; set; }

        /// <summary>
        /// Gets or Sets CavvAlgorithm
        /// </summary>
        [DataMember(Name="cavvAlgorithm", EmitDefaultValue=false)]
        public string CavvAlgorithm { get; set; }

        /// <summary>
        /// Gets or Sets ChallengeIndicator
        /// </summary>
        [DataMember(Name="challengeIndicator", EmitDefaultValue=false)]
        public string ChallengeIndicator { get; set; }

        /// <summary>
        /// Gets or Sets DsReferenceNumber
        /// </summary>
        [DataMember(Name="dsReferenceNumber", EmitDefaultValue=false)]
        public string DsReferenceNumber { get; set; }

        /// <summary>
        /// Gets or Sets DsTransID
        /// </summary>
        [DataMember(Name="dsTransID", EmitDefaultValue=false)]
        public string DsTransID { get; set; }

        /// <summary>
        /// Gets or Sets ExemptionIndicator
        /// </summary>
        [DataMember(Name="exemptionIndicator", EmitDefaultValue=false)]
        public string ExemptionIndicator { get; set; }

        /// <summary>
        /// Gets or Sets MessageVersion
        /// </summary>
        [DataMember(Name="messageVersion", EmitDefaultValue=false)]
        public string MessageVersion { get; set; }

        /// <summary>
        /// Gets or Sets RiskScore
        /// </summary>
        [DataMember(Name="riskScore", EmitDefaultValue=false)]
        public string RiskScore { get; set; }

        /// <summary>
        /// Gets or Sets SdkEphemPubKey
        /// </summary>
        [DataMember(Name="sdkEphemPubKey", EmitDefaultValue=false)]
        public string SdkEphemPubKey { get; set; }

        /// <summary>
        /// Gets or Sets ThreeDSServerTransID
        /// </summary>
        [DataMember(Name="threeDSServerTransID", EmitDefaultValue=false)]
        public string ThreeDSServerTransID { get; set; }

        /// <summary>
        /// Gets or Sets TransStatus
        /// </summary>
        [DataMember(Name="transStatus", EmitDefaultValue=false)]
        public string TransStatus { get; set; }

        /// <summary>
        /// Gets or Sets TransStatusReason
        /// </summary>
        [DataMember(Name="transStatusReason", EmitDefaultValue=false)]
        public string TransStatusReason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThreeDS2ResponseData {\n");
            sb.Append("  AcsChallengeMandated: ").Append(AcsChallengeMandated).Append("\n");
            sb.Append("  AcsOperatorID: ").Append(AcsOperatorID).Append("\n");
            sb.Append("  AcsReferenceNumber: ").Append(AcsReferenceNumber).Append("\n");
            sb.Append("  AcsSignedContent: ").Append(AcsSignedContent).Append("\n");
            sb.Append("  AcsTransID: ").Append(AcsTransID).Append("\n");
            sb.Append("  AcsURL: ").Append(AcsURL).Append("\n");
            sb.Append("  AuthenticationType: ").Append(AuthenticationType).Append("\n");
            sb.Append("  CardHolderInfo: ").Append(CardHolderInfo).Append("\n");
            sb.Append("  CavvAlgorithm: ").Append(CavvAlgorithm).Append("\n");
            sb.Append("  ChallengeIndicator: ").Append(ChallengeIndicator).Append("\n");
            sb.Append("  DsReferenceNumber: ").Append(DsReferenceNumber).Append("\n");
            sb.Append("  DsTransID: ").Append(DsTransID).Append("\n");
            sb.Append("  ExemptionIndicator: ").Append(ExemptionIndicator).Append("\n");
            sb.Append("  MessageVersion: ").Append(MessageVersion).Append("\n");
            sb.Append("  RiskScore: ").Append(RiskScore).Append("\n");
            sb.Append("  SdkEphemPubKey: ").Append(SdkEphemPubKey).Append("\n");
            sb.Append("  ThreeDSServerTransID: ").Append(ThreeDSServerTransID).Append("\n");
            sb.Append("  TransStatus: ").Append(TransStatus).Append("\n");
            sb.Append("  TransStatusReason: ").Append(TransStatusReason).Append("\n");
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
            return this.Equals(input as ThreeDS2ResponseData);
        }

        /// <summary>
        /// Returns true if ThreeDS2ResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of ThreeDS2ResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThreeDS2ResponseData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AcsChallengeMandated == input.AcsChallengeMandated ||
                    (this.AcsChallengeMandated != null &&
                    this.AcsChallengeMandated.Equals(input.AcsChallengeMandated))
                ) && 
                (
                    this.AcsOperatorID == input.AcsOperatorID ||
                    (this.AcsOperatorID != null &&
                    this.AcsOperatorID.Equals(input.AcsOperatorID))
                ) && 
                (
                    this.AcsReferenceNumber == input.AcsReferenceNumber ||
                    (this.AcsReferenceNumber != null &&
                    this.AcsReferenceNumber.Equals(input.AcsReferenceNumber))
                ) && 
                (
                    this.AcsSignedContent == input.AcsSignedContent ||
                    (this.AcsSignedContent != null &&
                    this.AcsSignedContent.Equals(input.AcsSignedContent))
                ) && 
                (
                    this.AcsTransID == input.AcsTransID ||
                    (this.AcsTransID != null &&
                    this.AcsTransID.Equals(input.AcsTransID))
                ) && 
                (
                    this.AcsURL == input.AcsURL ||
                    (this.AcsURL != null &&
                    this.AcsURL.Equals(input.AcsURL))
                ) && 
                (
                    this.AuthenticationType == input.AuthenticationType ||
                    (this.AuthenticationType != null &&
                    this.AuthenticationType.Equals(input.AuthenticationType))
                ) && 
                (
                    this.CardHolderInfo == input.CardHolderInfo ||
                    (this.CardHolderInfo != null &&
                    this.CardHolderInfo.Equals(input.CardHolderInfo))
                ) && 
                (
                    this.CavvAlgorithm == input.CavvAlgorithm ||
                    (this.CavvAlgorithm != null &&
                    this.CavvAlgorithm.Equals(input.CavvAlgorithm))
                ) && 
                (
                    this.ChallengeIndicator == input.ChallengeIndicator ||
                    (this.ChallengeIndicator != null &&
                    this.ChallengeIndicator.Equals(input.ChallengeIndicator))
                ) && 
                (
                    this.DsReferenceNumber == input.DsReferenceNumber ||
                    (this.DsReferenceNumber != null &&
                    this.DsReferenceNumber.Equals(input.DsReferenceNumber))
                ) && 
                (
                    this.DsTransID == input.DsTransID ||
                    (this.DsTransID != null &&
                    this.DsTransID.Equals(input.DsTransID))
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
                    this.SdkEphemPubKey == input.SdkEphemPubKey ||
                    (this.SdkEphemPubKey != null &&
                    this.SdkEphemPubKey.Equals(input.SdkEphemPubKey))
                ) && 
                (
                    this.ThreeDSServerTransID == input.ThreeDSServerTransID ||
                    (this.ThreeDSServerTransID != null &&
                    this.ThreeDSServerTransID.Equals(input.ThreeDSServerTransID))
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
                if (this.AcsChallengeMandated != null)
                    hashCode = hashCode * 59 + this.AcsChallengeMandated.GetHashCode();
                if (this.AcsOperatorID != null)
                    hashCode = hashCode * 59 + this.AcsOperatorID.GetHashCode();
                if (this.AcsReferenceNumber != null)
                    hashCode = hashCode * 59 + this.AcsReferenceNumber.GetHashCode();
                if (this.AcsSignedContent != null)
                    hashCode = hashCode * 59 + this.AcsSignedContent.GetHashCode();
                if (this.AcsTransID != null)
                    hashCode = hashCode * 59 + this.AcsTransID.GetHashCode();
                if (this.AcsURL != null)
                    hashCode = hashCode * 59 + this.AcsURL.GetHashCode();
                if (this.AuthenticationType != null)
                    hashCode = hashCode * 59 + this.AuthenticationType.GetHashCode();
                if (this.CardHolderInfo != null)
                    hashCode = hashCode * 59 + this.CardHolderInfo.GetHashCode();
                if (this.CavvAlgorithm != null)
                    hashCode = hashCode * 59 + this.CavvAlgorithm.GetHashCode();
                if (this.ChallengeIndicator != null)
                    hashCode = hashCode * 59 + this.ChallengeIndicator.GetHashCode();
                if (this.DsReferenceNumber != null)
                    hashCode = hashCode * 59 + this.DsReferenceNumber.GetHashCode();
                if (this.DsTransID != null)
                    hashCode = hashCode * 59 + this.DsTransID.GetHashCode();
                if (this.ExemptionIndicator != null)
                    hashCode = hashCode * 59 + this.ExemptionIndicator.GetHashCode();
                if (this.MessageVersion != null)
                    hashCode = hashCode * 59 + this.MessageVersion.GetHashCode();
                if (this.RiskScore != null)
                    hashCode = hashCode * 59 + this.RiskScore.GetHashCode();
                if (this.SdkEphemPubKey != null)
                    hashCode = hashCode * 59 + this.SdkEphemPubKey.GetHashCode();
                if (this.ThreeDSServerTransID != null)
                    hashCode = hashCode * 59 + this.ThreeDSServerTransID.GetHashCode();
                if (this.TransStatus != null)
                    hashCode = hashCode * 59 + this.TransStatus.GetHashCode();
                if (this.TransStatusReason != null)
                    hashCode = hashCode * 59 + this.TransStatusReason.GetHashCode();
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