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
    public class GetOnboardingUrlResponse
    {
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        public string PspReference { get; set; }
        [DataMember(Name = "resultCode", EmitDefaultValue = false)]
        public string ResultCode { get; set; }
        [DataMember(Name = "submittedAsync", EmitDefaultValue = false)]
        public bool SubmittedAsync { get; set; }
        [DataMember(Name = "redirectUrl", EmitDefaultValue = false)]
        public string RedirectUrl { get; set; }
    }
}