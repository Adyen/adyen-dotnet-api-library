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
  public class SepaDirectDebitDetails {
    /// <summary>
    /// The International Bank Account Number (IBAN).
    /// </summary>
    /// <value>The International Bank Account Number (IBAN).</value>
    [DataMember(Name="iban", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "iban")]
    public string Iban { get; set; }

    /// <summary>
    /// The name of the bank account holder.
    /// </summary>
    /// <value>The name of the bank account holder.</value>
    [DataMember(Name="ownerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ownerName")]
    public string OwnerName { get; set; }

    /// <summary>
    /// This is the `recurringDetailReference` returned in the response when you created the token.
    /// </summary>
    /// <value>This is the `recurringDetailReference` returned in the response when you created the token.</value>
    [DataMember(Name="recurringDetailReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurringDetailReference")]
    public string RecurringDetailReference { get; set; }

    /// <summary>
    /// This is the `recurringDetailReference` returned in the response when you created the token.
    /// </summary>
    /// <value>This is the `recurringDetailReference` returned in the response when you created the token.</value>
    [DataMember(Name="storedPaymentMethodId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storedPaymentMethodId")]
    public string StoredPaymentMethodId { get; set; }

    /// <summary>
    /// **sepadirectdebit**
    /// </summary>
    /// <value>**sepadirectdebit**</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SepaDirectDebitDetails {\n");
      sb.Append("  Iban: ").Append(Iban).Append("\n");
      sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
      sb.Append("  RecurringDetailReference: ").Append(RecurringDetailReference).Append("\n");
      sb.Append("  StoredPaymentMethodId: ").Append(StoredPaymentMethodId).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
