using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Adyen.EcommLibrary.Model.Checkout;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// PaymentsResponse
    /// </summary>
    [DataContract]
    public partial class PaymentsResponse : IEquatable<PaymentsResponse>, IValidatableObject
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
            RedirectShopper = 7,

            /// <summary>
            /// Enum IdentifyShopper for value: IdentifyShopper
            /// </summary>
            [EnumMember(Value = "IdentifyShopper")]
            IdentifyShopper = 8,

            /// <summary>
            /// Enum ChallengeShopper for value: ChallengeShopper
            /// </summary>
            [EnumMember(Value = "ChallengeShopper")]
            ChallengeShopper = 9,

            /// <summary>
            /// Enum PresentToShopper for value: PresentToShopper
            /// </summary>
            [EnumMember(Value = "PresentToShopper")]
            PresentToShopper = 10
        }

        /// <summary>
        /// The result of the payment. Possible values:  * **Authorised** – Indicates the payment authorisation was successfully completed. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state. * **Refused** – Indicates the payment was refused. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state. * **RedirectShopper** – Indicates the shopper should be redirected to an external web page or app to complete the authorisation. * **Received** – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments. * **Cancelled** – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state. * **Pending** – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment. For more information on handling a pending payment, refer to [Payments with pending status](https://docs.adyen.com/developers/development-resources/payments-with-pending-status). * **Error** – Indicates an error occurred during processing of the payment. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state.
        /// </summary>
        /// <value>The result of the payment. Possible values:  * **Authorised** – Indicates the payment authorisation was successfully completed. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state. * **Refused** – Indicates the payment was refused. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state. * **RedirectShopper** – Indicates the shopper should be redirected to an external web page or app to complete the authorisation. * **Received** – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments. * **Cancelled** – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state. * **Pending** – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment. For more information on handling a pending payment, refer to [Payments with pending status](https://docs.adyen.com/developers/development-resources/payments-with-pending-status). * **Error** – Indicates an error occurred during processing of the payment. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state.</value>
        [DataMember(Name = "resultCode", EmitDefaultValue = false)]
        public ResultCodeEnum? ResultCode { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsResponse" /> class.
        /// </summary>
        /// <param name="AdditionalData">This field contains additional data, which may be required to return in a particular payment response. To choose data fields to be returned, go to **Customer Area** &gt; **Account** &gt; **API URLs**..</param>
        /// <param name="Details">When non-empty, contains all the fields that you must submit to the &#x60;/payments/details&#x60; endpoint..</param>
        /// <param name="FraudResult">The fraud result properties of the payment..</param>
        /// <param name="PaymentData">When non-empty, contains a value that you must submit to the &#x60;/payments/details&#x60; endpoint..</param>
        /// <param name="PspReference">Adyen&#39;s 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.  &gt; &#x60;pspReference&#x60; is returned only for non-redirect payment methods..</param>
        /// <param name="Redirect">When the payment flow requires a redirect, this object contains information about the redirect URL..</param>
        /// <param name="RefusalReason">If the payment&#39;s authorisation is refused or an error occurs during authorisation, this field holds Adyen&#39;s mapped reason for the refusal or a description of the error.  When a transaction fails, the authorisation response includes &#x60;resultCode&#x60; and &#x60;refusalReason&#x60; values..</param>
        /// <param name="RefusalReasonCode">Code that specifies the refusal reason. For more information, see [Authorisation refusal reasons](https://docs.adyen.com/developers/development-resources/response-handling#authorisationrefusalreasons)..</param>
        /// <param name="ResultCode">The result of the payment. Possible values:  * **Authorised** – Indicates the payment authorisation was successfully completed. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state. * **Refused** – Indicates the payment was refused. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state. * **RedirectShopper** – Indicates the shopper should be redirected to an external web page or app to complete the authorisation. * **Received** – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments. * **Cancelled** – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state. * **Pending** – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment. For more information on handling a pending payment, refer to [Payments with pending status](https://docs.adyen.com/developers/development-resources/payments-with-pending-status). * **Error** – Indicates an error occurred during processing of the payment. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state..</param>
        /// <param name="Authentication">Contains tokens for fingerprint and challenge</param>
        public PaymentsResponse(Dictionary<string, string> AdditionalData = default(Dictionary<string, string>),
            List<InputDetail> Details = default(List<InputDetail>), FraudResult FraudResult = default(FraudResult),
            string PaymentData = default(string), string PspReference = default(string),
            Redirect Redirect = default(Redirect), string RefusalReason = default(string),
            string RefusalReasonCode = default(string), ResultCodeEnum? ResultCode = default(ResultCodeEnum?),
            Authentication Authentication = default(Authentication))
        {
            this.AdditionalData = AdditionalData;
            this.Details = Details;
            this.FraudResult = FraudResult;
            this.PaymentData = PaymentData;
            this.PspReference = PspReference;
            this.Redirect = Redirect;
            this.RefusalReason = RefusalReason;
            this.RefusalReasonCode = RefusalReasonCode;
            this.ResultCode = ResultCode;
            this.Authentication = Authentication;
        }


        /// <summary>
        /// This field contains additional data, which may be required to return in a particular payment response. To choose data fields to be returned, go to **Customer Area** &gt; **Account** &gt; **API URLs**.
        /// </summary>
        /// <value>This field contains additional data, which may be required to return in a particular payment response. To choose data fields to be returned, go to **Customer Area** &gt; **Account** &gt; **API URLs**.</value>
        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// When non-empty, contains all the fields that you must submit to the &#x60;/payments/details&#x60; endpoint.
        /// </summary>
        /// <value>When non-empty, contains all the fields that you must submit to the &#x60;/payments/details&#x60; endpoint.</value>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public List<InputDetail> Details { get; set; }

        /// <summary>
        /// The fraud result properties of the payment.
        /// </summary>
        /// <value>The fraud result properties of the payment.</value>
        [DataMember(Name = "fraudResult", EmitDefaultValue = false)]
        public FraudResult FraudResult { get; set; }

        /// <summary>
        /// When non-empty, contains a value that you must submit to the &#x60;/payments/details&#x60; endpoint.
        /// </summary>
        /// <value>When non-empty, contains a value that you must submit to the &#x60;/payments/details&#x60; endpoint.</value>
        [DataMember(Name = "paymentData", EmitDefaultValue = false)]
        public string PaymentData { get; set; }

        /// <summary>
        /// Adyen&#39;s 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.  &gt; &#x60;pspReference&#x60; is returned only for non-redirect payment methods.
        /// </summary>
        /// <value>Adyen&#39;s 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.  &gt; &#x60;pspReference&#x60; is returned only for non-redirect payment methods.</value>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        public string PspReference { get; set; }

        /// <summary>
        /// When the payment flow requires a redirect, this object contains information about the redirect URL.
        /// </summary>
        /// <value>When the payment flow requires a redirect, this object contains information about the redirect URL.</value>
        [DataMember(Name = "redirect", EmitDefaultValue = false)]
        public Redirect Redirect { get; set; }

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


        [DataMember(Name = "outputDetails", EmitDefaultValue = false)]
        public Dictionary<string, string> OutputDetails;

        [DataMember(Name= "authentication", EmitDefaultValue = false)]
        public Authentication Authentication { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentsResponse {\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  FraudResult: ").Append(FraudResult).Append("\n");
            sb.Append("  PaymentData: ").Append(PaymentData).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  Redirect: ").Append(Redirect).Append("\n");
            sb.Append("  RefusalReason: ").Append(RefusalReason).Append("\n");
            sb.Append("  RefusalReasonCode: ").Append(RefusalReasonCode).Append("\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
            sb.Append("  Authentication: ").Append(Authentication).Append("\n");
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
            return Equals(input as PaymentsResponse);
        }

        /// <summary>
        /// Returns true if PaymentsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentsResponse input)
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
                    Details == input.Details ||
                    Details != null &&
                    Details.SequenceEqual(input.Details)
                ) &&
                (
                    FraudResult == input.FraudResult ||
                    FraudResult != null &&
                    FraudResult.Equals(input.FraudResult)
                ) &&
                (
                    PaymentData == input.PaymentData ||
                    PaymentData != null &&
                    PaymentData.Equals(input.PaymentData)
                ) &&
                (
                    PspReference == input.PspReference ||
                    PspReference != null &&
                    PspReference.Equals(input.PspReference)
                ) &&
                (
                    Redirect == input.Redirect ||
                    Redirect != null &&
                    Redirect.Equals(input.Redirect)
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
                    Authentication == input.Authentication ||
                    Authentication != null &&
                    Authentication.Equals(input.Authentication)
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
                if (Details != null)
                    hashCode = hashCode * 59 + Details.GetHashCode();
                if (FraudResult != null)
                    hashCode = hashCode * 59 + FraudResult.GetHashCode();
                if (PaymentData != null)
                    hashCode = hashCode * 59 + PaymentData.GetHashCode();
                if (PspReference != null)
                    hashCode = hashCode * 59 + PspReference.GetHashCode();
                if (Redirect != null)
                    hashCode = hashCode * 59 + Redirect.GetHashCode();
                if (RefusalReason != null)
                    hashCode = hashCode * 59 + RefusalReason.GetHashCode();
                if (RefusalReasonCode != null)
                    hashCode = hashCode * 59 + RefusalReasonCode.GetHashCode();
                if (ResultCode != null)
                    hashCode = hashCode * 59 + ResultCode.GetHashCode();
                if (Authentication != null)
                    hashCode = hashCode * 59 + Authentication.GetHashCode();
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
