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
        [DataMember(Name = "accountHolderCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "accountHolderCode")]
        public string AccountHolderCode { get; set; }
        /// <summary>
        /// The URL where the sub-merchant will be redirected back to after they complete the onboarding, or if their session times out. Maximum length of 500 characters. If you don't provide this, the sub-merchant will be redirected back to the default return URL configured in your platform account.
        /// </summary>
        /// <value>The URL where the sub-merchant will be redirected back to after they complete the onboarding, or if their session times out. Maximum length of 500 characters. If you don't provide this, the sub-merchant will be redirected back to the default return URL configured in your platform account.</value>
        [DataMember(Name = "returnUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "returnUrl")]
        public string ReturnUrl { get; set; }
        /// <summary>
        /// The platform name which will show up in the welcome page.
        /// </summary>
        /// <value>The platform name which will show up in the welcome page.</value>
        [DataMember(Name = "platformName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "platformName")]
        public string PlatformName { get; set; }
        /// <summary>
        /// The language to be used in the page, specified by a combination of a language and country code. For example, pt-BR.
        /// If not specified in the request or if the language is not supported, the page uses the browser 
        /// language.If the browser language is not supported, the page uses en-US by default
        /// </summary>
        [DataMember(Name = "shopperLocale", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shopperLocale")]
        public string ShopperLocale { get; set; }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetOnboardingUrlRequest {\n");
            sb.Append("  AccountHolderCode: ").Append(AccountHolderCode).Append("\n");
            sb.Append("  PlatformName: ").Append(PlatformName).Append("\n");
            sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
            sb.Append("  ShopperLocale: ").Append(ShopperLocale).Append("\n");
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
