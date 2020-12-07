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
  public class KlarnaDetails {
    /// <summary>
    /// Gets or Sets BankAccount
    /// </summary>
    [DataMember(Name="bankAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bankAccount")]
    public string BankAccount { get; set; }

    /// <summary>
    /// Gets or Sets BillingAddress
    /// </summary>
    [DataMember(Name="billingAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billingAddress")]
    public string BillingAddress { get; set; }

    /// <summary>
    /// Gets or Sets DeliveryAddress
    /// </summary>
    [DataMember(Name="deliveryAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deliveryAddress")]
    public string DeliveryAddress { get; set; }

    /// <summary>
    /// Gets or Sets InstallmentConfigurationKey
    /// </summary>
    [DataMember(Name="installmentConfigurationKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "installmentConfigurationKey")]
    public string InstallmentConfigurationKey { get; set; }

    /// <summary>
    /// Gets or Sets PersonalDetails
    /// </summary>
    [DataMember(Name="personalDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "personalDetails")]
    public string PersonalDetails { get; set; }

    /// <summary>
    /// This is the `recurringDetailReference` returned in the response when you created the token.
    /// </summary>
    /// <value>This is the `recurringDetailReference` returned in the response when you created the token.</value>
    [DataMember(Name="recurringDetailReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurringDetailReference")]
    public string RecurringDetailReference { get; set; }

    /// <summary>
    /// Gets or Sets SeparateDeliveryAddress
    /// </summary>
    [DataMember(Name="separateDeliveryAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "separateDeliveryAddress")]
    public string SeparateDeliveryAddress { get; set; }

    /// <summary>
    /// This is the `recurringDetailReference` returned in the response when you created the token.
    /// </summary>
    /// <value>This is the `recurringDetailReference` returned in the response when you created the token.</value>
    [DataMember(Name="storedPaymentMethodId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storedPaymentMethodId")]
    public string StoredPaymentMethodId { get; set; }

    /// <summary>
    /// **klarna**
    /// </summary>
    /// <value>**klarna**</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class KlarnaDetails {\n");
      sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
      sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
      sb.Append("  DeliveryAddress: ").Append(DeliveryAddress).Append("\n");
      sb.Append("  InstallmentConfigurationKey: ").Append(InstallmentConfigurationKey).Append("\n");
      sb.Append("  PersonalDetails: ").Append(PersonalDetails).Append("\n");
      sb.Append("  RecurringDetailReference: ").Append(RecurringDetailReference).Append("\n");
      sb.Append("  SeparateDeliveryAddress: ").Append(SeparateDeliveryAddress).Append("\n");
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
