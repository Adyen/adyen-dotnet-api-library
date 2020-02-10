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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// DeleteShareholderRequest
    /// </summary>
    [DataContract]
        public partial class DeleteShareholderRequest :  IEquatable<DeleteShareholderRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteShareholderRequest" /> class.
        /// </summary>
        /// <param name="accountHolderCode">The code of the Account Holder from which to delete the Shareholders. (required).</param>
        /// <param name="shareholderCodes">The code(s) of the Shareholders to be deleted. (required).</param>
        public DeleteShareholderRequest(string accountHolderCode = default(string), List<string> shareholderCodes = default(List<string>))
        {
            // to ensure "accountHolderCode" is required (not null)
            if (accountHolderCode == null)
            {
                throw new InvalidDataException("accountHolderCode is a required property for DeleteShareholderRequest and cannot be null");
            }
            else
            {
                this.AccountHolderCode = accountHolderCode;
            }
            // to ensure "shareholderCodes" is required (not null)
            if (shareholderCodes == null)
            {
                throw new InvalidDataException("shareholderCodes is a required property for DeleteShareholderRequest and cannot be null");
            }
            else
            {
                this.ShareholderCodes = shareholderCodes;
            }
        }
        
        /// <summary>
        /// The code of the Account Holder from which to delete the Shareholders.
        /// </summary>
        /// <value>The code of the Account Holder from which to delete the Shareholders.</value>
        [DataMember(Name="accountHolderCode", EmitDefaultValue=false)]
        public string AccountHolderCode { get; set; }

        /// <summary>
        /// The code(s) of the Shareholders to be deleted.
        /// </summary>
        /// <value>The code(s) of the Shareholders to be deleted.</value>
        [DataMember(Name="shareholderCodes", EmitDefaultValue=false)]
        public List<string> ShareholderCodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteShareholderRequest {\n");
            sb.Append("  AccountHolderCode: ").Append(AccountHolderCode).Append("\n");
            sb.Append("  ShareholderCodes: ").Append(ShareholderCodes).Append("\n");
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
            return this.Equals(input as DeleteShareholderRequest);
        }

        /// <summary>
        /// Returns true if DeleteShareholderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteShareholderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteShareholderRequest input)
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
                    this.ShareholderCodes == input.ShareholderCodes ||
                    this.ShareholderCodes != null &&
                    input.ShareholderCodes != null &&
                    this.ShareholderCodes.SequenceEqual(input.ShareholderCodes)
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
                if (this.ShareholderCodes != null)
                    hashCode = hashCode * 59 + this.ShareholderCodes.GetHashCode();
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
