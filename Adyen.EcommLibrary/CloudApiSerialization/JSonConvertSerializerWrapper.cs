using Adyen.EcommLibrary.Model.Nexo;
using Adyen.EcommLibrary.Security;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.EcommLibrary.CloudApiSerialization
{
    internal class JSonConvertSerializerWrapper
    {
        private const string DateTimeFormat = "yyyy-MM-ddTHH:mm:ss";

        internal static string Serialize(SaleToPOIMessage saleToPoiMessage)
        {
            return JsonConvert.SerializeObject(saleToPoiMessage,
               
                new StringEnumConverter(),
                new IsoDateTimeConverter() { DateTimeFormat = DateTimeFormat });
        }

        internal static string Serialize(SaleToPoiMessageSecured saleToPoiMessageSecured)
        {
            return JsonConvert.SerializeObject(saleToPoiMessageSecured,
                
                new StringEnumConverter(),
                new IsoDateTimeConverter() { DateTimeFormat = DateTimeFormat });
        }
    }
}
