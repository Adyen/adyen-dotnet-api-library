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
  public class BrowserInfo {
    /// <summary>
    /// The accept header value of the shopper's browser.
    /// </summary>
    /// <value>The accept header value of the shopper's browser.</value>
    [DataMember(Name="acceptHeader", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "acceptHeader")]
    public string AcceptHeader { get; set; }

    /// <summary>
    /// The color depth of the shopper's browser in bits per pixel. This should be obtained by using the browser's `screen.colorDepth` property. Accepted values: 1, 4, 8, 15, 16, 24, 30, 32 or 48 bit color depth.
    /// </summary>
    /// <value>The color depth of the shopper's browser in bits per pixel. This should be obtained by using the browser's `screen.colorDepth` property. Accepted values: 1, 4, 8, 15, 16, 24, 30, 32 or 48 bit color depth.</value>
    [DataMember(Name="colorDepth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "colorDepth")]
    public int? ColorDepth { get; set; }

    /// <summary>
    /// Boolean value indicating if the shopper's browser is able to execute Java.
    /// </summary>
    /// <value>Boolean value indicating if the shopper's browser is able to execute Java.</value>
    [DataMember(Name="javaEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "javaEnabled")]
    public bool? JavaEnabled { get; set; }

    /// <summary>
    /// Boolean value indicating if the shopper's browser is able to execute JavaScript. A default 'true' value is assumed if the field is not present.
    /// </summary>
    /// <value>Boolean value indicating if the shopper's browser is able to execute JavaScript. A default 'true' value is assumed if the field is not present.</value>
    [DataMember(Name="javaScriptEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "javaScriptEnabled")]
    public bool? JavaScriptEnabled { get; set; }

    /// <summary>
    /// The `navigator.language` value of the shopper's browser (as defined in IETF BCP 47).
    /// </summary>
    /// <value>The `navigator.language` value of the shopper's browser (as defined in IETF BCP 47).</value>
    [DataMember(Name="language", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "language")]
    public string Language { get; set; }

    /// <summary>
    /// The total height of the shopper's device screen in pixels.
    /// </summary>
    /// <value>The total height of the shopper's device screen in pixels.</value>
    [DataMember(Name="screenHeight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "screenHeight")]
    public int? ScreenHeight { get; set; }

    /// <summary>
    /// The total width of the shopper's device screen in pixels.
    /// </summary>
    /// <value>The total width of the shopper's device screen in pixels.</value>
    [DataMember(Name="screenWidth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "screenWidth")]
    public int? ScreenWidth { get; set; }

    /// <summary>
    /// Time difference between UTC time and the shopper's browser local time, in minutes.
    /// </summary>
    /// <value>Time difference between UTC time and the shopper's browser local time, in minutes.</value>
    [DataMember(Name="timeZoneOffset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timeZoneOffset")]
    public int? TimeZoneOffset { get; set; }

    /// <summary>
    /// The user agent value of the shopper's browser.
    /// </summary>
    /// <value>The user agent value of the shopper's browser.</value>
    [DataMember(Name="userAgent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userAgent")]
    public string UserAgent { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BrowserInfo {\n");
      sb.Append("  AcceptHeader: ").Append(AcceptHeader).Append("\n");
      sb.Append("  ColorDepth: ").Append(ColorDepth).Append("\n");
      sb.Append("  JavaEnabled: ").Append(JavaEnabled).Append("\n");
      sb.Append("  JavaScriptEnabled: ").Append(JavaScriptEnabled).Append("\n");
      sb.Append("  Language: ").Append(Language).Append("\n");
      sb.Append("  ScreenHeight: ").Append(ScreenHeight).Append("\n");
      sb.Append("  ScreenWidth: ").Append(ScreenWidth).Append("\n");
      sb.Append("  TimeZoneOffset: ").Append(TimeZoneOffset).Append("\n");
      sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
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
