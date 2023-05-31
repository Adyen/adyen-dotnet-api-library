/*
* Configuration webhooks
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

namespace Adyen.Model.ConfigurationNotification
{
    /// <summary>
    /// AccountHolderNotificationData
    /// </summary>
    [DataContract(Name = "AccountHolderNotificationData")]
    public partial class AccountHolderNotificationData : IEquatable<AccountHolderNotificationData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountHolderNotificationData" /> class.
        /// </summary>
        /// <param name="accountHolder">accountHolder.</param>
        /// <param name="balancePlatform">The unique identifier of the balance platform..</param>
        public AccountHolderNotificationData(AccountHolder accountHolder = default(AccountHolder), string balancePlatform = default(string))
        {
            this.AccountHolder = accountHolder;
            this.BalancePlatform = balancePlatform;
        }

        /// <summary>
        /// Gets or Sets AccountHolder
        /// </summary>
        [DataMember(Name = "accountHolder", EmitDefaultValue = false)]
        public AccountHolder AccountHolder { get; set; }

        /// <summary>
        /// The unique identifier of the balance platform.
        /// </summary>
        /// <value>The unique identifier of the balance platform.</value>
        [DataMember(Name = "balancePlatform", EmitDefaultValue = false)]
        public string BalancePlatform { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountHolderNotificationData {\n");
            sb.Append("  AccountHolder: ").Append(AccountHolder).Append("\n");
            sb.Append("  BalancePlatform: ").Append(BalancePlatform).Append("\n");
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
            return this.Equals(input as AccountHolderNotificationData);
        }

        /// <summary>
        /// Returns true if AccountHolderNotificationData instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountHolderNotificationData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountHolderNotificationData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountHolder == input.AccountHolder ||
                    (this.AccountHolder != null &&
                    this.AccountHolder.Equals(input.AccountHolder))
                ) && 
                (
                    this.BalancePlatform == input.BalancePlatform ||
                    (this.BalancePlatform != null &&
                    this.BalancePlatform.Equals(input.BalancePlatform))
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
                if (this.AccountHolder != null)
                {
                    hashCode = (hashCode * 59) + this.AccountHolder.GetHashCode();
                }
                if (this.BalancePlatform != null)
                {
                    hashCode = (hashCode * 59) + this.BalancePlatform.GetHashCode();
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
