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
    /// GetUploadedDocumentsRequest
    /// </summary>
    [DataContract]
        public partial class GetUploadedDocumentsRequest :  IEquatable<GetUploadedDocumentsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUploadedDocumentsRequest" /> class.
        /// </summary>
        /// <param name="accountHolderCode">The code of the Account Holder for which to retrieve the documents. (required).</param>
        /// <param name="bankAccountUUID">The code of the Bank Account for which to retrieve the documents..</param>
        /// <param name="shareholderCode">The code of the Shareholder for which to retrieve the documents..</param>
        public GetUploadedDocumentsRequest(string accountHolderCode = default(string), string bankAccountUUID = default(string), string shareholderCode = default(string))
        {
            // to ensure "accountHolderCode" is required (not null)
            if (accountHolderCode == null)
            {
                throw new InvalidDataException("accountHolderCode is a required property for GetUploadedDocumentsRequest and cannot be null");
            }
            else
            {
                this.AccountHolderCode = accountHolderCode;
            }
            this.BankAccountUUID = bankAccountUUID;
            this.ShareholderCode = shareholderCode;
        }
        
        /// <summary>
        /// The code of the Account Holder for which to retrieve the documents.
        /// </summary>
        /// <value>The code of the Account Holder for which to retrieve the documents.</value>
        [DataMember(Name="accountHolderCode", EmitDefaultValue=false)]
        public string AccountHolderCode { get; set; }

        /// <summary>
        /// The code of the Bank Account for which to retrieve the documents.
        /// </summary>
        /// <value>The code of the Bank Account for which to retrieve the documents.</value>
        [DataMember(Name="bankAccountUUID", EmitDefaultValue=false)]
        public string BankAccountUUID { get; set; }

        /// <summary>
        /// The code of the Shareholder for which to retrieve the documents.
        /// </summary>
        /// <value>The code of the Shareholder for which to retrieve the documents.</value>
        [DataMember(Name="shareholderCode", EmitDefaultValue=false)]
        public string ShareholderCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetUploadedDocumentsRequest {\n");
            sb.Append("  AccountHolderCode: ").Append(AccountHolderCode).Append("\n");
            sb.Append("  BankAccountUUID: ").Append(BankAccountUUID).Append("\n");
            sb.Append("  ShareholderCode: ").Append(ShareholderCode).Append("\n");
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
            return this.Equals(input as GetUploadedDocumentsRequest);
        }

        /// <summary>
        /// Returns true if GetUploadedDocumentsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetUploadedDocumentsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetUploadedDocumentsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountHolderCode == input.AccountHolderCode ||
                    (this.AccountHolderCode != null &&
                    this.AccountHolderCode.Equals(input.AccountHolderCode))
                ) && 
                (
                    this.BankAccountUUID == input.BankAccountUUID ||
                    (this.BankAccountUUID != null &&
                    this.BankAccountUUID.Equals(input.BankAccountUUID))
                ) && 
                (
                    this.ShareholderCode == input.ShareholderCode ||
                    (this.ShareholderCode != null &&
                    this.ShareholderCode.Equals(input.ShareholderCode))
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
                if (this.AccountHolderCode != null)
                    hashCode = hashCode * 59 + this.AccountHolderCode.GetHashCode();
                if (this.BankAccountUUID != null)
                    hashCode = hashCode * 59 + this.BankAccountUUID.GetHashCode();
                if (this.ShareholderCode != null)
                    hashCode = hashCode * 59 + this.ShareholderCode.GetHashCode();
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
