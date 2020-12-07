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
  public class AccountInfo {
    /// <summary>
    /// Indicator for the length of time since this shopper account was created in the merchant's environment. Allowed values: * notApplicable * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days
    /// </summary>
    /// <value>Indicator for the length of time since this shopper account was created in the merchant's environment. Allowed values: * notApplicable * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days</value>
    [DataMember(Name="accountAgeIndicator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountAgeIndicator")]
    public string AccountAgeIndicator { get; set; }

    /// <summary>
    /// Date when the shopper's account was last changed.
    /// </summary>
    /// <value>Date when the shopper's account was last changed.</value>
    [DataMember(Name="accountChangeDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountChangeDate")]
    public DateTime? AccountChangeDate { get; set; }

    /// <summary>
    /// Indicator for the length of time since the shopper's account was last updated. Allowed values: * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days
    /// </summary>
    /// <value>Indicator for the length of time since the shopper's account was last updated. Allowed values: * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days</value>
    [DataMember(Name="accountChangeIndicator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountChangeIndicator")]
    public string AccountChangeIndicator { get; set; }

    /// <summary>
    /// Date when the shopper's account was created.
    /// </summary>
    /// <value>Date when the shopper's account was created.</value>
    [DataMember(Name="accountCreationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountCreationDate")]
    public DateTime? AccountCreationDate { get; set; }

    /// <summary>
    /// Indicates the type of account. For example, for a multi-account card product. Allowed values: * notApplicable * credit * debit
    /// </summary>
    /// <value>Indicates the type of account. For example, for a multi-account card product. Allowed values: * notApplicable * credit * debit</value>
    [DataMember(Name="accountType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountType")]
    public string AccountType { get; set; }

    /// <summary>
    /// Number of attempts the shopper tried to add a card to their account in the last day.
    /// </summary>
    /// <value>Number of attempts the shopper tried to add a card to their account in the last day.</value>
    [DataMember(Name="addCardAttemptsDay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addCardAttemptsDay")]
    public int? AddCardAttemptsDay { get; set; }

    /// <summary>
    /// Date the selected delivery address was first used.
    /// </summary>
    /// <value>Date the selected delivery address was first used.</value>
    [DataMember(Name="deliveryAddressUsageDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deliveryAddressUsageDate")]
    public DateTime? DeliveryAddressUsageDate { get; set; }

    /// <summary>
    /// Indicator for the length of time since this delivery address was first used. Allowed values: * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days
    /// </summary>
    /// <value>Indicator for the length of time since this delivery address was first used. Allowed values: * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days</value>
    [DataMember(Name="deliveryAddressUsageIndicator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deliveryAddressUsageIndicator")]
    public string DeliveryAddressUsageIndicator { get; set; }

    /// <summary>
    /// Shopper's home phone number (including the country code).
    /// </summary>
    /// <value>Shopper's home phone number (including the country code).</value>
    [DataMember(Name="homePhone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "homePhone")]
    public string HomePhone { get; set; }

    /// <summary>
    /// Shopper's mobile phone number (including the country code).
    /// </summary>
    /// <value>Shopper's mobile phone number (including the country code).</value>
    [DataMember(Name="mobilePhone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mobilePhone")]
    public string MobilePhone { get; set; }

    /// <summary>
    /// Date when the shopper last changed their password.
    /// </summary>
    /// <value>Date when the shopper last changed their password.</value>
    [DataMember(Name="passwordChangeDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "passwordChangeDate")]
    public DateTime? PasswordChangeDate { get; set; }

    /// <summary>
    /// Indicator when the shopper has changed their password. Allowed values: * notApplicable * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days
    /// </summary>
    /// <value>Indicator when the shopper has changed their password. Allowed values: * notApplicable * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days</value>
    [DataMember(Name="passwordChangeIndicator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "passwordChangeIndicator")]
    public string PasswordChangeIndicator { get; set; }

    /// <summary>
    /// Number of all transactions (successful and abandoned) from this shopper in the past 24 hours.
    /// </summary>
    /// <value>Number of all transactions (successful and abandoned) from this shopper in the past 24 hours.</value>
    [DataMember(Name="pastTransactionsDay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pastTransactionsDay")]
    public int? PastTransactionsDay { get; set; }

    /// <summary>
    /// Number of all transactions (successful and abandoned) from this shopper in the past year.
    /// </summary>
    /// <value>Number of all transactions (successful and abandoned) from this shopper in the past year.</value>
    [DataMember(Name="pastTransactionsYear", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pastTransactionsYear")]
    public int? PastTransactionsYear { get; set; }

    /// <summary>
    /// Date this payment method was added to the shopper's account.
    /// </summary>
    /// <value>Date this payment method was added to the shopper's account.</value>
    [DataMember(Name="paymentAccountAge", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentAccountAge")]
    public DateTime? PaymentAccountAge { get; set; }

    /// <summary>
    /// Indicator for the length of time since this payment method was added to this shopper's account. Allowed values: * notApplicable * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days
    /// </summary>
    /// <value>Indicator for the length of time since this payment method was added to this shopper's account. Allowed values: * notApplicable * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days</value>
    [DataMember(Name="paymentAccountIndicator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentAccountIndicator")]
    public string PaymentAccountIndicator { get; set; }

    /// <summary>
    /// Number of successful purchases in the last six months.
    /// </summary>
    /// <value>Number of successful purchases in the last six months.</value>
    [DataMember(Name="purchasesLast6Months", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "purchasesLast6Months")]
    public int? PurchasesLast6Months { get; set; }

    /// <summary>
    /// Whether suspicious activity was recorded on this account.
    /// </summary>
    /// <value>Whether suspicious activity was recorded on this account.</value>
    [DataMember(Name="suspiciousActivity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "suspiciousActivity")]
    public bool? SuspiciousActivity { get; set; }

    /// <summary>
    /// Shopper's work phone number (including the country code).
    /// </summary>
    /// <value>Shopper's work phone number (including the country code).</value>
    [DataMember(Name="workPhone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workPhone")]
    public string WorkPhone { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountInfo {\n");
      sb.Append("  AccountAgeIndicator: ").Append(AccountAgeIndicator).Append("\n");
      sb.Append("  AccountChangeDate: ").Append(AccountChangeDate).Append("\n");
      sb.Append("  AccountChangeIndicator: ").Append(AccountChangeIndicator).Append("\n");
      sb.Append("  AccountCreationDate: ").Append(AccountCreationDate).Append("\n");
      sb.Append("  AccountType: ").Append(AccountType).Append("\n");
      sb.Append("  AddCardAttemptsDay: ").Append(AddCardAttemptsDay).Append("\n");
      sb.Append("  DeliveryAddressUsageDate: ").Append(DeliveryAddressUsageDate).Append("\n");
      sb.Append("  DeliveryAddressUsageIndicator: ").Append(DeliveryAddressUsageIndicator).Append("\n");
      sb.Append("  HomePhone: ").Append(HomePhone).Append("\n");
      sb.Append("  MobilePhone: ").Append(MobilePhone).Append("\n");
      sb.Append("  PasswordChangeDate: ").Append(PasswordChangeDate).Append("\n");
      sb.Append("  PasswordChangeIndicator: ").Append(PasswordChangeIndicator).Append("\n");
      sb.Append("  PastTransactionsDay: ").Append(PastTransactionsDay).Append("\n");
      sb.Append("  PastTransactionsYear: ").Append(PastTransactionsYear).Append("\n");
      sb.Append("  PaymentAccountAge: ").Append(PaymentAccountAge).Append("\n");
      sb.Append("  PaymentAccountIndicator: ").Append(PaymentAccountIndicator).Append("\n");
      sb.Append("  PurchasesLast6Months: ").Append(PurchasesLast6Months).Append("\n");
      sb.Append("  SuspiciousActivity: ").Append(SuspiciousActivity).Append("\n");
      sb.Append("  WorkPhone: ").Append(WorkPhone).Append("\n");
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
