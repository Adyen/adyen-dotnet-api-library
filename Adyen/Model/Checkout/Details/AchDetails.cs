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
    public class AchDetails : IPaymentMethodDetails
    {
        //Possible types
        public const string Ach = "ach";
        /// <summary>
        /// The bank account number (without separators).
        /// </summary>
        /// <value>The bank account number (without separators).</value>
        [DataMember(Name = "bankAccountNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bankAccountNumber")]
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// The bank routing number of the account. The field value is `nil` in most cases.
        /// </summary>
        /// <value>The bank routing number of the account. The field value is `nil` in most cases.</value>
        [DataMember(Name = "bankLocationId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bankLocationId")]
        public string BankLocationId { get; set; }

        /// <summary>
        /// Encrypted bank account number. The bank account number (without separators).
        /// </summary>
        /// <value>Encrypted bank account number. The bank account number (without separators).</value>
        [DataMember(Name = "encryptedBankAccountNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "encryptedBankAccountNumber")]
        public string EncryptedBankAccountNumber { get; set; }

        /// <summary>
        /// Encrypted location id. The bank routing number of the account. The field value is `nil` in most cases.
        /// </summary>
        /// <value>Encrypted location id. The bank routing number of the account. The field value is `nil` in most cases.</value>
        [DataMember(Name = "encryptedBankLocationId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "encryptedBankLocationId")]
        public string EncryptedBankLocationId { get; set; }

        /// <summary>
        /// The name of the bank account holder. If you submit a name with non-Latin characters, we automatically replace some of them with corresponding Latin characters to meet the FATF recommendations. For example: * χ12 is converted to ch12. * üA is converted to euA. * Peter Møller is converted to Peter Mller, because banks don't accept 'ø'. After replacement, the ownerName must have at least three alphanumeric characters (A-Z, a-z, 0-9), and at least one of them must be a valid Latin character (A-Z, a-z). For example: * John17 - allowed. * J17 - allowed. * 171 - not allowed. * John-7 - allowed. > If provided details don't match the required format, the response returns the error message: 203 'Invalid bank account holder name'.
        /// </summary>
        /// <value>The name of the bank account holder. If you submit a name with non-Latin characters, we automatically replace some of them with corresponding Latin characters to meet the FATF recommendations. For example: * χ12 is converted to ch12. * üA is converted to euA. * Peter Møller is converted to Peter Mller, because banks don't accept 'ø'. After replacement, the ownerName must have at least three alphanumeric characters (A-Z, a-z, 0-9), and at least one of them must be a valid Latin character (A-Z, a-z). For example: * John17 - allowed. * J17 - allowed. * 171 - not allowed. * John-7 - allowed. > If provided details don't match the required format, the response returns the error message: 203 'Invalid bank account holder name'.</value>
        [DataMember(Name = "ownerName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ownerName")]
        public string OwnerName { get; set; }

        /// <summary>
        /// This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.
        /// </summary>
        /// <value>This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.</value>
        [DataMember(Name = "recurringDetailReference", EmitDefaultValue = false)]
        public string RecurringDetailReference { get; set; }

        /// <summary>
        /// This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.
        /// </summary>
        /// <value>This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.</value>
        [DataMember(Name = "storedPaymentMethodId", EmitDefaultValue = false)]
        public string StoredPaymentMethodId { get; set; }

        /// <summary>
        /// **ach**
        /// </summary>
        /// <value>**ach**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; } = Ach;

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AchDetails {\n");
            sb.Append("  BankAccountNumber: ").Append(BankAccountNumber).Append("\n");
            sb.Append("  BankLocationId: ").Append(BankLocationId).Append("\n");
            sb.Append("  EncryptedBankAccountNumber: ").Append(EncryptedBankAccountNumber).Append("\n");
            sb.Append("  EncryptedBankLocationId: ").Append(EncryptedBankLocationId).Append("\n");
            sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
            sb.Append("  RecurringDetailReference: ").Append(RecurringDetailReference).Append("\n");
            sb.Append("  StoredPaymentMethodId: ").Append(StoredPaymentMethodId).Append("\n");
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
