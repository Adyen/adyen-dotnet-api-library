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
using Adyen.Service.Resource.Payment;
using Newtonsoft.Json;
using System.Threading.Tasks;
using RequestOptions = Adyen.Model.RequestOptions;

namespace Adyen.Service
{
    public class Payment : AbstractService
    {
        private readonly Authorise _authorise;
        private readonly Authorise3D _authorise3D;
        private readonly Authorise3DS2 _authorise3DS2;
        private readonly GetAuthenticationResult _getAuthenticationResult;
        private readonly Retrieve3DS2Result _retrieve3DS2Result;
        
        public Payment(Client client)
            : base(client)
        {
            _authorise = new Authorise(this);
            _authorise3D = new Authorise3D(this);
            _authorise3DS2 = new Authorise3DS2(this);
            _getAuthenticationResult = new GetAuthenticationResult(this);
            _retrieve3DS2Result = new Retrieve3DS2Result(this);
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
