using Newtonsoft.Json;

namespace Adyen.CloudApiSerialization.Converter
{
    internal class JSonConvertDeserializerWrapper<T>
    {
        internal static T DeserializeObject(string objectToDeserialize)
        {
            return JsonConvert.DeserializeObject<T>(objectToDeserialize);
        }
    }
}
