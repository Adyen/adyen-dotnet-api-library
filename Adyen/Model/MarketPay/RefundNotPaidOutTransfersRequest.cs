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
    /// RefundNotPaidOutTransfersRequest
    /// </summary>
    [DataContract]
    public class RefundNotPaidOutTransfersRequest : IEquatable<RefundNotPaidOutTransfersRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundNotPaidOutTransfersRequest" /> class.
        /// </summary>
        /// <param name="accountCode">The code of the account from which to perform the refund(s). (required).</param>
        /// <param name="accountHolderCode">The code of the Account Holder which owns the account from which to perform the refund(s). (required).</param>
        public RefundNotPaidOutTransfersRequest(string accountCode = default(string), string accountHolderCode = default(string))
        {
            // to ensure "accountCode" is required (not null)
            if (accountCode == null)
            {
                throw new InvalidDataException("accountCode is a required property for RefundNotPaidOutTransfersRequest and cannot be null");
            }
            else
            {
                this.AccountCode = accountCode;
            }
            // to ensure "accountHolderCode" is required (not null)
            if (accountHolderCode == null)
            {
                throw new InvalidDataException("accountHolderCode is a required property for RefundNotPaidOutTransfersRequest and cannot be null");
            }
            else
            {
                this.AccountHolderCode = accountHolderCode;
            }
        }

        /// <summary>
        /// The code of the account from which to perform the refund(s).
        /// </summary>
        /// <value>The code of the account from which to perform the refund(s).</value>
        [DataMember(Name = "accountCode", EmitDefaultValue = false)]
        public string AccountCode { get; set; }

        /// <summary>
        /// The code of the Account Holder which owns the account from which to perform the refund(s).
        /// </summary>
        /// <value>The code of the Account Holder which owns the account from which to perform the refund(s).</value>
        [DataMember(Name = "accountHolderCode", EmitDefaultValue = false)]
        public string AccountHolderCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefundNotPaidOutTransfersRequest {\n");
            sb.Append("  AccountCode: ").Append(AccountCode).Append("\n");
            sb.Append("  AccountHolderCode: ").Append(AccountHolderCode).Append("\n");
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
            return this.Equals(input as RefundNotPaidOutTransfersRequest);
        }

        /// <summary>
        /// Returns true if RefundNotPaidOutTransfersRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RefundNotPaidOutTransfersRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefundNotPaidOutTransfersRequest input)
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
