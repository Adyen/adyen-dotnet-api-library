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
    /// PaymentResult
    /// </summary>
    [DataContract(Name = "PaymentResult")]
    public partial class PaymentResult : IEquatable<PaymentResult>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets PaymentType
        /// </summary>
        [DataMember(Name = "PaymentType", EmitDefaultValue = false)]
        public PaymentType? PaymentType { get; set; }
        /// <summary>
        /// Defines AuthenticationMethod
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthenticationMethodEnum
        {
            /// <summary>
            /// Enum Bypass for value: Bypass
            /// </summary>
            [EnumMember(Value = "Bypass")]
            Bypass = 1,

            /// <summary>
            /// Enum ManualVerification for value: ManualVerification
            /// </summary>
            [EnumMember(Value = "ManualVerification")]
            ManualVerification = 2,

            /// <summary>
            /// Enum MerchantAuthentication for value: MerchantAuthentication
            /// </summary>
            [EnumMember(Value = "MerchantAuthentication")]
            MerchantAuthentication = 3,

            /// <summary>
            /// Enum OfflinePIN for value: OfflinePIN
            /// </summary>
            [EnumMember(Value = "OfflinePIN")]
            OfflinePIN = 4,

            /// <summary>
            /// Enum OnlinePIN for value: OnlinePIN
            /// </summary>
            [EnumMember(Value = "OnlinePIN")]
            OnlinePIN = 5,

            /// <summary>
            /// Enum PaperSignature for value: PaperSignature
            /// </summary>
            [EnumMember(Value = "PaperSignature")]
            PaperSignature = 6,

            /// <summary>
            /// Enum SecureCertificate for value: SecureCertificate
            /// </summary>
            [EnumMember(Value = "SecureCertificate")]
            SecureCertificate = 7,

            /// <summary>
            /// Enum SecureNoCertificate for value: SecureNoCertificate
            /// </summary>
            [EnumMember(Value = "SecureNoCertificate")]
            SecureNoCertificate = 8,

            /// <summary>
            /// Enum SecuredChannel for value: SecuredChannel
            /// </summary>
            [EnumMember(Value = "SecuredChannel")]
            SecuredChannel = 9,

            /// <summary>
            /// Enum SignatureCapture for value: SignatureCapture
            /// </summary>
            [EnumMember(Value = "SignatureCapture")]
            SignatureCapture = 10,

            /// <summary>
            /// Enum UnknownMethod for value: UnknownMethod
            /// </summary>
            [EnumMember(Value = "UnknownMethod")]
            UnknownMethod = 11

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResult" /> class.
        /// </summary>
        /// <param name="paymentType">paymentType.</param>
        /// <param name="paymentInstrumentData">paymentInstrumentData.</param>
        /// <param name="amountsResp">amountsResp.</param>
        /// <param name="instalment">instalment.</param>
        /// <param name="currencyConversion">currencyConversion.</param>
        /// <param name="merchantOverrideFlag">merchantOverrideFlag (default to false).</param>
        /// <param name="capturedSignature">capturedSignature.</param>
        /// <param name="protectedSignature">protectedSignature.</param>
        /// <param name="customerLanguage">customerLanguage.</param>
        /// <param name="onlineFlag">onlineFlag (default to true).</param>
        /// <param name="authenticationMethod">authenticationMethod.</param>
        /// <param name="validityDate">validityDate.</param>
        /// <param name="paymentAcquirerData">paymentAcquirerData.</param>
        public PaymentResult(PaymentType? paymentType = default(PaymentType?), PaymentInstrumentData paymentInstrumentData = default(PaymentInstrumentData), AmountsResp amountsResp = default(AmountsResp), Instalment instalment = default(Instalment), List<CurrencyConversion> currencyConversion = default(List<CurrencyConversion>), bool? merchantOverrideFlag = false, CapturedSignature capturedSignature = default(CapturedSignature), string protectedSignature = default(string), string customerLanguage = default(string), bool? onlineFlag = true, List<AuthenticationMethodEnum> authenticationMethod = default(List<AuthenticationMethodEnum>), DateTime validityDate = default(DateTime), PaymentAcquirerData paymentAcquirerData = default(PaymentAcquirerData))
        {
            this.PaymentType = paymentType;
            this.PaymentInstrumentData = paymentInstrumentData;
            this.AmountsResp = amountsResp;
            this.Instalment = instalment;
            this.CurrencyConversion = currencyConversion;
            this.MerchantOverrideFlag = merchantOverrideFlag;
            this.CapturedSignature = capturedSignature;
            this.ProtectedSignature = protectedSignature;
            this.CustomerLanguage = customerLanguage;
            this.OnlineFlag = onlineFlag;
            this.AuthenticationMethod = authenticationMethod;
            this.ValidityDate = validityDate;
            this.PaymentAcquirerData = paymentAcquirerData;
        }

        /// <summary>
        /// Gets or Sets PaymentInstrumentData
        /// </summary>
        [DataMember(Name = "PaymentInstrumentData", EmitDefaultValue = false)]
        public PaymentInstrumentData PaymentInstrumentData { get; set; }

        /// <summary>
        /// Gets or Sets AmountsResp
        /// </summary>
        [DataMember(Name = "AmountsResp", EmitDefaultValue = false)]
        public AmountsResp AmountsResp { get; set; }

        /// <summary>
        /// Gets or Sets Instalment
        /// </summary>
        [DataMember(Name = "Instalment", EmitDefaultValue = false)]
        public Instalment Instalment { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyConversion
        /// </summary>
        [DataMember(Name = "CurrencyConversion", EmitDefaultValue = false)]
        public List<CurrencyConversion> CurrencyConversion { get; set; }

        /// <summary>
        /// Gets or Sets MerchantOverrideFlag
        /// </summary>
        [DataMember(Name = "MerchantOverrideFlag", EmitDefaultValue = false)]
        public bool? MerchantOverrideFlag { get; set; }

        /// <summary>
        /// Gets or Sets CapturedSignature
        /// </summary>
        [DataMember(Name = "CapturedSignature", EmitDefaultValue = false)]
        public CapturedSignature CapturedSignature { get; set; }

        /// <summary>
        /// Gets or Sets ProtectedSignature
        /// </summary>
        [DataMember(Name = "ProtectedSignature", EmitDefaultValue = false)]
        public string ProtectedSignature { get; set; }

        /// <summary>
        /// Gets or Sets CustomerLanguage
        /// </summary>
        [DataMember(Name = "CustomerLanguage", EmitDefaultValue = false)]
        public string CustomerLanguage { get; set; }

        /// <summary>
        /// Gets or Sets OnlineFlag
        /// </summary>
        [DataMember(Name = "OnlineFlag", EmitDefaultValue = false)]
        public bool? OnlineFlag { get; set; }

        /// <summary>
        /// Gets or Sets AuthenticationMethod
        /// </summary>
        [DataMember(Name = "AuthenticationMethod", EmitDefaultValue = false)]
        public List<PaymentResult.AuthenticationMethodEnum> AuthenticationMethod { get; set; }

        /// <summary>
        /// Gets or Sets ValidityDate
        /// </summary>
        [DataMember(Name = "ValidityDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime ValidityDate { get; set; }

        /// <summary>
        /// Gets or Sets PaymentAcquirerData
        /// </summary>
        [DataMember(Name = "PaymentAcquirerData", EmitDefaultValue = false)]
        public PaymentAcquirerData PaymentAcquirerData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentResult {\n");
            sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
            sb.Append("  PaymentInstrumentData: ").Append(PaymentInstrumentData).Append("\n");
            sb.Append("  AmountsResp: ").Append(AmountsResp).Append("\n");
            sb.Append("  Instalment: ").Append(Instalment).Append("\n");
            sb.Append("  CurrencyConversion: ").Append(CurrencyConversion).Append("\n");
            sb.Append("  MerchantOverrideFlag: ").Append(MerchantOverrideFlag).Append("\n");
            sb.Append("  CapturedSignature: ").Append(CapturedSignature).Append("\n");
            sb.Append("  ProtectedSignature: ").Append(ProtectedSignature).Append("\n");
            sb.Append("  CustomerLanguage: ").Append(CustomerLanguage).Append("\n");
            sb.Append("  OnlineFlag: ").Append(OnlineFlag).Append("\n");
            sb.Append("  AuthenticationMethod: ").Append(AuthenticationMethod).Append("\n");
            sb.Append("  ValidityDate: ").Append(ValidityDate).Append("\n");
            sb.Append("  PaymentAcquirerData: ").Append(PaymentAcquirerData).Append("\n");
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
            return this.Equals(input as PaymentResult);
        }

        /// <summary>
        /// Returns true if PaymentResult instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PaymentType == input.PaymentType ||
                    this.PaymentType.Equals(input.PaymentType)
                ) && 
                (
                    this.PaymentInstrumentData == input.PaymentInstrumentData ||
                    (this.PaymentInstrumentData != null &&
                    this.PaymentInstrumentData.Equals(input.PaymentInstrumentData))
                ) && 
                (
                    this.AmountsResp == input.AmountsResp ||
                    (this.AmountsResp != null &&
                    this.AmountsResp.Equals(input.AmountsResp))
                ) && 
                (
                    this.Instalment == input.Instalment ||
                    (this.Instalment != null &&
                    this.Instalment.Equals(input.Instalment))
                ) && 
                (
                    this.CurrencyConversion == input.CurrencyConversion ||
                    this.CurrencyConversion != null &&
                    input.CurrencyConversion != null &&
                    this.CurrencyConversion.SequenceEqual(input.CurrencyConversion)
                ) && 
                (
                    this.MerchantOverrideFlag == input.MerchantOverrideFlag ||
                    this.MerchantOverrideFlag.Equals(input.MerchantOverrideFlag)
                ) && 
                (
                    this.CapturedSignature == input.CapturedSignature ||
                    (this.CapturedSignature != null &&
                    this.CapturedSignature.Equals(input.CapturedSignature))
                ) && 
                (
                    this.ProtectedSignature == input.ProtectedSignature ||
                    (this.ProtectedSignature != null &&
                    this.ProtectedSignature.Equals(input.ProtectedSignature))
                ) && 
                (
                    this.CustomerLanguage == input.CustomerLanguage ||
                    (this.CustomerLanguage != null &&
                    this.CustomerLanguage.Equals(input.CustomerLanguage))
                ) && 
                (
                    this.OnlineFlag == input.OnlineFlag ||
                    this.OnlineFlag.Equals(input.OnlineFlag)
                ) && 
                (
                    this.AuthenticationMethod == input.AuthenticationMethod ||
                    this.AuthenticationMethod != null &&
                    input.AuthenticationMethod != null &&
                    this.AuthenticationMethod.SequenceEqual(input.AuthenticationMethod)
                ) && 
                (
                    this.ValidityDate == input.ValidityDate ||
                    (this.ValidityDate != null &&
                    this.ValidityDate.Equals(input.ValidityDate))
                ) && 
                (
                    this.PaymentAcquirerData == input.PaymentAcquirerData ||
                    (this.PaymentAcquirerData != null &&
                    this.PaymentAcquirerData.Equals(input.PaymentAcquirerData))
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
                hashCode = (hashCode * 59) + this.PaymentType.GetHashCode();
                if (this.PaymentInstrumentData != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentInstrumentData.GetHashCode();
                }
                if (this.AmountsResp != null)
                {
                    hashCode = (hashCode * 59) + this.AmountsResp.GetHashCode();
                }
                if (this.Instalment != null)
                {
                    hashCode = (hashCode * 59) + this.Instalment.GetHashCode();
                }
                if (this.CurrencyConversion != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyConversion.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MerchantOverrideFlag.GetHashCode();
                if (this.CapturedSignature != null)
                {
                    hashCode = (hashCode * 59) + this.CapturedSignature.GetHashCode();
                }
                if (this.ProtectedSignature != null)
                {
                    hashCode = (hashCode * 59) + this.ProtectedSignature.GetHashCode();
                }
                if (this.CustomerLanguage != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerLanguage.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OnlineFlag.GetHashCode();
                if (this.AuthenticationMethod != null)
                {
                    hashCode = (hashCode * 59) + this.AuthenticationMethod.GetHashCode();
                }
                if (this.ValidityDate != null)
                {
                    hashCode = (hashCode * 59) + this.ValidityDate.GetHashCode();
                }
                if (this.PaymentAcquirerData != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentAcquirerData.GetHashCode();
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

            yield break;
        }
    }

}
