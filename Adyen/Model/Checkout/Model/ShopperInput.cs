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
  public class ShopperInput {
    /// <summary>
    /// Specifies visibility of billing address fields.  Permitted values: * editable * hidden * readOnly
    /// </summary>
    /// <value>Specifies visibility of billing address fields.  Permitted values: * editable * hidden * readOnly</value>
    [DataMember(Name="billingAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billingAddress")]
    public string BillingAddress { get; set; }

    /// <summary>
    /// Specifies visibility of delivery address fields.  Permitted values: * editable * hidden * readOnly
    /// </summary>
    /// <value>Specifies visibility of delivery address fields.  Permitted values: * editable * hidden * readOnly</value>
    [DataMember(Name="deliveryAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deliveryAddress")]
    public string DeliveryAddress { get; set; }

    /// <summary>
    /// Specifies visibility of personal details.  Permitted values: * editable * hidden * readOnly
    /// </summary>
    /// <value>Specifies visibility of personal details.  Permitted values: * editable * hidden * readOnly</value>
    [DataMember(Name="personalDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "personalDetails")]
    public string PersonalDetails { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShopperInput {\n");
      sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
      sb.Append("  DeliveryAddress: ").Append(DeliveryAddress).Append("\n");
      sb.Append("  PersonalDetails: ").Append(PersonalDetails).Append("\n");
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
