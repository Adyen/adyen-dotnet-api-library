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
    public class HostedOnboarding : AbstractService
    {
        private HttpMethod patchMethod = new HttpMethod("PATCH");

        public HostedOnboarding(Client client) : base(client)
        {
        }

        public async Task<OnboardingLink> createAsync(string legalEntityId, OnboardingLinkInfo request)
        {
            var jsonRequest = request.ToJson();
            var resource = new LegalEntityManagementResource(this, "/legalEntities/" + legalEntityId);
            var jsonResult = await resource.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<OnboardingLink>(jsonResult);
        }
        
        public async Task<OnboardingThemes> listThemesAsync()
        {
            var resource = new LegalEntityManagementResource(this, "/themes");
            var jsonResult = await resource.RequestAsync(null, null, HttpMethod.Get);
            return JsonConvert.DeserializeObject<OnboardingThemes>(jsonResult);
        }
        
        public async Task<OnboardingTheme> retrieveThemesAsync(string themeId)
        {
            var resource = new LegalEntityManagementResource(this, "/themes/" + themeId);
            var jsonResult = await resource.RequestAsync(null, null, HttpMethod.Get);
            return JsonConvert.DeserializeObject<OnboardingTheme>(jsonResult);
        }
        
        // Asynchronous methods:

        public OnboardingLink create(string legalEntityId, OnboardingLinkInfo request)
        {
            return createAsync(legalEntityId, request).GetAwaiter().GetResult();
        }

        public OnboardingThemes listThemes()
        {
            return listThemesAsync().GetAwaiter().GetResult();
        }

        public OnboardingTheme retrieveTheme(string themeId)
        {
            return retrieveThemesAsync(themeId).GetAwaiter().GetResult();
        }
    }
}