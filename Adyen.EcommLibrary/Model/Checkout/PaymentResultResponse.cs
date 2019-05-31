using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.EcommLibrary.Model.Checkout
{
    /// <summary>
    /// PaymentResultResponse
    /// </summary>
    [DataContract]
    public partial class PaymentResultResponse : IEquatable<PaymentResultResponse>, IValidatableObject
    {
        /// <summary>
        /// The result of the payment. Possible values:  * **Authorised** – Indicates the payment authorisation was successfully completed. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state. * **Refused** – Indicates the payment was refused. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state. * **RedirectShopper** – Indicates the shopper should be redirected to an external web page or app to complete the authorisation. * **Received** – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments. * **Cancelled** – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state. * **Pending** – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment. For more information on handling a pending payment, refer to [Payments with pending status](https://docs.adyen.com/developers/development-resources/payments-with-pending-status). * **Error** – Indicates an error occurred during processing of the payment. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state.
        /// </summary>
        /// <value>The result of the payment. Possible values:  * **Authorised** – Indicates the payment authorisation was successfully completed. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state. * **Refused** – Indicates the payment was refused. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state. * **RedirectShopper** – Indicates the shopper should be redirected to an external web page or app to complete the authorisation. * **Received** – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments. * **Cancelled** – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state. * **Pending** – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment. For more information on handling a pending payment, refer to [Payments with pending status](https://docs.adyen.com/developers/development-resources/payments-with-pending-status). * **Error** – Indicates an error occurred during processing of the payment. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResultCodeEnum
        {
            /// <summary>
            /// Enum Authorised for value: Authorised
            /// </summary>
            [EnumMember(Value = "Authorised")] Authorised = 1,

            /// <summary>
            /// Enum PartiallyAuthorised for value: PartiallyAuthorised
            /// </summary>
            [EnumMember(Value = "PartiallyAuthorised")]
            PartiallyAuthorised = 2,

            /// <summary>
            /// Enum Refused for value: Refused
            /// </summary>
            [EnumMember(Value = "Refused")] Refused = 3,

            /// <summary>
            /// Enum Error for value: Error
            /// </summary>
            [EnumMember(Value = "Error")] Error = 4,

            /// <summary>
            /// Enum Cancelled for value: Cancelled
            /// </summary>
            [EnumMember(Value = "Cancelled")] Cancelled = 5,

            /// <summary>
            /// Enum Received for value: Received
            /// </summary>
            [EnumMember(Value = "Received")] Received = 6,

            /// <summary>
            /// Enum RedirectShopper for value: RedirectShopper
            /// </summary>
            [EnumMember(Value = "RedirectShopper")]
            RedirectShopper = 7
        }

        /// <summary>
        /// The result of the payment. Possible values:  * **Authorised** – Indicates the payment authorisation was successfully completed. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state. * **Refused** – Indicates the payment was refused. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state. * **RedirectShopper** – Indicates the shopper should be redirected to an external web page or app to complete the authorisation. * **Received** – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments. * **Cancelled** – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state. * **Pending** – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment. For more information on handling a pending payment, refer to [Payments with pending status](https://docs.adyen.com/developers/development-resources/payments-with-pending-status). * **Error** – Indicates an error occurred during processing of the payment. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state.
        /// </summary>
        /// <value>The result of the payment. Possible values:  * **Authorised** – Indicates the payment authorisation was successfully completed. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state. * **Refused** – Indicates the payment was refused. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state. * **RedirectShopper** – Indicates the shopper should be redirected to an external web page or app to complete the authorisation. * **Received** – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments. * **Cancelled** – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state. * **Pending** – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment. For more information on handling a pending payment, refer to [Payments with pending status](https://docs.adyen.com/developers/development-resources/payments-with-pending-status). * **Error** – Indicates an error occurred during processing of the payment. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state.</value>
        [DataMember(Name = "resultCode", EmitDefaultValue = false)]
        public ResultCodeEnum? ResultCode { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResultResponse" /> class.
        /// </summary>
        [JsonConstructor]
        protected PaymentResultResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResultResponse" /> class.
        /// </summary>
        /// <param name="AdditionalData">This field contains additional data, which may be required to return in a particular payment response. To choose data fields to be returned, go to **Customer Area** &gt; **Account** &gt; **API URLs**..</param>
        /// <param name="FraudResult">The fraud result properties of the payment..</param>
        /// <param name="MerchantReference">A unique value that you provided in the initial &#x60;/paymentSession&#x60; request as a &#x60;reference&#x60; field. (required).</param>
        /// <param name="PaymentMethod">The payment method used in the transaction. (required).</param>
        /// <param name="PspReference">Adyen&#39;s 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.  &gt; &#x60;pspReference&#x60; is returned only for non-redirect payment methods..</param>
        /// <param name="RefusalReason">If the payment&#39;s authorisation is refused or an error occurs during authorisation, this field holds Adyen&#39;s mapped reason for the refusal or a description of the error.  When a transaction fails, the authorisation response includes &#x60;resultCode&#x60; and &#x60;refusalReason&#x60; values..</param>
        /// <param name="RefusalReasonCode">Code that specifies the refusal reason. For more information, see [Authorisation refusal reasons](https://docs.adyen.com/developers/development-resources/response-handling#authorisationrefusalreasons)..</param>
        /// <param name="ResultCode">The result of the payment. Possible values:  * **Authorised** – Indicates the payment authorisation was successfully completed. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state. * **Refused** – Indicates the payment was refused. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state. * **RedirectShopper** – Indicates the shopper should be redirected to an external web page or app to complete the authorisation. * **Received** – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments. * **Cancelled** – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state. * **Pending** – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment. For more information on handling a pending payment, refer to [Payments with pending status](https://docs.adyen.com/developers/development-resources/payments-with-pending-status). * **Error** – Indicates an error occurred during processing of the payment. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state..</param>
        /// <param name="ServiceError">The type of the error..</param>
        /// <param name="ShopperLocale">The shopperLocale value provided in the payment request. (required).</param>
        public PaymentResultResponse(Dictionary<string, string> AdditionalData = default(Dictionary<string, string>),
            FraudResult FraudResult = default(FraudResult), string MerchantReference = default(string),
            string PaymentMethod = default(string), string PspReference = default(string),
            string RefusalReason = default(string), string RefusalReasonCode = default(string),
            ResultCodeEnum? ResultCode = default(ResultCodeEnum?), ServiceError ServiceError = default(ServiceError),
            string ShopperLocale = default(string))
        {
            // to ensure "MerchantReference" is required (not null)
            if (MerchantReference == null)
                throw new InvalidDataException(
                    "MerchantReference is a required property for PaymentResultResponse and cannot be null");
            else
                this.MerchantReference = MerchantReference;
            // to ensure "PaymentMethod" is required (not null)
            if (PaymentMethod == null)
                throw new InvalidDataException(
                    "PaymentMethod is a required property for PaymentResultResponse and cannot be null");
            else
                this.PaymentMethod = PaymentMethod;
            // to ensure "ShopperLocale" is required (not null)
            if (ShopperLocale == null)
                throw new InvalidDataException(
                    "ShopperLocale is a required property for PaymentResultResponse and cannot be null");
            else
                this.ShopperLocale = ShopperLocale;
            this.AdditionalData = AdditionalData;
            this.FraudResult = FraudResult;
            this.PspReference = PspReference;
            this.RefusalReason = RefusalReason;
            this.RefusalReasonCode = RefusalReasonCode;
            this.ResultCode = ResultCode;
            this.ServiceError = ServiceError;
        }

        /// <summary>
        /// This field contains additional data, which may be required to return in a particular payment response. To choose data fields to be returned, go to **Customer Area** &gt; **Account** &gt; **API URLs**.
        /// </summary>
        /// <value>This field contains additional data, which may be required to return in a particular payment response. To choose data fields to be returned, go to **Customer Area** &gt; **Account** &gt; **API URLs**.</value>
        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// The fraud result properties of the payment.
        /// </summary>
        /// <value>The fraud result properties of the payment.</value>
        [DataMember(Name = "fraudResult", EmitDefaultValue = false)]
        public FraudResult FraudResult { get; set; }

        /// <summary>
        /// A unique value that you provided in the initial &#x60;/paymentSession&#x60; request as a &#x60;reference&#x60; field.
        /// </summary>
        /// <value>A unique value that you provided in the initial &#x60;/paymentSession&#x60; request as a &#x60;reference&#x60; field.</value>
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        public string MerchantReference { get; set; }

        /// <summary>
        /// The payment method used in the transaction.
        /// </summary>
        /// <value>The payment method used in the transaction.</value>
        [DataMember(Name = "paymentMethod", EmitDefaultValue = false)]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Adyen&#39;s 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.  &gt; &#x60;pspReference&#x60; is returned only for non-redirect payment methods.
        /// </summary>
        /// <value>Adyen&#39;s 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.  &gt; &#x60;pspReference&#x60; is returned only for non-redirect payment methods.</value>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        public string PspReference { get; set; }

        /// <summary>
        /// If the payment&#39;s authorisation is refused or an error occurs during authorisation, this field holds Adyen&#39;s mapped reason for the refusal or a description of the error.  When a transaction fails, the authorisation response includes &#x60;resultCode&#x60; and &#x60;refusalReason&#x60; values.
        /// </summary>
        /// <value>If the payment&#39;s authorisation is refused or an error occurs during authorisation, this field holds Adyen&#39;s mapped reason for the refusal or a description of the error.  When a transaction fails, the authorisation response includes &#x60;resultCode&#x60; and &#x60;refusalReason&#x60; values.</value>
        [DataMember(Name = "refusalReason", EmitDefaultValue = false)]
        public string RefusalReason { get; set; }

        /// <summary>
        /// Code that specifies the refusal reason. For more information, see [Authorisation refusal reasons](https://docs.adyen.com/developers/development-resources/response-handling#authorisationrefusalreasons).
        /// </summary>
        /// <value>Code that specifies the refusal reason. For more information, see [Authorisation refusal reasons](https://docs.adyen.com/developers/development-resources/response-handling#authorisationrefusalreasons).</value>
        [DataMember(Name = "refusalReasonCode", EmitDefaultValue = false)]
        public string RefusalReasonCode { get; set; }


        /// <summary>
        /// The type of the error.
        /// </summary>
        /// <value>The type of the error.</value>
        [DataMember(Name = "serviceError", EmitDefaultValue = false)]
        public ServiceError ServiceError { get; set; }

        /// <summary>
        /// The shopperLocale value provided in the payment request.
        /// </summary>
        /// <value>The shopperLocale value provided in the payment request.</value>
        [DataMember(Name = "shopperLocale", EmitDefaultValue = false)]
        public string ShopperLocale { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentResultResponse {\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("  FraudResult: ").Append(FraudResult).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  RefusalReason: ").Append(RefusalReason).Append("\n");
            sb.Append("  RefusalReasonCode: ").Append(RefusalReasonCode).Append("\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
            sb.Append("  ServiceError: ").Append(ServiceError).Append("\n");
            sb.Append("  ShopperLocale: ").Append(ShopperLocale).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return Equals(input as PaymentResultResponse);
        }

        /// <summary>
        /// Returns true if PaymentResultResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentResultResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentResultResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    AdditionalData == input.AdditionalData ||
                    AdditionalData != null &&
                    AdditionalData.SequenceEqual(input.AdditionalData)
                ) &&
                (
                    FraudResult == input.FraudResult ||
                    FraudResult != null &&
                    FraudResult.Equals(input.FraudResult)
                ) &&
                (
                    MerchantReference == input.MerchantReference ||
                    MerchantReference != null &&
                    MerchantReference.Equals(input.MerchantReference)
                ) &&
                (
                    PaymentMethod == input.PaymentMethod ||
                    PaymentMethod != null &&
                    PaymentMethod.Equals(input.PaymentMethod)
                ) &&
                (
                    PspReference == input.PspReference ||
                    PspReference != null &&
                    PspReference.Equals(input.PspReference)
                ) &&
                (
                    RefusalReason == input.RefusalReason ||
                    RefusalReason != null &&
                    RefusalReason.Equals(input.RefusalReason)
                ) &&
                (
                    RefusalReasonCode == input.RefusalReasonCode ||
                    RefusalReasonCode != null &&
                    RefusalReasonCode.Equals(input.RefusalReasonCode)
                ) &&
                (
                    ResultCode == input.ResultCode ||
                    ResultCode != null &&
                    ResultCode.Equals(input.ResultCode)
                ) &&
                (
                    ServiceError == input.ServiceError ||
                    ServiceError != null &&
                    ServiceError.Equals(input.ServiceError)
                ) &&
                (
                    ShopperLocale == input.ShopperLocale ||
                    ShopperLocale != null &&
                    ShopperLocale.Equals(input.ShopperLocale)
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
                var hashCode = 41;
                if (AdditionalData != null)
                    hashCode = hashCode * 59 + AdditionalData.GetHashCode();
                if (FraudResult != null)
                    hashCode = hashCode * 59 + FraudResult.GetHashCode();
                if (MerchantReference != null)
                    hashCode = hashCode * 59 + MerchantReference.GetHashCode();
                if (PaymentMethod != null)
                    hashCode = hashCode * 59 + PaymentMethod.GetHashCode();
                if (PspReference != null)
                    hashCode = hashCode * 59 + PspReference.GetHashCode();
                if (RefusalReason != null)
                    hashCode = hashCode * 59 + RefusalReason.GetHashCode();
                if (RefusalReasonCode != null)
                    hashCode = hashCode * 59 + RefusalReasonCode.GetHashCode();
                if (ResultCode != null)
                    hashCode = hashCode * 59 + ResultCode.GetHashCode();
                if (ServiceError != null)
                    hashCode = hashCode * 59 + ServiceError.GetHashCode();
                if (ShopperLocale != null)
                    hashCode = hashCode * 59 + ShopperLocale.GetHashCode();
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