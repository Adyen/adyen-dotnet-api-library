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
    public class BacsDirectDebitDetails : IPaymentMethodDetails
    {
        //Possible types
        public const string Directdebit_GB = "directdebit_GB";

        /// <summary>
        /// **directdebit_GB**
        /// </summary>
        /// <value>**directdebit_GB**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; } = Directdebit_GB;

        /// <summary>
        /// **bankLocationId**
        /// </summary>
        /// <value>**bankLocationId**</value>
        [DataMember(Name = "bankLocationId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bankLocationId")]
        public string BankLocationId { get; set; }

        /// <summary>
        /// **bankAccountNumber**
        /// </summary>
        /// <value>**bankAccountNumber**</value>
        [DataMember(Name = "bankAccountNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bankAccountNumber")]
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// **holderName**
        /// </summary>
        /// <value>**holderName**</value>
        [DataMember(Name = "holderName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "holderName")]
        public string HolderName { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BacsDirectDebitDetails {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  HolderName: ").Append(HolderName).Append("\n");
            sb.Append("  BankAccountNumber: ").Append(BankAccountNumber).Append("\n");
            sb.Append("  BankLocationId: ").Append(BankLocationId).Append("\n");
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
