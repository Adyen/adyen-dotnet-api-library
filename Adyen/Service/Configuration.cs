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
 * Copyright (c) 2020 Adyen B.V.
 * This file is open source and available under the MIT license.
 * See the LICENSE file for more info.
 */
#endregion
using Adyen.Model;
using Adyen.Model.Configuration;
using Adyen.Service.Resource.Configuration;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace Adyen.Service
{
    public class Configuration : AbstractService
    {
        private Companies _companies;
        public Configuration(Client client) : base(client)
        {
            _companies = new Companies(this);
        }

        /// <summary>
        /// Get /companies/{companyId}/apiCredentials/{apiCredentialId}
        /// </summary>
        /// <returns>CompaniesApiCredentialResponse</returns>
        
        //TODO this is only returns the url for testing 
        public string RetrieveApiCredential(int companyId, int apiCredentialId)
        {
            var uri = string.Format("{0}/apiCredentials/{1}", companyId, apiCredentialId);
            var jsonResponse = _companies.Get(json: null, additionUri: uri);
            return jsonResponse;
            //return JsonConvert.DeserializeObject<CompaniesApiCredentialResponse>(jsonResponse);
        }

        /// <summary>
        /// Get async/companies/{companyId}/apiCredentials/{apiCredentialId}
        /// </summary>
        /// <returns>Task<CompaniesApiCredentialResponse></returns>
        public async Task<CompaniesApiCredentialResponse> RetrieveApiCredentialAsync(int companyId, int apiCredentialId)
        {
            var uri = string.Format("{0}/apiCredentials/{1}", companyId, apiCredentialId);
            var jsonResponse = await _companies.GetAsync(json: null, additionUri: uri);
            return JsonConvert.DeserializeObject<CompaniesApiCredentialResponse>(jsonResponse);
        }

        /// <summary>
        /// Patch /companies/{companyId}/apiCredentials/{apiCredentialId}
        /// </summary>
        /// <returns>CompaniesApiCredentialResponse</returns>
        public CompaniesApiCredentialResponse UpdateApiCredential(CompaniesApiCredentialRequest companiesApiCredentialRequest, int companyId, int apiCredentialId)
        {
            var uri = string.Format("{0}/apiCredentials/{1}", companyId, apiCredentialId);
            var jsonRequest = Util.JsonOperation.SerializeRequest(companiesApiCredentialRequest);
            var jsonResponse = _companies.Patch(json: jsonRequest, additionUri: uri);
            return JsonConvert.DeserializeObject<CompaniesApiCredentialResponse>(jsonResponse);
        }

        /// <summary>
        /// Patch /companies/{companyId}/apiCredentials/{apiCredentialId}
        /// </summary>
        /// <returns>Task<CompaniesApiCredentialResponse></returns>
        public async Task<CompaniesApiCredentialResponse> UpdateApiCredentialAsync(CompaniesApiCredentialRequest companiesApiCredentialRequest, int companyId, int apiCredentialId)
        {
            var uri = string.Format("{0}/apiCredentials/{1}", companyId, apiCredentialId);
            var jsonRequest = Util.JsonOperation.SerializeRequest(companiesApiCredentialRequest);
            var jsonResponse = await _companies.PatchAsync(json: jsonRequest, additionUri: uri);
            return JsonConvert.DeserializeObject<CompaniesApiCredentialResponse>(jsonResponse);
        }
    }
}

