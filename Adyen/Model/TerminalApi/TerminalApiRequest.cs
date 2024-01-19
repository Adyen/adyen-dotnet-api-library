using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.TerminalApi
{
    public class TerminalApiRequest
    {
        [JsonProperty("SaleToPOIRequest")]
        public SaleToPOIRequest SaleToPOIRequest { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TerminalApiRequest {\n");
            try
            {
                sb.Append("    SaleToPOIRequest: ").Append(JsonConvert.SerializeObject(this, Formatting.Indented)).Append("\n");
            }
            catch (JsonException e)
            {
                sb.Append("Error: Could not serialize SaleToPOIRequest");
            }
            sb.Append("}");
            return sb.ToString();
        }

        public static TerminalApiRequest FromJson(string jsonString)
        {
            return JsonConvert.DeserializeObject<TerminalApiRequest>(jsonString);
        }

        public string ToJson()
        {
            return Util.JsonOperation.SerializeRequest(this);
        }
    }
}