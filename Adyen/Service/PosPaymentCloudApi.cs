using System;
using System.Threading.Tasks;
using Adyen.Model.TerminalApi;

namespace Adyen.Service
{
    public class PosPaymentCloudApi : AbstractService, IPosPaymentCloudApi
    {
        private readonly TerminalCloudApi _terminalCloudApi;
        
        [Obsolete("This in person payment class is deprecated and will be removed in the next major, please refer to TerminalCloudApi.cs")]
        public PosPaymentCloudApi(Client client)
            : base(client)
        {
            _terminalCloudApi = new TerminalCloudApi(client);
        }

        /// <summary>
        /// CloudApi asynchronous call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <returns></returns>
        [Obsolete("This in person payment class is deprecated and will be removed in the next major, please refer to TerminalCloudApi.cs")]
        public SaleToPOIResponse TerminalApiCloudAsync(SaleToPOIMessage saleToPoiRequest)
        {
            return _terminalCloudApi.TerminalRequestAsync(saleToPoiRequest);
        }

        /// <summary>
        /// CloudApi synchronous call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <returns></returns>
        [Obsolete("This in person payment class is deprecated and will be removed in the next major, please refer to TerminalCloudApi.cs")]
        public SaleToPOIResponse TerminalApiCloudSync(SaleToPOIMessage saleToPoiRequest)
        {
            return _terminalCloudApi.TerminalRequestSync(saleToPoiRequest);
        }

        /// <summary>
        ///  Task async CloudApi asynchronous call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <returns></returns>
        [Obsolete("This in person payment class is deprecated and will be removed in the next major, please refer to TerminalCloudApi.cs")]
        public async Task<SaleToPOIResponse> TerminalApiCloudAsynchronousAsync(SaleToPOIMessage saleToPoiRequest)
        {
            return await _terminalCloudApi.TerminalRequestAsynchronousAsync(saleToPoiRequest);
        }

        /// <summary>
        ///  Task async CloudApi synchronous call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <returns></returns>
        [Obsolete("This in person payment class is deprecated and will be removed in the next major, please refer to TerminalCloudApi.cs")]
        public async Task<SaleToPOIResponse> TerminalApiCloudSynchronousAsync(SaleToPOIMessage saleToPoiRequest)
        {
            return await _terminalCloudApi.TerminalRequestSynchronousAsync(saleToPoiRequest);
        }
    }
}
