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

using Adyen.Model.Checkout;
using Adyen.Service.Resource.Checkout;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adyen.Service
{
    public class CheckoutUtility : AbstractService
    {
        private OriginKeys _originKeys;
        public CheckoutUtility(Client client)
            : base(client)
        {
            IsApiKeyRequired = true;
            _originKeys = new OriginKeys(this);
        }

        public CheckoutUtilityResponse OriginKeys(CheckoutUtilityRequest checkoutUtilityRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(checkoutUtilityRequest);
            var jsonResponse = _originKeys.Request(jsonRequest);
            return JsonConvert.DeserializeObject<CheckoutUtilityResponse>(jsonResponse);
        }
    }
}
