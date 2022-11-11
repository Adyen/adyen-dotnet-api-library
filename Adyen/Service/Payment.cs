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

using Adyen.Model;
using Adyen.Service.Resource.Payment;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Adyen.Service
{
    public class Payment : AbstractService
    {
        private readonly Authorise _authorise;
        private readonly Authorise3D _authorise3D;
        private readonly Authorise3DS2 _authorise3DS2;
        private readonly GetAuthenticationResult _getAuthenticationResult;
        public Payment(Client client)
            : base(client)
        {
            _authorise = new Authorise(this);
            _authorise3D = new Authorise3D(this);
            _authorise3DS2 = new Authorise3DS2(this);
            _getAuthenticationResult = new GetAuthenticationResult(this);
        }

        public PaymentResult Authorise(PaymentRequest paymentRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(paymentRequest);
            var jsonResponse = _authorise.Request(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<PaymentResult>(jsonResponse);
        }

        public PaymentResult Authorise(PaymentRequestThreeDS2 paymentRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(paymentRequest);
            var jsonResponse = _authorise.Request(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<PaymentResult>(jsonResponse);
        }

        public async Task<PaymentResult> AuthoriseAsync(PaymentRequest paymentRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(paymentRequest);
            var jsonResponse = await _authorise.RequestAsync(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<PaymentResult>(jsonResponse);
        }

        public async Task<PaymentResult> AuthoriseAsync(PaymentRequestThreeDS2 paymentRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(paymentRequest);
            var jsonResponse = await _authorise.RequestAsync(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<PaymentResult>(jsonResponse);
        }

        public PaymentResult Authorise3D(PaymentRequest3D paymentRequest3D, RequestOptions requestOptions = null)
        {
            var jsonRequest = JsonConvert.SerializeObject(paymentRequest3D);
            var jsonResponse = _authorise3D.Request(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<PaymentResult>(jsonResponse);
        }

        public async Task<PaymentResult> Authorise3DAsync(PaymentRequest3D paymentRequest3D, RequestOptions requestOptions = null)
        {
            var jsonRequest = JsonConvert.SerializeObject(paymentRequest3D);
            var jsonResponse = await _authorise3D.RequestAsync(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<PaymentResult>(jsonResponse);
        }

        public PaymentResult Authorise3DS2(PaymentRequestThreeDS2 paymentRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = JsonConvert.SerializeObject(paymentRequest);
            var jsonResponse =  _authorise3DS2.Request(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<PaymentResult>(jsonResponse);
        }

        public async Task<PaymentResult> Authorise3DS2Async(PaymentRequestThreeDS2 paymentRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = JsonConvert.SerializeObject(paymentRequest);
            var jsonResponse = await _authorise3DS2.RequestAsync(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<PaymentResult>(jsonResponse);
        }

        public AuthenticationResultResponse GetAuthenticationResult(AuthenticationResultRequest authenticationResultRequest)
        {
            var jsonRequest = JsonConvert.SerializeObject(authenticationResultRequest);
            var jsonResponse = _getAuthenticationResult.Request(jsonRequest);
            return JsonConvert.DeserializeObject<AuthenticationResultResponse>(jsonResponse);
        }
    }
}
