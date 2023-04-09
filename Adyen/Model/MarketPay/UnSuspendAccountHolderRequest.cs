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
    /// UnSuspendAccountHolderRequest
    /// </summary>
    [DataContract]
        public class UnSuspendAccountHolderRequest :  IEquatable<UnSuspendAccountHolderRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnSuspendAccountHolderRequest" /> class.
        /// </summary>
        /// <param name="accountHolderCode">The code of the account holder to be reinstated. (required).</param>
        public UnSuspendAccountHolderRequest(string accountHolderCode = default(string))
        {
            // to ensure "accountHolderCode" is required (not null)
            if (accountHolderCode == null)
            {
                throw new InvalidDataException("accountHolderCode is a required property for UnSuspendAccountHolderRequest and cannot be null");
            }

            AccountHolderCode = accountHolderCode;
        }
        
        /// <summary>
        /// The code of the account holder to be reinstated.
        /// </summary>
        /// <value>The code of the account holder to be reinstated.</value>
        [DataMember(Name="accountHolderCode", EmitDefaultValue=false)]
        public string AccountHolderCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnSuspendAccountHolderRequest {\n");
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
            return Equals(input as UnSuspendAccountHolderRequest);
        }

        /// <summary>
        /// Returns true if UnSuspendAccountHolderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UnSuspendAccountHolderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnSuspendAccountHolderRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    AccountHolderCode == input.AccountHolderCode ||
                    (AccountHolderCode != null &&
                    AccountHolderCode.Equals(input.AccountHolderCode))
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
