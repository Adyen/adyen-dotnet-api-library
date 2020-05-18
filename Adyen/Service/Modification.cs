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
using Adyen.Model.Modification;
using Adyen.Service.Resource.Modification;

namespace Adyen.Service
{
    public class Modification : AbstractService
    {
        private readonly Capture _capture;
        private readonly CancelOrRefund _cancelOrRefund;
        private readonly Refund _refund;
        private readonly Cancel _cancel;
        private readonly AdjustAuthorisation _adjustAuthorisation;
        private readonly VoidPendingRefund _voidPendingRefund;

        public Modification(Client client)
            : base(client)
        {
            _capture = new Capture(this);
            _cancelOrRefund = new CancelOrRefund(this);
            _refund = new Refund(this);
            _cancel = new Cancel(this);
            _adjustAuthorisation = new AdjustAuthorisation(this);
            _voidPendingRefund = new VoidPendingRefund(this);
        }
        
        public ModificationResult Capture(CaptureRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(request);
            var jsonResult = _capture.Request(jsonRequest, requestOptions);

            return Util.JsonOperation.Deserialize<ModificationResult>(jsonResult);
        }
        
        public ModificationResult CancelOrRefund(CancelOrRefundRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(request);
            var jsonResult = _cancelOrRefund.Request(jsonRequest, requestOptions);

            return Util.JsonOperation.Deserialize<ModificationResult>(jsonResult);
        }
        
        public ModificationResult Refund(RefundRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(request);
            var jsonResult = _refund.Request(jsonRequest, requestOptions);

            return Util.JsonOperation.Deserialize<ModificationResult>(jsonResult);
        }
        
        public ModificationResult Cancel(CancelRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(request);
            var jsonResult = _cancel.Request(jsonRequest, requestOptions);

            return Util.JsonOperation.Deserialize<ModificationResult>(jsonResult);
        }

        public ModificationResult AdjustAuthorisation(AdjustAuthorisationRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(request);
            var jsonResult = _adjustAuthorisation.Request(jsonRequest, requestOptions);

            return Util.JsonOperation.Deserialize<ModificationResult>(jsonResult);
        }

        public ModificationResult VoidPendingRefund(VoidPendingRefundRequest request, RequestOptions requestOptions = null)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(request);
            var jsonResult = _voidPendingRefund.Request(jsonRequest, requestOptions);

            return Util.JsonOperation.Deserialize<ModificationResult>(jsonResult);
        }
    }
}