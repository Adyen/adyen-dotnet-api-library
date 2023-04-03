using Adyen.Model.Nexo;

namespace Adyen.Security
{
    public class SaleToPoiMessageSecured
    {
        public MessageHeader MessageHeader { get; set; }

        public string NexoBlob { get; set; }

        public SecurityTrailer SecurityTrailer { get; set; }
    }
}
