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
  public class ResponseAdditionalDataBillingAddress {
    /// <summary>
    /// The billing address city passed in the payment request.
    /// </summary>
    /// <value>The billing address city passed in the payment request.</value>
    [DataMember(Name="billingAddress.city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billingAddress.city")]
    public string BillingAddressCity { get; set; }

    /// <summary>
    /// The billing address country passed in the payment request.  Example: NL
    /// </summary>
    /// <value>The billing address country passed in the payment request.  Example: NL</value>
    [DataMember(Name="billingAddress.country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billingAddress.country")]
    public string BillingAddressCountry { get; set; }

    /// <summary>
    /// The billing address house number or name passed in the payment request.
    /// </summary>
    /// <value>The billing address house number or name passed in the payment request.</value>
    [DataMember(Name="billingAddress.houseNumberOrName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billingAddress.houseNumberOrName")]
    public string BillingAddressHouseNumberOrName { get; set; }

    /// <summary>
    /// The billing address postal code passed in the payment request.  Example: 1011 DJ
    /// </summary>
    /// <value>The billing address postal code passed in the payment request.  Example: 1011 DJ</value>
    [DataMember(Name="billingAddress.postalCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billingAddress.postalCode")]
    public string BillingAddressPostalCode { get; set; }

    /// <summary>
    /// The billing address state or province passed in the payment request.  Example: NH
    /// </summary>
    /// <value>The billing address state or province passed in the payment request.  Example: NH</value>
    [DataMember(Name="billingAddress.stateOrProvince", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billingAddress.stateOrProvince")]
    public string BillingAddressStateOrProvince { get; set; }

    /// <summary>
    /// The billing address street passed in the payment request.
    /// </summary>
    /// <value>The billing address street passed in the payment request.</value>
    [DataMember(Name="billingAddress.street", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billingAddress.street")]
    public string BillingAddressStreet { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ResponseAdditionalDataBillingAddress {\n");
      sb.Append("  BillingAddressCity: ").Append(BillingAddressCity).Append("\n");
      sb.Append("  BillingAddressCountry: ").Append(BillingAddressCountry).Append("\n");
      sb.Append("  BillingAddressHouseNumberOrName: ").Append(BillingAddressHouseNumberOrName).Append("\n");
      sb.Append("  BillingAddressPostalCode: ").Append(BillingAddressPostalCode).Append("\n");
      sb.Append("  BillingAddressStateOrProvince: ").Append(BillingAddressStateOrProvince).Append("\n");
      sb.Append("  BillingAddressStreet: ").Append(BillingAddressStreet).Append("\n");
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
