﻿using Adyen.Model.Nexo;
using Adyen.Security;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.CloudApiSerialization.Converter
{
    internal class JSonConvertSerializerWrapper
    {
        private const string DateTimeFormat = "yyyy-MM-ddTHH\\:mm\\:ss";

        internal static string Serialize(SaleToPOIMessage saleToPoiMessage)
        {
            var serialize= JsonConvert.SerializeObject(saleToPoiMessage,
                new SaleToPoiMessageConverter(),
                new StringEnumConverter(),
                new IsoDateTimeConverter() { DateTimeFormat = DateTimeFormat });
            return serialize;
        }

        internal static string Serialize(SaleToPoiMessageSecured saleToPoiMessageSecured)
        {
            return JsonConvert.SerializeObject(saleToPoiMessageSecured,
                                               new SaleToPoiMessageSecuredConverter(),
                                               new StringEnumConverter(),
                                               new IsoDateTimeConverter() { DateTimeFormat = DateTimeFormat });
        }
    }
}
