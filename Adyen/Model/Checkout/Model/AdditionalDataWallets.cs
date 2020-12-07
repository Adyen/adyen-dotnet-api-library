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
  public class AdditionalDataWallets {
    /// <summary>
    /// The Android Pay token retrieved from the SDK.
    /// </summary>
    /// <value>The Android Pay token retrieved from the SDK.</value>
    [DataMember(Name="androidpay.token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "androidpay.token")]
    public string AndroidpayToken { get; set; }

    /// <summary>
    /// The Mastercard Masterpass Transaction ID retrieved from the SDK.
    /// </summary>
    /// <value>The Mastercard Masterpass Transaction ID retrieved from the SDK.</value>
    [DataMember(Name="masterpass.transactionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "masterpass.transactionId")]
    public string MasterpassTransactionId { get; set; }

    /// <summary>
    /// The Apple Pay token retrieved from the SDK.
    /// </summary>
    /// <value>The Apple Pay token retrieved from the SDK.</value>
    [DataMember(Name="payment.token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payment.token")]
    public string PaymentToken { get; set; }

    /// <summary>
    /// The Google Pay token retrieved from the SDK.
    /// </summary>
    /// <value>The Google Pay token retrieved from the SDK.</value>
    [DataMember(Name="paywithgoogle.token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paywithgoogle.token")]
    public string PaywithgoogleToken { get; set; }

    /// <summary>
    /// The Samsung Pay token retrieved from the SDK.
    /// </summary>
    /// <value>The Samsung Pay token retrieved from the SDK.</value>
    [DataMember(Name="samsungpay.token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "samsungpay.token")]
    public string SamsungpayToken { get; set; }

    /// <summary>
    /// The Visa Checkout Call ID retrieved from the SDK.
    /// </summary>
    /// <value>The Visa Checkout Call ID retrieved from the SDK.</value>
    [DataMember(Name="visacheckout.callId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visacheckout.callId")]
    public string VisacheckoutCallId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AdditionalDataWallets {\n");
      sb.Append("  AndroidpayToken: ").Append(AndroidpayToken).Append("\n");
      sb.Append("  MasterpassTransactionId: ").Append(MasterpassTransactionId).Append("\n");
      sb.Append("  PaymentToken: ").Append(PaymentToken).Append("\n");
      sb.Append("  PaywithgoogleToken: ").Append(PaywithgoogleToken).Append("\n");
      sb.Append("  SamsungpayToken: ").Append(SamsungpayToken).Append("\n");
      sb.Append("  VisacheckoutCallId: ").Append(VisacheckoutCallId).Append("\n");
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
