using Newtonsoft.Json;

namespace Adyen.EcommLibrary.Util
{
    public class JsonOperation
    {
        /// <summary>
        /// Deserialize to an object T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public static T Deserealize<T>(string request)
        {
            return JsonConvert.DeserializeObject<T>(request);
        }

        /// <summary>
        /// Deseralize to a dynamic object
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static dynamic Deserealize(string request)
        {
            return JsonConvert.DeserializeObject(request);
        }

        public static string SerializeRequest(object request)
        {
            return JsonConvert.SerializeObject(request, Newtonsoft.Json.Formatting.None,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                });
        }
    }
}
