/*
* Configuration webhooks
*
*
* The version of the OpenAPI document: 2
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

namespace Adyen.Model.ConfigurationWebhooks
{
    /// <summary>
    /// PlatformPaymentConfiguration
    /// </summary>
    [DataContract(Name = "PlatformPaymentConfiguration")]
    public partial class PlatformPaymentConfiguration : IEquatable<PlatformPaymentConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformPaymentConfiguration" /> class.
        /// </summary>
        /// <param name="salesDayClosingTime">Specifies at what time a [sales day](https://docs.adyen.com/platforms/settle-funds/sales-day-settlement#sales-day) ends for this account.  Possible values: Time in **\&quot;HH:MM\&quot;** format. **HH** ranges from **00** to **07**. **MM** must be **00**.  Default value: **\&quot;00:00\&quot;**..</param>
        /// <param name="settlementDelayDays">Specifies after how many business days the funds in a [settlement batch](https://docs.adyen.com/platforms/settle-funds/sales-day-settlement#settlement-batch) are made available in this balance account.  Possible values: **1** to **20**, or **null**. * Setting this value to an integer enables Sales day settlement in this balance account. See how Sales day settlement works in your [marketplace](https://docs.adyen.com/marketplaces/settle-funds/sales-day-settlement) or [platform](https://docs.adyen.com/platforms/settle-funds/sales-day-settlement). * Setting this value to **null** enables Pass-through settlement in this balance account. See how Pass-through settlement works in your [marketplace](https://docs.adyen.com/marketplaces/settle-funds/pass-through-settlement) or [platform](https://docs.adyen.com/platforms/settle-funds/pass-through-settlement).  Default value: **null**..</param>
        public PlatformPaymentConfiguration(string salesDayClosingTime = default(string), int? settlementDelayDays = default(int?))
        {
            this.SalesDayClosingTime = salesDayClosingTime;
            this.SettlementDelayDays = settlementDelayDays;
        }

        /// <summary>
        /// Specifies at what time a [sales day](https://docs.adyen.com/platforms/settle-funds/sales-day-settlement#sales-day) ends for this account.  Possible values: Time in **\&quot;HH:MM\&quot;** format. **HH** ranges from **00** to **07**. **MM** must be **00**.  Default value: **\&quot;00:00\&quot;**.
        /// </summary>
        /// <value>Specifies at what time a [sales day](https://docs.adyen.com/platforms/settle-funds/sales-day-settlement#sales-day) ends for this account.  Possible values: Time in **\&quot;HH:MM\&quot;** format. **HH** ranges from **00** to **07**. **MM** must be **00**.  Default value: **\&quot;00:00\&quot;**.</value>
        [DataMember(Name = "salesDayClosingTime", EmitDefaultValue = false)]
        public string SalesDayClosingTime { get; set; }

        /// <summary>
        /// Specifies after how many business days the funds in a [settlement batch](https://docs.adyen.com/platforms/settle-funds/sales-day-settlement#settlement-batch) are made available in this balance account.  Possible values: **1** to **20**, or **null**. * Setting this value to an integer enables Sales day settlement in this balance account. See how Sales day settlement works in your [marketplace](https://docs.adyen.com/marketplaces/settle-funds/sales-day-settlement) or [platform](https://docs.adyen.com/platforms/settle-funds/sales-day-settlement). * Setting this value to **null** enables Pass-through settlement in this balance account. See how Pass-through settlement works in your [marketplace](https://docs.adyen.com/marketplaces/settle-funds/pass-through-settlement) or [platform](https://docs.adyen.com/platforms/settle-funds/pass-through-settlement).  Default value: **null**.
        /// </summary>
        /// <value>Specifies after how many business days the funds in a [settlement batch](https://docs.adyen.com/platforms/settle-funds/sales-day-settlement#settlement-batch) are made available in this balance account.  Possible values: **1** to **20**, or **null**. * Setting this value to an integer enables Sales day settlement in this balance account. See how Sales day settlement works in your [marketplace](https://docs.adyen.com/marketplaces/settle-funds/sales-day-settlement) or [platform](https://docs.adyen.com/platforms/settle-funds/sales-day-settlement). * Setting this value to **null** enables Pass-through settlement in this balance account. See how Pass-through settlement works in your [marketplace](https://docs.adyen.com/marketplaces/settle-funds/pass-through-settlement) or [platform](https://docs.adyen.com/platforms/settle-funds/pass-through-settlement).  Default value: **null**.</value>
        [DataMember(Name = "settlementDelayDays", EmitDefaultValue = false)]
        public int? SettlementDelayDays { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlatformPaymentConfiguration {\n");
            sb.Append("  SalesDayClosingTime: ").Append(SalesDayClosingTime).Append("\n");
            sb.Append("  SettlementDelayDays: ").Append(SettlementDelayDays).Append("\n");
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
            return this.Equals(input as PlatformPaymentConfiguration);
        }

        /// <summary>
        /// Returns true if PlatformPaymentConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of PlatformPaymentConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlatformPaymentConfiguration input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SalesDayClosingTime == input.SalesDayClosingTime ||
                    (this.SalesDayClosingTime != null &&
                    this.SalesDayClosingTime.Equals(input.SalesDayClosingTime))
                ) && 
                (
                    this.SettlementDelayDays == input.SettlementDelayDays ||
                    this.SettlementDelayDays.Equals(input.SettlementDelayDays)
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
                if (this.SalesDayClosingTime != null)
                {
                    hashCode = (hashCode * 59) + this.SalesDayClosingTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SettlementDelayDays.GetHashCode();
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
