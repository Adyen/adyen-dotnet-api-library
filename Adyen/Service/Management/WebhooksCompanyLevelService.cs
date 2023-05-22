/*
* Management API
*
*
* The version of the OpenAPI document: 1
* Contact: developer-experience@adyen.com
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Constants;
using Adyen.Model;
using Adyen.Service.Resource;
using Adyen.Model.Management;

namespace Adyen.Service.Management
{
    /// <summary>
    /// WebhooksCompanyLevelService Interface
    /// </summary>
    public interface IWebhooksCompanyLevelService
    {
        /// <summary>
        /// Generate an HMAC key
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="webhookId"><see cref="string"/> - Unique identifier of the webhook configuration.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="GenerateHmacKeyResponse"/>.</returns>
        GenerateHmacKeyResponse GenerateHmacKey(string companyId, string webhookId, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Generate an HMAC key
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="webhookId"><see cref="string"/> - Unique identifier of the webhook configuration.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="GenerateHmacKeyResponse"/>.</returns>
        Task<GenerateHmacKeyResponse> GenerateHmacKeyAsync(string companyId, string webhookId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get a webhook
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - Unique identifier of the [company account](https://docs.adyen.com/account/account-structure#company-account).</param>
        /// <param name="webhookId"><see cref="string"/> - Unique identifier of the webhook configuration.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="Webhook"/>.</returns>
        Webhook GetWebhook(string companyId, string webhookId, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a webhook
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - Unique identifier of the [company account](https://docs.adyen.com/account/account-structure#company-account).</param>
        /// <param name="webhookId"><see cref="string"/> - Unique identifier of the webhook configuration.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="Webhook"/>.</returns>
        Task<Webhook> GetWebhookAsync(string companyId, string webhookId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// List all webhooks
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - Unique identifier of the [company account](https://docs.adyen.com/account/account-structure#company-account).</param>
        /// <param name="pageNumber"><see cref="int?"/> - The number of the page to fetch.</param>
        /// <param name="pageSize"><see cref="int?"/> - The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="ListWebhooksResponse"/>.</returns>
        ListWebhooksResponse ListAllWebhooks(string companyId, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// List all webhooks
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - Unique identifier of the [company account](https://docs.adyen.com/account/account-structure#company-account).</param>
        /// <param name="pageNumber"><see cref="int?"/> - The number of the page to fetch.</param>
        /// <param name="pageSize"><see cref="int?"/> - The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="ListWebhooksResponse"/>.</returns>
        Task<ListWebhooksResponse> ListAllWebhooksAsync(string companyId, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Remove a webhook
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="webhookId"><see cref="string"/> - Unique identifier of the webhook configuration.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        void RemoveWebhook(string companyId, string webhookId, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Remove a webhook
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="webhookId"><see cref="string"/> - Unique identifier of the webhook configuration.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        Task RemoveWebhookAsync(string companyId, string webhookId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Set up a webhook
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - Unique identifier of the [company account](https://docs.adyen.com/account/account-structure#company-account).</param>
        /// <param name="createCompanyWebhookRequest"><see cref="CreateCompanyWebhookRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="Webhook"/>.</returns>
        Webhook SetUpWebhook(string companyId, CreateCompanyWebhookRequest createCompanyWebhookRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Set up a webhook
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - Unique identifier of the [company account](https://docs.adyen.com/account/account-structure#company-account).</param>
        /// <param name="createCompanyWebhookRequest"><see cref="CreateCompanyWebhookRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="Webhook"/>.</returns>
        Task<Webhook> SetUpWebhookAsync(string companyId, CreateCompanyWebhookRequest createCompanyWebhookRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Test a webhook
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="webhookId"><see cref="string"/> - Unique identifier of the webhook configuration.</param>
        /// <param name="testCompanyWebhookRequest"><see cref="TestCompanyWebhookRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="TestWebhookResponse"/>.</returns>
        TestWebhookResponse TestWebhook(string companyId, string webhookId, TestCompanyWebhookRequest testCompanyWebhookRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Test a webhook
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="webhookId"><see cref="string"/> - Unique identifier of the webhook configuration.</param>
        /// <param name="testCompanyWebhookRequest"><see cref="TestCompanyWebhookRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="TestWebhookResponse"/>.</returns>
        Task<TestWebhookResponse> TestWebhookAsync(string companyId, string webhookId, TestCompanyWebhookRequest testCompanyWebhookRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Update a webhook
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="webhookId"><see cref="string"/> - Unique identifier of the webhook configuration.</param>
        /// <param name="updateCompanyWebhookRequest"><see cref="UpdateCompanyWebhookRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="Webhook"/>.</returns>
        Webhook UpdateWebhook(string companyId, string webhookId, UpdateCompanyWebhookRequest updateCompanyWebhookRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Update a webhook
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="webhookId"><see cref="string"/> - Unique identifier of the webhook configuration.</param>
        /// <param name="updateCompanyWebhookRequest"><see cref="UpdateCompanyWebhookRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="Webhook"/>.</returns>
        Task<Webhook> UpdateWebhookAsync(string companyId, string webhookId, UpdateCompanyWebhookRequest updateCompanyWebhookRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the WebhooksCompanyLevelService API endpoints
    /// </summary>
    public class WebhooksCompanyLevelService : AbstractService, IWebhooksCompanyLevelService
    {
        private readonly string _baseUrl;
        
        public WebhooksCompanyLevelService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://management-test.adyen.com/v1");
        }
        
        public GenerateHmacKeyResponse GenerateHmacKey(string companyId, string webhookId, RequestOptions requestOptions = default)
        {
            return GenerateHmacKeyAsync(companyId, webhookId, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<GenerateHmacKeyResponse> GenerateHmacKeyAsync(string companyId, string webhookId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/companies/{companyId}/webhooks/{webhookId}/generateHmac";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<GenerateHmacKeyResponse>(null, requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public Webhook GetWebhook(string companyId, string webhookId, RequestOptions requestOptions = default)
        {
            return GetWebhookAsync(companyId, webhookId, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Webhook> GetWebhookAsync(string companyId, string webhookId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/companies/{companyId}/webhooks/{webhookId}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Webhook>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public ListWebhooksResponse ListAllWebhooks(string companyId, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default)
        {
            return ListAllWebhooksAsync(companyId, pageNumber, pageSize, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<ListWebhooksResponse> ListAllWebhooksAsync(string companyId, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (pageNumber != null) queryParams.Add("pageNumber", pageNumber.ToString());
            if (pageSize != null) queryParams.Add("pageSize", pageSize.ToString());
            var endpoint = _baseUrl + $"/companies/{companyId}/webhooks" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<ListWebhooksResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public void RemoveWebhook(string companyId, string webhookId, RequestOptions requestOptions = default)
        {
            RemoveWebhookAsync(companyId, webhookId, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task RemoveWebhookAsync(string companyId, string webhookId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/companies/{companyId}/webhooks/{webhookId}";
            var resource = new ServiceResource(this, endpoint);
            await resource.RequestAsync(null, requestOptions, new HttpMethod("DELETE"), cancellationToken).ConfigureAwait(false);
        }
        
        public Webhook SetUpWebhook(string companyId, CreateCompanyWebhookRequest createCompanyWebhookRequest, RequestOptions requestOptions = default)
        {
            return SetUpWebhookAsync(companyId, createCompanyWebhookRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Webhook> SetUpWebhookAsync(string companyId, CreateCompanyWebhookRequest createCompanyWebhookRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/companies/{companyId}/webhooks";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Webhook>(createCompanyWebhookRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public TestWebhookResponse TestWebhook(string companyId, string webhookId, TestCompanyWebhookRequest testCompanyWebhookRequest, RequestOptions requestOptions = default)
        {
            return TestWebhookAsync(companyId, webhookId, testCompanyWebhookRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<TestWebhookResponse> TestWebhookAsync(string companyId, string webhookId, TestCompanyWebhookRequest testCompanyWebhookRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/companies/{companyId}/webhooks/{webhookId}/test";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<TestWebhookResponse>(testCompanyWebhookRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public Webhook UpdateWebhook(string companyId, string webhookId, UpdateCompanyWebhookRequest updateCompanyWebhookRequest, RequestOptions requestOptions = default)
        {
            return UpdateWebhookAsync(companyId, webhookId, updateCompanyWebhookRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Webhook> UpdateWebhookAsync(string companyId, string webhookId, UpdateCompanyWebhookRequest updateCompanyWebhookRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/companies/{companyId}/webhooks/{webhookId}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Webhook>(updateCompanyWebhookRequest.ToJson(), requestOptions, new HttpMethod("PATCH"), cancellationToken).ConfigureAwait(false);
        }
    }
}