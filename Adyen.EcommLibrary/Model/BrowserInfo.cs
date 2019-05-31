using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Adyen.EcommLibrary.Util;

namespace Adyen.EcommLibrary.Model
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
        /// <param name="AcceptHeader">The accept header value of the shopper&#39;s browser..</param>
        /// <param name="UserAgent">The user agent value of the shopper&#39;s browser..</param>
        public BrowserInfo(string AcceptHeader = default(string), string UserAgent = default(string))
        {
            this.AcceptHeader = AcceptHeader;
            this.UserAgent = UserAgent;
        }

        /// <summary>
        /// The accept header value of the shopper&#39;s browser.
        /// </summary>
        /// <value>The accept header value of the shopper&#39;s browser.</value>
        [DataMember(Name = "acceptHeader", EmitDefaultValue = false)]
        public string AcceptHeader { get; set; }

        /// <summary>
        /// The user agent value of the shopper&#39;s browser.
        /// </summary>
        /// <value>The user agent value of the shopper&#39;s browser.</value>
        [DataMember(Name = "userAgent", EmitDefaultValue = false)]
        public string UserAgent { get; set; }

        /// <summary>
        /// The language of the shopper&#39;s browser.
        /// </summary>
        /// <value>The language of the shopper&#39;s browser.</value>
        [DataMember(Name = "language")]
        public string Language { get; set; }

        /// <summary>
        /// The color depth of the shopper&#39;s browser.
        /// </summary>
        /// <value>The Color Depth value of the shopper&#39;s browser.</value>
        [DataMember(Name = "colorDepth")]
        public int ColorDepth { get; set; }

        /// <summary>
        /// The screen height of the shopper&#39;s browser.
        /// </summary>
        /// <value>The screen height of the shopper&#39;s browser.</value>
        [DataMember(Name = "screenHeight")]
        public int ScreenHeight { get; set; }

        /// <summary>
        /// The screen width of the shopper&#39;s browser.
        /// </summary>
        /// <value>The screen width of the shopper&#39;s browser.</value>
        [DataMember(Name = "screenWidth")]
        public int ScreenWidth { get; set; }

        /// <summary>
        /// The timezone offset of the shopper&#39;s browser.
        /// </summary>
        /// <value>The timezone offest of the shopper&#39;s browser.</value>
        [DataMember(Name = "timeZoneOffset")]
        public int TimeZoneOffset { get; set; }

        /// <summary>
        /// The java enabled value of the shopper&#39;s browser.
        /// </summary>
        /// <value>The java enabled value of the shopper&#39;s browser.</value>
        [DataMember(Name = "javaEnabled")]
        public bool JavaEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return this.ToClassDefinitionString();
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return Equals(obj as BrowserInfo);
        }

        /// <summary>
        /// Returns true if BrowserInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of BrowserInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrowserInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    AcceptHeader == other.AcceptHeader ||
                    AcceptHeader != null &&
                    AcceptHeader.Equals(other.AcceptHeader)
                ) &&
                (
                    UserAgent == other.UserAgent ||
                    UserAgent != null &&
                    UserAgent.Equals(other.UserAgent)
                ) &&
                (
                    Language == other.Language ||
                    Language != null &&
                    Language.Equals(other.Language)
                )
                &&
                ColorDepth == other.ColorDepth
                &&
                ScreenHeight == other.ScreenHeight
                &&
                ScreenWidth == other.ScreenWidth &&
                TimeZoneOffset == other.TimeZoneOffset &&
                JavaEnabled == other.JavaEnabled;
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                var hash = 41;
                // Suitable nullity checks etc, of course :)

                if (AcceptHeader != null)
                    hash = hash * 59 + AcceptHeader.GetHashCode();
                if (UserAgent != null)
                    hash = hash * 59 + UserAgent.GetHashCode();
                if (Language != null)
                    hash = hash * 59 + Language.GetHashCode();
                if (ColorDepth != null)
                    hash = hash * 59 + ColorDepth.GetHashCode();
                if (ScreenHeight != null)
                    hash = hash * 59 + ScreenHeight.GetHashCode();
                if (ScreenWidth != null)
                    hash = hash * 59 + ScreenWidth.GetHashCode();
                if (TimeZoneOffset != null)
                    hash = hash * 59 + TimeZoneOffset.GetHashCode();
                if (JavaEnabled != null)
                    hash = hash * 59 + JavaEnabled.GetHashCode();

                return hash;
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