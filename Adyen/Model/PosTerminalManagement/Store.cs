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
    public class Store
    {
        /// <summary>
        /// List of terminals that are assigned to this store.
        /// </summary>
        /// <value>List of terminals that are assigned to this store.</value>
        [DataMember(Name = "inStoreTerminals", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "inStoreTerminals")]
        public List<string> InStoreTerminals { get; set; }

        /// <summary>
        /// The store code of the store.
        /// </summary>
        /// <value>The store code of the store.</value>
        [DataMember(Name = "store", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "store")]
        public string StorePos { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Store {\n");
            sb.Append("  InStoreTerminals: ").Append(InStoreTerminals.ToListString()).Append("\n");
            sb.Append("  StorePos: ").Append(StorePos).Append("\n");
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
