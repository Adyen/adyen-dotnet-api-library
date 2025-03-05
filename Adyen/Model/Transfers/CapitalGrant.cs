/*
* Transfers API
*
*
* The version of the OpenAPI document: 4
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

namespace Adyen.Model.Transfers
{
    /// <summary>
    /// CapitalGrant
    /// </summary>
    [DataContract(Name = "CapitalGrant")]
    public partial class CapitalGrant : IEquatable<CapitalGrant>, IValidatableObject
    {
        /// <summary>
        /// The current status of the grant. Possible values: **Pending**, **Active**, **Repaid**, **WrittenOff**, **Failed**, **Revoked**.
        /// </summary>
        /// <value>The current status of the grant. Possible values: **Pending**, **Active**, **Repaid**, **WrittenOff**, **Failed**, **Revoked**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Pending for value: Pending
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending = 1,

            /// <summary>
            /// Enum Active for value: Active
            /// </summary>
            [EnumMember(Value = "Active")]
            Active = 2,

            /// <summary>
            /// Enum Repaid for value: Repaid
            /// </summary>
            [EnumMember(Value = "Repaid")]
            Repaid = 3,

            /// <summary>
            /// Enum Failed for value: Failed
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed = 4,

            /// <summary>
            /// Enum WrittenOff for value: WrittenOff
            /// </summary>
            [EnumMember(Value = "WrittenOff")]
            WrittenOff = 5,

            /// <summary>
            /// Enum Revoked for value: Revoked
            /// </summary>
            [EnumMember(Value = "Revoked")]
            Revoked = 6

        }


        /// <summary>
        /// The current status of the grant. Possible values: **Pending**, **Active**, **Repaid**, **WrittenOff**, **Failed**, **Revoked**.
        /// </summary>
        /// <value>The current status of the grant. Possible values: **Pending**, **Active**, **Repaid**, **WrittenOff**, **Failed**, **Revoked**.</value>
        [DataMember(Name = "status", IsRequired = false, EmitDefaultValue = false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CapitalGrant" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CapitalGrant() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CapitalGrant" /> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="balances">balances (required).</param>
        /// <param name="counterparty">counterparty.</param>
        /// <param name="fee">fee.</param>
        /// <param name="grantAccountId">The identifier of the grant account used for the grant. (required).</param>
        /// <param name="grantOfferId">The identifier of the grant offer that has been selected and from which the grant details will be used. (required).</param>
        /// <param name="id">The identifier of the grant reference. (required).</param>
        /// <param name="repayment">repayment.</param>
        /// <param name="status">The current status of the grant. Possible values: **Pending**, **Active**, **Repaid**, **WrittenOff**, **Failed**, **Revoked**. (required).</param>
        public CapitalGrant(Amount amount = default(Amount), CapitalBalance balances = default(CapitalBalance), Counterparty counterparty = default(Counterparty), Fee fee = default(Fee), string grantAccountId = default(string), string grantOfferId = default(string), string id = default(string), Repayment repayment = default(Repayment), StatusEnum status = default(StatusEnum))
        {
            this.Balances = balances;
            this.GrantAccountId = grantAccountId;
            this.GrantOfferId = grantOfferId;
            this.Id = id;
            this.Status = status;
            this.Amount = amount;
            this.Counterparty = counterparty;
            this.Fee = fee;
            this.Repayment = repayment;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Amount Amount { get; set; }

        /// <summary>
        /// Gets or Sets Balances
        /// </summary>
        [DataMember(Name = "balances", IsRequired = false, EmitDefaultValue = false)]
        public CapitalBalance Balances { get; set; }

        /// <summary>
        /// Gets or Sets Counterparty
        /// </summary>
        [DataMember(Name = "counterparty", EmitDefaultValue = false)]
        public Counterparty Counterparty { get; set; }

        /// <summary>
        /// Gets or Sets Fee
        /// </summary>
        [DataMember(Name = "fee", EmitDefaultValue = false)]
        public Fee Fee { get; set; }

        /// <summary>
        /// The identifier of the grant account used for the grant.
        /// </summary>
        /// <value>The identifier of the grant account used for the grant.</value>
        [DataMember(Name = "grantAccountId", IsRequired = false, EmitDefaultValue = false)]
        public string GrantAccountId { get; set; }

        /// <summary>
        /// The identifier of the grant offer that has been selected and from which the grant details will be used.
        /// </summary>
        /// <value>The identifier of the grant offer that has been selected and from which the grant details will be used.</value>
        [DataMember(Name = "grantOfferId", IsRequired = false, EmitDefaultValue = false)]
        public string GrantOfferId { get; set; }

        /// <summary>
        /// The identifier of the grant reference.
        /// </summary>
        /// <value>The identifier of the grant reference.</value>
        [DataMember(Name = "id", IsRequired = false, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Repayment
        /// </summary>
        [DataMember(Name = "repayment", EmitDefaultValue = false)]
        public Repayment Repayment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CapitalGrant {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Balances: ").Append(Balances).Append("\n");
            sb.Append("  Counterparty: ").Append(Counterparty).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  GrantAccountId: ").Append(GrantAccountId).Append("\n");
            sb.Append("  GrantOfferId: ").Append(GrantOfferId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Repayment: ").Append(Repayment).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as CapitalGrant);
        }

        /// <summary>
        /// Returns true if CapitalGrant instances are equal
        /// </summary>
        /// <param name="input">Instance of CapitalGrant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CapitalGrant input)
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
                    this.Balances == input.Balances ||
                    (this.Balances != null &&
                    this.Balances.Equals(input.Balances))
                ) && 
                (
                    this.Counterparty == input.Counterparty ||
                    (this.Counterparty != null &&
                    this.Counterparty.Equals(input.Counterparty))
                ) && 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
                ) && 
                (
                    this.GrantAccountId == input.GrantAccountId ||
                    (this.GrantAccountId != null &&
                    this.GrantAccountId.Equals(input.GrantAccountId))
                ) && 
                (
                    this.GrantOfferId == input.GrantOfferId ||
                    (this.GrantOfferId != null &&
                    this.GrantOfferId.Equals(input.GrantOfferId))
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
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
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
                if (this.Balances != null)
                {
                    hashCode = (hashCode * 59) + this.Balances.GetHashCode();
                }
                if (this.Counterparty != null)
                {
                    hashCode = (hashCode * 59) + this.Counterparty.GetHashCode();
                }
                if (this.Fee != null)
                {
                    hashCode = (hashCode * 59) + this.Fee.GetHashCode();
                }
                if (this.GrantAccountId != null)
                {
                    hashCode = (hashCode * 59) + this.GrantAccountId.GetHashCode();
                }
                if (this.GrantOfferId != null)
                {
                    hashCode = (hashCode * 59) + this.GrantOfferId.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Repayment != null)
                {
                    hashCode = (hashCode * 59) + this.Repayment.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
