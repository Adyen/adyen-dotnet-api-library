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
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// AccountDetailBalance
    /// </summary>
    [DataContract]
    public class AccountDetailBalance : IEquatable<AccountDetailBalance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetailBalance" /> class.
        /// </summary>
        /// <param name="accountCode">The code of the account that holds the balance..</param>
        /// <param name="detailBalance">detailBalance.</param>
        public AccountDetailBalance(string accountCode = default(string), DetailBalance detailBalance = default(DetailBalance))
        {
            this.AccountCode = accountCode;
            this.DetailBalance = detailBalance;
        }

        /// <summary>
        /// The code of the account that holds the balance.
        /// </summary>
        /// <value>The code of the account that holds the balance.</value>
        [DataMember(Name = "accountCode", EmitDefaultValue = false)]
        [JsonProperty("accountCode")]
        public string AccountCode { get; set; }

        /// <summary>
        /// Gets or Sets DetailBalance
        /// </summary>
        [DataMember(Name = "detailBalance", EmitDefaultValue = false)]
        [JsonProperty("detailBalance")]
        public DetailBalance DetailBalance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountDetailBalance {\n");
            sb.Append("  AccountCode: ").Append(AccountCode).Append("\n");
            sb.Append("  DetailBalance: ").Append(DetailBalance).Append("\n");
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
            return this.Equals(input as AccountDetailBalance);
        }

        /// <summary>
        /// Returns true if AccountDetailBalance instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountDetailBalance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountDetailBalance input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AccountCode == input.AccountCode ||
                    (this.AccountCode != null &&
                    this.AccountCode.Equals(input.AccountCode))
                ) &&
                (
                    this.DetailBalance == input.DetailBalance ||
                    (this.DetailBalance != null &&
                    this.DetailBalance.Equals(input.DetailBalance))
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
                if (this.AccountCode != null)
                    hashCode = hashCode * 59 + this.AccountCode.GetHashCode();
                if (this.DetailBalance != null)
                    hashCode = hashCode * 59 + this.DetailBalance.GetHashCode();
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
