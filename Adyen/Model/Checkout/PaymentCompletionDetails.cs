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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// PaymentCompletionDetails
    /// </summary>
    [DataContract]
    public partial class PaymentCompletionDetails : IEquatable<PaymentCompletionDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCompletionDetails" /> class.
        /// </summary>
        /// <param name="mD">A payment session identifier returned by the card issuer..</param>
        /// <param name="paReq">(3D) Payment Authentication Request data for the card issuer..</param>
        /// <param name="paRes">(3D) Payment Authentication Response data by the card issuer..</param>
        /// <param name="billingToken">PayPal-generated token for recurring payments..</param>
        /// <param name="cupsecureplusSmscode">The SMS verification code collected from the shopper..</param>
        /// <param name="facilitatorAccessToken">PayPal-generated third party access token..</param>
        /// <param name="oneTimePasscode">A random number sent to the mobile phone number of the shopper to verify the payment..</param>
        /// <param name="orderID">PayPal-assigned ID for the order..</param>
        /// <param name="payerID">PayPal-assigned ID for the payer (shopper)..</param>
        /// <param name="payload">Payload appended to the &#x60;returnURL&#x60; as a result of the redirect..</param>
        /// <param name="paymentID">PayPal-generated ID for the payment..</param>
        /// <param name="paymentStatus">Value passed from the WeChat MiniProgram &#x60;wx.requestPayment&#x60; **complete** callback. Possible values: any value starting with &#x60;requestPayment:&#x60;..</param>
        /// <param name="redirectResult">The result of the redirect as appended to the &#x60;returnURL&#x60;..</param>
        /// <param name="threeDSResult">Base64-encoded string returned by the Component after the challenge flow. It contains the following parameters: &#x60;transStatus&#x60;, &#x60;authorisationToken&#x60;..</param>
        /// <param name="threeds2ChallengeResult">Base64-encoded string returned by the Component after the challenge flow. It contains the following parameter: &#x60;transStatus&#x60;..</param>
        /// <param name="threeds2Fingerprint">Base64-encoded string returned by the Component after the challenge flow. It contains the following parameter: &#x60;threeDSCompInd&#x60;..</param>
        public PaymentCompletionDetails(string mD = default(string), string paReq = default(string),
            string paRes = default(string), string billingToken = default(string),
            string cupsecureplusSmscode = default(string), string facilitatorAccessToken = default(string),
            string oneTimePasscode = default(string), string orderID = default(string),
            string payerID = default(string), string payload = default(string), string paymentID = default(string),
            string paymentStatus = default(string), string redirectResult = default(string),
            string threeDSResult = default(string), string threeds2ChallengeResult = default(string),
            string threeds2Fingerprint = default(string))
        {
            this.MD = mD;
            this.PaReq = paReq;
            this.PaRes = paRes;
            this.BillingToken = billingToken;
            this.CupsecureplusSmscode = cupsecureplusSmscode;
            this.FacilitatorAccessToken = facilitatorAccessToken;
            this.OneTimePasscode = oneTimePasscode;
            this.OrderID = orderID;
            this.PayerID = payerID;
            this.Payload = payload;
            this.PaymentID = paymentID;
            this.PaymentStatus = paymentStatus;
            this.RedirectResult = redirectResult;
            this.ThreeDSResult = threeDSResult;
            this.Threeds2ChallengeResult = threeds2ChallengeResult;
            this.Threeds2Fingerprint = threeds2Fingerprint;
        }

        /// <summary>
        /// A payment session identifier returned by the card issuer.
        /// </summary>
        /// <value>A payment session identifier returned by the card issuer.</value>
        [DataMember(Name = "MD", EmitDefaultValue = false)]
        public string MD { get; set; }

        /// <summary>
        /// (3D) Payment Authentication Request data for the card issuer.
        /// </summary>
        /// <value>(3D) Payment Authentication Request data for the card issuer.</value>
        [DataMember(Name = "PaReq", EmitDefaultValue = false)]
        public string PaReq { get; set; }

        /// <summary>
        /// (3D) Payment Authentication Response data by the card issuer.
        /// </summary>
        /// <value>(3D) Payment Authentication Response data by the card issuer.</value>
        [DataMember(Name = "PaRes", EmitDefaultValue = false)]
        public string PaRes { get; set; }

        /// <summary>
        /// PayPal-generated token for recurring payments.
        /// </summary>
        /// <value>PayPal-generated token for recurring payments.</value>
        [DataMember(Name = "billingToken", EmitDefaultValue = false)]
        public string BillingToken { get; set; }

        /// <summary>
        /// The SMS verification code collected from the shopper.
        /// </summary>
        /// <value>The SMS verification code collected from the shopper.</value>
        [DataMember(Name = "cupsecureplus.smscode", EmitDefaultValue = false)]
        public string CupsecureplusSmscode { get; set; }

        /// <summary>
        /// PayPal-generated third party access token.
        /// </summary>
        /// <value>PayPal-generated third party access token.</value>
        [DataMember(Name = "facilitatorAccessToken", EmitDefaultValue = false)]
        public string FacilitatorAccessToken { get; set; }

        /// <summary>
        /// A random number sent to the mobile phone number of the shopper to verify the payment.
        /// </summary>
        /// <value>A random number sent to the mobile phone number of the shopper to verify the payment.</value>
        [DataMember(Name = "oneTimePasscode", EmitDefaultValue = false)]
        public string OneTimePasscode { get; set; }

        /// <summary>
        /// PayPal-assigned ID for the order.
        /// </summary>
        /// <value>PayPal-assigned ID for the order.</value>
        [DataMember(Name = "orderID", EmitDefaultValue = false)]
        public string OrderID { get; set; }

        /// <summary>
        /// PayPal-assigned ID for the payer (shopper).
        /// </summary>
        /// <value>PayPal-assigned ID for the payer (shopper).</value>
        [DataMember(Name = "payerID", EmitDefaultValue = false)]
        public string PayerID { get; set; }

        /// <summary>
        /// Payload appended to the &#x60;returnURL&#x60; as a result of the redirect.
        /// </summary>
        /// <value>Payload appended to the &#x60;returnURL&#x60; as a result of the redirect.</value>
        [DataMember(Name = "payload", EmitDefaultValue = false)]
        public string Payload { get; set; }

        /// <summary>
        /// PayPal-generated ID for the payment.
        /// </summary>
        /// <value>PayPal-generated ID for the payment.</value>
        [DataMember(Name = "paymentID", EmitDefaultValue = false)]
        public string PaymentID { get; set; }

        /// <summary>
        /// Value passed from the WeChat MiniProgram &#x60;wx.requestPayment&#x60; **complete** callback. Possible values: any value starting with &#x60;requestPayment:&#x60;.
        /// </summary>
        /// <value>Value passed from the WeChat MiniProgram &#x60;wx.requestPayment&#x60; **complete** callback. Possible values: any value starting with &#x60;requestPayment:&#x60;.</value>
        [DataMember(Name = "paymentStatus", EmitDefaultValue = false)]
        public string PaymentStatus { get; set; }

        /// <summary>
        /// The result of the redirect as appended to the &#x60;returnURL&#x60;.
        /// </summary>
        /// <value>The result of the redirect as appended to the &#x60;returnURL&#x60;.</value>
        [DataMember(Name = "redirectResult", EmitDefaultValue = false)]
        public string RedirectResult { get; set; }

        /// <summary>
        /// Base64-encoded string returned by the Component after the challenge flow. It contains the following parameters: &#x60;transStatus&#x60;, &#x60;authorisationToken&#x60;.
        /// </summary>
        /// <value>Base64-encoded string returned by the Component after the challenge flow. It contains the following parameters: &#x60;transStatus&#x60;, &#x60;authorisationToken&#x60;.</value>
        [DataMember(Name = "threeDSResult", EmitDefaultValue = false)]
        public string ThreeDSResult { get; set; }

        /// <summary>
        /// Base64-encoded string returned by the Component after the challenge flow. It contains the following parameter: &#x60;transStatus&#x60;.
        /// </summary>
        /// <value>Base64-encoded string returned by the Component after the challenge flow. It contains the following parameter: &#x60;transStatus&#x60;.</value>
        [DataMember(Name = "threeds2.challengeResult", EmitDefaultValue = false)]
        public string Threeds2ChallengeResult { get; set; }

        /// <summary>
        /// Base64-encoded string returned by the Component after the challenge flow. It contains the following parameter: &#x60;threeDSCompInd&#x60;.
        /// </summary>
        /// <value>Base64-encoded string returned by the Component after the challenge flow. It contains the following parameter: &#x60;threeDSCompInd&#x60;.</value>
        [DataMember(Name = "threeds2.fingerprint", EmitDefaultValue = false)]
        public string Threeds2Fingerprint { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentCompletionDetails {\n");
            sb.Append("  MD: ").Append(MD).Append("\n");
            sb.Append("  PaReq: ").Append(PaReq).Append("\n");
            sb.Append("  PaRes: ").Append(PaRes).Append("\n");
            sb.Append("  BillingToken: ").Append(BillingToken).Append("\n");
            sb.Append("  CupsecureplusSmscode: ").Append(CupsecureplusSmscode).Append("\n");
            sb.Append("  FacilitatorAccessToken: ").Append(FacilitatorAccessToken).Append("\n");
            sb.Append("  OneTimePasscode: ").Append(OneTimePasscode).Append("\n");
            sb.Append("  OrderID: ").Append(OrderID).Append("\n");
            sb.Append("  PayerID: ").Append(PayerID).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  PaymentID: ").Append(PaymentID).Append("\n");
            sb.Append("  PaymentStatus: ").Append(PaymentStatus).Append("\n");
            sb.Append("  RedirectResult: ").Append(RedirectResult).Append("\n");
            sb.Append("  ThreeDSResult: ").Append(ThreeDSResult).Append("\n");
            sb.Append("  Threeds2ChallengeResult: ").Append(Threeds2ChallengeResult).Append("\n");
            sb.Append("  Threeds2Fingerprint: ").Append(Threeds2Fingerprint).Append("\n");
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
            return this.Equals(input as PaymentCompletionDetails);
        }

        /// <summary>
        /// Returns true if PaymentCompletionDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentCompletionDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentCompletionDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    this.MD == input.MD ||
                    this.MD != null &&
                    this.MD.Equals(input.MD)
                ) &&
                (
                    this.PaReq == input.PaReq ||
                    this.PaReq != null &&
                    this.PaReq.Equals(input.PaReq)
                ) &&
                (
                    this.PaRes == input.PaRes ||
                    this.PaRes != null &&
                    this.PaRes.Equals(input.PaRes)
                ) &&
                (
                    this.BillingToken == input.BillingToken ||
                    this.BillingToken != null &&
                    this.BillingToken.Equals(input.BillingToken)
                ) &&
                (
                    this.CupsecureplusSmscode == input.CupsecureplusSmscode ||
                    this.CupsecureplusSmscode != null &&
                    this.CupsecureplusSmscode.Equals(input.CupsecureplusSmscode)
                ) &&
                (
                    this.FacilitatorAccessToken == input.FacilitatorAccessToken ||
                    this.FacilitatorAccessToken != null &&
                    this.FacilitatorAccessToken.Equals(input.FacilitatorAccessToken)
                ) &&
                (
                    this.OneTimePasscode == input.OneTimePasscode ||
                    this.OneTimePasscode != null &&
                    this.OneTimePasscode.Equals(input.OneTimePasscode)
                ) &&
                (
                    this.OrderID == input.OrderID ||
                    this.OrderID != null &&
                    this.OrderID.Equals(input.OrderID)
                ) &&
                (
                    this.PayerID == input.PayerID ||
                    this.PayerID != null &&
                    this.PayerID.Equals(input.PayerID)
                ) &&
                (
                    this.Payload == input.Payload ||
                    this.Payload != null &&
                    this.Payload.Equals(input.Payload)
                ) &&
                (
                    this.PaymentID == input.PaymentID ||
                    this.PaymentID != null &&
                    this.PaymentID.Equals(input.PaymentID)
                ) &&
                (
                    this.PaymentStatus == input.PaymentStatus ||
                    this.PaymentStatus != null &&
                    this.PaymentStatus.Equals(input.PaymentStatus)
                ) &&
                (
                    this.RedirectResult == input.RedirectResult ||
                    this.RedirectResult != null &&
                    this.RedirectResult.Equals(input.RedirectResult)
                ) &&
                (
                    this.ThreeDSResult == input.ThreeDSResult ||
                    this.ThreeDSResult != null &&
                    this.ThreeDSResult.Equals(input.ThreeDSResult)
                ) &&
                (
                    this.Threeds2ChallengeResult == input.Threeds2ChallengeResult ||
                    this.Threeds2ChallengeResult != null &&
                    this.Threeds2ChallengeResult.Equals(input.Threeds2ChallengeResult)
                ) &&
                (
                    this.Threeds2Fingerprint == input.Threeds2Fingerprint ||
                    this.Threeds2Fingerprint != null &&
                    this.Threeds2Fingerprint.Equals(input.Threeds2Fingerprint)
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
                if (this.MD != null)
                    hashCode = hashCode * 59 + this.MD.GetHashCode();
                if (this.PaReq != null)
                    hashCode = hashCode * 59 + this.PaReq.GetHashCode();
                if (this.PaRes != null)
                    hashCode = hashCode * 59 + this.PaRes.GetHashCode();
                if (this.BillingToken != null)
                    hashCode = hashCode * 59 + this.BillingToken.GetHashCode();
                if (this.CupsecureplusSmscode != null)
                    hashCode = hashCode * 59 + this.CupsecureplusSmscode.GetHashCode();
                if (this.FacilitatorAccessToken != null)
                    hashCode = hashCode * 59 + this.FacilitatorAccessToken.GetHashCode();
                if (this.OneTimePasscode != null)
                    hashCode = hashCode * 59 + this.OneTimePasscode.GetHashCode();
                if (this.OrderID != null)
                    hashCode = hashCode * 59 + this.OrderID.GetHashCode();
                if (this.PayerID != null)
                    hashCode = hashCode * 59 + this.PayerID.GetHashCode();
                if (this.Payload != null)
                    hashCode = hashCode * 59 + this.Payload.GetHashCode();
                if (this.PaymentID != null)
                    hashCode = hashCode * 59 + this.PaymentID.GetHashCode();
                if (this.PaymentStatus != null)
                    hashCode = hashCode * 59 + this.PaymentStatus.GetHashCode();
                if (this.RedirectResult != null)
                    hashCode = hashCode * 59 + this.RedirectResult.GetHashCode();
                if (this.ThreeDSResult != null)
                    hashCode = hashCode * 59 + this.ThreeDSResult.GetHashCode();
                if (this.Threeds2ChallengeResult != null)
                    hashCode = hashCode * 59 + this.Threeds2ChallengeResult.GetHashCode();
                if (this.Threeds2Fingerprint != null)
                    hashCode = hashCode * 59 + this.Threeds2Fingerprint.GetHashCode();
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