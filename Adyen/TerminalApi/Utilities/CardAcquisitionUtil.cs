using System;
using Newtonsoft.Json;

namespace Adyen.Util.TerminalApi
{
    public static class CardAcquisitionUtil
    {
        public static AdditionalResponse AdditionalResponse(string input)
        {
            if (IsBase64String(input))
            {
                var base64Bytes = Convert.FromBase64String(input);

                // Convert byte array to string (assuming it was originally UTF-8 encoded)
                input = System.Text.Encoding.UTF8.GetString(base64Bytes);
            }
            return JsonConvert.DeserializeObject<AdditionalResponse>(input);
        }

        private static bool IsBase64String(string input)
        {
            try
            {
                var fromBase64String = Convert.FromBase64String(input);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}