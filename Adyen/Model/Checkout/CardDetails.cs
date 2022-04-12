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
//  Copyright (c) 2022 Adyen N.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// CardDetails
    /// </summary>
    [DataContract]
     public partial class CardDetails : IEquatable<CardDetails>, IValidatableObject
     {
         /// <summary>
         /// The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**.
         /// </summary>
         /// <value>The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**.</value>
         [JsonConverter(typeof(StringEnumConverter))]
         public enum FundingSourceEnum
         {
             /// <summary>
             /// Enum Debit for value: debit
             /// </summary>
             [EnumMember(Value = "debit")] Debit = 1
         }

         /// <summary>
         /// The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**.
         /// </summary>
         /// <value>The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**.</value>
         [DataMember(Name = "fundingSource", EmitDefaultValue = false)]
         public FundingSourceEnum? FundingSource { get; set; }

         /// <summary>
         /// Default payment method details. Common for scheme payment methods, and for simple payment method details.
         /// </summary>
         /// <value>Default payment method details. Common for scheme payment methods, and for simple payment method details.</value>
         [JsonConverter(typeof(StringEnumConverter))]
         public enum TypeEnum
         {
             /// <summary>
             /// Enum Scheme for value: scheme
             /// </summary>
             [EnumMember(Value = "scheme")] Scheme = 1,

             /// <summary>
             /// Enum NetworkToken for value: networkToken
             /// </summary>
             [EnumMember(Value = "networkToken")] NetworkToken = 2,

             /// <summary>
             /// Enum Giftcard for value: giftcard
             /// </summary>
             [EnumMember(Value = "giftcard")] Giftcard = 3,

             /// <summary>
             /// Enum Alliancedata for value: alliancedata
             /// </summary>
             [EnumMember(Value = "alliancedata")] Alliancedata = 4,

             /// <summary>
             /// Enum Card for value: card
             /// </summary>
             [EnumMember(Value = "card")] Card = 5,

             /// <summary>
             /// Enum Moneybookers for value: moneybookers
             /// </summary>
             [EnumMember(Value = "moneybookers")] Moneybookers = 6,

             /// <summary>
             /// Enum Qiwiwallet for value: qiwiwallet
             /// </summary>
             [EnumMember(Value = "qiwiwallet")] Qiwiwallet = 7,

             /// <summary>
             /// Enum Alipayhk for value: alipay_hk
             /// </summary>
             [EnumMember(Value = "alipay_hk")] Alipayhk = 8,

             /// <summary>
             /// Enum Alipayhkwap for value: alipay_hk_wap
             /// </summary>
             [EnumMember(Value = "alipay_hk_wap")] Alipayhkwap = 9,

             /// <summary>
             /// Enum Alipayhkweb for value: alipay_hk_web
             /// </summary>
             [EnumMember(Value = "alipay_hk_web")] Alipayhkweb = 10,

             /// <summary>
             /// Enum Alipaywap for value: alipay_wap
             /// </summary>
             [EnumMember(Value = "alipay_wap")] Alipaywap = 11,

             /// <summary>
             /// Enum Kcpnaverpay for value: kcp_naverpay
             /// </summary>
             [EnumMember(Value = "kcp_naverpay")] Kcpnaverpay = 12,

             /// <summary>
             /// Enum Upi for value: upi
             /// </summary>
             [EnumMember(Value = "upi")] Upi = 13,

             /// <summary>
             /// Enum OnlinebankingIN for value: onlinebanking_IN
             /// </summary>
             [EnumMember(Value = "onlinebanking_IN")]
             OnlinebankingIN = 14,

             /// <summary>
             /// Enum WalletIN for value: wallet_IN
             /// </summary>
             [EnumMember(Value = "wallet_IN")] WalletIN = 15,

             /// <summary>
             /// Enum Entercash for value: entercash
             /// </summary>
             [EnumMember(Value = "entercash")] Entercash = 16,

             /// <summary>
             /// Enum Primeiropayboleto for value: primeiropay_boleto
             /// </summary>
             [EnumMember(Value = "primeiropay_boleto")]
             Primeiropayboleto = 17,

             /// <summary>
             /// Enum Gopaywallet for value: gopay_wallet
             /// </summary>
             [EnumMember(Value = "gopay_wallet")] Gopaywallet = 18,

             /// <summary>
             /// Enum Poli for value: poli
             /// </summary>
             [EnumMember(Value = "poli")] Poli = 19,

             /// <summary>
             /// Enum Mada for value: mada
             /// </summary>
             [EnumMember(Value = "mada")] Mada = 20,

             /// <summary>
             /// Enum Naps for value: naps
             /// </summary>
             [EnumMember(Value = "naps")] Naps = 21,

             /// <summary>
             /// Enum Benefit for value: benefit
             /// </summary>
             [EnumMember(Value = "benefit")] Benefit = 22,

             /// <summary>
             /// Enum Knet for value: knet
             /// </summary>
             [EnumMember(Value = "knet")] Knet = 23,

             /// <summary>
             /// Enum Fawry for value: fawry
             /// </summary>
             [EnumMember(Value = "fawry")] Fawry = 24,

             /// <summary>
             /// Enum Omannet for value: omannet
             /// </summary>
             [EnumMember(Value = "omannet")] Omannet = 25
         }

         /// <summary>
         /// Default payment method details. Common for scheme payment methods, and for simple payment method details.
         /// </summary>
         /// <value>Default payment method details. Common for scheme payment methods, and for simple payment method details.</value>
         [DataMember(Name = "type", EmitDefaultValue = false)]
         public TypeEnum? Type { get; set; }

         /// <summary>
         /// Initializes a new instance of the <see cref="CardDetails" /> class.
         /// </summary>
         /// <param name="cupsecureplusSmscode">cupsecureplusSmscode.</param>
         /// <param name="cvc">The card verification code. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide)..</param>
         /// <param name="encryptedCardNumber">The encrypted card number. (required).</param>
         /// <param name="encryptedExpiryMonth">The encrypted card expiry month. (required).</param>
         /// <param name="encryptedExpiryYear">The encrypted card expiry year. (required).</param>
         /// <param name="encryptedSecurityCode">The encrypted card verification code..</param>
         /// <param name="expiryMonth">The card expiry month. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide)..</param>
         /// <param name="expiryYear">The card expiry year. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide)..</param>
         /// <param name="fundingSource">The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**..</param>
         /// <param name="holderName">The name of the card holder..</param>
         /// <param name="number">The card number. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide)..</param>
         /// <param name="recurringDetailReference">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
         /// <param name="shopperNotificationReference">The &#x60;shopperNotificationReference&#x60; returned in the response when you requested to notify the shopper. Used only for recurring payments in India..</param>
         /// <param name="storedPaymentMethodId">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
         /// <param name="threeDS2SdkVersion">Version of the 3D Secure 2 mobile SDK..</param>
         /// <param name="type">Default payment method details. Common for scheme payment methods, and for simple payment method details. (default to TypeEnum.Scheme).</param>
         public CardDetails(string cupsecureplusSmscode = default(string), string cvc = default(string),
             string encryptedCardNumber = default(string), string encryptedExpiryMonth = default(string),
             string encryptedExpiryYear = default(string), string encryptedSecurityCode = default(string),
             string expiryMonth = default(string), string expiryYear = default(string),
             FundingSourceEnum? fundingSource = default(FundingSourceEnum?), string holderName = default(string),
             string number = default(string), string recurringDetailReference = default(string),
             string shopperNotificationReference = default(string), string storedPaymentMethodId = default(string),
             string threeDS2SdkVersion = default(string), TypeEnum? type = TypeEnum.Scheme)
         {
             // to ensure "encryptedCardNumber" is required (not null)
             if (encryptedCardNumber == null)
             {
                 throw new InvalidDataException(
                     "encryptedCardNumber is a required property for CardDetails and cannot be null");
             }
             else
             {
                 this.EncryptedCardNumber = encryptedCardNumber;
             }

             // to ensure "encryptedExpiryMonth" is required (not null)
             if (encryptedExpiryMonth == null)
             {
                 throw new InvalidDataException(
                     "encryptedExpiryMonth is a required property for CardDetails and cannot be null");
             }
             else
             {
                 this.EncryptedExpiryMonth = encryptedExpiryMonth;
             }

             // to ensure "encryptedExpiryYear" is required (not null)
             if (encryptedExpiryYear == null)
             {
                 throw new InvalidDataException(
                     "encryptedExpiryYear is a required property for CardDetails and cannot be null");
             }
             else
             {
                 this.EncryptedExpiryYear = encryptedExpiryYear;
             }

             this.CupsecureplusSmscode = cupsecureplusSmscode;
             this.Cvc = cvc;
             this.EncryptedSecurityCode = encryptedSecurityCode;
             this.ExpiryMonth = expiryMonth;
             this.ExpiryYear = expiryYear;
             this.FundingSource = fundingSource;
             this.HolderName = holderName;
             this.Number = number;
             this.RecurringDetailReference = recurringDetailReference;
             this.ShopperNotificationReference = shopperNotificationReference;
             this.StoredPaymentMethodId = storedPaymentMethodId;
             this.ThreeDS2SdkVersion = threeDS2SdkVersion;
             // use default value if no "type" provided
             if (type == null)
             {
                 this.Type = TypeEnum.Scheme;
             }
             else
             {
                 this.Type = type;
             }
         }

         /// <summary>
         /// Gets or Sets CupsecureplusSmscode
         /// </summary>
         [DataMember(Name = "cupsecureplus.smscode", EmitDefaultValue = false)]
         public string CupsecureplusSmscode { get; set; }

         /// <summary>
         /// The card verification code. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide).
         /// </summary>
         /// <value>The card verification code. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide).</value>
         [DataMember(Name = "cvc", EmitDefaultValue = false)]
         public string Cvc { get; set; }

         /// <summary>
         /// The encrypted card number.
         /// </summary>
         /// <value>The encrypted card number.</value>
         [DataMember(Name = "encryptedCardNumber", EmitDefaultValue = false)]
         public string EncryptedCardNumber { get; set; }

         /// <summary>
         /// The encrypted card expiry month.
         /// </summary>
         /// <value>The encrypted card expiry month.</value>
         [DataMember(Name = "encryptedExpiryMonth", EmitDefaultValue = false)]
         public string EncryptedExpiryMonth { get; set; }

         /// <summary>
         /// The encrypted card expiry year.
         /// </summary>
         /// <value>The encrypted card expiry year.</value>
         [DataMember(Name = "encryptedExpiryYear", EmitDefaultValue = false)]
         public string EncryptedExpiryYear { get; set; }

         /// <summary>
         /// The encrypted card verification code.
         /// </summary>
         /// <value>The encrypted card verification code.</value>
         [DataMember(Name = "encryptedSecurityCode", EmitDefaultValue = false)]
         public string EncryptedSecurityCode { get; set; }

         /// <summary>
         /// The card expiry month. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide).
         /// </summary>
         /// <value>The card expiry month. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide).</value>
         [DataMember(Name = "expiryMonth", EmitDefaultValue = false)]
         public string ExpiryMonth { get; set; }

         /// <summary>
         /// The card expiry year. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide).
         /// </summary>
         /// <value>The card expiry year. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide).</value>
         [DataMember(Name = "expiryYear", EmitDefaultValue = false)]
         public string ExpiryYear { get; set; }


         /// <summary>
         /// The name of the card holder.
         /// </summary>
         /// <value>The name of the card holder.</value>
         [DataMember(Name = "holderName", EmitDefaultValue = false)]
         public string HolderName { get; set; }

         /// <summary>
         /// The card number. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide).
         /// </summary>
         /// <value>The card number. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide).</value>
         [DataMember(Name = "number", EmitDefaultValue = false)]
         public string Number { get; set; }

         /// <summary>
         /// This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.
         /// </summary>
         /// <value>This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.</value>
         [DataMember(Name = "recurringDetailReference", EmitDefaultValue = false)]
         public string RecurringDetailReference { get; set; }

         /// <summary>
         /// The &#x60;shopperNotificationReference&#x60; returned in the response when you requested to notify the shopper. Used only for recurring payments in India.
         /// </summary>
         /// <value>The &#x60;shopperNotificationReference&#x60; returned in the response when you requested to notify the shopper. Used only for recurring payments in India.</value>
         [DataMember(Name = "shopperNotificationReference", EmitDefaultValue = false)]
         public string ShopperNotificationReference { get; set; }

         /// <summary>
         /// This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.
         /// </summary>
         /// <value>This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.</value>
         [DataMember(Name = "storedPaymentMethodId", EmitDefaultValue = false)]
         public string StoredPaymentMethodId { get; set; }

         /// <summary>
         /// Version of the 3D Secure 2 mobile SDK.
         /// </summary>
         /// <value>Version of the 3D Secure 2 mobile SDK.</value>
         [DataMember(Name = "threeDS2SdkVersion", EmitDefaultValue = false)]
         public string ThreeDS2SdkVersion { get; set; }


         /// <summary>
         /// Returns the string presentation of the object
         /// </summary>
         /// <returns>String presentation of the object</returns>
         public override string ToString()
         {
             var sb = new StringBuilder();
             sb.Append("class CardDetails {\n");
             sb.Append("  CupsecureplusSmscode: ").Append(CupsecureplusSmscode).Append("\n");
             sb.Append("  Cvc: ").Append(Cvc).Append("\n");
             sb.Append("  EncryptedCardNumber: ").Append(EncryptedCardNumber).Append("\n");
             sb.Append("  EncryptedExpiryMonth: ").Append(EncryptedExpiryMonth).Append("\n");
             sb.Append("  EncryptedExpiryYear: ").Append(EncryptedExpiryYear).Append("\n");
             sb.Append("  EncryptedSecurityCode: ").Append(EncryptedSecurityCode).Append("\n");
             sb.Append("  ExpiryMonth: ").Append(ExpiryMonth).Append("\n");
             sb.Append("  ExpiryYear: ").Append(ExpiryYear).Append("\n");
             sb.Append("  FundingSource: ").Append(FundingSource).Append("\n");
             sb.Append("  HolderName: ").Append(HolderName).Append("\n");
             sb.Append("  Number: ").Append(Number).Append("\n");
             sb.Append("  RecurringDetailReference: ").Append(RecurringDetailReference).Append("\n");
             sb.Append("  ShopperNotificationReference: ").Append(ShopperNotificationReference).Append("\n");
             sb.Append("  StoredPaymentMethodId: ").Append(StoredPaymentMethodId).Append("\n");
             sb.Append("  ThreeDS2SdkVersion: ").Append(ThreeDS2SdkVersion).Append("\n");
             sb.Append("  Type: ").Append(Type).Append("\n");
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
             return this.Equals(input as CardDetails);
         }

         /// <summary>
         /// Returns true if CardDetails instances are equal
         /// </summary>
         /// <param name="input">Instance of CardDetails to be compared</param>
         /// <returns>Boolean</returns>
         public bool Equals(CardDetails input)
         {
             if (input == null)
                 return false;

             return
                 (
                     this.CupsecureplusSmscode == input.CupsecureplusSmscode ||
                     (this.CupsecureplusSmscode != null &&
                      this.CupsecureplusSmscode.Equals(input.CupsecureplusSmscode))
                 ) &&
                 (
                     this.Cvc == input.Cvc ||
                     (this.Cvc != null &&
                      this.Cvc.Equals(input.Cvc))
                 ) &&
                 (
                     this.EncryptedCardNumber == input.EncryptedCardNumber ||
                     (this.EncryptedCardNumber != null &&
                      this.EncryptedCardNumber.Equals(input.EncryptedCardNumber))
                 ) &&
                 (
                     this.EncryptedExpiryMonth == input.EncryptedExpiryMonth ||
                     (this.EncryptedExpiryMonth != null &&
                      this.EncryptedExpiryMonth.Equals(input.EncryptedExpiryMonth))
                 ) &&
                 (
                     this.EncryptedExpiryYear == input.EncryptedExpiryYear ||
                     (this.EncryptedExpiryYear != null &&
                      this.EncryptedExpiryYear.Equals(input.EncryptedExpiryYear))
                 ) &&
                 (
                     this.EncryptedSecurityCode == input.EncryptedSecurityCode ||
                     (this.EncryptedSecurityCode != null &&
                      this.EncryptedSecurityCode.Equals(input.EncryptedSecurityCode))
                 ) &&
                 (
                     this.ExpiryMonth == input.ExpiryMonth ||
                     (this.ExpiryMonth != null &&
                      this.ExpiryMonth.Equals(input.ExpiryMonth))
                 ) &&
                 (
                     this.ExpiryYear == input.ExpiryYear ||
                     (this.ExpiryYear != null &&
                      this.ExpiryYear.Equals(input.ExpiryYear))
                 ) &&
                 (
                     this.FundingSource == input.FundingSource ||
                     (this.FundingSource != null &&
                      this.FundingSource.Equals(input.FundingSource))
                 ) &&
                 (
                     this.HolderName == input.HolderName ||
                     (this.HolderName != null &&
                      this.HolderName.Equals(input.HolderName))
                 ) &&
                 (
                     this.Number == input.Number ||
                     (this.Number != null &&
                      this.Number.Equals(input.Number))
                 ) &&
                 (
                     this.RecurringDetailReference == input.RecurringDetailReference ||
                     (this.RecurringDetailReference != null &&
                      this.RecurringDetailReference.Equals(input.RecurringDetailReference))
                 ) &&
                 (
                     this.ShopperNotificationReference == input.ShopperNotificationReference ||
                     (this.ShopperNotificationReference != null &&
                      this.ShopperNotificationReference.Equals(input.ShopperNotificationReference))
                 ) &&
                 (
                     this.StoredPaymentMethodId == input.StoredPaymentMethodId ||
                     (this.StoredPaymentMethodId != null &&
                      this.StoredPaymentMethodId.Equals(input.StoredPaymentMethodId))
                 ) &&
                 (
                     this.ThreeDS2SdkVersion == input.ThreeDS2SdkVersion ||
                     (this.ThreeDS2SdkVersion != null &&
                      this.ThreeDS2SdkVersion.Equals(input.ThreeDS2SdkVersion))
                 ) &&
                 (
                     this.Type == input.Type ||
                     (this.Type != null &&
                      this.Type.Equals(input.Type))
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
                 if (this.CupsecureplusSmscode != null)
                     hashCode = hashCode * 59 + this.CupsecureplusSmscode.GetHashCode();
                 if (this.Cvc != null)
                     hashCode = hashCode * 59 + this.Cvc.GetHashCode();
                 if (this.EncryptedCardNumber != null)
                     hashCode = hashCode * 59 + this.EncryptedCardNumber.GetHashCode();
                 if (this.EncryptedExpiryMonth != null)
                     hashCode = hashCode * 59 + this.EncryptedExpiryMonth.GetHashCode();
                 if (this.EncryptedExpiryYear != null)
                     hashCode = hashCode * 59 + this.EncryptedExpiryYear.GetHashCode();
                 if (this.EncryptedSecurityCode != null)
                     hashCode = hashCode * 59 + this.EncryptedSecurityCode.GetHashCode();
                 if (this.ExpiryMonth != null)
                     hashCode = hashCode * 59 + this.ExpiryMonth.GetHashCode();
                 if (this.ExpiryYear != null)
                     hashCode = hashCode * 59 + this.ExpiryYear.GetHashCode();
                 if (this.FundingSource != null)
                     hashCode = hashCode * 59 + this.FundingSource.GetHashCode();
                 if (this.HolderName != null)
                     hashCode = hashCode * 59 + this.HolderName.GetHashCode();
                 if (this.Number != null)
                     hashCode = hashCode * 59 + this.Number.GetHashCode();
                 if (this.RecurringDetailReference != null)
                     hashCode = hashCode * 59 + this.RecurringDetailReference.GetHashCode();
                 if (this.ShopperNotificationReference != null)
                     hashCode = hashCode * 59 + this.ShopperNotificationReference.GetHashCode();
                 if (this.StoredPaymentMethodId != null)
                     hashCode = hashCode * 59 + this.StoredPaymentMethodId.GetHashCode();
                 if (this.ThreeDS2SdkVersion != null)
                     hashCode = hashCode * 59 + this.ThreeDS2SdkVersion.GetHashCode();
                 if (this.Type != null)
                     hashCode = hashCode * 59 + this.Type.GetHashCode();
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