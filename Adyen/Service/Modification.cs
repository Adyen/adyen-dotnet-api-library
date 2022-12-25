﻿#region License
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

using System.Threading.Tasks;
using Adyen.Model;
using Adyen.Model.Payments;
using Adyen.Service.Resource;
using Newtonsoft.Json;
using AdjustAuthorisationRequest = Adyen.Model.Modification.AdjustAuthorisationRequest;
using CancelOrRefundRequest = Adyen.Model.Modification.CancelOrRefundRequest;
using CancelRequest = Adyen.Model.Modification.CancelRequest;
using CaptureRequest = Adyen.Model.Modification.CaptureRequest;
using ModificationResult = Adyen.Model.Modification.ModificationResult;
using RefundRequest = Adyen.Model.Modification.RefundRequest;
using VoidPendingRefundRequest = Adyen.Model.Modification.VoidPendingRefundRequest;

namespace Adyen.Service
{
    public class Modification : AbstractService
    {
        private readonly PaymentResource _capture;
        private readonly PaymentResource _cancelOrRefund;
        private readonly PaymentResource _refund;
        private readonly PaymentResource _cancel;
        private readonly PaymentResource _adjustAuthorisation;
        private readonly PaymentResource _voidPendingRefund;
        private readonly PaymentResource _technicalCancel;
        private readonly PaymentResource _donate;

        public Modification(Client client)
            : base(client)
        {
            _capture = new PaymentResource(this, "/capture");
            _cancelOrRefund = new PaymentResource(this, "/cancelOrRefund");
            _refund = new PaymentResource(this, "/refund");
            _cancel = new PaymentResource(this, "/cancel");
            _adjustAuthorisation = new PaymentResource(this, "/adjustAuthorisation");
            _voidPendingRefund = new PaymentResource(this, "/voidPendingRefund");
            _technicalCancel = new PaymentResource(this, "/technicalCancel");
            _donate = new PaymentResource(this, "/donate");
        }

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
    }
}