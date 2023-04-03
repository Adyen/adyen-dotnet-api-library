﻿using System.Net.Http;
using System.Threading.Tasks;
using Adyen.Constants;
using Adyen.Model;
using Adyen.Model.Recurring;

namespace Adyen.Service
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RecurringService : AbstractService
    {
        private readonly string _baseUrl;
        
        public RecurringService(Client client) : base(client)
        {
            _baseUrl = client.Config.Endpoint + "/pal/servlet/Recurring/" + ClientConfig.RecurringApiVersion;
        }
    
        /// <summary>
        /// Create new permits linked to a recurring contract.
        /// </summary>
        /// <param name="createPermitRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>CreatePermitResult</returns>
        public CreatePermitResult CreatePermit(CreatePermitRequest createPermitRequest, RequestOptions requestOptions = default)
        {
            return CreatePermitAsync(createPermitRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create new permits linked to a recurring contract.
        /// </summary>
        /// <param name="createPermitRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of CreatePermitResult</returns>
        public async Task<CreatePermitResult> CreatePermitAsync(CreatePermitRequest createPermitRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + "/createPermit";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<CreatePermitResult>(createPermitRequest.ToJson(), requestOptions, new HttpMethod("POST"));
        }

        /// <summary>
        /// Disable stored payment details
        /// </summary>
        /// <param name="disableRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>DisableResult</returns>
        public DisableResult Disable(DisableRequest disableRequest, RequestOptions requestOptions = default)
        {
            return DisableAsync(disableRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Disable stored payment details
        /// </summary>
        /// <param name="disableRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of DisableResult</returns>
        public async Task<DisableResult> DisableAsync(DisableRequest disableRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + "/disable";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<DisableResult>(disableRequest.ToJson(), requestOptions, new HttpMethod("POST"));
        }

        /// <summary>
        /// Disable an existing permit.
        /// </summary>
        /// <param name="disablePermitRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>DisablePermitResult</returns>
        public DisablePermitResult DisablePermit(DisablePermitRequest disablePermitRequest, RequestOptions requestOptions = default)
        {
            return DisablePermitAsync(disablePermitRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Disable an existing permit.
        /// </summary>
        /// <param name="disablePermitRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of DisablePermitResult</returns>
        public async Task<DisablePermitResult> DisablePermitAsync(DisablePermitRequest disablePermitRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + "/disablePermit";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<DisablePermitResult>(disablePermitRequest.ToJson(), requestOptions, new HttpMethod("POST"));
        }

        /// <summary>
        /// Get stored payment details
        /// </summary>
        /// <param name="recurringDetailsRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>RecurringDetailsResult</returns>
        public RecurringDetailsResult ListRecurringDetails(RecurringDetailsRequest recurringDetailsRequest, RequestOptions requestOptions = default)
        {
            return ListRecurringDetailsAsync(recurringDetailsRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get stored payment details
        /// </summary>
        /// <param name="recurringDetailsRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of RecurringDetailsResult</returns>
        public async Task<RecurringDetailsResult> ListRecurringDetailsAsync(RecurringDetailsRequest recurringDetailsRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + "/listRecurringDetails";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<RecurringDetailsResult>(recurringDetailsRequest.ToJson(), requestOptions, new HttpMethod("POST"));
        }

        /// <summary>
        /// Ask issuer to notify the shopper
        /// </summary>
        /// <param name="notifyShopperRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>NotifyShopperResult</returns>
        public NotifyShopperResult NotifyShopper(NotifyShopperRequest notifyShopperRequest, RequestOptions requestOptions = default)
        {
            return NotifyShopperAsync(notifyShopperRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Ask issuer to notify the shopper
        /// </summary>
        /// <param name="notifyShopperRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of NotifyShopperResult</returns>
        public async Task<NotifyShopperResult> NotifyShopperAsync(NotifyShopperRequest notifyShopperRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + "/notifyShopper";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<NotifyShopperResult>(notifyShopperRequest.ToJson(), requestOptions, new HttpMethod("POST"));
        }

        /// <summary>
        /// Schedule running the Account Updater
        /// </summary>
        /// <param name="scheduleAccountUpdaterRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>ScheduleAccountUpdaterResult</returns>
        public ScheduleAccountUpdaterResult ScheduleAccountUpdater(ScheduleAccountUpdaterRequest scheduleAccountUpdaterRequest, RequestOptions requestOptions = default)
        {
            return ScheduleAccountUpdaterAsync(scheduleAccountUpdaterRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Schedule running the Account Updater
        /// </summary>
        /// <param name="scheduleAccountUpdaterRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of ScheduleAccountUpdaterResult</returns>
        public async Task<ScheduleAccountUpdaterResult> ScheduleAccountUpdaterAsync(ScheduleAccountUpdaterRequest scheduleAccountUpdaterRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + "/scheduleAccountUpdater";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<ScheduleAccountUpdaterResult>(scheduleAccountUpdaterRequest.ToJson(), requestOptions, new HttpMethod("POST"));
        }

    }
}
