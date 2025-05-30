/*
* Dispute webhooks
*
*
* The version of the OpenAPI document: 1
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

namespace Adyen.Model.DisputeWebhooks
{
    /// <summary>
    /// BalancePlatformNotificationResponse
    /// </summary>
    [DataContract(Name = "BalancePlatformNotificationResponse")]
    public partial class BalancePlatformNotificationResponse : IEquatable<BalancePlatformNotificationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BalancePlatformNotificationResponse" /> class.
        /// </summary>
        /// <param name="notificationResponse">Respond with any **2xx** HTTP status code to [accept the webhook](https://docs.adyen.com/development-resources/webhooks#accept-notifications)..</param>
        public BalancePlatformNotificationResponse(string notificationResponse = default(string))
        {
            this.NotificationResponse = notificationResponse;
        }

        /// <summary>
        /// Respond with any **2xx** HTTP status code to [accept the webhook](https://docs.adyen.com/development-resources/webhooks#accept-notifications).
        /// </summary>
        /// <value>Respond with any **2xx** HTTP status code to [accept the webhook](https://docs.adyen.com/development-resources/webhooks#accept-notifications).</value>
        [DataMember(Name = "notificationResponse", EmitDefaultValue = false)]
        public string NotificationResponse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BalancePlatformNotificationResponse {\n");
            sb.Append("  NotificationResponse: ").Append(NotificationResponse).Append("\n");
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
            return this.Equals(input as BalancePlatformNotificationResponse);
        }

        /// <summary>
        /// Returns true if BalancePlatformNotificationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of BalancePlatformNotificationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BalancePlatformNotificationResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NotificationResponse == input.NotificationResponse ||
                    (this.NotificationResponse != null &&
                    this.NotificationResponse.Equals(input.NotificationResponse))
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
                if (this.NotificationResponse != null)
                {
                    hashCode = (hashCode * 59) + this.NotificationResponse.GetHashCode();
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
