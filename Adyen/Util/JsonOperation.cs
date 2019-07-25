using Newtonsoft.Json;

namespace Adyen.Util
{
    public class JsonOperation
    {
        /// <summary>
        /// Deserialize to an object T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public static T Deserialize<T>(string request)
        {
            var jsonSettings = new JsonSerializerSettings();
            jsonSettings.Converters.Add(new ByteArrayConverter());
            return JsonConvert.DeserializeObject<T>(request, jsonSettings);
        }

        /// <summary>
        /// Deseralize to a dynamic object
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static dynamic Deserialize(string request)
        {
            return JsonConvert.DeserializeObject(request);
        }

        public static string SerializeRequest(object request)
        {
            var jsonSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Include,
            };
            jsonSettings.Converters.Add(new ByteArrayConverter());
            return JsonConvert.SerializeObject(request, Newtonsoft.Json.Formatting.None, jsonSettings);
        }
    }
}
