using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.TerminalApi
{
    public class TerminalApiResponse
    {
        [JsonProperty("SaleToPOIRequest")] public SaleToPOIRequest SaleToPOIRequest { get; set; }

        [JsonProperty("SaleToPOIResponse")] public SaleToPOIResponse SaleToPOIResponse { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TerminalApiResponse {\n");
            try
            {
                sb.Append("    SaleToPOIRequest: ").Append(JsonConvert.SerializeObject(this, Formatting.Indented))
                    .Append("\n");
                sb.Append("    SaleToPOIResponse: ").Append(JsonConvert.SerializeObject(this, Formatting.Indented))
                    .Append("\n");
            }
            catch (JsonException e)
            {
                sb.Append("Error: Could not serialize TerminalApiResponse");
            }

            sb.Append("}");
            return sb.ToString();
        }

        public static TerminalApiResponse FromJson(string jsonString)
        {
            return JsonConvert.DeserializeObject<TerminalApiResponse>(jsonString);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}