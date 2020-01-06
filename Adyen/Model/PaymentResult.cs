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
//  * Copyright (c) 2019 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using Adyen.Model.Enum;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.Model
{
    /// <summary>
    /// PaymentResult
    /// </summary>
    [DataContract]
    public partial class PaymentResult :  IEquatable<PaymentResult>, IValidatableObject
    {
        /// <summary>
        /// The result of the payment.
        /// </summary>
        /// <value>The result of the payment.</value>
        [DataMember(Name="resultCode", EmitDefaultValue=false)]
        public ResultCodeEnum? ResultCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResult" /> class.
        /// </summary>
        /// <param name="AuthCode">Authorisation code:  * When the payment is authorised successfully, this field holds the authorisation code for the payment.  * When the payment is not authorised, this field is empty..</param>
        /// <param name="PaRequest">The 3D request data for the issuer.  If the value is **CUPSecurePlus-CollectSMSVerificationCode**, collect an SMS code from the shopper and pass it in the &#x60;/authorise3D&#x60; request. For more information, see [3D Secure](https://docs.adyen.com/developers/risk-management/3d-secure)..</param>
        /// <param name="IssuerUrl">The URL to direct the shopper to. &gt; In case of SecurePlus, do not redirect a shopper to this URL..</param>
        /// <param name="Md">The payment session..</param>
        /// <param name="ResultCode">The result of the payment..</param>
        /// <param name="DccSignature">DccSignature.</param>
        /// <param name="RefusalReason">If the payment&#39;s authorisation is refused or an error occurrs during authorisation, this field holds Adyen&#39;s mapped reason for the refusal or a description of the error.  When a transaction fails, the authorisation response includes &#x60;resultCode&#x60; and &#x60;refusalReason&#x60; values..</param>
        /// <param name="AdditionalData">This field contains additional data, which may be required to return in a particular payment response. To choose data fields to be returned, go to Customer Area -&gt; Settings -&gt; API and Response..</param>
        /// <param name="DccAmount">DccAmount.</param>
        /// <param name="FraudResult">FraudResult.</param>
        /// <param name="PspReference">Adyen&#39;s 16-digit unique reference associated with the transaction/the request. This value is globally unique; quote it when communicating with us about this request..</param>
        public PaymentResult(string AuthCode = default(string), string PaRequest = default(string), string IssuerUrl = default(string), string Md = default(string), ResultCodeEnum? ResultCode = default(ResultCodeEnum?), string DccSignature = default(string), string RefusalReason = default(string), Dictionary<string, string> AdditionalData = default(Dictionary<string, string>),  FraudResult FraudResult = default(FraudResult), string PspReference = default(string))
        {
            this.AuthCode = AuthCode;
            this.PaRequest = PaRequest;
            this.IssuerUrl = IssuerUrl;
            this.Md = Md;
            this.ResultCode = ResultCode;
            this.DccSignature = DccSignature;
            this.RefusalReason = RefusalReason;
            this.AdditionalData = AdditionalData;
            this.FraudResult = FraudResult;
            this.PspReference = PspReference;
        }
        
        /// <summary>
        /// Authorisation code:  * When the payment is authorised successfully, this field holds the authorisation code for the payment.  * When the payment is not authorised, this field is empty.
        /// </summary>
        /// <value>Authorisation code:  * When the payment is authorised successfully, this field holds the authorisation code for the payment.  * When the payment is not authorised, this field is empty.</value>
        [DataMember(Name="authCode", EmitDefaultValue=false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// The 3D request data for the issuer.  If the value is **CUPSecurePlus-CollectSMSVerificationCode**, collect an SMS code from the shopper and pass it in the &#x60;/authorise3D&#x60; request. For more information, see [3D Secure](https://docs.adyen.com/developers/risk-management/3d-secure).
        /// </summary>
        /// <value>The 3D request data for the issuer.  If the value is **CUPSecurePlus-CollectSMSVerificationCode**, collect an SMS code from the shopper and pass it in the &#x60;/authorise3D&#x60; request. For more information, see [3D Secure](https://docs.adyen.com/developers/risk-management/3d-secure).</value>
        [DataMember(Name="paRequest", EmitDefaultValue=false)]
        public string PaRequest { get; set; }

        /// <summary>
        /// The URL to direct the shopper to. &gt; In case of SecurePlus, do not redirect a shopper to this URL.
        /// </summary>
        /// <value>The URL to direct the shopper to. &gt; In case of SecurePlus, do not redirect a shopper to this URL.</value>
        [DataMember(Name="issuerUrl", EmitDefaultValue=false)]
        public string IssuerUrl { get; set; }

        /// <summary>
        /// The payment session.
        /// </summary>
        /// <value>The payment session.</value>
        [DataMember(Name="md", EmitDefaultValue=false)]
        public string Md { get; set; }


        /// <summary>
        /// Gets or Sets DccSignature
        /// </summary>
        [DataMember(Name="dccSignature", EmitDefaultValue=false)]
        public string DccSignature { get; set; }

        /// <summary>
        /// If the payment&#39;s authorisation is refused or an error occurrs during authorisation, this field holds Adyen&#39;s mapped reason for the refusal or a description of the error.  When a transaction fails, the authorisation response includes &#x60;resultCode&#x60; and &#x60;refusalReason&#x60; values.
        /// </summary>
        /// <value>If the payment&#39;s authorisation is refused or an error occurrs during authorisation, this field holds Adyen&#39;s mapped reason for the refusal or a description of the error.  When a transaction fails, the authorisation response includes &#x60;resultCode&#x60; and &#x60;refusalReason&#x60; values.</value>
        [DataMember(Name="refusalReason", EmitDefaultValue=false)]
        public string RefusalReason { get; set; }

        /// <summary>
        /// This field contains additional data, which may be required to return in a particular payment response. To choose data fields to be returned, go to Customer Area -&gt; Settings -&gt; API and Response.
        /// </summary>
        /// <value>This field contains additional data, which may be required to return in a particular payment response. To choose data fields to be returned, go to Customer Area -&gt; Settings -&gt; API and Response.</value>
        [DataMember(Name="additionalData", EmitDefaultValue=false)]
        public Dictionary<string, string> AdditionalData { get; set; }
        
        /// <summary>
        /// Gets or Sets FraudResult
        /// </summary>
        [DataMember(Name="fraudResult", EmitDefaultValue=false)]
        public FraudResult FraudResult { get; set; }

        [DataMember(Name = "Amount", EmitDefaultValue = false)]
        public Amount DccAmount { get; set; }
        
        /// <summary>
        /// Adyen&#39;s 16-digit unique reference associated with the transaction/the request. This value is globally unique; quote it when communicating with us about this request.
        /// </summary>
        /// <value>Adyen&#39;s 16-digit unique reference associated with the transaction/the request. This value is globally unique; quote it when communicating with us about this request.</value>
        [DataMember(Name="pspReference", EmitDefaultValue=false)]
        public string PspReference { get; set; }

        [DataMember(Name = "cardBin", EmitDefaultValue = false)]
        public string CardBin { get; set; }

        [DataMember(Name = "cardHolderName", EmitDefaultValue = false)]
        public string CardHolderName { get; set; }

        [DataMember(Name = "cardSummary", EmitDefaultValue = false)]
        public string CardSummary { get; set; }

        [DataMember(Name = "paymentMethod", EmitDefaultValue = false)]
        public string PaymentMethod { get; set; }

        [DataMember(Name = "avsResult", EmitDefaultValue = false)]
        public string AvsResult { get; set; }

        [DataMember(Name = "threeDOffered", EmitDefaultValue = false)]
        public string ThreeDOffered { get; set; }

        [DataMember(Name = "threeDAuthenticated", EmitDefaultValue = false)]
        public bool ThreeDAuthenticated { get; set; }

        [DataMember(Name = "boletoBarcodeReference", EmitDefaultValue = false)]
        public string BoletoBarcodeReference { get;  set; }

        [DataMember(Name = "boletoData", EmitDefaultValue = false)]
        public string BoletoData { get;  set; }

        [DataMember(Name = "boletoUrl", EmitDefaultValue = false)]
        public string BoletoUrl { get; set; }

        [DataMember(Name = "boletoDuetoDate", EmitDefaultValue = false)]
        public DateTime BoletoDuetoDate { get; set; }

        [DataMember(Name = "boletoExpirationDate", EmitDefaultValue = false)]
        public string BoletoExpirationDate { get; set; }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentResult {\n");
            sb.Append("  AuthCode: ").Append(AuthCode).Append("\n");
            sb.Append("  PaRequest: ").Append(PaRequest).Append("\n");
            sb.Append("  IssuerUrl: ").Append(IssuerUrl).Append("\n");
            sb.Append("  Md: ").Append(Md).Append("\n");
            sb.Append("  DccAmount: ").Append(DccAmount).Append("\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
            sb.Append("  DccSignature: ").Append(DccSignature).Append("\n");
            sb.Append("  RefusalReason: ").Append(RefusalReason).Append("\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");          
            sb.Append("  FraudResult: ").Append(FraudResult).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as PaymentResult);
        }

        /// <summary>
        /// Returns true if PaymentResult instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AuthCode == other.AuthCode ||
                    this.AuthCode != null &&
                    this.AuthCode.Equals(other.AuthCode)
                ) && 
                (
                    this.PaRequest == other.PaRequest ||
                    this.PaRequest != null &&
                    this.PaRequest.Equals(other.PaRequest)
                ) && 
                (
                    this.IssuerUrl == other.IssuerUrl ||
                    this.IssuerUrl != null &&
                    this.IssuerUrl.Equals(other.IssuerUrl)
                ) && 
                (
                    this.Md == other.Md ||
                    this.Md != null &&
                    this.Md.Equals(other.Md)
                ) && 
                (
                    this.ResultCode == other.ResultCode ||
                    this.ResultCode != null &&
                    this.ResultCode.Equals(other.ResultCode)
                ) && 
                (
                    this.DccSignature == other.DccSignature ||
                    this.DccSignature != null &&
                    this.DccSignature.Equals(other.DccSignature)
                ) && 
                (
                    this.RefusalReason == other.RefusalReason ||
                    this.RefusalReason != null &&
                    this.RefusalReason.Equals(other.RefusalReason)
                ) && 
                (
                    this.AdditionalData == other.AdditionalData ||
                    this.AdditionalData != null &&
                    this.AdditionalData.SequenceEqual(other.AdditionalData)
                ) && 
                
                (
                    this.FraudResult == other.FraudResult ||
                    this.FraudResult != null &&
                    this.FraudResult.Equals(other.FraudResult)
                ) && 
                (
                    this.PspReference == other.PspReference ||
                    this.PspReference != null &&
                    this.PspReference.Equals(other.PspReference)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.AuthCode != null)
                    hash = hash * 59 + this.AuthCode.GetHashCode();
                if (this.PaRequest != null)
                    hash = hash * 59 + this.PaRequest.GetHashCode();
                if (this.IssuerUrl != null)
                    hash = hash * 59 + this.IssuerUrl.GetHashCode();
                if (this.Md != null)
                    hash = hash * 59 + this.Md.GetHashCode();
                if (this.ResultCode != null)
                    hash = hash * 59 + this.ResultCode.GetHashCode();
                if (this.DccSignature != null)
                    hash = hash * 59 + this.DccSignature.GetHashCode();
                if (this.RefusalReason != null)
                    hash = hash * 59 + this.RefusalReason.GetHashCode();
                if (this.AdditionalData != null)
                    hash = hash * 59 + this.AdditionalData.GetHashCode();
                if (this.FraudResult != null)
                    hash = hash * 59 + this.FraudResult.GetHashCode();
                if (this.PspReference != null)
                    hash = hash * 59 + this.PspReference.GetHashCode();
                return hash;
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
