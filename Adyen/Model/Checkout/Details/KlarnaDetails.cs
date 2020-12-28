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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout.Details
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class KlarnaDetails : IPaymentMethodDetails
    {
        //Possible types
        public const string Klarna = "klarna";
        public const string KlarnaPayments = "klarnapayments";
        public const string KlarnaPaymentsAccount = "klarnapayments_account";
        public const string KlarnaPaymentsB2B = "klarnapayments_b2b";
        public const string KlarnaPayNow = "klarna_paynow";
        public const string KlarnaAccount = "klarna_account";
        public const string KlarnaB2B = "klarna_b2b";
        /// <summary>
        /// The bank account number.
        /// </summary>
        /// <value>The bank account number.</value>
        [DataMember(Name = "bankAccount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bankAccount")]
        public string BankAccount { get; set; }

        /// <summary>
        /// billingAddress 
        /// </summary>
        /// <value>billingAddress </value>
        [DataMember(Name = "billingAddress ", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "billingAddress ")]
        public string BillingAddress { get; set; }

        /// <summary>
        /// deliveryAddress 
        /// </summary>
        /// <value>deliveryAddress </value>
        [DataMember(Name = "deliveryAddress ", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "deliveryAddress ")]
        public string DeliveryAddress { get; set; }

        /// <summary>
        /// installmentConfigurationKey
        /// </summary>
        /// <value>installmentConfigurationKey</value>
        [DataMember(Name = "installmentConfigurationKey ", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "installmentConfigurationKey ")]
        public string InstallmentConfigurationKey { get; set; }

        /// <summary>
        /// personalDetails.
        /// </summary>
        /// <value>personalDetails</value>
        [DataMember(Name = "personalDetails", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "personalDetails")]
        public string PersonalDetails { get; set; }

        /// <summary>
        /// separateDeliveryAddress.
        /// </summary>
        /// <value>separateDeliveryAddress</value>
        [DataMember(Name = "separateDeliveryAddress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "separateDeliveryAddress")]
        public string SeparateDeliveryAddress { get; set; }

        /// <summary>
        /// storedPaymentMethodId.
        /// </summary>
        /// <value>storedPaymentMethodId.</value>
        [DataMember(Name = "storedPaymentMethodId", EmitDefaultValue = false)]
        public string StoredPaymentMethodId { get; set; }

        /// <summary>
        /// token.
        /// </summary>
        /// <value>token.</value>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public string Token { get; set; }

        /// <summary>
        /// **KlarnaDetail**
        /// </summary>
        /// <value>**KlarnaDetail**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KlarnaDetail {\n");
            sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  DeliveryAddress: ").Append(DeliveryAddress).Append("\n");
            sb.Append("  InstallmentConfigurationKey: ").Append(InstallmentConfigurationKey).Append("\n");
            sb.Append("  PersonalDetails: ").Append(PersonalDetails).Append("\n");
            sb.Append("  SeparateDeliveryAddress: ").Append(SeparateDeliveryAddress).Append("\n");
            sb.Append("  StoredPaymentMethodId: ").Append(StoredPaymentMethodId).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
