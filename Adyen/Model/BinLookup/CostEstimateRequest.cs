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
using Adyen.Model.Enum;
using Newtonsoft.Json;

namespace Adyen.Model.BinLookup {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class CostEstimateRequest {
    /// <summary>
    /// Gets or Sets Amount
    /// </summary>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public Amount Amount { get; set; }

    /// <summary>
    /// Gets or Sets Assumptions
    /// </summary>
    [DataMember(Name="assumptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assumptions")]
    public CostEstimateAssumptions Assumptions { get; set; }

    /// <summary>
    /// The card number (4-19 characters) for PCI compliant use cases. Do not use any separators.  > Either the `cardNumber` or `encryptedCard` field must be provided in a payment request.
    /// </summary>
    /// <value>The card number (4-19 characters) for PCI compliant use cases. Do not use any separators.  > Either the `cardNumber` or `encryptedCard` field must be provided in a payment request.</value>
    [DataMember(Name="cardNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cardNumber")]
    public string CardNumber { get; set; }

    /// <summary>
    /// Encrypted data that stores card information for non PCI-compliant use cases. The encrypted data must be created with the Client-Side Encryption library and must contain at least the `number` and `generationtime` fields.  > Either the `cardNumber` or `encryptedCard` field must be provided in a payment request.
    /// </summary>
    /// <value>Encrypted data that stores card information for non PCI-compliant use cases. The encrypted data must be created with the Client-Side Encryption library and must contain at least the `number` and `generationtime` fields.  > Either the `cardNumber` or `encryptedCard` field must be provided in a payment request.</value>
    [DataMember(Name="encryptedCard", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "encryptedCard")]
    public string EncryptedCard { get; set; }

    /// <summary>
    /// The merchant account identifier you want to process the (transaction) request with.
    /// </summary>
    /// <value>The merchant account identifier you want to process the (transaction) request with.</value>
    [DataMember(Name="merchantAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantAccount")]
    public string MerchantAccount { get; set; }

    /// <summary>
    /// Gets or Sets MerchantDetails
    /// </summary>
    [DataMember(Name="merchantDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantDetails")]
    public MerchantDetails MerchantDetails { get; set; }

    /// <summary>
    /// Gets or Sets Recurring
    /// </summary>
    [DataMember(Name="recurring", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurring")]
    public Recurring Recurring { get; set; }

    /// <summary>
    /// The `recurringDetailReference` you want to use for this cost estimate. The value `LATEST` can be used to select the most recently stored recurring detail.
    /// </summary>
    /// <value>The `recurringDetailReference` you want to use for this cost estimate. The value `LATEST` can be used to select the most recently stored recurring detail.</value>
    [DataMember(Name="selectedRecurringDetailReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "selectedRecurringDetailReference")]
    public string SelectedRecurringDetailReference { get; set; }

    /// <summary>
    /// Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer. For the web service API, Adyen assumes Ecommerce shopper interaction by default.  This field has the following possible values: * `Ecommerce` - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request. * `ContAuth` - Card on file and/or subscription transactions, where the card holder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment). * `Moto` - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone. * `POS` - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal.
    /// </summary>
    /// <value>Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer. For the web service API, Adyen assumes Ecommerce shopper interaction by default.  This field has the following possible values: * `Ecommerce` - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request. * `ContAuth` - Card on file and/or subscription transactions, where the card holder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment). * `Moto` - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone. * `POS` - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal.</value>
    [DataMember(Name="shopperInteraction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shopperInteraction")]
    public ShopperInteraction ShopperInteraction { get; set; }

    /// <summary>
    /// The shopper's reference to uniquely identify this shopper (e.g. user ID or account ID). > This field is required for recurring payments.
    /// </summary>
    /// <value>The shopper's reference to uniquely identify this shopper (e.g. user ID or account ID). > This field is required for recurring payments.</value>
    [DataMember(Name="shopperReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shopperReference")]
    public string ShopperReference { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CostEstimateRequest {\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Assumptions: ").Append(Assumptions).Append("\n");
      sb.Append("  CardNumber: ").Append(CardNumber).Append("\n");
      sb.Append("  EncryptedCard: ").Append(EncryptedCard).Append("\n");
      sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
      sb.Append("  MerchantDetails: ").Append(MerchantDetails).Append("\n");
      sb.Append("  Recurring: ").Append(Recurring).Append("\n");
      sb.Append("  SelectedRecurringDetailReference: ").Append(SelectedRecurringDetailReference).Append("\n");
      sb.Append("  ShopperInteraction: ").Append(ShopperInteraction).Append("\n");
      sb.Append("  ShopperReference: ").Append(ShopperReference).Append("\n");
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
