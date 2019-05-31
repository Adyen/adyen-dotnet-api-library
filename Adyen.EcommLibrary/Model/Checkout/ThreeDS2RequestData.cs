using Adyen.EcommLibrary.Model.Enum;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.EcommLibrary.Model.Checkout
{
    /// <summary>
    /// ThreeDS2RequestData
    /// </summary>
    [DataContract]
    public partial class ThreeDS2RequestData : IEquatable<ThreeDS2RequestData>, IValidatableObject
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
            [EnumMember(Value = "noPreference")] NoPreference = 1,

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
        [DataMember(Name = "challengeIndicator", EmitDefaultValue = false)]
        public ChallengeIndicatorEnum? ChallengeIndicator { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDS2RequestData" /> class.
        /// </summary>
        [JsonConstructor]
        protected ThreeDS2RequestData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDS2RequestData" /> class.
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
        public ThreeDS2RequestData(bool? AuthenticationOnly = default(bool?),
            ChallengeIndicatorEnum? ChallengeIndicator = default(ChallengeIndicatorEnum?),
            DeviceChannelEnum? DeviceChannel = default(DeviceChannelEnum),
            DeviceRenderOptions DeviceRenderOptions = default(DeviceRenderOptions),
            string NotificationURL = default(string), string SdkAppID = default(string),
            string SdkEncData = default(string), SDKEphemPubKey SdkEphemPubKey = default(SDKEphemPubKey),
            int? SdkMaxTimeout = default(int?), string SdkReferenceNumber = default(string),
            string SdkTransID = default(string),
            DeviceFingerprintCompletedEnum ThreeDSCompInd = default(DeviceFingerprintCompletedEnum),
            string ThreeDSRequestorURL = default(string))
        {
            // to ensure "DeviceChannel" is required (not null)

            this.DeviceChannel = DeviceChannel ??
                                 throw new InvalidDataException(
                                     "DeviceChannel is a required property for ThreeDS2RequestData and cannot be null");
            ;

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
        [DataMember(Name = "authenticationOnly", EmitDefaultValue = false)]
        public bool? AuthenticationOnly { get; set; }


        /// <summary>
        /// The environment of the shopper. Allowed values: * &#x60;app&#x60; * &#x60;browser&#x60;
        /// </summary>
        /// <value>The environment of the shopper. Allowed values: * &#x60;app&#x60; * &#x60;browser&#x60;</value>
        [DataMember(Name = "deviceChannel")]
        public DeviceChannelEnum DeviceChannel { get; set; }

        /// <summary>
        /// Display options for the 3DS2.0 SDK. Only for deviceChannel &#39;app&#39;.
        /// </summary>
        /// <value>Display options for the 3DS2.0 SDK. Only for deviceChannel &#39;app&#39;.</value>
        [DataMember(Name = "deviceRenderOptions", EmitDefaultValue = false)]
        public DeviceRenderOptions DeviceRenderOptions { get; set; }

        /// <summary>
        /// URL the &#x60;CRes&#x60; value will be sent. Only for &#x60;deviceChannel&#x60; set to **browser**.
        /// </summary>
        /// <value>URL the &#x60;CRes&#x60; value will be sent. Only for &#x60;deviceChannel&#x60; set to **browser**.</value>
        [DataMember(Name = "notificationURL", EmitDefaultValue = false)]
        public string NotificationURL { get; set; }

        /// <summary>
        /// The &#x60;sdkAppID&#x60; value as received from the 3DS 2.0 SDK. Only for &#x60;deviceChannel&#x60; set to **app**.
        /// </summary>
        /// <value>The &#x60;sdkAppID&#x60; value as received from the 3DS 2.0 SDK. Only for &#x60;deviceChannel&#x60; set to **app**.</value>
        [DataMember(Name = "sdkAppID", EmitDefaultValue = false)]
        public string SdkAppID { get; set; }

        /// <summary>
        /// The &#x60;sdkEncData&#x60; value as received from the 3DS 2.0 SDK. Only for &#x60;deviceChannel&#x60; set to **app**.
        /// </summary>
        /// <value>The &#x60;sdkEncData&#x60; value as received from the 3DS 2.0 SDK. Only for &#x60;deviceChannel&#x60; set to **app**.</value>
        [DataMember(Name = "sdkEncData", EmitDefaultValue = false)]
        public string SdkEncData { get; set; }

        /// <summary>
        /// The &#x60;sdkEphemPubKey&#x60; value as received from the 3DS 2.0 SDK. Only for &#x60;deviceChannel&#x60; set to **app**.
        /// </summary>
        /// <value>The &#x60;sdkEphemPubKey&#x60; value as received from the 3DS 2.0 SDK. Only for &#x60;deviceChannel&#x60; set to **app**.</value>
        [DataMember(Name = "sdkEphemPubKey", EmitDefaultValue = false)]
        public SDKEphemPubKey SdkEphemPubKey { get; set; }

        /// <summary>
        /// The maximum amount of time in minutes for the 3DS 2.0 authentication process. Only for &#x60;deviceChannel&#x60; set to **app**.
        /// </summary>
        /// <value>The maximum amount of time in minutes for the 3DS 2.0 authentication process. Only for &#x60;deviceChannel&#x60; set to **app**.</value>
        [DataMember(Name = "sdkMaxTimeout", EmitDefaultValue = false)]
        public int? SdkMaxTimeout { get; set; }

        /// <summary>
        /// The &#x60;sdkReferenceNumber&#x60; value as received from the 3DS 2.0 SDK. Only for &#x60;deviceChannel&#x60; set to **app**.
        /// </summary>
        /// <value>The &#x60;sdkReferenceNumber&#x60; value as received from the 3DS 2.0 SDK. Only for &#x60;deviceChannel&#x60; set to **app**.</value>
        [DataMember(Name = "sdkReferenceNumber", EmitDefaultValue = false)]
        public string SdkReferenceNumber { get; set; }

        /// <summary>
        /// The &#x60;sdkTransID&#x60; value as received from the 3DS 2.0 SDK. Only for &#x60;deviceChannel&#x60; set to **app**.
        /// </summary>
        /// <value>The &#x60;sdkTransID&#x60; value as received from the 3DS 2.0 SDK. Only for &#x60;deviceChannel&#x60; set to **app**.</value>
        [DataMember(Name = "sdkTransID", EmitDefaultValue = false)]
        public string SdkTransID { get; set; }

        /// <summary>
        /// Completion indicator for the &#x60;threeDSMethodUrl&#x60; fingerprinting.
        /// </summary>
        /// <value>Completion indicator for the &#x60;threeDSMethodUrl&#x60; fingerprinting.</value>
        [DataMember(Name = "threeDSCompInd", EmitDefaultValue = false)]
        public DeviceFingerprintCompletedEnum ThreeDSCompInd { get; set; }

        /// <summary>
        /// URL of the (customer service) website that will be shown to the shopper in case of technical errors during the 3DS2.0 process.
        /// </summary>
        /// <value>URL of the (customer service) website that will be shown to the shopper in case of technical errors during the 3DS2.0 process.</value>
        [DataMember(Name = "threeDSRequestorURL", EmitDefaultValue = false)]
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
            return Equals(input as ThreeDS2RequestData);
        }

        /// <summary>
        /// Returns true if ThreeDS2RequestData instances are equal
        /// </summary>
        /// <param name="input">Instance of ThreeDS2RequestData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThreeDS2RequestData input)
        {
            if (input == null)
                return false;

            return
                (
                    AuthenticationOnly == input.AuthenticationOnly ||
                    AuthenticationOnly != null &&
                    AuthenticationOnly.Equals(input.AuthenticationOnly)
                ) &&
                (
                    ChallengeIndicator == input.ChallengeIndicator ||
                    ChallengeIndicator != null &&
                    ChallengeIndicator.Equals(input.ChallengeIndicator)
                ) && DeviceChannel == input.DeviceChannel && DeviceChannel.Equals(input.DeviceChannel) && (
                    DeviceRenderOptions == input.DeviceRenderOptions ||
                    DeviceRenderOptions != null &&
                    DeviceRenderOptions.Equals(input.DeviceRenderOptions)
                ) && (
                    NotificationURL == input.NotificationURL ||
                    NotificationURL != null &&
                    NotificationURL.Equals(input.NotificationURL)
                ) && (
                    SdkAppID == input.SdkAppID ||
                    SdkAppID != null &&
                    SdkAppID.Equals(input.SdkAppID)
                ) && (
                    SdkEncData == input.SdkEncData ||
                    SdkEncData != null &&
                    SdkEncData.Equals(input.SdkEncData)
                ) && (
                    SdkEphemPubKey == input.SdkEphemPubKey ||
                    SdkEphemPubKey != null &&
                    SdkEphemPubKey.Equals(input.SdkEphemPubKey)
                ) && (
                    SdkMaxTimeout == input.SdkMaxTimeout ||
                    SdkMaxTimeout != null &&
                    SdkMaxTimeout.Equals(input.SdkMaxTimeout)
                ) && (
                    SdkReferenceNumber == input.SdkReferenceNumber ||
                    SdkReferenceNumber != null &&
                    SdkReferenceNumber.Equals(input.SdkReferenceNumber)
                ) && (
                    SdkTransID == input.SdkTransID ||
                    SdkTransID != null &&
                    SdkTransID.Equals(input.SdkTransID)
                ) && ThreeDSCompInd == input.ThreeDSCompInd && ThreeDSCompInd.Equals(input.ThreeDSCompInd) && (
                    ThreeDSRequestorURL == input.ThreeDSRequestorURL ||
                    ThreeDSRequestorURL != null &&
                    ThreeDSRequestorURL.Equals(input.ThreeDSRequestorURL)
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
                var hashCode = 41;
                if (AuthenticationOnly != null)
                    hashCode = hashCode * 59 + AuthenticationOnly.GetHashCode();
                if (ChallengeIndicator != null)
                    hashCode = hashCode * 59 + ChallengeIndicator.GetHashCode();

                hashCode = hashCode * 59 + DeviceChannel.GetHashCode();

                if (DeviceRenderOptions != null)
                    hashCode = hashCode * 59 + DeviceRenderOptions.GetHashCode();
                if (NotificationURL != null)
                    hashCode = hashCode * 59 + NotificationURL.GetHashCode();
                if (SdkAppID != null)
                    hashCode = hashCode * 59 + SdkAppID.GetHashCode();
                if (SdkEncData != null)
                    hashCode = hashCode * 59 + SdkEncData.GetHashCode();
                if (SdkEphemPubKey != null)
                    hashCode = hashCode * 59 + SdkEphemPubKey.GetHashCode();
                if (SdkMaxTimeout != null)
                    hashCode = hashCode * 59 + SdkMaxTimeout.GetHashCode();
                if (SdkReferenceNumber != null)
                    hashCode = hashCode * 59 + SdkReferenceNumber.GetHashCode();
                if (SdkTransID != null)
                    hashCode = hashCode * 59 + SdkTransID.GetHashCode();

                hashCode = hashCode * 59 + ThreeDSCompInd.GetHashCode();

                if (ThreeDSRequestorURL != null)
                    hashCode = hashCode * 59 + ThreeDSRequestorURL.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}