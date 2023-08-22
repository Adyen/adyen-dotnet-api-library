/*
* Transfer webhooks
*
*
* The version of the OpenAPI document: 3
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

namespace Adyen.Model.TransferNotification
{
    /// <summary>
    /// AmountAdjustment
    /// </summary>
    [DataContract(Name = "AmountAdjustment")]
    public partial class AmountAdjustment : IEquatable<AmountAdjustment>, IValidatableObject
    {
        /// <summary>
        /// The type of markup that is applied to an authorised payment.  Possible values: **exchange**, **forexMarkup**, **authHoldReserve**, **atmMarkup**.
        /// </summary>
        /// <value>The type of markup that is applied to an authorised payment.  Possible values: **exchange**, **forexMarkup**, **authHoldReserve**, **atmMarkup**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AmountAdjustmentTypeEnum
        {
            /// <summary>
            /// Enum AtmMarkup for value: atmMarkup
            /// </summary>
            [EnumMember(Value = "atmMarkup")]
            AtmMarkup = 1,

            /// <summary>
            /// Enum AuthHoldReserve for value: authHoldReserve
            /// </summary>
            [EnumMember(Value = "authHoldReserve")]
            AuthHoldReserve = 2,

            /// <summary>
            /// Enum Exchange for value: exchange
            /// </summary>
            [EnumMember(Value = "exchange")]
            Exchange = 3,

            /// <summary>
            /// Enum ForexMarkup for value: forexMarkup
            /// </summary>
            [EnumMember(Value = "forexMarkup")]
            ForexMarkup = 4

        }


        /// <summary>
        /// The type of markup that is applied to an authorised payment.  Possible values: **exchange**, **forexMarkup**, **authHoldReserve**, **atmMarkup**.
        /// </summary>
        /// <value>The type of markup that is applied to an authorised payment.  Possible values: **exchange**, **forexMarkup**, **authHoldReserve**, **atmMarkup**.</value>
        [DataMember(Name = "amountAdjustmentType", EmitDefaultValue = false)]
        public AmountAdjustmentTypeEnum? AmountAdjustmentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AmountAdjustment" /> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="amountAdjustmentType">The type of markup that is applied to an authorised payment.  Possible values: **exchange**, **forexMarkup**, **authHoldReserve**, **atmMarkup**..</param>
        /// <param name="basepoints">The basepoints associated with the applied markup..</param>
        public AmountAdjustment(Amount amount = default(Amount), AmountAdjustmentTypeEnum? amountAdjustmentType = default(AmountAdjustmentTypeEnum?), int? basepoints = default(int?))
        {
            this.Amount = amount;
            this.AmountAdjustmentType = amountAdjustmentType;
            this.Basepoints = basepoints;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Amount Amount { get; set; }

        /// <summary>
        /// The basepoints associated with the applied markup.
        /// </summary>
        /// <value>The basepoints associated with the applied markup.</value>
        [DataMember(Name = "basepoints", EmitDefaultValue = false)]
        public int? Basepoints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AmountAdjustment {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  AmountAdjustmentType: ").Append(AmountAdjustmentType).Append("\n");
            sb.Append("  Basepoints: ").Append(Basepoints).Append("\n");
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
            return this.Equals(input as AmountAdjustment);
        }

        /// <summary>
        /// Returns true if AmountAdjustment instances are equal
        /// </summary>
        /// <param name="input">Instance of AmountAdjustment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AmountAdjustment input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.AmountAdjustmentType == input.AmountAdjustmentType ||
                    this.AmountAdjustmentType.Equals(input.AmountAdjustmentType)
                ) && 
                (
                    this.Basepoints == input.Basepoints ||
                    this.Basepoints.Equals(input.Basepoints)
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AmountAdjustmentType.GetHashCode();
                hashCode = (hashCode * 59) + this.Basepoints.GetHashCode();
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
