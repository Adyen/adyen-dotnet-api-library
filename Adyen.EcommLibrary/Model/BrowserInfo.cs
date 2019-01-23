using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Adyen.EcommLibrary.Model
{
    /// <summary>
    /// BrowserInfo
    /// </summary>
    [DataContract]
    public partial class BrowserInfo :  IEquatable<BrowserInfo>, IValidatableObject
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
        [DataMember(Name="acceptHeader", EmitDefaultValue=false)]
        public string AcceptHeader { get; set; }

        /// <summary>
        /// The user agent value of the shopper&#39;s browser.
        /// </summary>
        /// <value>The user agent value of the shopper&#39;s browser.</value>
        [DataMember(Name="userAgent", EmitDefaultValue=false)]
        public string UserAgent { get; set; }

        /// <summary>
        /// The language of the shopper&#39;s browser.
        /// </summary>
        /// <value>The language of the shopper&#39;s browser.</value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public string Language { get; set; }

        /// <summary>
        /// The color depth of the shopper&#39;s browser.
        /// </summary>
        /// <value>The Color Depth value of the shopper&#39;s browser.</value>
        [DataMember(Name = "colorDepth", EmitDefaultValue = false)]
        public int ColorDepth { get; set; }

        /// <summary>
        /// The screen height of the shopper&#39;s browser.
        /// </summary>
        /// <value>The screen height of the shopper&#39;s browser.</value>
        [DataMember(Name = "screenHeight", EmitDefaultValue = false)]
        public int ScreenHeight { get; set; }

        /// <summary>
        /// The screen width of the shopper&#39;s browser.
        /// </summary>
        /// <value>The screen width of the shopper&#39;s browser.</value>
        [DataMember(Name = "screenWidth", EmitDefaultValue = false)]
        public int ScreenWidth { get; set; }

        /// <summary>
        /// The timezone offset of the shopper&#39;s browser.
        /// </summary>
        /// <value>The timezone offest of the shopper&#39;s browser.</value>
        [DataMember(Name = "timeZoneOffset", EmitDefaultValue = false)]
        [DefaultValue(0)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        public int TimeZoneOffset { get; set; }

        /// <summary>
        /// The java enabled value of the shopper&#39;s browser.
        /// </summary>
        /// <value>The java enabled value of the shopper&#39;s browser.</value>
        [DataMember(Name = "javaEnabled", EmitDefaultValue = false)]
        public bool JavaEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"class {nameof(BrowserInfo)} {{");
            sb.Append($"  {nameof(AcceptHeader)}: ").AppendLine(AcceptHeader);
            sb.Append($"  {nameof(UserAgent)}: ").AppendLine(UserAgent);
            sb.Append($"  {nameof(Language)}: ").AppendLine(Language);
            sb.Append($"  {nameof(ColorDepth)}: ").AppendLine($"{ColorDepth}");
            sb.Append($"  {nameof(ScreenHeight)}: ").AppendLine($"{ScreenHeight}");
            sb.Append($"  {nameof(ScreenWidth)}: ").AppendLine($"{ScreenWidth}");
            sb.Append($"  {nameof(TimeZoneOffset)}: ").AppendLine($"{TimeZoneOffset}");
            sb.Append($"  {nameof(JavaEnabled)}: ").AppendLine($"{JavaEnabled}");
            sb.AppendLine("}");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as BrowserInfo);
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
                    this.AcceptHeader == other.AcceptHeader ||
                    this.AcceptHeader != null &&
                    this.AcceptHeader.Equals(other.AcceptHeader)
                ) && 
                (
                    this.UserAgent == other.UserAgent ||
                    this.UserAgent != null &&
                    this.UserAgent.Equals(other.UserAgent)
                ) &&
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                )
                &&
                (
                    this.ColorDepth == other.ColorDepth
                )
                &&
                (
                    this.ScreenHeight == other.ScreenHeight
                )
                &&
                (
                    this.ScreenWidth == other.ScreenWidth
                ) &&
                (
                    this.TimeZoneOffset == other.TimeZoneOffset
                ) &&
                (
                    this.JavaEnabled == other.JavaEnabled
                );
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
                int hash = 41;

                hash = IncrementHash(hash, this.AcceptHeader);
                hash = IncrementHash(hash, this.UserAgent);
                hash = IncrementHash(hash, this.Language);
                hash = IncrementHash(hash, this.ColorDepth);
                hash = IncrementHash(hash, this.ScreenHeight);
                hash = IncrementHash(hash, this.ScreenWidth);
                hash = IncrementHash(hash, this.TimeZoneOffset);
                hash = IncrementHash(hash, this.JavaEnabled);

                return hash;
            }
        }

        private static int IncrementHash(int currentHash, object property)
        {
            if (property == null)
                return currentHash;

            return currentHash * 59 + property.GetHashCode();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // AcceptHeader (string) maxLength
            if(this.AcceptHeader != null && this.AcceptHeader.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AcceptHeader, length must be less than 50.", new [] { "AcceptHeader" });
            }

            // AcceptHeader (string) minLength
            if(this.AcceptHeader != null && this.AcceptHeader.Length < 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AcceptHeader, length must be greater than 10.", new [] { "AcceptHeader" });
            }

            // UserAgent (string) maxLength
            if(this.UserAgent != null && this.UserAgent.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UserAgent, length must be less than 50.", new [] { "UserAgent" });
            }

            // UserAgent (string) minLength
            if(this.UserAgent != null && this.UserAgent.Length < 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UserAgent, length must be greater than 10.", new [] { "UserAgent" });
            }

            yield break;
        }
    }

}
