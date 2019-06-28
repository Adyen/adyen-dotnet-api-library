using Adyen.CloudApiSerialization;
using Adyen.Model.Nexo;
using Adyen.Model.Nexo.Message;

namespace Adyen.Security
{
    public class SaleToPoiMessageSecured
    {
        public MessageHeader MessageHeader { get; set; }

        public string NexoBlob { get; set; }

        public SecurityTrailer SecurityTrailer { get; set; }
    }
}
