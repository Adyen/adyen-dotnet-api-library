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
  public class Address {
    /// <summary>
    /// The name of the city.
    /// </summary>
    /// <value>The name of the city.</value>
    [DataMember(Name="city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    /// <summary>
    /// The two-character country code as defined in ISO-3166-1 alpha-2. For example, **US**. > If you don't know the country or are not collecting the country from the shopper, provide `country` as `ZZ`.
    /// </summary>
    /// <value>The two-character country code as defined in ISO-3166-1 alpha-2. For example, **US**. > If you don't know the country or are not collecting the country from the shopper, provide `country` as `ZZ`.</value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// The number or name of the house.
    /// </summary>
    /// <value>The number or name of the house.</value>
    [DataMember(Name="houseNumberOrName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "houseNumberOrName")]
    public string HouseNumberOrName { get; set; }

    /// <summary>
    /// A maximum of five digits for an address in the US, or a maximum of ten characters for an address in all other countries.
    /// </summary>
    /// <value>A maximum of five digits for an address in the US, or a maximum of ten characters for an address in all other countries.</value>
    [DataMember(Name="postalCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postalCode")]
    public string PostalCode { get; set; }

    /// <summary>
    /// State or province codes as defined in ISO 3166-2. For example, **CA** in the US or **ON** in Canada. > Required for the US and Canada.
    /// </summary>
    /// <value>State or province codes as defined in ISO 3166-2. For example, **CA** in the US or **ON** in Canada. > Required for the US and Canada.</value>
    [DataMember(Name="stateOrProvince", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stateOrProvince")]
    public string StateOrProvince { get; set; }

    /// <summary>
    /// The name of the street. > The house number should not be included in this field; it should be separately provided via `houseNumberOrName`.
    /// </summary>
    /// <value>The name of the street. > The house number should not be included in this field; it should be separately provided via `houseNumberOrName`.</value>
    [DataMember(Name="street", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "street")]
    public string Street { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Address {\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  HouseNumberOrName: ").Append(HouseNumberOrName).Append("\n");
      sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
      sb.Append("  StateOrProvince: ").Append(StateOrProvince).Append("\n");
      sb.Append("  Street: ").Append(Street).Append("\n");
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
