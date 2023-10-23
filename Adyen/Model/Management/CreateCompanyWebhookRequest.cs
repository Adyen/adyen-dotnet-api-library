/*
* Management API
*
*
* The version of the OpenAPI document: 3
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
    /// CreateCompanyWebhookRequest
    /// </summary>
    [DataContract(Name = "CreateCompanyWebhookRequest")]
    public partial class CreateCompanyWebhookRequest : IEquatable<CreateCompanyWebhookRequest>, IValidatableObject
    {
        /// <summary>
        /// Format or protocol for receiving webhooks. Possible values: * **soap** * **http** * **json** 
        /// </summary>
        /// <value>Format or protocol for receiving webhooks. Possible values: * **soap** * **http** * **json** </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CommunicationFormatEnum
        {
            /// <summary>
            /// Enum Http for value: http
            /// </summary>
            [EnumMember(Value = "http")]
            Http = 1,

            /// <summary>
            /// Enum Json for value: json
            /// </summary>
            [EnumMember(Value = "json")]
            Json = 2,

            /// <summary>
            /// Enum Soap for value: soap
            /// </summary>
            [EnumMember(Value = "soap")]
            Soap = 3

        }


        /// <summary>
        /// Format or protocol for receiving webhooks. Possible values: * **soap** * **http** * **json** 
        /// </summary>
        /// <value>Format or protocol for receiving webhooks. Possible values: * **soap** * **http** * **json** </value>
        [DataMember(Name = "communicationFormat", IsRequired = false, EmitDefaultValue = false)]
        public CommunicationFormatEnum CommunicationFormat { get; set; }
        /// <summary>
        /// SSL version to access the public webhook URL specified in the &#x60;url&#x60; field. Possible values: * **TLSv1.3** * **TLSv1.2** * **HTTP** - Only allowed on Test environment.  If not specified, the webhook will use &#x60;sslVersion&#x60;: **TLSv1.2**.
        /// </summary>
        /// <value>SSL version to access the public webhook URL specified in the &#x60;url&#x60; field. Possible values: * **TLSv1.3** * **TLSv1.2** * **HTTP** - Only allowed on Test environment.  If not specified, the webhook will use &#x60;sslVersion&#x60;: **TLSv1.2**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EncryptionProtocolEnum
        {
            /// <summary>
            /// Enum HTTP for value: HTTP
            /// </summary>
            [EnumMember(Value = "HTTP")]
            HTTP = 1,

            /// <summary>
            /// Enum TLSv12 for value: TLSv1.2
            /// </summary>
            [EnumMember(Value = "TLSv1.2")]
            TLSv12 = 2,

            /// <summary>
            /// Enum TLSv13 for value: TLSv1.3
            /// </summary>
            [EnumMember(Value = "TLSv1.3")]
            TLSv13 = 3

        }


        /// <summary>
        /// SSL version to access the public webhook URL specified in the &#x60;url&#x60; field. Possible values: * **TLSv1.3** * **TLSv1.2** * **HTTP** - Only allowed on Test environment.  If not specified, the webhook will use &#x60;sslVersion&#x60;: **TLSv1.2**.
        /// </summary>
        /// <value>SSL version to access the public webhook URL specified in the &#x60;url&#x60; field. Possible values: * **TLSv1.3** * **TLSv1.2** * **HTTP** - Only allowed on Test environment.  If not specified, the webhook will use &#x60;sslVersion&#x60;: **TLSv1.2**.</value>
        [DataMember(Name = "encryptionProtocol", EmitDefaultValue = false)]
        public EncryptionProtocolEnum? EncryptionProtocol { get; set; }
        /// <summary>
        /// Shows how merchant accounts are filtered when configuring the webhook.   Possible values: *  **allAccounts** : Includes all merchant accounts, and does not require specifying &#x60;filterMerchantAccounts&#x60;. *  **includeAccounts** : The webhook is configured for the merchant accounts listed in &#x60;filterMerchantAccounts&#x60;. *  **excludeAccounts** : The webhook is not configured for the merchant accounts listed in &#x60;filterMerchantAccounts&#x60;.  
        /// </summary>
        /// <value>Shows how merchant accounts are filtered when configuring the webhook.   Possible values: *  **allAccounts** : Includes all merchant accounts, and does not require specifying &#x60;filterMerchantAccounts&#x60;. *  **includeAccounts** : The webhook is configured for the merchant accounts listed in &#x60;filterMerchantAccounts&#x60;. *  **excludeAccounts** : The webhook is not configured for the merchant accounts listed in &#x60;filterMerchantAccounts&#x60;.  </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FilterMerchantAccountTypeEnum
        {
            /// <summary>
            /// Enum AllAccounts for value: allAccounts
            /// </summary>
            [EnumMember(Value = "allAccounts")]
            AllAccounts = 1,

            /// <summary>
            /// Enum ExcludeAccounts for value: excludeAccounts
            /// </summary>
            [EnumMember(Value = "excludeAccounts")]
            ExcludeAccounts = 2,

            /// <summary>
            /// Enum IncludeAccounts for value: includeAccounts
            /// </summary>
            [EnumMember(Value = "includeAccounts")]
            IncludeAccounts = 3

        }


        /// <summary>
        /// Shows how merchant accounts are filtered when configuring the webhook.   Possible values: *  **allAccounts** : Includes all merchant accounts, and does not require specifying &#x60;filterMerchantAccounts&#x60;. *  **includeAccounts** : The webhook is configured for the merchant accounts listed in &#x60;filterMerchantAccounts&#x60;. *  **excludeAccounts** : The webhook is not configured for the merchant accounts listed in &#x60;filterMerchantAccounts&#x60;.  
        /// </summary>
        /// <value>Shows how merchant accounts are filtered when configuring the webhook.   Possible values: *  **allAccounts** : Includes all merchant accounts, and does not require specifying &#x60;filterMerchantAccounts&#x60;. *  **includeAccounts** : The webhook is configured for the merchant accounts listed in &#x60;filterMerchantAccounts&#x60;. *  **excludeAccounts** : The webhook is not configured for the merchant accounts listed in &#x60;filterMerchantAccounts&#x60;.  </value>
        [DataMember(Name = "filterMerchantAccountType", IsRequired = false, EmitDefaultValue = false)]
        public FilterMerchantAccountTypeEnum FilterMerchantAccountType { get; set; }
        /// <summary>
        /// Network type for Terminal API notification webhooks. Possible values: * **public** * **local**  Default Value: **public**.
        /// </summary>
        /// <value>Network type for Terminal API notification webhooks. Possible values: * **public** * **local**  Default Value: **public**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NetworkTypeEnum
        {
            /// <summary>
            /// Enum Local for value: local
            /// </summary>
            [EnumMember(Value = "local")]
            Local = 1,

            /// <summary>
            /// Enum Public for value: public
            /// </summary>
            [EnumMember(Value = "public")]
            Public = 2

        }


        /// <summary>
        /// Network type for Terminal API notification webhooks. Possible values: * **public** * **local**  Default Value: **public**.
        /// </summary>
        /// <value>Network type for Terminal API notification webhooks. Possible values: * **public** * **local**  Default Value: **public**.</value>
        [DataMember(Name = "networkType", EmitDefaultValue = false)]
        public NetworkTypeEnum? NetworkType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCompanyWebhookRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCompanyWebhookRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCompanyWebhookRequest" /> class.
        /// </summary>
        /// <param name="acceptsExpiredCertificate">Indicates if expired SSL certificates are accepted. Default value: **false**..</param>
        /// <param name="acceptsSelfSignedCertificate">Indicates if self-signed SSL certificates are accepted. Default value: **false**..</param>
        /// <param name="acceptsUntrustedRootCertificate">Indicates if untrusted SSL certificates are accepted. Default value: **false**..</param>
        /// <param name="active">Indicates if the webhook configuration is active. The field must be **true** for us to send webhooks about events related an account. (required).</param>
        /// <param name="additionalSettings">additionalSettings.</param>
        /// <param name="communicationFormat">Format or protocol for receiving webhooks. Possible values: * **soap** * **http** * **json**  (required).</param>
        /// <param name="description">Your description for this webhook configuration..</param>
        /// <param name="encryptionProtocol">SSL version to access the public webhook URL specified in the &#x60;url&#x60; field. Possible values: * **TLSv1.3** * **TLSv1.2** * **HTTP** - Only allowed on Test environment.  If not specified, the webhook will use &#x60;sslVersion&#x60;: **TLSv1.2**..</param>
        /// <param name="filterMerchantAccountType">Shows how merchant accounts are filtered when configuring the webhook.   Possible values: *  **allAccounts** : Includes all merchant accounts, and does not require specifying &#x60;filterMerchantAccounts&#x60;. *  **includeAccounts** : The webhook is configured for the merchant accounts listed in &#x60;filterMerchantAccounts&#x60;. *  **excludeAccounts** : The webhook is not configured for the merchant accounts listed in &#x60;filterMerchantAccounts&#x60;.   (required).</param>
        /// <param name="filterMerchantAccounts">A list of merchant account names that are included or excluded from receiving the webhook. Inclusion or exclusion is based on the value defined for &#x60;filterMerchantAccountType&#x60;.  Required if &#x60;filterMerchantAccountType&#x60; is either: * **includeAccounts** * **excludeAccounts**  Not needed for &#x60;filterMerchantAccountType&#x60;: **allAccounts**. (required).</param>
        /// <param name="networkType">Network type for Terminal API notification webhooks. Possible values: * **public** * **local**  Default Value: **public**..</param>
        /// <param name="password">Password to access the webhook URL..</param>
        /// <param name="populateSoapActionHeader">Indicates if the SOAP action header needs to be populated. Default value: **false**.  Only applies if &#x60;communicationFormat&#x60;: **soap**..</param>
        /// <param name="type">The type of webhook that is being created. Possible values are:  - **standard** - **account-settings-notification** - **banktransfer-notification** - **boletobancario-notification** - **directdebit-notification** - **ach-notification-of-change-notification** - **pending-notification** - **ideal-notification** - **ideal-pending-notification** - **report-notification** - **rreq-notification**  Find out more about [standard notification webhooks](https://docs.adyen.com/development-resources/webhooks/understand-notifications#event-codes) and [other types of notifications](https://docs.adyen.com/development-resources/webhooks/understand-notifications#other-notifications). (required).</param>
        /// <param name="url">Public URL where webhooks will be sent, for example **https://www.domain.com/webhook-endpoint**. (required).</param>
        /// <param name="username">Username to access the webhook URL..</param>
        public CreateCompanyWebhookRequest(bool? acceptsExpiredCertificate = default(bool?), bool? acceptsSelfSignedCertificate = default(bool?), bool? acceptsUntrustedRootCertificate = default(bool?), bool? active = default(bool?), AdditionalSettings additionalSettings = default(AdditionalSettings), CommunicationFormatEnum communicationFormat = default(CommunicationFormatEnum), string description = default(string), EncryptionProtocolEnum? encryptionProtocol = default(EncryptionProtocolEnum?), FilterMerchantAccountTypeEnum filterMerchantAccountType = default(FilterMerchantAccountTypeEnum), List<string> filterMerchantAccounts = default(List<string>), NetworkTypeEnum? networkType = default(NetworkTypeEnum?), string password = default(string), bool? populateSoapActionHeader = default(bool?), string type = default(string), string url = default(string), string username = default(string))
        {
            this.Active = active;
            this.CommunicationFormat = communicationFormat;
            this.FilterMerchantAccountType = filterMerchantAccountType;
            this.FilterMerchantAccounts = filterMerchantAccounts;
            this.Type = type;
            this.Url = url;
            this.AcceptsExpiredCertificate = acceptsExpiredCertificate;
            this.AcceptsSelfSignedCertificate = acceptsSelfSignedCertificate;
            this.AcceptsUntrustedRootCertificate = acceptsUntrustedRootCertificate;
            this.AdditionalSettings = additionalSettings;
            this.Description = description;
            this.EncryptionProtocol = encryptionProtocol;
            this.NetworkType = networkType;
            this.Password = password;
            this.PopulateSoapActionHeader = populateSoapActionHeader;
            this.Username = username;
        }

        /// <summary>
        /// Indicates if expired SSL certificates are accepted. Default value: **false**.
        /// </summary>
        /// <value>Indicates if expired SSL certificates are accepted. Default value: **false**.</value>
        [DataMember(Name = "acceptsExpiredCertificate", EmitDefaultValue = false)]
        public bool? AcceptsExpiredCertificate { get; set; }

        /// <summary>
        /// Indicates if self-signed SSL certificates are accepted. Default value: **false**.
        /// </summary>
        /// <value>Indicates if self-signed SSL certificates are accepted. Default value: **false**.</value>
        [DataMember(Name = "acceptsSelfSignedCertificate", EmitDefaultValue = false)]
        public bool? AcceptsSelfSignedCertificate { get; set; }

        /// <summary>
        /// Indicates if untrusted SSL certificates are accepted. Default value: **false**.
        /// </summary>
        /// <value>Indicates if untrusted SSL certificates are accepted. Default value: **false**.</value>
        [DataMember(Name = "acceptsUntrustedRootCertificate", EmitDefaultValue = false)]
        public bool? AcceptsUntrustedRootCertificate { get; set; }

        /// <summary>
        /// Indicates if the webhook configuration is active. The field must be **true** for us to send webhooks about events related an account.
        /// </summary>
        /// <value>Indicates if the webhook configuration is active. The field must be **true** for us to send webhooks about events related an account.</value>
        [DataMember(Name = "active", IsRequired = false, EmitDefaultValue = false)]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalSettings
        /// </summary>
        [DataMember(Name = "additionalSettings", EmitDefaultValue = false)]
        public AdditionalSettings AdditionalSettings { get; set; }

        /// <summary>
        /// Your description for this webhook configuration.
        /// </summary>
        /// <value>Your description for this webhook configuration.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// A list of merchant account names that are included or excluded from receiving the webhook. Inclusion or exclusion is based on the value defined for &#x60;filterMerchantAccountType&#x60;.  Required if &#x60;filterMerchantAccountType&#x60; is either: * **includeAccounts** * **excludeAccounts**  Not needed for &#x60;filterMerchantAccountType&#x60;: **allAccounts**.
        /// </summary>
        /// <value>A list of merchant account names that are included or excluded from receiving the webhook. Inclusion or exclusion is based on the value defined for &#x60;filterMerchantAccountType&#x60;.  Required if &#x60;filterMerchantAccountType&#x60; is either: * **includeAccounts** * **excludeAccounts**  Not needed for &#x60;filterMerchantAccountType&#x60;: **allAccounts**.</value>
        [DataMember(Name = "filterMerchantAccounts", IsRequired = false, EmitDefaultValue = false)]
        public List<string> FilterMerchantAccounts { get; set; }

        /// <summary>
        /// Password to access the webhook URL.
        /// </summary>
        /// <value>Password to access the webhook URL.</value>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Indicates if the SOAP action header needs to be populated. Default value: **false**.  Only applies if &#x60;communicationFormat&#x60;: **soap**.
        /// </summary>
        /// <value>Indicates if the SOAP action header needs to be populated. Default value: **false**.  Only applies if &#x60;communicationFormat&#x60;: **soap**.</value>
        [DataMember(Name = "populateSoapActionHeader", EmitDefaultValue = false)]
        public bool? PopulateSoapActionHeader { get; set; }

        /// <summary>
        /// The type of webhook that is being created. Possible values are:  - **standard** - **account-settings-notification** - **banktransfer-notification** - **boletobancario-notification** - **directdebit-notification** - **ach-notification-of-change-notification** - **pending-notification** - **ideal-notification** - **ideal-pending-notification** - **report-notification** - **rreq-notification**  Find out more about [standard notification webhooks](https://docs.adyen.com/development-resources/webhooks/understand-notifications#event-codes) and [other types of notifications](https://docs.adyen.com/development-resources/webhooks/understand-notifications#other-notifications).
        /// </summary>
        /// <value>The type of webhook that is being created. Possible values are:  - **standard** - **account-settings-notification** - **banktransfer-notification** - **boletobancario-notification** - **directdebit-notification** - **ach-notification-of-change-notification** - **pending-notification** - **ideal-notification** - **ideal-pending-notification** - **report-notification** - **rreq-notification**  Find out more about [standard notification webhooks](https://docs.adyen.com/development-resources/webhooks/understand-notifications#event-codes) and [other types of notifications](https://docs.adyen.com/development-resources/webhooks/understand-notifications#other-notifications).</value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Public URL where webhooks will be sent, for example **https://www.domain.com/webhook-endpoint**.
        /// </summary>
        /// <value>Public URL where webhooks will be sent, for example **https://www.domain.com/webhook-endpoint**.</value>
        [DataMember(Name = "url", IsRequired = false, EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Username to access the webhook URL.
        /// </summary>
        /// <value>Username to access the webhook URL.</value>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateCompanyWebhookRequest {\n");
            sb.Append("  AcceptsExpiredCertificate: ").Append(AcceptsExpiredCertificate).Append("\n");
            sb.Append("  AcceptsSelfSignedCertificate: ").Append(AcceptsSelfSignedCertificate).Append("\n");
            sb.Append("  AcceptsUntrustedRootCertificate: ").Append(AcceptsUntrustedRootCertificate).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  AdditionalSettings: ").Append(AdditionalSettings).Append("\n");
            sb.Append("  CommunicationFormat: ").Append(CommunicationFormat).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EncryptionProtocol: ").Append(EncryptionProtocol).Append("\n");
            sb.Append("  FilterMerchantAccountType: ").Append(FilterMerchantAccountType).Append("\n");
            sb.Append("  FilterMerchantAccounts: ").Append(FilterMerchantAccounts).Append("\n");
            sb.Append("  NetworkType: ").Append(NetworkType).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  PopulateSoapActionHeader: ").Append(PopulateSoapActionHeader).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return this.Equals(input as CreateCompanyWebhookRequest);
        }

        /// <summary>
        /// Returns true if CreateCompanyWebhookRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateCompanyWebhookRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCompanyWebhookRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AcceptsExpiredCertificate == input.AcceptsExpiredCertificate ||
                    this.AcceptsExpiredCertificate.Equals(input.AcceptsExpiredCertificate)
                ) && 
                (
                    this.AcceptsSelfSignedCertificate == input.AcceptsSelfSignedCertificate ||
                    this.AcceptsSelfSignedCertificate.Equals(input.AcceptsSelfSignedCertificate)
                ) && 
                (
                    this.AcceptsUntrustedRootCertificate == input.AcceptsUntrustedRootCertificate ||
                    this.AcceptsUntrustedRootCertificate.Equals(input.AcceptsUntrustedRootCertificate)
                ) && 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.AdditionalSettings == input.AdditionalSettings ||
                    (this.AdditionalSettings != null &&
                    this.AdditionalSettings.Equals(input.AdditionalSettings))
                ) && 
                (
                    this.CommunicationFormat == input.CommunicationFormat ||
                    this.CommunicationFormat.Equals(input.CommunicationFormat)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EncryptionProtocol == input.EncryptionProtocol ||
                    this.EncryptionProtocol.Equals(input.EncryptionProtocol)
                ) && 
                (
                    this.FilterMerchantAccountType == input.FilterMerchantAccountType ||
                    this.FilterMerchantAccountType.Equals(input.FilterMerchantAccountType)
                ) && 
                (
                    this.FilterMerchantAccounts == input.FilterMerchantAccounts ||
                    this.FilterMerchantAccounts != null &&
                    input.FilterMerchantAccounts != null &&
                    this.FilterMerchantAccounts.SequenceEqual(input.FilterMerchantAccounts)
                ) && 
                (
                    this.NetworkType == input.NetworkType ||
                    this.NetworkType.Equals(input.NetworkType)
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.PopulateSoapActionHeader == input.PopulateSoapActionHeader ||
                    this.PopulateSoapActionHeader.Equals(input.PopulateSoapActionHeader)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                hashCode = (hashCode * 59) + this.AcceptsExpiredCertificate.GetHashCode();
                hashCode = (hashCode * 59) + this.AcceptsSelfSignedCertificate.GetHashCode();
                hashCode = (hashCode * 59) + this.AcceptsUntrustedRootCertificate.GetHashCode();
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                if (this.AdditionalSettings != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalSettings.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CommunicationFormat.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EncryptionProtocol.GetHashCode();
                hashCode = (hashCode * 59) + this.FilterMerchantAccountType.GetHashCode();
                if (this.FilterMerchantAccounts != null)
                {
                    hashCode = (hashCode * 59) + this.FilterMerchantAccounts.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NetworkType.GetHashCode();
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PopulateSoapActionHeader.GetHashCode();
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.Username != null)
                {
                    hashCode = (hashCode * 59) + this.Username.GetHashCode();
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
            // Username (string) maxLength
            if (this.Username != null && this.Username.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Username, length must be less than 255.", new [] { "Username" });
            }

            yield break;
        }
    }

}
