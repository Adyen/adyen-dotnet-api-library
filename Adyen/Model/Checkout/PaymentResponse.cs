/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 69
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

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// PaymentResponse
    /// </summary>
    [DataContract(Name = "PaymentResponse")]
    public partial class PaymentResponse : IEquatable<PaymentResponse>, IValidatableObject
    {
        /// <summary>
        /// The result of the payment. For more information, see [Result codes](https://docs.adyen.com/online-payments/payment-result-codes).  Possible values:  * **AuthenticationFinished** – The payment has been successfully authenticated with 3D Secure 2. Returned for 3D Secure 2 authentication-only transactions. * **AuthenticationNotRequired** – The transaction does not require 3D Secure authentication. Returned for [standalone authentication-only integrations](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only). * **Authorised** – The payment was successfully authorised. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state. * **Cancelled** – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state. * **ChallengeShopper** – The issuer requires further shopper interaction before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Error** – There was an error when the payment was being processed. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state. * **IdentifyShopper** – The issuer requires the shopper&#39;s device fingerprint before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Pending** – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment. * **PresentToShopper** – Indicates that the response contains additional information that you need to present to a shopper, so that they can use it to complete a payment. * **Received** – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments. * **RedirectShopper** – Indicates the shopper should be redirected to an external web page or app to complete the authorisation. * **Refused** – Indicates the payment was refused. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state.
        /// </summary>
        /// <value>The result of the payment. For more information, see [Result codes](https://docs.adyen.com/online-payments/payment-result-codes).  Possible values:  * **AuthenticationFinished** – The payment has been successfully authenticated with 3D Secure 2. Returned for 3D Secure 2 authentication-only transactions. * **AuthenticationNotRequired** – The transaction does not require 3D Secure authentication. Returned for [standalone authentication-only integrations](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only). * **Authorised** – The payment was successfully authorised. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state. * **Cancelled** – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state. * **ChallengeShopper** – The issuer requires further shopper interaction before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Error** – There was an error when the payment was being processed. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state. * **IdentifyShopper** – The issuer requires the shopper&#39;s device fingerprint before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Pending** – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment. * **PresentToShopper** – Indicates that the response contains additional information that you need to present to a shopper, so that they can use it to complete a payment. * **Received** – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments. * **RedirectShopper** – Indicates the shopper should be redirected to an external web page or app to complete the authorisation. * **Refused** – Indicates the payment was refused. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResultCodeEnum
        {
            /// <summary>
            /// Enum AuthenticationFinished for value: AuthenticationFinished
            /// </summary>
            [EnumMember(Value = "AuthenticationFinished")]
            AuthenticationFinished = 1,

            /// <summary>
            /// Enum Authorised for value: Authorised
            /// </summary>
            [EnumMember(Value = "Authorised")]
            Authorised = 2,

            /// <summary>
            /// Enum Cancelled for value: Cancelled
            /// </summary>
            [EnumMember(Value = "Cancelled")]
            Cancelled = 3,

            /// <summary>
            /// Enum ChallengeShopper for value: ChallengeShopper
            /// </summary>
            [EnumMember(Value = "ChallengeShopper")]
            ChallengeShopper = 4,

            /// <summary>
            /// Enum Error for value: Error
            /// </summary>
            [EnumMember(Value = "Error")]
            Error = 5,

            /// <summary>
            /// Enum IdentifyShopper for value: IdentifyShopper
            /// </summary>
            [EnumMember(Value = "IdentifyShopper")]
            IdentifyShopper = 6,

            /// <summary>
            /// Enum Pending for value: Pending
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending = 7,

            /// <summary>
            /// Enum PresentToShopper for value: PresentToShopper
            /// </summary>
            [EnumMember(Value = "PresentToShopper")]
            PresentToShopper = 8,

            /// <summary>
            /// Enum Received for value: Received
            /// </summary>
            [EnumMember(Value = "Received")]
            Received = 9,

            /// <summary>
            /// Enum RedirectShopper for value: RedirectShopper
            /// </summary>
            [EnumMember(Value = "RedirectShopper")]
            RedirectShopper = 10,

            /// <summary>
            /// Enum Refused for value: Refused
            /// </summary>
            [EnumMember(Value = "Refused")]
            Refused = 11,

            /// <summary>
            /// Enum Success for value: Success
            /// </summary>
            [EnumMember(Value = "Success")]
            Success = 12

        }


        /// <summary>
        /// The result of the payment. For more information, see [Result codes](https://docs.adyen.com/online-payments/payment-result-codes).  Possible values:  * **AuthenticationFinished** – The payment has been successfully authenticated with 3D Secure 2. Returned for 3D Secure 2 authentication-only transactions. * **AuthenticationNotRequired** – The transaction does not require 3D Secure authentication. Returned for [standalone authentication-only integrations](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only). * **Authorised** – The payment was successfully authorised. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state. * **Cancelled** – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state. * **ChallengeShopper** – The issuer requires further shopper interaction before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Error** – There was an error when the payment was being processed. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state. * **IdentifyShopper** – The issuer requires the shopper&#39;s device fingerprint before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Pending** – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment. * **PresentToShopper** – Indicates that the response contains additional information that you need to present to a shopper, so that they can use it to complete a payment. * **Received** – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments. * **RedirectShopper** – Indicates the shopper should be redirected to an external web page or app to complete the authorisation. * **Refused** – Indicates the payment was refused. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state.
        /// </summary>
        /// <value>The result of the payment. For more information, see [Result codes](https://docs.adyen.com/online-payments/payment-result-codes).  Possible values:  * **AuthenticationFinished** – The payment has been successfully authenticated with 3D Secure 2. Returned for 3D Secure 2 authentication-only transactions. * **AuthenticationNotRequired** – The transaction does not require 3D Secure authentication. Returned for [standalone authentication-only integrations](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only). * **Authorised** – The payment was successfully authorised. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state. * **Cancelled** – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state. * **ChallengeShopper** – The issuer requires further shopper interaction before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Error** – There was an error when the payment was being processed. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state. * **IdentifyShopper** – The issuer requires the shopper&#39;s device fingerprint before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Pending** – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment. * **PresentToShopper** – Indicates that the response contains additional information that you need to present to a shopper, so that they can use it to complete a payment. * **Received** – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments. * **RedirectShopper** – Indicates the shopper should be redirected to an external web page or app to complete the authorisation. * **Refused** – Indicates the payment was refused. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state.</value>
        [DataMember(Name = "resultCode", EmitDefaultValue = false)]
        public ResultCodeEnum? ResultCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResponse" /> class.
        /// </summary>
        /// <param name="action">action.</param>
        /// <param name="additionalData">Contains additional information about the payment. Some data fields are included only if you select them first: Go to **Customer Area** &gt; **Developers** &gt; **Additional data**..</param>
        /// <param name="amount">amount.</param>
        /// <param name="donationToken">Donation Token containing payment details for Adyen Giving..</param>
        /// <param name="fraudResult">fraudResult.</param>
        /// <param name="merchantReference">The reference to uniquely identify a payment. This reference is used in all communication with you about the payment status. We recommend using a unique value per payment; however, it is not a requirement. If you need to provide multiple references for a transaction, separate them with hyphens (\&quot;-\&quot;). Maximum length: 80 characters..</param>
        /// <param name="order">order.</param>
        /// <param name="paymentMethod">paymentMethod.</param>
        /// <param name="pspReference">Adyen&#39;s 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.  &gt; For payment methods that require a redirect or additional action, you will get this value in the &#x60;/payments/details&#x60; response..</param>
        /// <param name="refusalReason">If the payment&#39;s authorisation is refused or an error occurs during authorisation, this field holds Adyen&#39;s mapped reason for the refusal or a description of the error. When a transaction fails, the authorisation response includes &#x60;resultCode&#x60; and &#x60;refusalReason&#x60; values.  For more information, see [Refusal reasons](https://docs.adyen.com/development-resources/refusal-reasons)..</param>
        /// <param name="refusalReasonCode">Code that specifies the refusal reason. For more information, see [Authorisation refusal reasons](https://docs.adyen.com/development-resources/refusal-reasons)..</param>
        /// <param name="resultCode">The result of the payment. For more information, see [Result codes](https://docs.adyen.com/online-payments/payment-result-codes).  Possible values:  * **AuthenticationFinished** – The payment has been successfully authenticated with 3D Secure 2. Returned for 3D Secure 2 authentication-only transactions. * **AuthenticationNotRequired** – The transaction does not require 3D Secure authentication. Returned for [standalone authentication-only integrations](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only). * **Authorised** – The payment was successfully authorised. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state. * **Cancelled** – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state. * **ChallengeShopper** – The issuer requires further shopper interaction before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Error** – There was an error when the payment was being processed. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state. * **IdentifyShopper** – The issuer requires the shopper&#39;s device fingerprint before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Pending** – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment. * **PresentToShopper** – Indicates that the response contains additional information that you need to present to a shopper, so that they can use it to complete a payment. * **Received** – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments. * **RedirectShopper** – Indicates the shopper should be redirected to an external web page or app to complete the authorisation. * **Refused** – Indicates the payment was refused. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state..</param>
        /// <param name="threeDS2ResponseData">threeDS2ResponseData.</param>
        /// <param name="threeDS2Result">threeDS2Result.</param>
        /// <param name="threeDSPaymentData">When non-empty, contains a value that you must submit to the &#x60;/payments/details&#x60; endpoint as &#x60;paymentData&#x60;..</param>
        public PaymentResponse(PaymentResponseAction action = default(PaymentResponseAction), Dictionary<string, string> additionalData = default(Dictionary<string, string>), Amount amount = default(Amount), string donationToken = default(string), FraudResult fraudResult = default(FraudResult), string merchantReference = default(string), CheckoutOrderResponse order = default(CheckoutOrderResponse), ResponsePaymentMethod paymentMethod = default(ResponsePaymentMethod), string pspReference = default(string), string refusalReason = default(string), string refusalReasonCode = default(string), ResultCodeEnum? resultCode = default(ResultCodeEnum?), ThreeDS2ResponseData threeDS2ResponseData = default(ThreeDS2ResponseData), ThreeDS2Result threeDS2Result = default(ThreeDS2Result), string threeDSPaymentData = default(string))
        {
            this.Action = action;
            this.AdditionalData = additionalData;
            this.Amount = amount;
            this.DonationToken = donationToken;
            this.FraudResult = fraudResult;
            this.MerchantReference = merchantReference;
            this.Order = order;
            this.PaymentMethod = paymentMethod;
            this.PspReference = pspReference;
            this.RefusalReason = refusalReason;
            this.RefusalReasonCode = refusalReasonCode;
            this.ResultCode = resultCode;
            this.ThreeDS2ResponseData = threeDS2ResponseData;
            this.ThreeDS2Result = threeDS2Result;
            this.ThreeDSPaymentData = threeDSPaymentData;
        }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public PaymentResponseAction Action { get; set; }

        /// <summary>
        /// Contains additional information about the payment. Some data fields are included only if you select them first: Go to **Customer Area** &gt; **Developers** &gt; **Additional data**.
        /// </summary>
        /// <value>Contains additional information about the payment. Some data fields are included only if you select them first: Go to **Customer Area** &gt; **Developers** &gt; **Additional data**.</value>
        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Amount Amount { get; set; }

        /// <summary>
        /// Donation Token containing payment details for Adyen Giving.
        /// </summary>
        /// <value>Donation Token containing payment details for Adyen Giving.</value>
        [DataMember(Name = "donationToken", EmitDefaultValue = false)]
        public string DonationToken { get; set; }

        /// <summary>
        /// Gets or Sets FraudResult
        /// </summary>
        [DataMember(Name = "fraudResult", EmitDefaultValue = false)]
        public FraudResult FraudResult { get; set; }

        /// <summary>
        /// The reference to uniquely identify a payment. This reference is used in all communication with you about the payment status. We recommend using a unique value per payment; however, it is not a requirement. If you need to provide multiple references for a transaction, separate them with hyphens (\&quot;-\&quot;). Maximum length: 80 characters.
        /// </summary>
        /// <value>The reference to uniquely identify a payment. This reference is used in all communication with you about the payment status. We recommend using a unique value per payment; however, it is not a requirement. If you need to provide multiple references for a transaction, separate them with hyphens (\&quot;-\&quot;). Maximum length: 80 characters.</value>
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        public string MerchantReference { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public CheckoutOrderResponse Order { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name = "paymentMethod", EmitDefaultValue = false)]
        public ResponsePaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Adyen&#39;s 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.  &gt; For payment methods that require a redirect or additional action, you will get this value in the &#x60;/payments/details&#x60; response.
        /// </summary>
        /// <value>Adyen&#39;s 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.  &gt; For payment methods that require a redirect or additional action, you will get this value in the &#x60;/payments/details&#x60; response.</value>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        public string PspReference { get; set; }

        /// <summary>
        /// If the payment&#39;s authorisation is refused or an error occurs during authorisation, this field holds Adyen&#39;s mapped reason for the refusal or a description of the error. When a transaction fails, the authorisation response includes &#x60;resultCode&#x60; and &#x60;refusalReason&#x60; values.  For more information, see [Refusal reasons](https://docs.adyen.com/development-resources/refusal-reasons).
        /// </summary>
        /// <value>If the payment&#39;s authorisation is refused or an error occurs during authorisation, this field holds Adyen&#39;s mapped reason for the refusal or a description of the error. When a transaction fails, the authorisation response includes &#x60;resultCode&#x60; and &#x60;refusalReason&#x60; values.  For more information, see [Refusal reasons](https://docs.adyen.com/development-resources/refusal-reasons).</value>
        [DataMember(Name = "refusalReason", EmitDefaultValue = false)]
        public string RefusalReason { get; set; }

        /// <summary>
        /// Code that specifies the refusal reason. For more information, see [Authorisation refusal reasons](https://docs.adyen.com/development-resources/refusal-reasons).
        /// </summary>
        /// <value>Code that specifies the refusal reason. For more information, see [Authorisation refusal reasons](https://docs.adyen.com/development-resources/refusal-reasons).</value>
        [DataMember(Name = "refusalReasonCode", EmitDefaultValue = false)]
        public string RefusalReasonCode { get; set; }

        /// <summary>
        /// Gets or Sets ThreeDS2ResponseData
        /// </summary>
        [DataMember(Name = "threeDS2ResponseData", EmitDefaultValue = false)]
        public ThreeDS2ResponseData ThreeDS2ResponseData { get; set; }

        /// <summary>
        /// Gets or Sets ThreeDS2Result
        /// </summary>
        [DataMember(Name = "threeDS2Result", EmitDefaultValue = false)]
        public ThreeDS2Result ThreeDS2Result { get; set; }

        /// <summary>
        /// When non-empty, contains a value that you must submit to the &#x60;/payments/details&#x60; endpoint as &#x60;paymentData&#x60;.
        /// </summary>
        /// <value>When non-empty, contains a value that you must submit to the &#x60;/payments/details&#x60; endpoint as &#x60;paymentData&#x60;.</value>
        [DataMember(Name = "threeDSPaymentData", EmitDefaultValue = false)]
        public string ThreeDSPaymentData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentResponse {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  DonationToken: ").Append(DonationToken).Append("\n");
            sb.Append("  FraudResult: ").Append(FraudResult).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  RefusalReason: ").Append(RefusalReason).Append("\n");
            sb.Append("  RefusalReasonCode: ").Append(RefusalReasonCode).Append("\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
            sb.Append("  ThreeDS2ResponseData: ").Append(ThreeDS2ResponseData).Append("\n");
            sb.Append("  ThreeDS2Result: ").Append(ThreeDS2Result).Append("\n");
            sb.Append("  ThreeDSPaymentData: ").Append(ThreeDSPaymentData).Append("\n");
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
            return this.Equals(input as PaymentResponse);
        }

        /// <summary>
        /// Returns true if PaymentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.AdditionalData == input.AdditionalData ||
                    this.AdditionalData != null &&
                    input.AdditionalData != null &&
                    this.AdditionalData.SequenceEqual(input.AdditionalData)
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.DonationToken == input.DonationToken ||
                    (this.DonationToken != null &&
                    this.DonationToken.Equals(input.DonationToken))
                ) && 
                (
                    this.FraudResult == input.FraudResult ||
                    (this.FraudResult != null &&
                    this.FraudResult.Equals(input.FraudResult))
                ) && 
                (
                    this.MerchantReference == input.MerchantReference ||
                    (this.MerchantReference != null &&
                    this.MerchantReference.Equals(input.MerchantReference))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && 
                (
                    this.PspReference == input.PspReference ||
                    (this.PspReference != null &&
                    this.PspReference.Equals(input.PspReference))
                ) && 
                (
                    this.RefusalReason == input.RefusalReason ||
                    (this.RefusalReason != null &&
                    this.RefusalReason.Equals(input.RefusalReason))
                ) && 
                (
                    this.RefusalReasonCode == input.RefusalReasonCode ||
                    (this.RefusalReasonCode != null &&
                    this.RefusalReasonCode.Equals(input.RefusalReasonCode))
                ) && 
                (
                    this.ResultCode == input.ResultCode ||
                    this.ResultCode.Equals(input.ResultCode)
                ) && 
                (
                    this.ThreeDS2ResponseData == input.ThreeDS2ResponseData ||
                    (this.ThreeDS2ResponseData != null &&
                    this.ThreeDS2ResponseData.Equals(input.ThreeDS2ResponseData))
                ) && 
                (
                    this.ThreeDS2Result == input.ThreeDS2Result ||
                    (this.ThreeDS2Result != null &&
                    this.ThreeDS2Result.Equals(input.ThreeDS2Result))
                ) && 
                (
                    this.ThreeDSPaymentData == input.ThreeDSPaymentData ||
                    (this.ThreeDSPaymentData != null &&
                    this.ThreeDSPaymentData.Equals(input.ThreeDSPaymentData))
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
                if (this.Action != null)
                {
                    hashCode = (hashCode * 59) + this.Action.GetHashCode();
                }
                if (this.AdditionalData != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalData.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.DonationToken != null)
                {
                    hashCode = (hashCode * 59) + this.DonationToken.GetHashCode();
                }
                if (this.FraudResult != null)
                {
                    hashCode = (hashCode * 59) + this.FraudResult.GetHashCode();
                }
                if (this.MerchantReference != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantReference.GetHashCode();
                }
                if (this.Order != null)
                {
                    hashCode = (hashCode * 59) + this.Order.GetHashCode();
                }
                if (this.PaymentMethod != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentMethod.GetHashCode();
                }
                if (this.PspReference != null)
                {
                    hashCode = (hashCode * 59) + this.PspReference.GetHashCode();
                }
                if (this.RefusalReason != null)
                {
                    hashCode = (hashCode * 59) + this.RefusalReason.GetHashCode();
                }
                if (this.RefusalReasonCode != null)
                {
                    hashCode = (hashCode * 59) + this.RefusalReasonCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ResultCode.GetHashCode();
                if (this.ThreeDS2ResponseData != null)
                {
                    hashCode = (hashCode * 59) + this.ThreeDS2ResponseData.GetHashCode();
                }
                if (this.ThreeDS2Result != null)
                {
                    hashCode = (hashCode * 59) + this.ThreeDS2Result.GetHashCode();
                }
                if (this.ThreeDSPaymentData != null)
                {
                    hashCode = (hashCode * 59) + this.ThreeDSPaymentData.GetHashCode();
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
