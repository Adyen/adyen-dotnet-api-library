#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// DetailBalance
    /// </summary>
    [DataContract]
    public partial class DetailBalance : IEquatable<DetailBalance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailBalance" /> class.
        /// </summary>
        /// <param name="balance">The list of balances held by the account..</param>
        /// <param name="onHoldBalance">The list of on hold balances held by the account..</param>
        /// <param name="pendingBalance">The list of pending balances held by the account..</param>
        public DetailBalance(List<Amount> balance = default(List<Amount>), List<Amount> onHoldBalance = default(List<Amount>), List<Amount> pendingBalance = default(List<Amount>))
        {
            this.Balance = balance;
            this.OnHoldBalance = onHoldBalance;
            this.PendingBalance = pendingBalance;
        }

        /// <summary>
        /// The list of balances held by the account.
        /// </summary>
        /// <value>The list of balances held by the account.</value>
        [DataMember(Name = "balance", EmitDefaultValue = false)]
        [JsonProperty("balance")]       
        public List<Amount> Balance { get; set; }

        /// <summary>
        /// The list of on hold balances held by the account.
        /// </summary>
        /// <value>The list of on hold balances held by the account.</value>
        [DataMember(Name = "onHoldBalance", EmitDefaultValue = false)]
        public List<Amount> OnHoldBalance { get; set; }

        /// <summary>
        /// The list of pending balances held by the account.
        /// </summary>
        /// <value>The list of pending balances held by the account.</value>
        [DataMember(Name = "pendingBalance", EmitDefaultValue = false)]
        public List<Amount> PendingBalance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetailBalance {\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  OnHoldBalance: ").Append(OnHoldBalance).Append("\n");
            sb.Append("  PendingBalance: ").Append(PendingBalance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DetailBalance);
        }

        /// <summary>
        /// Returns true if DetailBalance instances are equal
        /// </summary>
        /// <param name="input">Instance of DetailBalance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetailBalance input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Balance == input.Balance ||
                    this.Balance != null &&
                    input.Balance != null &&
                    this.Balance.SequenceEqual(input.Balance)
                ) &&
                (
                    this.OnHoldBalance == input.OnHoldBalance ||
                    this.OnHoldBalance != null &&
                    input.OnHoldBalance != null &&
                    this.OnHoldBalance.SequenceEqual(input.OnHoldBalance)
                ) &&
                (
                    this.PendingBalance == input.PendingBalance ||
                    this.PendingBalance != null &&
                    input.PendingBalance != null &&
                    this.PendingBalance.SequenceEqual(input.PendingBalance)
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
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.OnHoldBalance != null)
                    hashCode = hashCode * 59 + this.OnHoldBalance.GetHashCode();
                if (this.PendingBalance != null)
                    hashCode = hashCode * 59 + this.PendingBalance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
