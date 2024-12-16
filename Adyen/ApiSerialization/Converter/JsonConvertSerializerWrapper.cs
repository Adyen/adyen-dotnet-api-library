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
            var serialize = JsonConvert.SerializeObject(saleToPoiMessage,
                GetSerializerSettings(new SaleToPoiMessageConverter()));
            return serialize;
        }

        internal static string Serialize(SaleToPoiMessageSecured saleToPoiMessageSecured)
        {
            return JsonConvert.SerializeObject(saleToPoiMessageSecured,
                GetSerializerSettings(new SaleToPoiMessageSecuredConverter()));
        }

        private static JsonSerializerSettings GetSerializerSettings(JsonConverter messageConverter)
        {
            return new JsonSerializerSettings
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
            };
        }
    }
}
