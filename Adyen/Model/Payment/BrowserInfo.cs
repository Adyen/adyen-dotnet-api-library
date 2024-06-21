/*
* Adyen Payment API
*
*
* The version of the OpenAPI document: 68
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.Payment
{
    /// <summary>
    /// BrowserInfo
    /// </summary>
    [DataContract(Name = "BrowserInfo")]
    public partial class BrowserInfo : IEquatable<BrowserInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BrowserInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserInfo" /> class.
        /// </summary>
        /// <param name="acceptHeader">The accept header value of the shopper&#39;s browser. (required).</param>
        /// <param name="colorDepth">The color depth of the shopper&#39;s browser in bits per pixel. This should be obtained by using the browser&#39;s &#x60;screen.colorDepth&#x60; property. Accepted values: 1, 4, 8, 15, 16, 24, 30, 32 or 48 bit color depth. (required).</param>
        /// <param name="javaEnabled">Boolean value indicating if the shopper&#39;s browser is able to execute Java. (required).</param>
        /// <param name="javaScriptEnabled">Boolean value indicating if the shopper&#39;s browser is able to execute JavaScript. A default &#39;true&#39; value is assumed if the field is not present. (default to true).</param>
        /// <param name="language">The &#x60;navigator.language&#x60; value of the shopper&#39;s browser (as defined in IETF BCP 47). (required).</param>
        /// <param name="screenHeight">The total height of the shopper&#39;s device screen in pixels. (required).</param>
        /// <param name="screenWidth">The total width of the shopper&#39;s device screen in pixels. (required).</param>
        /// <param name="timeZoneOffset">Time difference between UTC time and the shopper&#39;s browser local time, in minutes. (required).</param>
        /// <param name="userAgent">The user agent value of the shopper&#39;s browser. (required).</param>
        public BrowserInfo(string acceptHeader = default(string), int? colorDepth = default(int?), bool? javaEnabled = default(bool?), bool? javaScriptEnabled = true, string language = default(string), int? screenHeight = default(int?), int? screenWidth = default(int?), int? timeZoneOffset = default(int?), string userAgent = default(string))
        {
            this.AcceptHeader = acceptHeader;
            this.ColorDepth = colorDepth;
            this.JavaEnabled = javaEnabled;
            this.Language = language;
            this.ScreenHeight = screenHeight;
            this.ScreenWidth = screenWidth;
            this.TimeZoneOffset = timeZoneOffset;
            this.UserAgent = userAgent;
            this.JavaScriptEnabled = javaScriptEnabled;
        }

        /// <summary>
        /// The accept header value of the shopper&#39;s browser.
        /// </summary>
        /// <value>The accept header value of the shopper&#39;s browser.</value>
        [DataMember(Name = "acceptHeader", IsRequired = false, EmitDefaultValue = false)]
        public string AcceptHeader { get; set; }

        /// <summary>
        /// The color depth of the shopper&#39;s browser in bits per pixel. This should be obtained by using the browser&#39;s &#x60;screen.colorDepth&#x60; property. Accepted values: 1, 4, 8, 15, 16, 24, 30, 32 or 48 bit color depth.
        /// </summary>
        /// <value>The color depth of the shopper&#39;s browser in bits per pixel. This should be obtained by using the browser&#39;s &#x60;screen.colorDepth&#x60; property. Accepted values: 1, 4, 8, 15, 16, 24, 30, 32 or 48 bit color depth.</value>
        [DataMember(Name = "colorDepth", IsRequired = false, EmitDefaultValue = false)]
        public int? ColorDepth { get; set; }

        /// <summary>
        /// Boolean value indicating if the shopper&#39;s browser is able to execute Java.
        /// </summary>
        /// <value>Boolean value indicating if the shopper&#39;s browser is able to execute Java.</value>
        [DataMember(Name = "javaEnabled", IsRequired = false, EmitDefaultValue = false)]
        public bool? JavaEnabled { get; set; }

        /// <summary>
        /// Boolean value indicating if the shopper&#39;s browser is able to execute JavaScript. A default &#39;true&#39; value is assumed if the field is not present.
        /// </summary>
        /// <value>Boolean value indicating if the shopper&#39;s browser is able to execute JavaScript. A default &#39;true&#39; value is assumed if the field is not present.</value>
        [DataMember(Name = "javaScriptEnabled", EmitDefaultValue = false)]
        public bool? JavaScriptEnabled { get; set; }

        /// <summary>
        /// The &#x60;navigator.language&#x60; value of the shopper&#39;s browser (as defined in IETF BCP 47).
        /// </summary>
        /// <value>The &#x60;navigator.language&#x60; value of the shopper&#39;s browser (as defined in IETF BCP 47).</value>
        [DataMember(Name = "language", IsRequired = false, EmitDefaultValue = false)]
        public string Language { get; set; }

        /// <summary>
        /// The total height of the shopper&#39;s device screen in pixels.
        /// </summary>
        /// <value>The total height of the shopper&#39;s device screen in pixels.</value>
        [DataMember(Name = "screenHeight", IsRequired = false, EmitDefaultValue = false)]
        public int? ScreenHeight { get; set; }

        /// <summary>
        /// The total width of the shopper&#39;s device screen in pixels.
        /// </summary>
        /// <value>The total width of the shopper&#39;s device screen in pixels.</value>
        [DataMember(Name = "screenWidth", IsRequired = false, EmitDefaultValue = false)]
        public int? ScreenWidth { get; set; }

        /// <summary>
        /// Time difference between UTC time and the shopper&#39;s browser local time, in minutes.
        /// </summary>
        /// <value>Time difference between UTC time and the shopper&#39;s browser local time, in minutes.</value>
        [DataMember(Name = "timeZoneOffset", IsRequired = false, EmitDefaultValue = false)]
        public int? TimeZoneOffset { get; set; }

        /// <summary>
        /// The user agent value of the shopper&#39;s browser.
        /// </summary>
        /// <value>The user agent value of the shopper&#39;s browser.</value>
        [DataMember(Name = "userAgent", IsRequired = false, EmitDefaultValue = false)]
        public string UserAgent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
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
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }
    
        /// <summary>
        /// Returns the BrowserInfo object from the json payload
        /// </summary>
        /// <returns>BrowserInfo</returns>
        public static BrowserInfo FromJson(string json)
        {
            return JsonConvert.DeserializeObject<BrowserInfo>(json);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BrowserInfo);
        }

        /// <summary>
        /// Returns true if BrowserInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of BrowserInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrowserInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AcceptHeader == input.AcceptHeader ||
                    (this.AcceptHeader != null &&
                    this.AcceptHeader.Equals(input.AcceptHeader))
                ) && 
                (
                    this.ColorDepth == input.ColorDepth ||
                    this.ColorDepth.Equals(input.ColorDepth)
                ) && 
                (
                    this.JavaEnabled == input.JavaEnabled ||
                    this.JavaEnabled.Equals(input.JavaEnabled)
                ) && 
                (
                    this.JavaScriptEnabled == input.JavaScriptEnabled ||
                    this.JavaScriptEnabled.Equals(input.JavaScriptEnabled)
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.ScreenHeight == input.ScreenHeight ||
                    this.ScreenHeight.Equals(input.ScreenHeight)
                ) && 
                (
                    this.ScreenWidth == input.ScreenWidth ||
                    this.ScreenWidth.Equals(input.ScreenWidth)
                ) && 
                (
                    this.TimeZoneOffset == input.TimeZoneOffset ||
                    this.TimeZoneOffset.Equals(input.TimeZoneOffset)
                ) && 
                (
                    this.UserAgent == input.UserAgent ||
                    (this.UserAgent != null &&
                    this.UserAgent.Equals(input.UserAgent))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AcceptHeader != null)
                {
                    hashCode = (hashCode * 59) + this.AcceptHeader.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ColorDepth.GetHashCode();
                hashCode = (hashCode * 59) + this.JavaEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.JavaScriptEnabled.GetHashCode();
                if (this.Language != null)
                {
                    hashCode = (hashCode * 59) + this.Language.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ScreenHeight.GetHashCode();
                hashCode = (hashCode * 59) + this.ScreenWidth.GetHashCode();
                hashCode = (hashCode * 59) + this.TimeZoneOffset.GetHashCode();
                if (this.UserAgent != null)
                {
                    hashCode = (hashCode * 59) + this.UserAgent.GetHashCode();
                }
                return hashCode;
            }
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
