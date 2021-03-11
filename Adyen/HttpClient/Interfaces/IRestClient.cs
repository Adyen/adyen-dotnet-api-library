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
 * Copyright (c) 2020 Adyen B.V.
 * This file is open source and available under the MIT license.
 * See the LICENSE file for more info.
 */
#endregion
using System.Threading.Tasks;

namespace Adyen.HttpClient.Interfaces
{
    public interface IRestClient
    {
        string Get(string endpoint, string json, Config config);
        string Post(string endpoint, string json, Config config);
        string Patch(string endpoint, string json, Config config);
        string Delete(string endpoint, string json, Config config);

        Task<string> GetAsync(string endpoint, string json, Config config);
        Task<string> PostAsync(string endpoint, string json, Config config);
        Task<string> PatchAsync(string endpoint, string json, Config config);
        Task<string> DeleteAsync(string endpoint, string json, Config config);
    }
}
