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
    public class Documents : AbstractService
    {
        private HttpMethod patchMethod = new HttpMethod("PATCH");
        
        public Documents(Client client) : base(client) {}

        public async Task<Document> createAsync(Document request)
        {
            var jsonRequest = request.ToJson();
            var resource = new LegalEntityManagementResource(this, "/documents");
            var jsonResult = await resource.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<Document>(jsonResult);
        }

        public async Task<Document> retrieveAsync(string documentId)
        {
            var resource = new LegalEntityManagementResource(this, "/documents/" + documentId);
            var jsonResult = await resource.RequestAsync(null, null, HttpMethod.Get);
            return JsonConvert.DeserializeObject<Document>(jsonResult);
        }
        
        public async Task<Document> updateAsync(string documentId, Document request)
        {
            var jsonRequest = request.ToJson();
            var resource = new LegalEntityManagementResource(this, "/documents/" + documentId);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, patchMethod);
            return JsonConvert.DeserializeObject<Document>(jsonResult);
        }
        
        public async void deleteAsync(string documentId)
        {
            var resource = new LegalEntityManagementResource(this, "/documents/" + documentId);
            await resource.RequestAsync(null, null, HttpMethod.Delete);
        }
        
        // Synchronous methods:
        
        public Document create(Document request)
        {
            return createAsync(request).GetAwaiter().GetResult();
        }
        
        public Document retrieve(string documentId)
        {
            return retrieveAsync(documentId).GetAwaiter().GetResult();
        }
        
        public Document update(string documentId, Document request)
        {
            return updateAsync(documentId, request).GetAwaiter().GetResult();
        }
        
        public void delete(string documentId)
        {
            deleteAsync(documentId);
        }
        
        
        
        
        
    }
}