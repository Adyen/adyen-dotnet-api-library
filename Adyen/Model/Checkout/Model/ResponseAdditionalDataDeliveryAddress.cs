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
  public class ResponseAdditionalDataDeliveryAddress {
    /// <summary>
    /// The delivery address city passed in the payment request.
    /// </summary>
    /// <value>The delivery address city passed in the payment request.</value>
    [DataMember(Name="deliveryAddress.city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deliveryAddress.city")]
    public string DeliveryAddressCity { get; set; }

    /// <summary>
    /// The delivery address country passed in the payment request.  Example: NL
    /// </summary>
    /// <value>The delivery address country passed in the payment request.  Example: NL</value>
    [DataMember(Name="deliveryAddress.country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deliveryAddress.country")]
    public string DeliveryAddressCountry { get; set; }

    /// <summary>
    /// The delivery address house number or name passed in the payment request.
    /// </summary>
    /// <value>The delivery address house number or name passed in the payment request.</value>
    [DataMember(Name="deliveryAddress.houseNumberOrName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deliveryAddress.houseNumberOrName")]
    public string DeliveryAddressHouseNumberOrName { get; set; }

    /// <summary>
    /// The delivery address postal code passed in the payment request.  Example: 1011 DJ
    /// </summary>
    /// <value>The delivery address postal code passed in the payment request.  Example: 1011 DJ</value>
    [DataMember(Name="deliveryAddress.postalCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deliveryAddress.postalCode")]
    public string DeliveryAddressPostalCode { get; set; }

    /// <summary>
    /// The delivery address state or province passed in the payment request.  Example: NH
    /// </summary>
    /// <value>The delivery address state or province passed in the payment request.  Example: NH</value>
    [DataMember(Name="deliveryAddress.stateOrProvince", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deliveryAddress.stateOrProvince")]
    public string DeliveryAddressStateOrProvince { get; set; }

    /// <summary>
    /// The delivery address street passed in the payment request.
    /// </summary>
    /// <value>The delivery address street passed in the payment request.</value>
    [DataMember(Name="deliveryAddress.street", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deliveryAddress.street")]
    public string DeliveryAddressStreet { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ResponseAdditionalDataDeliveryAddress {\n");
      sb.Append("  DeliveryAddressCity: ").Append(DeliveryAddressCity).Append("\n");
      sb.Append("  DeliveryAddressCountry: ").Append(DeliveryAddressCountry).Append("\n");
      sb.Append("  DeliveryAddressHouseNumberOrName: ").Append(DeliveryAddressHouseNumberOrName).Append("\n");
      sb.Append("  DeliveryAddressPostalCode: ").Append(DeliveryAddressPostalCode).Append("\n");
      sb.Append("  DeliveryAddressStateOrProvince: ").Append(DeliveryAddressStateOrProvince).Append("\n");
      sb.Append("  DeliveryAddressStreet: ").Append(DeliveryAddressStreet).Append("\n");
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
