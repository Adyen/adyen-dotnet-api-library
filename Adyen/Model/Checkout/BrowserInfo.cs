#region Licence

// 
//                        ######
//                        ######
//  ############    ####( ######  #####. ######  ############   ############
//  #############  #####( ######  #####. ######  #############  #############
//         ######  #####( ######  #####. ######  #####  ######  #####  ######
//  ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  ###### ######  #####( ######  #####. ######  #####          #####  ######
//  #############  #############  #############  #############  #####  ######
//   ############   ############  #############   ############  #####  ######
//                                       ######
//                                #############
//                                ############
// 
//  Adyen Dotnet API Library
// 
//  Copyright (c) 2020 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.

#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
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
        /// <param name="acceptHeader">The accept header value of the shopper&#x27;s browser. (required).</param>
        /// <param name="colorDepth">The color depth of the shopper&#x27;s browser in bits per pixel. This should be obtained by using the browser&#x27;s &#x60;screen.colorDepth&#x60; property. Accepted values: 1, 4, 8, 15, 16, 24, 30, 32 or 48 bit color depth. (required).</param>
        /// <param name="javaEnabled">Boolean value indicating if the shopper&#x27;s browser is able to execute Java. (required).</param>
        /// <param name="javaScriptEnabled">Boolean value indicating if the shopper&#x27;s browser is able to execute JavaScript. A default &#x27;true&#x27; value is assumed if the field is not present. (default to true).</param>
        /// <param name="language">The &#x60;navigator.language&#x60; value of the shopper&#x27;s browser (as defined in IETF BCP 47). (required).</param>
        /// <param name="screenHeight">The total height of the shopper&#x27;s device screen in pixels. (required).</param>
        /// <param name="screenWidth">The total width of the shopper&#x27;s device screen in pixels. (required).</param>
        /// <param name="timeZoneOffset">Time difference between UTC time and the shopper&#x27;s browser local time, in minutes. (required).</param>
        /// <param name="userAgent">The user agent value of the shopper&#x27;s browser. (required).</param>
        public BrowserInfo(string acceptHeader = default(string), int? colorDepth = default(int?),
            bool? javaEnabled = default(bool?), bool? javaScriptEnabled = true, string language = default(string),
            int? screenHeight = default(int?), int? screenWidth = default(int?), int? timeZoneOffset = default(int?),
            string userAgent = default(string))
        {
            // to ensure "acceptHeader" is required (not null)
            if (acceptHeader == null)
            {
                throw new InvalidDataException(
                    "acceptHeader is a required property for BrowserInfo and cannot be null");
            }
            else
            {
                this.AcceptHeader = acceptHeader;
            }
            // to ensure "colorDepth" is required (not null)
            if (colorDepth == null)
            {
                throw new InvalidDataException("colorDepth is a required property for BrowserInfo and cannot be null");
            }
            else
            {
                this.ColorDepth = colorDepth;
            }
            // to ensure "javaEnabled" is required (not null)
            if (javaEnabled == null)
            {
                throw new InvalidDataException("javaEnabled is a required property for BrowserInfo and cannot be null");
            }
            else
            {
                this.JavaEnabled = javaEnabled;
            }
            // to ensure "language" is required (not null)
            if (language == null)
            {
                throw new InvalidDataException("language is a required property for BrowserInfo and cannot be null");
            }
            else
            {
                this.Language = language;
            }
            // to ensure "screenHeight" is required (not null)
            if (screenHeight == null)
            {
                throw new InvalidDataException(
                    "screenHeight is a required property for BrowserInfo and cannot be null");
            }
            else
            {
                this.ScreenHeight = screenHeight;
            }
            // to ensure "screenWidth" is required (not null)
            if (screenWidth == null)
            {
                throw new InvalidDataException("screenWidth is a required property for BrowserInfo and cannot be null");
            }
            else
            {
                this.ScreenWidth = screenWidth;
            }
            // to ensure "timeZoneOffset" is required (not null)
            if (timeZoneOffset == null)
            {
                throw new InvalidDataException(
                    "timeZoneOffset is a required property for BrowserInfo and cannot be null");
            }
            else
            {
                this.TimeZoneOffset = timeZoneOffset;
            }
            // to ensure "userAgent" is required (not null)
            if (userAgent == null)
            {
                throw new InvalidDataException("userAgent is a required property for BrowserInfo and cannot be null");
            }
            else
            {
                this.UserAgent = userAgent;
            }
            // use default value if no "javaScriptEnabled" provided
            if (javaScriptEnabled == null)
            {
                this.JavaScriptEnabled = true;
            }
            else
            {
                this.JavaScriptEnabled = javaScriptEnabled;
            }
        }

        /// <summary>
        /// The accept header value of the shopper&#x27;s browser.
        /// </summary>
        /// <value>The accept header value of the shopper&#x27;s browser.</value>
        [DataMember(Name = "acceptHeader", EmitDefaultValue = false)]
        public string AcceptHeader { get; set; }

        /// <summary>
        /// The color depth of the shopper&#x27;s browser in bits per pixel. This should be obtained by using the browser&#x27;s &#x60;screen.colorDepth&#x60; property. Accepted values: 1, 4, 8, 15, 16, 24, 30, 32 or 48 bit color depth.
        /// </summary>
        /// <value>The color depth of the shopper&#x27;s browser in bits per pixel. This should be obtained by using the browser&#x27;s &#x60;screen.colorDepth&#x60; property. Accepted values: 1, 4, 8, 15, 16, 24, 30, 32 or 48 bit color depth.</value>
        [DataMember(Name = "colorDepth", EmitDefaultValue = false)]
        public int? ColorDepth { get; set; }

        /// <summary>
        /// Boolean value indicating if the shopper&#x27;s browser is able to execute Java.
        /// </summary>
        /// <value>Boolean value indicating if the shopper&#x27;s browser is able to execute Java.</value>
        [DataMember(Name = "javaEnabled", EmitDefaultValue = false)]
        public bool? JavaEnabled { get; set; }

        /// <summary>
        /// Boolean value indicating if the shopper&#x27;s browser is able to execute JavaScript. A default &#x27;true&#x27; value is assumed if the field is not present.
        /// </summary>
        /// <value>Boolean value indicating if the shopper&#x27;s browser is able to execute JavaScript. A default &#x27;true&#x27; value is assumed if the field is not present.</value>
        [DataMember(Name = "javaScriptEnabled", EmitDefaultValue = false)]
        public bool? JavaScriptEnabled { get; set; }

        /// <summary>
        /// The &#x60;navigator.language&#x60; value of the shopper&#x27;s browser (as defined in IETF BCP 47).
        /// </summary>
        /// <value>The &#x60;navigator.language&#x60; value of the shopper&#x27;s browser (as defined in IETF BCP 47).</value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public string Language { get; set; }

        /// <summary>
        /// The total height of the shopper&#x27;s device screen in pixels.
        /// </summary>
        /// <value>The total height of the shopper&#x27;s device screen in pixels.</value>
        [DataMember(Name = "screenHeight", EmitDefaultValue = false)]
        public int? ScreenHeight { get; set; }

        /// <summary>
        /// The total width of the shopper&#x27;s device screen in pixels.
        /// </summary>
        /// <value>The total width of the shopper&#x27;s device screen in pixels.</value>
        [DataMember(Name = "screenWidth", EmitDefaultValue = false)]
        public int? ScreenWidth { get; set; }

        /// <summary>
        /// Time difference between UTC time and the shopper&#x27;s browser local time, in minutes.
        /// </summary>
        /// <value>Time difference between UTC time and the shopper&#x27;s browser local time, in minutes.</value>
        [DataMember(Name = "timeZoneOffset", EmitDefaultValue = false)]
        public int? TimeZoneOffset { get; set; }

        /// <summary>
        /// The user agent value of the shopper&#x27;s browser.
        /// </summary>
        /// <value>The user agent value of the shopper&#x27;s browser.</value>
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
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
                return false;

            return
                (
                    this.AcceptHeader == input.AcceptHeader ||
                    this.AcceptHeader != null &&
                    this.AcceptHeader.Equals(input.AcceptHeader)
                ) &&
                (
                    this.ColorDepth == input.ColorDepth ||
                    this.ColorDepth != null &&
                    this.ColorDepth.Equals(input.ColorDepth)
                ) &&
                (
                    this.JavaEnabled == input.JavaEnabled ||
                    this.JavaEnabled != null &&
                    this.JavaEnabled.Equals(input.JavaEnabled)
                ) &&
                (
                    this.JavaScriptEnabled == input.JavaScriptEnabled ||
                    this.JavaScriptEnabled != null &&
                    this.JavaScriptEnabled.Equals(input.JavaScriptEnabled)
                ) &&
                (
                    this.Language == input.Language ||
                    this.Language != null &&
                    this.Language.Equals(input.Language)
                ) &&
                (
                    this.ScreenHeight == input.ScreenHeight ||
                    this.ScreenHeight != null &&
                    this.ScreenHeight.Equals(input.ScreenHeight)
                ) &&
                (
                    this.ScreenWidth == input.ScreenWidth ||
                    this.ScreenWidth != null &&
                    this.ScreenWidth.Equals(input.ScreenWidth)
                ) &&
                (
                    this.TimeZoneOffset == input.TimeZoneOffset ||
                    this.TimeZoneOffset != null &&
                    this.TimeZoneOffset.Equals(input.TimeZoneOffset)
                ) &&
                (
                    this.UserAgent == input.UserAgent ||
                    this.UserAgent != null &&
                    this.UserAgent.Equals(input.UserAgent)
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
                    hashCode = hashCode * 59 + this.AcceptHeader.GetHashCode();
                if (this.ColorDepth != null)
                    hashCode = hashCode * 59 + this.ColorDepth.GetHashCode();
                if (this.JavaEnabled != null)
                    hashCode = hashCode * 59 + this.JavaEnabled.GetHashCode();
                if (this.JavaScriptEnabled != null)
                    hashCode = hashCode * 59 + this.JavaScriptEnabled.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.ScreenHeight != null)
                    hashCode = hashCode * 59 + this.ScreenHeight.GetHashCode();
                if (this.ScreenWidth != null)
                    hashCode = hashCode * 59 + this.ScreenWidth.GetHashCode();
                if (this.TimeZoneOffset != null)
                    hashCode = hashCode * 59 + this.TimeZoneOffset.GetHashCode();
                if (this.UserAgent != null)
                    hashCode = hashCode * 59 + this.UserAgent.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(
            ValidationContext validationContext)
        {
            yield break;
        }
    }
}