#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2019 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
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
    public partial class BrowserInfo :  IEquatable<BrowserInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserInfo" /> class.
        /// </summary>
        [JsonConstructor]
        protected BrowserInfo() { }
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
        /// <param name="JavaScriptEnabled">Boolean value indicating if the shopper's browser is able to execute JavaScript..</param>

        public BrowserInfo(string AcceptHeader = default(string), int? ColorDepth = default(int?), bool? JavaEnabled = default(bool?), string Language = default(string), int? ScreenHeight = default(int?), int? ScreenWidth = default(int?), int? TimeZoneOffset = default(int?), string UserAgent = default(string), bool? JavaScriptEnabled = default(bool?))
        {
            // to ensure "AcceptHeader" is required (not null)
            if (AcceptHeader == null)
            {
                throw new InvalidDataException("AcceptHeader is a required property for BrowserInfo and cannot be null");
            }
            else
            {
                this.AcceptHeader = AcceptHeader;
            }
            // to ensure "UserAgent" is required (not null)
            if (UserAgent == null)
            {
                throw new InvalidDataException("UserAgent is a required property for BrowserInfo and cannot be null");
            }
            else
            {
                this.UserAgent = UserAgent;
            }
            this.ColorDepth = ColorDepth;
            this.JavaEnabled = JavaEnabled;
            this.Language = Language;
            this.ScreenHeight = ScreenHeight;
            this.ScreenWidth = ScreenWidth;
            this.TimeZoneOffset = TimeZoneOffset;
            this.JavaScriptEnabled = JavaScriptEnabled;
        }
        
        /// <summary>
        /// The accept header value of the shopper&#39;s browser.
        /// </summary>
        /// <value>The accept header value of the shopper&#39;s browser.</value>
        [DataMember(Name="acceptHeader", EmitDefaultValue=false)]
        public string AcceptHeader { get; set; }

        /// <summary>
        /// The color depth of the shopper&#39;s device in bits per pixel. Should be obtained by using the browser&#39;s screen.colorDepth property.
        /// </summary>
        /// <value>The color depth of the shopper&#39;s device in bits per pixel. Should be obtained by using the browser&#39;s screen.colorDepth property.</value>
        [DataMember(Name="colorDepth", EmitDefaultValue=false)]
        public int? ColorDepth { get; set; }

        /// <summary>
        /// Boolean value indicating if the shopper&#39;s browser is able to execute Java.
        /// </summary>
        /// <value>Boolean value indicating if the shopper&#39;s browser is able to execute Java.</value>
        [DataMember(Name="javaEnabled", EmitDefaultValue=false)]
        public bool? JavaEnabled { get; set; }

        /// <summary>
        /// The navigator.language value of the shopper&#39;s browser (as defined in IETF BCP 47).
        /// </summary>
        /// <value>The navigator.language value of the shopper&#39;s browser (as defined in IETF BCP 47).</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// The total height of the shopper&#39;s device screen in pixels.
        /// </summary>
        /// <value>The total height of the shopper&#39;s device screen in pixels.</value>
        [DataMember(Name="screenHeight", EmitDefaultValue=false)]
        public int? ScreenHeight { get; set; }

        /// <summary>
        /// The total width of the shopper&#39;s device screen in pixels.
        /// </summary>
        /// <value>The total width of the shopper&#39;s device screen in pixels.</value>
        [DataMember(Name="screenWidth", EmitDefaultValue=false)]
        public int? ScreenWidth { get; set; }

        /// <summary>
        /// Time difference between UTC time and the shopper&#39;s browser local time, in minutes.
        /// </summary>
        /// <value>Time difference between UTC time and the shopper&#39;s browser local time, in minutes.</value>
        [DataMember(Name="timeZoneOffset", EmitDefaultValue=false)]
        public int? TimeZoneOffset { get; set; }

        /// <summary>
        /// The user agent value of the shopper&#39;s browser.
        /// </summary>
        /// <value>The user agent value of the shopper&#39;s browser.</value>
        [DataMember(Name="userAgent", EmitDefaultValue=false)]
        public string UserAgent { get; set; }
        /// <summary>
        /// Boolean value indicating if the shopper&#39;s browser is able to execute Java.
        /// </summary>
        /// <value>Boolean value indicating if the shopper&#39;s browser is able to execute Java.</value>
        [DataMember(Name = "javaScriptEnabled", EmitDefaultValue = false)]
        public bool? JavaScriptEnabled { get; set; }
        
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
            sb.Append("  JavaScriptEnabled: ").Append(JavaEnabled).Append("\n");
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
                    (this.AcceptHeader != null &&
                    this.AcceptHeader.Equals(input.AcceptHeader))
                ) && 
                (
                    this.ColorDepth == input.ColorDepth ||
                    (this.ColorDepth != null &&
                    this.ColorDepth.Equals(input.ColorDepth))
                ) && 
                (
                    this.JavaEnabled == input.JavaEnabled ||
                    (this.JavaEnabled != null &&
                    this.JavaEnabled.Equals(input.JavaEnabled))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.ScreenHeight == input.ScreenHeight ||
                    (this.ScreenHeight != null &&
                    this.ScreenHeight.Equals(input.ScreenHeight))
                ) && 
                (
                    this.ScreenWidth == input.ScreenWidth ||
                    (this.ScreenWidth != null &&
                    this.ScreenWidth.Equals(input.ScreenWidth))
                ) && 
                (
                    this.TimeZoneOffset == input.TimeZoneOffset ||
                    (this.TimeZoneOffset != null &&
                    this.TimeZoneOffset.Equals(input.TimeZoneOffset))
                ) && 
                (
                    this.UserAgent == input.UserAgent ||
                    (this.UserAgent != null &&
                    this.UserAgent.Equals(input.UserAgent))
                )&&
                 (
                    this.JavaScriptEnabled == input.JavaScriptEnabled ||
                    (this.JavaScriptEnabled != null &&
                    this.JavaScriptEnabled.Equals(input.JavaScriptEnabled))
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
                if (this.JavaScriptEnabled != null)
                    hashCode = hashCode * 59 + this.JavaScriptEnabled.GetHashCode();
                return hashCode;
            }
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
