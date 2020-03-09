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

        public Modification(Client clinet)
            : base(clinet)
        {
            _capture = new Capture(this);
            _cancelOrRefund = new CancelOrRefund(this);
            _refund = new Refund(this);
            _cancel = new Cancel(this);
            _adjustAuthorisation = new AdjustAuthorisation(this);
            _voidPendingRefund = new VoidPendingRefund(this);
        }
        
        public ModificationResult Capture(CaptureRequest request)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(request);
            var jsonResult = _capture.Request(jsonRequest);

            return Util.JsonOperation.Deserialize<ModificationResult>(jsonResult);
        }
        
        public ModificationResult CancelOrRefund(CancelOrRefundRequest request)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(request);
            var jsonResult = _cancelOrRefund.Request(jsonRequest);

            return Util.JsonOperation.Deserialize<ModificationResult>(jsonResult);
        }
        
        public ModificationResult Refund(RefundRequest request)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(request);
            var jsonResult = _refund.Request(jsonRequest);

            return Util.JsonOperation.Deserialize<ModificationResult>(jsonResult);
        }
        
        public ModificationResult Cancel(CancelRequest request)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(request);
            var jsonResult = _cancel.Request(jsonRequest);

            return Util.JsonOperation.Deserialize<ModificationResult>(jsonResult);
        }

        public ModificationResult AdjustAuthorisation(AdjustAuthorisationRequest request)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(request);
            var jsonResult = _adjustAuthorisation.Request(jsonRequest);

            return Util.JsonOperation.Deserialize<ModificationResult>(jsonResult);
        }

        public ModificationResult VoidPendingRefund(VoidPendingRefundRequest request)
        {
            return VoidPendingRefund(request, null);
        }

        public ModificationResult VoidPendingRefund(VoidPendingRefundRequest request, Model.RequestOptions requestOptions )
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(request);
            var jsonResult = _adjustAuthorisation.Request(jsonRequest, requestOptions);

            return Util.JsonOperation.Deserialize<ModificationResult>(jsonResult);
        }
    }
}
