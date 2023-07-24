/*
* Management API
*
*
* The version of the OpenAPI document: 1
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
using Adyen.Model;
using Adyen.Model.Management;

namespace Adyen.Service.Management
{
    /// <summary>
    /// TerminalSettingsMerchantLevelService Interface
    /// </summary>
    public interface ITerminalSettingsMerchantLevelService
    {
        /// <summary>
        /// Get the terminal logo
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="model"><see cref="string"/> - The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="Logo"/>.</returns>
        Model.Management.Logo GetTerminalLogo(string merchantId, string model, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get the terminal logo
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="model"><see cref="string"/> - The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="Logo"/>.</returns>
        Task<Model.Management.Logo> GetTerminalLogoAsync(string merchantId, string model, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get terminal settings
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="TerminalSettings"/>.</returns>
        Model.Management.TerminalSettings GetTerminalSettings(string merchantId, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get terminal settings
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="TerminalSettings"/>.</returns>
        Task<Model.Management.TerminalSettings> GetTerminalSettingsAsync(string merchantId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Update the terminal logo
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="logo"><see cref="Logo"/> - </param>
        /// <param name="model"><see cref="string"/> - The terminal model. Allowed values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="Logo"/>.</returns>
        Model.Management.Logo UpdateTerminalLogo(string merchantId, string model, Logo logo = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Update the terminal logo
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="logo"><see cref="Logo"/> - </param>
        /// <param name="model"><see cref="string"/> - The terminal model. Allowed values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="Logo"/>.</returns>
        Task<Model.Management.Logo> UpdateTerminalLogoAsync(string merchantId, string model, Logo logo = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Update terminal settings
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="terminalSettings"><see cref="TerminalSettings"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="TerminalSettings"/>.</returns>
        Model.Management.TerminalSettings UpdateTerminalSettings(string merchantId, TerminalSettings terminalSettings = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Update terminal settings
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="terminalSettings"><see cref="TerminalSettings"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="TerminalSettings"/>.</returns>
        Task<Model.Management.TerminalSettings> UpdateTerminalSettingsAsync(string merchantId, TerminalSettings terminalSettings = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the TerminalSettingsMerchantLevelService API endpoints
    /// </summary>
    public class TerminalSettingsMerchantLevelService : AbstractService, ITerminalSettingsMerchantLevelService
    {
        private readonly string _baseUrl;
        
        public TerminalSettingsMerchantLevelService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://management-test.adyen.com/v1");
        }
        
        public Model.Management.Logo GetTerminalLogo(string merchantId, string model, RequestOptions requestOptions = default)
        {
            return GetTerminalLogoAsync(merchantId, model, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Management.Logo> GetTerminalLogoAsync(string merchantId, string model, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            queryParams.Add("model", model);
            var endpoint = _baseUrl + $"/merchants/{merchantId}/terminalLogos" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Management.Logo>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Management.TerminalSettings GetTerminalSettings(string merchantId, RequestOptions requestOptions = default)
        {
            return GetTerminalSettingsAsync(merchantId, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Management.TerminalSettings> GetTerminalSettingsAsync(string merchantId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}/terminalSettings";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Management.TerminalSettings>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Management.Logo UpdateTerminalLogo(string merchantId, string model, Logo logo = default, RequestOptions requestOptions = default)
        {
            return UpdateTerminalLogoAsync(merchantId, model, logo, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Management.Logo> UpdateTerminalLogoAsync(string merchantId, string model, Logo logo = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            queryParams.Add("model", model);
            var endpoint = _baseUrl + $"/merchants/{merchantId}/terminalLogos" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Management.Logo>(logo.ToJson(), requestOptions, new HttpMethod("PATCH"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Management.TerminalSettings UpdateTerminalSettings(string merchantId, TerminalSettings terminalSettings = default, RequestOptions requestOptions = default)
        {
            return UpdateTerminalSettingsAsync(merchantId, terminalSettings, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Management.TerminalSettings> UpdateTerminalSettingsAsync(string merchantId, TerminalSettings terminalSettings = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}/terminalSettings";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Management.TerminalSettings>(terminalSettings.ToJson(), requestOptions, new HttpMethod("PATCH"), cancellationToken).ConfigureAwait(false);
        }
    }
}