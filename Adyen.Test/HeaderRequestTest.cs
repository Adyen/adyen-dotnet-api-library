﻿using System.Linq;
using System.Net.Http;
using Adyen.Constants;
using Adyen.HttpClient;
using Adyen.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Environment = Adyen.Model.Environment;

namespace Adyen.Test
{
    [TestClass]
    public class HeaderRequestTest
    {
        private readonly string _endpoint = "https://endpoint:8080/";
        
        [TestMethod]
        public void BasicAuthenticationHeadersTest()
        {
            var config = new Config
            {
                Username = "Username",
                Password = "Password",
                ApplicationName = "Appname"
            };
            var client = new HttpClientWrapper(config, new System.Net.Http.HttpClient());
            HttpRequestMessage httpRequestMessage = client.GetHttpRequestMessage(_endpoint, "requestBody", null, HttpMethod.Post);

            Assert.IsNotNull(httpRequestMessage.Headers.UserAgent);
            Assert.AreEqual(httpRequestMessage.RequestUri?.ToString(), _endpoint);
            Assert.AreEqual(httpRequestMessage.Headers.AcceptCharset.ToString(), "UTF-8");
            Assert.AreEqual(httpRequestMessage.Headers.CacheControl?.ToString(), "no-cache");
            Assert.AreEqual(httpRequestMessage.Content.Headers.GetValues("Content-Type").FirstOrDefault(), "application/json; charset=utf-8");
            Assert.IsNotNull(httpRequestMessage.Headers.Authorization);
            Assert.IsFalse(httpRequestMessage.Headers.TryGetValues("x-api-key", out var _));
        }

        [TestMethod]
        public void ApiKeyBasedHeadersTest()
        {
            var configWithApiKey = new Config
            {
                Environment = Environment.Test,
                XApiKey = "AQEyhmfxK....LAG84XwzP5pSpVd"
            };
            var client = new HttpClientWrapper(configWithApiKey, new System.Net.Http.HttpClient());
            HttpRequestMessage httpRequestMessage = client.GetHttpRequestMessage(_endpoint, "requestbody", null, HttpMethod.Get);

            Assert.IsNotNull(httpRequestMessage.Headers.UserAgent);
            Assert.AreEqual(httpRequestMessage.RequestUri?.ToString(), _endpoint);
            Assert.AreEqual(httpRequestMessage.Headers.AcceptCharset.ToString(), "UTF-8");
            Assert.AreEqual(httpRequestMessage.Headers.CacheControl?.ToString(), "no-cache");
            Assert.IsNull(httpRequestMessage.Content);

            Assert.IsNull(httpRequestMessage.Headers.Authorization);
            Assert.AreEqual(httpRequestMessage.Headers.GetValues("x-api-key").FirstOrDefault(), "AQEyhmfxK....LAG84XwzP5pSpVd");
        }
        
        [TestMethod]
        public void ApiKeyAndBasicAuthBasedHeaderTest()
        {
            var config = new Config
            {
                Username = "Username",
                Password = "Password",
                XApiKey = "AQEyhmfxK....LAG84XwzP5pSpVd"
            };
            
            var client = new HttpClientWrapper(config, new System.Net.Http.HttpClient());
            var httpRequestMessage = client.GetHttpRequestMessage(_endpoint, "requestbody", null, HttpMethod.Get);
            Assert.IsNull(httpRequestMessage.Headers.Authorization);
            Assert.AreEqual(httpRequestMessage.Headers.GetValues("x-api-key").FirstOrDefault(), "AQEyhmfxK....LAG84XwzP5pSpVd");
        }
        
        [TestMethod]
        public void IdempotencyKeyTest()
        {
            var config = new Config
            {
                Username = "Username",
                Password = "Password",
                ApplicationName = "Appname"
            };
            var client = new HttpClientWrapper(config, new System.Net.Http.HttpClient());
            var httpWebRequest = client.GetHttpRequestMessage(_endpoint, "requestbody",new RequestOptions
            {
                IdempotencyKey = "123456789"
            }, null);

            Assert.AreEqual(httpWebRequest.Headers.GetValues("Idempotency-Key").FirstOrDefault(), "123456789");
        }

        [TestMethod]
        public void IdempotencyKeyNotPresentInHeaderIfEmptyString()
        {
            var requestOptions = new RequestOptions
            {
                IdempotencyKey = string.Empty
            };
            
            var config = new Config
            {
                Username = "Username",
                Password = "Password",
                ApplicationName = "Appname"
            };
            
            var client = new HttpClientWrapper(config, new System.Net.Http.HttpClient());
            var httpWebRequest = client.GetHttpRequestMessage(_endpoint, "requestbody", requestOptions, null);
            Assert.IsFalse(httpWebRequest.Headers.TryGetValues("Idempotency-Key", out var _));
        }

        [TestMethod]
        public void IdempotencyKeyNotPresentInHeaderIfWhitespaceString()
        {
            var requestOptions = new RequestOptions
            {
                IdempotencyKey = " "
            };
            
            var config = new Config
            {
                Username = "Username",
                Password = "Password",
                ApplicationName = "Appname"
            };
            
            var client = new HttpClientWrapper(config, new System.Net.Http.HttpClient());
            var httpWebRequest = client.GetHttpRequestMessage(_endpoint, "request", requestOptions, null);

            Assert.IsFalse(httpWebRequest.Headers.TryGetValues("Idempotency-Key", out var _));
        }

        [TestMethod]
        public void IdempotencyKeyPresentInHeaderIfSpecified()
        {
            var requestOptions = new RequestOptions
            {
                IdempotencyKey = "idempotencyKey"
            };
            
            var config = new Config
            {
                Username = "Username",
                Password = "Password",
                ApplicationName = "Appname"
            };
            
            var client = new HttpClientWrapper(config, new System.Net.Http.HttpClient());
            var httpWebRequest = client.GetHttpRequestMessage(_endpoint,"requestBody", requestOptions, null);

            Assert.IsNotNull(httpWebRequest.Headers.GetValues("Idempotency-Key"));
            Assert.AreEqual(requestOptions.IdempotencyKey, httpWebRequest.Headers.GetValues("Idempotency-Key").FirstOrDefault());
        }

        [TestMethod]
        public void UserAgentPresentWhenApplicationNameIsProvidedTest()
        {
            var config = new Config
            {
                Username = "Username",
                Password = "Password",
                ApplicationName = "YourApplicationName"
            };
            
            var client = new HttpClientWrapper(config, new System.Net.Http.HttpClient());
            HttpRequestMessage httpWebRequest = client.GetHttpRequestMessage(_endpoint, "requestBody", null, null);

            Assert.AreEqual(httpWebRequest.Headers.GetValues("UserAgent").FirstOrDefault(), $"YourApplicationName {ClientConfig.LibName}/{ClientConfig.LibVersion}");
        }
        
        [TestMethod]
        public void UserAgentPresentWhenApplicationNameIsNotProvidedTest()
        {
            var config = new Config
            {
                Username = "Username",
                Password = "Password",
                ApplicationName = null
            };
            
            var client = new HttpClientWrapper(config, new System.Net.Http.HttpClient());
            HttpRequestMessage httpWebRequest = client.GetHttpRequestMessage(_endpoint, "requestBody", null, null);

            Assert.AreEqual(httpWebRequest.Headers.GetValues("UserAgent").FirstOrDefault(), $"{ClientConfig.LibName}/{ClientConfig.LibVersion}");
        }

        [TestMethod]
        public void LibraryAnalysisConstantsInHeaderTest()
        {
            var config = new Config
            {
                Username = "Username",
                Password = "Password",
                ApplicationName = "Appname"
            };
            
            var client = new HttpClientWrapper(config, new System.Net.Http.HttpClient());
            HttpRequestMessage httpWebRequest = client.GetHttpRequestMessage(_endpoint, "requestBody", null, null);

            Assert.IsNotNull(httpWebRequest.Headers.GetValues(ApiConstants.AdyenLibraryName));
            Assert.AreEqual(ClientConfig.LibName, httpWebRequest.Headers.GetValues(ApiConstants.AdyenLibraryName).FirstOrDefault());
            Assert.IsNotNull(httpWebRequest.Headers.GetValues(ApiConstants.AdyenLibraryVersion));
            Assert.AreEqual(ClientConfig.LibVersion, httpWebRequest.Headers.GetValues(ApiConstants.AdyenLibraryVersion).FirstOrDefault());
        }
    }
}
