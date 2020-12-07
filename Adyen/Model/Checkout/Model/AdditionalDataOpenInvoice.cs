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
  public class AdditionalDataOpenInvoice {
    /// <summary>
    /// Holds different merchant data points like product, purchase, customer, and so on. It takes data in a Base64 encoded string.  The `merchantData` parameter needs to be added to the `openinvoicedata` signature at the end.  Since the field is optional, if it's not included it does not impact computing the merchant signature.  Applies only to Klarna.  You can contact Klarna for the format and structure of the string.
    /// </summary>
    /// <value>Holds different merchant data points like product, purchase, customer, and so on. It takes data in a Base64 encoded string.  The `merchantData` parameter needs to be added to the `openinvoicedata` signature at the end.  Since the field is optional, if it's not included it does not impact computing the merchant signature.  Applies only to Klarna.  You can contact Klarna for the format and structure of the string.</value>
    [DataMember(Name="openinvoicedata.merchantData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "openinvoicedata.merchantData")]
    public string OpeninvoicedataMerchantData { get; set; }

    /// <summary>
    /// The number of invoice lines included in `openinvoicedata`.  There needs to be at least one line, so `numberOfLines` needs to be at least 1.
    /// </summary>
    /// <value>The number of invoice lines included in `openinvoicedata`.  There needs to be at least one line, so `numberOfLines` needs to be at least 1.</value>
    [DataMember(Name="openinvoicedata.numberOfLines", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "openinvoicedata.numberOfLines")]
    public string OpeninvoicedataNumberOfLines { get; set; }

    /// <summary>
    /// The three-character ISO currency code.
    /// </summary>
    /// <value>The three-character ISO currency code.</value>
    [DataMember(Name="openinvoicedataLine[itemNr].currencyCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "openinvoicedataLine[itemNr].currencyCode")]
    public string OpeninvoicedataLineItemNrCurrencyCode { get; set; }

    /// <summary>
    /// A text description of the product the invoice line refers to.
    /// </summary>
    /// <value>A text description of the product the invoice line refers to.</value>
    [DataMember(Name="openinvoicedataLine[itemNr].description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "openinvoicedataLine[itemNr].description")]
    public string OpeninvoicedataLineItemNrDescription { get; set; }

    /// <summary>
    /// The price for one item in the invoice line, represented in minor units.  The due amount for the item, VAT excluded.
    /// </summary>
    /// <value>The price for one item in the invoice line, represented in minor units.  The due amount for the item, VAT excluded.</value>
    [DataMember(Name="openinvoicedataLine[itemNr].itemAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "openinvoicedataLine[itemNr].itemAmount")]
    public string OpeninvoicedataLineItemNrItemAmount { get; set; }

    /// <summary>
    /// A unique id for this item. Required for RatePay if the description of each item is not unique.
    /// </summary>
    /// <value>A unique id for this item. Required for RatePay if the description of each item is not unique.</value>
    [DataMember(Name="openinvoicedataLine[itemNr].itemId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "openinvoicedataLine[itemNr].itemId")]
    public string OpeninvoicedataLineItemNrItemId { get; set; }

    /// <summary>
    /// The VAT due for one item in the invoice line, represented in minor units.
    /// </summary>
    /// <value>The VAT due for one item in the invoice line, represented in minor units.</value>
    [DataMember(Name="openinvoicedataLine[itemNr].itemVatAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "openinvoicedataLine[itemNr].itemVatAmount")]
    public string OpeninvoicedataLineItemNrItemVatAmount { get; set; }

    /// <summary>
    /// The VAT percentage for one item in the invoice line, represented in minor units.  For example, 19% VAT is specified as 1900.
    /// </summary>
    /// <value>The VAT percentage for one item in the invoice line, represented in minor units.  For example, 19% VAT is specified as 1900.</value>
    [DataMember(Name="openinvoicedataLine[itemNr].itemVatPercentage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "openinvoicedataLine[itemNr].itemVatPercentage")]
    public string OpeninvoicedataLineItemNrItemVatPercentage { get; set; }

    /// <summary>
    /// The number of units purchased of a specific product.
    /// </summary>
    /// <value>The number of units purchased of a specific product.</value>
    [DataMember(Name="openinvoicedataLine[itemNr].numberOfItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "openinvoicedataLine[itemNr].numberOfItems")]
    public string OpeninvoicedataLineItemNrNumberOfItems { get; set; }

    /// <summary>
    /// Required for AfterPay. The country-specific VAT category a product falls under.  Allowed values: * High * Low * None.
    /// </summary>
    /// <value>Required for AfterPay. The country-specific VAT category a product falls under.  Allowed values: * High * Low * None.</value>
    [DataMember(Name="openinvoicedataLine[itemNr].vatCategory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "openinvoicedataLine[itemNr].vatCategory")]
    public string OpeninvoicedataLineItemNrVatCategory { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AdditionalDataOpenInvoice {\n");
      sb.Append("  OpeninvoicedataMerchantData: ").Append(OpeninvoicedataMerchantData).Append("\n");
      sb.Append("  OpeninvoicedataNumberOfLines: ").Append(OpeninvoicedataNumberOfLines).Append("\n");
      sb.Append("  OpeninvoicedataLineItemNrCurrencyCode: ").Append(OpeninvoicedataLineItemNrCurrencyCode).Append("\n");
      sb.Append("  OpeninvoicedataLineItemNrDescription: ").Append(OpeninvoicedataLineItemNrDescription).Append("\n");
      sb.Append("  OpeninvoicedataLineItemNrItemAmount: ").Append(OpeninvoicedataLineItemNrItemAmount).Append("\n");
      sb.Append("  OpeninvoicedataLineItemNrItemId: ").Append(OpeninvoicedataLineItemNrItemId).Append("\n");
      sb.Append("  OpeninvoicedataLineItemNrItemVatAmount: ").Append(OpeninvoicedataLineItemNrItemVatAmount).Append("\n");
      sb.Append("  OpeninvoicedataLineItemNrItemVatPercentage: ").Append(OpeninvoicedataLineItemNrItemVatPercentage).Append("\n");
      sb.Append("  OpeninvoicedataLineItemNrNumberOfItems: ").Append(OpeninvoicedataLineItemNrNumberOfItems).Append("\n");
      sb.Append("  OpeninvoicedataLineItemNrVatCategory: ").Append(OpeninvoicedataLineItemNrVatCategory).Append("\n");
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
