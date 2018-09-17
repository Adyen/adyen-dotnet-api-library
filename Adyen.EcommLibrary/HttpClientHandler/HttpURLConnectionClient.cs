using Adyen.EcommLibrary.Constants;
using Adyen.EcommLibrary.HttpClientHandler.Interfaces;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Adyen.EcommLibrary.HttpClientHandler
{
    public class HttpUrlConnectionClient : IClient
    {
        public string Request(string endpoint, string json, Config config, bool isApiKeyRequired)
        {
            string responseText;
            //Set security protocol. Only TLS1.2
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            
            var httpWebRequest = GetHttpWebRequest(endpoint, config, isApiKeyRequired);

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
           
            var response = (HttpWebResponse) httpWebRequest.GetResponse();
            var encoding = Encoding.ASCII;
            using (var reader = new StreamReader(response.GetResponseStream(), encoding))
            {
                responseText = reader.ReadToEnd();
            }

            if (response.StatusCode != HttpStatusCode.OK)
            {
                var httpClientException = new HttpClientException((int)response.StatusCode, "HTTP Exception",  response.Headers, responseText);
                throw httpClientException;
            }

            return responseText;
        }
        //This is deprecated functionality. Correct use is set the IsRequiredBool
        public string Request(string endpoint, string json, Config config)
        {
            return this.Request(endpoint, json, config, false);
        }
        
        public HttpWebRequest GetHttpWebRequest(string endpoint, Config config, bool isApiKeyRequired)
        {
            //Add default headers
            var httpWebRequest = (HttpWebRequest) WebRequest.Create(endpoint);
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Headers.Add("Accept-Charset", "UTF-8");
            httpWebRequest.Headers.Add("Cache-Control", "no-cache");
            httpWebRequest.UserAgent = $"{config.ApplicationName} {ClientConfig.UserAgentSuffix}{ClientConfig.LibVersion}";

            //Use one of two authentication method.
            if (isApiKeyRequired || !string.IsNullOrEmpty(config.XApiKey))
            {
                httpWebRequest.Headers.Add("x-api-key", config.XApiKey);
            }
            else
            {
                CreateBasicAuthentication(config, httpWebRequest);
            }
            return httpWebRequest;
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

        public static string QueryString(IDictionary<string, string> dict)
        {
            var list = new List<string>();
            foreach (var item in dict)
            {
                list.Add(item.Key + "=" + HttpUtility.UrlEncode(item.Value));
            }
            return string.Join("&", list);
        }

       
        /// <summary>
        /// Create the basic authentication header
        /// </summary>
        /// <param name="config"></param>
        /// <param name="request"></param>
        private static void CreateBasicAuthentication(Config config, HttpWebRequest request)
        {
            var authString = config.Username + ":" + config.Password;
            var bytes = Encoding.ASCII.GetBytes(authString);
            var credentials = Convert.ToBase64String(bytes);

            request.Headers.Add("Authorization", "Basic " + credentials);
            request.UseDefaultCredentials = true;
        }
       
    }
}
