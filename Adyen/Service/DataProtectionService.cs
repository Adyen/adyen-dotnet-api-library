/*
* Adyen Data Protection API
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
using System.Threading.Tasks;
using Adyen.Constants;
using Adyen.Model;
using Adyen.Service.Resource;
using Adyen.Model.DataProtection;
using Newtonsoft.Json;

namespace Adyen.Service
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DataProtectionService : AbstractService
    {
        private readonly string _baseUrl;
        
        public DataProtectionService(Client client) : base(client)
        {
            _baseUrl = client.Config.DataProtectionEndpoint + "/" + ClientConfig.DataProtectionVersion;
        }
    
        /// <summary>
        /// Submit a Subject Erasure Request.
        /// </summary>
        /// <param name="subjectErasureByPspReferenceRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>SubjectErasureResponse</returns>
        public SubjectErasureResponse RequestSubjectErasure(SubjectErasureByPspReferenceRequest subjectErasureByPspReferenceRequest, RequestOptions requestOptions = default)
        {
            return RequestSubjectErasureAsync(subjectErasureByPspReferenceRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Submit a Subject Erasure Request.
        /// </summary>
        /// <param name="subjectErasureByPspReferenceRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of SubjectErasureResponse</returns>
        public async Task<SubjectErasureResponse> RequestSubjectErasureAsync(SubjectErasureByPspReferenceRequest subjectErasureByPspReferenceRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + "/requestSubjectErasure";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<SubjectErasureResponse>(subjectErasureByPspReferenceRequest.ToJson(), requestOptions, new HttpMethod("POST"));
        }

    }
}
