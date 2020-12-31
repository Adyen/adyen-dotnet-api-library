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
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Adyen.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// CheckoutBalanceCheckResponse
    /// </summary>
    [DataContract]
    public partial class CheckoutBalanceCheckResponse : IEquatable<CheckoutBalanceCheckResponse>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="CheckoutBalanceCheckResponse" /> class.
        /// </summary>
        /// <param name="additionalData">This field contains additional data, which may be required to return in a particular payment response. To choose data fields to be returned, go to **Customer Area** &gt; **Account** &gt; **API URLs** &gt; **Additional data settings**..</param>
        /// <param name="balance">balance (required).</param>
        /// <param name="fraudResult">fraudResult.</param>
        /// <param name="pspReference">Adyen&#x27;s 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.  &gt; &#x60;pspReference&#x60; is returned only for non-redirect payment methods..</param>
        /// <param name="refusalReason">If the payment&#x27;s authorisation is refused or an error occurs during authorisation, this field holds Adyen&#x27;s mapped reason for the refusal or a description of the error. When a transaction fails, the authorisation response includes &#x60;resultCode&#x60; and &#x60;refusalReason&#x60; values.  For more information, see [Refusal reasons](https://docs.adyen.com/development-resources/refusal-reasons)..</param>
        /// <param name="resultCode">The result of the payment. For more information, see [Result codes](https://docs.adyen.com/checkout/payment-result-codes).  Possible values:  * **AuthenticationFinished** – The payment has been successfully authenticated with 3D Secure 2. Returned for 3D Secure 2 authentication-only transactions. * **AuthenticationNotRequired** – The transaction does not require 3D Secure authentication. Returned for [standalone authentication-only integrations](https://docs.adyen.com/checkout/3d-secure/other-3ds-flows/authentication-only). * **Authorised** – The payment was successfully authorised. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state. * **Cancelled** – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state. * **ChallengeShopper** – The issuer requires further shopper interaction before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Error** – There was an error when the payment was being processed. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state. * **IdentifyShopper** – The issuer requires the shopper&#x27;s device fingerprint before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Pending** – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment. * **PresentToShopper** – Indicates that the response contains additional information that you need to present to a shopper, so that they can use it to complete a payment. * **Received** – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments. * **RedirectShopper** – Indicates the shopper should be redirected to an external web page or app to complete the authorisation. * **Refused** – Indicates the payment was refused. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state..</param>
        /// <param name="transactionLimit">transactionLimit.</param>
        public CheckoutBalanceCheckResponse(
             Dictionary<string, string> additionalData =
                default(Dictionary<string, string>), Amount balance = default(Amount),
            FraudResult fraudResult = default(FraudResult), string pspReference = default(string),
            string refusalReason = default(string), ResultCodeEnum? resultCode = default(ResultCodeEnum?),
            Amount transactionLimit = default(Amount))
        {
            // to ensure "balance" is required (not null)
            if (balance == null)
            {
                throw new InvalidDataException(
                    "balance is a required property for CheckoutBalanceCheckResponse and cannot be null");
            }
            else
            {
                this.Balance = balance;
            }
            this.AdditionalData = additionalData;
            this.FraudResult = fraudResult;
            this.PspReference = pspReference;
            this.RefusalReason = refusalReason;
            this.ResultCode = resultCode;
            this.TransactionLimit = transactionLimit;
        }

        /// <summary>
        /// This field contains additional data, which may be required to return in a particular payment response. To choose data fields to be returned, go to **Customer Area** &gt; **Account** &gt; **API URLs** &gt; **Additional data settings**.
        /// </summary>
        /// <value>This field contains additional data, which may be required to return in a particular payment response. To choose data fields to be returned, go to **Customer Area** &gt; **Account** &gt; **API URLs** &gt; **Additional data settings**.</value>
        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// Gets or Sets Balance
        /// </summary>
        [DataMember(Name = "balance", EmitDefaultValue = false)]
        public Amount Balance { get; set; }

        /// <summary>
        /// Gets or Sets FraudResult
        /// </summary>
        [DataMember(Name = "fraudResult", EmitDefaultValue = false)]
        public FraudResult FraudResult { get; set; }

        /// <summary>
        /// Adyen&#x27;s 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.  &gt; &#x60;pspReference&#x60; is returned only for non-redirect payment methods.
        /// </summary>
        /// <value>Adyen&#x27;s 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.  &gt; &#x60;pspReference&#x60; is returned only for non-redirect payment methods.</value>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        public string PspReference { get; set; }

        /// <summary>
        /// If the payment&#x27;s authorisation is refused or an error occurs during authorisation, this field holds Adyen&#x27;s mapped reason for the refusal or a description of the error. When a transaction fails, the authorisation response includes &#x60;resultCode&#x60; and &#x60;refusalReason&#x60; values.  For more information, see [Refusal reasons](https://docs.adyen.com/development-resources/refusal-reasons).
        /// </summary>
        /// <value>If the payment&#x27;s authorisation is refused or an error occurs during authorisation, this field holds Adyen&#x27;s mapped reason for the refusal or a description of the error. When a transaction fails, the authorisation response includes &#x60;resultCode&#x60; and &#x60;refusalReason&#x60; values.  For more information, see [Refusal reasons](https://docs.adyen.com/development-resources/refusal-reasons).</value>
        [DataMember(Name = "refusalReason", EmitDefaultValue = false)]
        public string RefusalReason { get; set; }


        /// <summary>
        /// Gets or Sets TransactionLimit
        /// </summary>
        [DataMember(Name = "transactionLimit", EmitDefaultValue = false)]
        public Amount TransactionLimit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckoutBalanceCheckResponse {\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData.ToCollectionsString()).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  FraudResult: ").Append(FraudResult).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  RefusalReason: ").Append(RefusalReason).Append("\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
            sb.Append("  TransactionLimit: ").Append(TransactionLimit).Append("\n");
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
            return this.Equals(input as CheckoutBalanceCheckResponse);
        }

        /// <summary>
        /// Returns true if CheckoutBalanceCheckResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckoutBalanceCheckResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckoutBalanceCheckResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AdditionalData == input.AdditionalData ||
                    this.AdditionalData != null &&
                    this.AdditionalData.Equals(input.AdditionalData)
                ) &&
                (
                    this.Balance == input.Balance ||
                    this.Balance != null &&
                    this.Balance.Equals(input.Balance)
                ) &&
                (
                    this.FraudResult == input.FraudResult ||
                    this.FraudResult != null &&
                    this.FraudResult.Equals(input.FraudResult)
                ) &&
                (
                    this.PspReference == input.PspReference ||
                    this.PspReference != null &&
                    this.PspReference.Equals(input.PspReference)
                ) &&
                (
                    this.RefusalReason == input.RefusalReason ||
                    this.RefusalReason != null &&
                    this.RefusalReason.Equals(input.RefusalReason)
                ) &&
                (
                    this.ResultCode == input.ResultCode ||
                    this.ResultCode != null &&
                    this.ResultCode.Equals(input.ResultCode)
                ) &&
                (
                    this.TransactionLimit == input.TransactionLimit ||
                    this.TransactionLimit != null &&
                    this.TransactionLimit.Equals(input.TransactionLimit)
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
                if (this.AdditionalData != null)
                    hashCode = hashCode * 59 + this.AdditionalData.GetHashCode();
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.FraudResult != null)
                    hashCode = hashCode * 59 + this.FraudResult.GetHashCode();
                if (this.PspReference != null)
                    hashCode = hashCode * 59 + this.PspReference.GetHashCode();
                if (this.RefusalReason != null)
                    hashCode = hashCode * 59 + this.RefusalReason.GetHashCode();
                if (this.ResultCode != null)
                    hashCode = hashCode * 59 + this.ResultCode.GetHashCode();
                if (this.TransactionLimit != null)
                    hashCode = hashCode * 59 + this.TransactionLimit.GetHashCode();
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