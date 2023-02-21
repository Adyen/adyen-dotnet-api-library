/*
* Adyen Payment API
*
*
* The version of the OpenAPI document: 68
* Contact: developer-experience@adyen.com
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Adyen.Constants;
using Adyen.Model;
using Adyen.Service.Resource;
using Adyen.Model.ClassicPayments;
using Newtonsoft.Json;

namespace Adyen.Service.ClassicPayments
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PaymentService : AbstractService
    {
        private readonly string _baseUrl;
        
        public PaymentService(Client client) : base(client)
        {
            _baseUrl = client.Config.Endpoint + "/pal/servlet/Payment/" + ClientConfig.ApiVersion;
        }
    
        /// <summary>
        /// Create an authorisation
        /// </summary>
        /// <param name="paymentRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>PaymentResult</returns>
        public PaymentResult CreateAuthorisation(PaymentRequest paymentRequest, RequestOptions requestOptions = default)
        {
            return CreateAuthorisationAsync(paymentRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an authorisation
        /// </summary>
        /// <param name="paymentRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of PaymentResult</returns>
        public async Task<PaymentResult> CreateAuthorisationAsync(PaymentRequest paymentRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + "/authorise";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaymentResult>(paymentRequest.ToJson(), requestOptions, new HttpMethod("POST"));
        }

        /// <summary>
        /// Complete a 3DS authorisation
        /// </summary>
        /// <param name="paymentRequest3d"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>PaymentResult</returns>
        public PaymentResult Complete3dsAuthorisation(PaymentRequest3d paymentRequest3d, RequestOptions requestOptions = default)
        {
            return Complete3dsAuthorisationAsync(paymentRequest3d, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Complete a 3DS authorisation
        /// </summary>
        /// <param name="paymentRequest3d"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of PaymentResult</returns>
        public async Task<PaymentResult> Complete3dsAuthorisationAsync(PaymentRequest3d paymentRequest3d, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + "/authorise3d";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaymentResult>(paymentRequest3d.ToJson(), requestOptions, new HttpMethod("POST"));
        }

        /// <summary>
        /// Complete a 3DS2 authorisation
        /// </summary>
        /// <param name="paymentRequest3ds2"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>PaymentResult</returns>
        public PaymentResult Complete3ds2Authorisation(PaymentRequest3ds2 paymentRequest3ds2, RequestOptions requestOptions = default)
        {
            return Complete3ds2AuthorisationAsync(paymentRequest3ds2, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Complete a 3DS2 authorisation
        /// </summary>
        /// <param name="paymentRequest3ds2"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of PaymentResult</returns>
        public async Task<PaymentResult> Complete3ds2AuthorisationAsync(PaymentRequest3ds2 paymentRequest3ds2, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + "/authorise3ds2";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaymentResult>(paymentRequest3ds2.ToJson(), requestOptions, new HttpMethod("POST"));
        }

        /// <summary>
        /// Get the 3DS authentication result
        /// </summary>
        /// <param name="authenticationResultRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>AuthenticationResultResponse</returns>
        public AuthenticationResultResponse GetThe3dsAuthenticationResult(AuthenticationResultRequest authenticationResultRequest, RequestOptions requestOptions = default)
        {
            return GetThe3dsAuthenticationResultAsync(authenticationResultRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the 3DS authentication result
        /// </summary>
        /// <param name="authenticationResultRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of AuthenticationResultResponse</returns>
        public async Task<AuthenticationResultResponse> GetThe3dsAuthenticationResultAsync(AuthenticationResultRequest authenticationResultRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + "/getAuthenticationResult";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<AuthenticationResultResponse>(authenticationResultRequest.ToJson(), requestOptions, new HttpMethod("POST"));
        }

        /// <summary>
        /// Get the 3DS2 authentication result
        /// </summary>
        /// <param name="threeDS2ResultRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>ThreeDS2ResultResponse</returns>
        public ThreeDS2ResultResponse GetThe3ds2AuthenticationResult(ThreeDS2ResultRequest threeDS2ResultRequest, RequestOptions requestOptions = default)
        {
            return GetThe3ds2AuthenticationResultAsync(threeDS2ResultRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the 3DS2 authentication result
        /// </summary>
        /// <param name="threeDS2ResultRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of ThreeDS2ResultResponse</returns>
        public async Task<ThreeDS2ResultResponse> GetThe3ds2AuthenticationResultAsync(ThreeDS2ResultRequest threeDS2ResultRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + "/retrieve3ds2Result";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<ThreeDS2ResultResponse>(threeDS2ResultRequest.ToJson(), requestOptions, new HttpMethod("POST"));
        }

    }
}
