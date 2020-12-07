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
  public class PaymentMethodsRequest {
    /// <summary>
    /// This field contains additional data, which may be required for a particular payment request.  The `additionalData` object consists of entries, each of which includes the key and value.
    /// </summary>
    /// <value>This field contains additional data, which may be required for a particular payment request.  The `additionalData` object consists of entries, each of which includes the key and value.</value>
    [DataMember(Name="additionalData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additionalData")]
    public AnyOfPaymentMethodsRequestAdditionalData AdditionalData { get; set; }

    /// <summary>
    /// List of payments methods to be presented to the shopper. To refer to payment methods, use their `paymentMethod.type` from [Payment methods overview](https://docs.adyen.com/payment-methods).  Example: `\"allowedPaymentMethods\":[\"ideal\",\"giropay\"]`
    /// </summary>
    /// <value>List of payments methods to be presented to the shopper. To refer to payment methods, use their `paymentMethod.type` from [Payment methods overview](https://docs.adyen.com/payment-methods).  Example: `\"allowedPaymentMethods\":[\"ideal\",\"giropay\"]`</value>
    [DataMember(Name="allowedPaymentMethods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowedPaymentMethods")]
    public List<string> AllowedPaymentMethods { get; set; }

    /// <summary>
    /// Gets or Sets Amount
    /// </summary>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public Amount Amount { get; set; }

    /// <summary>
    /// List of payments methods to be hidden from the shopper. To refer to payment methods, use their `paymentMethod.type` from [Payment methods overview](https://docs.adyen.com/payment-methods).  Example: `\"blockedPaymentMethods\":[\"ideal\",\"giropay\"]`
    /// </summary>
    /// <value>List of payments methods to be hidden from the shopper. To refer to payment methods, use their `paymentMethod.type` from [Payment methods overview](https://docs.adyen.com/payment-methods).  Example: `\"blockedPaymentMethods\":[\"ideal\",\"giropay\"]`</value>
    [DataMember(Name="blockedPaymentMethods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blockedPaymentMethods")]
    public List<string> BlockedPaymentMethods { get; set; }

    /// <summary>
    /// The platform where a payment transaction takes place. This field can be used for filtering out payment methods that are only available on specific platforms. Possible values: * iOS * Android * Web
    /// </summary>
    /// <value>The platform where a payment transaction takes place. This field can be used for filtering out payment methods that are only available on specific platforms. Possible values: * iOS * Android * Web</value>
    [DataMember(Name="channel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "channel")]
    public string Channel { get; set; }

    /// <summary>
    /// The shopper's country code.
    /// </summary>
    /// <value>The shopper's country code.</value>
    [DataMember(Name="countryCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "countryCode")]
    public string CountryCode { get; set; }

    /// <summary>
    /// The merchant account identifier, with which you want to process the transaction.
    /// </summary>
    /// <value>The merchant account identifier, with which you want to process the transaction.</value>
    [DataMember(Name="merchantAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantAccount")]
    public string MerchantAccount { get; set; }

    /// <summary>
    /// Gets or Sets Order
    /// </summary>
    [DataMember(Name="order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order")]
    public CheckoutOrder Order { get; set; }

    /// <summary>
    /// The combination of a language code and a country code to specify the language to be used in the payment.
    /// </summary>
    /// <value>The combination of a language code and a country code to specify the language to be used in the payment.</value>
    [DataMember(Name="shopperLocale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shopperLocale")]
    public string ShopperLocale { get; set; }

    /// <summary>
    /// Your reference to uniquely identify this shopper (for example, user ID or account ID). Minimum length: 3 characters. > This field is required for recurring payments.
    /// </summary>
    /// <value>Your reference to uniquely identify this shopper (for example, user ID or account ID). Minimum length: 3 characters. > This field is required for recurring payments.</value>
    [DataMember(Name="shopperReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shopperReference")]
    public string ShopperReference { get; set; }

    /// <summary>
    /// Boolean value indicating whether the card payment method should be split into separate debit and credit options.
    /// </summary>
    /// <value>Boolean value indicating whether the card payment method should be split into separate debit and credit options.</value>
    [DataMember(Name="splitCardFundingSources", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "splitCardFundingSources")]
    public bool? SplitCardFundingSources { get; set; }

    /// <summary>
    /// The physical store, for which this payment is processed.
    /// </summary>
    /// <value>The physical store, for which this payment is processed.</value>
    [DataMember(Name="store", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "store")]
    public string Store { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentMethodsRequest {\n");
      sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
      sb.Append("  AllowedPaymentMethods: ").Append(AllowedPaymentMethods).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  BlockedPaymentMethods: ").Append(BlockedPaymentMethods).Append("\n");
      sb.Append("  Channel: ").Append(Channel).Append("\n");
      sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
      sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
      sb.Append("  Order: ").Append(Order).Append("\n");
      sb.Append("  ShopperLocale: ").Append(ShopperLocale).Append("\n");
      sb.Append("  ShopperReference: ").Append(ShopperReference).Append("\n");
      sb.Append("  SplitCardFundingSources: ").Append(SplitCardFundingSources).Append("\n");
      sb.Append("  Store: ").Append(Store).Append("\n");
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
