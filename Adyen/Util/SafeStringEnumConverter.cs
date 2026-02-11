using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Util
{
    /// <summary>
    /// A custom JSON converter for enums that returns null for unknown values instead of throwing an exception.
    /// This ensures forward compatibility when new enum values are added to the API.
    /// </summary>
    public class SafeStringEnumConverter : StringEnumConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            try
            {
                return base.ReadJson(reader, objectType, existingValue, serializer);
            }
            catch (JsonSerializationException)
            {
                // If the enum value is unknown, return null for nullable enums
                // This allows the application to continue processing even when encountering unknown enum values
                if (Nullable.GetUnderlyingType(objectType) != null)
                {
                    return null;
                }
                
                // For non-nullable enums, we still throw to maintain backward compatibility
                throw;
            }
        }
    }
}
