/*
* Adyen Recurring API (deprecated)
*
*
* The version of the OpenAPI document: 68
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

namespace Adyen.Model.Recurring
{
    /// <summary>
    /// NotifyShopperRequest
    /// </summary>
    [DataContract(Name = "NotifyShopperRequest")]
    public partial class NotifyShopperRequest : IEquatable<NotifyShopperRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotifyShopperRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NotifyShopperRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotifyShopperRequest" /> class.
        /// </summary>
        /// <param name="amount">amount (required).</param>
        /// <param name="billingDate">Date on which the subscription amount will be debited from the shopper. In YYYY-MM-DD format.</param>
        /// <param name="billingSequenceNumber">Sequence of the debit. Depends on Frequency and Billing Attempts Rule..</param>
        /// <param name="displayedReference">Reference of Pre-debit notification that is displayed to the shopper. Optional field. Maps to reference if missing.</param>
        /// <param name="merchantAccount">The merchant account identifier with which you want to process the transaction. (required).</param>
        /// <param name="recurringDetailReference">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
        /// <param name="reference">Pre-debit notification reference sent by the merchant. This is a mandatory field (required).</param>
        /// <param name="shopperReference">The ID that uniquely identifies the shopper.  This &#x60;shopperReference&#x60; must be the same as the &#x60;shopperReference&#x60; used in the initial payment. (required).</param>
        /// <param name="storedPaymentMethodId">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
        public NotifyShopperRequest(Amount amount = default(Amount), string billingDate = default(string), string billingSequenceNumber = default(string), string displayedReference = default(string), string merchantAccount = default(string), string recurringDetailReference = default(string), string reference = default(string), string shopperReference = default(string), string storedPaymentMethodId = default(string))
        {
            this.Amount = amount;
            this.MerchantAccount = merchantAccount;
            this.Reference = reference;
            this.ShopperReference = shopperReference;
            this.BillingDate = billingDate;
            this.BillingSequenceNumber = billingSequenceNumber;
            this.DisplayedReference = displayedReference;
            this.RecurringDetailReference = recurringDetailReference;
            this.StoredPaymentMethodId = storedPaymentMethodId;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", IsRequired = false, EmitDefaultValue = false)]
        public Amount Amount { get; set; }

        /// <summary>
        /// Date on which the subscription amount will be debited from the shopper. In YYYY-MM-DD format
        /// </summary>
        /// <value>Date on which the subscription amount will be debited from the shopper. In YYYY-MM-DD format</value>
        [DataMember(Name = "billingDate", EmitDefaultValue = false)]
        public string BillingDate { get; set; }

        /// <summary>
        /// Sequence of the debit. Depends on Frequency and Billing Attempts Rule.
        /// </summary>
        /// <value>Sequence of the debit. Depends on Frequency and Billing Attempts Rule.</value>
        [DataMember(Name = "billingSequenceNumber", EmitDefaultValue = false)]
        public string BillingSequenceNumber { get; set; }

        /// <summary>
        /// Reference of Pre-debit notification that is displayed to the shopper. Optional field. Maps to reference if missing
        /// </summary>
        /// <value>Reference of Pre-debit notification that is displayed to the shopper. Optional field. Maps to reference if missing</value>
        [DataMember(Name = "displayedReference", EmitDefaultValue = false)]
        public string DisplayedReference { get; set; }

        /// <summary>
        /// The merchant account identifier with which you want to process the transaction.
        /// </summary>
        /// <value>The merchant account identifier with which you want to process the transaction.</value>
        [DataMember(Name = "merchantAccount", IsRequired = false, EmitDefaultValue = false)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.
        /// </summary>
        /// <value>This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.</value>
        [DataMember(Name = "recurringDetailReference", EmitDefaultValue = false)]
        public string RecurringDetailReference { get; set; }

        /// <summary>
        /// Pre-debit notification reference sent by the merchant. This is a mandatory field
        /// </summary>
        /// <value>Pre-debit notification reference sent by the merchant. This is a mandatory field</value>
        [DataMember(Name = "reference", IsRequired = false, EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// The ID that uniquely identifies the shopper.  This &#x60;shopperReference&#x60; must be the same as the &#x60;shopperReference&#x60; used in the initial payment.
        /// </summary>
        /// <value>The ID that uniquely identifies the shopper.  This &#x60;shopperReference&#x60; must be the same as the &#x60;shopperReference&#x60; used in the initial payment.</value>
        [DataMember(Name = "shopperReference", IsRequired = false, EmitDefaultValue = false)]
        public string ShopperReference { get; set; }

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
            sb.Append("class NotifyShopperRequest {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BillingDate: ").Append(BillingDate).Append("\n");
            sb.Append("  BillingSequenceNumber: ").Append(BillingSequenceNumber).Append("\n");
            sb.Append("  DisplayedReference: ").Append(DisplayedReference).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  RecurringDetailReference: ").Append(RecurringDetailReference).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  ShopperReference: ").Append(ShopperReference).Append("\n");
            sb.Append("  StoredPaymentMethodId: ").Append(StoredPaymentMethodId).Append("\n");
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
            return this.Equals(input as NotifyShopperRequest);
        }

        /// <summary>
        /// Returns true if NotifyShopperRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of NotifyShopperRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotifyShopperRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.BillingDate == input.BillingDate ||
                    (this.BillingDate != null &&
                    this.BillingDate.Equals(input.BillingDate))
                ) && 
                (
                    this.BillingSequenceNumber == input.BillingSequenceNumber ||
                    (this.BillingSequenceNumber != null &&
                    this.BillingSequenceNumber.Equals(input.BillingSequenceNumber))
                ) && 
                (
                    this.DisplayedReference == input.DisplayedReference ||
                    (this.DisplayedReference != null &&
                    this.DisplayedReference.Equals(input.DisplayedReference))
                ) && 
                (
                    this.MerchantAccount == input.MerchantAccount ||
                    (this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(input.MerchantAccount))
                ) && 
                (
                    this.RecurringDetailReference == input.RecurringDetailReference ||
                    (this.RecurringDetailReference != null &&
                    this.RecurringDetailReference.Equals(input.RecurringDetailReference))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.ShopperReference == input.ShopperReference ||
                    (this.ShopperReference != null &&
                    this.ShopperReference.Equals(input.ShopperReference))
                ) && 
                (
                    this.StoredPaymentMethodId == input.StoredPaymentMethodId ||
                    (this.StoredPaymentMethodId != null &&
                    this.StoredPaymentMethodId.Equals(input.StoredPaymentMethodId))
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.BillingDate != null)
                {
                    hashCode = (hashCode * 59) + this.BillingDate.GetHashCode();
                }
                if (this.BillingSequenceNumber != null)
                {
                    hashCode = (hashCode * 59) + this.BillingSequenceNumber.GetHashCode();
                }
                if (this.DisplayedReference != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayedReference.GetHashCode();
                }
                if (this.MerchantAccount != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantAccount.GetHashCode();
                }
                if (this.RecurringDetailReference != null)
                {
                    hashCode = (hashCode * 59) + this.RecurringDetailReference.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.ShopperReference != null)
                {
                    hashCode = (hashCode * 59) + this.ShopperReference.GetHashCode();
                }
                if (this.StoredPaymentMethodId != null)
                {
                    hashCode = (hashCode * 59) + this.StoredPaymentMethodId.GetHashCode();
                }
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
