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
        private HttpMethod _patchMethod = new HttpMethod("PATCH");

        public HostedOnboarding(Client client) : base(client)
        {
        }

        public async Task<OnboardingLink> CreateAsync(string legalEntityId, OnboardingLinkInfo request)
        {
            string jsonRequest = request.ToJson();
            LegalEntityManagementResource resource = new LegalEntityManagementResource(this, "/legalEntities/" + legalEntityId);
            string jsonResult = await resource.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<OnboardingLink>(jsonResult);
        }
        
        public async Task<OnboardingThemes> ListThemesAsync()
        {
            LegalEntityManagementResource resource = new LegalEntityManagementResource(this, "/themes");
            string jsonResult = await resource.RequestAsync(null, null, HttpMethod.Get);
            return JsonConvert.DeserializeObject<OnboardingThemes>(jsonResult);
        }
        
        public async Task<OnboardingTheme> RetrieveThemesAsync(string themeId)
        {
            LegalEntityManagementResource resource = new LegalEntityManagementResource(this, "/themes/" + themeId);
            string jsonResult = await resource.RequestAsync(null, null, HttpMethod.Get);
            return JsonConvert.DeserializeObject<OnboardingTheme>(jsonResult);
        }
        
        // Asynchronous methods:

        public OnboardingLink Create(string legalEntityId, OnboardingLinkInfo request)
        {
            return CreateAsync(legalEntityId, request).GetAwaiter().GetResult();
        }

        public OnboardingThemes ListThemes()
        {
            return ListThemesAsync().GetAwaiter().GetResult();
        }

        public OnboardingTheme RetrieveTheme(string themeId)
        {
            return RetrieveThemesAsync(themeId).GetAwaiter().GetResult();
        }
    }
}