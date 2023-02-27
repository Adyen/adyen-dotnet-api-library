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
    /// TestCompanyWebhookRequest
    /// </summary>
    [DataContract(Name = "TestCompanyWebhookRequest")]
    public partial class TestCompanyWebhookRequest : IEquatable<TestCompanyWebhookRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestCompanyWebhookRequest" /> class.
        /// </summary>
        /// <param name="merchantIds">List of &#x60;merchantId&#x60; values for which test webhooks will be sent. The list can have a maximum of 20 &#x60;merchantId&#x60; values.  If not specified, we send sample notifications to all the merchant accounts that the webhook is configured for. If this is more than 20 merchant accounts, use this list to specify a subset of the merchant accounts for which to send test notifications..</param>
        /// <param name="notification">notification.</param>
        /// <param name="types">List of event codes for which to send test notifications. Only the webhook types below are supported.   Possible values if webhook &#x60;type&#x60;: **standard**:  * **AUTHORISATION** * **CHARGEBACK_REVERSED** * **ORDER_CLOSED** * **ORDER_OPENED** * **PAIDOUT_REVERSED** * **PAYOUT_THIRDPARTY** * **REFUNDED_REVERSED** * **REFUND_WITH_DATA** * **REPORT_AVAILABLE** * **CUSTOM** - set your custom notification fields in the [&#x60;notification&#x60;](https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/companies/{companyId}/webhooks/{webhookId}/test__reqParam_notification) object.  Possible values if webhook &#x60;type&#x60;: **banktransfer-notification**:  * **PENDING**  Possible values if webhook &#x60;type&#x60;: **report-notification**:  * **REPORT_AVAILABLE**  Possible values if webhook &#x60;type&#x60;: **ideal-notification**:  * **AUTHORISATION**  Possible values if webhook &#x60;type&#x60;: **pending-notification**:  * **PENDING** .</param>
        public TestCompanyWebhookRequest(List<string> merchantIds = default(List<string>), CustomNotification notification = default(CustomNotification), List<string> types = default(List<string>))
        {
            this.MerchantIds = merchantIds;
            this.Notification = notification;
            this.Types = types;
        }

        /// <summary>
        /// List of &#x60;merchantId&#x60; values for which test webhooks will be sent. The list can have a maximum of 20 &#x60;merchantId&#x60; values.  If not specified, we send sample notifications to all the merchant accounts that the webhook is configured for. If this is more than 20 merchant accounts, use this list to specify a subset of the merchant accounts for which to send test notifications.
        /// </summary>
        /// <value>List of &#x60;merchantId&#x60; values for which test webhooks will be sent. The list can have a maximum of 20 &#x60;merchantId&#x60; values.  If not specified, we send sample notifications to all the merchant accounts that the webhook is configured for. If this is more than 20 merchant accounts, use this list to specify a subset of the merchant accounts for which to send test notifications.</value>
        [DataMember(Name = "merchantIds", EmitDefaultValue = false)]
        public List<string> MerchantIds { get; set; }

        /// <summary>
        /// Gets or Sets Notification
        /// </summary>
        [DataMember(Name = "notification", EmitDefaultValue = false)]
        public CustomNotification Notification { get; set; }

        /// <summary>
        /// List of event codes for which to send test notifications. Only the webhook types below are supported.   Possible values if webhook &#x60;type&#x60;: **standard**:  * **AUTHORISATION** * **CHARGEBACK_REVERSED** * **ORDER_CLOSED** * **ORDER_OPENED** * **PAIDOUT_REVERSED** * **PAYOUT_THIRDPARTY** * **REFUNDED_REVERSED** * **REFUND_WITH_DATA** * **REPORT_AVAILABLE** * **CUSTOM** - set your custom notification fields in the [&#x60;notification&#x60;](https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/companies/{companyId}/webhooks/{webhookId}/test__reqParam_notification) object.  Possible values if webhook &#x60;type&#x60;: **banktransfer-notification**:  * **PENDING**  Possible values if webhook &#x60;type&#x60;: **report-notification**:  * **REPORT_AVAILABLE**  Possible values if webhook &#x60;type&#x60;: **ideal-notification**:  * **AUTHORISATION**  Possible values if webhook &#x60;type&#x60;: **pending-notification**:  * **PENDING** 
        /// </summary>
        /// <value>List of event codes for which to send test notifications. Only the webhook types below are supported.   Possible values if webhook &#x60;type&#x60;: **standard**:  * **AUTHORISATION** * **CHARGEBACK_REVERSED** * **ORDER_CLOSED** * **ORDER_OPENED** * **PAIDOUT_REVERSED** * **PAYOUT_THIRDPARTY** * **REFUNDED_REVERSED** * **REFUND_WITH_DATA** * **REPORT_AVAILABLE** * **CUSTOM** - set your custom notification fields in the [&#x60;notification&#x60;](https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/companies/{companyId}/webhooks/{webhookId}/test__reqParam_notification) object.  Possible values if webhook &#x60;type&#x60;: **banktransfer-notification**:  * **PENDING**  Possible values if webhook &#x60;type&#x60;: **report-notification**:  * **REPORT_AVAILABLE**  Possible values if webhook &#x60;type&#x60;: **ideal-notification**:  * **AUTHORISATION**  Possible values if webhook &#x60;type&#x60;: **pending-notification**:  * **PENDING** </value>
        [DataMember(Name = "types", EmitDefaultValue = false)]
        public List<string> Types { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestCompanyWebhookRequest {\n");
            sb.Append("  MerchantIds: ").Append(MerchantIds).Append("\n");
            sb.Append("  Notification: ").Append(Notification).Append("\n");
            sb.Append("  Types: ").Append(Types).Append("\n");
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
            return this.Equals(input as TestCompanyWebhookRequest);
        }

        /// <summary>
        /// Returns true if TestCompanyWebhookRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TestCompanyWebhookRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestCompanyWebhookRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MerchantIds == input.MerchantIds ||
                    this.MerchantIds != null &&
                    input.MerchantIds != null &&
                    this.MerchantIds.SequenceEqual(input.MerchantIds)
                ) && 
                (
                    this.Notification == input.Notification ||
                    (this.Notification != null &&
                    this.Notification.Equals(input.Notification))
                ) && 
                (
                    this.Types == input.Types ||
                    this.Types != null &&
                    input.Types != null &&
                    this.Types.SequenceEqual(input.Types)
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
                if (this.MerchantIds != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantIds.GetHashCode();
                }
                if (this.Notification != null)
                {
                    hashCode = (hashCode * 59) + this.Notification.GetHashCode();
                }
                if (this.Types != null)
                {
                    hashCode = (hashCode * 59) + this.Types.GetHashCode();
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
