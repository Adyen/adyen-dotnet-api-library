using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.Model.MarketPay
{
    [DataContract]
    public class AccountEventContainer : IEquatable<AccountEventContainer>, IValidatableObject
    {
        [DataMember(Name = "accountEvent", EmitDefaultValue = false)]

        public AccountEvent accountEvent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountEventContainer {\n");
            sb.Append("  AccountEvent: ").Append(accountEvent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if AccountEventContainer instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountEventContainer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountEventContainer input)
        {
            if (input == null)
                return false;

            return
                (
                    this.accountEvent == input.accountEvent ||
                    this.accountEvent != null &&
                    input.accountEvent != null &&
                    this.accountEvent.Equals(input.accountEvent)
                );
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(
            ValidationContext validationContext)
        {
            yield break;
        }
    }
}
