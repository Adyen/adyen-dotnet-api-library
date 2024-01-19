using Adyen.Model.Terminal;
using Newtonsoft.Json;

namespace Adyen.Security
{
    public class SaleToPoiMessageSecured
    {
        public MessageHeader MessageHeader { get; set; }

        public string NexoBlob { get; set; }

        public SecurityTrailer SecurityTrailer { get; set; }
        
        public static SaleToPoiMessageSecured FromJson(string jsonString)
        {
            return JsonConvert.DeserializeObject<SaleToPoiMessageSecured>(jsonString);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
