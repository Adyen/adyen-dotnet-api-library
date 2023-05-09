/*
* Configuration API
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

namespace Adyen.Model.BalancePlatform
{
    /// <summary>
    /// GrantOffer
    /// </summary>
    [DataContract(Name = "GrantOffer")]
    public partial class GrantOffer : IEquatable<GrantOffer>, IValidatableObject
    {
        /// <summary>
        /// The contract type of the grant offer. Possible value: **cashAdvance**, **loan**.
        /// </summary>
        /// <value>The contract type of the grant offer. Possible value: **cashAdvance**, **loan**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ContractTypeEnum
        {
            /// <summary>
            /// Enum CashAdvance for value: cashAdvance
            /// </summary>
            [EnumMember(Value = "cashAdvance")]
            CashAdvance = 1,

            /// <summary>
            /// Enum Loan for value: loan
            /// </summary>
            [EnumMember(Value = "loan")]
            Loan = 2

        }


        /// <summary>
        /// The contract type of the grant offer. Possible value: **cashAdvance**, **loan**.
        /// </summary>
        /// <value>The contract type of the grant offer. Possible value: **cashAdvance**, **loan**.</value>
        [DataMember(Name = "contractType", EmitDefaultValue = false)]
        public ContractTypeEnum? ContractType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GrantOffer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GrantOffer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GrantOffer" /> class.
        /// </summary>
        /// <param name="accountHolderId">The identifier of the account holder to which the grant is offered. (required).</param>
        /// <param name="amount">amount.</param>
        /// <param name="contractType">The contract type of the grant offer. Possible value: **cashAdvance**, **loan**..</param>
        /// <param name="expiresAt">expiresAt.</param>
        /// <param name="fee">fee.</param>
        /// <param name="id">The unique identifier of the grant offer..</param>
        /// <param name="repayment">repayment.</param>
        /// <param name="startsAt">startsAt.</param>
        public GrantOffer(string accountHolderId = default(string), Amount amount = default(Amount), ContractTypeEnum? contractType = default(ContractTypeEnum?), Object expiresAt = default(Object), Fee fee = default(Fee), string id = default(string), Repayment repayment = default(Repayment), Object startsAt = default(Object))
        {
            this.AccountHolderId = accountHolderId;
            this.Amount = amount;
            this.ContractType = contractType;
            this.ExpiresAt = expiresAt;
            this.Fee = fee;
            this.Id = id;
            this.Repayment = repayment;
            this.StartsAt = startsAt;
        }

        /// <summary>
        /// The identifier of the account holder to which the grant is offered.
        /// </summary>
        /// <value>The identifier of the account holder to which the grant is offered.</value>
        [DataMember(Name = "accountHolderId", IsRequired = false, EmitDefaultValue = false)]
        public string AccountHolderId { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Amount Amount { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresAt
        /// </summary>
        [DataMember(Name = "expiresAt", EmitDefaultValue = false)]
        public Object ExpiresAt { get; set; }

        /// <summary>
        /// Gets or Sets Fee
        /// </summary>
        [DataMember(Name = "fee", EmitDefaultValue = false)]
        public Fee Fee { get; set; }

        /// <summary>
        /// The unique identifier of the grant offer.
        /// </summary>
        /// <value>The unique identifier of the grant offer.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Repayment
        /// </summary>
        [DataMember(Name = "repayment", EmitDefaultValue = false)]
        public Repayment Repayment { get; set; }

        /// <summary>
        /// Gets or Sets StartsAt
        /// </summary>
        [DataMember(Name = "startsAt", EmitDefaultValue = false)]
        public Object StartsAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GrantOffer {\n");
            sb.Append("  AccountHolderId: ").Append(AccountHolderId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ContractType: ").Append(ContractType).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Repayment: ").Append(Repayment).Append("\n");
            sb.Append("  StartsAt: ").Append(StartsAt).Append("\n");
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
            return this.Equals(input as GrantOffer);
        }

        /// <summary>
        /// Returns true if GrantOffer instances are equal
        /// </summary>
        /// <param name="input">Instance of GrantOffer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GrantOffer input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountHolderId == input.AccountHolderId ||
                    (this.AccountHolderId != null &&
                    this.AccountHolderId.Equals(input.AccountHolderId))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.ContractType == input.ContractType ||
                    this.ContractType.Equals(input.ContractType)
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    (this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(input.ExpiresAt))
                ) && 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Repayment == input.Repayment ||
                    (this.Repayment != null &&
                    this.Repayment.Equals(input.Repayment))
                ) && 
                (
                    this.StartsAt == input.StartsAt ||
                    (this.StartsAt != null &&
                    this.StartsAt.Equals(input.StartsAt))
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
                if (this.AccountHolderId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountHolderId.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ContractType.GetHashCode();
                if (this.ExpiresAt != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiresAt.GetHashCode();
                }
                if (this.Fee != null)
                {
                    hashCode = (hashCode * 59) + this.Fee.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Repayment != null)
                {
                    hashCode = (hashCode * 59) + this.Repayment.GetHashCode();
                }
                if (this.StartsAt != null)
                {
                    hashCode = (hashCode * 59) + this.StartsAt.GetHashCode();
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