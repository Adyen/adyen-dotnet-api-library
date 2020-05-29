#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using Adyen.Model.ApplicationInformation;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.Model.Modification
{
    [DataContract]
    public class RefundRequest : AbstractModificationRequest
    {
        [DataMember(Name = "modificationAmount", EmitDefaultValue = false)]
        public Amount ModificationAmount { get; set; }

        public RefundRequest()
        {
             if(ApplicationInfo==null)
                ApplicationInfo = new ApplicationInfo();
        }

        /// <summary>
        /// The details of how the refund should be split when distributing a refund from a MarketPay Marketplace and its Accounts.
        /// </summary>
        /// <value>The details of how the refund should be split when distributing a refund from a MarketPay Marketplace and its Accounts.</value>
        [DataMember(Name = "splits", EmitDefaultValue = false)]
        public List<Split> Splits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefundRequest {\n");
            sb.Append(base.ToString());
            sb.Append("  modificationAmount.Currency: ").Append(ModificationAmount.Currency).Append("\n");
            sb.Append("  modificationAmount.Value: ").Append(ModificationAmount.Value).Append("\n");

            sb.Append("}");
            return sb.ToString();
        }
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
