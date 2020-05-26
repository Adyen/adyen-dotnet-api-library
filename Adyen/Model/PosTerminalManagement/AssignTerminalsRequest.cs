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
    public class AssignTerminalsRequest
    {
        /// <summary>
        /// Your company account.
        /// </summary>
        /// <value>Your company account.</value>
        [DataMember(Name = "companyAccount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "companyAccount")]
        public string CompanyAccount { get; set; }

        /// <summary>
        /// The merchant account you are assigning the terminal to.
        /// </summary>
        /// <value>The merchant account you are assigning the terminal to.</value>
        [DataMember(Name = "merchantAccount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantAccount")]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// Boolean that indicates if you are assigning the terminals to the merchant inventory. This is required when assigning the terminal to a merchant account.  - Set this to **true** to indicate that the terminal is in the merchant inventory. This also means that the terminals cannot be boarded.  - Set this to **false** to indicate that the terminal is ready to be boarded and to process payments through the specific merchant account.
        /// </summary>
        /// <value>Boolean that indicates if you are assigning the terminals to the merchant inventory. This is required when assigning the terminal to a merchant account.  - Set this to **true** to indicate that the terminal is in the merchant inventory. This also means that the terminals cannot be boarded.  - Set this to **false** to indicate that the terminal is ready to be boarded and to process payments through the specific merchant account.</value>
        [DataMember(Name = "merchantInventory", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantInventory")]
        public bool? MerchantInventory { get; set; }

        /// <summary>
        /// The store code of the store that you want to assign the terminals to.
        /// </summary>
        /// <value>The store code of the store that you want to assign the terminals to.</value>
        [DataMember(Name = "store", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "store")]
        public string Store { get; set; }

        /// <summary>
        /// Array containing a list of terminal IDs that you want to assign or reassign to the merchant account, store, or company account to return to the company inventory.  For example, `[\"V400m-324689776\",\"P400Plus-329127412\"]`.
        /// </summary>
        /// <value>Array containing a list of terminal IDs that you want to assign or reassign to the merchant account, store, or company account to return to the company inventory.  For example, `[\"V400m-324689776\",\"P400Plus-329127412\"]`.</value>
        [DataMember(Name = "terminals", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "terminals")]
        public List<string> Terminals { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssignTerminalsRequest {\n");
            sb.Append("  CompanyAccount: ").Append(CompanyAccount).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  MerchantInventory: ").Append(MerchantInventory).Append("\n");
            sb.Append("  Store: ").Append(Store).Append("\n");
            sb.Append("  Terminals: ").Append(Terminals.ToListString()).Append("\n");
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
