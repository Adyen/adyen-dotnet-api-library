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
using Adyen.Util;

namespace Adyen.Model.PosTerminalManagement
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class MerchantAccount
    {
        /// <summary>
        /// List of terminals assigned to this merchant account that are assigned and ready to be boarded.
        /// </summary>
        /// <value>List of terminals assigned to this merchant account that are assigned and ready to be boarded.</value>
        [DataMember(Name = "inStoreTerminals", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "inStoreTerminals")]
        public List<string> InStoreTerminals { get; set; }

        /// <summary>
        /// List of terminals assigned to the merchant account's inventory.
        /// </summary>
        /// <value>List of terminals assigned to the merchant account's inventory.</value>
        [DataMember(Name = "inventoryTerminals", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "inventoryTerminals")]
        public List<string> InventoryTerminals { get; set; }

        /// <summary>
        /// The merchant account.
        /// </summary>
        /// <value>The merchant account.</value>
        [DataMember(Name = "merchantAccount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantAccount")]
        public string MerchantAccountPos { get; set; }

        /// <summary>
        /// Array of stores under this merchant account.
        /// </summary>
        /// <value>Array of stores under this merchant account.</value>
        [DataMember(Name = "stores", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "stores")]
        public List<Store> Stores { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantAccount {\n");
            sb.Append("  InStoreTerminals: ").Append(InStoreTerminals.ToListString()).Append("\n");
            sb.Append("  InventoryTerminals: ").Append(InventoryTerminals.ToListString()).Append("\n");
            sb.Append("  MerchantAccountPos: ").Append(MerchantAccountPos).Append("\n");
            sb.Append("  Stores: ").Append(Stores.ObjectListToString<Store>()).Append("\n");
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
