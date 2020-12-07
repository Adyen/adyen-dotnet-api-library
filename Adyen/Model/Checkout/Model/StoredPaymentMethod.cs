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
  public class StoredPaymentMethod {
    /// <summary>
    /// The brand of the card.
    /// </summary>
    /// <value>The brand of the card.</value>
    [DataMember(Name="brand", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "brand")]
    public string Brand { get; set; }

    /// <summary>
    /// The month the card expires.
    /// </summary>
    /// <value>The month the card expires.</value>
    [DataMember(Name="expiryMonth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiryMonth")]
    public string ExpiryMonth { get; set; }

    /// <summary>
    /// The year the card expires.
    /// </summary>
    /// <value>The year the card expires.</value>
    [DataMember(Name="expiryYear", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiryYear")]
    public string ExpiryYear { get; set; }

    /// <summary>
    /// The unique payment method code.
    /// </summary>
    /// <value>The unique payment method code.</value>
    [DataMember(Name="holderName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "holderName")]
    public string HolderName { get; set; }

    /// <summary>
    /// A unique identifier of this stored payment method.
    /// </summary>
    /// <value>A unique identifier of this stored payment method.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The last four digits of the PAN.
    /// </summary>
    /// <value>The last four digits of the PAN.</value>
    [DataMember(Name="lastFour", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastFour")]
    public string LastFour { get; set; }

    /// <summary>
    /// The display name of the stored payment method.
    /// </summary>
    /// <value>The display name of the stored payment method.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The shopper’s email address.
    /// </summary>
    /// <value>The shopper’s email address.</value>
    [DataMember(Name="shopperEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shopperEmail")]
    public string ShopperEmail { get; set; }

    /// <summary>
    /// The supported shopper interactions for this stored payment method.
    /// </summary>
    /// <value>The supported shopper interactions for this stored payment method.</value>
    [DataMember(Name="supportedShopperInteractions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supportedShopperInteractions")]
    public List<string> SupportedShopperInteractions { get; set; }

    /// <summary>
    /// The type of payment method.
    /// </summary>
    /// <value>The type of payment method.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StoredPaymentMethod {\n");
      sb.Append("  Brand: ").Append(Brand).Append("\n");
      sb.Append("  ExpiryMonth: ").Append(ExpiryMonth).Append("\n");
      sb.Append("  ExpiryYear: ").Append(ExpiryYear).Append("\n");
      sb.Append("  HolderName: ").Append(HolderName).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LastFour: ").Append(LastFour).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ShopperEmail: ").Append(ShopperEmail).Append("\n");
      sb.Append("  SupportedShopperInteractions: ").Append(SupportedShopperInteractions).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
