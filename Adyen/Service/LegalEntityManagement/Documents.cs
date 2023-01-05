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
        private readonly HttpMethod _patchMethod = new HttpMethod("PATCH");
        
        public Documents(Client client) : base(client) {}

        public async Task<Document> CreateAsync(Document request)
        {
            var jsonRequest = request.ToJson();
            var resource = new LegalEntityManagementResource(this, "/documents");
            var jsonResult = await resource.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<Document>(jsonResult);
        }

        public async Task<Document> RetrieveAsync(string documentId)
        {
            var resource = new LegalEntityManagementResource(this, "/documents/" + documentId);
            var jsonResult = await resource.RequestAsync(null, null, HttpMethod.Get);
            return JsonConvert.DeserializeObject<Document>(jsonResult);
        }
        
        public async Task<Document> UpdateAsync(string documentId, Document request)
        {
            var jsonRequest = request.ToJson();
            var resource = new LegalEntityManagementResource(this, "/documents/" + documentId);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, _patchMethod);
            return JsonConvert.DeserializeObject<Document>(jsonResult);
        }
        
        public async void DeleteAsync(string documentId)
        {
            var resource = new LegalEntityManagementResource(this, "/documents/" + documentId);
            await resource.RequestAsync(null, null, HttpMethod.Delete);
        }
        
        // Synchronous methods:
        
        public Document Create(Document request)
        {
            return CreateAsync(request).GetAwaiter().GetResult();
        }
        
        public Document Retrieve(string documentId)
        {
            return RetrieveAsync(documentId).GetAwaiter().GetResult();
        }
        
        public Document Update(string documentId, Document request)
        {
            return UpdateAsync(documentId, request).GetAwaiter().GetResult();
        }
        
        public void Delete(string documentId)
        {
            DeleteAsync(documentId);
        }
        
        
        
        
        
    }
}