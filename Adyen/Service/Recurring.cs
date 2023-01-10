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

using Adyen.Model.Recurring;
using Adyen.Service.Resource.Recurring;
using System.Threading.Tasks;

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
            string jsonRequest = Util.JsonOperation.SerializeRequest(request);
            string jsonResponse = _listRecurringDetails.Request(jsonRequest);
            return Util.JsonOperation.Deserialize<RecurringDetailsResult>(jsonResponse);
        }

        public async Task<RecurringDetailsResult> ListRecurringDetailsAsync(RecurringDetailsRequest request)
        {
            string jsonRequest = Util.JsonOperation.SerializeRequest(request);
            string jsonResponse = await _listRecurringDetails.RequestAsync(jsonRequest);
            return Util.JsonOperation.Deserialize<RecurringDetailsResult>(jsonResponse);
        }

        public DisableResult Disable(DisableRequest disableRequest)
        {
            string jsonRequest = Util.JsonOperation.SerializeRequest(disableRequest);
            string jsonResponse = _disable.Request(jsonRequest);
            return Util.JsonOperation.Deserialize<DisableResult>(jsonResponse);
        }

        public async Task<DisableResult> DisableAsync(DisableRequest disableRequest)
        {
            string jsonRequest = Util.JsonOperation.SerializeRequest(disableRequest);
            string jsonResponse = await _disable.RequestAsync(jsonRequest);
            return Util.JsonOperation.Deserialize<DisableResult>(jsonResponse);
        }

        /// <summary>
        /// send a pre-debit notification to your shopper
        /// </summary>
        /// <param name="notifyShopperRequest"></param>
        /// <returns>NotifyShopperResult</returns>
        public NotifyShopperResult NotifyShopper(NotifyShopperRequest notifyShopperRequest)
        {
            string jsonRequest = Util.JsonOperation.SerializeRequest(notifyShopperRequest);
            string jsonResponse = _notifyShopper.Request(jsonRequest);
            return Util.JsonOperation.Deserialize<NotifyShopperResult>(jsonResponse);
        }

        /// <summary>
        /// async send a pre-debit notification to your shopper
        /// </summary>
        /// <param name="notifyShopperRequest"></param>
        /// <returns>Task<NotifyShopperResult></returns>
        public async Task<NotifyShopperResult> NotifyShopperAsync(NotifyShopperRequest notifyShopperRequest)
        {
            string jsonRequest = Util.JsonOperation.SerializeRequest(notifyShopperRequest);
            string jsonResponse = await _notifyShopper.RequestAsync(jsonRequest);
            return Util.JsonOperation.Deserialize<NotifyShopperResult>(jsonResponse);
        }
    }
}
