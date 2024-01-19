/*
* Adyen Terminal API
*
*
* The version of the OpenAPI document: 1
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

namespace Adyen.Model.Terminal
{
    /// <summary>
    /// Conditions on which the transaction must be processed.
    /// </summary>
    [DataContract(Name = "TransactionConditions")]
    public partial class TransactionConditions : IEquatable<TransactionConditions>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets LoyaltyHandling
        /// </summary>
        [DataMember(Name = "LoyaltyHandling", EmitDefaultValue = false)]
        public LoyaltyHandling? LoyaltyHandling { get; set; }
        /// <summary>
        /// Defines ForceEntryMode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ForceEntryModeEnum
        {
            /// <summary>
            /// Enum CheckReader for value: CheckReader
            /// </summary>
            [EnumMember(Value = "CheckReader")]
            CheckReader = 1,

            /// <summary>
            /// Enum Contactless for value: Contactless
            /// </summary>
            [EnumMember(Value = "Contactless")]
            Contactless = 2,

            /// <summary>
            /// Enum File for value: File
            /// </summary>
            [EnumMember(Value = "File")]
            File = 3,

            /// <summary>
            /// Enum ICC for value: ICC
            /// </summary>
            [EnumMember(Value = "ICC")]
            ICC = 4,

            /// <summary>
            /// Enum Keyed for value: Keyed
            /// </summary>
            [EnumMember(Value = "Keyed")]
            Keyed = 5,

            /// <summary>
            /// Enum MagStripe for value: MagStripe
            /// </summary>
            [EnumMember(Value = "MagStripe")]
            MagStripe = 6,

            /// <summary>
            /// Enum Manual for value: Manual
            /// </summary>
            [EnumMember(Value = "Manual")]
            Manual = 7,

            /// <summary>
            /// Enum RFID for value: RFID
            /// </summary>
            [EnumMember(Value = "RFID")]
            RFID = 8,

            /// <summary>
            /// Enum Scanned for value: Scanned
            /// </summary>
            [EnumMember(Value = "Scanned")]
            Scanned = 9,

            /// <summary>
            /// Enum SynchronousICC for value: SynchronousICC
            /// </summary>
            [EnumMember(Value = "SynchronousICC")]
            SynchronousICC = 10,

            /// <summary>
            /// Enum Tapped for value: Tapped
            /// </summary>
            [EnumMember(Value = "Tapped")]
            Tapped = 11

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionConditions" /> class.
        /// </summary>
        /// <param name="allowedPaymentBrand">allowedPaymentBrand.</param>
        /// <param name="acquirerID">acquirerID.</param>
        /// <param name="debitPreferredFlag">The preferred type of payment is a debit transaction rather a credit transaction..</param>
        /// <param name="allowedLoyaltyBrand">allowedLoyaltyBrand.</param>
        /// <param name="loyaltyHandling">loyaltyHandling.</param>
        /// <param name="customerLanguage">If the language is selected by the Sale System before the request to the POI..</param>
        /// <param name="forceOnlineFlag">Go online if data sent. (default to false).</param>
        /// <param name="forceEntryMode">forceEntryMode.</param>
        /// <param name="merchantCategoryCode">The payment implies a specific MCC..</param>
        public TransactionConditions(List<string> allowedPaymentBrand = default(List<string>), List<int> acquirerID = default(List<int>), bool? debitPreferredFlag = default(bool?), List<string> allowedLoyaltyBrand = default(List<string>), LoyaltyHandling? loyaltyHandling = default(LoyaltyHandling?), string customerLanguage = default(string), bool? forceOnlineFlag = false, List<ForceEntryModeEnum> forceEntryMode = default(List<ForceEntryModeEnum>), string merchantCategoryCode = default(string))
        {
            this.AllowedPaymentBrand = allowedPaymentBrand;
            this.AcquirerID = acquirerID;
            this.DebitPreferredFlag = debitPreferredFlag;
            this.AllowedLoyaltyBrand = allowedLoyaltyBrand;
            this.LoyaltyHandling = loyaltyHandling;
            this.CustomerLanguage = customerLanguage;
            this.ForceOnlineFlag = forceOnlineFlag;
            this.ForceEntryMode = forceEntryMode;
            this.MerchantCategoryCode = merchantCategoryCode;
        }

        /// <summary>
        /// Gets or Sets AllowedPaymentBrand
        /// </summary>
        [DataMember(Name = "AllowedPaymentBrand", EmitDefaultValue = false)]
        public List<string> AllowedPaymentBrand { get; set; }

        /// <summary>
        /// Gets or Sets AcquirerID
        /// </summary>
        [DataMember(Name = "AcquirerID", EmitDefaultValue = false)]
        public List<int> AcquirerID { get; set; }

        /// <summary>
        /// The preferred type of payment is a debit transaction rather a credit transaction.
        /// </summary>
        /// <value>The preferred type of payment is a debit transaction rather a credit transaction.</value>
        [DataMember(Name = "DebitPreferredFlag", EmitDefaultValue = false)]
        public bool? DebitPreferredFlag { get; set; }

        /// <summary>
        /// Gets or Sets AllowedLoyaltyBrand
        /// </summary>
        [DataMember(Name = "AllowedLoyaltyBrand", EmitDefaultValue = false)]
        public List<string> AllowedLoyaltyBrand { get; set; }

        /// <summary>
        /// If the language is selected by the Sale System before the request to the POI.
        /// </summary>
        /// <value>If the language is selected by the Sale System before the request to the POI.</value>
        [DataMember(Name = "CustomerLanguage", EmitDefaultValue = false)]
        public string CustomerLanguage { get; set; }

        /// <summary>
        /// Go online if data sent.
        /// </summary>
        /// <value>Go online if data sent.</value>
        [DataMember(Name = "ForceOnlineFlag", EmitDefaultValue = false)]
        public bool? ForceOnlineFlag { get; set; }

        /// <summary>
        /// Gets or Sets ForceEntryMode
        /// </summary>
        [DataMember(Name = "ForceEntryMode", EmitDefaultValue = false)]
        public List<TransactionConditions.ForceEntryModeEnum> ForceEntryMode { get; set; }

        /// <summary>
        /// The payment implies a specific MCC.
        /// </summary>
        /// <value>The payment implies a specific MCC.</value>
        [DataMember(Name = "MerchantCategoryCode", EmitDefaultValue = false)]
        public string MerchantCategoryCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionConditions {\n");
            sb.Append("  AllowedPaymentBrand: ").Append(AllowedPaymentBrand).Append("\n");
            sb.Append("  AcquirerID: ").Append(AcquirerID).Append("\n");
            sb.Append("  DebitPreferredFlag: ").Append(DebitPreferredFlag).Append("\n");
            sb.Append("  AllowedLoyaltyBrand: ").Append(AllowedLoyaltyBrand).Append("\n");
            sb.Append("  LoyaltyHandling: ").Append(LoyaltyHandling).Append("\n");
            sb.Append("  CustomerLanguage: ").Append(CustomerLanguage).Append("\n");
            sb.Append("  ForceOnlineFlag: ").Append(ForceOnlineFlag).Append("\n");
            sb.Append("  ForceEntryMode: ").Append(ForceEntryMode).Append("\n");
            sb.Append("  MerchantCategoryCode: ").Append(MerchantCategoryCode).Append("\n");
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
            return this.Equals(input as TransactionConditions);
        }

        /// <summary>
        /// Returns true if TransactionConditions instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionConditions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionConditions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AllowedPaymentBrand == input.AllowedPaymentBrand ||
                    this.AllowedPaymentBrand != null &&
                    input.AllowedPaymentBrand != null &&
                    this.AllowedPaymentBrand.SequenceEqual(input.AllowedPaymentBrand)
                ) && 
                (
                    this.AcquirerID == input.AcquirerID ||
                    this.AcquirerID != null &&
                    input.AcquirerID != null &&
                    this.AcquirerID.SequenceEqual(input.AcquirerID)
                ) && 
                (
                    this.DebitPreferredFlag == input.DebitPreferredFlag ||
                    this.DebitPreferredFlag.Equals(input.DebitPreferredFlag)
                ) && 
                (
                    this.AllowedLoyaltyBrand == input.AllowedLoyaltyBrand ||
                    this.AllowedLoyaltyBrand != null &&
                    input.AllowedLoyaltyBrand != null &&
                    this.AllowedLoyaltyBrand.SequenceEqual(input.AllowedLoyaltyBrand)
                ) && 
                (
                    this.LoyaltyHandling == input.LoyaltyHandling ||
                    this.LoyaltyHandling.Equals(input.LoyaltyHandling)
                ) && 
                (
                    this.CustomerLanguage == input.CustomerLanguage ||
                    (this.CustomerLanguage != null &&
                    this.CustomerLanguage.Equals(input.CustomerLanguage))
                ) && 
                (
                    this.ForceOnlineFlag == input.ForceOnlineFlag ||
                    this.ForceOnlineFlag.Equals(input.ForceOnlineFlag)
                ) && 
                (
                    this.ForceEntryMode == input.ForceEntryMode ||
                    this.ForceEntryMode != null &&
                    input.ForceEntryMode != null &&
                    this.ForceEntryMode.SequenceEqual(input.ForceEntryMode)
                ) && 
                (
                    this.MerchantCategoryCode == input.MerchantCategoryCode ||
                    (this.MerchantCategoryCode != null &&
                    this.MerchantCategoryCode.Equals(input.MerchantCategoryCode))
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
                if (this.AllowedPaymentBrand != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedPaymentBrand.GetHashCode();
                }
                if (this.AcquirerID != null)
                {
                    hashCode = (hashCode * 59) + this.AcquirerID.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DebitPreferredFlag.GetHashCode();
                if (this.AllowedLoyaltyBrand != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedLoyaltyBrand.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LoyaltyHandling.GetHashCode();
                if (this.CustomerLanguage != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerLanguage.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ForceOnlineFlag.GetHashCode();
                if (this.ForceEntryMode != null)
                {
                    hashCode = (hashCode * 59) + this.ForceEntryMode.GetHashCode();
                }
                if (this.MerchantCategoryCode != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantCategoryCode.GetHashCode();
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
            // CustomerLanguage (string) pattern
            Regex regexCustomerLanguage = new Regex(@"^[a-z]{2,2}$", RegexOptions.CultureInvariant);
            if (false == regexCustomerLanguage.Match(this.CustomerLanguage).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomerLanguage, must match a pattern of " + regexCustomerLanguage, new [] { "CustomerLanguage" });
            }

            // MerchantCategoryCode (string) pattern
            Regex regexMerchantCategoryCode = new Regex(@"^.{3,4}$", RegexOptions.CultureInvariant);
            if (false == regexMerchantCategoryCode.Match(this.MerchantCategoryCode).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantCategoryCode, must match a pattern of " + regexMerchantCategoryCode, new [] { "MerchantCategoryCode" });
            }

            yield break;
        }
    }

}
