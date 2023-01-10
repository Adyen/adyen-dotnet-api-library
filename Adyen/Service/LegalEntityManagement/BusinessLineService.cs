#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System.Net.Http;
using System.Threading.Tasks;
using Adyen.Model.LegalEntityManagement;
using Adyen.Service.Resource;
using Newtonsoft.Json;

namespace Adyen.Service.LegalEntityManagement
{
    public class BusinessLineService : AbstractService
    {
        private readonly HttpMethod _patchMethod = new HttpMethod("PATCH");

        public BusinessLineService(Client client) : base(client)
        {
        }

        public async Task<BusinessLine> CreateAsync(BusinessLineInfo request)
        {
            string jsonRequest = request.ToJson();
            LegalEntityManagementResource resource = new LegalEntityManagementResource(this, "/businessLines");
            string jsonResult = await resource.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<BusinessLine>(jsonResult);
        }
        
        public async Task<BusinessLine> RetrieveAsync(string businessLineId)
        {
            LegalEntityManagementResource resource = new LegalEntityManagementResource(this, "/businessLines/" + businessLineId);
            string jsonResult = await resource.RequestAsync(null, null, HttpMethod.Get);
            return JsonConvert.DeserializeObject<BusinessLine>(jsonResult);
        }
        
        public async Task<BusinessLine> UpdateAsync(string businessLineId, BusinessLineInfo request)
        {
            string jsonRequest = request.ToJson();
            LegalEntityManagementResource resource = new LegalEntityManagementResource(this, "/businessLines/" + businessLineId);
            string jsonResult = await resource.RequestAsync(jsonRequest, null, _patchMethod);
            return JsonConvert.DeserializeObject<BusinessLine>(jsonResult);
        }
        
        // Synchronous methods:

        public BusinessLine Create(BusinessLineInfo request)
        {
            return CreateAsync(request).GetAwaiter().GetResult();
        }
        
        public BusinessLine Retrieve(string businessLineId)
        {
            return RetrieveAsync(businessLineId).GetAwaiter().GetResult();
        }
        
        public BusinessLine Update(string businessLineId, BusinessLineInfo request)
        {
            return UpdateAsync(businessLineId, request).GetAwaiter().GetResult();
        }
    }
}