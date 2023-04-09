using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// TransactionListForAccount
    /// </summary>
    [DataContract]
    public class TransactionListForAccount : IEquatable<TransactionListForAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionListForAccount" /> class.
        /// </summary>
        /// <param name="accountCode">The account for which to retrieve the transactions. (required).</param>
        /// <param name="page">The page of transactions to retrieve. Each page lists fifty (50) transactions.  The most recent transactions are included on page 1. (required).</param>
        public TransactionListForAccount(string accountCode = default(string), int? page = default(int?))
        {
            // to ensure "accountCode" is required (not null)
            if (accountCode == null)
            {
                throw new InvalidDataException("accountCode is a required property for TransactionListForAccount and cannot be null");
            }

            AccountCode = accountCode;
            // to ensure "page" is required (not null)
            if (page == null)
            {
                throw new InvalidDataException("page is a required property for TransactionListForAccount and cannot be null");
            }

            Page = page;
        }

        /// <summary>
        /// The account for which to retrieve the transactions.
        /// </summary>
        /// <value>The account for which to retrieve the transactions.</value>
        [DataMember(Name = "accountCode", EmitDefaultValue = false)]
        public string AccountCode { get; set; }

        /// <summary>
        /// The page of transactions to retrieve. Each page lists fifty (50) transactions.  The most recent transactions are included on page 1.
        /// </summary>
        /// <value>The page of transactions to retrieve. Each page lists fifty (50) transactions.  The most recent transactions are included on page 1.</value>
        [DataMember(Name = "page", EmitDefaultValue = false)]
        public int? Page { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionListForAccount {\n");
            sb.Append("  AccountCode: ").Append(AccountCode).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
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
            return Equals(input as TransactionListForAccount);
        }

        /// <summary>
        /// Returns true if TransactionListForAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionListForAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionListForAccount input)
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
                    Page == input.Page ||
                    (Page != null &&
                    Page.Equals(input.Page))
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
                if (Page != null)
                    hashCode = hashCode * 59 + Page.GetHashCode();
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
