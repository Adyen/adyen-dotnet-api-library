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
            /// <summary>
    /// The URL where the sub-merchant will be redirected back to after they complete the onboarding, or if their session times out. Maximum length of 500 characters. If you don't provide this, the sub-merchant will be redirected back to the default return URL configured in your platform account.
    /// </summary>
    /// <value>The URL where the sub-merchant will be redirected back to after they complete the onboarding, or if their session times out. Maximum length of 500 characters. If you don't provide this, the sub-merchant will be redirected back to the default return URL configured in your platform account.</value>
    [DataMember(Name="returnUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "returnUrl")]
        public string ReturnUrl { get; set; }
          /// <summary>
    /// The platform name which will show up in the welcome page.
    /// </summary>
    /// <value>The platform name which will show up in the welcome page.</value>
    [DataMember(Name="platformName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "platformName")]
    public string PlatformName { get; set; }
        public string HopWebserviceUser { get; set; }
    }
}
