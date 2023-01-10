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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Adyen.HttpClient;
using Adyen.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class HeaderRequestTest
    {
        private readonly string _endpoint = "https://endpoint:8080/";
        
        [TestMethod]
        public void BasicAuthenticationHeadersTest()
        {
            HttpClientWrapper client = new HttpClientWrapper(MockPaymentData.CreateConfigMock(), new System.Net.Http.HttpClient());
            HttpRequestMessage httpRequestMessage = client.GetHttpRequestMessage(_endpoint, "requestBody", null, HttpMethod.Post);

            Assert.IsNotNull(httpRequestMessage.Headers.UserAgent);
            Assert.AreEqual(httpRequestMessage.RequestUri?.ToString(), _endpoint);
            Assert.AreEqual(httpRequestMessage.Headers.AcceptCharset.ToString(), "UTF-8");
            Assert.AreEqual(httpRequestMessage.Headers.CacheControl?.ToString(), "no-cache");
            Assert.AreEqual(httpRequestMessage.Content.Headers.GetValues("Content-Type").FirstOrDefault(), "application/json; charset=utf-8");
            Assert.IsNotNull(httpRequestMessage.Headers.Authorization);
            Assert.IsFalse(httpRequestMessage.Headers.TryGetValues("x-api-key", out IEnumerable<string> _));
        }

        [TestMethod]
        public void ApiKeyBasedHeadersTest()
        {
            HttpClientWrapper client = new HttpClientWrapper(MockPaymentData.CreateConfigApiKeyBasedMock(), new System.Net.Http.HttpClient());
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
            Config config = new Config
            {
                Username = "Username",
                Password = "Password",
                MerchantAccount = "TestMerchant",
                XApiKey = "AQEyhmfxK....LAG84XwzP5pSpVd"
            };
            
            HttpClientWrapper client = new HttpClientWrapper(config, new System.Net.Http.HttpClient());
            HttpRequestMessage httpRequestMessage = client.GetHttpRequestMessage(_endpoint, "requestbody", null, HttpMethod.Get);
            Assert.IsNull(httpRequestMessage.Headers.Authorization);
            Assert.AreEqual(httpRequestMessage.Headers.GetValues("x-api-key").FirstOrDefault(), "AQEyhmfxK....LAG84XwzP5pSpVd");
        }
        
        [TestMethod]
        public void IdempotencyKeyTest()
        {
            HttpClientWrapper client = new HttpClientWrapper(MockPaymentData.CreateConfigMock(), new System.Net.Http.HttpClient());
            HttpRequestMessage httpWebRequest = client.GetHttpRequestMessage(_endpoint, "requestbody",new RequestOptions()
            {
                IdempotencyKey = "123456789"
            }, null);

            Assert.AreEqual(httpWebRequest.Headers.GetValues("Idempotency-Key").FirstOrDefault(), "123456789");
        }

        [TestMethod]
        public void IdempotencyKeyNotPresentInHeaderIfEmptyString()
        {
            RequestOptions requestOptions = new RequestOptions
            {
                IdempotencyKey = string.Empty
            };
            
            HttpClientWrapper client = new HttpClientWrapper(MockPaymentData.CreateConfigMock(), new System.Net.Http.HttpClient());
            HttpRequestMessage httpWebRequest = client.GetHttpRequestMessage(_endpoint, "requestbody", requestOptions, null);
            Assert.IsFalse(httpWebRequest.Headers.TryGetValues("Idempotency-Key", out IEnumerable<string> _));
        }

        [TestMethod]
        public void IdempotencyKeyNotPresentInHeaderIfWhitespaceString()
        {
            RequestOptions requestOptions = new RequestOptions
            {
                IdempotencyKey = " "
            };
            
            HttpClientWrapper client = new HttpClientWrapper(MockPaymentData.CreateConfigMock(), new System.Net.Http.HttpClient());
            HttpRequestMessage httpWebRequest = client.GetHttpRequestMessage(_endpoint, "request", requestOptions, null);

            Assert.IsFalse(httpWebRequest.Headers.TryGetValues("Idempotency-Key", out IEnumerable<string> _));
        }

        [TestMethod]
        public void IdempotencyKeyPresentInHeaderIfSpecified()
        {
            RequestOptions requestOptions = new RequestOptions
            {
                IdempotencyKey = "idempotencyKey"
            };
            
            HttpClientWrapper client = new HttpClientWrapper(MockPaymentData.CreateConfigMock(), new System.Net.Http.HttpClient());
            HttpRequestMessage httpWebRequest = client.GetHttpRequestMessage(_endpoint,"requestBody", requestOptions, null);

            Assert.IsNotNull(httpWebRequest.Headers.GetValues("Idempotency-Key"));
            Assert.AreEqual(requestOptions.IdempotencyKey, httpWebRequest.Headers.GetValues("Idempotency-Key").FirstOrDefault());
        }
    }
}
