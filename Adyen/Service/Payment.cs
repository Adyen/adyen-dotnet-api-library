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
using Adyen.Model.Checkout;
using Adyen.Service.Resource;
using PaymentRequest = Adyen.Model.Payments.PaymentRequest;
using RequestOptions = Adyen.Model.RequestOptions;
using ThreeDS2Result = Adyen.Model.Payments.ThreeDS2Result;

namespace Adyen.Service
{
    public class Payment : AbstractService
    {
        // Classic Payments
        private readonly ClassicResource _authorise;
        private readonly ClassicResource _authorise3D;
        private readonly ClassicResource _authorise3DS2;
        private readonly ClassicResource _getAuthenticationResult;
        private readonly ClassicResource _retrieve3DS2Result;
        // Classic Modification
        private readonly ClassicResource _capture;
        private readonly ClassicResource _cancelOrRefund;
        private readonly ClassicResource _refund;
        private readonly ClassicResource _cancel;
        private readonly ClassicResource _adjustAuthorisation;
        private readonly ClassicResource _voidPendingRefund;
        private readonly ClassicResource _technicalCancel;
        private readonly ClassicResource _donate;
        
        public Payment(Client client)
            : base(client)
        {
            _authorise = new ClassicResource(this, "/authorise");
            _authorise3D = new ClassicResource(this, "/authorise3d");
            _authorise3DS2 = new ClassicResource(this, "/authorise3ds2");
            _getAuthenticationResult = new ClassicResource(this, "/getAuthenticationResult");
            _retrieve3DS2Result = new ClassicResource(this, "/retrieve3ds2Result");
            _capture = new ClassicResource(this, "/capture");
            _cancelOrRefund = new ClassicResource(this, "/cancelOrRefund");
            _refund = new ClassicResource(this, "/refund");
            _cancel = new ClassicResource(this, "/cancel");
            _adjustAuthorisation = new ClassicResource(this, "/adjustAuthorisation");
            _voidPendingRefund = new ClassicResource(this, "/voidPendingRefund");
            _technicalCancel = new ClassicResource(this, "/technicalCancel");
            _donate = new ClassicResource(this, "/donate");
        }
        
        #region Classic Payments
        public PaymentResult Authorise(PaymentRequest paymentRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = paymentRequest.ToJson();
            return _authorise.Request<PaymentResult>(jsonRequest, requestOptions);
        }

        public PaymentResult Authorise(PaymentRequest3ds2 paymentRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = paymentRequest.ToJson();
            return _authorise.Request<PaymentResult>(jsonRequest, requestOptions);
        }

        public async Task<PaymentResult> AuthoriseAsync(PaymentRequest paymentRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = paymentRequest.ToJson();
            return await _authorise.RequestAsync<PaymentResult>(jsonRequest, requestOptions);
        }

        public async Task<PaymentResult> AuthoriseAsync(PaymentRequest3ds2 paymentRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = paymentRequest.ToJson();
            return await _authorise.RequestAsync<PaymentResult>(jsonRequest, requestOptions);
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
        #endregion

        #region Classic Modifications
        public ModificationResult Capture(CaptureRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = request.ToJson();
            var jsonResult = _capture.Request(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<ModificationResult>(jsonResult);
        }

        public async Task<ModificationResult> CaptureAsync(CaptureRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = request.ToJson();
            var jsonResult = await _capture.RequestAsync(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<ModificationResult>(jsonResult);
        }

        public ModificationResult CancelOrRefund(CancelOrRefundRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = request.ToJson();
            var jsonResult = _cancelOrRefund.Request(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<ModificationResult>(jsonResult);
        }

        public async Task<ModificationResult> CancelOrRefundAsync(CancelOrRefundRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = request.ToJson();
            var jsonResult = await _cancelOrRefund.RequestAsync(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<ModificationResult>(jsonResult);
        }

        public ModificationResult Refund(RefundRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = request.ToJson();
            var jsonResult = _refund.Request(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<ModificationResult>(jsonResult);
        }

        public async Task<ModificationResult> RefundAsync(RefundRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = request.ToJson();
            var jsonResult = await _refund.RequestAsync(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<ModificationResult>(jsonResult);
        }

        public ModificationResult Cancel(CancelRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = request.ToJson();
            var jsonResult = _cancel.Request(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<ModificationResult>(jsonResult);
        }

        public async Task<ModificationResult> CancelAsync(CancelRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = request.ToJson();
            var jsonResult = await _cancel.RequestAsync(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<ModificationResult>(jsonResult);
        }

        public ModificationResult AdjustAuthorisation(AdjustAuthorisationRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = request.ToJson();
            var jsonResult = _adjustAuthorisation.Request(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<ModificationResult>(jsonResult);
        }

        public async Task<ModificationResult> AdjustAuthorisationAsync(AdjustAuthorisationRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = request.ToJson();
            var jsonResult = await _adjustAuthorisation.RequestAsync(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<ModificationResult>(jsonResult);
        }

        public ModificationResult VoidPendingRefund(VoidPendingRefundRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = request.ToJson();
            var jsonResult = _voidPendingRefund.Request(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<ModificationResult>(jsonResult);
        }

        public async Task<ModificationResult> VoidPendingRefundAsync(VoidPendingRefundRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = request.ToJson();
            var jsonResult = await _voidPendingRefund.RequestAsync(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<ModificationResult>(jsonResult);
        }

        public async Task<ModificationResult> TechnicalCancelAsync(TechnicalCancelRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = request.ToJson();
            var jsonResult = await _technicalCancel.RequestAsync(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<ModificationResult>(jsonResult);
        }

        public ModificationResult TechnicalCancel(TechnicalCancelRequest request, RequestOptions requestOptions = null)
        {
            return TechnicalCancelAsync(request, requestOptions).GetAwaiter().GetResult();
        }
        
        public async Task<ModificationResult> DonateAsync(DonationRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = request.ToJson();
            var jsonResult = await _donate.RequestAsync(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<ModificationResult>(jsonResult);
        }

        public ModificationResult Donate(DonationRequest request, RequestOptions requestOptions = null)
        {
            return DonateAsync(request, requestOptions).GetAwaiter().GetResult();
        }
        #endregion
    }
}
