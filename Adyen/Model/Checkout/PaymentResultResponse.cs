#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// PaymentResultResponse
    /// </summary>
    [DataContract]
    public partial class PaymentResultResponse : IEquatable<PaymentResultResponse>, IValidatableObject
    {
        /// <summary>
        /// The result of the payment. Possible values:  * **AuthenticationFinished** – The payment has been successfully authenticated with 3D Secure 2. Returned for 3D Secure 2 authentication-only transactions. * **Authorised** – The payment was successfully authorised. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state. * **Cancelled** – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state. * **ChallengeShopper** – The issuer requires further shopper interaction before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Error** – There was an error when the payment was being processed. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state. * **IdentifyShopper** – The issuer requires the shopper&#x27;s device fingerprint before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Refused** – Indicates the payment was refused. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state. * **Pending** – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment. For more information on handling a pending payment, refer to [Payments with pending status](https://docs.adyen.com/development-resources/payments-with-pending-status). * **Received** – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments. * **RedirectShopper** – Indicates the shopper should be redirected to an external web page or app to complete the authorisation. 
        /// </summary>
        /// <value>The result of the payment. Possible values:  * **AuthenticationFinished** – The payment has been successfully authenticated with 3D Secure 2. Returned for 3D Secure 2 authentication-only transactions. * **Authorised** – The payment was successfully authorised. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state. * **Cancelled** – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state. * **ChallengeShopper** – The issuer requires further shopper interaction before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Error** – There was an error when the payment was being processed. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state. * **IdentifyShopper** – The issuer requires the shopper&#x27;s device fingerprint before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Refused** – Indicates the payment was refused. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state. * **Pending** – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment. For more information on handling a pending payment, refer to [Payments with pending status](https://docs.adyen.com/development-resources/payments-with-pending-status). * **Received** – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments. * **RedirectShopper** – Indicates the shopper should be redirected to an external web page or app to complete the authorisation. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResultCodeEnum
        {
            /// <summary>
            /// Enum AuthenticationFinished for value: AuthenticationFinished
            /// </summary>
            [EnumMember(Value = "AuthenticationFinished")]
            AuthenticationFinished = 0,
            /// <summary>
            /// Enum Authorised for value: Authorised
            /// </summary>
            [EnumMember(Value = "Authorised")]
            Authorised = 1,
            /// <summary>
            /// Enum Cancelled for value: Cancelled
            /// </summary>
            [EnumMember(Value = "Cancelled")]
            Cancelled = 2,
            /// <summary>
            /// Enum ChallengeShopper for value: ChallengeShopper
            /// </summary>
            [EnumMember(Value = "ChallengeShopper")]
            ChallengeShopper = 3,
            /// <summary>
            /// Enum Error for value: Error
            /// </summary>
            [EnumMember(Value = "Error")]
            Error = 4,
            /// <summary>
            /// Enum IdentifyShopper for value: IdentifyShopper
            /// </summary>
            [EnumMember(Value = "IdentifyShopper")]
            IdentifyShopper = 5,
            /// <summary>
            /// Enum Pending for value: Pending
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending = 6,
            /// <summary>
            /// Enum Received for value: Received
            /// </summary>
            [EnumMember(Value = "Received")]
            Received = 7,
            /// <summary>
            /// Enum RedirectShopper for value: RedirectShopper
            /// </summary>
            [EnumMember(Value = "RedirectShopper")]
            RedirectShopper = 8,
            /// <summary>
            /// Enum Refused for value: Refused
            /// </summary>
            [EnumMember(Value = "Refused")]
            Refused = 9
        }
        /// <summary>
        /// The result of the payment. Possible values:  * **AuthenticationFinished** – The payment has been successfully authenticated with 3D Secure 2. Returned for 3D Secure 2 authentication-only transactions. * **Authorised** – The payment was successfully authorised. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state. * **Cancelled** – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state. * **ChallengeShopper** – The issuer requires further shopper interaction before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Error** – There was an error when the payment was being processed. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state. * **IdentifyShopper** – The issuer requires the shopper&#x27;s device fingerprint before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Refused** – Indicates the payment was refused. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state. * **Pending** – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment. For more information on handling a pending payment, refer to [Payments with pending status](https://docs.adyen.com/development-resources/payments-with-pending-status). * **Received** – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments. * **RedirectShopper** – Indicates the shopper should be redirected to an external web page or app to complete the authorisation. 
        /// </summary>
        /// <value>The result of the payment. Possible values:  * **AuthenticationFinished** – The payment has been successfully authenticated with 3D Secure 2. Returned for 3D Secure 2 authentication-only transactions. * **Authorised** – The payment was successfully authorised. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state. * **Cancelled** – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state. * **ChallengeShopper** – The issuer requires further shopper interaction before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Error** – There was an error when the payment was being processed. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state. * **IdentifyShopper** – The issuer requires the shopper&#x27;s device fingerprint before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Refused** – Indicates the payment was refused. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state. * **Pending** – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment. For more information on handling a pending payment, refer to [Payments with pending status](https://docs.adyen.com/development-resources/payments-with-pending-status). * **Received** – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments. * **RedirectShopper** – Indicates the shopper should be redirected to an external web page or app to complete the authorisation. </value>
        [DataMember(Name = "resultCode", EmitDefaultValue = false)]
        public ResultCodeEnum? ResultCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResultResponse" /> class.
        /// </summary>
        [JsonConstructor]
        protected PaymentResultResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResultResponse" /> class.
        /// </summary>
        /// <param name="additionalData">This field contains additional data, which may be required to return in a particular payment response. To choose data fields to be returned, go to **Customer Area** &gt; **Account** &gt; **API URLs**..</param>
        /// <param name="fraudResult">fraudResult.</param>
        /// <param name="merchantReference">A unique value that you provided in the initial &#x60;/paymentSession&#x60; request as a &#x60;reference&#x60; field. (required).</param>
        /// <param name="paymentMethod">The payment method used in the transaction. (required).</param>
        /// <param name="pspReference">Adyen&#x27;s 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.  &gt; &#x60;pspReference&#x60; is returned only for non-redirect payment methods..</param>
        /// <param name="refusalReason">If the payment&#x27;s authorisation is refused or an error occurs during authorisation, this field holds Adyen&#x27;s mapped reason for the refusal or a description of the error.  When a transaction fails, the authorisation response includes &#x60;resultCode&#x60; and &#x60;refusalReason&#x60; values..</param>
        /// <param name="refusalReasonCode">Code that specifies the refusal reason. For more information, see [Authorisation refusal reasons](https://docs.adyen.com/development-resources/refusal-reasons)..</param>
        /// <param name="resultCode">The result of the payment. Possible values:  * **AuthenticationFinished** – The payment has been successfully authenticated with 3D Secure 2. Returned for 3D Secure 2 authentication-only transactions. * **Authorised** – The payment was successfully authorised. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state. * **Cancelled** – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state. * **ChallengeShopper** – The issuer requires further shopper interaction before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Error** – There was an error when the payment was being processed. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state. * **IdentifyShopper** – The issuer requires the shopper&#x27;s device fingerprint before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Refused** – Indicates the payment was refused. The reason is given in the &#x60;refusalReason&#x60; field. This is a final state. * **Pending** – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment. For more information on handling a pending payment, refer to [Payments with pending status](https://docs.adyen.com/development-resources/payments-with-pending-status). * **Received** – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments. * **RedirectShopper** – Indicates the shopper should be redirected to an external web page or app to complete the authorisation. .</param>
        /// <param name="serviceError">serviceError.</param>
        /// <param name="shopperLocale">The shopperLocale value provided in the payment request. (required).</param>
        public PaymentResultResponse(Dictionary<string, string> additionalData = default(Dictionary<string, string>), FraudResult fraudResult = default(FraudResult), string merchantReference = default(string), string paymentMethod = default(string), string pspReference = default(string), string refusalReason = default(string), string refusalReasonCode = default(string), ResultCodeEnum? resultCode = default(ResultCodeEnum?), ServiceError serviceError = default(ServiceError), string shopperLocale = default(string))
        {
            // to ensure "merchantReference" is required (not null)
            if (merchantReference == null)
            {
                throw new InvalidDataException("merchantReference is a required property for PaymentResultResponse and cannot be null");
            }
            else
            {
                this.MerchantReference = merchantReference;
            }
            // to ensure "paymentMethod" is required (not null)
            if (paymentMethod == null)
            {
                throw new InvalidDataException("paymentMethod is a required property for PaymentResultResponse and cannot be null");
            }
            else
            {
                this.PaymentMethod = paymentMethod;
            }
            // to ensure "shopperLocale" is required (not null)
            if (shopperLocale == null)
            {
                throw new InvalidDataException("shopperLocale is a required property for PaymentResultResponse and cannot be null");
            }
            else
            {
                this.ShopperLocale = shopperLocale;
            }
            this.AdditionalData = additionalData;
            this.FraudResult = fraudResult;
            this.PspReference = pspReference;
            this.RefusalReason = refusalReason;
            this.RefusalReasonCode = refusalReasonCode;
            this.ResultCode = resultCode;
            this.ServiceError = serviceError;
        }

        /// <summary>
        /// This field contains additional data, which may be required to return in a particular payment response. To choose data fields to be returned, go to **Customer Area** &gt; **Account** &gt; **API URLs**.
        /// </summary>
        /// <value>This field contains additional data, which may be required to return in a particular payment response. To choose data fields to be returned, go to **Customer Area** &gt; **Account** &gt; **API URLs**.</value>
        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        public Dictionary<string,string> AdditionalData { get; set; }

        /// <summary>
        /// Gets or Sets FraudResult
        /// </summary>
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
        /// Adyen&#x27;s 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.  &gt; &#x60;pspReference&#x60; is returned only for non-redirect payment methods.
        /// </summary>
        /// <value>Adyen&#x27;s 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.  &gt; &#x60;pspReference&#x60; is returned only for non-redirect payment methods.</value>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        public string PspReference { get; set; }

        /// <summary>
        /// If the payment&#x27;s authorisation is refused or an error occurs during authorisation, this field holds Adyen&#x27;s mapped reason for the refusal or a description of the error.  When a transaction fails, the authorisation response includes &#x60;resultCode&#x60; and &#x60;refusalReason&#x60; values.
        /// </summary>
        /// <value>If the payment&#x27;s authorisation is refused or an error occurs during authorisation, this field holds Adyen&#x27;s mapped reason for the refusal or a description of the error.  When a transaction fails, the authorisation response includes &#x60;resultCode&#x60; and &#x60;refusalReason&#x60; values.</value>
        [DataMember(Name = "refusalReason", EmitDefaultValue = false)]
        public string RefusalReason { get; set; }

        /// <summary>
        /// Code that specifies the refusal reason. For more information, see [Authorisation refusal reasons](https://docs.adyen.com/development-resources/refusal-reasons).
        /// </summary>
        /// <value>Code that specifies the refusal reason. For more information, see [Authorisation refusal reasons](https://docs.adyen.com/development-resources/refusal-reasons).</value>
        [DataMember(Name = "refusalReasonCode", EmitDefaultValue = false)]
        public string RefusalReasonCode { get; set; }


        /// <summary>
        /// Gets or Sets ServiceError
        /// </summary>
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
            return this.Equals(input as PaymentResultResponse);
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
                    this.AdditionalData == input.AdditionalData ||
                    (this.AdditionalData != null &&
                    this.AdditionalData.Equals(input.AdditionalData))
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
                    (this.ResultCode != null &&
                    this.ResultCode.Equals(input.ResultCode))
                ) &&
                (
                    this.ServiceError == input.ServiceError ||
                    (this.ServiceError != null &&
                    this.ServiceError.Equals(input.ServiceError))
                ) &&
                (
                    this.ShopperLocale == input.ShopperLocale ||
                    (this.ShopperLocale != null &&
                    this.ShopperLocale.Equals(input.ShopperLocale))
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
                if (this.FraudResult != null)
                    hashCode = hashCode * 59 + this.FraudResult.GetHashCode();
                if (this.MerchantReference != null)
                    hashCode = hashCode * 59 + this.MerchantReference.GetHashCode();
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.PspReference != null)
                    hashCode = hashCode * 59 + this.PspReference.GetHashCode();
                if (this.RefusalReason != null)
                    hashCode = hashCode * 59 + this.RefusalReason.GetHashCode();
                if (this.RefusalReasonCode != null)
                    hashCode = hashCode * 59 + this.RefusalReasonCode.GetHashCode();
                if (this.ResultCode != null)
                    hashCode = hashCode * 59 + this.ResultCode.GetHashCode();
                if (this.ServiceError != null)
                    hashCode = hashCode * 59 + this.ServiceError.GetHashCode();
                if (this.ShopperLocale != null)
                    hashCode = hashCode * 59 + this.ShopperLocale.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
