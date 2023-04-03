using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// DocumentDetail
    /// </summary>
    [DataContract]
    public class DocumentDetail : IEquatable<DocumentDetail>, IValidatableObject
    {
        /// <summary>
        /// The type of the document. Refer to [Verification checks](https://docs.adyen.com/platforms/verification-checks) for details on when each document type should be submitted and for the accepted file formats.  Permitted values: * **BANK_STATEMENT**: A file containing a bank statement or other document proving ownership of a specific bank account. * **COMPANY_REGISTRATION_SCREENING** (Supported from v5 and later): A file containing a company registration document. * **CONSTITUTIONAL_DOCUMENT**: A file containing information about the account holder&#x27;s legal arrangement. * **PASSPORT**: A file containing the identity page(s) of a passport. * **ID_CARD_FRONT**: A file containing only the front of the ID card. In order for a document to be usable, both the **ID_CARD_FRONT** and **ID_CARD_BACK** must be submitted. * **ID_CARD_BACK**: A file containing only the back of the ID card. In order for a document to be usable, both the **ID_CARD_FRONT** and **ID_CARD_BACK** must be submitted. * **DRIVING_LICENCE_FRONT**: A file containing only the front of the driving licence. In order for a document to be usable, both the **DRIVING_LICENCE_FRONT** and **DRIVING_LICENCE_BACK** must be submitted. * **DRIVING_LICENCE_BACK**: A file containing only the back of the driving licence. In order for a document to be usable, both the **DRIVING_LICENCE_FRONT** and **DRIVING_LICENCE_FRONT** must be submitted. 
        /// </summary>
        /// <value>The type of the document. Refer to [Verification checks](https://docs.adyen.com/platforms/verification-checks) for details on when each document type should be submitted and for the accepted file formats.  Permitted values: * **BANK_STATEMENT**: A file containing a bank statement or other document proving ownership of a specific bank account. * **COMPANY_REGISTRATION_SCREENING** (Supported from v5 and later): A file containing a company registration document. * **CONSTITUTIONAL_DOCUMENT**: A file containing information about the account holder&#x27;s legal arrangement. * **PASSPORT**: A file containing the identity page(s) of a passport. * **ID_CARD_FRONT**: A file containing only the front of the ID card. In order for a document to be usable, both the **ID_CARD_FRONT** and **ID_CARD_BACK** must be submitted. * **ID_CARD_BACK**: A file containing only the back of the ID card. In order for a document to be usable, both the **ID_CARD_FRONT** and **ID_CARD_BACK** must be submitted. * **DRIVING_LICENCE_FRONT**: A file containing only the front of the driving licence. In order for a document to be usable, both the **DRIVING_LICENCE_FRONT** and **DRIVING_LICENCE_BACK** must be submitted. * **DRIVING_LICENCE_BACK**: A file containing only the back of the driving licence. In order for a document to be usable, both the **DRIVING_LICENCE_FRONT** and **DRIVING_LICENCE_FRONT** must be submitted. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DocumentTypeEnum
        {
            /// <summary>
            /// Enum BANKSTATEMENT for value: BANK_STATEMENT
            /// </summary>
            [EnumMember(Value = "BANK_STATEMENT")] BANKSTATEMENT = 1,

            /// <summary>
            /// Enum BSN for value: BSN
            /// </summary>
            [EnumMember(Value = "BSN")] BSN = 2,

            /// <summary>
            /// Enum COMPANYREGISTRATIONSCREENING for value: COMPANY_REGISTRATION_SCREENING
            /// </summary>
            [EnumMember(Value = "COMPANY_REGISTRATION_SCREENING")]
            COMPANYREGISTRATIONSCREENING = 3,

            /// <summary>
            /// Enum DRIVINGLICENCE for value: DRIVING_LICENCE
            /// </summary>
            [EnumMember(Value = "DRIVING_LICENCE")]
            DRIVINGLICENCE = 4,

            /// <summary>
            /// Enum DRIVINGLICENCEBACK for value: DRIVING_LICENCE_BACK
            /// </summary>
            [EnumMember(Value = "DRIVING_LICENCE_BACK")]
            DRIVINGLICENCEBACK = 5,

            /// <summary>
            /// Enum DRIVINGLICENCEFRONT for value: DRIVING_LICENCE_FRONT
            /// </summary>
            [EnumMember(Value = "DRIVING_LICENCE_FRONT")]
            DRIVINGLICENCEFRONT = 6,

            /// <summary>
            /// Enum IDCARD for value: ID_CARD
            /// </summary>
            [EnumMember(Value = "ID_CARD")] IDCARD = 7,

            /// <summary>
            /// Enum IDCARDBACK for value: ID_CARD_BACK
            /// </summary>
            [EnumMember(Value = "ID_CARD_BACK")] IDCARDBACK = 8,

            /// <summary>
            /// Enum IDCARDFRONT for value: ID_CARD_FRONT
            /// </summary>
            [EnumMember(Value = "ID_CARD_FRONT")] IDCARDFRONT = 9,

            /// <summary>
            /// Enum PASSPORT for value: PASSPORT
            /// </summary>
            [EnumMember(Value = "PASSPORT")] PASSPORT = 10,

            /// <summary>
            /// Enum SSN for value: SSN
            /// </summary>
            [EnumMember(Value = "SSN")] SSN = 11,

            /// <summary>
            /// Enum SUPPORTINGDOCUMENTS for value: SUPPORTING_DOCUMENTS
            /// </summary>
            [EnumMember(Value = "SUPPORTING_DOCUMENTS")]
            SUPPORTINGDOCUMENTS = 12
        }

        /// <summary>
        /// The type of the document. Refer to [Verification checks](https://docs.adyen.com/platforms/verification-checks) for details on when each document type should be submitted and for the accepted file formats.  Permitted values: * **BANK_STATEMENT**: A file containing a bank statement or other document proving ownership of a specific bank account. * **COMPANY_REGISTRATION_SCREENING** (Supported from v5 and later): A file containing a company registration document. * **CONSTITUTIONAL_DOCUMENT**: A file containing information about the account holder&#x27;s legal arrangement. * **PASSPORT**: A file containing the identity page(s) of a passport. * **ID_CARD_FRONT**: A file containing only the front of the ID card. In order for a document to be usable, both the **ID_CARD_FRONT** and **ID_CARD_BACK** must be submitted. * **ID_CARD_BACK**: A file containing only the back of the ID card. In order for a document to be usable, both the **ID_CARD_FRONT** and **ID_CARD_BACK** must be submitted. * **DRIVING_LICENCE_FRONT**: A file containing only the front of the driving licence. In order for a document to be usable, both the **DRIVING_LICENCE_FRONT** and **DRIVING_LICENCE_BACK** must be submitted. * **DRIVING_LICENCE_BACK**: A file containing only the back of the driving licence. In order for a document to be usable, both the **DRIVING_LICENCE_FRONT** and **DRIVING_LICENCE_FRONT** must be submitted. 
        /// </summary>
        /// <value>The type of the document. Refer to [Verification checks](https://docs.adyen.com/platforms/verification-checks) for details on when each document type should be submitted and for the accepted file formats.  Permitted values: * **BANK_STATEMENT**: A file containing a bank statement or other document proving ownership of a specific bank account. * **COMPANY_REGISTRATION_SCREENING** (Supported from v5 and later): A file containing a company registration document. * **CONSTITUTIONAL_DOCUMENT**: A file containing information about the account holder&#x27;s legal arrangement. * **PASSPORT**: A file containing the identity page(s) of a passport. * **ID_CARD_FRONT**: A file containing only the front of the ID card. In order for a document to be usable, both the **ID_CARD_FRONT** and **ID_CARD_BACK** must be submitted. * **ID_CARD_BACK**: A file containing only the back of the ID card. In order for a document to be usable, both the **ID_CARD_FRONT** and **ID_CARD_BACK** must be submitted. * **DRIVING_LICENCE_FRONT**: A file containing only the front of the driving licence. In order for a document to be usable, both the **DRIVING_LICENCE_FRONT** and **DRIVING_LICENCE_BACK** must be submitted. * **DRIVING_LICENCE_BACK**: A file containing only the back of the driving licence. In order for a document to be usable, both the **DRIVING_LICENCE_FRONT** and **DRIVING_LICENCE_FRONT** must be submitted. </value>
        [DataMember(Name = "documentType", EmitDefaultValue = false)]
        public DocumentTypeEnum DocumentType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentDetail" /> class.
        /// </summary>
        /// <param name="accountHolderCode">The code of account holder, to which the document applies. (required).</param>
        /// <param name="bankAccountUUID">The Adyen-generated [&#x60;bankAccountUUID&#x60;](https://docs.adyen.com/api-explorer/#/Account/latest/post/createAccountHolder__resParam_accountHolderDetails-bankAccountDetails-bankAccountUUID) to which the document must be linked. Refer to [Bank account check](https://docs.adyen.com/platforms/verification-checks/bank-account-check#uploading-a-bank-statement) for details on when a document should be submitted. &gt;Required if the &#x60;documentType&#x60; is **BANK_STATEMENT**, where a document is being submitted in order to verify a bank account. .</param>
        /// <param name="description">Description of the document..</param>
        /// <param name="documentType">The type of the document. Refer to [Verification checks](https://docs.adyen.com/platforms/verification-checks) for details on when each document type should be submitted and for the accepted file formats.  Permitted values: * **BANK_STATEMENT**: A file containing a bank statement or other document proving ownership of a specific bank account. * **COMPANY_REGISTRATION_SCREENING** (Supported from v5 and later): A file containing a company registration document. * **CONSTITUTIONAL_DOCUMENT**: A file containing information about the account holder&#x27;s legal arrangement. * **PASSPORT**: A file containing the identity page(s) of a passport. * **ID_CARD_FRONT**: A file containing only the front of the ID card. In order for a document to be usable, both the **ID_CARD_FRONT** and **ID_CARD_BACK** must be submitted. * **ID_CARD_BACK**: A file containing only the back of the ID card. In order for a document to be usable, both the **ID_CARD_FRONT** and **ID_CARD_BACK** must be submitted. * **DRIVING_LICENCE_FRONT**: A file containing only the front of the driving licence. In order for a document to be usable, both the **DRIVING_LICENCE_FRONT** and **DRIVING_LICENCE_BACK** must be submitted. * **DRIVING_LICENCE_BACK**: A file containing only the back of the driving licence. In order for a document to be usable, both the **DRIVING_LICENCE_FRONT** and **DRIVING_LICENCE_FRONT** must be submitted.  (required).</param>
        /// <param name="filename">Filename of the document. (required).</param>
        /// <param name="shareholderCode">The Adyen-generated [&#x60;shareholderCode&#x60;](https://docs.adyen.com/api-explorer/#/Account/latest/post/createAccountHolder__resParam_accountHolderDetails-businessDetails-shareholders-shareholderCode) to which the document must be linked. Refer to [Verification checks](https://docs.adyen.com/platforms/verification-checks) for details on when a document should be submitted. &gt;Required if the account holder has a &#x60;legalEntity&#x60; of type **Business** and the &#x60;documentType&#x60; is either **PASSPORT**, **ID_CARD_FRONT**, **ID_CARD_BACK**, **DRIVING_LICENCE_FRONT**, or **DRIVING_LICENCE_BACK**. .</param>
        /// <param name="signatoryCode">The Adyen-generated [&#x60;signatoryCode&#x60;](https://docs.adyen.com/api-explorer/#/Account/v6/post/createAccountHolder__resParam_accountHolderDetails-businessDetails-signatories-signatoryCode) to which the document must be linked..</param>
        public DocumentDetail(string accountHolderCode = default(string), string bankAccountUUID = default(string),
            string description = default(string), DocumentTypeEnum documentType = default(DocumentTypeEnum),
            string filename = default(string), string shareholderCode = default(string),
            string signatoryCode = default(string))
        {
            // to ensure "accountHolderCode" is required (not null)
            if (accountHolderCode == null)
            {
                throw new InvalidDataException(
                    "accountHolderCode is a required property for DocumentDetail and cannot be null");
            }

            AccountHolderCode = accountHolderCode;

            // to ensure "documentType" is required (not null)
            if (documentType == null)
            {
                throw new InvalidDataException(
                    "documentType is a required property for DocumentDetail and cannot be null");
            }

            DocumentType = documentType;

            // to ensure "filename" is required (not null)
            if (filename == null)
            {
                throw new InvalidDataException("filename is a required property for DocumentDetail and cannot be null");
            }

            Filename = filename;

            BankAccountUUID = bankAccountUUID;
            Description = description;
            ShareholderCode = shareholderCode;
            SignatoryCode = signatoryCode;
        }

        /// <summary>
        /// The code of account holder, to which the document applies.
        /// </summary>
        /// <value>The code of account holder, to which the document applies.</value>
        [DataMember(Name = "accountHolderCode", EmitDefaultValue = false)]
        public string AccountHolderCode { get; set; }

        /// <summary>
        /// The Adyen-generated [&#x60;bankAccountUUID&#x60;](https://docs.adyen.com/api-explorer/#/Account/latest/post/createAccountHolder__resParam_accountHolderDetails-bankAccountDetails-bankAccountUUID) to which the document must be linked. Refer to [Bank account check](https://docs.adyen.com/platforms/verification-checks/bank-account-check#uploading-a-bank-statement) for details on when a document should be submitted. &gt;Required if the &#x60;documentType&#x60; is **BANK_STATEMENT**, where a document is being submitted in order to verify a bank account. 
        /// </summary>
        /// <value>The Adyen-generated [&#x60;bankAccountUUID&#x60;](https://docs.adyen.com/api-explorer/#/Account/latest/post/createAccountHolder__resParam_accountHolderDetails-bankAccountDetails-bankAccountUUID) to which the document must be linked. Refer to [Bank account check](https://docs.adyen.com/platforms/verification-checks/bank-account-check#uploading-a-bank-statement) for details on when a document should be submitted. &gt;Required if the &#x60;documentType&#x60; is **BANK_STATEMENT**, where a document is being submitted in order to verify a bank account. </value>
        [DataMember(Name = "bankAccountUUID", EmitDefaultValue = false)]
        public string BankAccountUUID { get; set; }

        /// <summary>
        /// Description of the document.
        /// </summary>
        /// <value>Description of the document.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }


        /// <summary>
        /// Filename of the document.
        /// </summary>
        /// <value>Filename of the document.</value>
        [DataMember(Name = "filename", EmitDefaultValue = false)]
        public string Filename { get; set; }

        /// <summary>
        /// The Adyen-generated [&#x60;shareholderCode&#x60;](https://docs.adyen.com/api-explorer/#/Account/latest/post/createAccountHolder__resParam_accountHolderDetails-businessDetails-shareholders-shareholderCode) to which the document must be linked. Refer to [Verification checks](https://docs.adyen.com/platforms/verification-checks) for details on when a document should be submitted. &gt;Required if the account holder has a &#x60;legalEntity&#x60; of type **Business** and the &#x60;documentType&#x60; is either **PASSPORT**, **ID_CARD_FRONT**, **ID_CARD_BACK**, **DRIVING_LICENCE_FRONT**, or **DRIVING_LICENCE_BACK**. 
        /// </summary>
        /// <value>The Adyen-generated [&#x60;shareholderCode&#x60;](https://docs.adyen.com/api-explorer/#/Account/latest/post/createAccountHolder__resParam_accountHolderDetails-businessDetails-shareholders-shareholderCode) to which the document must be linked. Refer to [Verification checks](https://docs.adyen.com/platforms/verification-checks) for details on when a document should be submitted. &gt;Required if the account holder has a &#x60;legalEntity&#x60; of type **Business** and the &#x60;documentType&#x60; is either **PASSPORT**, **ID_CARD_FRONT**, **ID_CARD_BACK**, **DRIVING_LICENCE_FRONT**, or **DRIVING_LICENCE_BACK**. </value>
        [DataMember(Name = "shareholderCode", EmitDefaultValue = false)]
        public string ShareholderCode { get; set; }

        /// <summary>
        /// The Adyen-generated [&#x60;signatoryCode&#x60;](https://docs.adyen.com/api-explorer/#/Account/v6/post/createAccountHolder__resParam_accountHolderDetails-businessDetails-signatories-signatoryCode) to which the document must be linked.
        /// </summary>
        /// <value>The Adyen-generated [&#x60;signatoryCode&#x60;](https://docs.adyen.com/api-explorer/#/Account/v6/post/createAccountHolder__resParam_accountHolderDetails-businessDetails-signatories-signatoryCode) to which the document must be linked.</value>
        [DataMember(Name = "signatoryCode", EmitDefaultValue = false)]
        public string SignatoryCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentDetail {\n");
            sb.Append("  AccountHolderCode: ").Append(AccountHolderCode).Append("\n");
            sb.Append("  BankAccountUUID: ").Append(BankAccountUUID).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  ShareholderCode: ").Append(ShareholderCode).Append("\n");
            sb.Append("  SignatoryCode: ").Append(SignatoryCode).Append("\n");
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
            return Equals(input as DocumentDetail);
        }

        /// <summary>
        /// Returns true if DocumentDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentDetail input)
        {
            if (input == null)
                return false;

            return
                (
                    AccountHolderCode == input.AccountHolderCode ||
                    (AccountHolderCode != null &&
                     AccountHolderCode.Equals(input.AccountHolderCode))
                ) &&
                (
                    BankAccountUUID == input.BankAccountUUID ||
                    (BankAccountUUID != null &&
                     BankAccountUUID.Equals(input.BankAccountUUID))
                ) &&
                (
                    Description == input.Description ||
                    (Description != null &&
                     Description.Equals(input.Description))
                ) &&
                (
                    DocumentType == input.DocumentType ||
                    (DocumentType != null &&
                     DocumentType.Equals(input.DocumentType))
                ) &&
                (
                    Filename == input.Filename ||
                    (Filename != null &&
                     Filename.Equals(input.Filename))
                ) &&
                (
                    ShareholderCode == input.ShareholderCode ||
                    (ShareholderCode != null &&
                     ShareholderCode.Equals(input.ShareholderCode))
                ) &&
                (
                    SignatoryCode == input.SignatoryCode ||
                    (SignatoryCode != null &&
                     SignatoryCode.Equals(input.SignatoryCode))
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
                if (AccountHolderCode != null)
                    hashCode = hashCode * 59 + AccountHolderCode.GetHashCode();
                if (BankAccountUUID != null)
                    hashCode = hashCode * 59 + BankAccountUUID.GetHashCode();
                if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                if (DocumentType != null)
                    hashCode = hashCode * 59 + DocumentType.GetHashCode();
                if (Filename != null)
                    hashCode = hashCode * 59 + Filename.GetHashCode();
                if (ShareholderCode != null)
                    hashCode = hashCode * 59 + ShareholderCode.GetHashCode();
                if (SignatoryCode != null)
                    hashCode = hashCode * 59 + SignatoryCode.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(
            ValidationContext validationContext)
        {
            yield break;
        }
    }
}