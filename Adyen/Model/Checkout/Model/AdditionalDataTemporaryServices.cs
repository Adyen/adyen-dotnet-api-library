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
  public class AdditionalDataTemporaryServices {
    /// <summary>
    /// Customer code, if supplied by a customer. * Encoding: ASCII * maxLength: 25
    /// </summary>
    /// <value>Customer code, if supplied by a customer. * Encoding: ASCII * maxLength: 25</value>
    [DataMember(Name="enhancedSchemeData.customerReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enhancedSchemeData.customerReference")]
    public string EnhancedSchemeDataCustomerReference { get; set; }

    /// <summary>
    /// Name or ID associated with the individual working in a temporary capacity. * maxLength: 40
    /// </summary>
    /// <value>Name or ID associated with the individual working in a temporary capacity. * maxLength: 40</value>
    [DataMember(Name="enhancedSchemeData.employeeName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enhancedSchemeData.employeeName")]
    public string EnhancedSchemeDataEmployeeName { get; set; }

    /// <summary>
    /// Description of the job or task of the individual working in a temporary capacity. * maxLength: 40
    /// </summary>
    /// <value>Description of the job or task of the individual working in a temporary capacity. * maxLength: 40</value>
    [DataMember(Name="enhancedSchemeData.jobDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enhancedSchemeData.jobDescription")]
    public string EnhancedSchemeDataJobDescription { get; set; }

    /// <summary>
    /// Amount paid per regular hours worked, minor units. * maxLength: 7
    /// </summary>
    /// <value>Amount paid per regular hours worked, minor units. * maxLength: 7</value>
    [DataMember(Name="enhancedSchemeData.regularHoursRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enhancedSchemeData.regularHoursRate")]
    public string EnhancedSchemeDataRegularHoursRate { get; set; }

    /// <summary>
    /// Amount of time worked during a normal operation for the task or job. * maxLength: 7
    /// </summary>
    /// <value>Amount of time worked during a normal operation for the task or job. * maxLength: 7</value>
    [DataMember(Name="enhancedSchemeData.regularHoursWorked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enhancedSchemeData.regularHoursWorked")]
    public string EnhancedSchemeDataRegularHoursWorked { get; set; }

    /// <summary>
    /// Name of the individual requesting temporary services. * maxLength: 40
    /// </summary>
    /// <value>Name of the individual requesting temporary services. * maxLength: 40</value>
    [DataMember(Name="enhancedSchemeData.requestName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enhancedSchemeData.requestName")]
    public string EnhancedSchemeDataRequestName { get; set; }

    /// <summary>
    /// Date for the beginning of the pay period. * Format: ddMMyy * maxLength: 6
    /// </summary>
    /// <value>Date for the beginning of the pay period. * Format: ddMMyy * maxLength: 6</value>
    [DataMember(Name="enhancedSchemeData.tempStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enhancedSchemeData.tempStartDate")]
    public string EnhancedSchemeDataTempStartDate { get; set; }

    /// <summary>
    /// Date of the end of the billing cycle. * Format: ddMMyy * maxLength: 6
    /// </summary>
    /// <value>Date of the end of the billing cycle. * Format: ddMMyy * maxLength: 6</value>
    [DataMember(Name="enhancedSchemeData.tempWeekEnding", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enhancedSchemeData.tempWeekEnding")]
    public string EnhancedSchemeDataTempWeekEnding { get; set; }

    /// <summary>
    /// Total tax amount, in minor units. For example, 2000 means USD 20.00 * maxLength: 12
    /// </summary>
    /// <value>Total tax amount, in minor units. For example, 2000 means USD 20.00 * maxLength: 12</value>
    [DataMember(Name="enhancedSchemeData.totalTaxAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enhancedSchemeData.totalTaxAmount")]
    public string EnhancedSchemeDataTotalTaxAmount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AdditionalDataTemporaryServices {\n");
      sb.Append("  EnhancedSchemeDataCustomerReference: ").Append(EnhancedSchemeDataCustomerReference).Append("\n");
      sb.Append("  EnhancedSchemeDataEmployeeName: ").Append(EnhancedSchemeDataEmployeeName).Append("\n");
      sb.Append("  EnhancedSchemeDataJobDescription: ").Append(EnhancedSchemeDataJobDescription).Append("\n");
      sb.Append("  EnhancedSchemeDataRegularHoursRate: ").Append(EnhancedSchemeDataRegularHoursRate).Append("\n");
      sb.Append("  EnhancedSchemeDataRegularHoursWorked: ").Append(EnhancedSchemeDataRegularHoursWorked).Append("\n");
      sb.Append("  EnhancedSchemeDataRequestName: ").Append(EnhancedSchemeDataRequestName).Append("\n");
      sb.Append("  EnhancedSchemeDataTempStartDate: ").Append(EnhancedSchemeDataTempStartDate).Append("\n");
      sb.Append("  EnhancedSchemeDataTempWeekEnding: ").Append(EnhancedSchemeDataTempWeekEnding).Append("\n");
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
