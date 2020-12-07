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
  public class MerchantRiskIndicator {
    /// <summary>
    /// Whether the chosen delivery address is identical to the billing address.
    /// </summary>
    /// <value>Whether the chosen delivery address is identical to the billing address.</value>
    [DataMember(Name="addressMatch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addressMatch")]
    public bool? AddressMatch { get; set; }

    /// <summary>
    /// Indicator regarding the delivery address. Allowed values: * `shipToBillingAddress` * `shipToVerifiedAddress` * `shipToNewAddress` * `shipToStore` * `digitalGoods` * `goodsNotShipped` * `other`
    /// </summary>
    /// <value>Indicator regarding the delivery address. Allowed values: * `shipToBillingAddress` * `shipToVerifiedAddress` * `shipToNewAddress` * `shipToStore` * `digitalGoods` * `goodsNotShipped` * `other`</value>
    [DataMember(Name="deliveryAddressIndicator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deliveryAddressIndicator")]
    public string DeliveryAddressIndicator { get; set; }

    /// <summary>
    /// The delivery email address (for digital goods).
    /// </summary>
    /// <value>The delivery email address (for digital goods).</value>
    [DataMember(Name="deliveryEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deliveryEmail")]
    public string DeliveryEmail { get; set; }

    /// <summary>
    /// The estimated delivery time for the shopper to receive the goods. Allowed values: * `electronicDelivery` * `sameDayShipping` * `overnightShipping` * `twoOrMoreDaysShipping`
    /// </summary>
    /// <value>The estimated delivery time for the shopper to receive the goods. Allowed values: * `electronicDelivery` * `sameDayShipping` * `overnightShipping` * `twoOrMoreDaysShipping`</value>
    [DataMember(Name="deliveryTimeframe", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deliveryTimeframe")]
    public string DeliveryTimeframe { get; set; }

    /// <summary>
    /// Gets or Sets GiftCardAmount
    /// </summary>
    [DataMember(Name="giftCardAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "giftCardAmount")]
    public Amount GiftCardAmount { get; set; }

    /// <summary>
    /// For prepaid or gift card purchase, total count of individual prepaid or gift cards/codes purchased.
    /// </summary>
    /// <value>For prepaid or gift card purchase, total count of individual prepaid or gift cards/codes purchased.</value>
    [DataMember(Name="giftCardCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "giftCardCount")]
    public int? GiftCardCount { get; set; }

    /// <summary>
    /// For pre-order purchases, the expected date this product will be available to the shopper.
    /// </summary>
    /// <value>For pre-order purchases, the expected date this product will be available to the shopper.</value>
    [DataMember(Name="preOrderDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "preOrderDate")]
    public DateTime? PreOrderDate { get; set; }

    /// <summary>
    /// Indicator for whether this transaction is for pre-ordering a product.
    /// </summary>
    /// <value>Indicator for whether this transaction is for pre-ordering a product.</value>
    [DataMember(Name="preOrderPurchase", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "preOrderPurchase")]
    public bool? PreOrderPurchase { get; set; }

    /// <summary>
    /// Indicator for whether the shopper has already purchased the same items in the past.
    /// </summary>
    /// <value>Indicator for whether the shopper has already purchased the same items in the past.</value>
    [DataMember(Name="reorderItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reorderItems")]
    public bool? ReorderItems { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MerchantRiskIndicator {\n");
      sb.Append("  AddressMatch: ").Append(AddressMatch).Append("\n");
      sb.Append("  DeliveryAddressIndicator: ").Append(DeliveryAddressIndicator).Append("\n");
      sb.Append("  DeliveryEmail: ").Append(DeliveryEmail).Append("\n");
      sb.Append("  DeliveryTimeframe: ").Append(DeliveryTimeframe).Append("\n");
      sb.Append("  GiftCardAmount: ").Append(GiftCardAmount).Append("\n");
      sb.Append("  GiftCardCount: ").Append(GiftCardCount).Append("\n");
      sb.Append("  PreOrderDate: ").Append(PreOrderDate).Append("\n");
      sb.Append("  PreOrderPurchase: ").Append(PreOrderPurchase).Append("\n");
      sb.Append("  ReorderItems: ").Append(ReorderItems).Append("\n");
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
