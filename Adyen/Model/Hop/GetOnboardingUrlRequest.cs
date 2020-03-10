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

using System.Runtime.Serialization;

namespace Adyen.Model.Hop
{
    [DataContract]
    public class GetOnboardingUrlRequest
    {
        [DataMember(Name = "accountHolderCode", EmitDefaultValue = false)]
        public string AccountHolderCode { get; set; }
        [DataMember(Name = "returnUrl", EmitDefaultValue = false)]
        public string ReturnUrl { get; set; }
        [DataMember(Name = "hopWebserviceUser", EmitDefaultValue = false)]
        public string HopWebserviceUser { get; set; }
    }
}
