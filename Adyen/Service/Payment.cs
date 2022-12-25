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

using Adyen.Model.Payments;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Adyen.Service.Resource;
using RequestOptions = Adyen.Model.RequestOptions;

namespace Adyen.Service
{
    public class Payment : AbstractService
    {
        private readonly PaymentResource _authorise;
        private readonly PaymentResource _authorise3D;
        private readonly PaymentResource _authorise3DS2;
        private readonly PaymentResource _getAuthenticationResult;
        private readonly PaymentResource _retrieve3DS2Result;
        
        public Payment(Client client)
            : base(client)
        {
            _authorise = new PaymentResource(this, "/authorise");
            _authorise3D = new PaymentResource(this, "/authorise3d");
            _authorise3DS2 = new PaymentResource(this, "/authorise3ds2");
            _getAuthenticationResult = new PaymentResource(this, "/getAuthenticationResult");
            _retrieve3DS2Result = new PaymentResource(this, "/retrieve3ds2Result");
        }

        public PaymentResult Authorise(PaymentRequest paymentRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = paymentRequest.ToJson();
            var jsonResponse = _authorise.Request(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<PaymentResult>(jsonResponse);
        }

        public PaymentResult Authorise(PaymentRequest3ds2 paymentRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = paymentRequest.ToJson();
            var jsonResponse = _authorise.Request(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<PaymentResult>(jsonResponse);
        }

        public async Task<PaymentResult> AuthoriseAsync(PaymentRequest paymentRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = paymentRequest.ToJson();
            var jsonResponse = await _authorise.RequestAsync(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<PaymentResult>(jsonResponse);
        }

        public async Task<PaymentResult> AuthoriseAsync(PaymentRequest3ds2 paymentRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = paymentRequest.ToJson();
            var jsonResponse = await _authorise.RequestAsync(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<PaymentResult>(jsonResponse);
        }

        public PaymentResult Authorise3D(PaymentRequest3d paymentRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = paymentRequest.ToJson();
            var jsonResponse = _authorise3D.Request(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<PaymentResult>(jsonResponse);
        }

        public async Task<PaymentResult> Authorise3DAsync(PaymentRequest3d paymentRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = paymentRequest.ToJson();
            var jsonResponse = await _authorise3D.RequestAsync(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<PaymentResult>(jsonResponse);
        }

        public PaymentResult Authorise3DS2(PaymentRequest3ds2 paymentRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = paymentRequest.ToJson();
            var jsonResponse =  _authorise3DS2.Request(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<PaymentResult>(jsonResponse);
        }

        public async Task<PaymentResult> Authorise3DS2Async(PaymentRequest3ds2 paymentRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = paymentRequest.ToJson();
            var jsonResponse = await _authorise3DS2.RequestAsync(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<PaymentResult>(jsonResponse);
        }

        public async Task<AuthenticationResultResponse> GetAuthenticationResultAsync(AuthenticationResultRequest authenticationResultRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = authenticationResultRequest.ToJson();
            var jsonResponse = await _getAuthenticationResult.RequestAsync(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<AuthenticationResultResponse>(jsonResponse);
        }

        public AuthenticationResultResponse GetAuthenticationResult(AuthenticationResultRequest authenticationResultRequest, RequestOptions requestOptions = null)
        {
            return GetAuthenticationResultAsync(authenticationResultRequest, requestOptions).GetAwaiter().GetResult();
        }

        public async Task<ThreeDS2Result> Retrieve3DS2ResultAsync(AuthenticationResultRequest authenticationResultRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = authenticationResultRequest.ToJson();
            var jsonResponse = await _retrieve3DS2Result.RequestAsync(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<ThreeDS2Result>(jsonResponse);
        }

        public ThreeDS2Result Retrieve3DS2Result(AuthenticationResultRequest authenticationResultRequest, RequestOptions requestOptions = null)
        {
            return Retrieve3DS2ResultAsync(authenticationResultRequest, requestOptions).GetAwaiter().GetResult();
        }
    }
}
