using Adyen.EcommLibrary.Exceptions;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Adyen.EcommLibrary.CloudApiSerialization.Converter
{
    internal class JSonConvertDeserializerWrapper<T>
    {
        internal static T DeserializeObject(string objectToDeserialize)
        {
            return JsonConvert.DeserializeObject<T>(objectToDeserialize);
        }
    }
}
