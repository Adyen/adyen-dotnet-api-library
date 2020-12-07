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
  public class AdditionalDataRisk {
    /// <summary>
    /// The data for your custom risk field. For more information, refer to [Create custom risk fields](https://docs.adyen.com/risk-management/configure-custom-risk-rules#step-1-create-custom-risk-fields).
    /// </summary>
    /// <value>The data for your custom risk field. For more information, refer to [Create custom risk fields](https://docs.adyen.com/risk-management/configure-custom-risk-rules#step-1-create-custom-risk-fields).</value>
    [DataMember(Name="riskdata.[customFieldName]", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "riskdata.[customFieldName]")]
    public string RiskdataCustomFieldName { get; set; }

    /// <summary>
    /// The price of item in the basket, represented in [minor units](https://docs.adyen.com/development-resources/currency-codes).
    /// </summary>
    /// <value>The price of item in the basket, represented in [minor units](https://docs.adyen.com/development-resources/currency-codes).</value>
    [DataMember(Name="riskdata.basket.item[itemNr].amountPerItem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "riskdata.basket.item[itemNr].amountPerItem")]
    public string RiskdataBasketItemItemNrAmountPerItem { get; set; }

    /// <summary>
    /// Brand of the item.
    /// </summary>
    /// <value>Brand of the item.</value>
    [DataMember(Name="riskdata.basket.item[itemNr].brand", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "riskdata.basket.item[itemNr].brand")]
    public string RiskdataBasketItemItemNrBrand { get; set; }

    /// <summary>
    /// Category of the item.
    /// </summary>
    /// <value>Category of the item.</value>
    [DataMember(Name="riskdata.basket.item[itemNr].category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "riskdata.basket.item[itemNr].category")]
    public string RiskdataBasketItemItemNrCategory { get; set; }

    /// <summary>
    /// Color of the item.
    /// </summary>
    /// <value>Color of the item.</value>
    [DataMember(Name="riskdata.basket.item[itemNr].color", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "riskdata.basket.item[itemNr].color")]
    public string RiskdataBasketItemItemNrColor { get; set; }

    /// <summary>
    /// The three-character [ISO currency code](https://en.wikipedia.org/wiki/ISO_4217).
    /// </summary>
    /// <value>The three-character [ISO currency code](https://en.wikipedia.org/wiki/ISO_4217).</value>
    [DataMember(Name="riskdata.basket.item[itemNr].currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "riskdata.basket.item[itemNr].currency")]
    public string RiskdataBasketItemItemNrCurrency { get; set; }

    /// <summary>
    /// ID of the item.
    /// </summary>
    /// <value>ID of the item.</value>
    [DataMember(Name="riskdata.basket.item[itemNr].itemID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "riskdata.basket.item[itemNr].itemID")]
    public string RiskdataBasketItemItemNrItemID { get; set; }

    /// <summary>
    /// Manufacturer of the item.
    /// </summary>
    /// <value>Manufacturer of the item.</value>
    [DataMember(Name="riskdata.basket.item[itemNr].manufacturer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "riskdata.basket.item[itemNr].manufacturer")]
    public string RiskdataBasketItemItemNrManufacturer { get; set; }

    /// <summary>
    /// A text description of the product the invoice line refers to.
    /// </summary>
    /// <value>A text description of the product the invoice line refers to.</value>
    [DataMember(Name="riskdata.basket.item[itemNr].productTitle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "riskdata.basket.item[itemNr].productTitle")]
    public string RiskdataBasketItemItemNrProductTitle { get; set; }

    /// <summary>
    /// Quantity of the item purchased.
    /// </summary>
    /// <value>Quantity of the item purchased.</value>
    [DataMember(Name="riskdata.basket.item[itemNr].quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "riskdata.basket.item[itemNr].quantity")]
    public string RiskdataBasketItemItemNrQuantity { get; set; }

    /// <summary>
    /// Email associated with the given product in the basket (usually in electronic gift cards).
    /// </summary>
    /// <value>Email associated with the given product in the basket (usually in electronic gift cards).</value>
    [DataMember(Name="riskdata.basket.item[itemNr].receiverEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "riskdata.basket.item[itemNr].receiverEmail")]
    public string RiskdataBasketItemItemNrReceiverEmail { get; set; }

    /// <summary>
    /// Size of the item.
    /// </summary>
    /// <value>Size of the item.</value>
    [DataMember(Name="riskdata.basket.item[itemNr].size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "riskdata.basket.item[itemNr].size")]
    public string RiskdataBasketItemItemNrSize { get; set; }

    /// <summary>
    /// [Stock keeping unit](https://en.wikipedia.org/wiki/Stock_keeping_unit).
    /// </summary>
    /// <value>[Stock keeping unit](https://en.wikipedia.org/wiki/Stock_keeping_unit).</value>
    [DataMember(Name="riskdata.basket.item[itemNr].sku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "riskdata.basket.item[itemNr].sku")]
    public string RiskdataBasketItemItemNrSku { get; set; }

    /// <summary>
    /// [Universal Product Code](https://en.wikipedia.org/wiki/Universal_Product_Code).
    /// </summary>
    /// <value>[Universal Product Code](https://en.wikipedia.org/wiki/Universal_Product_Code).</value>
    [DataMember(Name="riskdata.basket.item[itemNr].upc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "riskdata.basket.item[itemNr].upc")]
    public string RiskdataBasketItemItemNrUpc { get; set; }

    /// <summary>
    /// Code of the promotion.
    /// </summary>
    /// <value>Code of the promotion.</value>
    [DataMember(Name="riskdata.promotions.promotion[itemNr].promotionCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "riskdata.promotions.promotion[itemNr].promotionCode")]
    public string RiskdataPromotionsPromotionItemNrPromotionCode { get; set; }

    /// <summary>
    /// The discount amount of the promotion, represented in [minor units](https://docs.adyen.com/development-resources/currency-codes).
    /// </summary>
    /// <value>The discount amount of the promotion, represented in [minor units](https://docs.adyen.com/development-resources/currency-codes).</value>
    [DataMember(Name="riskdata.promotions.promotion[itemNr].promotionDiscountAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "riskdata.promotions.promotion[itemNr].promotionDiscountAmount")]
    public string RiskdataPromotionsPromotionItemNrPromotionDiscountAmount { get; set; }

    /// <summary>
    /// The three-character [ISO currency code](https://en.wikipedia.org/wiki/ISO_4217).
    /// </summary>
    /// <value>The three-character [ISO currency code](https://en.wikipedia.org/wiki/ISO_4217).</value>
    [DataMember(Name="riskdata.promotions.promotion[itemNr].promotionDiscountCurrency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "riskdata.promotions.promotion[itemNr].promotionDiscountCurrency")]
    public string RiskdataPromotionsPromotionItemNrPromotionDiscountCurrency { get; set; }

    /// <summary>
    /// Promotion's percentage discount. It is represented in percentage value and there is no need to include the '%' sign.  e.g. for a promotion discount of 30%, the value of the field should be 30.
    /// </summary>
    /// <value>Promotion's percentage discount. It is represented in percentage value and there is no need to include the '%' sign.  e.g. for a promotion discount of 30%, the value of the field should be 30.</value>
    [DataMember(Name="riskdata.promotions.promotion[itemNr].promotionDiscountPercentage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "riskdata.promotions.promotion[itemNr].promotionDiscountPercentage")]
    public string RiskdataPromotionsPromotionItemNrPromotionDiscountPercentage { get; set; }

    /// <summary>
    /// Name of the promotion.
    /// </summary>
    /// <value>Name of the promotion.</value>
    [DataMember(Name="riskdata.promotions.promotion[itemNr].promotionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "riskdata.promotions.promotion[itemNr].promotionName")]
    public string RiskdataPromotionsPromotionItemNrPromotionName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AdditionalDataRisk {\n");
      sb.Append("  RiskdataCustomFieldName: ").Append(RiskdataCustomFieldName).Append("\n");
      sb.Append("  RiskdataBasketItemItemNrAmountPerItem: ").Append(RiskdataBasketItemItemNrAmountPerItem).Append("\n");
      sb.Append("  RiskdataBasketItemItemNrBrand: ").Append(RiskdataBasketItemItemNrBrand).Append("\n");
      sb.Append("  RiskdataBasketItemItemNrCategory: ").Append(RiskdataBasketItemItemNrCategory).Append("\n");
      sb.Append("  RiskdataBasketItemItemNrColor: ").Append(RiskdataBasketItemItemNrColor).Append("\n");
      sb.Append("  RiskdataBasketItemItemNrCurrency: ").Append(RiskdataBasketItemItemNrCurrency).Append("\n");
      sb.Append("  RiskdataBasketItemItemNrItemID: ").Append(RiskdataBasketItemItemNrItemID).Append("\n");
      sb.Append("  RiskdataBasketItemItemNrManufacturer: ").Append(RiskdataBasketItemItemNrManufacturer).Append("\n");
      sb.Append("  RiskdataBasketItemItemNrProductTitle: ").Append(RiskdataBasketItemItemNrProductTitle).Append("\n");
      sb.Append("  RiskdataBasketItemItemNrQuantity: ").Append(RiskdataBasketItemItemNrQuantity).Append("\n");
      sb.Append("  RiskdataBasketItemItemNrReceiverEmail: ").Append(RiskdataBasketItemItemNrReceiverEmail).Append("\n");
      sb.Append("  RiskdataBasketItemItemNrSize: ").Append(RiskdataBasketItemItemNrSize).Append("\n");
      sb.Append("  RiskdataBasketItemItemNrSku: ").Append(RiskdataBasketItemItemNrSku).Append("\n");
      sb.Append("  RiskdataBasketItemItemNrUpc: ").Append(RiskdataBasketItemItemNrUpc).Append("\n");
      sb.Append("  RiskdataPromotionsPromotionItemNrPromotionCode: ").Append(RiskdataPromotionsPromotionItemNrPromotionCode).Append("\n");
      sb.Append("  RiskdataPromotionsPromotionItemNrPromotionDiscountAmount: ").Append(RiskdataPromotionsPromotionItemNrPromotionDiscountAmount).Append("\n");
      sb.Append("  RiskdataPromotionsPromotionItemNrPromotionDiscountCurrency: ").Append(RiskdataPromotionsPromotionItemNrPromotionDiscountCurrency).Append("\n");
      sb.Append("  RiskdataPromotionsPromotionItemNrPromotionDiscountPercentage: ").Append(RiskdataPromotionsPromotionItemNrPromotionDiscountPercentage).Append("\n");
      sb.Append("  RiskdataPromotionsPromotionItemNrPromotionName: ").Append(RiskdataPromotionsPromotionItemNrPromotionName).Append("\n");
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
