/*
* Legal Entity Management API
*
*
* The version of the OpenAPI document: 2
* Contact: developer-experience@adyen.com
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

namespace Adyen.Model.LegalEntityManagement
{
    /// <summary>
    /// Attachment
    /// </summary>
    [DataContract(Name = "Attachment")]
    public partial class Attachment : IEquatable<Attachment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attachment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Attachment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Attachment" /> class.
        /// </summary>
        /// <param name="content">The document in Base64-encoded string format. (required).</param>
        /// <param name="contentType">The file format.   Possible values: **application/pdf**, **image/jpg**, **image/jpeg**, **image/png**. .</param>
        /// <param name="filename">The name of the file including the file extension..</param>
        /// <param name="pageName">The name of the file including the file extension..</param>
        /// <param name="pageType">Specifies which side of the ID card is uploaded.  * When &#x60;type&#x60; is **driversLicense** or **identityCard**, set this to **front** or **back**.  * When omitted, we infer the page number based on the order of attachments..</param>
        public Attachment(byte[] content = default(byte[]), string contentType = default(string), string filename = default(string), string pageName = default(string), string pageType = default(string))
        {
            this.Content = content;
            this.ContentType = contentType;
            this.Filename = filename;
            this.PageName = pageName;
            this.PageType = pageType;
        }

        /// <summary>
        /// The document in Base64-encoded string format.
        /// </summary>
        /// <value>The document in Base64-encoded string format.</value>
        [DataMember(Name = "content", IsRequired = false, EmitDefaultValue = false)]
        public byte[] Content { get; set; }

        /// <summary>
        /// The file format.   Possible values: **application/pdf**, **image/jpg**, **image/jpeg**, **image/png**. 
        /// </summary>
        /// <value>The file format.   Possible values: **application/pdf**, **image/jpg**, **image/jpeg**, **image/png**. </value>
        [DataMember(Name = "contentType", EmitDefaultValue = false)]
        [Obsolete]
        public string ContentType { get; set; }

        /// <summary>
        /// The name of the file including the file extension.
        /// </summary>
        /// <value>The name of the file including the file extension.</value>
        [DataMember(Name = "filename", EmitDefaultValue = false)]
        [Obsolete]
        public string Filename { get; set; }

        /// <summary>
        /// The name of the file including the file extension.
        /// </summary>
        /// <value>The name of the file including the file extension.</value>
        [DataMember(Name = "pageName", EmitDefaultValue = false)]
        public string PageName { get; set; }

        /// <summary>
        /// Specifies which side of the ID card is uploaded.  * When &#x60;type&#x60; is **driversLicense** or **identityCard**, set this to **front** or **back**.  * When omitted, we infer the page number based on the order of attachments.
        /// </summary>
        /// <value>Specifies which side of the ID card is uploaded.  * When &#x60;type&#x60; is **driversLicense** or **identityCard**, set this to **front** or **back**.  * When omitted, we infer the page number based on the order of attachments.</value>
        [DataMember(Name = "pageType", EmitDefaultValue = false)]
        public string PageType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Attachment {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  PageName: ").Append(PageName).Append("\n");
            sb.Append("  PageType: ").Append(PageType).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Attachment);
        }

        /// <summary>
        /// Returns true if Attachment instances are equal
        /// </summary>
        /// <param name="input">Instance of Attachment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Attachment input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.Filename == input.Filename ||
                    (this.Filename != null &&
                    this.Filename.Equals(input.Filename))
                ) && 
                (
                    this.PageName == input.PageName ||
                    (this.PageName != null &&
                    this.PageName.Equals(input.PageName))
                ) && 
                (
                    this.PageType == input.PageType ||
                    (this.PageType != null &&
                    this.PageType.Equals(input.PageType))
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
                if (this.Content != null)
                {
                    hashCode = (hashCode * 59) + this.Content.GetHashCode();
                }
                if (this.ContentType != null)
                {
                    hashCode = (hashCode * 59) + this.ContentType.GetHashCode();
                }
                if (this.Filename != null)
                {
                    hashCode = (hashCode * 59) + this.Filename.GetHashCode();
                }
                if (this.PageName != null)
                {
                    hashCode = (hashCode * 59) + this.PageName.GetHashCode();
                }
                if (this.PageType != null)
                {
                    hashCode = (hashCode * 59) + this.PageType.GetHashCode();
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
