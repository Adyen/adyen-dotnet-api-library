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
    public class TerminalSettingsCompanyLevelApi : AbstractService
    {
        public TerminalSettingsCompanyLevelApi(Client client) : base(client) {}
    
        /// <summary>
        /// Get the terminal logo
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="requestOptions">Additional request options. Query parameters:
        /// <list type="table">
        ///     <listheader>
        ///         <term>parameter</term>
        ///         <description>description</description>
        ///     </listheader>
        ///     <item>
        ///         <term>model</term>
        ///         <description>The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T.</description>
        ///     </item>
        /// </list></param>
        /// <returns>Logo</returns>
        public Logo GetCompaniesCompanyIdTerminalLogos(string companyId, RequestOptions requestOptions = null)
        {
            return GetCompaniesCompanyIdTerminalLogosAsync(companyId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the terminal logo
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="requestOptions">Additional request options. Query parameters:
        /// <list type="table">
        ///     <listheader>
        ///         <term>parameter</term>
        ///         <description>description</description>
        ///     </listheader>
        ///     <item>
        ///         <term>model</term>
        ///         <description>The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T.</description>
        ///     </item>
        /// </list></param>
        /// <returns>Task of Logo</returns>
        public async Task<Logo> GetCompaniesCompanyIdTerminalLogosAsync(string companyId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/companies/{companyId}/terminalLogos" + ToQueryString(requestOptions?.QueryParameters);
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<Logo>(jsonResult);
        }

        /// <summary>
        /// Get terminal settings
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>TerminalSettings</returns>
        public TerminalSettings GetCompaniesCompanyIdTerminalSettings(string companyId, RequestOptions requestOptions = null)
        {
            return GetCompaniesCompanyIdTerminalSettingsAsync(companyId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get terminal settings
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of TerminalSettings</returns>
        public async Task<TerminalSettings> GetCompaniesCompanyIdTerminalSettingsAsync(string companyId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/companies/{companyId}/terminalSettings";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<TerminalSettings>(jsonResult);
        }

        /// <summary>
        /// Update the terminal logo
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="logo"></param>
        /// <param name="requestOptions">Additional request options. Query parameters:
        /// <list type="table">
        ///     <listheader>
        ///         <term>parameter</term>
        ///         <description>description</description>
        ///     </listheader>
        ///     <item>
        ///         <term>model</term>
        ///         <description>The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T.</description>
        ///     </item>
        /// </list></param>
        /// <returns>Logo</returns>
        public Logo PatchCompaniesCompanyIdTerminalLogos(string companyId, Logo logo, RequestOptions requestOptions = null)
        {
            return PatchCompaniesCompanyIdTerminalLogosAsync(companyId, logo, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update the terminal logo
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="logo"></param>
        /// <param name="requestOptions">Additional request options. Query parameters:
        /// <list type="table">
        ///     <listheader>
        ///         <term>parameter</term>
        ///         <description>description</description>
        ///     </listheader>
        ///     <item>
        ///         <term>model</term>
        ///         <description>The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T.</description>
        ///     </item>
        /// </list></param>
        /// <returns>Task of Logo</returns>
        public async Task<Logo> PatchCompaniesCompanyIdTerminalLogosAsync(string companyId, Logo logo, RequestOptions requestOptions = null)
        {
            var endpoint = $"/companies/{companyId}/terminalLogos" + ToQueryString(requestOptions?.QueryParameters);
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(logo.ToJson(), null, new HttpMethod("PATCH"));
            return JsonConvert.DeserializeObject<Logo>(jsonResult);
        }

        /// <summary>
        /// Update terminal settings
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="terminalSettings"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>TerminalSettings</returns>
        public TerminalSettings PatchCompaniesCompanyIdTerminalSettings(string companyId, TerminalSettings terminalSettings, RequestOptions requestOptions = null)
        {
            return PatchCompaniesCompanyIdTerminalSettingsAsync(companyId, terminalSettings, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update terminal settings
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="terminalSettings"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of TerminalSettings</returns>
        public async Task<TerminalSettings> PatchCompaniesCompanyIdTerminalSettingsAsync(string companyId, TerminalSettings terminalSettings, RequestOptions requestOptions = null)
        {
            var endpoint = $"/companies/{companyId}/terminalSettings";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(terminalSettings.ToJson(), null, new HttpMethod("PATCH"));
            return JsonConvert.DeserializeObject<TerminalSettings>(jsonResult);
        }

    }
}
