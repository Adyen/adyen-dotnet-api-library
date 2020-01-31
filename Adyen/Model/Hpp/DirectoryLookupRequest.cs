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

namespace Adyen.Model.Hpp
{
    public class DirectoryLookupRequest
    {
        public string CurrencyCode { get; set; }
        public string PaymentAmount { get; set; }
        public string SessionValidity { get; set; }
        public string MerchantReference { get; set; }
        public string CountryCode { get; set; }
        public string SkinCode { get; set; }
        public string MerchantAccount { get; set; }
        public string HmacKey { get; set; }
        public string ShopperLocale { get; set; }
    }
}
