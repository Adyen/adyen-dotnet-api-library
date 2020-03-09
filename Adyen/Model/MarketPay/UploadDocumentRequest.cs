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
    /// UploadDocumentRequest
    /// </summary>
    [DataContract]
        public partial class UploadDocumentRequest :  IEquatable<UploadDocumentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadDocumentRequest" /> class.
        /// </summary>
        /// <param name="documentContent">The content of the document as represented by a Base64-encoded string.  To learn about requirements, see [Bank account check](https://docs.adyen.com/marketpay/onboarding-and-verification/verification-checks/bank-account-check#requirements) and [Photo ID check](https://docs.adyen.com/marketpay/onboarding-and-verification/verification-checks/photo-id-check#requirements). (required).</param>
        /// <param name="documentDetail">documentDetail (required).</param>
        public UploadDocumentRequest(byte[] documentContent = default(byte[]), DocumentDetail documentDetail = default(DocumentDetail))
        {
            // to ensure "documentContent" is required (not null)
            if (documentContent == null)
            {
                throw new InvalidDataException("documentContent is a required property for UploadDocumentRequest and cannot be null");
            }
            else
            {
                this.DocumentContent = documentContent;
            }
            // to ensure "documentDetail" is required (not null)
            if (documentDetail == null)
            {
                throw new InvalidDataException("documentDetail is a required property for UploadDocumentRequest and cannot be null");
            }
            else
            {
                this.DocumentDetail = documentDetail;
            }
        }
        
        /// <summary>
        /// The content of the document as represented by a Base64-encoded string.  To learn about requirements, see [Bank account check](https://docs.adyen.com/marketpay/onboarding-and-verification/verification-checks/bank-account-check#requirements) and [Photo ID check](https://docs.adyen.com/marketpay/onboarding-and-verification/verification-checks/photo-id-check#requirements).
        /// </summary>
        /// <value>The content of the document as represented by a Base64-encoded string.  To learn about requirements, see [Bank account check](https://docs.adyen.com/marketpay/onboarding-and-verification/verification-checks/bank-account-check#requirements) and [Photo ID check](https://docs.adyen.com/marketpay/onboarding-and-verification/verification-checks/photo-id-check#requirements).</value>
        [DataMember(Name="documentContent", EmitDefaultValue=false)]
        public byte[] DocumentContent { get; set; }

        /// <summary>
        /// Gets or Sets DocumentDetail
        /// </summary>
        [DataMember(Name="documentDetail", EmitDefaultValue=false)]
        public DocumentDetail DocumentDetail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadDocumentRequest {\n");
            sb.Append("  DocumentContent: ").Append(DocumentContent).Append("\n");
            sb.Append("  DocumentDetail: ").Append(DocumentDetail).Append("\n");
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
            return this.Equals(input as UploadDocumentRequest);
        }

        /// <summary>
        /// Returns true if UploadDocumentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UploadDocumentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UploadDocumentRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocumentContent == input.DocumentContent ||
                    (this.DocumentContent != null &&
                    this.DocumentContent.Equals(input.DocumentContent))
                ) && 
                (
                    this.DocumentDetail == input.DocumentDetail ||
                    (this.DocumentDetail != null &&
                    this.DocumentDetail.Equals(input.DocumentDetail))
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
                if (this.DocumentContent != null)
                    hashCode = hashCode * 59 + this.DocumentContent.GetHashCode();
                if (this.DocumentDetail != null)
                    hashCode = hashCode * 59 + this.DocumentDetail.GetHashCode();
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
