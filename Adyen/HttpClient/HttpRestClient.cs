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
 * Copyright (c) 2021 Adyen B.V.
 * This file is open source and available under the MIT license.
 * See the LICENSE file for more info.
 */
#endregion
using Adyen.HttpClient.Interfaces;
using System;
using System.Threading.Tasks;

namespace Adyen.HttpClient
{
    /// <summary>
    /// Defines methods required to make RESTful calls.
    /// </summary>
    public class HttpRestClient : IRestClient
    {
        public Config Config { get; internal set; }
        public string Get(string endpoint, string json, Config config)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetAsync(string endpoint, string json, Config config)
        {
            throw new NotImplementedException();
        }
        public string Post(string endpoint, string json, Config config)
        {
            throw new NotImplementedException();
        }

        public Task<string> PostAsync(string endpoint, string json, Config config)
        {
            throw new NotImplementedException();
        }
        
        public Task<string> DeleteAsync(string endpoint, string json, Config config)
        {
            throw new NotImplementedException();
        }
        public string Delete(string endpoint, string json, Config config)
        {
            throw new NotImplementedException();
        }

        public string Patch(string endpoint, string json, Config config)
        {
            throw new NotImplementedException();
        }

        public Task<string> PatchAsync(string endpoint, string json, Config config)
        {
            throw new NotImplementedException();
        }
    }
}
