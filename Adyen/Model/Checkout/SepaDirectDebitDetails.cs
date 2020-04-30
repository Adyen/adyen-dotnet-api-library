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

namespace Adyen.Model.Checkout
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class SepaDirectDebitDetails : IOneOfPaymentRequestPaymentMethod
    {
        /// <summary>
        /// The International Bank Account Number (IBAN).
        /// </summary>
        /// <value>The International Bank Account Number (IBAN).</value>
        [DataMember(Name = "iban", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "iban")]
        public string Iban { get; set; }

        /// <summary>
        /// The name of the bank account holder.
        /// </summary>
        /// <value>The name of the bank account holder.</value>
        [DataMember(Name = "ownerName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ownerName")]
        public string OwnerName { get; set; }

        /// <summary>
        /// **sepadirectdebit**
        /// </summary>
        /// <value>**sepadirectdebit**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; } = "sepadirectdebit"; 


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SepaDirectDebitDetails {\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
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
