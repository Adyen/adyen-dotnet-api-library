#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2019 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.BinLookup {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class CardBin {
    /// <summary>
    /// The first 6 digit of the card number. Enable this field via merchant account settings.
    /// </summary>
    /// <value>The first 6 digit of the card number. Enable this field via merchant account settings.</value>
    [DataMember(Name="bin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bin")]
    public string Bin { get; set; }

    /// <summary>
    /// If true, it indicates a commercial card. Enable this field via merchant account settings.
    /// </summary>
    /// <value>If true, it indicates a commercial card. Enable this field via merchant account settings.</value>
    [DataMember(Name="commercial", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commercial")]
    public bool? Commercial { get; set; }

    /// <summary>
    /// The card funding source. Valid values are: * CREDIT * DEBIT * PREPAID * PREPAID_RELOADABLE * DEFERRED_DEBIT * CHARGED > Enable this field via merchant account settings.
    /// </summary>
    /// <value>The card funding source. Valid values are: * CREDIT * DEBIT * PREPAID * PREPAID_RELOADABLE * DEFERRED_DEBIT * CHARGED > Enable this field via merchant account settings.</value>
    [DataMember(Name="fundingSource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fundingSource")]
    public string FundingSource { get; set; }

    /// <summary>
    /// Indicates availability of funds.  Visa: * \"I\" (fast funds are supported) * \"N\" (otherwise)  Mastercard: * \"I\" (product type is Prepaid or Debit, or issuing country is in CEE/HGEM list) * \"N\" (otherwise) > Returned when you verify a card BIN or estimate costs, and only if `payoutEligible` is different from \"N\" or \"U\".
    /// </summary>
    /// <value>Indicates availability of funds.  Visa: * \"I\" (fast funds are supported) * \"N\" (otherwise)  Mastercard: * \"I\" (product type is Prepaid or Debit, or issuing country is in CEE/HGEM list) * \"N\" (otherwise) > Returned when you verify a card BIN or estimate costs, and only if `payoutEligible` is different from \"N\" or \"U\".</value>
    [DataMember(Name="fundsAvailability", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fundsAvailability")]
    public string FundsAvailability { get; set; }

    /// <summary>
    /// The issuing bank of the card.
    /// </summary>
    /// <value>The issuing bank of the card.</value>
    [DataMember(Name="issuingBank", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issuingBank")]
    public string IssuingBank { get; set; }

    /// <summary>
    /// The country where the card was issued from.
    /// </summary>
    /// <value>The country where the card was issued from.</value>
    [DataMember(Name="issuingCountry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issuingCountry")]
    public string IssuingCountry { get; set; }

    /// <summary>
    /// The currency of the card.
    /// </summary>
    /// <value>The currency of the card.</value>
    [DataMember(Name="issuingCurrency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issuingCurrency")]
    public string IssuingCurrency { get; set; }

    /// <summary>
    /// The payment method associated with the card (e.g. visa, mc, or amex).
    /// </summary>
    /// <value>The payment method associated with the card (e.g. visa, mc, or amex).</value>
    [DataMember(Name="paymentMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentMethod")]
    public string PaymentMethod { get; set; }

    /// <summary>
    /// Indicates whether a payout is eligible or not for this card.  Visa: * \"Y\" * \"N\"  Mastercard: * \"Y\" (domestic and cross-border) * \"D\" (only domestic) * \"N\" (no MoneySend) * \"U\" (unknown) > Returned when you verify a card BIN or estimate costs, and only if `payoutEligible` is different from \"N\" or \"U\".
    /// </summary>
    /// <value>Indicates whether a payout is eligible or not for this card.  Visa: * \"Y\" * \"N\"  Mastercard: * \"Y\" (domestic and cross-border) * \"D\" (only domestic) * \"N\" (no MoneySend) * \"U\" (unknown) > Returned when you verify a card BIN or estimate costs, and only if `payoutEligible` is different from \"N\" or \"U\".</value>
    [DataMember(Name="payoutEligible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payoutEligible")]
    public string PayoutEligible { get; set; }

    /// <summary>
    /// The last four digits of the card number.
    /// </summary>
    /// <value>The last four digits of the card number.</value>
    [DataMember(Name="summary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "summary")]
    public string Summary { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CardBin {\n");
      sb.Append("  Bin: ").Append(Bin).Append("\n");
      sb.Append("  Commercial: ").Append(Commercial).Append("\n");
      sb.Append("  FundingSource: ").Append(FundingSource).Append("\n");
      sb.Append("  FundsAvailability: ").Append(FundsAvailability).Append("\n");
      sb.Append("  IssuingBank: ").Append(IssuingBank).Append("\n");
      sb.Append("  IssuingCountry: ").Append(IssuingCountry).Append("\n");
      sb.Append("  IssuingCurrency: ").Append(IssuingCurrency).Append("\n");
      sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
      sb.Append("  PayoutEligible: ").Append(PayoutEligible).Append("\n");
      sb.Append("  Summary: ").Append(Summary).Append("\n");
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
