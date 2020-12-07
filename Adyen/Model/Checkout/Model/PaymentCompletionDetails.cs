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
  public class PaymentCompletionDetails {
    /// <summary>
    /// A payment session identifier returned by the card issuer.
    /// </summary>
    /// <value>A payment session identifier returned by the card issuer.</value>
    [DataMember(Name="MD", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MD")]
    public string MD { get; set; }

    /// <summary>
    /// (3D) Payment Authentication Request data for the card issuer.
    /// </summary>
    /// <value>(3D) Payment Authentication Request data for the card issuer.</value>
    [DataMember(Name="PaReq", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaReq")]
    public string PaReq { get; set; }

    /// <summary>
    /// (3D) Payment Authentication Response data by the card issuer.
    /// </summary>
    /// <value>(3D) Payment Authentication Response data by the card issuer.</value>
    [DataMember(Name="PaRes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PaRes")]
    public string PaRes { get; set; }

    /// <summary>
    /// PayPal-generated token for recurring payments.
    /// </summary>
    /// <value>PayPal-generated token for recurring payments.</value>
    [DataMember(Name="billingToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billingToken")]
    public string BillingToken { get; set; }

    /// <summary>
    /// The SMS verification code collected from the shopper.
    /// </summary>
    /// <value>The SMS verification code collected from the shopper.</value>
    [DataMember(Name="cupsecureplus.smscode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cupsecureplus.smscode")]
    public string CupsecureplusSmscode { get; set; }

    /// <summary>
    /// PayPal-generated third party access token.
    /// </summary>
    /// <value>PayPal-generated third party access token.</value>
    [DataMember(Name="facilitatorAccessToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "facilitatorAccessToken")]
    public string FacilitatorAccessToken { get; set; }

    /// <summary>
    /// A random number sent to the mobile phone number of the shopper to verify the payment.
    /// </summary>
    /// <value>A random number sent to the mobile phone number of the shopper to verify the payment.</value>
    [DataMember(Name="oneTimePasscode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "oneTimePasscode")]
    public string OneTimePasscode { get; set; }

    /// <summary>
    /// PayPal-assigned ID for the order.
    /// </summary>
    /// <value>PayPal-assigned ID for the order.</value>
    [DataMember(Name="orderID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderID")]
    public string OrderID { get; set; }

    /// <summary>
    /// PayPal-assigned ID for the payer (shopper).
    /// </summary>
    /// <value>PayPal-assigned ID for the payer (shopper).</value>
    [DataMember(Name="payerID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payerID")]
    public string PayerID { get; set; }

    /// <summary>
    /// Payload appended to the `returnURL` as a result of the redirect.
    /// </summary>
    /// <value>Payload appended to the `returnURL` as a result of the redirect.</value>
    [DataMember(Name="payload", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payload")]
    public string Payload { get; set; }

    /// <summary>
    /// PayPal-generated ID for the payment.
    /// </summary>
    /// <value>PayPal-generated ID for the payment.</value>
    [DataMember(Name="paymentID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentID")]
    public string PaymentID { get; set; }

    /// <summary>
    /// Value passed from the WeChat MiniProgram `wx.requestPayment` **complete** callback. Possible values: any value starting with `requestPayment:`.
    /// </summary>
    /// <value>Value passed from the WeChat MiniProgram `wx.requestPayment` **complete** callback. Possible values: any value starting with `requestPayment:`.</value>
    [DataMember(Name="paymentStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentStatus")]
    public string PaymentStatus { get; set; }

    /// <summary>
    /// The result of the redirect as appended to the `returnURL`.
    /// </summary>
    /// <value>The result of the redirect as appended to the `returnURL`.</value>
    [DataMember(Name="redirectResult", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "redirectResult")]
    public string RedirectResult { get; set; }

    /// <summary>
    /// Base64-encoded string returned by the Component after the challenge flow. It contains the following parameters: `transStatus`, `authorisationToken`.
    /// </summary>
    /// <value>Base64-encoded string returned by the Component after the challenge flow. It contains the following parameters: `transStatus`, `authorisationToken`.</value>
    [DataMember(Name="threeDSResult", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "threeDSResult")]
    public string ThreeDSResult { get; set; }

    /// <summary>
    /// Base64-encoded string returned by the Component after the challenge flow. It contains the following parameter: `transStatus`.
    /// </summary>
    /// <value>Base64-encoded string returned by the Component after the challenge flow. It contains the following parameter: `transStatus`.</value>
    [DataMember(Name="threeds2.challengeResult", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "threeds2.challengeResult")]
    public string Threeds2ChallengeResult { get; set; }

    /// <summary>
    /// Base64-encoded string returned by the Component after the challenge flow. It contains the following parameter: `threeDSCompInd`.
    /// </summary>
    /// <value>Base64-encoded string returned by the Component after the challenge flow. It contains the following parameter: `threeDSCompInd`.</value>
    [DataMember(Name="threeds2.fingerprint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "threeds2.fingerprint")]
    public string Threeds2Fingerprint { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentCompletionDetails {\n");
      sb.Append("  MD: ").Append(MD).Append("\n");
      sb.Append("  PaReq: ").Append(PaReq).Append("\n");
      sb.Append("  PaRes: ").Append(PaRes).Append("\n");
      sb.Append("  BillingToken: ").Append(BillingToken).Append("\n");
      sb.Append("  CupsecureplusSmscode: ").Append(CupsecureplusSmscode).Append("\n");
      sb.Append("  FacilitatorAccessToken: ").Append(FacilitatorAccessToken).Append("\n");
      sb.Append("  OneTimePasscode: ").Append(OneTimePasscode).Append("\n");
      sb.Append("  OrderID: ").Append(OrderID).Append("\n");
      sb.Append("  PayerID: ").Append(PayerID).Append("\n");
      sb.Append("  Payload: ").Append(Payload).Append("\n");
      sb.Append("  PaymentID: ").Append(PaymentID).Append("\n");
      sb.Append("  PaymentStatus: ").Append(PaymentStatus).Append("\n");
      sb.Append("  RedirectResult: ").Append(RedirectResult).Append("\n");
      sb.Append("  ThreeDSResult: ").Append(ThreeDSResult).Append("\n");
      sb.Append("  Threeds2ChallengeResult: ").Append(Threeds2ChallengeResult).Append("\n");
      sb.Append("  Threeds2Fingerprint: ").Append(Threeds2Fingerprint).Append("\n");
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
