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

namespace Adyen.Model.PosTerminalManagement
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class FindTerminalResponse
    {
        /// <summary>
        /// The company account.
        /// </summary>
        /// <value>The company account.</value>
        [DataMember(Name = "companyAccount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "companyAccount")]
        public string CompanyAccount { get; set; }

        /// <summary>
        /// The merchant account that the terminal is assigned to, if applicable.
        /// </summary>
        /// <value>The merchant account that the terminal is assigned to, if applicable.</value>
        [DataMember(Name = "merchantAccount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantAccount")]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// Boolean that indicates if the terminal is assigned to the merchant inventory. This is returned when the terminal is assigned to a merchant account.  - If **true**, this indicates that the terminal is in the merchant inventory. This also means that the terminals cannot be boarded.  - If **false**, this indicates that the terminal is ready to be boarded, or is already boarded.
        /// </summary>
        /// <value>Boolean that indicates if the terminal is assigned to the merchant inventory. This is returned when the terminal is assigned to a merchant account.  - If **true**, this indicates that the terminal is in the merchant inventory. This also means that the terminals cannot be boarded.  - If **false**, this indicates that the terminal is ready to be boarded, or is already boarded.</value>
        [DataMember(Name = "merchantInventory", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantInventory")]
        public bool? MerchantInventory { get; set; }

        /// <summary>
        /// The store code of the store that the terminal is assigned to, if applicable.
        /// </summary>
        /// <value>The store code of the store that the terminal is assigned to, if applicable.</value>
        [DataMember(Name = "store", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "store")]
        public string Store { get; set; }

        /// <summary>
        /// The terminal ID.
        /// </summary>
        /// <value>The terminal ID.</value>
        [DataMember(Name = "terminal", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "terminal")]
        public string Terminal { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FindTerminalResponse {\n");
            sb.Append("  CompanyAccount: ").Append(CompanyAccount).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  MerchantInventory: ").Append(MerchantInventory).Append("\n");
            sb.Append("  Store: ").Append(Store).Append("\n");
            sb.Append("  Terminal: ").Append(Terminal).Append("\n");
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
