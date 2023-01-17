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
 * Copyright (c) 2021 Adyen B.V.
 * This file is open source and available under the MIT license.
 * See the LICENSE file for more info.
 */
#endregion

using System;
using Adyen.Model.Recurring;
using Adyen.Service.Resource.Recurring;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Adyen.Service
{
    public class Recurring : AbstractService
    {
        private readonly ListRecurringDetails _listRecurringDetails;
        private Disable _disable;
        private NotifyShopper _notifyShopper;

        public Recurring(Client client) : base(client)
        {
            _listRecurringDetails = new ListRecurringDetails(this);
            _disable = new Disable(this);
            _notifyShopper = new NotifyShopper(this);
        }

        public RecurringDetailsResult ListRecurringDetails(RecurringDetailsRequest request)
        {
            var jsonRequest = request.ToJson();
            var jsonResponse = _listRecurringDetails.Request(jsonRequest);
            return JsonConvert.DeserializeObject<RecurringDetailsResult>(jsonResponse);
        }

        public async Task<RecurringDetailsResult> ListRecurringDetailsAsync(RecurringDetailsRequest request)
        {
            var jsonRequest = request.ToJson();
            var jsonResponse = await _listRecurringDetails.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<RecurringDetailsResult>(jsonResponse);
        }

        public DisableResult Disable(DisableRequest disableRequest)
        {
            var jsonRequest = disableRequest.ToJson();
            var jsonResponse = _disable.Request(jsonRequest);
            return JsonConvert.DeserializeObject<DisableResult>(jsonResponse);
        }

        public async Task<DisableResult> DisableAsync(DisableRequest disableRequest)
        {
            var jsonRequest = disableRequest.ToJson();
            var jsonResponse = await _disable.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<DisableResult>(jsonResponse);
        }

        /// <summary>
        /// send a pre-debit notification to your shopper
        /// </summary>
        /// <param name="notifyShopperRequest"></param>
        /// <returns>NotifyShopperResult</returns>
        public NotifyShopperResult NotifyShopper(NotifyShopperRequest notifyShopperRequest)
        {
            var jsonRequest = notifyShopperRequest.ToJson();
            var jsonResponse = _notifyShopper.Request(jsonRequest);
            return JsonConvert.DeserializeObject<NotifyShopperResult>(jsonResponse);
        }

        /// <summary>
        /// async send a pre-debit notification to your shopper
        /// </summary>
        /// <param name="notifyShopperRequest"></param>
        /// <returns>Task<NotifyShopperResult></returns>
        public async Task<NotifyShopperResult> NotifyShopperAsync(NotifyShopperRequest notifyShopperRequest)
        {
            var jsonRequest = notifyShopperRequest.ToJson();
            var jsonResponse = await _notifyShopper.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<NotifyShopperResult>(jsonResponse);
        }
    }
}
