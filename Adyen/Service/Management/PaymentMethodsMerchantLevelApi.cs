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
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Adyen.Service.Resource;
using Adyen.Model.Management;

namespace Adyen.Service.Management
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PaymentMethodsMerchantLevelApi : AbstractService
    {
        public PaymentMethodsMerchantLevelApi(Client client) : base(client) {}
    
        /// <summary>
        /// Get all payment methods Returns details for all payment methods of the merchant account identified in the path.  To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Payment methods read 
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="storeId">The unique identifier of the store for which to return the payment methods. (optional)</param>
        /// <param name="businessLineId">The unique identifier of the Business Line for which to return the payment methods. (optional)</param>
        /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 10 items on a page. (optional)</param>
        /// <param name="pageNumber">The number of the page to fetch. (optional)</param>
        /// <returns>PaymentMethodResponse</returns>
        public PaymentMethodResponse GetMerchantsMerchantIdPaymentMethodSettings(string merchantId, string storeId = default(string), string businessLineId = default(string), int? pageSize = default(int?), int? pageNumber = default(int?))
        {
            return GetMerchantsMerchantIdPaymentMethodSettingsAsync(merchantId, storeId, businessLineId, pageSize, pageNumber).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get all payment methods Returns details for all payment methods of the merchant account identified in the path.  To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Payment methods read 
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="storeId">The unique identifier of the store for which to return the payment methods. (optional)</param>
        /// <param name="businessLineId">The unique identifier of the Business Line for which to return the payment methods. (optional)</param>
        /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 10 items on a page. (optional)</param>
        /// <param name="pageNumber">The number of the page to fetch. (optional)</param>
        /// <returns>Task of PaymentMethodResponse</returns>
        public async Task<PaymentMethodResponse> GetMerchantsMerchantIdPaymentMethodSettingsAsync(string merchantId, string storeId = default(string), string businessLineId = default(string), int? pageSize = default(int?), int? pageNumber = default(int?))
        {
            var httpMethod = new HttpMethod("GET");
            string jsonRequest = null;
            var resource = new ManagementResource(this, $"/merchants/{merchantId}/paymentMethodSettings");
            var jsonResult = await resource.RequestAsync(jsonRequest, null, httpMethod);
            return JsonConvert.DeserializeObject<PaymentMethodResponse>(jsonResult);
        }

        /// <summary>
        /// Get payment method details Returns details for the merchant account and the payment method identified in the path.  To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Payment methods read 
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="paymentMethodId">The unique identifier of the payment method.</param>
        /// <returns>PaymentMethod</returns>
        public PaymentMethod GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodId(string merchantId, string paymentMethodId)
        {
            return GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAsync(merchantId, paymentMethodId).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get payment method details Returns details for the merchant account and the payment method identified in the path.  To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Payment methods read 
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="paymentMethodId">The unique identifier of the payment method.</param>
        /// <returns>Task of PaymentMethod</returns>
        public async Task<PaymentMethod> GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAsync(string merchantId, string paymentMethodId)
        {
            var httpMethod = new HttpMethod("GET");
            string jsonRequest = null;
            var resource = new ManagementResource(this, $"/merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}");
            var jsonResult = await resource.RequestAsync(jsonRequest, null, httpMethod);
            return JsonConvert.DeserializeObject<PaymentMethod>(jsonResult);
        }

        /// <summary>
        /// Get Apple Pay domains Returns all Apple Pay domains that are registered with the merchant account and the payment method identified in the path. For more information, see [Apple Pay documentation](https://docs.adyen.com/payment-methods/apple-pay/enable-apple-pay#register-merchant-domain).  To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Payment methods read 
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="paymentMethodId">The unique identifier of the payment method.</param>
        /// <returns>ApplePayInfo</returns>
        public ApplePayInfo GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomains(string merchantId, string paymentMethodId)
        {
            return GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsAsync(merchantId, paymentMethodId).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get Apple Pay domains Returns all Apple Pay domains that are registered with the merchant account and the payment method identified in the path. For more information, see [Apple Pay documentation](https://docs.adyen.com/payment-methods/apple-pay/enable-apple-pay#register-merchant-domain).  To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Payment methods read 
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="paymentMethodId">The unique identifier of the payment method.</param>
        /// <returns>Task of ApplePayInfo</returns>
        public async Task<ApplePayInfo> GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsAsync(string merchantId, string paymentMethodId)
        {
            var httpMethod = new HttpMethod("GET");
            string jsonRequest = null;
            var resource = new ManagementResource(this, $"/merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}/getApplePayDomains");
            var jsonResult = await resource.RequestAsync(jsonRequest, null, httpMethod);
            return JsonConvert.DeserializeObject<ApplePayInfo>(jsonResult);
        }

        /// <summary>
        /// Update a payment method Updates payment method details for the merchant account and the payment method identified in the path.  To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Payment methods read and write 
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="paymentMethodId">The unique identifier of the payment method.</param>
        /// <param name="updatePaymentMethodInfo"> (optional)</param>
        /// <returns>PaymentMethod</returns>
        public PaymentMethod PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodId(string merchantId, string paymentMethodId, UpdatePaymentMethodInfo updatePaymentMethodInfo)
        {
            return PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAsync(merchantId, paymentMethodId, updatePaymentMethodInfo).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update a payment method Updates payment method details for the merchant account and the payment method identified in the path.  To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Payment methods read and write 
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="paymentMethodId">The unique identifier of the payment method.</param>
        /// <param name="updatePaymentMethodInfo"> (optional)</param>
        /// <returns>Task of PaymentMethod</returns>
        public async Task<PaymentMethod> PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAsync(string merchantId, string paymentMethodId, UpdatePaymentMethodInfo updatePaymentMethodInfo)
        {
            var httpMethod = new HttpMethod("PATCH");
            string jsonRequest = updatePaymentMethodInfo.ToJson();
            var resource = new ManagementResource(this, $"/merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}");
            var jsonResult = await resource.RequestAsync(jsonRequest, null, httpMethod);
            return JsonConvert.DeserializeObject<PaymentMethod>(jsonResult);
        }

        /// <summary>
        /// Request a payment method Sends a request to add a new payment method to the merchant account identified in the path.  To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Payment methods read and write 
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="paymentMethodSetupInfo"> (optional)</param>
        /// <returns>PaymentMethod</returns>
        public PaymentMethod PostMerchantsMerchantIdPaymentMethodSettings(string merchantId, PaymentMethodSetupInfo paymentMethodSetupInfo)
        {
            return PostMerchantsMerchantIdPaymentMethodSettingsAsync(merchantId, paymentMethodSetupInfo).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Request a payment method Sends a request to add a new payment method to the merchant account identified in the path.  To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Payment methods read and write 
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="paymentMethodSetupInfo"> (optional)</param>
        /// <returns>Task of PaymentMethod</returns>
        public async Task<PaymentMethod> PostMerchantsMerchantIdPaymentMethodSettingsAsync(string merchantId, PaymentMethodSetupInfo paymentMethodSetupInfo)
        {
            var httpMethod = new HttpMethod("POST");
            string jsonRequest = paymentMethodSetupInfo.ToJson();
            var resource = new ManagementResource(this, $"/merchants/{merchantId}/paymentMethodSettings");
            var jsonResult = await resource.RequestAsync(jsonRequest, null, httpMethod);
            return JsonConvert.DeserializeObject<PaymentMethod>(jsonResult);
        }

        /// <summary>
        /// Add an Apple Pay domain Adds the new domain to the list of Apple Pay domains that are registered with the merchant account and the payment method identified in the path. For more information, see [Apple Pay documentation](https://docs.adyen.com/payment-methods/apple-pay/enable-apple-pay#register-merchant-domain).  To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Payment methods read and write 
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="paymentMethodId">The unique identifier of the payment method.</param>
        /// <param name="applePayInfo"> (optional)</param>
        /// <returns>Object</returns>
        public Object PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomains(string merchantId, string paymentMethodId, ApplePayInfo applePayInfo)
        {
            return PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomainsAsync(merchantId, paymentMethodId, applePayInfo).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Add an Apple Pay domain Adds the new domain to the list of Apple Pay domains that are registered with the merchant account and the payment method identified in the path. For more information, see [Apple Pay documentation](https://docs.adyen.com/payment-methods/apple-pay/enable-apple-pay#register-merchant-domain).  To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Payment methods read and write 
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="paymentMethodId">The unique identifier of the payment method.</param>
        /// <param name="applePayInfo"> (optional)</param>
        /// <returns>Task of Object</returns>
        public async Task<Object> PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomainsAsync(string merchantId, string paymentMethodId, ApplePayInfo applePayInfo)
        {
            var httpMethod = new HttpMethod("POST");
            string jsonRequest = applePayInfo.ToJson();
            var resource = new ManagementResource(this, $"/merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}/addApplePayDomains");
            var jsonResult = await resource.RequestAsync(jsonRequest, null, httpMethod);
            return JsonConvert.DeserializeObject<Object>(jsonResult);
        }

    }
}
