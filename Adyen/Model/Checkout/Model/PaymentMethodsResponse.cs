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
  public class PaymentMethodsResponse {
    /// <summary>
    /// Detailed list of payment methods required to generate payment forms.
    /// </summary>
    /// <value>Detailed list of payment methods required to generate payment forms.</value>
    [DataMember(Name="paymentMethods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentMethods")]
    public List<PaymentMethod> PaymentMethods { get; set; }

    /// <summary>
    /// List of all stored payment methods.
    /// </summary>
    /// <value>List of all stored payment methods.</value>
    [DataMember(Name="storedPaymentMethods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storedPaymentMethods")]
    public List<StoredPaymentMethod> StoredPaymentMethods { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentMethodsResponse {\n");
      sb.Append("  PaymentMethods: ").Append(PaymentMethods).Append("\n");
      sb.Append("  StoredPaymentMethods: ").Append(StoredPaymentMethods).Append("\n");
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
