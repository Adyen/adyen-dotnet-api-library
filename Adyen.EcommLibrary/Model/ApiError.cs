using Adyen.EcommLibrary.Model.Reccuring;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Adyen.EcommLibrary.Model
{
    public class ApiError : IEquatable<ApiError>, IValidatableObject
    {
        public int Status { get; set; }
        public string ErrorCode { get; set; }
        public string Message { get; set; }
        public string ErrorType { get; set; }
        public string PspReference { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiError {\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  ErrorType: ").Append(ErrorType).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return Equals(obj as RecurringDetailsResult);
        }

        /// <summary>
        /// Returns true if RecurringDetailsResult instances are equal
        /// </summary>
        /// <param name="other">Instance of RecurringDetailsResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiError other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    Status == other.Status ||
                    Status.Equals(other.Status)
                ) &&
                (
                    ErrorCode == other.ErrorCode ||
                    ErrorCode != null &&
                    ErrorCode.Equals(other.ErrorCode)
                ) &&
                (
                    Message == other.Message ||
                    Message != null &&
                    Message.Equals(other.Message)
                ) &&
                (
                    ErrorType == other.ErrorType ||
                    ErrorType != null &&
                    ErrorType.Equals(other.ErrorType)
                ) &&
                (
                    PspReference == other.PspReference ||
                    PspReference != null &&
                    PspReference.Equals(other.PspReference)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                var hash = 41;
                // Suitable nullity checks etc, of course :)
                hash = hash * 59 + Status.GetHashCode();
                if (ErrorCode != null)
                    hash = hash * 59 + ErrorCode.GetHashCode();
                if (Message != null)
                    hash = hash * 59 + Message.GetHashCode();
                if (ErrorType != null)
                    hash = hash * 59 + ErrorType.GetHashCode();
                if (PspReference != null)
                    hash = hash * 59 + PspReference.GetHashCode();
                return hash;
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