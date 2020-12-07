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
  public class CheckoutVoucherAction {
    /// <summary>
    /// The voucher alternative reference code.
    /// </summary>
    /// <value>The voucher alternative reference code.</value>
    [DataMember(Name="alternativeReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alternativeReference")]
    public string AlternativeReference { get; set; }

    /// <summary>
    /// A collection institution number (store number) for Econtext Pay-Easy ATM.
    /// </summary>
    /// <value>A collection institution number (store number) for Econtext Pay-Easy ATM.</value>
    [DataMember(Name="collectionInstitutionNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "collectionInstitutionNumber")]
    public string CollectionInstitutionNumber { get; set; }

    /// <summary>
    /// The URL to download the voucher.
    /// </summary>
    /// <value>The URL to download the voucher.</value>
    [DataMember(Name="downloadUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "downloadUrl")]
    public string DownloadUrl { get; set; }

    /// <summary>
    /// An entity number of Multibanco.
    /// </summary>
    /// <value>An entity number of Multibanco.</value>
    [DataMember(Name="entity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entity")]
    public string Entity { get; set; }

    /// <summary>
    /// The date time of the voucher expiry.
    /// </summary>
    /// <value>The date time of the voucher expiry.</value>
    [DataMember(Name="expiresAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiresAt")]
    public string ExpiresAt { get; set; }

    /// <summary>
    /// Gets or Sets InitialAmount
    /// </summary>
    [DataMember(Name="initialAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "initialAmount")]
    public Amount InitialAmount { get; set; }

    /// <summary>
    /// The URL to the detailed instructions to make payment using the voucher.
    /// </summary>
    /// <value>The URL to the detailed instructions to make payment using the voucher.</value>
    [DataMember(Name="instructionsUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instructionsUrl")]
    public string InstructionsUrl { get; set; }

    /// <summary>
    /// The issuer of the voucher.
    /// </summary>
    /// <value>The issuer of the voucher.</value>
    [DataMember(Name="issuer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issuer")]
    public string Issuer { get; set; }

    /// <summary>
    /// The shopper telephone number (partially masked).
    /// </summary>
    /// <value>The shopper telephone number (partially masked).</value>
    [DataMember(Name="maskedTelephoneNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maskedTelephoneNumber")]
    public string MaskedTelephoneNumber { get; set; }

    /// <summary>
    /// The merchant name.
    /// </summary>
    /// <value>The merchant name.</value>
    [DataMember(Name="merchantName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantName")]
    public string MerchantName { get; set; }

    /// <summary>
    /// The merchant reference.
    /// </summary>
    /// <value>The merchant reference.</value>
    [DataMember(Name="merchantReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantReference")]
    public string MerchantReference { get; set; }

    /// <summary>
    /// When non-empty, contains a value that you must submit to the `/payments/details` endpoint. In some cases, required for polling.
    /// </summary>
    /// <value>When non-empty, contains a value that you must submit to the `/payments/details` endpoint. In some cases, required for polling.</value>
    [DataMember(Name="paymentData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentData")]
    public string PaymentData { get; set; }

    /// <summary>
    /// Specifies the payment method.
    /// </summary>
    /// <value>Specifies the payment method.</value>
    [DataMember(Name="paymentMethodType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentMethodType")]
    public string PaymentMethodType { get; set; }

    /// <summary>
    /// The voucher reference code.
    /// </summary>
    /// <value>The voucher reference code.</value>
    [DataMember(Name="reference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reference")]
    public string Reference { get; set; }

    /// <summary>
    /// The shopper email.
    /// </summary>
    /// <value>The shopper email.</value>
    [DataMember(Name="shopperEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shopperEmail")]
    public string ShopperEmail { get; set; }

    /// <summary>
    /// The shopper name.
    /// </summary>
    /// <value>The shopper name.</value>
    [DataMember(Name="shopperName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shopperName")]
    public string ShopperName { get; set; }

    /// <summary>
    /// Gets or Sets Surcharge
    /// </summary>
    [DataMember(Name="surcharge", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "surcharge")]
    public Amount Surcharge { get; set; }

    /// <summary>
    /// Gets or Sets TotalAmount
    /// </summary>
    [DataMember(Name="totalAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalAmount")]
    public Amount TotalAmount { get; set; }

    /// <summary>
    /// Specifies the URL to redirect to.
    /// </summary>
    /// <value>Specifies the URL to redirect to.</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CheckoutVoucherAction {\n");
      sb.Append("  AlternativeReference: ").Append(AlternativeReference).Append("\n");
      sb.Append("  CollectionInstitutionNumber: ").Append(CollectionInstitutionNumber).Append("\n");
      sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
      sb.Append("  Entity: ").Append(Entity).Append("\n");
      sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
      sb.Append("  InitialAmount: ").Append(InitialAmount).Append("\n");
      sb.Append("  InstructionsUrl: ").Append(InstructionsUrl).Append("\n");
      sb.Append("  Issuer: ").Append(Issuer).Append("\n");
      sb.Append("  MaskedTelephoneNumber: ").Append(MaskedTelephoneNumber).Append("\n");
      sb.Append("  MerchantName: ").Append(MerchantName).Append("\n");
      sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
      sb.Append("  PaymentData: ").Append(PaymentData).Append("\n");
      sb.Append("  PaymentMethodType: ").Append(PaymentMethodType).Append("\n");
      sb.Append("  Reference: ").Append(Reference).Append("\n");
      sb.Append("  ShopperEmail: ").Append(ShopperEmail).Append("\n");
      sb.Append("  ShopperName: ").Append(ShopperName).Append("\n");
      sb.Append("  Surcharge: ").Append(Surcharge).Append("\n");
      sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
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
