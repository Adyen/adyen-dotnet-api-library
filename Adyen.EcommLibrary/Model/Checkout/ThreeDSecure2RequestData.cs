
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.EcommLibrary.Model.Checkout
{
    /// <summary>
    /// ThreeDS2RequestData
    /// </summary>
    [DataContract]
    public partial class ThreeDSecure2RequestData :  IEquatable<ThreeDSecure2RequestData>, IValidatableObject
    {
        /// <summary>
        /// Possibility to specify a preference for receiving a challenge from the issuer.
        /// </summary>
        /// <value>Possibility to specify a preference for receiving a challenge from the issuer.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChallengeIndicatorEnum
        {
            
            /// <summary>
            /// Enum NoPreference for value: noPreference
            /// </summary>
            [EnumMember(Value = "noPreference")]
            NoPreference = 1,
            
            /// <summary>
            /// Enum RequestChallenge for value: requestChallenge
            /// </summary>
            [EnumMember(Value = "requestChallenge")]
            RequestChallenge = 2,
            
            /// <summary>
            /// Enum RequestNoChallenge for value: requestNoChallenge
            /// </summary>
            [EnumMember(Value = "requestNoChallenge")]
            RequestNoChallenge = 3
        }

        /// <summary>
        /// Possibility to specify a preference for receiving a challenge from the issuer.
        /// </summary>
        /// <value>Possibility to specify a preference for receiving a challenge from the issuer.</value>
        [DataMember(Name="challengeIndicator", EmitDefaultValue=false)]
        public ChallengeIndicatorEnum? ChallengeIndicator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDSecure2RequestData" /> class.
        /// </summary>
        [JsonConstructor]
        protected ThreeDSecure2RequestData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDSecure2RequestData" /> class.
        /// </summary>
        /// <param name="AuthenticationOnly">If set to true, you will only do the 3D Secure 2.0 authentication, not the payment authorization..</param>
        /// <param name="ChallengeIndicator">Possibility to specify a preference for receiving a challenge from the issuer..</param>
        /// <param name="DeviceChannel">The environment of the shopper. Allowed values: * &#x60;app&#x60; * &#x60;browser&#x60; (required).</param>
        /// <param name="DeviceRenderOptions">Display options for the 3DS2.0 SDK. Only for deviceChannel &#39;app&#39;..</param>
        /// <param name="NotificationURL">URL the &#x60;CRes&#x60; value will be sent. Only for &#x60;deviceChannel&#x60; set to **browser**..</param>
        /// <param name="SdkAppID">The &#x60;sdkAppID&#x60; value as received from the 3DS 2.0 SDK. Only for &#x60;deviceChannel&#x60; set to **app**..</param>
        /// <param name="SdkEncData">The &#x60;sdkEncData&#x60; value as received from the 3DS 2.0 SDK. Only for &#x60;deviceChannel&#x60; set to **app**..</param>
        /// <param name="SdkEphemPubKey">The &#x60;sdkEphemPubKey&#x60; value as received from the 3DS 2.0 SDK. Only for &#x60;deviceChannel&#x60; set to **app**..</param>
        /// <param name="SdkMaxTimeout">The maximum amount of time in minutes for the 3DS 2.0 authentication process. Only for &#x60;deviceChannel&#x60; set to **app**..</param>
        /// <param name="SdkReferenceNumber">The &#x60;sdkReferenceNumber&#x60; value as received from the 3DS 2.0 SDK. Only for &#x60;deviceChannel&#x60; set to **app**..</param>
        /// <param name="SdkTransID">The &#x60;sdkTransID&#x60; value as received from the 3DS 2.0 SDK. Only for &#x60;deviceChannel&#x60; set to **app**..</param>
        /// <param name="ThreeDSCompInd">Completion indicator for the &#x60;threeDSMethodUrl&#x60; fingerprinting..</param>
        /// <param name="ThreeDSRequestorURL">URL of the (customer service) website that will be shown to the shopper in case of technical errors during the 3DS2.0 process..</param>
        public ThreeDSecure2RequestData(bool? AuthenticationOnly = default(bool?), ChallengeIndicatorEnum? ChallengeIndicator = default(ChallengeIndicatorEnum?), string DeviceChannel = default(string), DeviceRenderOptions DeviceRenderOptions = default(DeviceRenderOptions), string NotificationURL = default(string), string SdkAppID = default(string), string SdkEncData = default(string), SDKEphemPubKey SdkEphemPubKey = default(SDKEphemPubKey), int? SdkMaxTimeout = default(int?), string SdkReferenceNumber = default(string), string SdkTransID = default(string), string ThreeDSCompInd = default(string), string ThreeDSRequestorURL = default(string))
        {
            // to ensure "DeviceChannel" is required (not null)
            if (DeviceChannel == null)
            {
                throw new InvalidDataException("DeviceChannel is a required property for ThreeDS2RequestData and cannot be null");
            }
            else
            {
                this.DeviceChannel = DeviceChannel;
            }
            this.AuthenticationOnly = AuthenticationOnly;
            this.ChallengeIndicator = ChallengeIndicator;
            this.DeviceRenderOptions = DeviceRenderOptions;
            this.NotificationURL = NotificationURL;
            this.SdkAppID = SdkAppID;
            this.SdkEncData = SdkEncData;
            this.SdkEphemPubKey = SdkEphemPubKey;
            this.SdkMaxTimeout = SdkMaxTimeout;
            this.SdkReferenceNumber = SdkReferenceNumber;
            this.SdkTransID = SdkTransID;
            this.ThreeDSCompInd = ThreeDSCompInd;
            this.ThreeDSRequestorURL = ThreeDSRequestorURL;
        }
        
        /// <summary>
        /// If set to true, you will only do the 3D Secure 2.0 authentication, not the payment authorization.
        /// </summary>
        /// <value>If set to true, you will only do the 3D Secure 2.0 authentication, not the payment authorization.</value>
        [DataMember(Name="authenticationOnly", EmitDefaultValue=false)]
        public bool? AuthenticationOnly { get; set; }


        /// <summary>
        /// The environment of the shopper. Allowed values: * &#x60;app&#x60; * &#x60;browser&#x60;
        /// </summary>
        /// <value>The environment of the shopper. Allowed values: * &#x60;app&#x60; * &#x60;browser&#x60;</value>
        [DataMember(Name="deviceChannel", EmitDefaultValue=false)]
        public string DeviceChannel { get; set; }

        /// <summary>
        /// Display options for the 3DS2.0 SDK. Only for deviceChannel &#39;app&#39;.
        /// </summary>
        /// <value>Display options for the 3DS2.0 SDK. Only for deviceChannel &#39;app&#39;.</value>
        [DataMember(Name="deviceRenderOptions", EmitDefaultValue=false)]
        public DeviceRenderOptions DeviceRenderOptions { get; set; }

        /// <summary>
        /// URL the &#x60;CRes&#x60; value will be sent. Only for &#x60;deviceChannel&#x60; set to **browser**.
        /// </summary>
        /// <value>URL the &#x60;CRes&#x60; value will be sent. Only for &#x60;deviceChannel&#x60; set to **browser**.</value>
        [DataMember(Name="notificationURL", EmitDefaultValue=false)]
        public string NotificationURL { get; set; }

        /// <summary>
        /// The &#x60;sdkAppID&#x60; value as received from the 3DS 2.0 SDK. Only for &#x60;deviceChannel&#x60; set to **app**.
        /// </summary>
        /// <value>The &#x60;sdkAppID&#x60; value as received from the 3DS 2.0 SDK. Only for &#x60;deviceChannel&#x60; set to **app**.</value>
        [DataMember(Name="sdkAppID", EmitDefaultValue=false)]
        public string SdkAppID { get; set; }

        /// <summary>
        /// The &#x60;sdkEncData&#x60; value as received from the 3DS 2.0 SDK. Only for &#x60;deviceChannel&#x60; set to **app**.
        /// </summary>
        /// <value>The &#x60;sdkEncData&#x60; value as received from the 3DS 2.0 SDK. Only for &#x60;deviceChannel&#x60; set to **app**.</value>
        [DataMember(Name="sdkEncData", EmitDefaultValue=false)]
        public string SdkEncData { get; set; }

        /// <summary>
        /// The &#x60;sdkEphemPubKey&#x60; value as received from the 3DS 2.0 SDK. Only for &#x60;deviceChannel&#x60; set to **app**.
        /// </summary>
        /// <value>The &#x60;sdkEphemPubKey&#x60; value as received from the 3DS 2.0 SDK. Only for &#x60;deviceChannel&#x60; set to **app**.</value>
        [DataMember(Name="sdkEphemPubKey", EmitDefaultValue=false)]
        public SDKEphemPubKey SdkEphemPubKey { get; set; }

        /// <summary>
        /// The maximum amount of time in minutes for the 3DS 2.0 authentication process. Only for &#x60;deviceChannel&#x60; set to **app**.
        /// </summary>
        /// <value>The maximum amount of time in minutes for the 3DS 2.0 authentication process. Only for &#x60;deviceChannel&#x60; set to **app**.</value>
        [DataMember(Name="sdkMaxTimeout", EmitDefaultValue=false)]
        public int? SdkMaxTimeout { get; set; }

        /// <summary>
        /// The &#x60;sdkReferenceNumber&#x60; value as received from the 3DS 2.0 SDK. Only for &#x60;deviceChannel&#x60; set to **app**.
        /// </summary>
        /// <value>The &#x60;sdkReferenceNumber&#x60; value as received from the 3DS 2.0 SDK. Only for &#x60;deviceChannel&#x60; set to **app**.</value>
        [DataMember(Name="sdkReferenceNumber", EmitDefaultValue=false)]
        public string SdkReferenceNumber { get; set; }

        /// <summary>
        /// The &#x60;sdkTransID&#x60; value as received from the 3DS 2.0 SDK. Only for &#x60;deviceChannel&#x60; set to **app**.
        /// </summary>
        /// <value>The &#x60;sdkTransID&#x60; value as received from the 3DS 2.0 SDK. Only for &#x60;deviceChannel&#x60; set to **app**.</value>
        [DataMember(Name="sdkTransID", EmitDefaultValue=false)]
        public string SdkTransID { get; set; }

        /// <summary>
        /// Completion indicator for the &#x60;threeDSMethodUrl&#x60; fingerprinting.
        /// </summary>
        /// <value>Completion indicator for the &#x60;threeDSMethodUrl&#x60; fingerprinting.</value>
        [DataMember(Name="threeDSCompInd", EmitDefaultValue=false)]
        public string ThreeDSCompInd { get; set; }

        /// <summary>
        /// URL of the (customer service) website that will be shown to the shopper in case of technical errors during the 3DS2.0 process.
        /// </summary>
        /// <value>URL of the (customer service) website that will be shown to the shopper in case of technical errors during the 3DS2.0 process.</value>
        [DataMember(Name="threeDSRequestorURL", EmitDefaultValue=false)]
        public string ThreeDSRequestorURL { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThreeDS2RequestData {\n");
            sb.Append("  AuthenticationOnly: ").Append(AuthenticationOnly).Append("\n");
            sb.Append("  ChallengeIndicator: ").Append(ChallengeIndicator).Append("\n");
            sb.Append("  DeviceChannel: ").Append(DeviceChannel).Append("\n");
            sb.Append("  DeviceRenderOptions: ").Append(DeviceRenderOptions).Append("\n");
            sb.Append("  NotificationURL: ").Append(NotificationURL).Append("\n");
            sb.Append("  SdkAppID: ").Append(SdkAppID).Append("\n");
            sb.Append("  SdkEncData: ").Append(SdkEncData).Append("\n");
            sb.Append("  SdkEphemPubKey: ").Append(SdkEphemPubKey).Append("\n");
            sb.Append("  SdkMaxTimeout: ").Append(SdkMaxTimeout).Append("\n");
            sb.Append("  SdkReferenceNumber: ").Append(SdkReferenceNumber).Append("\n");
            sb.Append("  SdkTransID: ").Append(SdkTransID).Append("\n");
            sb.Append("  ThreeDSCompInd: ").Append(ThreeDSCompInd).Append("\n");
            sb.Append("  ThreeDSRequestorURL: ").Append(ThreeDSRequestorURL).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as ThreeDSecure2RequestData);
        }

        /// <summary>
        /// Returns true if ThreeDS2RequestData instances are equal
        /// </summary>
        /// <param name="input">Instance of ThreeDS2RequestData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThreeDSecure2RequestData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthenticationOnly == input.AuthenticationOnly ||
                    (this.AuthenticationOnly != null &&
                    this.AuthenticationOnly.Equals(input.AuthenticationOnly))
                ) && 
                (
                    this.ChallengeIndicator == input.ChallengeIndicator ||
                    (this.ChallengeIndicator != null &&
                    this.ChallengeIndicator.Equals(input.ChallengeIndicator))
                ) && 
                (
                    this.DeviceChannel == input.DeviceChannel ||
                    (this.DeviceChannel != null &&
                    this.DeviceChannel.Equals(input.DeviceChannel))
                ) && 
                (
                    this.DeviceRenderOptions == input.DeviceRenderOptions ||
                    (this.DeviceRenderOptions != null &&
                    this.DeviceRenderOptions.Equals(input.DeviceRenderOptions))
                ) && 
                (
                    this.NotificationURL == input.NotificationURL ||
                    (this.NotificationURL != null &&
                    this.NotificationURL.Equals(input.NotificationURL))
                ) && 
                (
                    this.SdkAppID == input.SdkAppID ||
                    (this.SdkAppID != null &&
                    this.SdkAppID.Equals(input.SdkAppID))
                ) && 
                (
                    this.SdkEncData == input.SdkEncData ||
                    (this.SdkEncData != null &&
                    this.SdkEncData.Equals(input.SdkEncData))
                ) && 
                (
                    this.SdkEphemPubKey == input.SdkEphemPubKey ||
                    (this.SdkEphemPubKey != null &&
                    this.SdkEphemPubKey.Equals(input.SdkEphemPubKey))
                ) && 
                (
                    this.SdkMaxTimeout == input.SdkMaxTimeout ||
                    (this.SdkMaxTimeout != null &&
                    this.SdkMaxTimeout.Equals(input.SdkMaxTimeout))
                ) && 
                (
                    this.SdkReferenceNumber == input.SdkReferenceNumber ||
                    (this.SdkReferenceNumber != null &&
                    this.SdkReferenceNumber.Equals(input.SdkReferenceNumber))
                ) && 
                (
                    this.SdkTransID == input.SdkTransID ||
                    (this.SdkTransID != null &&
                    this.SdkTransID.Equals(input.SdkTransID))
                ) && 
                (
                    this.ThreeDSCompInd == input.ThreeDSCompInd ||
                    (this.ThreeDSCompInd != null &&
                    this.ThreeDSCompInd.Equals(input.ThreeDSCompInd))
                ) && 
                (
                    this.ThreeDSRequestorURL == input.ThreeDSRequestorURL ||
                    (this.ThreeDSRequestorURL != null &&
                    this.ThreeDSRequestorURL.Equals(input.ThreeDSRequestorURL))
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
                if (this.AuthenticationOnly != null)
                    hashCode = hashCode * 59 + this.AuthenticationOnly.GetHashCode();
                if (this.ChallengeIndicator != null)
                    hashCode = hashCode * 59 + this.ChallengeIndicator.GetHashCode();
                if (this.DeviceChannel != null)
                    hashCode = hashCode * 59 + this.DeviceChannel.GetHashCode();
                if (this.DeviceRenderOptions != null)
                    hashCode = hashCode * 59 + this.DeviceRenderOptions.GetHashCode();
                if (this.NotificationURL != null)
                    hashCode = hashCode * 59 + this.NotificationURL.GetHashCode();
                if (this.SdkAppID != null)
                    hashCode = hashCode * 59 + this.SdkAppID.GetHashCode();
                if (this.SdkEncData != null)
                    hashCode = hashCode * 59 + this.SdkEncData.GetHashCode();
                if (this.SdkEphemPubKey != null)
                    hashCode = hashCode * 59 + this.SdkEphemPubKey.GetHashCode();
                if (this.SdkMaxTimeout != null)
                    hashCode = hashCode * 59 + this.SdkMaxTimeout.GetHashCode();
                if (this.SdkReferenceNumber != null)
                    hashCode = hashCode * 59 + this.SdkReferenceNumber.GetHashCode();
                if (this.SdkTransID != null)
                    hashCode = hashCode * 59 + this.SdkTransID.GetHashCode();
                if (this.ThreeDSCompInd != null)
                    hashCode = hashCode * 59 + this.ThreeDSCompInd.GetHashCode();
                if (this.ThreeDSRequestorURL != null)
                    hashCode = hashCode * 59 + this.ThreeDSRequestorURL.GetHashCode();
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
