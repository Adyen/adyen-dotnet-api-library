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
    /// CapabilitySettings
    /// </summary>
    [DataContract(Name = "CapabilitySettings")]
    public partial class CapabilitySettings : IEquatable<CapabilitySettings>, IValidatableObject
    {
        /// <summary>
        /// Defines FundingSource
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FundingSourceEnum
        {
            /// <summary>
            /// Enum Credit for value: credit
            /// </summary>
            [EnumMember(Value = "credit")]
            Credit = 1,

            /// <summary>
            /// Enum Debit for value: debit
            /// </summary>
            [EnumMember(Value = "debit")]
            Debit = 2,

            /// <summary>
            /// Enum Prepaid for value: prepaid
            /// </summary>
            [EnumMember(Value = "prepaid")]
            Prepaid = 3

        }



        /// <summary>
        /// Gets or Sets FundingSource
        /// </summary>
        [DataMember(Name = "fundingSource", EmitDefaultValue = false)]
        public List<FundingSourceEnum> FundingSource { get; set; }
        /// <summary>
        /// Defines Interval
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IntervalEnum
        {
            /// <summary>
            /// Enum Daily for value: daily
            /// </summary>
            [EnumMember(Value = "daily")]
            Daily = 1,

            /// <summary>
            /// Enum Monthly for value: monthly
            /// </summary>
            [EnumMember(Value = "monthly")]
            Monthly = 2,

            /// <summary>
            /// Enum Weekly for value: weekly
            /// </summary>
            [EnumMember(Value = "weekly")]
            Weekly = 3

        }


        /// <summary>
        /// Gets or Sets Interval
        /// </summary>
        [DataMember(Name = "interval", EmitDefaultValue = false)]
        public IntervalEnum? Interval { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CapabilitySettings" /> class.
        /// </summary>
        /// <param name="amountPerIndustry">amountPerIndustry.</param>
        /// <param name="authorizedCardUsers">authorizedCardUsers.</param>
        /// <param name="fundingSource">fundingSource.</param>
        /// <param name="interval">interval.</param>
        /// <param name="maxAmount">maxAmount.</param>
        public CapabilitySettings(Dictionary<string, Amount> amountPerIndustry = default(Dictionary<string, Amount>), bool? authorizedCardUsers = default(bool?), List<FundingSourceEnum> fundingSource = default(List<FundingSourceEnum>), IntervalEnum? interval = default(IntervalEnum?), Amount maxAmount = default(Amount))
        {
            this.AmountPerIndustry = amountPerIndustry;
            this.AuthorizedCardUsers = authorizedCardUsers;
            this.FundingSource = fundingSource;
            this.Interval = interval;
            this.MaxAmount = maxAmount;
        }

        /// <summary>
        /// Gets or Sets AmountPerIndustry
        /// </summary>
        [DataMember(Name = "amountPerIndustry", EmitDefaultValue = false)]
        public Dictionary<string, Amount> AmountPerIndustry { get; set; }

        /// <summary>
        /// Gets or Sets AuthorizedCardUsers
        /// </summary>
        [DataMember(Name = "authorizedCardUsers", EmitDefaultValue = false)]
        public bool? AuthorizedCardUsers { get; set; }

        /// <summary>
        /// Gets or Sets MaxAmount
        /// </summary>
        [DataMember(Name = "maxAmount", EmitDefaultValue = false)]
        public Amount MaxAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CapabilitySettings {\n");
            sb.Append("  AmountPerIndustry: ").Append(AmountPerIndustry).Append("\n");
            sb.Append("  AuthorizedCardUsers: ").Append(AuthorizedCardUsers).Append("\n");
            sb.Append("  FundingSource: ").Append(FundingSource).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  MaxAmount: ").Append(MaxAmount).Append("\n");
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
            return this.Equals(input as CapabilitySettings);
        }

        /// <summary>
        /// Returns true if CapabilitySettings instances are equal
        /// </summary>
        /// <param name="input">Instance of CapabilitySettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CapabilitySettings input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AmountPerIndustry == input.AmountPerIndustry ||
                    this.AmountPerIndustry != null &&
                    input.AmountPerIndustry != null &&
                    this.AmountPerIndustry.SequenceEqual(input.AmountPerIndustry)
                ) && 
                (
                    this.AuthorizedCardUsers == input.AuthorizedCardUsers ||
                    this.AuthorizedCardUsers.Equals(input.AuthorizedCardUsers)
                ) && 
                (
                    this.FundingSource == input.FundingSource ||
                    this.FundingSource.SequenceEqual(input.FundingSource)
                ) && 
                (
                    this.Interval == input.Interval ||
                    this.Interval.Equals(input.Interval)
                ) && 
                (
                    this.MaxAmount == input.MaxAmount ||
                    (this.MaxAmount != null &&
                    this.MaxAmount.Equals(input.MaxAmount))
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
                if (this.AmountPerIndustry != null)
                {
                    hashCode = (hashCode * 59) + this.AmountPerIndustry.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AuthorizedCardUsers.GetHashCode();
                hashCode = (hashCode * 59) + this.FundingSource.GetHashCode();
                hashCode = (hashCode * 59) + this.Interval.GetHashCode();
                if (this.MaxAmount != null)
                {
                    hashCode = (hashCode * 59) + this.MaxAmount.GetHashCode();
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
