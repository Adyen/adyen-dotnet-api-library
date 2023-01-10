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
    public class LegalEntities : AbstractService
    {
        private readonly HttpMethod _patchMethod = new HttpMethod("PATCH");

        public LegalEntities(Client client) : base(client)
        {
        }

        public async Task<LegalEntity> CreateAsync(LegalEntityInfo request)
        {
            string jsonRequest = request.ToJson();
            LegalEntityManagementResource resource = new LegalEntityManagementResource(this, "/legalEntities");
            string jsonResult = await resource.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<LegalEntity>(jsonResult);
        }
        
        public async Task<LegalEntity> RetrieveAsync(string legalEntityId)
        {
            LegalEntityManagementResource resource = new LegalEntityManagementResource(this, "/legalEntities/" + legalEntityId);
            string jsonResult = await resource.RequestAsync(null, null, HttpMethod.Get);
            return JsonConvert.DeserializeObject<LegalEntity>(jsonResult);
        }
        
        public async Task<LegalEntity> UpdateAsync(string legalEntityId, LegalEntityInfo request)
        {
            string jsonRequest = request.ToJson();
            LegalEntityManagementResource resource = new LegalEntityManagementResource(this, "/legalEntities/" + legalEntityId);
            string jsonResult = await resource.RequestAsync(jsonRequest, null, _patchMethod);
            return JsonConvert.DeserializeObject<LegalEntity>(jsonResult);
        }
        
        public async Task<BusinessLines> ListBusinessLinesAsync(string legalEntityId)
        {
            LegalEntityManagementResource resource = new LegalEntityManagementResource(this, "/legalEntities/" + legalEntityId);
            string jsonResult = await resource.RequestAsync(null, null, HttpMethod.Get);
            return JsonConvert.DeserializeObject<BusinessLines>(jsonResult);
        }
        
        // Asynchronous methods:
        public LegalEntity Create(LegalEntityInfo request)
        {
            return CreateAsync(request).GetAwaiter().GetResult();
        }

        public LegalEntity Retrieve(string legalEntityId)
        {
            return RetrieveAsync(legalEntityId).GetAwaiter().GetResult();
        }

        public LegalEntity Update(string legalEntityId, LegalEntityInfo request)
        {
            return UpdateAsync(legalEntityId, request).GetAwaiter().GetResult();
        }

        public BusinessLines ListBusinessLines(string legalEntityId)
        {
            return ListBusinessLinesAsync(legalEntityId).GetAwaiter().GetResult();
        }
        
    }
}