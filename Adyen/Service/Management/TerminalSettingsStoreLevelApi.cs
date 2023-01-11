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
    public class TerminalSettingsStoreLevelApi : AbstractService
    {
        public TerminalSettingsStoreLevelApi(Client client) : base(client) {}
    
        /// <summary>
        /// Get the terminal logo Returns the logo that is configured for a specific payment terminal model at the store identified in the path. You must specify the terminal model as a query parameter.  The logo is returned as a Base64-encoded string. You need to Base64-decode the string to get the actual image file.  This logo applies to all terminals of the specified model under the store, unless a different logo is configured for an individual terminal.  To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Terminal settings read * Management API—Terminal settings read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="reference">The reference that identifies the store.</param>
        /// <param name="model">The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T. (optional)</param>
        /// <returns>Logo</returns>
        /// <param name="requestOptions">Additional request options</param>
        public Logo GetMerchantsMerchantIdStoresReferenceTerminalLogos(string merchantId, string reference, RequestOptions requestOptions = default)
        {
            return GetMerchantsMerchantIdStoresReferenceTerminalLogosAsync(merchantId, reference, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the terminal logo Returns the logo that is configured for a specific payment terminal model at the store identified in the path. You must specify the terminal model as a query parameter.  The logo is returned as a Base64-encoded string. You need to Base64-decode the string to get the actual image file.  This logo applies to all terminals of the specified model under the store, unless a different logo is configured for an individual terminal.  To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Terminal settings read * Management API—Terminal settings read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="reference">The reference that identifies the store.</param>
        /// <param name="model">The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T. (optional)</param>
        /// <returns>Task of Logo</returns>
        /// <param name="requestOptions">Additional request options</param>
        public async Task<Logo> GetMerchantsMerchantIdStoresReferenceTerminalLogosAsync(string merchantId, string reference, RequestOptions requestOptions = default)
        {
            var endpoint = $"/merchants/{merchantId}/stores/{reference}/terminalLogos" + ToQueryString(requestOptions?.QueryParameters);
            string jsonRequest = null;
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<Logo>(jsonResult);
        }

        /// <summary>
        /// Get terminal settings Returns the payment terminal settings that are configured for the store identified in the path. These settings apply to all terminals under the store unless different values are configured for an individual terminal.  To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Terminal settings read * Management API—Terminal settings read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="reference">The reference that identifies the store.</param>
        /// <returns>TerminalSettings</returns>
        /// <param name="requestOptions">Additional request options</param>
        public TerminalSettings GetMerchantsMerchantIdStoresReferenceTerminalSettings(string merchantId, string reference, RequestOptions requestOptions = default)
        {
            return GetMerchantsMerchantIdStoresReferenceTerminalSettingsAsync(merchantId, reference, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get terminal settings Returns the payment terminal settings that are configured for the store identified in the path. These settings apply to all terminals under the store unless different values are configured for an individual terminal.  To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Terminal settings read * Management API—Terminal settings read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="reference">The reference that identifies the store.</param>
        /// <returns>Task of TerminalSettings</returns>
        /// <param name="requestOptions">Additional request options</param>
        public async Task<TerminalSettings> GetMerchantsMerchantIdStoresReferenceTerminalSettingsAsync(string merchantId, string reference, RequestOptions requestOptions = default)
        {
            var endpoint = $"/merchants/{merchantId}/stores/{reference}/terminalSettings";
            string jsonRequest = null;
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<TerminalSettings>(jsonResult);
        }

        /// <summary>
        /// Get the terminal logo Returns the logo that is configured for a specific payment terminal model at the store identified in the path. The terminal model must be specified as a query parameter.   The logo is returned as a Base64-encoded string. You need to Base64-decode the string to get the actual image file.  This logo applies to all terminals of that model under the store unless a different logo is configured for an individual terminal.  To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Terminal settings read * Management API—Terminal settings read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">The unique identifier of the store.</param>
        /// <param name="model">The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T. (optional)</param>
        /// <returns>Logo</returns>
        /// <param name="requestOptions">Additional request options</param>
        public Logo GetStoresStoreIdTerminalLogos(string storeId, RequestOptions requestOptions = default)
        {
            return GetStoresStoreIdTerminalLogosAsync(storeId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the terminal logo Returns the logo that is configured for a specific payment terminal model at the store identified in the path. The terminal model must be specified as a query parameter.   The logo is returned as a Base64-encoded string. You need to Base64-decode the string to get the actual image file.  This logo applies to all terminals of that model under the store unless a different logo is configured for an individual terminal.  To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Terminal settings read * Management API—Terminal settings read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">The unique identifier of the store.</param>
        /// <param name="model">The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T. (optional)</param>
        /// <returns>Task of Logo</returns>
        /// <param name="requestOptions">Additional request options</param>
        public async Task<Logo> GetStoresStoreIdTerminalLogosAsync(string storeId, RequestOptions requestOptions = default)
        {
            var endpoint = $"/stores/{storeId}/terminalLogos" + ToQueryString(requestOptions?.QueryParameters);
            string jsonRequest = null;
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<Logo>(jsonResult);
        }

        /// <summary>
        /// Get terminal settings Returns the payment terminal settings that are configured for the store identified in the path. These settings apply to all terminals under the store unless different values are configured for an individual terminal.  To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Terminal settings read * Management API—Terminal settings read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">The unique identifier of the store.</param>
        /// <returns>TerminalSettings</returns>
        /// <param name="requestOptions">Additional request options</param>
        public TerminalSettings GetStoresStoreIdTerminalSettings(string storeId, RequestOptions requestOptions = default)
        {
            return GetStoresStoreIdTerminalSettingsAsync(storeId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get terminal settings Returns the payment terminal settings that are configured for the store identified in the path. These settings apply to all terminals under the store unless different values are configured for an individual terminal.  To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Terminal settings read * Management API—Terminal settings read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">The unique identifier of the store.</param>
        /// <returns>Task of TerminalSettings</returns>
        /// <param name="requestOptions">Additional request options</param>
        public async Task<TerminalSettings> GetStoresStoreIdTerminalSettingsAsync(string storeId, RequestOptions requestOptions = default)
        {
            var endpoint = $"/stores/{storeId}/terminalSettings";
            string jsonRequest = null;
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<TerminalSettings>(jsonResult);
        }

        /// <summary>
        /// Update the terminal logo Updates the logo that is configured for a specific payment terminal model at the store identified in the path. You must specify the terminal model as a query parameter. You can update the logo for only one terminal model at a time. This logo applies to all terminals of the specified model under the store, unless a different logo is configured for an individual terminal.   * To change the logo, specify the image file as a Base64-encoded string. * To restore the logo inherited from a higher level (merchant or company account), specify an empty logo value.  To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Terminal settings read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="reference">The reference that identifies the store.</param>
        /// <param name="model">The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T (optional)</param>
        /// <param name="logo"> (optional)</param>
        /// <returns>Logo</returns>
        /// <param name="requestOptions">Additional request options</param>
        public Logo PatchMerchantsMerchantIdStoresReferenceTerminalLogos(string merchantId, string reference, Logo logo, RequestOptions requestOptions = default)
        {
            return PatchMerchantsMerchantIdStoresReferenceTerminalLogosAsync(merchantId, reference, logo, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update the terminal logo Updates the logo that is configured for a specific payment terminal model at the store identified in the path. You must specify the terminal model as a query parameter. You can update the logo for only one terminal model at a time. This logo applies to all terminals of the specified model under the store, unless a different logo is configured for an individual terminal.   * To change the logo, specify the image file as a Base64-encoded string. * To restore the logo inherited from a higher level (merchant or company account), specify an empty logo value.  To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Terminal settings read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="reference">The reference that identifies the store.</param>
        /// <param name="model">The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T (optional)</param>
        /// <param name="logo"> (optional)</param>
        /// <returns>Task of Logo</returns>
        /// <param name="requestOptions">Additional request options</param>
        public async Task<Logo> PatchMerchantsMerchantIdStoresReferenceTerminalLogosAsync(string merchantId, string reference, Logo logo, RequestOptions requestOptions = default)
        {
            var endpoint = $"/merchants/{merchantId}/stores/{reference}/terminalLogos" + ToQueryString(requestOptions?.QueryParameters);
            string jsonRequest = logo.ToJson();
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("PATCH"));
            return JsonConvert.DeserializeObject<Logo>(jsonResult);
        }

        /// <summary>
        /// Update terminal settings Updates payment terminal settings for the store identified in the path. These settings apply to all terminals under the store, unless different values are configured for an individual terminal.  * To change a parameter value, include the full object that contains the parameter, even if you don't want to change all parameters in the object. * To restore a parameter value inherited from a higher level, include the full object that contains the parameter, and specify an empty value for the parameter or omit the parameter. * Objects that are not included in the request are not updated.  To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Terminal settings read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="reference">The reference that identifies the store.</param>
        /// <param name="terminalSettings"> (optional)</param>
        /// <returns>TerminalSettings</returns>
        /// <param name="requestOptions">Additional request options</param>
        public TerminalSettings PatchMerchantsMerchantIdStoresReferenceTerminalSettings(string merchantId, string reference, TerminalSettings terminalSettings, RequestOptions requestOptions = default)
        {
            return PatchMerchantsMerchantIdStoresReferenceTerminalSettingsAsync(merchantId, reference, terminalSettings, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update terminal settings Updates payment terminal settings for the store identified in the path. These settings apply to all terminals under the store, unless different values are configured for an individual terminal.  * To change a parameter value, include the full object that contains the parameter, even if you don't want to change all parameters in the object. * To restore a parameter value inherited from a higher level, include the full object that contains the parameter, and specify an empty value for the parameter or omit the parameter. * Objects that are not included in the request are not updated.  To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Terminal settings read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="reference">The reference that identifies the store.</param>
        /// <param name="terminalSettings"> (optional)</param>
        /// <returns>Task of TerminalSettings</returns>
        /// <param name="requestOptions">Additional request options</param>
        public async Task<TerminalSettings> PatchMerchantsMerchantIdStoresReferenceTerminalSettingsAsync(string merchantId, string reference, TerminalSettings terminalSettings, RequestOptions requestOptions = default)
        {
            var endpoint = $"/merchants/{merchantId}/stores/{reference}/terminalSettings";
            string jsonRequest = terminalSettings.ToJson();
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("PATCH"));
            return JsonConvert.DeserializeObject<TerminalSettings>(jsonResult);
        }

        /// <summary>
        /// Update the terminal logo Updates the logo that is configured for a specific payment terminal model at the store identified in the path. You must specify the terminal model as a query parameter. You can update the logo for only one terminal model at a time. This logo applies to all terminals of the specified model under the store, unless a different logo is configured for an individual terminal.   * To change the logo, specify the image file as a Base64-encoded string. * To restore the logo inherited from a higher level (merchant or company account), specify an empty logo value.  To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Terminal settings read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">The unique identifier of the store.</param>
        /// <param name="model">The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T. (optional)</param>
        /// <param name="logo"> (optional)</param>
        /// <returns>Logo</returns>
        /// <param name="requestOptions">Additional request options</param>
        public Logo PatchStoresStoreIdTerminalLogos(string storeId, Logo logo, RequestOptions requestOptions = default)
        {
            return PatchStoresStoreIdTerminalLogosAsync(storeId, logo, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update the terminal logo Updates the logo that is configured for a specific payment terminal model at the store identified in the path. You must specify the terminal model as a query parameter. You can update the logo for only one terminal model at a time. This logo applies to all terminals of the specified model under the store, unless a different logo is configured for an individual terminal.   * To change the logo, specify the image file as a Base64-encoded string. * To restore the logo inherited from a higher level (merchant or company account), specify an empty logo value.  To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Terminal settings read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">The unique identifier of the store.</param>
        /// <param name="model">The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T. (optional)</param>
        /// <param name="logo"> (optional)</param>
        /// <returns>Task of Logo</returns>
        /// <param name="requestOptions">Additional request options</param>
        public async Task<Logo> PatchStoresStoreIdTerminalLogosAsync(string storeId, Logo logo, RequestOptions requestOptions = default)
        {
            var endpoint = $"/stores/{storeId}/terminalLogos" + ToQueryString(requestOptions?.QueryParameters);
            string jsonRequest = logo.ToJson();
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("PATCH"));
            return JsonConvert.DeserializeObject<Logo>(jsonResult);
        }

        /// <summary>
        /// Update terminal settings Updates payment terminal settings for the store identified in the path. These settings apply to all terminals under the store, unless different values are configured for an individual terminal.  * To change a parameter value, include the full object that contains the parameter, even if you don't want to change all parameters in the object. * To restore a parameter value inherited from a higher level, include the full object that contains the parameter, and specify an empty value for the parameter or omit the parameter. * Objects that are not included in the request are not updated.  To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Terminal settings read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">The unique identifier of the store.</param>
        /// <param name="terminalSettings"> (optional)</param>
        /// <returns>TerminalSettings</returns>
        /// <param name="requestOptions">Additional request options</param>
        public TerminalSettings PatchStoresStoreIdTerminalSettings(string storeId, TerminalSettings terminalSettings, RequestOptions requestOptions = default)
        {
            return PatchStoresStoreIdTerminalSettingsAsync(storeId, terminalSettings, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update terminal settings Updates payment terminal settings for the store identified in the path. These settings apply to all terminals under the store, unless different values are configured for an individual terminal.  * To change a parameter value, include the full object that contains the parameter, even if you don't want to change all parameters in the object. * To restore a parameter value inherited from a higher level, include the full object that contains the parameter, and specify an empty value for the parameter or omit the parameter. * Objects that are not included in the request are not updated.  To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions): * Management API—Terminal settings read and write
        /// </summary>
        /// <exception cref="Adyen.Service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">The unique identifier of the store.</param>
        /// <param name="terminalSettings"> (optional)</param>
        /// <returns>Task of TerminalSettings</returns>
        /// <param name="requestOptions">Additional request options</param>
        public async Task<TerminalSettings> PatchStoresStoreIdTerminalSettingsAsync(string storeId, TerminalSettings terminalSettings, RequestOptions requestOptions = default)
        {
            var endpoint = $"/stores/{storeId}/terminalSettings";
            string jsonRequest = terminalSettings.ToJson();
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("PATCH"));
            return JsonConvert.DeserializeObject<TerminalSettings>(jsonResult);
        }

    }
}
