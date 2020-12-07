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
  public class ResponseAdditionalDataPayPal {
    /// <summary>
    /// The buyer's PayPal account email address.  Example: paypaltest@adyen.com
    /// </summary>
    /// <value>The buyer's PayPal account email address.  Example: paypaltest@adyen.com</value>
    [DataMember(Name="paypalEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paypalEmail")]
    public string PaypalEmail { get; set; }

    /// <summary>
    /// The buyer's PayPal ID.  Example: LF5HCWWBRV2KL
    /// </summary>
    /// <value>The buyer's PayPal ID.  Example: LF5HCWWBRV2KL</value>
    [DataMember(Name="paypalPayerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paypalPayerId")]
    public string PaypalPayerId { get; set; }

    /// <summary>
    /// The buyer's country of residence.  Example: NL
    /// </summary>
    /// <value>The buyer's country of residence.  Example: NL</value>
    [DataMember(Name="paypalPayerResidenceCountry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paypalPayerResidenceCountry")]
    public string PaypalPayerResidenceCountry { get; set; }

    /// <summary>
    /// The status of the buyer's PayPal account.  Example: unverified
    /// </summary>
    /// <value>The status of the buyer's PayPal account.  Example: unverified</value>
    [DataMember(Name="paypalPayerStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paypalPayerStatus")]
    public string PaypalPayerStatus { get; set; }

    /// <summary>
    /// The eligibility for PayPal Seller Protection for this payment.  Example: Ineligible
    /// </summary>
    /// <value>The eligibility for PayPal Seller Protection for this payment.  Example: Ineligible</value>
    [DataMember(Name="paypalProtectionEligibility", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paypalProtectionEligibility")]
    public string PaypalProtectionEligibility { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ResponseAdditionalDataPayPal {\n");
      sb.Append("  PaypalEmail: ").Append(PaypalEmail).Append("\n");
      sb.Append("  PaypalPayerId: ").Append(PaypalPayerId).Append("\n");
      sb.Append("  PaypalPayerResidenceCountry: ").Append(PaypalPayerResidenceCountry).Append("\n");
      sb.Append("  PaypalPayerStatus: ").Append(PaypalPayerStatus).Append("\n");
      sb.Append("  PaypalProtectionEligibility: ").Append(PaypalProtectionEligibility).Append("\n");
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
