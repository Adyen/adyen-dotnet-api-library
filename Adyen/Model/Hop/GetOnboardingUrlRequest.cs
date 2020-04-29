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
using System;
using System.Text;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Adyen.Model.Hop
{
    [DataContract]
    public class GetOnboardingUrlRequest
    {
        /// <summary>
    /// The account holder code you provided when you created the account holder.
    /// </summary>
    /// <value>The account holder code you provided when you created the account holder.</value>
    [DataMember(Name="accountHolderCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountHolderCode")]
        public string AccountHolderCode { get; set; }
        [DataMember(Name = "returnUrl", EmitDefaultValue = false)]
        public string ReturnUrl { get; set; }
        [DataMember(Name = "hopWebserviceUser", EmitDefaultValue = false)]
        public string HopWebserviceUser { get; set; }
    }
}
