/*
* Management API
*
*
* The version of the OpenAPI document: 1
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

namespace Adyen.Model.Management
{
    /// <summary>
    /// WebhookLinks
    /// </summary>
    [DataContract(Name = "WebhookLinks")]
    public partial class WebhookLinks : IEquatable<WebhookLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLinks" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookLinks() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLinks" /> class.
        /// </summary>
        /// <param name="company">company.</param>
        /// <param name="generateHmac">generateHmac (required).</param>
        /// <param name="merchant">merchant.</param>
        /// <param name="self">self (required).</param>
        /// <param name="testWebhook">testWebhook (required).</param>
        public WebhookLinks(LinksElement company = default(LinksElement), LinksElement generateHmac = default(LinksElement), LinksElement merchant = default(LinksElement), LinksElement self = default(LinksElement), LinksElement testWebhook = default(LinksElement))
        {
            this.GenerateHmac = generateHmac;
            this.Self = self;
            this.TestWebhook = testWebhook;
            this.Company = company;
            this.Merchant = merchant;
        }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name = "company", EmitDefaultValue = false)]
        public LinksElement Company { get; set; }

        /// <summary>
        /// Gets or Sets GenerateHmac
        /// </summary>
        [DataMember(Name = "generateHmac", IsRequired = false, EmitDefaultValue = false)]
        public LinksElement GenerateHmac { get; set; }

        /// <summary>
        /// Gets or Sets Merchant
        /// </summary>
        [DataMember(Name = "merchant", EmitDefaultValue = false)]
        public LinksElement Merchant { get; set; }

        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name = "self", IsRequired = false, EmitDefaultValue = false)]
        public LinksElement Self { get; set; }

        /// <summary>
        /// Gets or Sets TestWebhook
        /// </summary>
        [DataMember(Name = "testWebhook", IsRequired = false, EmitDefaultValue = false)]
        public LinksElement TestWebhook { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhookLinks {\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  GenerateHmac: ").Append(GenerateHmac).Append("\n");
            sb.Append("  Merchant: ").Append(Merchant).Append("\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  TestWebhook: ").Append(TestWebhook).Append("\n");
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
            return this.Equals(input as WebhookLinks);
        }

        /// <summary>
        /// Returns true if WebhookLinks instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookLinks input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.GenerateHmac == input.GenerateHmac ||
                    (this.GenerateHmac != null &&
                    this.GenerateHmac.Equals(input.GenerateHmac))
                ) && 
                (
                    this.Merchant == input.Merchant ||
                    (this.Merchant != null &&
                    this.Merchant.Equals(input.Merchant))
                ) && 
                (
                    this.Self == input.Self ||
                    (this.Self != null &&
                    this.Self.Equals(input.Self))
                ) && 
                (
                    this.TestWebhook == input.TestWebhook ||
                    (this.TestWebhook != null &&
                    this.TestWebhook.Equals(input.TestWebhook))
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
                if (this.Company != null)
                {
                    hashCode = (hashCode * 59) + this.Company.GetHashCode();
                }
                if (this.GenerateHmac != null)
                {
                    hashCode = (hashCode * 59) + this.GenerateHmac.GetHashCode();
                }
                if (this.Merchant != null)
                {
                    hashCode = (hashCode * 59) + this.Merchant.GetHashCode();
                }
                if (this.Self != null)
                {
                    hashCode = (hashCode * 59) + this.Self.GetHashCode();
                }
                if (this.TestWebhook != null)
                {
                    hashCode = (hashCode * 59) + this.TestWebhook.GetHashCode();
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
