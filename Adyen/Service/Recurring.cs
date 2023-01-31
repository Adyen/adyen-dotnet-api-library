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
using System.Threading.Tasks;
using Adyen.Service.Resource;
using Newtonsoft.Json;

namespace Adyen.Service
{
    public class Recurring : AbstractService
    {
        private readonly RecurringResource _listRecurringDetails;
        private readonly RecurringResource _disable;
        private readonly RecurringResource _notifyShopper;
        private readonly RecurringResource _createPermit;
        private readonly RecurringResource _disablePermit;
        private readonly RecurringResource _scheduleAccountUpdater;

        public Recurring(Client client) : base(client)
        {
            _listRecurringDetails = new RecurringResource(this, "/listRecurringDetails");
            _disable = new RecurringResource(this, "/disable");
            _notifyShopper = new RecurringResource(this, "/notifyShopper");
            _scheduleAccountUpdater = new RecurringResource(this, "/scheduleAccountUpdate");
            _createPermit = new RecurringResource(this, "/createPermit");
            _disablePermit = new RecurringResource(this, "/disablePermit");
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
        /// <returns>NotifyShopperResult</returns>
        public async Task<NotifyShopperResult> NotifyShopperAsync(NotifyShopperRequest notifyShopperRequest)
        {
            var jsonRequest = notifyShopperRequest.ToJson();
            var jsonResponse = await _notifyShopper.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<NotifyShopperResult>(jsonResponse);
        }

        /// <summary>
        /// async disable a permit that was previously linked to a recurringDetailReference.
        /// </summary>
        /// <param name="disablePermitRequest"></param>
        /// <returns>DisableResult</returns>
        public async Task<DisablePermitResult> DisablePermitAsync(DisablePermitRequest disablePermitRequest)
        {
            var jsonRequest = disablePermitRequest.ToJson();
            var jsonResponse = await _disablePermit.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<DisablePermitResult>(jsonResponse);
        }

        /// <summary>
        /// sync disable a permit that was previously linked to a recurringDetailReference.
        /// </summary>
        /// <param name="disablePermitRequest"></param>
        /// <returns>DisableResult</returns>
        public DisablePermitResult DisablePermit(DisablePermitRequest disablePermitRequest)
        {
            return DisablePermitAsync(disablePermitRequest).GetAwaiter().GetResult();
        }

        /// <summary>
        /// async create permits for a recurring contract, including support for defining restrictions.
        /// </summary>
        /// <param name="createPermitRequest"></param>
        /// <returns>CreatePermitResult</returns>
        public async Task<CreatePermitResult> CreatePermitAsync(CreatePermitRequest createPermitRequest)
        {
            var jsonRequest = createPermitRequest.ToJson();
            var jsonResponse = await _createPermit.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<CreatePermitResult>(jsonResponse);
        }

        /// <summary>
        /// sync create permits for a recurring contract, including support for defining restrictions.
        /// </summary>
        /// <param name="createPermitRequest"></param>
        /// <returns>CreatePermitResult</returns>
        public CreatePermitResult CreatePermit(CreatePermitRequest createPermitRequest)
        {
            return CreatePermitAsync(createPermitRequest).GetAwaiter().GetResult();
        }

        /// <summary>
        /// async schedule running the Account Updater.
        /// </summary>
        /// <param name="scheduleAccountUpdaterRequest"></param>
        /// <returns>ScheduleAccountUpdaterResult</returns>
        public async Task<ScheduleAccountUpdaterResult> SchedulAccountUpdaterAsync(
            ScheduleAccountUpdaterRequest scheduleAccountUpdaterRequest)
        {
            var jsonRequest = scheduleAccountUpdaterRequest.ToJson();
            var jsonResponse = await _scheduleAccountUpdater.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<ScheduleAccountUpdaterResult>(jsonResponse);
        }

        /// <summary>
        /// sync schedule running the Account Updater.
        /// </summary>
        /// <param name="scheduleAccountUpdaterRequest"></param>
        /// <returns>ScheduleAccountUpdaterResult</returns>
        public ScheduleAccountUpdaterResult ScheduleAccountUpdater(
            ScheduleAccountUpdaterRequest scheduleAccountUpdaterRequest)
        {
            return SchedulAccountUpdaterAsync(scheduleAccountUpdaterRequest).GetAwaiter().GetResult();
        }
    }
}
