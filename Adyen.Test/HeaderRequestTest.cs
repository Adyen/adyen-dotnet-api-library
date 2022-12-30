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
            var client = new HttpClientWrapper(MockPaymentData.CreateConfingMock(), new System.Net.Http.HttpClient());
            var httpRequestMessage = client.GetHttpRequestMessage(_endpoint, "requestBody", null, HttpMethod.Post);
            
            Assert.IsNotNull(httpRequestMessage.Headers.UserAgent);
            Assert.AreEqual<string>(httpRequestMessage.RequestUri?.ToString(), _endpoint);
            Assert.AreEqual(httpRequestMessage.Headers.AcceptCharset.ToString(), "UTF-8");
            Assert.AreEqual(httpRequestMessage.Headers.CacheControl?.ToString(), "no-cache");
            Assert.IsNotNull(httpRequestMessage.Content);
            Assert.IsNotNull(httpRequestMessage.Headers.Authorization);
        }

        [TestMethod]
        public void ApiKeyBasedHeadersTest()
        {
            var client = new HttpClientWrapper(MockPaymentData.CreateConfingApiKeyBasedMock(), new System.Net.Http.HttpClient());
            var httpRequestMessage = client.GetHttpRequestMessage(_endpoint, "requestbody", null, HttpMethod.Get);
            
            Assert.IsNotNull(httpRequestMessage.Headers.UserAgent);
            Assert.AreEqual<string>(httpRequestMessage.RequestUri?.ToString(), _endpoint);
            Assert.AreEqual(httpRequestMessage.Headers.AcceptCharset.ToString(), "UTF-8");
            Assert.AreEqual(httpRequestMessage.Headers.CacheControl.ToString(), "no-cache");
            Assert.IsNull(httpRequestMessage.Content);

            Assert.IsNull(httpRequestMessage.Headers.Authorization);

            Assert.AreEqual(httpRequestMessage.Headers.GetValues("x-api-key").FirstOrDefault(), "AQEyhmfxK....LAG84XwzP5pSpVd");
        }

        [TestMethod]
        public void IdempotencyKeyTest()
        {
            var client = new HttpClientWrapper(MockPaymentData.CreateConfingMock(), new System.Net.Http.HttpClient());
            var httpWebRequest = client.GetHttpRequestMessage(_endpoint, "requestbody",new RequestOptions()
            {
                IdempotencyKey = "123456789"
            }, null);

            Assert.AreEqual(httpWebRequest.Headers.GetValues("Idempotency-Key").FirstOrDefault(), "123456789");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "Cannot find Idem-Key in header, throws invalidOperation")]
        public void IdempotencyKeyNotPresentInHeaderIfEmptyString()
        {
            var requestOptions = new RequestOptions
            {
                IdempotencyKey = string.Empty
            };

            var client = new HttpClientWrapper(MockPaymentData.CreateConfingMock(), new System.Net.Http.HttpClient());
            var httpWebRequest = client.GetHttpRequestMessage(_endpoint, "requestbody", requestOptions, null);
            
            httpWebRequest.Headers.GetValues("Idempotency-Key");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "Cannot find Idem-Key in header, throws invalidOperation")]
        public void IdempotencyKeyNotPresentInHeaderIfWhitespaceString()
        {
            var requestOptions = new RequestOptions
            {
                IdempotencyKey = " "
            };

            var client = new HttpClientWrapper(MockPaymentData.CreateConfingMock(), new System.Net.Http.HttpClient());
            var httpWebRequest = client.GetHttpRequestMessage(_endpoint, "request", requestOptions, null);
            
            httpWebRequest.Headers.GetValues("Idempotency-Key");
        }

        [TestMethod]
        public void IdempotencyKeyPresentInHeaderIfSpecified()
        {
            var requestOptions = new RequestOptions
            {
                IdempotencyKey = "idempotencyKey"
            };

            var client = new HttpClientWrapper(MockPaymentData.CreateConfingMock(), new System.Net.Http.HttpClient());
            var httpWebRequest = client.GetHttpRequestMessage(_endpoint,"requestBody", requestOptions, null);
            
            Assert.IsNotNull(httpWebRequest.Headers.GetValues("Idempotency-Key"));
            Assert.AreEqual(requestOptions.IdempotencyKey, httpWebRequest.Headers.GetValues("Idempotency-Key").FirstOrDefault());
        }
    }
}
