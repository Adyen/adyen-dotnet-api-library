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
  public class AdditionalDataLevel23 {
    /// <summary>
    /// Customer code, if supplied by a customer.  Encoding: ASCII.  Max length: 25 characters.  > Required for Level 2 and Level 3 data.
    /// </summary>
    /// <value>Customer code, if supplied by a customer.  Encoding: ASCII.  Max length: 25 characters.  > Required for Level 2 and Level 3 data.</value>
    [DataMember(Name="enhancedSchemeData.customerReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enhancedSchemeData.customerReference")]
    public string EnhancedSchemeDataCustomerReference { get; set; }

    /// <summary>
    /// Destination country code.  Encoding: ASCII.  Max length: 3 characters.
    /// </summary>
    /// <value>Destination country code.  Encoding: ASCII.  Max length: 3 characters.</value>
    [DataMember(Name="enhancedSchemeData.destinationCountryCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enhancedSchemeData.destinationCountryCode")]
    public string EnhancedSchemeDataDestinationCountryCode { get; set; }

    /// <summary>
    /// The postal code of a destination address.  Encoding: ASCII.  Max length: 10 characters.  > Required for American Express.
    /// </summary>
    /// <value>The postal code of a destination address.  Encoding: ASCII.  Max length: 10 characters.  > Required for American Express.</value>
    [DataMember(Name="enhancedSchemeData.destinationPostalCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enhancedSchemeData.destinationPostalCode")]
    public string EnhancedSchemeDataDestinationPostalCode { get; set; }

    /// <summary>
    /// Destination state or province code.  Encoding: ASCII.Max length: 3 characters.
    /// </summary>
    /// <value>Destination state or province code.  Encoding: ASCII.Max length: 3 characters.</value>
    [DataMember(Name="enhancedSchemeData.destinationStateProvinceCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enhancedSchemeData.destinationStateProvinceCode")]
    public string EnhancedSchemeDataDestinationStateProvinceCode { get; set; }

    /// <summary>
    /// Duty amount, in minor units.  For example, 2000 means USD 20.00.  Max length: 12 characters.
    /// </summary>
    /// <value>Duty amount, in minor units.  For example, 2000 means USD 20.00.  Max length: 12 characters.</value>
    [DataMember(Name="enhancedSchemeData.dutyAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enhancedSchemeData.dutyAmount")]
    public string EnhancedSchemeDataDutyAmount { get; set; }

    /// <summary>
    /// Shipping amount, in minor units.  For example, 2000 means USD 20.00.  Max length: 12 characters.
    /// </summary>
    /// <value>Shipping amount, in minor units.  For example, 2000 means USD 20.00.  Max length: 12 characters.</value>
    [DataMember(Name="enhancedSchemeData.freightAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enhancedSchemeData.freightAmount")]
    public string EnhancedSchemeDataFreightAmount { get; set; }

    /// <summary>
    /// Item commodity code.  Encoding: ASCII.  Max length: 12 characters.
    /// </summary>
    /// <value>Item commodity code.  Encoding: ASCII.  Max length: 12 characters.</value>
    [DataMember(Name="enhancedSchemeData.itemDetailLine[itemNr].commodityCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enhancedSchemeData.itemDetailLine[itemNr].commodityCode")]
    public string EnhancedSchemeDataItemDetailLineItemNrCommodityCode { get; set; }

    /// <summary>
    /// Item description.  Encoding: ASCII.  Max length: 26 characters.
    /// </summary>
    /// <value>Item description.  Encoding: ASCII.  Max length: 26 characters.</value>
    [DataMember(Name="enhancedSchemeData.itemDetailLine[itemNr].description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enhancedSchemeData.itemDetailLine[itemNr].description")]
    public string EnhancedSchemeDataItemDetailLineItemNrDescription { get; set; }

    /// <summary>
    /// Discount amount, in minor units.  For example, 2000 means USD 20.00.  Max length: 12 characters.
    /// </summary>
    /// <value>Discount amount, in minor units.  For example, 2000 means USD 20.00.  Max length: 12 characters.</value>
    [DataMember(Name="enhancedSchemeData.itemDetailLine[itemNr].discountAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enhancedSchemeData.itemDetailLine[itemNr].discountAmount")]
    public string EnhancedSchemeDataItemDetailLineItemNrDiscountAmount { get; set; }

    /// <summary>
    /// Product code.  Encoding: ASCII.  Max length: 12 characters.
    /// </summary>
    /// <value>Product code.  Encoding: ASCII.  Max length: 12 characters.</value>
    [DataMember(Name="enhancedSchemeData.itemDetailLine[itemNr].productCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enhancedSchemeData.itemDetailLine[itemNr].productCode")]
    public string EnhancedSchemeDataItemDetailLineItemNrProductCode { get; set; }

    /// <summary>
    /// Quantity, specified as an integer value.  Value must be greater than 0.  Max length: 12 characters.
    /// </summary>
    /// <value>Quantity, specified as an integer value.  Value must be greater than 0.  Max length: 12 characters.</value>
    [DataMember(Name="enhancedSchemeData.itemDetailLine[itemNr].quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enhancedSchemeData.itemDetailLine[itemNr].quantity")]
    public string EnhancedSchemeDataItemDetailLineItemNrQuantity { get; set; }

    /// <summary>
    /// Total amount, in minor units.  For example, 2000 means USD 20.00.  Max length: 12 characters.
    /// </summary>
    /// <value>Total amount, in minor units.  For example, 2000 means USD 20.00.  Max length: 12 characters.</value>
    [DataMember(Name="enhancedSchemeData.itemDetailLine[itemNr].totalAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enhancedSchemeData.itemDetailLine[itemNr].totalAmount")]
    public string EnhancedSchemeDataItemDetailLineItemNrTotalAmount { get; set; }

    /// <summary>
    /// Item unit of measurement.  Encoding: ASCII.  Max length: 3 characters.
    /// </summary>
    /// <value>Item unit of measurement.  Encoding: ASCII.  Max length: 3 characters.</value>
    [DataMember(Name="enhancedSchemeData.itemDetailLine[itemNr].unitOfMeasure", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enhancedSchemeData.itemDetailLine[itemNr].unitOfMeasure")]
    public string EnhancedSchemeDataItemDetailLineItemNrUnitOfMeasure { get; set; }

    /// <summary>
    /// Unit price, specified in [minor units](https://docs.adyen.com/development-resources/currency-codes).  Max length: 12 characters.
    /// </summary>
    /// <value>Unit price, specified in [minor units](https://docs.adyen.com/development-resources/currency-codes).  Max length: 12 characters.</value>
    [DataMember(Name="enhancedSchemeData.itemDetailLine[itemNr].unitPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enhancedSchemeData.itemDetailLine[itemNr].unitPrice")]
    public string EnhancedSchemeDataItemDetailLineItemNrUnitPrice { get; set; }

    /// <summary>
    /// Order date. * Format: `ddMMyy`  Encoding: ASCII.  Max length: 6 characters.
    /// </summary>
    /// <value>Order date. * Format: `ddMMyy`  Encoding: ASCII.  Max length: 6 characters.</value>
    [DataMember(Name="enhancedSchemeData.orderDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enhancedSchemeData.orderDate")]
    public string EnhancedSchemeDataOrderDate { get; set; }

    /// <summary>
    /// The postal code of a \"ship-from\" address.  Encoding: ASCII.  Max length: 10 characters.
    /// </summary>
    /// <value>The postal code of a \"ship-from\" address.  Encoding: ASCII.  Max length: 10 characters.</value>
    [DataMember(Name="enhancedSchemeData.shipFromPostalCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enhancedSchemeData.shipFromPostalCode")]
    public string EnhancedSchemeDataShipFromPostalCode { get; set; }

    /// <summary>
    /// Total tax amount, in minor units.  For example, 2000 means USD 20.00.  Max length: 12 characters.  > Required for Level 2 and Level 3 data.
    /// </summary>
    /// <value>Total tax amount, in minor units.  For example, 2000 means USD 20.00.  Max length: 12 characters.  > Required for Level 2 and Level 3 data.</value>
    [DataMember(Name="enhancedSchemeData.totalTaxAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enhancedSchemeData.totalTaxAmount")]
    public string EnhancedSchemeDataTotalTaxAmount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AdditionalDataLevel23 {\n");
      sb.Append("  EnhancedSchemeDataCustomerReference: ").Append(EnhancedSchemeDataCustomerReference).Append("\n");
      sb.Append("  EnhancedSchemeDataDestinationCountryCode: ").Append(EnhancedSchemeDataDestinationCountryCode).Append("\n");
      sb.Append("  EnhancedSchemeDataDestinationPostalCode: ").Append(EnhancedSchemeDataDestinationPostalCode).Append("\n");
      sb.Append("  EnhancedSchemeDataDestinationStateProvinceCode: ").Append(EnhancedSchemeDataDestinationStateProvinceCode).Append("\n");
      sb.Append("  EnhancedSchemeDataDutyAmount: ").Append(EnhancedSchemeDataDutyAmount).Append("\n");
      sb.Append("  EnhancedSchemeDataFreightAmount: ").Append(EnhancedSchemeDataFreightAmount).Append("\n");
      sb.Append("  EnhancedSchemeDataItemDetailLineItemNrCommodityCode: ").Append(EnhancedSchemeDataItemDetailLineItemNrCommodityCode).Append("\n");
      sb.Append("  EnhancedSchemeDataItemDetailLineItemNrDescription: ").Append(EnhancedSchemeDataItemDetailLineItemNrDescription).Append("\n");
      sb.Append("  EnhancedSchemeDataItemDetailLineItemNrDiscountAmount: ").Append(EnhancedSchemeDataItemDetailLineItemNrDiscountAmount).Append("\n");
      sb.Append("  EnhancedSchemeDataItemDetailLineItemNrProductCode: ").Append(EnhancedSchemeDataItemDetailLineItemNrProductCode).Append("\n");
      sb.Append("  EnhancedSchemeDataItemDetailLineItemNrQuantity: ").Append(EnhancedSchemeDataItemDetailLineItemNrQuantity).Append("\n");
      sb.Append("  EnhancedSchemeDataItemDetailLineItemNrTotalAmount: ").Append(EnhancedSchemeDataItemDetailLineItemNrTotalAmount).Append("\n");
      sb.Append("  EnhancedSchemeDataItemDetailLineItemNrUnitOfMeasure: ").Append(EnhancedSchemeDataItemDetailLineItemNrUnitOfMeasure).Append("\n");
      sb.Append("  EnhancedSchemeDataItemDetailLineItemNrUnitPrice: ").Append(EnhancedSchemeDataItemDetailLineItemNrUnitPrice).Append("\n");
      sb.Append("  EnhancedSchemeDataOrderDate: ").Append(EnhancedSchemeDataOrderDate).Append("\n");
      sb.Append("  EnhancedSchemeDataShipFromPostalCode: ").Append(EnhancedSchemeDataShipFromPostalCode).Append("\n");
      sb.Append("  EnhancedSchemeDataTotalTaxAmount: ").Append(EnhancedSchemeDataTotalTaxAmount).Append("\n");
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
