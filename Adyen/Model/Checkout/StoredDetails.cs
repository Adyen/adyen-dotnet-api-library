#region Licence

// 
//                        ######
//                        ######
//  ############    ####( ######  #####. ######  ############   ############
//  #############  #####( ######  #####. ######  #############  #############
//         ######  #####( ######  #####. ######  #####  ######  #####  ######
//  ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  ###### ######  #####( ######  #####. ######  #####          #####  ######
//  #############  #############  #############  #############  #####  ######
//   ############   ############  #############   ############  #####  ######
//                                       ######
//                                #############
//                                ############
// 
//  Adyen Dotnet API Library
// 
//  Copyright (c) 2020 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.

#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
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
        /// <param name="bank">bank.</param>
        /// <param name="card">card.</param>
        /// <param name="emailAddress">The email associated with stored payment details..</param>
        public StoredDetails(BankAccount bank = default(BankAccount), Card card = default(Card),
            string emailAddress = default(string))
        {
            this.Bank = bank;
            this.Card = card;
            this.EmailAddress = emailAddress;
        }

        /// <summary>
        /// Gets or Sets Bank
        /// </summary>
        [DataMember(Name = "bank", EmitDefaultValue = false)]
        public BankAccount Bank { get; set; }

        /// <summary>
        /// Gets or Sets Card
        /// </summary>
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
            return this.Equals(input as StoredDetails);
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
                    this.Bank == input.Bank ||
                    this.Bank != null &&
                    this.Bank.Equals(input.Bank)
                ) &&
                (
                    this.Card == input.Card ||
                    this.Card != null &&
                    this.Card.Equals(input.Card)
                ) &&
                (
                    this.EmailAddress == input.EmailAddress ||
                    this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress)
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
                if (this.Bank != null)
                    hashCode = hashCode * 59 + this.Bank.GetHashCode();
                if (this.Card != null)
                    hashCode = hashCode * 59 + this.Card.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                return hashCode;
            }
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