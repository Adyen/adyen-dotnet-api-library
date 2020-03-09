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
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// PayoutAccountHolderRequest
    /// </summary>
    [DataContract]
    public class PayoutAccountHolderRequest : IEquatable<PayoutAccountHolderRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutAccountHolderRequest" /> class.
        /// </summary>
        /// <param name="accountCode">The code of the account from which the payout is to be made. (required).</param>
        /// <param name="accountHolderCode">The code of the Account Holder who owns the account from which the payout is to be made. The Account Holder is the party to which the payout will be made. (required).</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="bankAccountUUID">The unique ID of the Bank Account held by the Account Holder to which the payout is to be made. If left blank, a bank account is automatically selected..</param>
        /// <param name="description">A description of the payout. Maximum 35 characters. Allowed: **abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789/?:().,&#x27;+ \&quot;;**.</param>
        /// <param name="merchantReference">A value that can be supplied at the discretion of the executing user in order to link multiple transactions to one another..</param>
        /// <param name="payoutMethodCode">The unique ID of the payout method held by the Account Holder to which the payout is to be made. If left blank, a payout instrument is automatically selected..</param>
        public PayoutAccountHolderRequest(string accountCode = default(string), string accountHolderCode = default(string), Amount amount = default(Amount), string bankAccountUUID = default(string), string description = default(string), string merchantReference = default(string), string payoutMethodCode = default(string))
        {
            // to ensure "accountCode" is required (not null)
            if (accountCode == null)
            {
                throw new InvalidDataException("accountCode is a required property for PayoutAccountHolderRequest and cannot be null");
            }
            else
            {
                this.AccountCode = accountCode;
            }
            // to ensure "accountHolderCode" is required (not null)
            if (accountHolderCode == null)
            {
                throw new InvalidDataException("accountHolderCode is a required property for PayoutAccountHolderRequest and cannot be null");
            }
            else
            {
                this.AccountHolderCode = accountHolderCode;
            }
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for PayoutAccountHolderRequest and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            this.BankAccountUUID = bankAccountUUID;
            this.Description = description;
            this.MerchantReference = merchantReference;
            this.PayoutMethodCode = payoutMethodCode;
        }

        /// <summary>
        /// The code of the account from which the payout is to be made.
        /// </summary>
        /// <value>The code of the account from which the payout is to be made.</value>
        [DataMember(Name = "accountCode", EmitDefaultValue = false)]
        public string AccountCode { get; set; }

        /// <summary>
        /// The code of the Account Holder who owns the account from which the payout is to be made. The Account Holder is the party to which the payout will be made.
        /// </summary>
        /// <value>The code of the Account Holder who owns the account from which the payout is to be made. The Account Holder is the party to which the payout will be made.</value>
        [DataMember(Name = "accountHolderCode", EmitDefaultValue = false)]
        public string AccountHolderCode { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Amount Amount { get; set; }

        /// <summary>
        /// The unique ID of the Bank Account held by the Account Holder to which the payout is to be made. If left blank, a bank account is automatically selected.
        /// </summary>
        /// <value>The unique ID of the Bank Account held by the Account Holder to which the payout is to be made. If left blank, a bank account is automatically selected.</value>
        [DataMember(Name = "bankAccountUUID", EmitDefaultValue = false)]
        public string BankAccountUUID { get; set; }

        /// <summary>
        /// A description of the payout. Maximum 35 characters. Allowed: **abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789/?:().,&#x27;+ \&quot;;**
        /// </summary>
        /// <value>A description of the payout. Maximum 35 characters. Allowed: **abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789/?:().,&#x27;+ \&quot;;**</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// A value that can be supplied at the discretion of the executing user in order to link multiple transactions to one another.
        /// </summary>
        /// <value>A value that can be supplied at the discretion of the executing user in order to link multiple transactions to one another.</value>
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        public string MerchantReference { get; set; }

        /// <summary>
        /// The unique ID of the payout method held by the Account Holder to which the payout is to be made. If left blank, a payout instrument is automatically selected.
        /// </summary>
        /// <value>The unique ID of the payout method held by the Account Holder to which the payout is to be made. If left blank, a payout instrument is automatically selected.</value>
        [DataMember(Name = "payoutMethodCode", EmitDefaultValue = false)]
        public string PayoutMethodCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayoutAccountHolderRequest {\n");
            sb.Append("  AccountCode: ").Append(AccountCode).Append("\n");
            sb.Append("  AccountHolderCode: ").Append(AccountHolderCode).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BankAccountUUID: ").Append(BankAccountUUID).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  PayoutMethodCode: ").Append(PayoutMethodCode).Append("\n");
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
            return this.Equals(input as PayoutAccountHolderRequest);
        }

        /// <summary>
        /// Returns true if PayoutAccountHolderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PayoutAccountHolderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayoutAccountHolderRequest input)
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
                    this.AccountHolderCode == input.AccountHolderCode ||
                    (this.AccountHolderCode != null &&
                    this.AccountHolderCode.Equals(input.AccountHolderCode))
                ) &&
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) &&
                (
                    this.BankAccountUUID == input.BankAccountUUID ||
                    (this.BankAccountUUID != null &&
                    this.BankAccountUUID.Equals(input.BankAccountUUID))
                ) &&
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) &&
                (
                    this.MerchantReference == input.MerchantReference ||
                    (this.MerchantReference != null &&
                    this.MerchantReference.Equals(input.MerchantReference))
                ) &&
                (
                    this.PayoutMethodCode == input.PayoutMethodCode ||
                    (this.PayoutMethodCode != null &&
                    this.PayoutMethodCode.Equals(input.PayoutMethodCode))
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
                if (this.AccountHolderCode != null)
                    hashCode = hashCode * 59 + this.AccountHolderCode.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.BankAccountUUID != null)
                    hashCode = hashCode * 59 + this.BankAccountUUID.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.MerchantReference != null)
                    hashCode = hashCode * 59 + this.MerchantReference.GetHashCode();
                if (this.PayoutMethodCode != null)
                    hashCode = hashCode * 59 + this.PayoutMethodCode.GetHashCode();
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
