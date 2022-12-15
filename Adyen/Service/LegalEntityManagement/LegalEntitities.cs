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
        private HttpMethod patchMethod = new HttpMethod("PATCH");

        public LegalEntities(Client client) : base(client)
        {
        }

        public async Task<LegalEntity> createAsync(LegalEntityInfo request)
        {
            var jsonRequest = request.ToJson();
            var resource = new LegalEntityManagementResource(this, "/legalEntities");
            var jsonResult = await resource.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<LegalEntity>(jsonResult);
        }
        
        public async Task<LegalEntity> retrieveAsync(string legalEntityId)
        {
            var resource = new LegalEntityManagementResource(this, "/legalEntities/" + legalEntityId);
            var jsonResult = await resource.RequestAsync(null, null, HttpMethod.Get);
            return JsonConvert.DeserializeObject<LegalEntity>(jsonResult);
        }
        
        public async Task<LegalEntity> updateAsync(string legalEntityId, LegalEntityInfo request)
        {
            var jsonRequest = request.ToJson();
            var resource = new LegalEntityManagementResource(this, "/legalEntities/" + legalEntityId);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, patchMethod);
            return JsonConvert.DeserializeObject<LegalEntity>(jsonResult);
        }
        
        public async Task<BusinessLines> listBusinessLinesAsync(string legalEntityId)
        {
            var resource = new LegalEntityManagementResource(this, "/legalEntities/" + legalEntityId);
            var jsonResult = await resource.RequestAsync(null, null, HttpMethod.Get);
            return JsonConvert.DeserializeObject<BusinessLines>(jsonResult);
        }
        
        // Asynchronous methods:
        public LegalEntity create(LegalEntityInfo request)
        {
            return createAsync(request).GetAwaiter().GetResult();
        }

        public LegalEntity retrieve(string legalEntityId)
        {
            return retrieveAsync(legalEntityId).GetAwaiter().GetResult();
        }

        public LegalEntity update(string legalEntityId, LegalEntityInfo request)
        {
            return updateAsync(legalEntityId, request).GetAwaiter().GetResult();
        }

        public BusinessLines listBusinessLines(string legalEntityId)
        {
            return listBusinessLinesAsync(legalEntityId).GetAwaiter().GetResult();
        }
        
    }
}