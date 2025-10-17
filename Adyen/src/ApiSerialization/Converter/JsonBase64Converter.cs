﻿using System;
using Newtonsoft.Json;

namespace Adyen.ApiSerialization.Converter
{
    internal class JsonBase64Converter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return System.Text.Encoding.UTF8.GetString((Convert.FromBase64String((string)reader.Value)));
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var json = JsonConvert.SerializeObject(value, Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });

            writer.WriteValue(Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(json)));
        }
    }
}
