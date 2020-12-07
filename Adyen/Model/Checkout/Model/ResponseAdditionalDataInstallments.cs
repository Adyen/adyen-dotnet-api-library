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
  public class ResponseAdditionalDataInstallments {
    /// <summary>
    /// Type of installment. The value of `installmentType` should be **IssuerFinanced**.
    /// </summary>
    /// <value>Type of installment. The value of `installmentType` should be **IssuerFinanced**.</value>
    [DataMember(Name="installmentPaymentData.installmentType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "installmentPaymentData.installmentType")]
    public string InstallmentPaymentDataInstallmentType { get; set; }

    /// <summary>
    /// Annual interest rate.
    /// </summary>
    /// <value>Annual interest rate.</value>
    [DataMember(Name="installmentPaymentData.option[itemNr].annualPercentageRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "installmentPaymentData.option[itemNr].annualPercentageRate")]
    public string InstallmentPaymentDataOptionItemNrAnnualPercentageRate { get; set; }

    /// <summary>
    /// First Installment Amount in minor units.
    /// </summary>
    /// <value>First Installment Amount in minor units.</value>
    [DataMember(Name="installmentPaymentData.option[itemNr].firstInstallmentAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "installmentPaymentData.option[itemNr].firstInstallmentAmount")]
    public string InstallmentPaymentDataOptionItemNrFirstInstallmentAmount { get; set; }

    /// <summary>
    /// Installment fee amount in minor units.
    /// </summary>
    /// <value>Installment fee amount in minor units.</value>
    [DataMember(Name="installmentPaymentData.option[itemNr].installmentFee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "installmentPaymentData.option[itemNr].installmentFee")]
    public string InstallmentPaymentDataOptionItemNrInstallmentFee { get; set; }

    /// <summary>
    /// Interest rate for the installment period.
    /// </summary>
    /// <value>Interest rate for the installment period.</value>
    [DataMember(Name="installmentPaymentData.option[itemNr].interestRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "installmentPaymentData.option[itemNr].interestRate")]
    public string InstallmentPaymentDataOptionItemNrInterestRate { get; set; }

    /// <summary>
    /// Maximum number of installments possible for this payment.
    /// </summary>
    /// <value>Maximum number of installments possible for this payment.</value>
    [DataMember(Name="installmentPaymentData.option[itemNr].maximumNumberOfInstallments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "installmentPaymentData.option[itemNr].maximumNumberOfInstallments")]
    public string InstallmentPaymentDataOptionItemNrMaximumNumberOfInstallments { get; set; }

    /// <summary>
    /// Minimum number of installments possible for this payment.
    /// </summary>
    /// <value>Minimum number of installments possible for this payment.</value>
    [DataMember(Name="installmentPaymentData.option[itemNr].minimumNumberOfInstallments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "installmentPaymentData.option[itemNr].minimumNumberOfInstallments")]
    public string InstallmentPaymentDataOptionItemNrMinimumNumberOfInstallments { get; set; }

    /// <summary>
    /// Total number of installments possible for this payment.
    /// </summary>
    /// <value>Total number of installments possible for this payment.</value>
    [DataMember(Name="installmentPaymentData.option[itemNr].numberOfInstallments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "installmentPaymentData.option[itemNr].numberOfInstallments")]
    public string InstallmentPaymentDataOptionItemNrNumberOfInstallments { get; set; }

    /// <summary>
    /// Subsequent Installment Amount in minor units.
    /// </summary>
    /// <value>Subsequent Installment Amount in minor units.</value>
    [DataMember(Name="installmentPaymentData.option[itemNr].subsequentInstallmentAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "installmentPaymentData.option[itemNr].subsequentInstallmentAmount")]
    public string InstallmentPaymentDataOptionItemNrSubsequentInstallmentAmount { get; set; }

    /// <summary>
    /// Total amount in minor units.
    /// </summary>
    /// <value>Total amount in minor units.</value>
    [DataMember(Name="installmentPaymentData.option[itemNr].totalAmountDue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "installmentPaymentData.option[itemNr].totalAmountDue")]
    public string InstallmentPaymentDataOptionItemNrTotalAmountDue { get; set; }

    /// <summary>
    /// Possible values: * PayInInstallmentsOnly * PayInFullOnly * PayInFullOrInstallments
    /// </summary>
    /// <value>Possible values: * PayInInstallmentsOnly * PayInFullOnly * PayInFullOrInstallments</value>
    [DataMember(Name="installmentPaymentData.paymentOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "installmentPaymentData.paymentOptions")]
    public string InstallmentPaymentDataPaymentOptions { get; set; }

    /// <summary>
    /// The number of installments that the payment amount should be charged with.  Example: 5 > Only relevant for card payments in countries that support installments.
    /// </summary>
    /// <value>The number of installments that the payment amount should be charged with.  Example: 5 > Only relevant for card payments in countries that support installments.</value>
    [DataMember(Name="installments.value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "installments.value")]
    public string InstallmentsValue { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ResponseAdditionalDataInstallments {\n");
      sb.Append("  InstallmentPaymentDataInstallmentType: ").Append(InstallmentPaymentDataInstallmentType).Append("\n");
      sb.Append("  InstallmentPaymentDataOptionItemNrAnnualPercentageRate: ").Append(InstallmentPaymentDataOptionItemNrAnnualPercentageRate).Append("\n");
      sb.Append("  InstallmentPaymentDataOptionItemNrFirstInstallmentAmount: ").Append(InstallmentPaymentDataOptionItemNrFirstInstallmentAmount).Append("\n");
      sb.Append("  InstallmentPaymentDataOptionItemNrInstallmentFee: ").Append(InstallmentPaymentDataOptionItemNrInstallmentFee).Append("\n");
      sb.Append("  InstallmentPaymentDataOptionItemNrInterestRate: ").Append(InstallmentPaymentDataOptionItemNrInterestRate).Append("\n");
      sb.Append("  InstallmentPaymentDataOptionItemNrMaximumNumberOfInstallments: ").Append(InstallmentPaymentDataOptionItemNrMaximumNumberOfInstallments).Append("\n");
      sb.Append("  InstallmentPaymentDataOptionItemNrMinimumNumberOfInstallments: ").Append(InstallmentPaymentDataOptionItemNrMinimumNumberOfInstallments).Append("\n");
      sb.Append("  InstallmentPaymentDataOptionItemNrNumberOfInstallments: ").Append(InstallmentPaymentDataOptionItemNrNumberOfInstallments).Append("\n");
      sb.Append("  InstallmentPaymentDataOptionItemNrSubsequentInstallmentAmount: ").Append(InstallmentPaymentDataOptionItemNrSubsequentInstallmentAmount).Append("\n");
      sb.Append("  InstallmentPaymentDataOptionItemNrTotalAmountDue: ").Append(InstallmentPaymentDataOptionItemNrTotalAmountDue).Append("\n");
      sb.Append("  InstallmentPaymentDataPaymentOptions: ").Append(InstallmentPaymentDataPaymentOptions).Append("\n");
      sb.Append("  InstallmentsValue: ").Append(InstallmentsValue).Append("\n");
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
