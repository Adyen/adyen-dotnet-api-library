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
using System.Net.Http;
using System.Threading.Tasks;
using Adyen.Model;
using Adyen.Service.Resource;
using Adyen.Model.Management;
using Newtonsoft.Json;

namespace Adyen.Service.Management
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WebhooksMerchantLevelApi : AbstractService
    {
        public WebhooksMerchantLevelApi(Client client) : base(client) {}
    
        /// <summary>
        /// Remove a webhook Remove the configuration for the webhook identified in the path.  To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Webhooks read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="webhookId">Unique identifier of the webhook configuration.</param>
        /// <returns></returns>
        /// <param name="requestOptions">Additional request options</param>
        public void DeleteMerchantsMerchantIdWebhooksWebhookId(string merchantId, string webhookId, RequestOptions requestOptions = default)
        {
            DeleteMerchantsMerchantIdWebhooksWebhookIdAsync(merchantId, webhookId, requestOptions);
        }

        /// <summary>
        /// Remove a webhook Remove the configuration for the webhook identified in the path.  To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Webhooks read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="webhookId">Unique identifier of the webhook configuration.</param>
        /// <returns>Task of void</returns>
        /// <param name="requestOptions">Additional request options</param>
        public async Task DeleteMerchantsMerchantIdWebhooksWebhookIdAsync(string merchantId, string webhookId, RequestOptions requestOptions = default)
        {
            var endpoint = $"/merchants/{merchantId}/webhooks/{webhookId}";
            string jsonRequest = null;
            var resource = new ManagementResource(this, endpoint);
            await resource.RequestAsync(jsonRequest, null, new HttpMethod("DELETE"));
        }

        /// <summary>
        /// List all webhooks Lists all webhook configurations for the merchant account.  To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Webhooks read * Management API—Webhooks read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="pageNumber">The number of the page to fetch. (optional)</param>
        /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 10 items on a page. (optional)</param>
        /// <returns>ListWebhooksResponse</returns>
        /// <param name="requestOptions">Additional request options</param>
        public ListWebhooksResponse GetMerchantsMerchantIdWebhooks(string merchantId, RequestOptions requestOptions = default)
        {
            return GetMerchantsMerchantIdWebhooksAsync(merchantId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List all webhooks Lists all webhook configurations for the merchant account.  To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Webhooks read * Management API—Webhooks read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="pageNumber">The number of the page to fetch. (optional)</param>
        /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 10 items on a page. (optional)</param>
        /// <returns>Task of ListWebhooksResponse</returns>
        /// <param name="requestOptions">Additional request options</param>
        public async Task<ListWebhooksResponse> GetMerchantsMerchantIdWebhooksAsync(string merchantId, RequestOptions requestOptions = default)
        {
            var endpoint = $"/merchants/{merchantId}/webhooks" + ToQueryString(requestOptions?.QueryParameters);
            string jsonRequest = null;
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<ListWebhooksResponse>(jsonResult);
        }

        /// <summary>
        /// Get a webhook Returns the configuration for the webhook identified in the path.  To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Webhooks read * Management API—Webhooks read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="webhookId">Unique identifier of the webhook configuration.</param>
        /// <returns>Webhook</returns>
        /// <param name="requestOptions">Additional request options</param>
        public Webhook GetMerchantsMerchantIdWebhooksWebhookId(string merchantId, string webhookId, RequestOptions requestOptions = default)
        {
            return GetMerchantsMerchantIdWebhooksWebhookIdAsync(merchantId, webhookId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a webhook Returns the configuration for the webhook identified in the path.  To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Webhooks read * Management API—Webhooks read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="webhookId">Unique identifier of the webhook configuration.</param>
        /// <returns>Task of Webhook</returns>
        /// <param name="requestOptions">Additional request options</param>
        public async Task<Webhook> GetMerchantsMerchantIdWebhooksWebhookIdAsync(string merchantId, string webhookId, RequestOptions requestOptions = default)
        {
            var endpoint = $"/merchants/{merchantId}/webhooks/{webhookId}";
            string jsonRequest = null;
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<Webhook>(jsonResult);
        }

        /// <summary>
        /// Update a webhook Make changes to the configuration of the webhook identified in the path. The request contains the new values you want to have in the webhook configuration. The response contains the full configuration for the webhook, which includes the new values from the request.  To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Webhooks read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="webhookId">Unique identifier of the webhook configuration.</param>
        /// <param name="updateMerchantWebhookRequest"> (optional)</param>
        /// <returns>Webhook</returns>
        /// <param name="requestOptions">Additional request options</param>
        public Webhook PatchMerchantsMerchantIdWebhooksWebhookId(string merchantId, string webhookId, UpdateMerchantWebhookRequest updateMerchantWebhookRequest, RequestOptions requestOptions = default)
        {
            return PatchMerchantsMerchantIdWebhooksWebhookIdAsync(merchantId, webhookId, updateMerchantWebhookRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update a webhook Make changes to the configuration of the webhook identified in the path. The request contains the new values you want to have in the webhook configuration. The response contains the full configuration for the webhook, which includes the new values from the request.  To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Webhooks read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="webhookId">Unique identifier of the webhook configuration.</param>
        /// <param name="updateMerchantWebhookRequest"> (optional)</param>
        /// <returns>Task of Webhook</returns>
        /// <param name="requestOptions">Additional request options</param>
        public async Task<Webhook> PatchMerchantsMerchantIdWebhooksWebhookIdAsync(string merchantId, string webhookId, UpdateMerchantWebhookRequest updateMerchantWebhookRequest, RequestOptions requestOptions = default)
        {
            var endpoint = $"/merchants/{merchantId}/webhooks/{webhookId}";
            string jsonRequest = updateMerchantWebhookRequest.ToJson();
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("PATCH"));
            return JsonConvert.DeserializeObject<Webhook>(jsonResult);
        }

        /// <summary>
        /// Set up a webhook Subscribe to receive webhook notifications about events related to your merchant account. You can add basic authentication to make sure the data is secure.  To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Webhooks read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="createMerchantWebhookRequest"> (optional)</param>
        /// <returns>Webhook</returns>
        /// <param name="requestOptions">Additional request options</param>
        public Webhook PostMerchantsMerchantIdWebhooks(string merchantId, CreateMerchantWebhookRequest createMerchantWebhookRequest, RequestOptions requestOptions = default)
        {
            return PostMerchantsMerchantIdWebhooksAsync(merchantId, createMerchantWebhookRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Set up a webhook Subscribe to receive webhook notifications about events related to your merchant account. You can add basic authentication to make sure the data is secure.  To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Webhooks read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="createMerchantWebhookRequest"> (optional)</param>
        /// <returns>Task of Webhook</returns>
        /// <param name="requestOptions">Additional request options</param>
        public async Task<Webhook> PostMerchantsMerchantIdWebhooksAsync(string merchantId, CreateMerchantWebhookRequest createMerchantWebhookRequest, RequestOptions requestOptions = default)
        {
            var endpoint = $"/merchants/{merchantId}/webhooks";
            string jsonRequest = createMerchantWebhookRequest.ToJson();
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("POST"));
            return JsonConvert.DeserializeObject<Webhook>(jsonResult);
        }

        /// <summary>
        /// Generate an HMAC key Returns an [HMAC key](https://en.wikipedia.org/wiki/HMAC) for the webhook identified in the path. This key allows you to check the integrity and the origin of the notifications you receive.By creating an HMAC key, you start receiving [HMAC-signed notifications](https://docs.adyen.com/development-resources/webhooks/verify-hmac-signatures#enable-hmac-signatures) from Adyen. Find out more about how to [verify HMAC signatures](https://docs.adyen.com/development-resources/webhooks/verify-hmac-signatures).  To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Webhooks read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="webhookId"></param>
        /// <returns>GenerateHmacKeyResponse</returns>
        /// <param name="requestOptions">Additional request options</param>
        public GenerateHmacKeyResponse PostMerchantsMerchantIdWebhooksWebhookIdGenerateHmac(string merchantId, string webhookId, RequestOptions requestOptions = default)
        {
            return PostMerchantsMerchantIdWebhooksWebhookIdGenerateHmacAsync(merchantId, webhookId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Generate an HMAC key Returns an [HMAC key](https://en.wikipedia.org/wiki/HMAC) for the webhook identified in the path. This key allows you to check the integrity and the origin of the notifications you receive.By creating an HMAC key, you start receiving [HMAC-signed notifications](https://docs.adyen.com/development-resources/webhooks/verify-hmac-signatures#enable-hmac-signatures) from Adyen. Find out more about how to [verify HMAC signatures](https://docs.adyen.com/development-resources/webhooks/verify-hmac-signatures).  To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Webhooks read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="webhookId"></param>
        /// <returns>Task of GenerateHmacKeyResponse</returns>
        /// <param name="requestOptions">Additional request options</param>
        public async Task<GenerateHmacKeyResponse> PostMerchantsMerchantIdWebhooksWebhookIdGenerateHmacAsync(string merchantId, string webhookId, RequestOptions requestOptions = default)
        {
            var endpoint = $"/merchants/{merchantId}/webhooks/{webhookId}/generateHmac";
            string jsonRequest = null;
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("POST"));
            return JsonConvert.DeserializeObject<GenerateHmacKeyResponse>(jsonResult);
        }

        /// <summary>
        /// Test a webhook Sends sample notifications to test if the webhook is set up correctly.  We send four test notifications for each event code you choose. They cover success and failure scenarios for the hard-coded currencies EUR and GBP, regardless of the currencies configured in the merchant accounts. For custom notifications, we only send the specified custom notification.  The response describes the result of the test. The `status` field tells you if the test was successful or not. You can use the other fields to troubleshoot unsuccessful tests.  To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Webhooks read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="webhookId">Unique identifier of the webhook configuration.</param>
        /// <param name="testWebhookRequest"> (optional)</param>
        /// <returns>TestWebhookResponse</returns>
        /// <param name="requestOptions">Additional request options</param>
        public TestWebhookResponse PostMerchantsMerchantIdWebhooksWebhookIdTest(string merchantId, string webhookId, TestWebhookRequest testWebhookRequest, RequestOptions requestOptions = default)
        {
            return PostMerchantsMerchantIdWebhooksWebhookIdTestAsync(merchantId, webhookId, testWebhookRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Test a webhook Sends sample notifications to test if the webhook is set up correctly.  We send four test notifications for each event code you choose. They cover success and failure scenarios for the hard-coded currencies EUR and GBP, regardless of the currencies configured in the merchant accounts. For custom notifications, we only send the specified custom notification.  The response describes the result of the test. The `status` field tells you if the test was successful or not. You can use the other fields to troubleshoot unsuccessful tests.  To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Webhooks read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="webhookId">Unique identifier of the webhook configuration.</param>
        /// <param name="testWebhookRequest"> (optional)</param>
        /// <returns>Task of TestWebhookResponse</returns>
        /// <param name="requestOptions">Additional request options</param>
        public async Task<TestWebhookResponse> PostMerchantsMerchantIdWebhooksWebhookIdTestAsync(string merchantId, string webhookId, TestWebhookRequest testWebhookRequest, RequestOptions requestOptions = default)
        {
            var endpoint = $"/merchants/{merchantId}/webhooks/{webhookId}/test";
            string jsonRequest = testWebhookRequest.ToJson();
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("POST"));
            return JsonConvert.DeserializeObject<TestWebhookResponse>(jsonResult);
        }

    }
}
