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
  public class LineItem {
    /// <summary>
    /// Item amount excluding the tax, in minor units.
    /// </summary>
    /// <value>Item amount excluding the tax, in minor units.</value>
    [DataMember(Name="amountExcludingTax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amountExcludingTax")]
    public long? AmountExcludingTax { get; set; }

    /// <summary>
    /// Item amount including the tax, in minor units.
    /// </summary>
    /// <value>Item amount including the tax, in minor units.</value>
    [DataMember(Name="amountIncludingTax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amountIncludingTax")]
    public long? AmountIncludingTax { get; set; }

    /// <summary>
    /// Description of the line item.
    /// </summary>
    /// <value>Description of the line item.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// ID of the line item.
    /// </summary>
    /// <value>ID of the line item.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Link to the picture of the purchased item.
    /// </summary>
    /// <value>Link to the picture of the purchased item.</value>
    [DataMember(Name="imageUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "imageUrl")]
    public string ImageUrl { get; set; }

    /// <summary>
    /// Link to the purchased item.
    /// </summary>
    /// <value>Link to the purchased item.</value>
    [DataMember(Name="productUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productUrl")]
    public string ProductUrl { get; set; }

    /// <summary>
    /// Number of items.
    /// </summary>
    /// <value>Number of items.</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public long? Quantity { get; set; }

    /// <summary>
    /// Tax amount, in minor units.
    /// </summary>
    /// <value>Tax amount, in minor units.</value>
    [DataMember(Name="taxAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxAmount")]
    public long? TaxAmount { get; set; }

    /// <summary>
    /// Required for AfterPay. Tax category: High, Low, None, Zero
    /// </summary>
    /// <value>Required for AfterPay. Tax category: High, Low, None, Zero</value>
    [DataMember(Name="taxCategory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxCategory")]
    public string TaxCategory { get; set; }

    /// <summary>
    /// Tax percentage, in minor units.
    /// </summary>
    /// <value>Tax percentage, in minor units.</value>
    [DataMember(Name="taxPercentage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxPercentage")]
    public long? TaxPercentage { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LineItem {\n");
      sb.Append("  AmountExcludingTax: ").Append(AmountExcludingTax).Append("\n");
      sb.Append("  AmountIncludingTax: ").Append(AmountIncludingTax).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
      sb.Append("  ProductUrl: ").Append(ProductUrl).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
      sb.Append("  TaxCategory: ").Append(TaxCategory).Append("\n");
      sb.Append("  TaxPercentage: ").Append(TaxPercentage).Append("\n");
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
