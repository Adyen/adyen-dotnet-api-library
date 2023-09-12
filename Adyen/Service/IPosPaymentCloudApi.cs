using System.Threading.Tasks;
using Adyen.Model.TerminalApi;

namespace Adyen.Service
{
    public interface IPosPaymentCloudApi
    {
        /// <summary>
        /// CloudApi asynchronous call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <returns></returns>
        SaleToPOIResponse TerminalApiCloudAsync(SaleToPOIMessage saleToPoiRequest);

        /// <summary>
        /// CloudApi synchronous call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <returns></returns>
        SaleToPOIResponse TerminalApiCloudSync(SaleToPOIMessage saleToPoiRequest);

        /// <summary>
        ///  Task async CloudApi asynchronous call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <returns></returns>
        Task<SaleToPOIResponse> TerminalApiCloudAsynchronousAsync(SaleToPOIMessage saleToPoiRequest);

        /// <summary>
        ///  Task async CloudApi synchronous call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <returns></returns>
        Task<SaleToPOIResponse> TerminalApiCloudSynchronousAsync(SaleToPOIMessage saleToPoiRequest);
    }
}