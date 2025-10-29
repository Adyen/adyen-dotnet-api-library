using Newtonsoft.Json;

namespace Adyen.ApiSerialization.Converter
{
    internal class JsonConvertDeserializerWrapper<T>
    {
        internal static T DeserializeObject(string objectToDeserialize)
        {
            return JsonConvert.DeserializeObject<T>(objectToDeserialize);
        }
    }
}
