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
    /// PayoutAccountHolderResponse
    /// </summary>
    [DataContract]
    public class PayoutAccountHolderResponse : IEquatable<PayoutAccountHolderResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutAccountHolderResponse" /> class.
        /// </summary>
        /// <param name="bankAccountUUID">The unique ID of the Bank Account to which the payout was made. (required).</param>
        /// <param name="invalidFields">Contains field validation errors that would prevent requests from being processed..</param>
        /// <param name="merchantReference">The value supplied by the executing user when initiating the transfer; may be used to link multiple transactions..</param>
        /// <param name="pspReference">The reference of a request.  Can be used to uniquely identify the request. (required).</param>
        /// <param name="resultCode">The result code..</param>
        public PayoutAccountHolderResponse(string bankAccountUUID = default(string), List<ErrorFieldType> invalidFields = default(List<ErrorFieldType>), string merchantReference = default(string), string pspReference = default(string), string resultCode = default(string))
        { 
            // to ensure "pspReference" is required (not null)
            if (pspReference == null)
            {
                throw new InvalidDataException("pspReference is a required property for PayoutAccountHolderResponse and cannot be null");
            }

            PspReference = pspReference;
            BankAccountUUID = bankAccountUUID;
            InvalidFields = invalidFields;
            MerchantReference = merchantReference;
            ResultCode = resultCode;
        }

        /// <summary>
        /// The unique ID of the Bank Account to which the payout was made.
        /// </summary>
        /// <value>The unique ID of the Bank Account to which the payout was made.</value>
        [DataMember(Name = "bankAccountUUID", EmitDefaultValue = false)]
        public string BankAccountUUID { get; set; }

        /// <summary>
        /// Contains field validation errors that would prevent requests from being processed.
        /// </summary>
        /// <value>Contains field validation errors that would prevent requests from being processed.</value>
        [DataMember(Name = "invalidFields", EmitDefaultValue = false)]
        public List<ErrorFieldType> InvalidFields { get; set; }

        /// <summary>
        /// The value supplied by the executing user when initiating the transfer; may be used to link multiple transactions.
        /// </summary>
        /// <value>The value supplied by the executing user when initiating the transfer; may be used to link multiple transactions.</value>
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        public string MerchantReference { get; set; }

        /// <summary>
        /// The reference of a request.  Can be used to uniquely identify the request.
        /// </summary>
        /// <value>The reference of a request.  Can be used to uniquely identify the request.</value>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        public string PspReference { get; set; }

        /// <summary>
        /// The result code.
        /// </summary>
        /// <value>The result code.</value>
        [DataMember(Name = "resultCode", EmitDefaultValue = false)]
        public string ResultCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayoutAccountHolderResponse {\n");
            sb.Append("  BankAccountUUID: ").Append(BankAccountUUID).Append("\n");
            sb.Append("  InvalidFields: ").Append(InvalidFields).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
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
            return Equals(input as PayoutAccountHolderResponse);
        }

        /// <summary>
        /// Returns true if PayoutAccountHolderResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PayoutAccountHolderResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayoutAccountHolderResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    BankAccountUUID == input.BankAccountUUID ||
                    (BankAccountUUID != null &&
                    BankAccountUUID.Equals(input.BankAccountUUID))
                ) &&
                (
                    InvalidFields == input.InvalidFields ||
                    InvalidFields != null &&
                    input.InvalidFields != null &&
                    InvalidFields.SequenceEqual(input.InvalidFields)
                ) &&
                (
                    MerchantReference == input.MerchantReference ||
                    (MerchantReference != null &&
                    MerchantReference.Equals(input.MerchantReference))
                ) &&
                (
                    PspReference == input.PspReference ||
                    (PspReference != null &&
                    PspReference.Equals(input.PspReference))
                ) &&
                (
                    ResultCode == input.ResultCode ||
                    (ResultCode != null &&
                    ResultCode.Equals(input.ResultCode))
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
                if (BankAccountUUID != null)
                    hashCode = hashCode * 59 + BankAccountUUID.GetHashCode();
                if (InvalidFields != null)
                    hashCode = hashCode * 59 + InvalidFields.GetHashCode();
                if (MerchantReference != null)
                    hashCode = hashCode * 59 + MerchantReference.GetHashCode();
                if (PspReference != null)
                    hashCode = hashCode * 59 + PspReference.GetHashCode();
                if (ResultCode != null)
                    hashCode = hashCode * 59 + ResultCode.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
