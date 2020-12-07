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
  public class ApplicationInfo {
    /// <summary>
    /// Gets or Sets AdyenLibrary
    /// </summary>
    [DataMember(Name="adyenLibrary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "adyenLibrary")]
    public CommonField AdyenLibrary { get; set; }

    /// <summary>
    /// Gets or Sets AdyenPaymentSource
    /// </summary>
    [DataMember(Name="adyenPaymentSource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "adyenPaymentSource")]
    public CommonField AdyenPaymentSource { get; set; }

    /// <summary>
    /// Gets or Sets ExternalPlatform
    /// </summary>
    [DataMember(Name="externalPlatform", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "externalPlatform")]
    public ExternalPlatform ExternalPlatform { get; set; }

    /// <summary>
    /// Gets or Sets MerchantApplication
    /// </summary>
    [DataMember(Name="merchantApplication", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantApplication")]
    public CommonField MerchantApplication { get; set; }

    /// <summary>
    /// Gets or Sets MerchantDevice
    /// </summary>
    [DataMember(Name="merchantDevice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantDevice")]
    public MerchantDevice MerchantDevice { get; set; }

    /// <summary>
    /// Gets or Sets ShopperInteractionDevice
    /// </summary>
    [DataMember(Name="shopperInteractionDevice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shopperInteractionDevice")]
    public ShopperInteractionDevice ShopperInteractionDevice { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApplicationInfo {\n");
      sb.Append("  AdyenLibrary: ").Append(AdyenLibrary).Append("\n");
      sb.Append("  AdyenPaymentSource: ").Append(AdyenPaymentSource).Append("\n");
      sb.Append("  ExternalPlatform: ").Append(ExternalPlatform).Append("\n");
      sb.Append("  MerchantApplication: ").Append(MerchantApplication).Append("\n");
      sb.Append("  MerchantDevice: ").Append(MerchantDevice).Append("\n");
      sb.Append("  ShopperInteractionDevice: ").Append(ShopperInteractionDevice).Append("\n");
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
