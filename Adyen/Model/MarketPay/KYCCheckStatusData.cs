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
using Newtonsoft.Json.Converters;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// KYCCheckStatusData
    /// </summary>
    [DataContract]
        public partial class KYCCheckStatusData :  IEquatable<KYCCheckStatusData>, IValidatableObject
    {
        /// <summary>
        /// The status of the check. &gt;Permitted Values: &#x60;DATA_PROVIDED&#x60;, &#x60;PASSED&#x60;, &#x60;PENDING&#x60;, &#x60;AWAITING_DATA&#x60;, &#x60;RETRY_LIMIT_REACHED&#x60;, &#x60;INVALID_DATA&#x60;, &#x60;FAILED&#x60;.
        /// </summary>
        /// <value>The status of the check. &gt;Permitted Values: &#x60;DATA_PROVIDED&#x60;, &#x60;PASSED&#x60;, &#x60;PENDING&#x60;, &#x60;AWAITING_DATA&#x60;, &#x60;RETRY_LIMIT_REACHED&#x60;, &#x60;INVALID_DATA&#x60;, &#x60;FAILED&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StatusEnum
        {
            /// <summary>
            /// Enum AWAITINGDATA for value: AWAITING_DATA
            /// </summary>
            [EnumMember(Value = "AWAITING_DATA")]
            AWAITINGDATA = 1,
            /// <summary>
            /// Enum DATAPROVIDED for value: DATA_PROVIDED
            /// </summary>
            [EnumMember(Value = "DATA_PROVIDED")]
            DATAPROVIDED = 2,
            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            [EnumMember(Value = "FAILED")]
            FAILED = 3,
            /// <summary>
            /// Enum INVALIDDATA for value: INVALID_DATA
            /// </summary>
            [EnumMember(Value = "INVALID_DATA")]
            INVALIDDATA = 4,
            /// <summary>
            /// Enum PASSED for value: PASSED
            /// </summary>
            [EnumMember(Value = "PASSED")]
            PASSED = 5,
            /// <summary>
            /// Enum PENDING for value: PENDING
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDING = 6,
            /// <summary>
            /// Enum PENDINGREVIEW for value: PENDING_REVIEW
            /// </summary>
            [EnumMember(Value = "PENDING_REVIEW")]
            PENDINGREVIEW = 7,
            /// <summary>
            /// Enum RETRYLIMITREACHED for value: RETRY_LIMIT_REACHED
            /// </summary>
            [EnumMember(Value = "RETRY_LIMIT_REACHED")]
            RETRYLIMITREACHED = 8,
            /// <summary>
            /// Enum UNCHECKED for value: UNCHECKED
            /// </summary>
            [EnumMember(Value = "UNCHECKED")]
            UNCHECKED = 9        }
        /// <summary>
        /// The status of the check. &gt;Permitted Values: &#x60;DATA_PROVIDED&#x60;, &#x60;PASSED&#x60;, &#x60;PENDING&#x60;, &#x60;AWAITING_DATA&#x60;, &#x60;RETRY_LIMIT_REACHED&#x60;, &#x60;INVALID_DATA&#x60;, &#x60;FAILED&#x60;.
        /// </summary>
        /// <value>The status of the check. &gt;Permitted Values: &#x60;DATA_PROVIDED&#x60;, &#x60;PASSED&#x60;, &#x60;PENDING&#x60;, &#x60;AWAITING_DATA&#x60;, &#x60;RETRY_LIMIT_REACHED&#x60;, &#x60;INVALID_DATA&#x60;, &#x60;FAILED&#x60;.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// The type of check. &gt;Permitted Values: &#x60;COMPANY_VERIFICATION&#x60;, &#x60;IDENTITY_VERIFICATION&#x60;, &#x60;PASSPORT_VERIFICATION&#x60;, &#x60;BANK_ACCOUNT_VERIFICATION&#x60;, &#x60;NONPROFIT_VERIFICATION&#x60;.
        /// </summary>
        /// <value>The type of check. &gt;Permitted Values: &#x60;COMPANY_VERIFICATION&#x60;, &#x60;IDENTITY_VERIFICATION&#x60;, &#x60;PASSPORT_VERIFICATION&#x60;, &#x60;BANK_ACCOUNT_VERIFICATION&#x60;, &#x60;NONPROFIT_VERIFICATION&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum BANKACCOUNTVERIFICATION for value: BANK_ACCOUNT_VERIFICATION
            /// </summary>
            [EnumMember(Value = "BANK_ACCOUNT_VERIFICATION")]
            BANKACCOUNTVERIFICATION = 1,
            /// <summary>
            /// Enum COMPANYVERIFICATION for value: COMPANY_VERIFICATION
            /// </summary>
            [EnumMember(Value = "COMPANY_VERIFICATION")]
            COMPANYVERIFICATION = 2,
            /// <summary>
            /// Enum IDENTITYVERIFICATION for value: IDENTITY_VERIFICATION
            /// </summary>
            [EnumMember(Value = "IDENTITY_VERIFICATION")]
            IDENTITYVERIFICATION = 3,
            /// <summary>
            /// Enum NONPROFITVERIFICATION for value: NONPROFIT_VERIFICATION
            /// </summary>
            [EnumMember(Value = "NONPROFIT_VERIFICATION")]
            NONPROFITVERIFICATION = 4,
            /// <summary>
            /// Enum PASSPORTVERIFICATION for value: PASSPORT_VERIFICATION
            /// </summary>
            [EnumMember(Value = "PASSPORT_VERIFICATION")]
            PASSPORTVERIFICATION = 5        }
        /// <summary>
        /// The type of check. &gt;Permitted Values: &#x60;COMPANY_VERIFICATION&#x60;, &#x60;IDENTITY_VERIFICATION&#x60;, &#x60;PASSPORT_VERIFICATION&#x60;, &#x60;BANK_ACCOUNT_VERIFICATION&#x60;, &#x60;NONPROFIT_VERIFICATION&#x60;.
        /// </summary>
        /// <value>The type of check. &gt;Permitted Values: &#x60;COMPANY_VERIFICATION&#x60;, &#x60;IDENTITY_VERIFICATION&#x60;, &#x60;PASSPORT_VERIFICATION&#x60;, &#x60;BANK_ACCOUNT_VERIFICATION&#x60;, &#x60;NONPROFIT_VERIFICATION&#x60;.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KYCCheckStatusData" /> class.
        /// </summary>
        /// <param name="requiredFields">A list of the fields required for execution of the check. (required).</param>
        /// <param name="status">The status of the check. &gt;Permitted Values: &#x60;DATA_PROVIDED&#x60;, &#x60;PASSED&#x60;, &#x60;PENDING&#x60;, &#x60;AWAITING_DATA&#x60;, &#x60;RETRY_LIMIT_REACHED&#x60;, &#x60;INVALID_DATA&#x60;, &#x60;FAILED&#x60;. (required).</param>
        /// <param name="summary">summary (required).</param>
        /// <param name="type">The type of check. &gt;Permitted Values: &#x60;COMPANY_VERIFICATION&#x60;, &#x60;IDENTITY_VERIFICATION&#x60;, &#x60;PASSPORT_VERIFICATION&#x60;, &#x60;BANK_ACCOUNT_VERIFICATION&#x60;, &#x60;NONPROFIT_VERIFICATION&#x60;. (required).</param>
        public KYCCheckStatusData(List<string> requiredFields = default(List<string>), StatusEnum status = default(StatusEnum), KYCCheckSummary summary = default(KYCCheckSummary), TypeEnum type = default(TypeEnum))
        {
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for KYCCheckStatusData and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for KYCCheckStatusData and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.RequiredFields = requiredFields;
            this.Summary = summary;
        }
        
        /// <summary>
        /// A list of the fields required for execution of the check.
        /// </summary>
        /// <value>A list of the fields required for execution of the check.</value>
        [DataMember(Name="requiredFields", EmitDefaultValue=false)]
        public List<string> RequiredFields { get; set; }


        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name="summary", EmitDefaultValue=false)]
        public KYCCheckSummary Summary { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KYCCheckStatusData {\n");
            sb.Append("  RequiredFields: ").Append(RequiredFields).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
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
            return this.Equals(input as KYCCheckStatusData);
        }

        /// <summary>
        /// Returns true if KYCCheckStatusData instances are equal
        /// </summary>
        /// <param name="input">Instance of KYCCheckStatusData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KYCCheckStatusData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequiredFields == input.RequiredFields ||
                    this.RequiredFields != null &&
                    input.RequiredFields != null &&
                    this.RequiredFields.SequenceEqual(input.RequiredFields)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
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
                if (this.RequiredFields != null)
                    hashCode = hashCode * 59 + this.RequiredFields.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
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
