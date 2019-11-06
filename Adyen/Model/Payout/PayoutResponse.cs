using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.Model.Payout
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class PayoutResponse
    {
        /// <summary>
        /// This field contains additional data, which may be required to return in a particular payment response. To choose data fields to be returned, go to **Customer Area** > **Account** > **API URLs**.
        /// </summary>
        /// <value>This field contains additional data, which may be required to return in a particular payment response. To choose data fields to be returned, go to **Customer Area** > **Account** > **API URLs**.</value>
        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "additionalData")]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// Authorisation code: * When the payment is authorised successfully, this field holds the authorisation code for the payment. * When the payment is not authorised, this field is empty.
        /// </summary>
        /// <value>Authorisation code: * When the payment is authorised successfully, this field holds the authorisation code for the payment. * When the payment is not authorised, this field is empty.</value>
        [DataMember(Name = "authCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "authCode")]
        public string AuthCode { get; set; }

        /// <summary>
        /// Gets or Sets DccAmount
        /// </summary>
        [DataMember(Name = "dccAmount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dccAmount")]
        public Amount DccAmount { get; set; }

        /// <summary>
        /// Cryptographic signature used to verify `dccQuote`. > This value only applies if you have implemented Dynamic Currency Conversion. For more information, [contact Support](https://support.adyen.com/hc/en-us/requests/new).
        /// </summary>
        /// <value>Cryptographic signature used to verify `dccQuote`. > This value only applies if you have implemented Dynamic Currency Conversion. For more information, [contact Support](https://support.adyen.com/hc/en-us/requests/new).</value>
        [DataMember(Name = "dccSignature", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dccSignature")]
        public string DccSignature { get; set; }

        /// <summary>
        /// Gets or Sets FraudResult
        /// </summary>
        [DataMember(Name = "fraudResult", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fraudResult")]
        public FraudResult FraudResult { get; set; }

        /// <summary>
        /// The URL to direct the shopper to. > In case of SecurePlus, do not redirect a shopper to this URL.
        /// </summary>
        /// <value>The URL to direct the shopper to. > In case of SecurePlus, do not redirect a shopper to this URL.</value>
        [DataMember(Name = "issuerUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "issuerUrl")]
        public string IssuerUrl { get; set; }

        /// <summary>
        /// The payment session.
        /// </summary>
        /// <value>The payment session.</value>
        [DataMember(Name = "md", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "md")]
        public string Md { get; set; }

        /// <summary>
        /// The 3D request data for the issuer.  If the value is **CUPSecurePlus-CollectSMSVerificationCode**, collect an SMS code from the shopper and pass it in the `/authorise3D` request. For more information, see [3D Secure](https://docs.adyen.com/classic-integration/3d-secure).
        /// </summary>
        /// <value>The 3D request data for the issuer.  If the value is **CUPSecurePlus-CollectSMSVerificationCode**, collect an SMS code from the shopper and pass it in the `/authorise3D` request. For more information, see [3D Secure](https://docs.adyen.com/classic-integration/3d-secure).</value>
        [DataMember(Name = "paRequest", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paRequest")]
        public string PaRequest { get; set; }

        /// <summary>
        /// Adyen's 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.  > `pspReference` is returned only for non-redirect payment methods.
        /// </summary>
        /// <value>Adyen's 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.  > `pspReference` is returned only for non-redirect payment methods.</value>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pspReference")]
        public string PspReference { get; set; }

        /// <summary>
        /// If the payment's authorisation is refused or an error occurs during authorisation, this field holds Adyen's mapped reason for the refusal or a description of the error.  When a transaction fails, the authorisation response includes `resultCode` and `refusalReason` values.
        /// </summary>
        /// <value>If the payment's authorisation is refused or an error occurs during authorisation, this field holds Adyen's mapped reason for the refusal or a description of the error.  When a transaction fails, the authorisation response includes `resultCode` and `refusalReason` values.</value>
        [DataMember(Name = "refusalReason", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "refusalReason")]
        public string RefusalReason { get; set; }

        /// <summary>
        /// The result of the payment. Possible values:  * **AuthenticationFinished** – The payment has been successfully authenticated with 3D Secure 2. Returned for 3D Secure 2 authentication-only transactions. * **Authorised** – The payment was successfully authorised. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state. * **Cancelled** – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state. * **ChallengeShopper** – The issuer requires further shopper interaction before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Error** – There was an error when the payment was being processed. The reason is given in the `refusalReason` field. This is a final state. * **IdentifyShopper** – The issuer requires the shopper's device fingerprint before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Pending** – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment. For more information on handling a pending payment, refer to [Payments with pending status](https://docs.adyen.com/development-resources/payments-with-pending-status). * **PresentToShopper** – Indicates that the response contains additional information that you need to present to a shopper, so that they can use it to complete a payment. * **Received** – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments. * **RedirectShopper** – Indicates the shopper should be redirected to an external web page or app to complete the authorisation. * **Refused** – Indicates the payment was refused. The reason is given in the `refusalReason` field. This is a final state.
        /// </summary>
        /// <value>The result of the payment. Possible values:  * **AuthenticationFinished** – The payment has been successfully authenticated with 3D Secure 2. Returned for 3D Secure 2 authentication-only transactions. * **Authorised** – The payment was successfully authorised. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state. * **Cancelled** – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state. * **ChallengeShopper** – The issuer requires further shopper interaction before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Error** – There was an error when the payment was being processed. The reason is given in the `refusalReason` field. This is a final state. * **IdentifyShopper** – The issuer requires the shopper's device fingerprint before the payment can be authenticated. Returned for 3D Secure 2 transactions. * **Pending** – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment. For more information on handling a pending payment, refer to [Payments with pending status](https://docs.adyen.com/development-resources/payments-with-pending-status). * **PresentToShopper** – Indicates that the response contains additional information that you need to present to a shopper, so that they can use it to complete a payment. * **Received** – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments. * **RedirectShopper** – Indicates the shopper should be redirected to an external web page or app to complete the authorisation. * **Refused** – Indicates the payment was refused. The reason is given in the `refusalReason` field. This is a final state.</value>
        [DataMember(Name = "resultCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "resultCode")]
        public string ResultCode { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayoutResponse {\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("  AuthCode: ").Append(AuthCode).Append("\n");
            sb.Append("  DccAmount: ").Append(DccAmount).Append("\n");
            sb.Append("  DccSignature: ").Append(DccSignature).Append("\n");
            sb.Append("  FraudResult: ").Append(FraudResult).Append("\n");
            sb.Append("  IssuerUrl: ").Append(IssuerUrl).Append("\n");
            sb.Append("  Md: ").Append(Md).Append("\n");
            sb.Append("  PaRequest: ").Append(PaRequest).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  RefusalReason: ").Append(RefusalReason).Append("\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

    }
}
