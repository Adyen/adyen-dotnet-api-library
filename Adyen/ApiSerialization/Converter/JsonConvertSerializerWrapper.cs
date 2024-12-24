using System.Collections.Generic;
using Adyen.Model.TerminalApi;
using Adyen.Security;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Adyen.ApiSerialization.Converter
{
    internal class JsonConvertSerializerWrapper
    {
        private const string DateTimeFormat = "yyyy-MM-ddTHH\\:mm\\:ss";

        internal static string Serialize(SaleToPOIMessage saleToPoiMessage)
        {
            return Serialize(saleToPoiMessage, new SaleToPoiMessageConverter());
        }

        internal static string Serialize(SaleToPoiMessageSecured saleToPoiMessageSecured)
        {
            return Serialize(saleToPoiMessageSecured, new SaleToPoiMessageSecuredConverter());
        }

        private static string Serialize(object message, JsonConverter messageConverter)
        {
            return JsonConvert.SerializeObject(message,
                new JsonSerializerSettings
                {
                    Converters = new List<JsonConverter>
                    {
                        messageConverter,
                        new StringEnumConverter(),
                        new IsoDateTimeConverter { DateTimeFormat = DateTimeFormat }
                    },
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore,
                    ContractResolver = new DefaultContractResolver()
                });
        }
    }
}
