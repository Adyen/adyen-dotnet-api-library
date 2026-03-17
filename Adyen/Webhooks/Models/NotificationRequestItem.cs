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
        public Amount Amount { get; set; }
        public string EventCode { get; set; }
        public string EventDate { get; set; }
        public string MerchantAccountCode  { get; set; }
        public string MerchantReference { get; set; }
        public string OriginalReference { get; set; }
        public string PspReference { get; set; }
        public string Reason { get; set; }
        [JsonConverter(typeof(BooleanFromStringJsonConverter))]
        public bool Success { get; set; }
        public string PaymentMethod { get; set; }
        public List<string> Operations { get; set; }
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
}
