﻿using Adyen.Constants;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Adyen.HttpClient.Interfaces;
using Adyen.Model;

namespace Adyen.HttpClient
{
    public class HttpUrlConnectionClient : IClient
    {
        private readonly Encoding _encoding = Encoding.ASCII;

        public string Request(string endpoint, string json, Config config, bool isApiKeyRequired, RequestOptions requestOptions = null , RemoteCertificateValidationCallback certificateValidationCallback=null)
        {
            string responseText = null;
            var httpWebRequest = GetHttpWebRequest(endpoint, config, isApiKeyRequired, requestOptions , certificateValidationCallback);
            if (config.HttpRequestTimeout > 0)
            {
                httpWebRequest.Timeout = config.HttpRequestTimeout;
            }
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
            try
            {
                using (var response = (HttpWebResponse) httpWebRequest.GetResponse())
                {
                    using (var reader = new StreamReader(response.GetResponseStream(), _encoding))
                    {
                        responseText = reader.ReadToEnd();
                    }
                }
            }
            catch (WebException e)
            {
                if (e.Response == null)
                {
                    throw new HttpClientException((int) HttpStatusCode.RequestTimeout, "HTTP Exception timeout", null, "No response", e);
                }
                var response = (HttpWebResponse) e.Response;
                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    responseText = sr.ReadToEnd();
                }
                throw new HttpClientException((int) response.StatusCode, "HTTP Exception", response.Headers, responseText);
            }
            return responseText;
        }

        /// <summary>
        /// HttpWebRequest asynchronous. 
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="json"></param>
        /// <param name="config"></param>
        /// <param name="isApiKeyRequired"></param>
        /// <param name="requestOptions">Optional parameter used to specify the options for the request</param>
        /// <returns>Task<string></returns>
        public async Task<string> RequestAsync(string endpoint, string json, Config config, bool isApiKeyRequired, RequestOptions requestOptions = null)
        {
            string responseText;
            //Set security protocol. Only TLS1.2
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var httpWebRequest = GetHttpWebRequest(endpoint, config, isApiKeyRequired, requestOptions);
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
            using (var response = (HttpWebResponse)await httpWebRequest.GetResponseAsync())
            {
                using (var reader = new StreamReader(response.GetResponseStream(), _encoding))
                {
                    responseText = await reader.ReadToEndAsync();
                }
            }
            return responseText;
        }
        public string Request(string endpoint, string json, Config config, bool isApiKeyRequired, RequestOptions requestOptions = null)
        {
            return this.Request(endpoint, json, config, isApiKeyRequired,requestOptions, null);
        }

        [Obsolete("This is deprecated functionality by Adyen. Correct use request method with isApiKeyRequired parameter.")]
        public string Request(string endpoint, string json, Config config)
        {
            return this.Request(endpoint, json, config, false,null);
        }

        public string Post(string endpoint, Dictionary<string, string> postParameters, Config config)
        {
            var dictToString = QueryString(postParameters);
            byte[] postBytes = Encoding.ASCII.GetBytes(dictToString);
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(endpoint);
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentType = "application/x-www-form-urlencoded";
            httpWebRequest.ContentLength = postBytes.Length;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            using (var stream = httpWebRequest.GetRequestStream())
            {
                stream.Write(postBytes, 0, postBytes.Length);
            }
            var response = (HttpWebResponse)httpWebRequest.GetResponse();
            return new StreamReader(response.GetResponseStream()).ReadToEnd();
        }

        public HttpWebRequest GetHttpWebRequest(string endpoint, Config config, bool isApiKeyRequired, RequestOptions requestOptions = null, RemoteCertificateValidationCallback certificateValidationCallback=null)
        {
            //Add default headers
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(endpoint);
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Headers.Add("Accept-Charset", "UTF-8");
            httpWebRequest.Headers.Add("Cache-Control", "no-cache");
            httpWebRequest.UserAgent = $"{config.ApplicationName} {ClientConfig.UserAgentSuffix}{ClientConfig.LibVersion}";
            if (!string.IsNullOrWhiteSpace(requestOptions?.IdempotencyKey))
            {
                httpWebRequest.Headers.Add("Idempotency-Key", requestOptions?.IdempotencyKey);
            }
            //Use one of two authentication method.
            if (isApiKeyRequired || !string.IsNullOrEmpty(config.XApiKey))
            {
                httpWebRequest.Headers.Add("x-api-key", config.XApiKey);
            }
            else if (!string.IsNullOrEmpty(config.Password))
            {
                var authString = config.Username + ":" + config.Password;
                var bytes = Encoding.ASCII.GetBytes(authString);
                var credentials = Convert.ToBase64String(bytes);
                httpWebRequest.Headers.Add("Authorization", "Basic " + credentials);
                httpWebRequest.UseDefaultCredentials = true;
            }
            if (certificateValidationCallback != null)
            {
                httpWebRequest.ServerCertificateValidationCallback = certificateValidationCallback;
            }
            return httpWebRequest;
        }
        public static string QueryString(IDictionary<string, string> dict)
        {
            var list = new List<string>();
            foreach (var item in dict)
            {
                list.Add(item.Key + "=" + HttpUtility.UrlEncode(item.Value));
            }
            return string.Join("&", list);
        }
    }
}
