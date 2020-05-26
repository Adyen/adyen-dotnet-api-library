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
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.PosTerminalManagement
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class GetTerminalsUnderAccountResponse
    {
        /// <summary>
        /// Your company account.
        /// </summary>
        /// <value>Your company account.</value>
        [DataMember(Name = "companyAccount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "companyAccount")]
        public string CompanyAccount { get; set; }

        /// <summary>
        /// Array that returns a list of all terminals that are part of the company's inventory.
        /// </summary>
        /// <value>Array that returns a list of all terminals that are part of the company's inventory.</value>
        [DataMember(Name = "inventoryTerminals", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "inventoryTerminals")]
        public List<string> InventoryTerminals { get; set; }

        /// <summary>
        /// Array that returns a list of all merchant accounts that are part of the company account.
        /// </summary>
        /// <value>Array that returns a list of all merchant accounts that are part of the company account.</value>
        [DataMember(Name = "merchantAccounts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantAccounts")]
        public List<MerchantAccount> MerchantAccounts { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetTerminalsUnderAccountResponse {\n");
            sb.Append("  CompanyAccount: ").Append(CompanyAccount).Append("\n");
            sb.Append("  InventoryTerminals: ").Append(InventoryTerminals).Append("\n");
            sb.Append("  MerchantAccounts: ").Append(MerchantAccounts).Append("\n");
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
