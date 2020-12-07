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
  public class PayUUpiDetails {
    /// <summary>
    /// This is the `recurringDetailReference` returned in the response when you created the token.
    /// </summary>
    /// <value>This is the `recurringDetailReference` returned in the response when you created the token.</value>
    [DataMember(Name="recurringDetailReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurringDetailReference")]
    public string RecurringDetailReference { get; set; }

    /// <summary>
    /// The `shopperNotificationReference` returned in the response when you requested to notify the shopper. Used for recurring payment only.
    /// </summary>
    /// <value>The `shopperNotificationReference` returned in the response when you requested to notify the shopper. Used for recurring payment only.</value>
    [DataMember(Name="shopperNotificationReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shopperNotificationReference")]
    public string ShopperNotificationReference { get; set; }

    /// <summary>
    /// This is the `recurringDetailReference` returned in the response when you created the token.
    /// </summary>
    /// <value>This is the `recurringDetailReference` returned in the response when you created the token.</value>
    [DataMember(Name="storedPaymentMethodId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storedPaymentMethodId")]
    public string StoredPaymentMethodId { get; set; }

    /// <summary>
    /// Gets or Sets SubscriptionDetails
    /// </summary>
    [DataMember(Name="subscriptionDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscriptionDetails")]
    public SubscriptionDetails SubscriptionDetails { get; set; }

    /// <summary>
    /// **payu_IN_upi**
    /// </summary>
    /// <value>**payu_IN_upi**</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The virtual payment address for UPI.
    /// </summary>
    /// <value>The virtual payment address for UPI.</value>
    [DataMember(Name="virtualPaymentAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "virtualPaymentAddress")]
    public string VirtualPaymentAddress { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PayUUpiDetails {\n");
      sb.Append("  RecurringDetailReference: ").Append(RecurringDetailReference).Append("\n");
      sb.Append("  ShopperNotificationReference: ").Append(ShopperNotificationReference).Append("\n");
      sb.Append("  StoredPaymentMethodId: ").Append(StoredPaymentMethodId).Append("\n");
      sb.Append("  SubscriptionDetails: ").Append(SubscriptionDetails).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  VirtualPaymentAddress: ").Append(VirtualPaymentAddress).Append("\n");
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
