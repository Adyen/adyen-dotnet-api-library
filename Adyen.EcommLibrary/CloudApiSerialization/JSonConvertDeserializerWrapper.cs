using Adyen.EcommLibrary.Exceptions;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Adyen.EcommLibrary.CloudApiSerialization
{

    internal class JSonConvertDeserializerWrapper<T>
    {
        internal static T DeserializeObject(string objectToDeserialize)
        {
            return JsonConvert.DeserializeObject<T>(objectToDeserialize, new JsonSerializerSettings
            {
                MissingMemberHandling = MissingMemberHandling.Error,
                Error = delegate (object sender, ErrorEventArgs args)
                {
                    var exceptionMessage = string.Format(ExceptionMessages.ExceptionDuringDeserialization,
                        objectToDeserialize,
                        args.ErrorContext.Error.Message);

                    throw new DeserializationException(exceptionMessage, args.ErrorContext.Error);
                }
            });
        }
    }
}
