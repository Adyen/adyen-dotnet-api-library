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
    /// AccountTransactionList
    /// </summary>
    [DataContract]
    public class AccountTransactionList : IEquatable<AccountTransactionList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountTransactionListc" /> class.
        /// </summary>
        /// <param name="accountCode">The code of the account..</param>
        /// <param name="hasNextPage">Indicates whether there is a next page of transactions available..</param>
        /// <param name="transactions">The list of transactions..</param>
        public AccountTransactionList(string accountCode = default(string), bool? hasNextPage = default(bool?), List<Transaction> transactions = default(List<Transaction>))
        {
            AccountCode = accountCode;
            HasNextPage = hasNextPage;
            Transactions = transactions;
        }

        /// <summary>
        /// The code of the account.
        /// </summary>
        /// <value>The code of the account.</value>
        [DataMember(Name = "accountCode", EmitDefaultValue = false)]
        public string AccountCode { get; set; }

        /// <summary>
        /// Indicates whether there is a next page of transactions available.
        /// </summary>
        /// <value>Indicates whether there is a next page of transactions available.</value>
        [DataMember(Name = "hasNextPage", EmitDefaultValue = false)]
        public bool? HasNextPage { get; set; }

        /// <summary>
        /// The list of transactions.
        /// </summary>
        /// <value>The list of transactions.</value>
        [DataMember(Name = "transactions", EmitDefaultValue = false)]
        public List<Transaction> Transactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountTransactionList {\n");
            sb.Append("  AccountCode: ").Append(AccountCode).Append("\n");
            sb.Append("  HasNextPage: ").Append(HasNextPage).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
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
            return Equals(input as AccountTransactionList);
        }

        /// <summary>
        /// Returns true if AccountTransactionList instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountTransactionList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountTransactionList input)
        {
            if (input == null)
                return false;

            return
                (
                    AccountCode == input.AccountCode ||
                    (AccountCode != null &&
                    AccountCode.Equals(input.AccountCode))
                ) &&
                (
                    HasNextPage == input.HasNextPage ||
                    (HasNextPage != null &&
                    HasNextPage.Equals(input.HasNextPage))
                ) &&
                (
                    Transactions == input.Transactions ||
                    Transactions != null &&
                    input.Transactions != null &&
                    Transactions.SequenceEqual(input.Transactions)
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
                if (AccountCode != null)
                    hashCode = hashCode * 59 + AccountCode.GetHashCode();
                if (HasNextPage != null)
                    hashCode = hashCode * 59 + HasNextPage.GetHashCode();
                if (Transactions != null)
                    hashCode = hashCode * 59 + Transactions.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
