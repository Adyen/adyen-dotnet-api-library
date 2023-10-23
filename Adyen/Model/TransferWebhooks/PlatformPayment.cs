/*
* Transfer webhooks
*
*
* The version of the OpenAPI document: 4
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

namespace Adyen.Model.TransferWebhooks
{
    /// <summary>
    /// PlatformPayment
    /// </summary>
    [DataContract(Name = "PlatformPayment")]
    public partial class PlatformPayment : IEquatable<PlatformPayment>, IValidatableObject
    {
        /// <summary>
        /// The type of the related split.
        /// </summary>
        /// <value>The type of the related split.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PlatformPaymentTypeEnum
        {
            /// <summary>
            /// Enum AcquiringFees for value: AcquiringFees
            /// </summary>
            [EnumMember(Value = "AcquiringFees")]
            AcquiringFees = 1,

            /// <summary>
            /// Enum AdyenCommission for value: AdyenCommission
            /// </summary>
            [EnumMember(Value = "AdyenCommission")]
            AdyenCommission = 2,

            /// <summary>
            /// Enum AdyenFees for value: AdyenFees
            /// </summary>
            [EnumMember(Value = "AdyenFees")]
            AdyenFees = 3,

            /// <summary>
            /// Enum AdyenMarkup for value: AdyenMarkup
            /// </summary>
            [EnumMember(Value = "AdyenMarkup")]
            AdyenMarkup = 4,

            /// <summary>
            /// Enum BalanceAccount for value: BalanceAccount
            /// </summary>
            [EnumMember(Value = "BalanceAccount")]
            BalanceAccount = 5,

            /// <summary>
            /// Enum Commission for value: Commission
            /// </summary>
            [EnumMember(Value = "Commission")]
            Commission = 6,

            /// <summary>
            /// Enum Default for value: Default
            /// </summary>
            [EnumMember(Value = "Default")]
            Default = 7,

            /// <summary>
            /// Enum Interchange for value: Interchange
            /// </summary>
            [EnumMember(Value = "Interchange")]
            Interchange = 8,

            /// <summary>
            /// Enum PaymentFee for value: PaymentFee
            /// </summary>
            [EnumMember(Value = "PaymentFee")]
            PaymentFee = 9,

            /// <summary>
            /// Enum Remainder for value: Remainder
            /// </summary>
            [EnumMember(Value = "Remainder")]
            Remainder = 10,

            /// <summary>
            /// Enum SchemeFee for value: SchemeFee
            /// </summary>
            [EnumMember(Value = "SchemeFee")]
            SchemeFee = 11,

            /// <summary>
            /// Enum TopUp for value: TopUp
            /// </summary>
            [EnumMember(Value = "TopUp")]
            TopUp = 12,

            /// <summary>
            /// Enum VAT for value: VAT
            /// </summary>
            [EnumMember(Value = "VAT")]
            VAT = 13

        }


        /// <summary>
        /// The type of the related split.
        /// </summary>
        /// <value>The type of the related split.</value>
        [DataMember(Name = "platformPaymentType", EmitDefaultValue = false)]
        public PlatformPaymentTypeEnum? PlatformPaymentType { get; set; }
        /// <summary>
        /// **platformPayment**
        /// </summary>
        /// <value>**platformPayment**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum PlatformPayment for value: platformPayment
            /// </summary>
            [EnumMember(Value = "platformPayment")]
            PlatformPayment = 1

        }


        /// <summary>
        /// **platformPayment**
        /// </summary>
        /// <value>**platformPayment**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformPayment" /> class.
        /// </summary>
        /// <param name="modificationMerchantReference">The capture&#39;s merchant reference included in the transfer..</param>
        /// <param name="modificationPspReference">The capture reference included in the transfer..</param>
        /// <param name="paymentMerchantReference">The payment&#39;s merchant reference included in the transfer..</param>
        /// <param name="platformPaymentType">The type of the related split..</param>
        /// <param name="pspPaymentReference">The payment reference included in the transfer..</param>
        /// <param name="type">**platformPayment** (default to TypeEnum.PlatformPayment).</param>
        public PlatformPayment(string modificationMerchantReference = default(string), string modificationPspReference = default(string), string paymentMerchantReference = default(string), PlatformPaymentTypeEnum? platformPaymentType = default(PlatformPaymentTypeEnum?), string pspPaymentReference = default(string), TypeEnum? type = TypeEnum.PlatformPayment)
        {
            this.ModificationMerchantReference = modificationMerchantReference;
            this.ModificationPspReference = modificationPspReference;
            this.PaymentMerchantReference = paymentMerchantReference;
            this.PlatformPaymentType = platformPaymentType;
            this.PspPaymentReference = pspPaymentReference;
            this.Type = type;
        }

        /// <summary>
        /// The capture&#39;s merchant reference included in the transfer.
        /// </summary>
        /// <value>The capture&#39;s merchant reference included in the transfer.</value>
        [DataMember(Name = "modificationMerchantReference", EmitDefaultValue = false)]
        public string ModificationMerchantReference { get; set; }

        /// <summary>
        /// The capture reference included in the transfer.
        /// </summary>
        /// <value>The capture reference included in the transfer.</value>
        [DataMember(Name = "modificationPspReference", EmitDefaultValue = false)]
        public string ModificationPspReference { get; set; }

        /// <summary>
        /// The payment&#39;s merchant reference included in the transfer.
        /// </summary>
        /// <value>The payment&#39;s merchant reference included in the transfer.</value>
        [DataMember(Name = "paymentMerchantReference", EmitDefaultValue = false)]
        public string PaymentMerchantReference { get; set; }

        /// <summary>
        /// The payment reference included in the transfer.
        /// </summary>
        /// <value>The payment reference included in the transfer.</value>
        [DataMember(Name = "pspPaymentReference", EmitDefaultValue = false)]
        public string PspPaymentReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlatformPayment {\n");
            sb.Append("  ModificationMerchantReference: ").Append(ModificationMerchantReference).Append("\n");
            sb.Append("  ModificationPspReference: ").Append(ModificationPspReference).Append("\n");
            sb.Append("  PaymentMerchantReference: ").Append(PaymentMerchantReference).Append("\n");
            sb.Append("  PlatformPaymentType: ").Append(PlatformPaymentType).Append("\n");
            sb.Append("  PspPaymentReference: ").Append(PspPaymentReference).Append("\n");
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
            return this.Equals(input as PlatformPayment);
        }

        /// <summary>
        /// Returns true if PlatformPayment instances are equal
        /// </summary>
        /// <param name="input">Instance of PlatformPayment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlatformPayment input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ModificationMerchantReference == input.ModificationMerchantReference ||
                    (this.ModificationMerchantReference != null &&
                    this.ModificationMerchantReference.Equals(input.ModificationMerchantReference))
                ) && 
                (
                    this.ModificationPspReference == input.ModificationPspReference ||
                    (this.ModificationPspReference != null &&
                    this.ModificationPspReference.Equals(input.ModificationPspReference))
                ) && 
                (
                    this.PaymentMerchantReference == input.PaymentMerchantReference ||
                    (this.PaymentMerchantReference != null &&
                    this.PaymentMerchantReference.Equals(input.PaymentMerchantReference))
                ) && 
                (
                    this.PlatformPaymentType == input.PlatformPaymentType ||
                    this.PlatformPaymentType.Equals(input.PlatformPaymentType)
                ) && 
                (
                    this.PspPaymentReference == input.PspPaymentReference ||
                    (this.PspPaymentReference != null &&
                    this.PspPaymentReference.Equals(input.PspPaymentReference))
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
                if (this.ModificationMerchantReference != null)
                {
                    hashCode = (hashCode * 59) + this.ModificationMerchantReference.GetHashCode();
                }
                if (this.ModificationPspReference != null)
                {
                    hashCode = (hashCode * 59) + this.ModificationPspReference.GetHashCode();
                }
                if (this.PaymentMerchantReference != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentMerchantReference.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PlatformPaymentType.GetHashCode();
                if (this.PspPaymentReference != null)
                {
                    hashCode = (hashCode * 59) + this.PspPaymentReference.GetHashCode();
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
