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
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Adyen.Util;

namespace Adyen.Model
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
                // Suitable nullity checks etc, of course :)

                if (this.AcceptHeader != null)
                    hash = hash * 59 + this.AcceptHeader.GetHashCode();
                if (this.UserAgent != null)
                    hash = hash * 59 + this.UserAgent.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                hash = hash * 59 + this.ColorDepth.GetHashCode();
                hash = hash * 59 + this.ScreenHeight.GetHashCode();
                hash = hash * 59 + this.ScreenWidth.GetHashCode();
                hash = hash * 59 + this.TimeZoneOffset.GetHashCode();
                hash = hash * 59 + this.JavaEnabled.GetHashCode();

                return hash;
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
            if (this.AcceptHeader != null && this.AcceptHeader.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AcceptHeader, length must be less than 50.", new[] { "AcceptHeader" });
            }

            // AcceptHeader (string) minLength
            if (this.AcceptHeader != null && this.AcceptHeader.Length < 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AcceptHeader, length must be greater than 10.", new[] { "AcceptHeader" });
            }

            // UserAgent (string) maxLength
            if (this.UserAgent != null && this.UserAgent.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UserAgent, length must be less than 50.", new[] { "UserAgent" });
            }

            // UserAgent (string) minLength
            if (this.UserAgent != null && this.UserAgent.Length < 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UserAgent, length must be greater than 10.", new[] { "UserAgent" });
            }
        }
    }
}