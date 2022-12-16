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
using Adyen.Model.Checkout;
using Adyen.Model.LegalEntityManagement;
using Adyen.Service.Resource;
using Newtonsoft.Json;

namespace Adyen.Service.LegalEntityManagement
{
    public class TransferInstruments : AbstractService
    {
        private readonly HttpMethod _patchMethod = new HttpMethod("PATCH");

        public TransferInstruments(Client client) : base(client)
        {
        }

        public async Task<TransferInstrument> CreateAsync(TransferInstrumentInfo request)
        {
            var jsonRequest = request.ToJson();
            var resource = new LegalEntityManagementResource(this, "/transferInstruments");
            var jsonResult = await resource.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<TransferInstrument>(jsonResult);
        }
        
        public async Task<TransferInstrument> RetrieveAsync(string transferInstrumentId)
        {
            var resource = new LegalEntityManagementResource(this, "/transferInstruments/" + transferInstrumentId);
            var jsonResult = await resource.RequestAsync(null, null, HttpMethod.Get);
            return JsonConvert.DeserializeObject<TransferInstrument>(jsonResult);
        }
        
        public async Task<TransferInstrument> UpdateAsync(string transferInstrumentId, TransferInstrumentInfo request)
        {
            var jsonRequest = request.ToJson();
            var resource = new LegalEntityManagementResource(this, "/transferInstruments/" + transferInstrumentId);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, _patchMethod);
            return JsonConvert.DeserializeObject<TransferInstrument>(jsonResult);
        }

        public async void DeleteAsync(string transferInstrumentId)
        {
            var resource = new LegalEntityManagementResource(this, "/transferInstruments/" + transferInstrumentId);
            await resource.RequestAsync(null, null, HttpMethod.Delete);
        }
        
        // Synchronous methods:

        public TransferInstrument Create(TransferInstrumentInfo request)
        {
            return CreateAsync(request).GetAwaiter().GetResult();
        }

        public TransferInstrument Retrieve(string transferInstrumentId)
        {
            return RetrieveAsync(transferInstrumentId).GetAwaiter().GetResult();
        }

        public TransferInstrument Update(string transferInstrumentId, TransferInstrumentInfo request)
        {
            return UpdateAsync(transferInstrumentId, request).GetAwaiter().GetResult();
        }

        public void Delete(string transferInstrumentId)
        {
            DeleteAsync(transferInstrumentId);
        }
    }
}