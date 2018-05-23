using Adyen.EcommLibrary.Model.Nexo;

namespace Adyen.EcommLibrary.Test
{
    internal class PaymentRequestGenerator
    {
        internal SaleToPOIRequest CreatePaymentRequest()
        {
            var saleToPoiRequest = new SaleToPOIRequest()
            {
                MessageHeader = new MessageHeaderType()
                {
                    
                },
                SecurityTrailer = new ContentInformationType()

            };

            return saleToPoiRequest;
        }
    }
}
