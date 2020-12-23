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
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// ForexQuote
    /// </summary>
    [DataContract]
    public partial class ForexQuote : IEquatable<ForexQuote>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForexQuote" /> class.
        /// </summary>
        /// <param name="account">The account name..</param>
        /// <param name="accountType">The account type..</param>
        /// <param name="baseAmount">baseAmount.</param>
        /// <param name="basePoints">The base points. (required).</param>
        /// <param name="buy">buy.</param>
        /// <param name="interbank">interbank.</param>
        /// <param name="reference">The reference assigned to the forex quote request..</param>
        /// <param name="sell">sell.</param>
        /// <param name="signature">The signature to validate the integrity..</param>
        /// <param name="source">The source of the forex quote..</param>
        /// <param name="type">The type of forex..</param>
        /// <param name="validTill">The date until which the forex quote is valid. (required).</param>
        public ForexQuote(string account = default(string), string accountType = default(string),
            Amount baseAmount = default(Amount), int? basePoints = default(int?), Amount buy = default(Amount),
            Amount interbank = default(Amount), string reference = default(string), Amount sell = default(Amount),
            string signature = default(string), string source = default(string), string type = default(string),
            DateTime? validTill = default(DateTime?))
        {
            // to ensure "basePoints" is required (not null)
            if (basePoints == null)
            {
                throw new InvalidDataException("basePoints is a required property for ForexQuote and cannot be null");
            }
            else
            {
                this.BasePoints = basePoints;
            }
            // to ensure "validTill" is required (not null)
            if (validTill == null)
            {
                throw new InvalidDataException("validTill is a required property for ForexQuote and cannot be null");
            }
            else
            {
                this.ValidTill = validTill;
            }
            this.Account = account;
            this.AccountType = accountType;
            this.BaseAmount = baseAmount;
            this.Buy = buy;
            this.Interbank = interbank;
            this.Reference = reference;
            this.Sell = sell;
            this.Signature = signature;
            this.Source = source;
            this.Type = type;
        }

        /// <summary>
        /// The account name.
        /// </summary>
        /// <value>The account name.</value>
        [DataMember(Name = "account", EmitDefaultValue = false)]
        public string Account { get; set; }

        /// <summary>
        /// The account type.
        /// </summary>
        /// <value>The account type.</value>
        [DataMember(Name = "accountType", EmitDefaultValue = false)]
        public string AccountType { get; set; }

        /// <summary>
        /// Gets or Sets BaseAmount
        /// </summary>
        [DataMember(Name = "baseAmount", EmitDefaultValue = false)]
        public Amount BaseAmount { get; set; }

        /// <summary>
        /// The base points.
        /// </summary>
        /// <value>The base points.</value>
        [DataMember(Name = "basePoints", EmitDefaultValue = false)]
        public int? BasePoints { get; set; }

        /// <summary>
        /// Gets or Sets Buy
        /// </summary>
        [DataMember(Name = "buy", EmitDefaultValue = false)]
        public Amount Buy { get; set; }

        /// <summary>
        /// Gets or Sets Interbank
        /// </summary>
        [DataMember(Name = "interbank", EmitDefaultValue = false)]
        public Amount Interbank { get; set; }

        /// <summary>
        /// The reference assigned to the forex quote request.
        /// </summary>
        /// <value>The reference assigned to the forex quote request.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets Sell
        /// </summary>
        [DataMember(Name = "sell", EmitDefaultValue = false)]
        public Amount Sell { get; set; }

        /// <summary>
        /// The signature to validate the integrity.
        /// </summary>
        /// <value>The signature to validate the integrity.</value>
        [DataMember(Name = "signature", EmitDefaultValue = false)]
        public string Signature { get; set; }

        /// <summary>
        /// The source of the forex quote.
        /// </summary>
        /// <value>The source of the forex quote.</value>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public string Source { get; set; }

        /// <summary>
        /// The type of forex.
        /// </summary>
        /// <value>The type of forex.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// The date until which the forex quote is valid.
        /// </summary>
        /// <value>The date until which the forex quote is valid.</value>
        [DataMember(Name = "validTill", EmitDefaultValue = false)]
        public DateTime? ValidTill { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForexQuote {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  BaseAmount: ").Append(BaseAmount).Append("\n");
            sb.Append("  BasePoints: ").Append(BasePoints).Append("\n");
            sb.Append("  Buy: ").Append(Buy).Append("\n");
            sb.Append("  Interbank: ").Append(Interbank).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Sell: ").Append(Sell).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ValidTill: ").Append(ValidTill).Append("\n");
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
            return this.Equals(input as ForexQuote);
        }

        /// <summary>
        /// Returns true if ForexQuote instances are equal
        /// </summary>
        /// <param name="input">Instance of ForexQuote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForexQuote input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Account == input.Account ||
                    this.Account != null &&
                    this.Account.Equals(input.Account)
                ) &&
                (
                    this.AccountType == input.AccountType ||
                    this.AccountType != null &&
                    this.AccountType.Equals(input.AccountType)
                ) &&
                (
                    this.BaseAmount == input.BaseAmount ||
                    this.BaseAmount != null &&
                    this.BaseAmount.Equals(input.BaseAmount)
                ) &&
                (
                    this.BasePoints == input.BasePoints ||
                    this.BasePoints != null &&
                    this.BasePoints.Equals(input.BasePoints)
                ) &&
                (
                    this.Buy == input.Buy ||
                    this.Buy != null &&
                    this.Buy.Equals(input.Buy)
                ) &&
                (
                    this.Interbank == input.Interbank ||
                    this.Interbank != null &&
                    this.Interbank.Equals(input.Interbank)
                ) &&
                (
                    this.Reference == input.Reference ||
                    this.Reference != null &&
                    this.Reference.Equals(input.Reference)
                ) &&
                (
                    this.Sell == input.Sell ||
                    this.Sell != null &&
                    this.Sell.Equals(input.Sell)
                ) &&
                (
                    this.Signature == input.Signature ||
                    this.Signature != null &&
                    this.Signature.Equals(input.Signature)
                ) &&
                (
                    this.Source == input.Source ||
                    this.Source != null &&
                    this.Source.Equals(input.Source)
                ) &&
                (
                    this.Type == input.Type ||
                    this.Type != null &&
                    this.Type.Equals(input.Type)
                ) &&
                (
                    this.ValidTill == input.ValidTill ||
                    this.ValidTill != null &&
                    this.ValidTill.Equals(input.ValidTill)
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
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.AccountType != null)
                    hashCode = hashCode * 59 + this.AccountType.GetHashCode();
                if (this.BaseAmount != null)
                    hashCode = hashCode * 59 + this.BaseAmount.GetHashCode();
                if (this.BasePoints != null)
                    hashCode = hashCode * 59 + this.BasePoints.GetHashCode();
                if (this.Buy != null)
                    hashCode = hashCode * 59 + this.Buy.GetHashCode();
                if (this.Interbank != null)
                    hashCode = hashCode * 59 + this.Interbank.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.Sell != null)
                    hashCode = hashCode * 59 + this.Sell.GetHashCode();
                if (this.Signature != null)
                    hashCode = hashCode * 59 + this.Signature.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ValidTill != null)
                    hashCode = hashCode * 59 + this.ValidTill.GetHashCode();
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