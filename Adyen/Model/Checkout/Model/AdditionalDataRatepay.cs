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
  public class AdditionalDataRatepay {
    /// <summary>
    /// Amount the customer has to pay each month.
    /// </summary>
    /// <value>Amount the customer has to pay each month.</value>
    [DataMember(Name="ratepay.installmentAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ratepay.installmentAmount")]
    public string RatepayInstallmentAmount { get; set; }

    /// <summary>
    /// Interest rate of this installment.
    /// </summary>
    /// <value>Interest rate of this installment.</value>
    [DataMember(Name="ratepay.interestRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ratepay.interestRate")]
    public string RatepayInterestRate { get; set; }

    /// <summary>
    /// Amount of the last installment.
    /// </summary>
    /// <value>Amount of the last installment.</value>
    [DataMember(Name="ratepay.lastInstallmentAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ratepay.lastInstallmentAmount")]
    public string RatepayLastInstallmentAmount { get; set; }

    /// <summary>
    /// Calendar day of the first payment.
    /// </summary>
    /// <value>Calendar day of the first payment.</value>
    [DataMember(Name="ratepay.paymentFirstday", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ratepay.paymentFirstday")]
    public string RatepayPaymentFirstday { get; set; }

    /// <summary>
    /// Date the merchant delivered the goods to the customer.
    /// </summary>
    /// <value>Date the merchant delivered the goods to the customer.</value>
    [DataMember(Name="ratepaydata.deliveryDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ratepaydata.deliveryDate")]
    public string RatepaydataDeliveryDate { get; set; }

    /// <summary>
    /// Date by which the customer must settle the payment.
    /// </summary>
    /// <value>Date by which the customer must settle the payment.</value>
    [DataMember(Name="ratepaydata.dueDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ratepaydata.dueDate")]
    public string RatepaydataDueDate { get; set; }

    /// <summary>
    /// Invoice date, defined by the merchant. If not included, the invoice date is set to the delivery date.
    /// </summary>
    /// <value>Invoice date, defined by the merchant. If not included, the invoice date is set to the delivery date.</value>
    [DataMember(Name="ratepaydata.invoiceDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ratepaydata.invoiceDate")]
    public string RatepaydataInvoiceDate { get; set; }

    /// <summary>
    /// Identification name or number for the invoice, defined by the merchant.
    /// </summary>
    /// <value>Identification name or number for the invoice, defined by the merchant.</value>
    [DataMember(Name="ratepaydata.invoiceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ratepaydata.invoiceId")]
    public string RatepaydataInvoiceId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AdditionalDataRatepay {\n");
      sb.Append("  RatepayInstallmentAmount: ").Append(RatepayInstallmentAmount).Append("\n");
      sb.Append("  RatepayInterestRate: ").Append(RatepayInterestRate).Append("\n");
      sb.Append("  RatepayLastInstallmentAmount: ").Append(RatepayLastInstallmentAmount).Append("\n");
      sb.Append("  RatepayPaymentFirstday: ").Append(RatepayPaymentFirstday).Append("\n");
      sb.Append("  RatepaydataDeliveryDate: ").Append(RatepaydataDeliveryDate).Append("\n");
      sb.Append("  RatepaydataDueDate: ").Append(RatepaydataDueDate).Append("\n");
      sb.Append("  RatepaydataInvoiceDate: ").Append(RatepaydataInvoiceDate).Append("\n");
      sb.Append("  RatepaydataInvoiceId: ").Append(RatepaydataInvoiceId).Append("\n");
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
