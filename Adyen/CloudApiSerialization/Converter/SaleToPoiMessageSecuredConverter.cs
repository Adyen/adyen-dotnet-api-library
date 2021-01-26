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
using Adyen.Model.Nexo.Message;
using Adyen.Security;
using Newtonsoft.Json;

namespace Adyen.CloudApiSerialization.Converter
{
    internal class SaleToPoiMessageSecuredConverter : JsonConverter
    {
        private const string SaleToPoiRequestSecuredForSerialization = "SaleToPOIRequest";
        private const string SaleToPoiResponseSecuredForSerialization = "SaleToPOIResponse";
        private const string NexoBlob = "NexoBlob";

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.NullValueHandling = NullValueHandling.Ignore;

            writer.WriteStartObject();
            writer.WritePropertyName(GetProperTypeNameForSerialization(value.GetType()));

            writer.WriteStartObject();

            var saleToPoiMessageSecured = value as SaleToPoiMessageSecured;

            writer.WritePropertyName(saleToPoiMessageSecured.MessageHeader.GetType().Name);
            serializer.Serialize(writer, saleToPoiMessageSecured.MessageHeader);

            writer.WritePropertyName(NexoBlob);
            serializer.Serialize(writer, saleToPoiMessageSecured.NexoBlob);

            writer.WritePropertyName(saleToPoiMessageSecured.SecurityTrailer.GetType().Name);
            serializer.Serialize(writer, saleToPoiMessageSecured.SecurityTrailer);

            writer.WriteEndObject();

            writer.WriteEndObject();
        }

        private string GetProperTypeNameForSerialization(Type type)
        {
            if (type == typeof(SaleToPOIMessage) || type == typeof(SaleToPoiRequestSecured))
            {
                return SaleToPoiRequestSecuredForSerialization;
            }

            if (type == typeof(SaleToPOIResponse) || type == typeof(SaleToPoiResponseSecured))
            {
                return SaleToPoiResponseSecuredForSerialization;
            }

            return string.Empty;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(SaleToPoiMessageSecured).IsAssignableFrom(objectType);
        }
    }
}