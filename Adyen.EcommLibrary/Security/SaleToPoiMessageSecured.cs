using Adyen.EcommLibrary.Model.Nexo;
using Adyen.EcommLibrary.Model.Nexo.Message;

namespace Adyen.EcommLibrary.Security
{
    public class SaleToPoiMessageSecured
    {
        public MessageHeader MessageHeader { get; set; }

        public string NexoBlob { get; set; }

        public SecurityTrailer SecurityTrailer { get; set; }
    }
}
