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
using Newtonsoft.Json.Converters;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// DocumentDetail
    /// </summary>
    [DataContract]
        public partial class DocumentDetail :  IEquatable<DocumentDetail>, IValidatableObject
    {
        /// <summary>
        /// The type of a document. Permitted values: * &#x60;BANK_STATEMENT&#x60; denotes an image containing a bank statement or other document proving ownership of a specific bank account. * &#x60;PASSPORT&#x60; denotes an image containing the identity page(s) of a passport. * &#x60;ID_CARD_FRONT&#x60; denotes an image containing only the front of the ID card. In order for a document to be usable, both the &#x60;ID_CARD_FRONT&#x60; and &#x60;ID_CARD_BACK&#x60; must be submitted. * &#x60;ID_CARD_BACK&#x60; denotes an image containing only the back of the ID card. In order for a document to be usable, both the &#x60;ID_CARD_FRONT&#x60; and &#x60;ID_CARD_BACK&#x60; must be submitted. * &#x60;DRIVING_LICENCE_FRONT&#x60; denotes an image containing only the front of the driving licence. In order for a document to be usable, both the &#x60;DRIVING_LICENCE_FRONT&#x60; and &#x60;DRIVING_LICENCE_BACK&#x60; must be submitted. * &#x60;DRIVING_LICENCE_BACK&#x60; denotes an image containing only the back of the driving licence. In order for a document to be usable, both the &#x60;DRIVING_LICENCE_FRONT&#x60; and &#x60;DRIVING_LICENCE_FRONT&#x60; must be submitted.  &gt;Please refer to [Verification checks](https://docs.adyen.com/marketpay/onboarding-and-verification/verification-checks) for details on when each document type should be submitted.
        /// </summary>
        /// <value>The type of a document. Permitted values: * &#x60;BANK_STATEMENT&#x60; denotes an image containing a bank statement or other document proving ownership of a specific bank account. * &#x60;PASSPORT&#x60; denotes an image containing the identity page(s) of a passport. * &#x60;ID_CARD_FRONT&#x60; denotes an image containing only the front of the ID card. In order for a document to be usable, both the &#x60;ID_CARD_FRONT&#x60; and &#x60;ID_CARD_BACK&#x60; must be submitted. * &#x60;ID_CARD_BACK&#x60; denotes an image containing only the back of the ID card. In order for a document to be usable, both the &#x60;ID_CARD_FRONT&#x60; and &#x60;ID_CARD_BACK&#x60; must be submitted. * &#x60;DRIVING_LICENCE_FRONT&#x60; denotes an image containing only the front of the driving licence. In order for a document to be usable, both the &#x60;DRIVING_LICENCE_FRONT&#x60; and &#x60;DRIVING_LICENCE_BACK&#x60; must be submitted. * &#x60;DRIVING_LICENCE_BACK&#x60; denotes an image containing only the back of the driving licence. In order for a document to be usable, both the &#x60;DRIVING_LICENCE_FRONT&#x60; and &#x60;DRIVING_LICENCE_FRONT&#x60; must be submitted.  &gt;Please refer to [Verification checks](https://docs.adyen.com/marketpay/onboarding-and-verification/verification-checks) for details on when each document type should be submitted.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum DocumentTypeEnum
        {
            /// <summary>
            /// Enum BANKSTATEMENT for value: BANK_STATEMENT
            /// </summary>
            [EnumMember(Value = "BANK_STATEMENT")]
            BANKSTATEMENT = 1,
            /// <summary>
            /// Enum BSN for value: BSN
            /// </summary>
            [EnumMember(Value = "BSN")]
            BSN = 2,
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
            [EnumMember(Value = "ID_CARD")]
            IDCARD = 7,
            /// <summary>
            /// Enum IDCARDBACK for value: ID_CARD_BACK
            /// </summary>
            [EnumMember(Value = "ID_CARD_BACK")]
            IDCARDBACK = 8,
            /// <summary>
            /// Enum IDCARDFRONT for value: ID_CARD_FRONT
            /// </summary>
            [EnumMember(Value = "ID_CARD_FRONT")]
            IDCARDFRONT = 9,
            /// <summary>
            /// Enum PASSPORT for value: PASSPORT
            /// </summary>
            [EnumMember(Value = "PASSPORT")]
            PASSPORT = 10,
            /// <summary>
            /// Enum SSN for value: SSN
            /// </summary>
            [EnumMember(Value = "SSN")]
            SSN = 11,
            /// <summary>
            /// Enum SUPPORTINGDOCUMENTS for value: SUPPORTING_DOCUMENTS
            /// </summary>
            [EnumMember(Value = "SUPPORTING_DOCUMENTS")]
            SUPPORTINGDOCUMENTS = 12        }
        /// <summary>
        /// The type of a document. Permitted values: * &#x60;BANK_STATEMENT&#x60; denotes an image containing a bank statement or other document proving ownership of a specific bank account. * &#x60;PASSPORT&#x60; denotes an image containing the identity page(s) of a passport. * &#x60;ID_CARD_FRONT&#x60; denotes an image containing only the front of the ID card. In order for a document to be usable, both the &#x60;ID_CARD_FRONT&#x60; and &#x60;ID_CARD_BACK&#x60; must be submitted. * &#x60;ID_CARD_BACK&#x60; denotes an image containing only the back of the ID card. In order for a document to be usable, both the &#x60;ID_CARD_FRONT&#x60; and &#x60;ID_CARD_BACK&#x60; must be submitted. * &#x60;DRIVING_LICENCE_FRONT&#x60; denotes an image containing only the front of the driving licence. In order for a document to be usable, both the &#x60;DRIVING_LICENCE_FRONT&#x60; and &#x60;DRIVING_LICENCE_BACK&#x60; must be submitted. * &#x60;DRIVING_LICENCE_BACK&#x60; denotes an image containing only the back of the driving licence. In order for a document to be usable, both the &#x60;DRIVING_LICENCE_FRONT&#x60; and &#x60;DRIVING_LICENCE_FRONT&#x60; must be submitted.  &gt;Please refer to [Verification checks](https://docs.adyen.com/marketpay/onboarding-and-verification/verification-checks) for details on when each document type should be submitted.
        /// </summary>
        /// <value>The type of a document. Permitted values: * &#x60;BANK_STATEMENT&#x60; denotes an image containing a bank statement or other document proving ownership of a specific bank account. * &#x60;PASSPORT&#x60; denotes an image containing the identity page(s) of a passport. * &#x60;ID_CARD_FRONT&#x60; denotes an image containing only the front of the ID card. In order for a document to be usable, both the &#x60;ID_CARD_FRONT&#x60; and &#x60;ID_CARD_BACK&#x60; must be submitted. * &#x60;ID_CARD_BACK&#x60; denotes an image containing only the back of the ID card. In order for a document to be usable, both the &#x60;ID_CARD_FRONT&#x60; and &#x60;ID_CARD_BACK&#x60; must be submitted. * &#x60;DRIVING_LICENCE_FRONT&#x60; denotes an image containing only the front of the driving licence. In order for a document to be usable, both the &#x60;DRIVING_LICENCE_FRONT&#x60; and &#x60;DRIVING_LICENCE_BACK&#x60; must be submitted. * &#x60;DRIVING_LICENCE_BACK&#x60; denotes an image containing only the back of the driving licence. In order for a document to be usable, both the &#x60;DRIVING_LICENCE_FRONT&#x60; and &#x60;DRIVING_LICENCE_FRONT&#x60; must be submitted.  &gt;Please refer to [Verification checks](https://docs.adyen.com/marketpay/onboarding-and-verification/verification-checks) for details on when each document type should be submitted.</value>
        [DataMember(Name="documentType", EmitDefaultValue=false)]
        public DocumentTypeEnum DocumentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentDetail" /> class.
        /// </summary>
        /// <param name="accountHolderCode">The code of account holder, to which the document applies. (required).</param>
        /// <param name="bankAccountUUID">The unique ID of the Bank Account to which the document applies. &gt;Required if the documentType is &#x60;BANK_STATEMENT&#x60; (i.e., a document is being submitted in order to verify a bank account).  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on when a document should be submitted in order to verify a bank account..</param>
        /// <param name="description">Description of the document..</param>
        /// <param name="documentType">The type of a document. Permitted values: * &#x60;BANK_STATEMENT&#x60; denotes an image containing a bank statement or other document proving ownership of a specific bank account. * &#x60;PASSPORT&#x60; denotes an image containing the identity page(s) of a passport. * &#x60;ID_CARD_FRONT&#x60; denotes an image containing only the front of the ID card. In order for a document to be usable, both the &#x60;ID_CARD_FRONT&#x60; and &#x60;ID_CARD_BACK&#x60; must be submitted. * &#x60;ID_CARD_BACK&#x60; denotes an image containing only the back of the ID card. In order for a document to be usable, both the &#x60;ID_CARD_FRONT&#x60; and &#x60;ID_CARD_BACK&#x60; must be submitted. * &#x60;DRIVING_LICENCE_FRONT&#x60; denotes an image containing only the front of the driving licence. In order for a document to be usable, both the &#x60;DRIVING_LICENCE_FRONT&#x60; and &#x60;DRIVING_LICENCE_BACK&#x60; must be submitted. * &#x60;DRIVING_LICENCE_BACK&#x60; denotes an image containing only the back of the driving licence. In order for a document to be usable, both the &#x60;DRIVING_LICENCE_FRONT&#x60; and &#x60;DRIVING_LICENCE_FRONT&#x60; must be submitted.  &gt;Please refer to [Verification checks](https://docs.adyen.com/marketpay/onboarding-and-verification/verification-checks) for details on when each document type should be submitted. (required).</param>
        /// <param name="filename">Filename of the document. (required).</param>
        /// <param name="shareholderCode">The code of the shareholder, to which the document applies. &gt;Required if the account holder referred to by the &#x60;accountHolderCode&#x60; has a &#x60;legalEntity&#x60; of type &#x60;Business&#x60; and the &#x60;documentType&#x60; is either &#x60;PASSPORT&#x60;, &#x60;ID_CARD_FRONT&#x60;, &#x60;ID_CARD_BACK&#x60;, &#x60;DRIVING_LICENCE_FRONT&#x60;, &#x60;DRIVING_LICENCE_BACK&#x60; (i.e. a document is being submitted in order to verify a shareholder).  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on when a document should be submitted in order to verify a shareholder..</param>
        public DocumentDetail(string accountHolderCode = default(string), string bankAccountUUID = default(string), string description = default(string), DocumentTypeEnum documentType = default(DocumentTypeEnum), string filename = default(string), string shareholderCode = default(string))
        {
            // to ensure "accountHolderCode" is required (not null)
            if (accountHolderCode == null)
            {
                throw new InvalidDataException("accountHolderCode is a required property for DocumentDetail and cannot be null");
            }
            else
            {
                this.AccountHolderCode = accountHolderCode;
            }
            
            // to ensure "filename" is required (not null)
            if (filename == null)
            {
                throw new InvalidDataException("filename is a required property for DocumentDetail and cannot be null");
            }
            else
            {
                this.Filename = filename;
            }
            this.DocumentType = documentType;
            this.Filename = filename;
            this.BankAccountUUID = bankAccountUUID;
            this.Description = description;
            this.ShareholderCode = shareholderCode;
        }
        
        /// <summary>
        /// The code of account holder, to which the document applies.
        /// </summary>
        /// <value>The code of account holder, to which the document applies.</value>
        [DataMember(Name="accountHolderCode", EmitDefaultValue=false)]
        public string AccountHolderCode { get; set; }

        /// <summary>
        /// The unique ID of the Bank Account to which the document applies. &gt;Required if the documentType is &#x60;BANK_STATEMENT&#x60; (i.e., a document is being submitted in order to verify a bank account).  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on when a document should be submitted in order to verify a bank account.
        /// </summary>
        /// <value>The unique ID of the Bank Account to which the document applies. &gt;Required if the documentType is &#x60;BANK_STATEMENT&#x60; (i.e., a document is being submitted in order to verify a bank account).  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on when a document should be submitted in order to verify a bank account.</value>
        [DataMember(Name="bankAccountUUID", EmitDefaultValue=false)]
        public string BankAccountUUID { get; set; }

        /// <summary>
        /// Description of the document.
        /// </summary>
        /// <value>Description of the document.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }


        /// <summary>
        /// Filename of the document.
        /// </summary>
        /// <value>Filename of the document.</value>
        [DataMember(Name="filename", EmitDefaultValue=false)]
        public string Filename { get; set; }

        /// <summary>
        /// The code of the shareholder, to which the document applies. &gt;Required if the account holder referred to by the &#x60;accountHolderCode&#x60; has a &#x60;legalEntity&#x60; of type &#x60;Business&#x60; and the &#x60;documentType&#x60; is either &#x60;PASSPORT&#x60;, &#x60;ID_CARD_FRONT&#x60;, &#x60;ID_CARD_BACK&#x60;, &#x60;DRIVING_LICENCE_FRONT&#x60;, &#x60;DRIVING_LICENCE_BACK&#x60; (i.e. a document is being submitted in order to verify a shareholder).  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on when a document should be submitted in order to verify a shareholder.
        /// </summary>
        /// <value>The code of the shareholder, to which the document applies. &gt;Required if the account holder referred to by the &#x60;accountHolderCode&#x60; has a &#x60;legalEntity&#x60; of type &#x60;Business&#x60; and the &#x60;documentType&#x60; is either &#x60;PASSPORT&#x60;, &#x60;ID_CARD_FRONT&#x60;, &#x60;ID_CARD_BACK&#x60;, &#x60;DRIVING_LICENCE_FRONT&#x60;, &#x60;DRIVING_LICENCE_BACK&#x60; (i.e. a document is being submitted in order to verify a shareholder).  &gt;Refer to the [Onboarding and verification](https://docs.adyen.com/marketpay/onboarding-and-verification) section for details on when a document should be submitted in order to verify a shareholder.</value>
        [DataMember(Name="shareholderCode", EmitDefaultValue=false)]
        public string ShareholderCode { get; set; }

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
            return this.Equals(input as DocumentDetail);
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DocumentType == input.DocumentType ||
                    this.DocumentType.Equals(input.DocumentType)
                ) && 
                (
                    this.Filename == input.Filename ||
                    (this.Filename != null &&
                    this.Filename.Equals(input.Filename))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.DocumentType.GetHashCode();
                if (this.Filename != null)
                    hashCode = hashCode * 59 + this.Filename.GetHashCode();
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
