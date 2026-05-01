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
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Webhooks.Models
{
    public class NotificationRequestItem
    {
        [JsonPropertyName("amount")]
        [Newtonsoft.Json.JsonProperty("amount")]
        public Amount Amount { get; set; }

        [JsonPropertyName("eventCode")]
        [Newtonsoft.Json.JsonProperty("eventCode")]
        public string EventCode { get; set; }

        [JsonPropertyName("eventDate")]
        [Newtonsoft.Json.JsonProperty("eventDate")]
        public string EventDate { get; set; }

        [JsonPropertyName("merchantAccountCode")]
        [Newtonsoft.Json.JsonProperty("merchantAccountCode")]
        public string MerchantAccountCode { get; set; }

        [JsonPropertyName("merchantReference")]
        [Newtonsoft.Json.JsonProperty("merchantReference")]
        public string MerchantReference { get; set; }

        [JsonPropertyName("originalReference")]
        [Newtonsoft.Json.JsonProperty("originalReference")]
        public string OriginalReference { get; set; }

        [JsonPropertyName("pspReference")]
        [Newtonsoft.Json.JsonProperty("pspReference")]
        public string PspReference { get; set; }

        [JsonPropertyName("reason")]
        [Newtonsoft.Json.JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonPropertyName("success")]
        [Newtonsoft.Json.JsonProperty("success")]
        [JsonConverter(typeof(BooleanFromStringJsonConverter))]
        [Newtonsoft.Json.JsonConverter(typeof(NewtonsoftBooleanFromStringConverter))]
        public bool Success { get; set; }

        [JsonPropertyName("paymentMethod")]
        [Newtonsoft.Json.JsonProperty("paymentMethod")]
        public string PaymentMethod { get; set; }

        [JsonPropertyName("operations")]
        [Newtonsoft.Json.JsonProperty("operations")]
        public List<string> Operations { get; set; }

        [JsonPropertyName("additionalData")]
        [Newtonsoft.Json.JsonProperty("additionalData")]
        public Dictionary<string, string> AdditionalData { get; set; }
    }

    internal class BooleanFromStringJsonConverter : JsonConverter<bool>
    {
        public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.True)
                return true;

            if (reader.TokenType == JsonTokenType.False)
                return false;

            if (reader.TokenType == JsonTokenType.String)
            {
                var value = reader.GetString();
                if (bool.TryParse(value, out bool boolValue))
                    return boolValue;
            }

            throw new JsonException("Unable to convert the webhook success value to boolean.");
        }

        public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options)
        {
            writer.WriteBooleanValue(value);
        }
    }

    internal class NewtonsoftBooleanFromStringConverter : Newtonsoft.Json.JsonConverter<bool>
    {
        public override bool ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, bool existingValue,
            bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            if (reader.TokenType == Newtonsoft.Json.JsonToken.Boolean)
                return (bool)reader.Value;

            if (reader.TokenType == Newtonsoft.Json.JsonToken.String &&
                bool.TryParse((string)reader.Value, out bool result))
                return result;

            throw new Newtonsoft.Json.JsonSerializationException(
                $"Unable to convert the webhook success value '{reader.Value}' to boolean.");
        }

        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, bool value,
            Newtonsoft.Json.JsonSerializer serializer) => writer.WriteValue(value);
    }
}
