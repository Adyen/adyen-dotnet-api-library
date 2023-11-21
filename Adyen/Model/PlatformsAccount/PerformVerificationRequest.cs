/*
* Account API
*
*
* The version of the OpenAPI document: 6
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

namespace Adyen.Model.PlatformsAccount
{
    /// <summary>
    /// PerformVerificationRequest
    /// </summary>
    [DataContract(Name = "PerformVerificationRequest")]
    public partial class PerformVerificationRequest : IEquatable<PerformVerificationRequest>, IValidatableObject
    {
        /// <summary>
        /// The state required for the account holder. &gt; Permitted values: &#x60;Processing&#x60;, &#x60;Payout&#x60;.
        /// </summary>
        /// <value>The state required for the account holder. &gt; Permitted values: &#x60;Processing&#x60;, &#x60;Payout&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountStateTypeEnum
        {
            /// <summary>
            /// Enum LimitedPayout for value: LimitedPayout
            /// </summary>
            [EnumMember(Value = "LimitedPayout")]
            LimitedPayout = 1,

            /// <summary>
            /// Enum LimitedProcessing for value: LimitedProcessing
            /// </summary>
            [EnumMember(Value = "LimitedProcessing")]
            LimitedProcessing = 2,

            /// <summary>
            /// Enum LimitlessPayout for value: LimitlessPayout
            /// </summary>
            [EnumMember(Value = "LimitlessPayout")]
            LimitlessPayout = 3,

            /// <summary>
            /// Enum LimitlessProcessing for value: LimitlessProcessing
            /// </summary>
            [EnumMember(Value = "LimitlessProcessing")]
            LimitlessProcessing = 4,

            /// <summary>
            /// Enum Payout for value: Payout
            /// </summary>
            [EnumMember(Value = "Payout")]
            Payout = 5,

            /// <summary>
            /// Enum Processing for value: Processing
            /// </summary>
            [EnumMember(Value = "Processing")]
            Processing = 6

        }


        /// <summary>
        /// The state required for the account holder. &gt; Permitted values: &#x60;Processing&#x60;, &#x60;Payout&#x60;.
        /// </summary>
        /// <value>The state required for the account holder. &gt; Permitted values: &#x60;Processing&#x60;, &#x60;Payout&#x60;.</value>
        [DataMember(Name = "accountStateType", IsRequired = false, EmitDefaultValue = false)]
        public AccountStateTypeEnum AccountStateType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PerformVerificationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PerformVerificationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PerformVerificationRequest" /> class.
        /// </summary>
        /// <param name="accountHolderCode">The code of the account holder to verify. (required).</param>
        /// <param name="accountStateType">The state required for the account holder. &gt; Permitted values: &#x60;Processing&#x60;, &#x60;Payout&#x60;. (required).</param>
        /// <param name="tier">The tier required for the account holder. (required).</param>
        public PerformVerificationRequest(string accountHolderCode = default(string), AccountStateTypeEnum accountStateType = default(AccountStateTypeEnum), int? tier = default(int?))
        {
            this.AccountHolderCode = accountHolderCode;
            this.AccountStateType = accountStateType;
            this.Tier = tier;
        }

        /// <summary>
        /// The code of the account holder to verify.
        /// </summary>
        /// <value>The code of the account holder to verify.</value>
        [DataMember(Name = "accountHolderCode", IsRequired = false, EmitDefaultValue = false)]
        public string AccountHolderCode { get; set; }

        /// <summary>
        /// The tier required for the account holder.
        /// </summary>
        /// <value>The tier required for the account holder.</value>
        [DataMember(Name = "tier", IsRequired = false, EmitDefaultValue = false)]
        public int? Tier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PerformVerificationRequest {\n");
            sb.Append("  AccountHolderCode: ").Append(AccountHolderCode).Append("\n");
            sb.Append("  AccountStateType: ").Append(AccountStateType).Append("\n");
            sb.Append("  Tier: ").Append(Tier).Append("\n");
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
            return this.Equals(input as PerformVerificationRequest);
        }

        /// <summary>
        /// Returns true if PerformVerificationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PerformVerificationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PerformVerificationRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountHolderCode == input.AccountHolderCode ||
                    (this.AccountHolderCode != null &&
                    this.AccountHolderCode.Equals(input.AccountHolderCode))
                ) && 
                (
                    this.AccountStateType == input.AccountStateType ||
                    this.AccountStateType.Equals(input.AccountStateType)
                ) && 
                (
                    this.Tier == input.Tier ||
                    this.Tier.Equals(input.Tier)
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
                if (this.AccountHolderCode != null)
                {
                    hashCode = (hashCode * 59) + this.AccountHolderCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AccountStateType.GetHashCode();
                hashCode = (hashCode * 59) + this.Tier.GetHashCode();
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