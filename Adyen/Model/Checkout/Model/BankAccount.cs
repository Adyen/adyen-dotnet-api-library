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
  public class BankAccount {
    /// <summary>
    /// The bank account number (without separators).
    /// </summary>
    /// <value>The bank account number (without separators).</value>
    [DataMember(Name="bankAccountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bankAccountNumber")]
    public string BankAccountNumber { get; set; }

    /// <summary>
    /// The bank city.
    /// </summary>
    /// <value>The bank city.</value>
    [DataMember(Name="bankCity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bankCity")]
    public string BankCity { get; set; }

    /// <summary>
    /// The location id of the bank. The field value is `nil` in most cases.
    /// </summary>
    /// <value>The location id of the bank. The field value is `nil` in most cases.</value>
    [DataMember(Name="bankLocationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bankLocationId")]
    public string BankLocationId { get; set; }

    /// <summary>
    /// The name of the bank.
    /// </summary>
    /// <value>The name of the bank.</value>
    [DataMember(Name="bankName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bankName")]
    public string BankName { get; set; }

    /// <summary>
    /// The [Business Identifier Code](https://en.wikipedia.org/wiki/ISO_9362) (BIC) is the SWIFT address assigned to a bank. The field value is `nil` in most cases.
    /// </summary>
    /// <value>The [Business Identifier Code](https://en.wikipedia.org/wiki/ISO_9362) (BIC) is the SWIFT address assigned to a bank. The field value is `nil` in most cases.</value>
    [DataMember(Name="bic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bic")]
    public string Bic { get; set; }

    /// <summary>
    /// Country code where the bank is located.  A valid value is an ISO two-character country code (e.g. 'NL').
    /// </summary>
    /// <value>Country code where the bank is located.  A valid value is an ISO two-character country code (e.g. 'NL').</value>
    [DataMember(Name="countryCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "countryCode")]
    public string CountryCode { get; set; }

    /// <summary>
    /// The [International Bank Account Number](https://en.wikipedia.org/wiki/International_Bank_Account_Number) (IBAN).
    /// </summary>
    /// <value>The [International Bank Account Number](https://en.wikipedia.org/wiki/International_Bank_Account_Number) (IBAN).</value>
    [DataMember(Name="iban", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "iban")]
    public string Iban { get; set; }

    /// <summary>
    /// The name of the bank account holder. If you submit a name with non-Latin characters, we automatically replace some of them with corresponding Latin characters to meet the FATF recommendations. For example: * χ12 is converted to ch12. * üA is converted to euA. * Peter Møller is converted to Peter Mller, because banks don't accept 'ø'. After replacement, the ownerName must have at least three alphanumeric characters (A-Z, a-z, 0-9), and at least one of them must be a valid Latin character (A-Z, a-z). For example: * John17 - allowed. * J17 - allowed. * 171 - not allowed. * John-7 - allowed. > If provided details don't match the required format, the response returns the error message: 203 'Invalid bank account holder name'.
    /// </summary>
    /// <value>The name of the bank account holder. If you submit a name with non-Latin characters, we automatically replace some of them with corresponding Latin characters to meet the FATF recommendations. For example: * χ12 is converted to ch12. * üA is converted to euA. * Peter Møller is converted to Peter Mller, because banks don't accept 'ø'. After replacement, the ownerName must have at least three alphanumeric characters (A-Z, a-z, 0-9), and at least one of them must be a valid Latin character (A-Z, a-z). For example: * John17 - allowed. * J17 - allowed. * 171 - not allowed. * John-7 - allowed. > If provided details don't match the required format, the response returns the error message: 203 'Invalid bank account holder name'.</value>
    [DataMember(Name="ownerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ownerName")]
    public string OwnerName { get; set; }

    /// <summary>
    /// The bank account holder's tax ID.
    /// </summary>
    /// <value>The bank account holder's tax ID.</value>
    [DataMember(Name="taxId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxId")]
    public string TaxId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BankAccount {\n");
      sb.Append("  BankAccountNumber: ").Append(BankAccountNumber).Append("\n");
      sb.Append("  BankCity: ").Append(BankCity).Append("\n");
      sb.Append("  BankLocationId: ").Append(BankLocationId).Append("\n");
      sb.Append("  BankName: ").Append(BankName).Append("\n");
      sb.Append("  Bic: ").Append(Bic).Append("\n");
      sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
      sb.Append("  Iban: ").Append(Iban).Append("\n");
      sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
      sb.Append("  TaxId: ").Append(TaxId).Append("\n");
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
