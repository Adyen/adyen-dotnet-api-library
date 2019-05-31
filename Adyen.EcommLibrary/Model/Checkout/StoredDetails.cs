using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.EcommLibrary.Model.Checkout
{
    /// <summary>
    /// StoredDetails
    /// </summary>
    [DataContract]
    public partial class StoredDetails : IEquatable<StoredDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoredDetails" /> class.
        /// </summary>
        /// <param name="Bank">The stored bank account..</param>
        /// <param name="Card">The stored card information..</param>
        /// <param name="EmailAddress">The email associated with stored payment details..</param>
        public StoredDetails(BankAccount Bank = default(BankAccount), Card Card = default(Card),
            string EmailAddress = default(string))
        {
            this.Bank = Bank;
            this.Card = Card;
            this.EmailAddress = EmailAddress;
        }

        /// <summary>
        /// The stored bank account.
        /// </summary>
        /// <value>The stored bank account.</value>
        [DataMember(Name = "bank", EmitDefaultValue = false)]
        public BankAccount Bank { get; set; }

        /// <summary>
        /// The stored card information.
        /// </summary>
        /// <value>The stored card information.</value>
        [DataMember(Name = "card", EmitDefaultValue = false)]
        public Card Card { get; set; }

        /// <summary>
        /// The email associated with stored payment details.
        /// </summary>
        /// <value>The email associated with stored payment details.</value>
        [DataMember(Name = "emailAddress", EmitDefaultValue = false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoredDetails {\n");
            sb.Append("  Bank: ").Append(Bank).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return Equals(input as StoredDetails);
        }

        /// <summary>
        /// Returns true if StoredDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of StoredDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoredDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    Bank == input.Bank ||
                    Bank != null &&
                    Bank.Equals(input.Bank)
                ) &&
                (
                    Card == input.Card ||
                    Card != null &&
                    Card.Equals(input.Card)
                ) &&
                (
                    EmailAddress == input.EmailAddress ||
                    EmailAddress != null &&
                    EmailAddress.Equals(input.EmailAddress)
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
                var hashCode = 41;
                if (Bank != null)
                    hashCode = hashCode * 59 + Bank.GetHashCode();
                if (Card != null)
                    hashCode = hashCode * 59 + Card.GetHashCode();
                if (EmailAddress != null)
                    hashCode = hashCode * 59 + EmailAddress.GetHashCode();
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