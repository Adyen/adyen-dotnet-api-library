#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using Adyen.Model.Nexo;
using Newtonsoft.Json;

namespace Adyen.ApiSerialization.Converter
{
    internal class SaleToPoiMessageConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.NullValueHandling = NullValueHandling.Ignore;
            serializer.MissingMemberHandling = MissingMemberHandling.Ignore;
            writer.WriteStartObject();
            writer.WritePropertyName(value.GetType().Name);
            writer.WriteStartObject();
            var saleToPoiMessage = value as SaleToPOIMessage;
            writer.WritePropertyName(saleToPoiMessage.MessageHeader.GetType().Name);
            serializer.Serialize(writer, saleToPoiMessage.MessageHeader);
            writer.WritePropertyName(saleToPoiMessage.MessagePayload.GetType().Name);
            serializer.Serialize(writer, saleToPoiMessage.MessagePayload);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(SaleToPOIMessage).IsAssignableFrom(objectType);
        }
    }
}
