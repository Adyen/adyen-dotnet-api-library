using Newtonsoft.Json;

namespace Adyen.Util
{
    public class JsonOperation
    {
        /// <summary>
        /// Deserialize to an object T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="response"></param>
        /// <returns></returns>
        public static T Deserialize<T>(string response)
        {
            var jsonSettings = new JsonSerializerSettings();
            jsonSettings.Converters.Add(new ByteArrayConverter());

            return JsonConvert.DeserializeObject<T>(response, jsonSettings);
        }
        
        public static string SerializeRequest(object request)
        {
            var jsonSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Include,
            };
            jsonSettings.Converters.Add(new ByteArrayConverter());
            return JsonConvert.SerializeObject(request, Formatting.None, jsonSettings);
        }
    }
}
