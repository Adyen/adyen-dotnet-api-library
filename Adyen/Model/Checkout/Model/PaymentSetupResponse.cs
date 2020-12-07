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
  public class PaymentSetupResponse {
    /// <summary>
    /// The encoded payment session that you need to pass to the SDK.
    /// </summary>
    /// <value>The encoded payment session that you need to pass to the SDK.</value>
    [DataMember(Name="paymentSession", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentSession")]
    public string PaymentSession { get; set; }

    /// <summary>
    /// The detailed list of stored payment details required to generate payment forms. Will be empty if oneClick is set to false in the request.
    /// </summary>
    /// <value>The detailed list of stored payment details required to generate payment forms. Will be empty if oneClick is set to false in the request.</value>
    [DataMember(Name="recurringDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurringDetails")]
    public List<RecurringDetail> RecurringDetails { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentSetupResponse {\n");
      sb.Append("  PaymentSession: ").Append(PaymentSession).Append("\n");
      sb.Append("  RecurringDetails: ").Append(RecurringDetails).Append("\n");
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
