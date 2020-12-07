using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ThreeDS2RequestData {
    /// <summary>
    /// Required for [authentication-only integration](https://docs.adyen.com/checkout/3d-secure/other-3ds-flows/authentication-only). The acquiring BIN enrolled for 3D Secure 2. This string should match the value that you will use in the authorisation. Use 123456 on the Test platform.
    /// </summary>
    /// <value>Required for [authentication-only integration](https://docs.adyen.com/checkout/3d-secure/other-3ds-flows/authentication-only). The acquiring BIN enrolled for 3D Secure 2. This string should match the value that you will use in the authorisation. Use 123456 on the Test platform.</value>
    [DataMember(Name="acquirerBIN", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "acquirerBIN")]
    public string AcquirerBIN { get; set; }

    /// <summary>
    /// Required for [authentication-only integration](https://docs.adyen.com/checkout/3d-secure/other-3ds-flows/authentication-only). The merchantId that is enrolled for 3D Secure 2 by the merchant's acquirer. This string should match the value that you will use in the authorisation. Use 123456 on the Test platform.
    /// </summary>
    /// <value>Required for [authentication-only integration](https://docs.adyen.com/checkout/3d-secure/other-3ds-flows/authentication-only). The merchantId that is enrolled for 3D Secure 2 by the merchant's acquirer. This string should match the value that you will use in the authorisation. Use 123456 on the Test platform.</value>
    [DataMember(Name="acquirerMerchantID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "acquirerMerchantID")]
    public string AcquirerMerchantID { get; set; }

    /// <summary>
    /// If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/checkout/3d-secure/other-3ds-flows/authentication-only), and not the payment authorisation.
    /// </summary>
    /// <value>If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/checkout/3d-secure/other-3ds-flows/authentication-only), and not the payment authorisation.</value>
    [DataMember(Name="authenticationOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authenticationOnly")]
    public bool? AuthenticationOnly { get; set; }

    /// <summary>
    /// Possibility to specify a preference for receiving a challenge from the issuer. Allowed values: * `noPreference` * `requestNoChallenge` * `requestChallenge` * `requestChallengeAsMandate` 
    /// </summary>
    /// <value>Possibility to specify a preference for receiving a challenge from the issuer. Allowed values: * `noPreference` * `requestNoChallenge` * `requestChallenge` * `requestChallengeAsMandate` </value>
    [DataMember(Name="challengeIndicator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "challengeIndicator")]
    public string ChallengeIndicator { get; set; }

    /// <summary>
    /// The environment of the shopper. Allowed values: * `app` * `browser`
    /// </summary>
    /// <value>The environment of the shopper. Allowed values: * `app` * `browser`</value>
    [DataMember(Name="deviceChannel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deviceChannel")]
    public string DeviceChannel { get; set; }

    /// <summary>
    /// Gets or Sets DeviceRenderOptions
    /// </summary>
    [DataMember(Name="deviceRenderOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deviceRenderOptions")]
    public DeviceRenderOptions DeviceRenderOptions { get; set; }

    /// <summary>
    /// Required for merchants that have been enrolled for 3D Secure 2 by another party than Adyen, mostly [authentication-only integrations](https://docs.adyen.com/checkout/3d-secure/other-3ds-flows/authentication-only). The `mcc` is a four-digit code with which the previously given `acquirerMerchantID` is registered at the scheme.
    /// </summary>
    /// <value>Required for merchants that have been enrolled for 3D Secure 2 by another party than Adyen, mostly [authentication-only integrations](https://docs.adyen.com/checkout/3d-secure/other-3ds-flows/authentication-only). The `mcc` is a four-digit code with which the previously given `acquirerMerchantID` is registered at the scheme.</value>
    [DataMember(Name="mcc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mcc")]
    public string Mcc { get; set; }

    /// <summary>
    /// Required for [authentication-only integration](https://docs.adyen.com/checkout/3d-secure/other-3ds-flows/authentication-only). The merchant name that the issuer presents to the shopper if they get a challenge. We recommend to use the same value that you will use in the authorization. Maximum length is 40 characters. > Optional for a [full 3D Secure 2 integration](https://docs.adyen.com/checkout/3d-secure/native-3ds2/api-integration). Use this field if you are enrolled for 3D Secure 2 with us and want to override the merchant name already configured on your account.
    /// </summary>
    /// <value>Required for [authentication-only integration](https://docs.adyen.com/checkout/3d-secure/other-3ds-flows/authentication-only). The merchant name that the issuer presents to the shopper if they get a challenge. We recommend to use the same value that you will use in the authorization. Maximum length is 40 characters. > Optional for a [full 3D Secure 2 integration](https://docs.adyen.com/checkout/3d-secure/native-3ds2/api-integration). Use this field if you are enrolled for 3D Secure 2 with us and want to override the merchant name already configured on your account.</value>
    [DataMember(Name="merchantName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantName")]
    public string MerchantName { get; set; }

    /// <summary>
    /// The `messageVersion` value indicating the 3D Secure 2 protocol version.
    /// </summary>
    /// <value>The `messageVersion` value indicating the 3D Secure 2 protocol version.</value>
    [DataMember(Name="messageVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "messageVersion")]
    public string MessageVersion { get; set; }

    /// <summary>
    /// URL to where the issuer should send the `CRes`. Required if you are not using components for `channel` **Web** or if you are using classic integration `deviceChannel` **browser**.
    /// </summary>
    /// <value>URL to where the issuer should send the `CRes`. Required if you are not using components for `channel` **Web** or if you are using classic integration `deviceChannel` **browser**.</value>
    [DataMember(Name="notificationURL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notificationURL")]
    public string NotificationURL { get; set; }

    /// <summary>
    /// The `sdkAppID` value as received from the 3D Secure 2 SDK. Required for `deviceChannel` set to **app**.
    /// </summary>
    /// <value>The `sdkAppID` value as received from the 3D Secure 2 SDK. Required for `deviceChannel` set to **app**.</value>
    [DataMember(Name="sdkAppID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sdkAppID")]
    public string SdkAppID { get; set; }

    /// <summary>
    /// The `sdkEncData` value as received from the 3D Secure 2 SDK. Required for `deviceChannel` set to **app**.
    /// </summary>
    /// <value>The `sdkEncData` value as received from the 3D Secure 2 SDK. Required for `deviceChannel` set to **app**.</value>
    [DataMember(Name="sdkEncData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sdkEncData")]
    public string SdkEncData { get; set; }

    /// <summary>
    /// Gets or Sets SdkEphemPubKey
    /// </summary>
    [DataMember(Name="sdkEphemPubKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sdkEphemPubKey")]
    public SDKEphemPubKey SdkEphemPubKey { get; set; }

    /// <summary>
    /// The maximum amount of time in minutes for the 3D Secure 2 authentication process. Optional and only for `deviceChannel` set to **app**. Defaults to **60** minutes.
    /// </summary>
    /// <value>The maximum amount of time in minutes for the 3D Secure 2 authentication process. Optional and only for `deviceChannel` set to **app**. Defaults to **60** minutes.</value>
    [DataMember(Name="sdkMaxTimeout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sdkMaxTimeout")]
    public int? SdkMaxTimeout { get; set; }

    /// <summary>
    /// The `sdkReferenceNumber` value as received from the 3D Secure 2 SDK. Only for `deviceChannel` set to **app**.
    /// </summary>
    /// <value>The `sdkReferenceNumber` value as received from the 3D Secure 2 SDK. Only for `deviceChannel` set to **app**.</value>
    [DataMember(Name="sdkReferenceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sdkReferenceNumber")]
    public string SdkReferenceNumber { get; set; }

    /// <summary>
    /// The `sdkTransID` value as received from the 3D Secure 2 SDK. Only for `deviceChannel` set to **app**.
    /// </summary>
    /// <value>The `sdkTransID` value as received from the 3D Secure 2 SDK. Only for `deviceChannel` set to **app**.</value>
    [DataMember(Name="sdkTransID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sdkTransID")]
    public string SdkTransID { get; set; }

    /// <summary>
    /// Completion indicator for the device fingerprinting.
    /// </summary>
    /// <value>Completion indicator for the device fingerprinting.</value>
    [DataMember(Name="threeDSCompInd", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "threeDSCompInd")]
    public string ThreeDSCompInd { get; set; }

    /// <summary>
    /// Required for [authentication-only integration](https://docs.adyen.com/checkout/3d-secure/other-3ds-flows/authentication-only) for Visa. Unique 3D Secure requestor identifier assigned by the Directory Server when you enrol for 3D Secure 2.
    /// </summary>
    /// <value>Required for [authentication-only integration](https://docs.adyen.com/checkout/3d-secure/other-3ds-flows/authentication-only) for Visa. Unique 3D Secure requestor identifier assigned by the Directory Server when you enrol for 3D Secure 2.</value>
    [DataMember(Name="threeDSRequestorID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "threeDSRequestorID")]
    public string ThreeDSRequestorID { get; set; }

    /// <summary>
    /// Required for [authentication-only integration](https://docs.adyen.com/checkout/3d-secure/other-3ds-flows/authentication-only) for Visa. Unique 3D Secure requestor name assigned by the Directory Server when you enrol for 3D Secure 2.
    /// </summary>
    /// <value>Required for [authentication-only integration](https://docs.adyen.com/checkout/3d-secure/other-3ds-flows/authentication-only) for Visa. Unique 3D Secure requestor name assigned by the Directory Server when you enrol for 3D Secure 2.</value>
    [DataMember(Name="threeDSRequestorName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "threeDSRequestorName")]
    public string ThreeDSRequestorName { get; set; }

    /// <summary>
    /// URL of the (customer service) website that will be shown to the shopper in case of technical errors during the 3D Secure 2 process.
    /// </summary>
    /// <value>URL of the (customer service) website that will be shown to the shopper in case of technical errors during the 3D Secure 2 process.</value>
    [DataMember(Name="threeDSRequestorURL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "threeDSRequestorURL")]
    public string ThreeDSRequestorURL { get; set; }

    /// <summary>
    /// Identify the type of the transaction being authenticated.
    /// </summary>
    /// <value>Identify the type of the transaction being authenticated.</value>
    [DataMember(Name="transactionType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionType")]
    public string TransactionType { get; set; }

    /// <summary>
    /// The `whiteListStatus` value returned from a previous 3D Secure 2 transaction, only applicable for 3D Secure 2 protocol version 2.2.0.
    /// </summary>
    /// <value>The `whiteListStatus` value returned from a previous 3D Secure 2 transaction, only applicable for 3D Secure 2 protocol version 2.2.0.</value>
    [DataMember(Name="whiteListStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "whiteListStatus")]
    public string WhiteListStatus { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
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
      sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
      sb.Append("  WhiteListStatus: ").Append(WhiteListStatus).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
