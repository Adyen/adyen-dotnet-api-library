#region License
/*
 *                       ######
 *                       ######
 * ############    ####( ######  #####. ######  ############   ############
 * #############  #####( ######  #####. ######  #############  #############
 *        ######  #####( ######  #####. ######  #####  ######  #####  ######
 * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
 * ###### ######  #####( ######  #####. ######  #####          #####  ######
 * #############  #############  #############  #############  #####  ######
 *  ############   ############  #############   ############  #####  ######
 *                                      ######
 *                               #############
 *                               ############
 *
 * Adyen Dotnet API Library
 *
 * Copyright (c) 2020 Adyen B.V.
 * This file is open source and available under the MIT license.
 * See the LICENSE file for more info.
 */
#endregion

using Newtonsoft.Json;

namespace Adyen.Model.Checkout.Action
{
    public interface IPaymentResponseAction
    {
        [JsonProperty(PropertyName = "paymentMethodType")]
        string PaymentMethodType { get; set; }

        [JsonProperty(PropertyName = "url")]
        string Url { get; set; }

        [JsonProperty(PropertyName = "type")]
        string Type { get; set; }

        [JsonProperty(PropertyName = "method")]
        string Method { get; set; }
    }
}
