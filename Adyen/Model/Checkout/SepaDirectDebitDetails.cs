/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 70
* Contact: developer-experience@adyen.com
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// SepaDirectDebitDetails
    /// </summary>
    [DataContract(Name = "SepaDirectDebitDetails")]
    public partial class SepaDirectDebitDetails : IEquatable<SepaDirectDebitDetails>, IValidatableObject
    {
        /// <summary>
        /// **sepadirectdebit**
        /// </summary>
        /// <value>**sepadirectdebit**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Sepadirectdebit for value: sepadirectdebit
            /// </summary>
            [EnumMember(Value = "sepadirectdebit")]
            Sepadirectdebit = 1,

            /// <summary>
            /// Enum SepadirectdebitAmazonpay for value: sepadirectdebit_amazonpay
            /// </summary>
            [EnumMember(Value = "sepadirectdebit_amazonpay")]
            SepadirectdebitAmazonpay = 2

        }


        /// <summary>
        /// **sepadirectdebit**
        /// </summary>
        /// <value>**sepadirectdebit**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SepaDirectDebitDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SepaDirectDebitDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SepaDirectDebitDetails" /> class.
        /// </summary>
        /// <param name="checkoutAttemptId">The checkout attempt identifier..</param>
        /// <param name="iban">The International Bank Account Number (IBAN). (required).</param>
        /// <param name="ownerName">The name of the bank account holder. (required).</param>
        /// <param name="recurringDetailReference">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
        /// <param name="storedPaymentMethodId">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
        /// <param name="type">**sepadirectdebit** (default to TypeEnum.Sepadirectdebit).</param>
        public SepaDirectDebitDetails(string checkoutAttemptId = default(string), string iban = default(string), string ownerName = default(string), string recurringDetailReference = default(string), string storedPaymentMethodId = default(string), TypeEnum? type = TypeEnum.Sepadirectdebit)
        {
            this.Iban = iban;
            this.OwnerName = ownerName;
            this.CheckoutAttemptId = checkoutAttemptId;
            this.RecurringDetailReference = recurringDetailReference;
            this.StoredPaymentMethodId = storedPaymentMethodId;
            this.Type = type;
        }

        /// <summary>
        /// The checkout attempt identifier.
        /// </summary>
        /// <value>The checkout attempt identifier.</value>
        [DataMember(Name = "checkoutAttemptId", EmitDefaultValue = false)]
        public string CheckoutAttemptId { get; set; }

        /// <summary>
        /// The International Bank Account Number (IBAN).
        /// </summary>
        /// <value>The International Bank Account Number (IBAN).</value>
        [DataMember(Name = "iban", IsRequired = false, EmitDefaultValue = true)]
        public string Iban { get; set; }

        /// <summary>
        /// The name of the bank account holder.
        /// </summary>
        /// <value>The name of the bank account holder.</value>
        [DataMember(Name = "ownerName", IsRequired = false, EmitDefaultValue = true)]
        public string OwnerName { get; set; }

        /// <summary>
        /// This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.
        /// </summary>
        /// <value>This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.</value>
        [DataMember(Name = "recurringDetailReference", EmitDefaultValue = false)]
        [Obsolete]
        public string RecurringDetailReference { get; set; }

        /// <summary>
        /// This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.
        /// </summary>
        /// <value>This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.</value>
        [DataMember(Name = "storedPaymentMethodId", EmitDefaultValue = false)]
        public string StoredPaymentMethodId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SepaDirectDebitDetails {\n");
            sb.Append("  CheckoutAttemptId: ").Append(CheckoutAttemptId).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SepaDirectDebitDetails);
        }

        /// <summary>
        /// Returns true if SepaDirectDebitDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of SepaDirectDebitDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SepaDirectDebitDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CheckoutAttemptId == input.CheckoutAttemptId ||
                    (this.CheckoutAttemptId != null &&
                    this.CheckoutAttemptId.Equals(input.CheckoutAttemptId))
                ) && 
                (
                    this.Iban == input.Iban ||
                    (this.Iban != null &&
                    this.Iban.Equals(input.Iban))
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
                    this.Type.Equals(input.Type)
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
                if (this.CheckoutAttemptId != null)
                {
                    hashCode = (hashCode * 59) + this.CheckoutAttemptId.GetHashCode();
                }
                if (this.Iban != null)
                {
                    hashCode = (hashCode * 59) + this.Iban.GetHashCode();
                }
                if (this.OwnerName != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerName.GetHashCode();
                }
                if (this.RecurringDetailReference != null)
                {
                    hashCode = (hashCode * 59) + this.RecurringDetailReference.GetHashCode();
                }
                if (this.StoredPaymentMethodId != null)
                {
                    hashCode = (hashCode * 59) + this.StoredPaymentMethodId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
