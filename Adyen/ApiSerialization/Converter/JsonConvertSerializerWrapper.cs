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

        private static readonly JsonSerializerSettings SaleToPoiMessageSerializerSettings = CreateSerializerSettings(new SaleToPoiMessageConverter());
        private static readonly JsonSerializerSettings SaleToPoiMessageSecuredSerializerSettings = CreateSerializerSettings(new SaleToPoiMessageSecuredConverter());

        internal static string Serialize(SaleToPOIMessage saleToPoiMessage)
        {
            return JsonConvert.SerializeObject(saleToPoiMessage, SaleToPoiMessageSerializerSettings);
        }

        internal static string Serialize(SaleToPoiMessageSecured saleToPoiMessageSecured)
        {
            return JsonConvert.SerializeObject(saleToPoiMessageSecured, SaleToPoiMessageSecuredSerializerSettings);
        }

        private static JsonSerializerSettings CreateSerializerSettings(JsonConverter messageConverter)
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
