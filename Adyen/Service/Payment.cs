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
using System.Threading.Tasks;
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
            return _authorise3D.Request<PaymentResult>(jsonRequest, requestOptions);
        }

        public async Task<PaymentResult> Authorise3DAsync(PaymentRequest3d paymentRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = paymentRequest.ToJson();
            return await _authorise3D.RequestAsync<PaymentResult>(jsonRequest, requestOptions);
        }

        public PaymentResult Authorise3DS2(PaymentRequest3ds2 paymentRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = paymentRequest.ToJson();
            return _authorise3DS2.Request<PaymentResult>(jsonRequest, requestOptions);
        }

        public async Task<PaymentResult> Authorise3DS2Async(PaymentRequest3ds2 paymentRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = paymentRequest.ToJson();
            return await _authorise3DS2.RequestAsync<PaymentResult>(jsonRequest, requestOptions);
        }

        public async Task<AuthenticationResultResponse> GetAuthenticationResultAsync(AuthenticationResultRequest authenticationResultRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = authenticationResultRequest.ToJson();
            return await _getAuthenticationResult.RequestAsync<AuthenticationResultResponse>(jsonRequest, requestOptions);
        }

        public AuthenticationResultResponse GetAuthenticationResult(AuthenticationResultRequest authenticationResultRequest, RequestOptions requestOptions = null)
        {
            return GetAuthenticationResultAsync(authenticationResultRequest, requestOptions).GetAwaiter().GetResult();
        }

        public async Task<ThreeDS2Result> Retrieve3DS2ResultAsync(AuthenticationResultRequest authenticationResultRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = authenticationResultRequest.ToJson();
            return await _retrieve3DS2Result.RequestAsync<ThreeDS2Result>(jsonRequest, requestOptions);
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
            return _capture.Request<ModificationResult>(jsonRequest, requestOptions);
        }

        public async Task<ModificationResult> CaptureAsync(CaptureRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = request.ToJson();
            return await _capture.RequestAsync<ModificationResult>(jsonRequest, requestOptions);
        }

        public ModificationResult CancelOrRefund(CancelOrRefundRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = request.ToJson();
            return _cancelOrRefund.Request<ModificationResult>(jsonRequest, requestOptions);
        }

        public async Task<ModificationResult> CancelOrRefundAsync(CancelOrRefundRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = request.ToJson();
            return await _cancelOrRefund.RequestAsync<ModificationResult>(jsonRequest, requestOptions);
        }

        public ModificationResult Refund(RefundRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = request.ToJson();
            return _refund.Request<ModificationResult>(jsonRequest, requestOptions);
        }

        public async Task<ModificationResult> RefundAsync(RefundRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = request.ToJson();
            return await _refund.RequestAsync<ModificationResult>(jsonRequest, requestOptions);
        }

        public ModificationResult Cancel(CancelRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = request.ToJson();
            return _cancel.Request<ModificationResult>(jsonRequest, requestOptions);
        }

        public async Task<ModificationResult> CancelAsync(CancelRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = request.ToJson();
            return await _cancel.RequestAsync<ModificationResult>(jsonRequest, requestOptions);
        }

        public ModificationResult AdjustAuthorisation(AdjustAuthorisationRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = request.ToJson();
            return _adjustAuthorisation.Request<ModificationResult>(jsonRequest, requestOptions);
        }

        public async Task<ModificationResult> AdjustAuthorisationAsync(AdjustAuthorisationRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = request.ToJson();
            return await _adjustAuthorisation.RequestAsync<ModificationResult>(jsonRequest, requestOptions);
        }

        public ModificationResult VoidPendingRefund(VoidPendingRefundRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = request.ToJson();
            return _voidPendingRefund.Request<ModificationResult>(jsonRequest, requestOptions);
        }

        public async Task<ModificationResult> VoidPendingRefundAsync(VoidPendingRefundRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = request.ToJson();
            return await _voidPendingRefund.RequestAsync<ModificationResult>(jsonRequest, requestOptions);
        }

        public async Task<ModificationResult> TechnicalCancelAsync(TechnicalCancelRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = request.ToJson();
            return await _technicalCancel.RequestAsync<ModificationResult>(jsonRequest, requestOptions);
        }

        public ModificationResult TechnicalCancel(TechnicalCancelRequest request, RequestOptions requestOptions = null)
        {
            return TechnicalCancelAsync(request, requestOptions).GetAwaiter().GetResult();
        }
        
        public async Task<ModificationResult> DonateAsync(DonationRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = request.ToJson();
            return await _donate.RequestAsync<ModificationResult>(jsonRequest, requestOptions);
        }

        public ModificationResult Donate(DonationRequest request, RequestOptions requestOptions = null)
        {
            return DonateAsync(request, requestOptions).GetAwaiter().GetResult();
        }
        #endregion
    }
}
