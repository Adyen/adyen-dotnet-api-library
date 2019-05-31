using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.EcommLibrary.Model.Checkout
{
    /// <summary>
    /// BrowserInfo
    /// </summary>
    [DataContract]
    public partial class BrowserInfo : IEquatable<BrowserInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserInfo" /> class.
        /// </summary>
        [JsonConstructor]
        protected BrowserInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserInfo" /> class.
        /// </summary>
        /// <param name="AcceptHeader">The accept header value of the shopper&#39;s browser. (required).</param>
        /// <param name="ColorDepth">The color depth of the shopper&#39;s device in bits per pixel. Should be obtained by using the browser&#39;s screen.colorDepth property..</param>
        /// <param name="JavaEnabled">Boolean value indicating if the shopper&#39;s browser is able to execute Java..</param>
        /// <param name="Language">The navigator.language value of the shopper&#39;s browser (as defined in IETF BCP 47)..</param>
        /// <param name="ScreenHeight">The total height of the shopper&#39;s device screen in pixels..</param>
        /// <param name="ScreenWidth">The total width of the shopper&#39;s device screen in pixels..</param>
        /// <param name="TimeZoneOffset">Time difference between UTC time and the shopper&#39;s browser local time, in minutes..</param>
        /// <param name="UserAgent">The user agent value of the shopper&#39;s browser. (required).</param>
        public BrowserInfo(string AcceptHeader = default(string), int? ColorDepth = default(int?),
            bool? JavaEnabled = default(bool?), string Language = default(string), int? ScreenHeight = default(int?),
            int? ScreenWidth = default(int?), int? TimeZoneOffset = default(int?), string UserAgent = default(string))
        {
            // to ensure "AcceptHeader" is required (not null)
            if (AcceptHeader == null)
                throw new InvalidDataException(
                    "AcceptHeader is a required property for BrowserInfo and cannot be null");
            else
                this.AcceptHeader = AcceptHeader;
            // to ensure "UserAgent" is required (not null)
            if (UserAgent == null)
                throw new InvalidDataException("UserAgent is a required property for BrowserInfo and cannot be null");
            else
                this.UserAgent = UserAgent;
            this.ColorDepth = ColorDepth;
            this.JavaEnabled = JavaEnabled;
            this.Language = Language;
            this.ScreenHeight = ScreenHeight;
            this.ScreenWidth = ScreenWidth;
            this.TimeZoneOffset = TimeZoneOffset;
        }

        /// <summary>
        /// The accept header value of the shopper&#39;s browser.
        /// </summary>
        /// <value>The accept header value of the shopper&#39;s browser.</value>
        [DataMember(Name = "acceptHeader", EmitDefaultValue = false)]
        public string AcceptHeader { get; set; }

        /// <summary>
        /// The color depth of the shopper&#39;s device in bits per pixel. Should be obtained by using the browser&#39;s screen.colorDepth property.
        /// </summary>
        /// <value>The color depth of the shopper&#39;s device in bits per pixel. Should be obtained by using the browser&#39;s screen.colorDepth property.</value>
        [DataMember(Name = "colorDepth", EmitDefaultValue = false)]
        public int? ColorDepth { get; set; }

        /// <summary>
        /// Boolean value indicating if the shopper&#39;s browser is able to execute Java.
        /// </summary>
        /// <value>Boolean value indicating if the shopper&#39;s browser is able to execute Java.</value>
        [DataMember(Name = "javaEnabled", EmitDefaultValue = false)]
        public bool? JavaEnabled { get; set; }

        /// <summary>
        /// The navigator.language value of the shopper&#39;s browser (as defined in IETF BCP 47).
        /// </summary>
        /// <value>The navigator.language value of the shopper&#39;s browser (as defined in IETF BCP 47).</value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public string Language { get; set; }

        /// <summary>
        /// The total height of the shopper&#39;s device screen in pixels.
        /// </summary>
        /// <value>The total height of the shopper&#39;s device screen in pixels.</value>
        [DataMember(Name = "screenHeight", EmitDefaultValue = false)]
        public int? ScreenHeight { get; set; }

        /// <summary>
        /// The total width of the shopper&#39;s device screen in pixels.
        /// </summary>
        /// <value>The total width of the shopper&#39;s device screen in pixels.</value>
        [DataMember(Name = "screenWidth", EmitDefaultValue = false)]
        public int? ScreenWidth { get; set; }

        /// <summary>
        /// Time difference between UTC time and the shopper&#39;s browser local time, in minutes.
        /// </summary>
        /// <value>Time difference between UTC time and the shopper&#39;s browser local time, in minutes.</value>
        [DataMember(Name = "timeZoneOffset", EmitDefaultValue = false)]
        public int? TimeZoneOffset { get; set; }

        /// <summary>
        /// The user agent value of the shopper&#39;s browser.
        /// </summary>
        /// <value>The user agent value of the shopper&#39;s browser.</value>
        [DataMember(Name = "userAgent", EmitDefaultValue = false)]
        public string UserAgent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrowserInfo {\n");
            sb.Append("  AcceptHeader: ").Append(AcceptHeader).Append("\n");
            sb.Append("  ColorDepth: ").Append(ColorDepth).Append("\n");
            sb.Append("  JavaEnabled: ").Append(JavaEnabled).Append("\n");
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
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as BrowserInfo);
        }

        /// <summary>
        /// Returns true if BrowserInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of BrowserInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrowserInfo input)
        {
            if (input == null)
                return false;

            return
                (
                    AcceptHeader == input.AcceptHeader ||
                    AcceptHeader != null &&
                    AcceptHeader.Equals(input.AcceptHeader)
                ) &&
                (
                    ColorDepth == input.ColorDepth ||
                    ColorDepth != null &&
                    ColorDepth.Equals(input.ColorDepth)
                ) &&
                (
                    JavaEnabled == input.JavaEnabled ||
                    JavaEnabled != null &&
                    JavaEnabled.Equals(input.JavaEnabled)
                ) &&
                (
                    Language == input.Language ||
                    Language != null &&
                    Language.Equals(input.Language)
                ) &&
                (
                    ScreenHeight == input.ScreenHeight ||
                    ScreenHeight != null &&
                    ScreenHeight.Equals(input.ScreenHeight)
                ) &&
                (
                    ScreenWidth == input.ScreenWidth ||
                    ScreenWidth != null &&
                    ScreenWidth.Equals(input.ScreenWidth)
                ) &&
                (
                    TimeZoneOffset == input.TimeZoneOffset ||
                    TimeZoneOffset != null &&
                    TimeZoneOffset.Equals(input.TimeZoneOffset)
                ) &&
                (
                    UserAgent == input.UserAgent ||
                    UserAgent != null &&
                    UserAgent.Equals(input.UserAgent)
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
                var hashCode = 41;
                if (AcceptHeader != null)
                    hashCode = hashCode * 59 + AcceptHeader.GetHashCode();
                if (ColorDepth != null)
                    hashCode = hashCode * 59 + ColorDepth.GetHashCode();
                if (JavaEnabled != null)
                    hashCode = hashCode * 59 + JavaEnabled.GetHashCode();
                if (Language != null)
                    hashCode = hashCode * 59 + Language.GetHashCode();
                if (ScreenHeight != null)
                    hashCode = hashCode * 59 + ScreenHeight.GetHashCode();
                if (ScreenWidth != null)
                    hashCode = hashCode * 59 + ScreenWidth.GetHashCode();
                if (TimeZoneOffset != null)
                    hashCode = hashCode * 59 + TimeZoneOffset.GetHashCode();
                if (UserAgent != null)
                    hashCode = hashCode * 59 + UserAgent.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // AcceptHeader (string) maxLength
            if (AcceptHeader != null && AcceptHeader.Length > 50)
                yield return new ValidationResult("Invalid value for AcceptHeader, length must be less than 50.",
                    new[] {"AcceptHeader"});

            // AcceptHeader (string) minLength
            if (AcceptHeader != null && AcceptHeader.Length < 10)
                yield return new ValidationResult("Invalid value for AcceptHeader, length must be greater than 10.",
                    new[] {"AcceptHeader"});

            // UserAgent (string) maxLength
            if (UserAgent != null && UserAgent.Length > 50)
                yield return new ValidationResult("Invalid value for UserAgent, length must be less than 50.",
                    new[] {"UserAgent"});

            // UserAgent (string) minLength
            if (UserAgent != null && UserAgent.Length < 10)
                yield return new ValidationResult("Invalid value for UserAgent, length must be greater than 10.",
                    new[] {"UserAgent"});

            yield break;
        }
    }
}