#region Licence

// 
//                        ######
//                        ######
//  ############    ####( ######  #####. ######  ############   ############
//  #############  #####( ######  #####. ######  #############  #############
//         ######  #####( ######  #####. ######  #####  ######  #####  ######
//  ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  ###### ######  #####( ######  #####. ######  #####          #####  ######
//  #############  #############  #############  #############  #####  ######
//   ############   ############  #############   ############  #####  ######
//                                       ######
//                                #############
//                                ############
// 
//  Adyen Dotnet API Library
// 
//  Copyright (c) 2020 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.

#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Adyen.Model.Checkout.Action;
using Adyen.Util;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// PaymentResponse
    /// </summary>
    [DataContract]
    public partial class PaymentResponse : IEquatable<PaymentResponse>, IValidatableObject
    {
        /// <summary>
        /// The result of the payment. For more information, see [Result codes](https://docs.adyen.com/checkout/payment-result-codes).  Possible values:  * **AuthenticationFinished** – The payment has been successfully authenticated with 3D Secure 2. Returned for 3D Secure 2 authentication-only transactions. * **AuthenticationNotRequired** – The transaction does not require 3D Secure authentication. Returned for [standalone authentication-only integrations](https://docs.adyen.com/checkout/3d-secure/other-3ds-flows/authentication-only). * **Authorised** – The payment was successfully authorised. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state. * **Cancelled** – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state. * **ChallengeShopper** – The issuer requires further shopper interaction before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Error** – There was an error when the payment was being processed. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state. * **IdentifyShopper** – The issuer requires the shopper&#x27;s device fingerprint before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Pending** – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment. * **PresentToShopper** – Indicates that the response contains additional information that you need to present to a shopper, so that they can use it to complete a payment. * **Received** – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments. * **RedirectShopper** – Indicates the shopper should be redirected to an external web page or app to complete the authorisation. * **Refused** – Indicates the payment was refused. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state.
        /// </summary>
        /// <value>The result of the payment. For more information, see [Result codes](https://docs.adyen.com/checkout/payment-result-codes).  Possible values:  * **AuthenticationFinished** – The payment has been successfully authenticated with 3D Secure 2. Returned for 3D Secure 2 authentication-only transactions. * **AuthenticationNotRequired** – The transaction does not require 3D Secure authentication. Returned for [standalone authentication-only integrations](https://docs.adyen.com/checkout/3d-secure/other-3ds-flows/authentication-only). * **Authorised** – The payment was successfully authorised. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state. * **Cancelled** – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state. * **ChallengeShopper** – The issuer requires further shopper interaction before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Error** – There was an error when the payment was being processed. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state. * **IdentifyShopper** – The issuer requires the shopper&#x27;s device fingerprint before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Pending** – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment. * **PresentToShopper** – Indicates that the response contains additional information that you need to present to a shopper, so that they can use it to complete a payment. * **Received** – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments. * **RedirectShopper** – Indicates the shopper should be redirected to an external web page or app to complete the authorisation. * **Refused** – Indicates the payment was refused. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResultCodeEnum
        {
            /// <summary>
            /// Enum AuthenticationFinished for value: AuthenticationFinished
            /// </summary>
            [EnumMember(Value = "AuthenticationFinished")] AuthenticationFinished = 1,

            /// <summary>
            /// Enum Authorised for value: Authorised
            /// </summary>
            [EnumMember(Value = "Authorised")] Authorised = 2,

            /// <summary>
            /// Enum Cancelled for value: Cancelled
            /// </summary>
            [EnumMember(Value = "Cancelled")] Cancelled = 3,

            /// <summary>
            /// Enum ChallengeShopper for value: ChallengeShopper
            /// </summary>
            [EnumMember(Value = "ChallengeShopper")] ChallengeShopper = 4,

            /// <summary>
            /// Enum Error for value: Error
            /// </summary>
            [EnumMember(Value = "Error")] Error = 5,

            /// <summary>
            /// Enum IdentifyShopper for value: IdentifyShopper
            /// </summary>
            [EnumMember(Value = "IdentifyShopper")] IdentifyShopper = 6,

            /// <summary>
            /// Enum Pending for value: Pending
            /// </summary>
            [EnumMember(Value = "Pending")] Pending = 7,

            /// <summary>
            /// Enum PresentToShopper for value: PresentToShopper
            /// </summary>
            [EnumMember(Value = "PresentToShopper")] PresentToShopper = 8,

            /// <summary>
            /// Enum Received for value: Received
            /// </summary>
            [EnumMember(Value = "Received")] Received = 9,

            /// <summary>
            /// Enum RedirectShopper for value: RedirectShopper
            /// </summary>
            [EnumMember(Value = "RedirectShopper")] RedirectShopper = 10,

            /// <summary>
            /// Enum Refused for value: Refused
            /// </summary>
            [EnumMember(Value = "Refused")] Refused = 11
        }

        /// <summary>
        /// The result of the payment. For more information, see [Result codes](https://docs.adyen.com/checkout/payment-result-codes).  Possible values:  * **AuthenticationFinished** – The payment has been successfully authenticated with 3D Secure 2. Returned for 3D Secure 2 authentication-only transactions. * **AuthenticationNotRequired** – The transaction does not require 3D Secure authentication. Returned for [standalone authentication-only integrations](https://docs.adyen.com/checkout/3d-secure/other-3ds-flows/authentication-only). * **Authorised** – The payment was successfully authorised. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state. * **Cancelled** – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state. * **ChallengeShopper** – The issuer requires further shopper interaction before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Error** – There was an error when the payment was being processed. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state. * **IdentifyShopper** – The issuer requires the shopper&#x27;s device fingerprint before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Pending** – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment. * **PresentToShopper** – Indicates that the response contains additional information that you need to present to a shopper, so that they can use it to complete a payment. * **Received** – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments. * **RedirectShopper** – Indicates the shopper should be redirected to an external web page or app to complete the authorisation. * **Refused** – Indicates the payment was refused. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state.
        /// </summary>
        /// <value>The result of the payment. For more information, see [Result codes](https://docs.adyen.com/checkout/payment-result-codes).  Possible values:  * **AuthenticationFinished** – The payment has been successfully authenticated with 3D Secure 2. Returned for 3D Secure 2 authentication-only transactions. * **AuthenticationNotRequired** – The transaction does not require 3D Secure authentication. Returned for [standalone authentication-only integrations](https://docs.adyen.com/checkout/3d-secure/other-3ds-flows/authentication-only). * **Authorised** – The payment was successfully authorised. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state. * **Cancelled** – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state. * **ChallengeShopper** – The issuer requires further shopper interaction before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Error** – There was an error when the payment was being processed. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state. * **IdentifyShopper** – The issuer requires the shopper&#x27;s device fingerprint before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Pending** – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment. * **PresentToShopper** – Indicates that the response contains additional information that you need to present to a shopper, so that they can use it to complete a payment. * **Received** – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments. * **RedirectShopper** – Indicates the shopper should be redirected to an external web page or app to complete the authorisation. * **Refused** – Indicates the payment was refused. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state.</value>
        [DataMember(Name = "resultCode", EmitDefaultValue = false)]
        public ResultCodeEnum? ResultCode { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResponse" /> class.
        /// </summary>
        /// <param name="action">Action to be taken for completing the payment..</param>
        /// <param name="additionalData">This field contains additional data, which may be required to return in a particular payment response. To choose data fields to be returned, go to **Customer Area** &gt; **Account** &gt; **API URLs** &gt; **Additional data settings**..</param>
        /// <param name="amount">amount.</param>
        /// <param name="authentication">Contains &#x60;threeds2.fingerprint&#x60; or &#x60;threeds2.challengeToken&#x60; values to be used in further calls to &#x60;/payments/details&#x60; endpoint. .</param>
        /// <param name="details">When non-empty, contains all the fields that you must submit to the &#x60;/payments/details&#x60; endpoint..</param>
        /// <param name="donationToken">donationToken.</param>
        /// <param name="fraudResult">fraudResult.</param>
        /// <param name="merchantReference">The reference to uniquely identify a payment. This reference is used in all communication with you about the payment status. We recommend using a unique value per payment; however, it is not a requirement. If you need to provide multiple references for a transaction, separate them with hyphens (\&quot;-\&quot;). Maximum length: 80 characters..</param>
        /// <param name="order">order.</param>
        /// <param name="outputDetails">Contains the details that will be presented to the shopper..</param>
        /// <param name="paymentData">When non-empty, contains a value that you must submit to the &#x60;/payments/details&#x60; endpoint..</param>
        /// <param name="pspReference">Adyen&#x27;s 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.  &gt; &#x60;pspReference&#x60; is returned only for non-redirect payment methods..</param>
        /// <param name="redirect">redirect.</param>
        /// <param name="refusalReason">If the payment&#x27;s authorisation is refused or an error occurs during authorisation, this field holds Adyen&#x27;s mapped reason for the refusal or a description of the error. When a transaction fails, the authorisation response includes &#x60;resultCode&#x60; and &#x60;refusalReason&#x60; values.  For more information, see [Refusal reasons](https://docs.adyen.com/development-resources/refusal-reasons)..</param>
        /// <param name="refusalReasonCode">Code that specifies the refusal reason. For more information, see [Authorisation refusal reasons](https://docs.adyen.com/development-resources/refusal-reasons)..</param>
        /// <param name="resultCode">The result of the payment. For more information, see [Result codes](https://docs.adyen.com/checkout/payment-result-codes).  Possible values:  * **AuthenticationFinished** – The payment has been successfully authenticated with 3D Secure 2. Returned for 3D Secure 2 authentication-only transactions. * **AuthenticationNotRequired** – The transaction does not require 3D Secure authentication. Returned for [standalone authentication-only integrations](https://docs.adyen.com/checkout/3d-secure/other-3ds-flows/authentication-only). * **Authorised** – The payment was successfully authorised. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state. * **Cancelled** – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state. * **ChallengeShopper** – The issuer requires further shopper interaction before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Error** – There was an error when the payment was being processed. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state. * **IdentifyShopper** – The issuer requires the shopper&#x27;s device fingerprint before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Pending** – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment. * **PresentToShopper** – Indicates that the response contains additional information that you need to present to a shopper, so that they can use it to complete a payment. * **Received** – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments. * **RedirectShopper** – Indicates the shopper should be redirected to an external web page or app to complete the authorisation. * **Refused** – Indicates the payment was refused. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state..</param>
        public PaymentResponse(IPaymentResponseAction action = default(IPaymentResponseAction),
            Dictionary<string, string> additionalData = default(Dictionary<string, string>),
            Amount amount = default(Amount),
            Dictionary<string, string> authentication = default(Dictionary<string, string>),
            List<InputDetail> details = default(List<InputDetail>), string donationToken = default(string),
            FraudResult fraudResult = default(FraudResult), string merchantReference = default(string),
            CheckoutOrderResponse order = default(CheckoutOrderResponse),
            Dictionary<string, string> outputDetails = default(Dictionary<string, string>),
            string paymentData = default(string), string pspReference = default(string),
            Redirect redirect = default(Redirect), string refusalReason = default(string),
            string refusalReasonCode = default(string), ResultCodeEnum? resultCode = default(ResultCodeEnum?))
        {
            this.Action = action;
            this.AdditionalData = additionalData;
            this.Amount = amount;
            this.Authentication = authentication;
            this.Details = details;
            this.DonationToken = donationToken;
            this.FraudResult = fraudResult;
            this.MerchantReference = merchantReference;
            this.Order = order;
            this.OutputDetails = outputDetails;
            this.PaymentData = paymentData;
            this.PspReference = pspReference;
            this.Redirect = redirect;
            this.RefusalReason = refusalReason;
            this.RefusalReasonCode = refusalReasonCode;
            this.ResultCode = resultCode;
        }

        /// <summary>
        /// Action to be taken for completing the payment.
        /// </summary>
        /// <value>Action to be taken for completing the payment.</value>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public IPaymentResponseAction Action { get; set; }

        /// <summary>
        /// This field contains additional data, which may be required to return in a particular payment response. To choose data fields to be returned, go to **Customer Area** &gt; **Account** &gt; **API URLs** &gt; **Additional data settings**.
        /// </summary>
        /// <value>This field contains additional data, which may be required to return in a particular payment response. To choose data fields to be returned, go to **Customer Area** &gt; **Account** &gt; **API URLs** &gt; **Additional data settings**.</value>
        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Amount Amount { get; set; }

        /// <summary>
        /// Contains &#x60;threeds2.fingerprint&#x60; or &#x60;threeds2.challengeToken&#x60; values to be used in further calls to &#x60;/payments/details&#x60; endpoint. 
        /// </summary>
        /// <value>Contains &#x60;threeds2.fingerprint&#x60; or &#x60;threeds2.challengeToken&#x60; values to be used in further calls to &#x60;/payments/details&#x60; endpoint. </value>
        [DataMember(Name = "authentication", EmitDefaultValue = false)]
        public Dictionary<string, string> Authentication { get; set; }

        /// <summary>
        /// When non-empty, contains all the fields that you must submit to the &#x60;/payments/details&#x60; endpoint.
        /// </summary>
        /// <value>When non-empty, contains all the fields that you must submit to the &#x60;/payments/details&#x60; endpoint.</value>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public List<InputDetail> Details { get; set; }

        /// <summary>
        /// Gets or Sets DonationToken
        /// </summary>
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
        /// Contains the details that will be presented to the shopper.
        /// </summary>
        /// <value>Contains the details that will be presented to the shopper.</value>
        [DataMember(Name = "outputDetails", EmitDefaultValue = false)]
        public Dictionary<string, string> OutputDetails { get; set; }

        /// <summary>
        /// When non-empty, contains a value that you must submit to the &#x60;/payments/details&#x60; endpoint.
        /// </summary>
        /// <value>When non-empty, contains a value that you must submit to the &#x60;/payments/details&#x60; endpoint.</value>
        [DataMember(Name = "paymentData", EmitDefaultValue = false)]
        public string PaymentData { get; set; }

        /// <summary>
        /// Adyen&#x27;s 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.  &gt; &#x60;pspReference&#x60; is returned only for non-redirect payment methods.
        /// </summary>
        /// <value>Adyen&#x27;s 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.  &gt; &#x60;pspReference&#x60; is returned only for non-redirect payment methods.</value>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        public string PspReference { get; set; }

        /// <summary>
        /// Gets or Sets Redirect
        /// </summary>
        [DataMember(Name = "redirect", EmitDefaultValue = false)]
        public Redirect Redirect { get; set; }

        /// <summary>
        /// If the payment&#x27;s authorisation is refused or an error occurs during authorisation, this field holds Adyen&#x27;s mapped reason for the refusal or a description of the error. When a transaction fails, the authorisation response includes &#x60;resultCode&#x60; and &#x60;refusalReason&#x60; values.  For more information, see [Refusal reasons](https://docs.adyen.com/development-resources/refusal-reasons).
        /// </summary>
        /// <value>If the payment&#x27;s authorisation is refused or an error occurs during authorisation, this field holds Adyen&#x27;s mapped reason for the refusal or a description of the error. When a transaction fails, the authorisation response includes &#x60;resultCode&#x60; and &#x60;refusalReason&#x60; values.  For more information, see [Refusal reasons](https://docs.adyen.com/development-resources/refusal-reasons).</value>
        [DataMember(Name = "refusalReason", EmitDefaultValue = false)]
        public string RefusalReason { get; set; }

        /// <summary>
        /// Code that specifies the refusal reason. For more information, see [Authorisation refusal reasons](https://docs.adyen.com/development-resources/refusal-reasons).
        /// </summary>
        /// <value>Code that specifies the refusal reason. For more information, see [Authorisation refusal reasons](https://docs.adyen.com/development-resources/refusal-reasons).</value>
        [DataMember(Name = "refusalReasonCode", EmitDefaultValue = false)]
        public string RefusalReasonCode { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentResponse {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData.ToCollectionsString()).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Authentication: ").Append(Authentication.ToCollectionsString()).Append("\n");
            sb.Append("  Details: ").Append(Details.ObjectListToString()).Append("\n");
            sb.Append("  DonationToken: ").Append(DonationToken).Append("\n");
            sb.Append("  FraudResult: ").Append(FraudResult).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  OutputDetails: ").Append(OutputDetails.ToCollectionsString()).Append("\n");
            sb.Append("  PaymentData: ").Append(PaymentData).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  Redirect: ").Append(Redirect).Append("\n");
            sb.Append("  RefusalReason: ").Append(RefusalReason).Append("\n");
            sb.Append("  RefusalReasonCode: ").Append(RefusalReasonCode).Append("\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
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
                return false;

            return
                (
                    this.Action == input.Action ||
                    this.Action != null &&
                    this.Action.Equals(input.Action)
                ) &&
                (
                    this.AdditionalData == input.AdditionalData ||
                    this.AdditionalData != null &&
                    this.AdditionalData.Equals(input.AdditionalData)
                ) &&
                (
                    this.Amount == input.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(input.Amount)
                ) &&
                (
                    this.Authentication == input.Authentication ||
                    this.Authentication != null &&
                    input.Authentication != null &&
                    this.Authentication.SequenceEqual(input.Authentication)
                ) &&
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    input.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                ) &&
                (
                    this.DonationToken == input.DonationToken ||
                    this.DonationToken != null &&
                    this.DonationToken.Equals(input.DonationToken)
                ) &&
                (
                    this.FraudResult == input.FraudResult ||
                    this.FraudResult != null &&
                    this.FraudResult.Equals(input.FraudResult)
                ) &&
                (
                    this.MerchantReference == input.MerchantReference ||
                    this.MerchantReference != null &&
                    this.MerchantReference.Equals(input.MerchantReference)
                ) &&
                (
                    this.Order == input.Order ||
                    this.Order != null &&
                    this.Order.Equals(input.Order)
                ) &&
                (
                    this.OutputDetails == input.OutputDetails ||
                    this.OutputDetails != null &&
                    input.OutputDetails != null &&
                    this.OutputDetails.SequenceEqual(input.OutputDetails)
                ) &&
                (
                    this.PaymentData == input.PaymentData ||
                    this.PaymentData != null &&
                    this.PaymentData.Equals(input.PaymentData)
                ) &&
                (
                    this.PspReference == input.PspReference ||
                    this.PspReference != null &&
                    this.PspReference.Equals(input.PspReference)
                ) &&
                (
                    this.Redirect == input.Redirect ||
                    this.Redirect != null &&
                    this.Redirect.Equals(input.Redirect)
                ) &&
                (
                    this.RefusalReason == input.RefusalReason ||
                    this.RefusalReason != null &&
                    this.RefusalReason.Equals(input.RefusalReason)
                ) &&
                (
                    this.RefusalReasonCode == input.RefusalReasonCode ||
                    this.RefusalReasonCode != null &&
                    this.RefusalReasonCode.Equals(input.RefusalReasonCode)
                ) &&
                (
                    this.ResultCode == input.ResultCode ||
                    this.ResultCode != null &&
                    this.ResultCode.Equals(input.ResultCode)
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
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.AdditionalData != null)
                    hashCode = hashCode * 59 + this.AdditionalData.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Authentication != null)
                    hashCode = hashCode * 59 + this.Authentication.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.DonationToken != null)
                    hashCode = hashCode * 59 + this.DonationToken.GetHashCode();
                if (this.FraudResult != null)
                    hashCode = hashCode * 59 + this.FraudResult.GetHashCode();
                if (this.MerchantReference != null)
                    hashCode = hashCode * 59 + this.MerchantReference.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.OutputDetails != null)
                    hashCode = hashCode * 59 + this.OutputDetails.GetHashCode();
                if (this.PaymentData != null)
                    hashCode = hashCode * 59 + this.PaymentData.GetHashCode();
                if (this.PspReference != null)
                    hashCode = hashCode * 59 + this.PspReference.GetHashCode();
                if (this.Redirect != null)
                    hashCode = hashCode * 59 + this.Redirect.GetHashCode();
                if (this.RefusalReason != null)
                    hashCode = hashCode * 59 + this.RefusalReason.GetHashCode();
                if (this.RefusalReasonCode != null)
                    hashCode = hashCode * 59 + this.RefusalReasonCode.GetHashCode();
                if (this.ResultCode != null)
                    hashCode = hashCode * 59 + this.ResultCode.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(
            ValidationContext validationContext)
        {
            yield break;
        }
    }
}