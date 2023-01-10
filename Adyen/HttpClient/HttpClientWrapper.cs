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
//  * Copyright (c) 2022 Adyen N.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */

#endregion

using Adyen.Constants;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Adyen.HttpClient.Interfaces;
using Adyen.Model;

namespace Adyen.HttpClient
{
    public class HttpClientWrapper : IClient
    {
        private readonly Config _config;

        private readonly Encoding _encoding = Encoding.UTF8;
        private readonly System.Net.Http.HttpClient _httpClient;

        public HttpClientWrapper(Config config, System.Net.Http.HttpClient httpClient)
        {
            _config = config;
            _httpClient = httpClient;
        }

        public string Request(string endpoint, string requestBody, RequestOptions requestOptions = null, HttpMethod httpMethod = null)
        {
            return RequestAsync(endpoint, requestBody, requestOptions,  httpMethod).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<string> RequestAsync(string endpoint, string requestBody, RequestOptions requestOptions = null, HttpMethod httpMethod = null)
        {
            using (HttpRequestMessage request = GetHttpRequestMessage(endpoint, requestBody, requestOptions, httpMethod))
            using (HttpResponseMessage httpResponseMessage = await _httpClient.SendAsync(request))
            {
                string responseText = await httpResponseMessage.Content.ReadAsStringAsync();
                if(httpResponseMessage.IsSuccessStatusCode)
                {
                    return responseText;
                }
                throw (new HttpClientException((int)httpResponseMessage.StatusCode, (int)httpResponseMessage.StatusCode + ": " + httpResponseMessage.StatusCode + ", ResponseBody: " + responseText, responseText));
            }
        }

        public string Post(string endpoint, Dictionary<string, string> postParameters)
        {
            string dictToString = QueryString(postParameters);

            StringContent content = new StringContent(dictToString, _encoding, "application/x-www-form-urlencoded");
            using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, endpoint) {Content = content})
            using (HttpResponseMessage response = _httpClient.SendAsync(request).GetAwaiter().GetResult())
            {
                response.EnsureSuccessStatusCode();
                return response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            }
        }

        public HttpRequestMessage GetHttpRequestMessage(string endpoint, string requestBody, RequestOptions requestOptions, HttpMethod httpMethod)
        {   
            if (httpMethod == null) {httpMethod = HttpMethod.Post;}
            
            HttpRequestMessage httpWebRequest = new HttpRequestMessage(httpMethod, endpoint);
            
            // Custom patch method for dotnet <2.1
            HttpMethod patchMethod = new HttpMethod("PATCH");
            
            if (httpMethod == HttpMethod.Post || httpMethod == patchMethod)
            {
                httpWebRequest.Content = new StringContent(requestBody, _encoding, "application/json");
            }

            httpWebRequest.Headers.Add("ContentType", "application/json");
            httpWebRequest.Headers.Add("Accept-Charset", "UTF-8");
            httpWebRequest.Headers.Add("Cache-Control", "no-cache");
            httpWebRequest.Headers.Add("UserAgent", $"{_config.ApplicationName} {ClientConfig.UserAgentSuffix}{ClientConfig.LibVersion}");
            if (!string.IsNullOrWhiteSpace(requestOptions?.IdempotencyKey))
            {
                httpWebRequest.Headers.Add("Idempotency-Key", requestOptions.IdempotencyKey);
            }

            //Use one of two authentication method.
            if (_config.HasApiKey)
            {
                httpWebRequest.Headers.Add("x-api-key", _config.XApiKey);
            }
            else if (_config.HasPassword)
            {
                string authString = _config.Username + ":" + _config.Password;
                byte[] bytes = Encoding.UTF8.GetBytes(authString);
                string credentials = Convert.ToBase64String(bytes);
                httpWebRequest.Headers.Add("Authorization", "Basic " + credentials);
            }

            return httpWebRequest;
        }

        private static string QueryString(IDictionary<string, string> dict)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (KeyValuePair<string, string> item in dict)
            {
                stringBuilder.Append(item.Key);
                stringBuilder.Append('=');
                stringBuilder.Append(HttpUtility.UrlEncode(item.Value));
                stringBuilder.Append('&');
            }

            if (stringBuilder.Length > 0)
            {
                // Remove trailing &amp
                stringBuilder.Remove(stringBuilder.Length - 2, 1);
            }

            return stringBuilder.ToString();
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }
}