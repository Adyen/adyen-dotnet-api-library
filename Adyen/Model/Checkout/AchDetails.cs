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
    /// AchDetails
    /// </summary>
    [DataContract]
    public partial class AchDetails : IEquatable<AchDetails>, IValidatableObject, IPaymentMethodDetails
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="AchDetails" /> class.
        /// </summary>
        /// <param name="bankAccountNumber">The bank account number (without separators). (required).</param>
        /// <param name="bankLocationId">The bank routing number of the account. The field value is &#x60;nil&#x60; in most cases..</param>
        /// <param name="encryptedBankAccountNumber">Encrypted bank account number. The bank account number (without separators)..</param>
        /// <param name="encryptedBankLocationId">Encrypted location id. The bank routing number of the account. The field value is &#x60;nil&#x60; in most cases..</param>
        /// <param name="ownerName">The name of the bank account holder. If you submit a name with non-Latin characters, we automatically replace some of them with corresponding Latin characters to meet the FATF recommendations. For example: * χ12 is converted to ch12. * üA is converted to euA. * Peter Møller is converted to Peter Mller, because banks don&#x27;t accept &#x27;ø&#x27;. After replacement, the ownerName must have at least three alphanumeric characters (A-Z, a-z, 0-9), and at least one of them must be a valid Latin character (A-Z, a-z). For example: * John17 - allowed. * J17 - allowed. * 171 - not allowed. * John-7 - allowed. &gt; If provided details don&#x27;t match the required format, the response returns the error message: 203 &#x27;Invalid bank account holder name&#x27;..</param>
        /// <param name="recurringDetailReference">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
        /// <param name="storedPaymentMethodId">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
        /// <param name="type">**ach** (default to &quot;ach&quot;).</param>
        public AchDetails(string bankAccountNumber = default(string), string bankLocationId = default(string), string encryptedBankAccountNumber = default(string), string encryptedBankLocationId = default(string), string ownerName = default(string), string recurringDetailReference = default(string), string storedPaymentMethodId = default(string), string type = "ach")
        {
            // to ensure "bankAccountNumber" is required (not null)
            if (bankAccountNumber == null)
            {
                throw new InvalidDataException("bankAccountNumber is a required property for AchDetails and cannot be null");
            }
            else
            {
                this.BankAccountNumber = bankAccountNumber;
            }
            this.BankLocationId = bankLocationId;
            this.EncryptedBankAccountNumber = encryptedBankAccountNumber;
            this.EncryptedBankLocationId = encryptedBankLocationId;
            this.OwnerName = ownerName;
            this.RecurringDetailReference = recurringDetailReference;
            this.StoredPaymentMethodId = storedPaymentMethodId;
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "ach";
            }
            else
            {
                this.Type = type;
            }
        }

        /// <summary>
        /// The bank account number (without separators).
        /// </summary>
        /// <value>The bank account number (without separators).</value>
        [DataMember(Name = "bankAccountNumber", EmitDefaultValue = false)]
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// The bank routing number of the account. The field value is &#x60;nil&#x60; in most cases.
        /// </summary>
        /// <value>The bank routing number of the account. The field value is &#x60;nil&#x60; in most cases.</value>
        [DataMember(Name = "bankLocationId", EmitDefaultValue = false)]
        public string BankLocationId { get; set; }

        /// <summary>
        /// Encrypted bank account number. The bank account number (without separators).
        /// </summary>
        /// <value>Encrypted bank account number. The bank account number (without separators).</value>
        [DataMember(Name = "encryptedBankAccountNumber", EmitDefaultValue = false)]
        public string EncryptedBankAccountNumber { get; set; }

        /// <summary>
        /// Encrypted location id. The bank routing number of the account. The field value is &#x60;nil&#x60; in most cases.
        /// </summary>
        /// <value>Encrypted location id. The bank routing number of the account. The field value is &#x60;nil&#x60; in most cases.</value>
        [DataMember(Name = "encryptedBankLocationId", EmitDefaultValue = false)]
        public string EncryptedBankLocationId { get; set; }

        /// <summary>
        /// The name of the bank account holder. If you submit a name with non-Latin characters, we automatically replace some of them with corresponding Latin characters to meet the FATF recommendations. For example: * χ12 is converted to ch12. * üA is converted to euA. * Peter Møller is converted to Peter Mller, because banks don&#x27;t accept &#x27;ø&#x27;. After replacement, the ownerName must have at least three alphanumeric characters (A-Z, a-z, 0-9), and at least one of them must be a valid Latin character (A-Z, a-z). For example: * John17 - allowed. * J17 - allowed. * 171 - not allowed. * John-7 - allowed. &gt; If provided details don&#x27;t match the required format, the response returns the error message: 203 &#x27;Invalid bank account holder name&#x27;.
        /// </summary>
        /// <value>The name of the bank account holder. If you submit a name with non-Latin characters, we automatically replace some of them with corresponding Latin characters to meet the FATF recommendations. For example: * χ12 is converted to ch12. * üA is converted to euA. * Peter Møller is converted to Peter Mller, because banks don&#x27;t accept &#x27;ø&#x27;. After replacement, the ownerName must have at least three alphanumeric characters (A-Z, a-z, 0-9), and at least one of them must be a valid Latin character (A-Z, a-z). For example: * John17 - allowed. * J17 - allowed. * 171 - not allowed. * John-7 - allowed. &gt; If provided details don&#x27;t match the required format, the response returns the error message: 203 &#x27;Invalid bank account holder name&#x27;.</value>
        [DataMember(Name = "ownerName", EmitDefaultValue = false)]
        public string OwnerName { get; set; }

        /// <summary>
        /// This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.
        /// </summary>
        /// <value>This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.</value>
        [DataMember(Name = "recurringDetailReference", EmitDefaultValue = false)]
        public string RecurringDetailReference { get; set; }

        /// <summary>
        /// This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.
        /// </summary>
        /// <value>This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.</value>
        [DataMember(Name = "storedPaymentMethodId", EmitDefaultValue = false)]
        public string StoredPaymentMethodId { get; set; }

        /// <summary>
        /// **ach**
        /// </summary>
        /// <value>**ach**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AchDetails {\n");
            sb.Append("  BankAccountNumber: ").Append(BankAccountNumber).Append("\n");
            sb.Append("  BankLocationId: ").Append(BankLocationId).Append("\n");
            sb.Append("  EncryptedBankAccountNumber: ").Append(EncryptedBankAccountNumber).Append("\n");
            sb.Append("  EncryptedBankLocationId: ").Append(EncryptedBankLocationId).Append("\n");
            sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
            sb.Append("  RecurringDetailReference: ").Append(RecurringDetailReference).Append("\n");
            sb.Append("  StoredPaymentMethodId: ").Append(StoredPaymentMethodId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as AchDetails);
        }

        /// <summary>
        /// Returns true if AchDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of AchDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AchDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    this.BankAccountNumber == input.BankAccountNumber ||
                    (this.BankAccountNumber != null &&
                    this.BankAccountNumber.Equals(input.BankAccountNumber))
                ) &&
                (
                    this.BankLocationId == input.BankLocationId ||
                    (this.BankLocationId != null &&
                    this.BankLocationId.Equals(input.BankLocationId))
                ) &&
                (
                    this.EncryptedBankAccountNumber == input.EncryptedBankAccountNumber ||
                    (this.EncryptedBankAccountNumber != null &&
                    this.EncryptedBankAccountNumber.Equals(input.EncryptedBankAccountNumber))
                ) &&
                (
                    this.EncryptedBankLocationId == input.EncryptedBankLocationId ||
                    (this.EncryptedBankLocationId != null &&
                    this.EncryptedBankLocationId.Equals(input.EncryptedBankLocationId))
                ) &&
                (
                    this.OwnerName == input.OwnerName ||
                    (this.OwnerName != null &&
                    this.OwnerName.Equals(input.OwnerName))
                ) &&
                (
                    this.RecurringDetailReference == input.RecurringDetailReference ||
                    (this.RecurringDetailReference != null &&
                    this.RecurringDetailReference.Equals(input.RecurringDetailReference))
                ) &&
                (
                    this.StoredPaymentMethodId == input.StoredPaymentMethodId ||
                    (this.StoredPaymentMethodId != null &&
                    this.StoredPaymentMethodId.Equals(input.StoredPaymentMethodId))
                ) &&
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.BankAccountNumber != null)
                    hashCode = hashCode * 59 + this.BankAccountNumber.GetHashCode();
                if (this.BankLocationId != null)
                    hashCode = hashCode * 59 + this.BankLocationId.GetHashCode();
                if (this.EncryptedBankAccountNumber != null)
                    hashCode = hashCode * 59 + this.EncryptedBankAccountNumber.GetHashCode();
                if (this.EncryptedBankLocationId != null)
                    hashCode = hashCode * 59 + this.EncryptedBankLocationId.GetHashCode();
                if (this.OwnerName != null)
                    hashCode = hashCode * 59 + this.OwnerName.GetHashCode();
                if (this.RecurringDetailReference != null)
                    hashCode = hashCode * 59 + this.RecurringDetailReference.GetHashCode();
                if (this.StoredPaymentMethodId != null)
                    hashCode = hashCode * 59 + this.StoredPaymentMethodId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
