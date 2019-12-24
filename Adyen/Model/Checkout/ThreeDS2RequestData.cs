#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2019 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using Adyen.Model.Enum;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// ThreeDS2RequestData
    /// </summary>
    [DataContract]
    public partial class ThreeDS2RequestData : IEquatable<ThreeDS2RequestData>, IValidatableObject
    {
        /// <summary>
        /// Possibility to specify a preference for receiving a challenge from the issuer. Allowed values: * &#x60;noPreference&#x60; * &#x60;requestNoChallenge&#x60; * &#x60;requestChallenge&#x60; * &#x60;requestChallengeAsMandate&#x60; 
        /// </summary>
        /// <value>Possibility to specify a preference for receiving a challenge from the issuer. Allowed values: * &#x60;noPreference&#x60; * &#x60;requestNoChallenge&#x60; * &#x60;requestChallenge&#x60; * &#x60;requestChallengeAsMandate&#x60; </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChallengeIndicatorEnum
        {
            /// <summary>
            /// Enum NoPreference for value: noPreference
            /// </summary>
            [EnumMember(Value = "noPreference")]
            NoPreference = 0,
            /// <summary>
            /// Enum RequestNoChallenge for value: requestNoChallenge
            /// </summary>
            [EnumMember(Value = "requestNoChallenge")]
            RequestNoChallenge = 1,
            /// <summary>
            /// Enum RequestChallenge for value: requestChallenge
            /// </summary>
            [EnumMember(Value = "requestChallenge")]
            RequestChallenge = 2,
            /// <summary>
            /// Enum RequestChallengeAsMandate for value: requestChallengeAsMandate
            /// </summary>
            [EnumMember(Value = "requestChallengeAsMandate")]
            RequestChallengeAsMandate = 3
        }
        /// <summary>
        /// Possibility to specify a preference for receiving a challenge from the issuer. Allowed values: * &#x60;noPreference&#x60; * &#x60;requestNoChallenge&#x60; * &#x60;requestChallenge&#x60; * &#x60;requestChallengeAsMandate&#x60; 
        /// </summary>
        /// <value>Possibility to specify a preference for receiving a challenge from the issuer. Allowed values: * &#x60;noPreference&#x60; * &#x60;requestNoChallenge&#x60; * &#x60;requestChallenge&#x60; * &#x60;requestChallengeAsMandate&#x60; </value>
        [DataMember(Name = "challengeIndicator", EmitDefaultValue = false)]
        public ChallengeIndicatorEnum? ChallengeIndicator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDS2RequestData" /> class.
        /// </summary>
        [JsonConstructor]
        protected ThreeDS2RequestData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDS2RequestData" /> class.
        /// </summary>
        /// <param name="acquirerBIN">Required for [authentication-only integration](https://docs.adyen.com/checkout/3d-secure-2/3ds2-checkout-authentication-only-integration). The acquiring BIN enrolled for 3D Secure 2. This string should match the value that you will use in the authorisation..</param>
        /// <param name="acquirerMerchantID">Required for [authentication-only integration](https://docs.adyen.com/checkout/3d-secure-2/3ds2-checkout-authentication-only-integration). The merchantId that is enrolled for 3D Secure 2 by the merchant&#x27;s acquirer. This string should match the value that you will use in the authorisation..</param>
        /// <param name="authenticationOnly">If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/checkout/3d-secure-2/3ds2-checkout-authentication-only-integration), and not the payment authorisation..</param>
        /// <param name="challengeIndicator">Possibility to specify a preference for receiving a challenge from the issuer. Allowed values: * &#x60;noPreference&#x60; * &#x60;requestNoChallenge&#x60; * &#x60;requestChallenge&#x60; * &#x60;requestChallengeAsMandate&#x60; .</param>
        /// <param name="deviceChannel">The environment of the shopper. Allowed values: * &#x60;app&#x60; * &#x60;browser&#x60; (required).</param>
        /// <param name="deviceRenderOptions">deviceRenderOptions.</param>
        /// <param name="mcc">Required for merchants that have been enrolled for 3DS2 by another party than Adyen, mostly [authentication-only integrations](https://docs.adyen.com/checkout/3d-secure-2/3ds2-checkout-authentication-only-integration). The &#x60;mcc&#x60; is a four-digit code with which the previously given &#x60;acquirerMerchantID&#x60; is registered at the scheme..</param>
        /// <param name="merchantName">Required for [authentication-only integration](https://docs.adyen.com/checkout/3d-secure-2/3ds2-checkout-authentication-only-integration). The merchant name that the issuer presents to the shopper if they get a challenge. We recommend to use the same value that you will use in the authorization. Maximum length is 40 characters. &gt; Optional for a [full 3D Secure 2 integration](https://docs.adyen.com/checkout/3d-secure-2/3ds2-checkout-api-integration). Use this field if you are enrolled for 3D Secure 2 with us and want to override the merchant name already configured on your account..</param>
        /// <param name="messageVersion">The &#x60;messageVersion&#x60; value indicating the 3D Secure 2 protocol version..</param>
        /// <param name="notificationURL">URL to where the issuer should send the &#x60;CRes&#x60;. Required if you are not using components for &#x60;channel&#x60; **Web** or if you are using classic integration &#x60;deviceChannel&#x60; **browser**..</param>
        /// <param name="sdkAppID">The &#x60;sdkAppID&#x60; value as received from the 3D Secure 2 SDK. Required for &#x60;deviceChannel&#x60; set to **app**..</param>
        /// <param name="sdkEncData">The &#x60;sdkEncData&#x60; value as received from the 3D Secure 2 SDK. Required for &#x60;deviceChannel&#x60; set to **app**..</param>
        /// <param name="sdkEphemPubKey">sdkEphemPubKey.</param>
        /// <param name="sdkMaxTimeout">The maximum amount of time in minutes for the 3D Secure 2 authentication process. Optional and only for &#x60;deviceChannel&#x60; set to **app**. Defaults to **60** minutes..</param>
        /// <param name="sdkReferenceNumber">The &#x60;sdkReferenceNumber&#x60; value as received from the 3D Secure 2 SDK. Only for &#x60;deviceChannel&#x60; set to **app**..</param>
        /// <param name="sdkTransID">The &#x60;sdkTransID&#x60; value as received from the 3D Secure 2 SDK. Only for &#x60;deviceChannel&#x60; set to **app**..</param>
        /// <param name="threeDSCompInd">Completion indicator for the device fingerprinting..</param>
        /// <param name="threeDSRequestorID">Required for [authentication-only integration](https://docs.adyen.com/checkout/3d-secure-2/3ds2-checkout-authentication-only-integration) for Visa. Unique 3D Secure requestor identifier assigned by the Directory Server when you enrol for 3D Secure 2..</param>
        /// <param name="threeDSRequestorName">Required for [authentication-only integration](https://docs.adyen.com/checkout/3d-secure-2/3ds2-checkout-authentication-only-integration) for Visa. Unique 3D Secure requestor name assigned by the Directory Server when you enrol for 3D Secure 2..</param>
        /// <param name="threeDSRequestorURL">URL of the (customer service) website that will be shown to the shopper in case of technical errors during the 3D Secure 2 process..</param>
        public ThreeDS2RequestData(string AcquirerBIN = default(string), string AcquirerMerchantID = default(string), bool? AuthenticationOnly = default(bool?), ChallengeIndicatorEnum? ChallengeIndicator = default(ChallengeIndicatorEnum?), DeviceChannelEnum? DeviceChannel = default(DeviceChannelEnum), DeviceRenderOptions DeviceRenderOptions = default(DeviceRenderOptions), string Mcc = default(string), string MerchantName = default(string), string MessageVersion = default(string), string NotificationURL = default(string), string SdkAppID = default(string), string SdkEncData = default(string), SDKEphemPubKey SdkEphemPubKey = default(SDKEphemPubKey), int? SdkMaxTimeout = default(int?), string SdkReferenceNumber = default(string), string SdkTransID = default(string), DeviceFingerprintCompletedEnum? ThreeDSCompInd = default(DeviceFingerprintCompletedEnum?), string ThreeDSRequestorID = default(string), string ThreeDSRequestorName = default(string), string ThreeDSRequestorURL = default(string))
        {
            // to ensure "deviceChannel" is required (not null)
            this.DeviceChannel = DeviceChannel ?? throw new InvalidDataException("DeviceChannel is a required property for ThreeDS2RequestData and cannot be null"); ;
            this.AcquirerBIN = AcquirerBIN;
            this.AcquirerMerchantID = AcquirerMerchantID;
            this.AuthenticationOnly = AuthenticationOnly;
            this.ChallengeIndicator = ChallengeIndicator;
            this.DeviceRenderOptions = DeviceRenderOptions;
            this.Mcc = Mcc;
            this.MerchantName = MerchantName;
            this.MessageVersion = MessageVersion;
            this.NotificationURL = NotificationURL;
            this.SdkAppID = SdkAppID;
            this.SdkEncData = SdkEncData;
            this.SdkEphemPubKey = SdkEphemPubKey;
            this.SdkMaxTimeout = SdkMaxTimeout;
            this.SdkReferenceNumber = SdkReferenceNumber;
            this.SdkTransID = SdkTransID;
            this.ThreeDSCompInd = ThreeDSCompInd;
            this.ThreeDSRequestorID = ThreeDSRequestorID;
            this.ThreeDSRequestorName = ThreeDSRequestorName;
            this.ThreeDSRequestorURL = ThreeDSRequestorURL;
        }

        /// <summary>
        /// Required for [authentication-only integration](https://docs.adyen.com/checkout/3d-secure-2/3ds2-checkout-authentication-only-integration). The acquiring BIN enrolled for 3D Secure 2. This string should match the value that you will use in the authorisation.
        /// </summary>
        /// <value>Required for [authentication-only integration](https://docs.adyen.com/checkout/3d-secure-2/3ds2-checkout-authentication-only-integration). The acquiring BIN enrolled for 3D Secure 2. This string should match the value that you will use in the authorisation.</value>
        [DataMember(Name = "acquirerBIN", EmitDefaultValue = false)]
        public string AcquirerBIN { get; set; }

        /// <summary>
        /// Required for [authentication-only integration](https://docs.adyen.com/checkout/3d-secure-2/3ds2-checkout-authentication-only-integration). The merchantId that is enrolled for 3D Secure 2 by the merchant&#x27;s acquirer. This string should match the value that you will use in the authorisation.
        /// </summary>
        /// <value>Required for [authentication-only integration](https://docs.adyen.com/checkout/3d-secure-2/3ds2-checkout-authentication-only-integration). The merchantId that is enrolled for 3D Secure 2 by the merchant&#x27;s acquirer. This string should match the value that you will use in the authorisation.</value>
        [DataMember(Name = "acquirerMerchantID", EmitDefaultValue = false)]
        public string AcquirerMerchantID { get; set; }

        /// <summary>
        /// If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/checkout/3d-secure-2/3ds2-checkout-authentication-only-integration), and not the payment authorisation.
        /// </summary>
        /// <value>If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/checkout/3d-secure-2/3ds2-checkout-authentication-only-integration), and not the payment authorisation.</value>
        [DataMember(Name = "authenticationOnly", EmitDefaultValue = false)]
        public bool? AuthenticationOnly { get; set; }


        /// <summary>
        /// The environment of the shopper. Allowed values: * &#x60;app&#x60; * &#x60;browser&#x60;
        /// </summary>
        /// <value>The environment of the shopper. Allowed values: * &#x60;app&#x60; * &#x60;browser&#x60;</value>
        [DataMember(Name = "deviceChannel", EmitDefaultValue = false)]
        public DeviceChannelEnum? DeviceChannel { get; set; }

        /// <summary>
        /// Gets or Sets DeviceRenderOptions
        /// </summary>
        [DataMember(Name = "deviceRenderOptions", EmitDefaultValue = false)]
        public DeviceRenderOptions DeviceRenderOptions { get; set; }

        /// <summary>
        /// Required for merchants that have been enrolled for 3DS2 by another party than Adyen, mostly [authentication-only integrations](https://docs.adyen.com/checkout/3d-secure-2/3ds2-checkout-authentication-only-integration). The &#x60;mcc&#x60; is a four-digit code with which the previously given &#x60;acquirerMerchantID&#x60; is registered at the scheme.
        /// </summary>
        /// <value>Required for merchants that have been enrolled for 3DS2 by another party than Adyen, mostly [authentication-only integrations](https://docs.adyen.com/checkout/3d-secure-2/3ds2-checkout-authentication-only-integration). The &#x60;mcc&#x60; is a four-digit code with which the previously given &#x60;acquirerMerchantID&#x60; is registered at the scheme.</value>
        [DataMember(Name = "mcc", EmitDefaultValue = false)]
        public string Mcc { get; set; }

        /// <summary>
        /// Required for [authentication-only integration](https://docs.adyen.com/checkout/3d-secure-2/3ds2-checkout-authentication-only-integration). The merchant name that the issuer presents to the shopper if they get a challenge. We recommend to use the same value that you will use in the authorization. Maximum length is 40 characters. &gt; Optional for a [full 3D Secure 2 integration](https://docs.adyen.com/checkout/3d-secure-2/3ds2-checkout-api-integration). Use this field if you are enrolled for 3D Secure 2 with us and want to override the merchant name already configured on your account.
        /// </summary>
        /// <value>Required for [authentication-only integration](https://docs.adyen.com/checkout/3d-secure-2/3ds2-checkout-authentication-only-integration). The merchant name that the issuer presents to the shopper if they get a challenge. We recommend to use the same value that you will use in the authorization. Maximum length is 40 characters. &gt; Optional for a [full 3D Secure 2 integration](https://docs.adyen.com/checkout/3d-secure-2/3ds2-checkout-api-integration). Use this field if you are enrolled for 3D Secure 2 with us and want to override the merchant name already configured on your account.</value>
        [DataMember(Name = "merchantName", EmitDefaultValue = false)]
        public string MerchantName { get; set; }

        /// <summary>
        /// The &#x60;messageVersion&#x60; value indicating the 3D Secure 2 protocol version.
        /// </summary>
        /// <value>The &#x60;messageVersion&#x60; value indicating the 3D Secure 2 protocol version.</value>
        [DataMember(Name = "messageVersion", EmitDefaultValue = false)]
        public string MessageVersion { get; set; }

        /// <summary>
        /// URL to where the issuer should send the CR. Required if you are not using components for &#x60;channel&#x60; **Web** or if you are using classic integration &#x60;deviceChannel&#x60; **browser**.
        /// </summary>
        /// <value>URL to where the issuer should send the &#x60;CRes&#x60;. Required if you are not using components for &#x60;channel&#x60; **Web** or if you are using classic integration &#x60;deviceChannel&#x60; **browser**.</value>
        [DataMember(Name = "notificationURL", EmitDefaultValue = false)]
        public string NotificationURL { get; set; }

        /// <summary>
        /// The &#x60;sdkAppID&#x60; value as received from the 3D Secure 2 SDK. Required for &#x60;deviceChannel&#x60; set to **app**.
        /// </summary>
        /// <value>The &#x60;sdkAppID&#x60; value as received from the 3D Secure 2 SDK. Required for &#x60;deviceChannel&#x60; set to **app**.</value>
        [DataMember(Name = "sdkAppID", EmitDefaultValue = false)]
        public string SdkAppID { get; set; }

        /// <summary>
        /// The &#x60;sdkEncData&#x60; value as received from the 3D Secure 2 SDK. Required for &#x60;deviceChannel&#x60; set to **app**.
        /// </summary>
        /// <value>The &#x60;sdkEncData&#x60; value as received from the 3D Secure 2 SDK. Required for &#x60;deviceChannel&#x60; set to **app**.</value>
        [DataMember(Name = "sdkEncData", EmitDefaultValue = false)]
        public string SdkEncData { get; set; }

        /// <summary>
        /// Gets or Sets SdkEphemPubKey
        /// </summary>
        [DataMember(Name = "sdkEphemPubKey", EmitDefaultValue = false)]
        public SDKEphemPubKey SdkEphemPubKey { get; set; }

        /// <summary>
        /// The maximum amount of time in minutes for the 3D Secure 2 authentication process. Optional and only for &#x60;deviceChannel&#x60; set to **app**. Defaults to **60** minutes.
        /// </summary>
        /// <value>The maximum amount of time in minutes for the 3D Secure 2 authentication process. Optional and only for &#x60;deviceChannel&#x60; set to **app**. Defaults to **60** minutes.</value>
        [DataMember(Name = "sdkMaxTimeout", EmitDefaultValue = false)]
        public int? SdkMaxTimeout { get; set; }

        /// <summary>
        /// The &#x60;sdkReferenceNumber&#x60; value as received from the 3D Secure 2 SDK. Only for &#x60;deviceChannel&#x60; set to **app**.
        /// </summary>
        /// <value>The &#x60;sdkReferenceNumber&#x60; value as received from the 3D Secure 2 SDK. Only for &#x60;deviceChannel&#x60; set to **app**.</value>
        [DataMember(Name = "sdkReferenceNumber", EmitDefaultValue = false)]
        public string SdkReferenceNumber { get; set; }

        /// <summary>
        /// The &#x60;sdkTransID&#x60; value as received from the 3D Secure 2 SDK. Only for &#x60;deviceChannel&#x60; set to **app**.
        /// </summary>
        /// <value>The &#x60;sdkTransID&#x60; value as received from the 3D Secure 2 SDK. Only for &#x60;deviceChannel&#x60; set to **app**.</value>
        [DataMember(Name = "sdkTransID", EmitDefaultValue = false)]
        public string SdkTransID { get; set; }

        /// <summary>
        /// Completion indicator for the device fingerprinting.
        /// </summary>
        /// <value>Completion indicator for the device fingerprinting.</value>
        [DataMember(Name = "threeDSCompInd", EmitDefaultValue = false)]
        public DeviceFingerprintCompletedEnum? ThreeDSCompInd { get; set; }

        /// <summary>
        /// Required for [authentication-only integration](https://docs.adyen.com/checkout/3d-secure-2/3ds2-checkout-authentication-only-integration) for Visa. Unique 3D Secure requestor identifier assigned by the Directory Server when you enrol for 3D Secure 2.
        /// </summary>
        /// <value>Required for [authentication-only integration](https://docs.adyen.com/checkout/3d-secure-2/3ds2-checkout-authentication-only-integration) for Visa. Unique 3D Secure requestor identifier assigned by the Directory Server when you enrol for 3D Secure 2.</value>
        [DataMember(Name = "threeDSRequestorID", EmitDefaultValue = false)]
        public string ThreeDSRequestorID { get; set; }

        /// <summary>
        /// Required for [authentication-only integration](https://docs.adyen.com/checkout/3d-secure-2/3ds2-checkout-authentication-only-integration) for Visa. Unique 3D Secure requestor name assigned by the Directory Server when you enrol for 3D Secure 2.
        /// </summary>
        /// <value>Required for [authentication-only integration](https://docs.adyen.com/checkout/3d-secure-2/3ds2-checkout-authentication-only-integration) for Visa. Unique 3D Secure requestor name assigned by the Directory Server when you enrol for 3D Secure 2.</value>
        [DataMember(Name = "threeDSRequestorName", EmitDefaultValue = false)]
        public string ThreeDSRequestorName { get; set; }

        /// <summary>
        /// URL of the (customer service) website that will be shown to the shopper in case of technical errors during the 3D Secure 2 process.
        /// </summary>
        /// <value>URL of the (customer service) website that will be shown to the shopper in case of technical errors during the 3D Secure 2 process.</value>
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
            sb.Append("  AcquirerBIN: ").Append(AcquirerBIN).Append("\n");
            sb.Append("  AcquirerMerchantID: ").Append(AcquirerMerchantID).Append("\n");
            sb.Append("  AuthenticationOnly: ").Append(AuthenticationOnly).Append("\n");
            sb.Append("  ChallengeIndicator: ").Append(ChallengeIndicator).Append("\n");
            sb.Append("  DeviceChannel: ").Append(DeviceChannel).Append("\n");
            sb.Append("  DeviceRenderOptions: ").Append(DeviceRenderOptions).Append("\n");
            sb.Append("  Mcc: ").Append(Mcc).Append("\n");
            sb.Append("  MerchantName: ").Append(MerchantName).Append("\n");
            sb.Append("  MessageVersion: ").Append(MessageVersion).Append("\n");
            sb.Append("  NotificationURL: ").Append(NotificationURL).Append("\n");
            sb.Append("  SdkAppID: ").Append(SdkAppID).Append("\n");
            sb.Append("  SdkEncData: ").Append(SdkEncData).Append("\n");
            sb.Append("  SdkEphemPubKey: ").Append(SdkEphemPubKey).Append("\n");
            sb.Append("  SdkMaxTimeout: ").Append(SdkMaxTimeout).Append("\n");
            sb.Append("  SdkReferenceNumber: ").Append(SdkReferenceNumber).Append("\n");
            sb.Append("  SdkTransID: ").Append(SdkTransID).Append("\n");
            sb.Append("  ThreeDSCompInd: ").Append(ThreeDSCompInd).Append("\n");
            sb.Append("  ThreeDSRequestorID: ").Append(ThreeDSRequestorID).Append("\n");
            sb.Append("  ThreeDSRequestorName: ").Append(ThreeDSRequestorName).Append("\n");
            sb.Append("  ThreeDSRequestorURL: ").Append(ThreeDSRequestorURL).Append("\n");
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
            return this.Equals(input as ThreeDS2RequestData);
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
                    this.AcquirerBIN == input.AcquirerBIN ||
                    (this.AcquirerBIN != null &&
                    this.AcquirerBIN.Equals(input.AcquirerBIN))
                ) &&
                (
                    this.AcquirerMerchantID == input.AcquirerMerchantID ||
                    (this.AcquirerMerchantID != null &&
                    this.AcquirerMerchantID.Equals(input.AcquirerMerchantID))
                ) &&
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
                    this.Mcc == input.Mcc ||
                    (this.Mcc != null &&
                    this.Mcc.Equals(input.Mcc))
                ) &&
                (
                    this.MerchantName == input.MerchantName ||
                    (this.MerchantName != null &&
                    this.MerchantName.Equals(input.MerchantName))
                ) &&
                (
                    this.MessageVersion == input.MessageVersion ||
                    (this.MessageVersion != null &&
                    this.MessageVersion.Equals(input.MessageVersion))
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
                    this.ThreeDSRequestorID == input.ThreeDSRequestorID ||
                    (this.ThreeDSRequestorID != null &&
                    this.ThreeDSRequestorID.Equals(input.ThreeDSRequestorID))
                ) &&
                (
                    this.ThreeDSRequestorName == input.ThreeDSRequestorName ||
                    (this.ThreeDSRequestorName != null &&
                    this.ThreeDSRequestorName.Equals(input.ThreeDSRequestorName))
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
                if (this.AcquirerBIN != null)
                    hashCode = hashCode * 59 + this.AcquirerBIN.GetHashCode();
                if (this.AcquirerMerchantID != null)
                    hashCode = hashCode * 59 + this.AcquirerMerchantID.GetHashCode();
                if (this.AuthenticationOnly != null)
                    hashCode = hashCode * 59 + this.AuthenticationOnly.GetHashCode();
                if (this.ChallengeIndicator != null)
                    hashCode = hashCode * 59 + this.ChallengeIndicator.GetHashCode();
                if (this.DeviceChannel != null)
                    hashCode = hashCode * 59 + this.DeviceChannel.GetHashCode();
                if (this.DeviceRenderOptions != null)
                    hashCode = hashCode * 59 + this.DeviceRenderOptions.GetHashCode();
                if (this.Mcc != null)
                    hashCode = hashCode * 59 + this.Mcc.GetHashCode();
                if (this.MerchantName != null)
                    hashCode = hashCode * 59 + this.MerchantName.GetHashCode();
                if (this.MessageVersion != null)
                    hashCode = hashCode * 59 + this.MessageVersion.GetHashCode();
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
                if (this.ThreeDSRequestorID != null)
                    hashCode = hashCode * 59 + this.ThreeDSRequestorID.GetHashCode();
                if (this.ThreeDSRequestorName != null)
                    hashCode = hashCode * 59 + this.ThreeDSRequestorName.GetHashCode();
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
