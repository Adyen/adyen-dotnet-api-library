using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Terminal
{
    public class Split
    {
        [JsonProperty(PropertyName = "api")]
        public int Api { get; set; }
    
        [JsonProperty(PropertyName = "nrOfItems")]
        public int NrOfItems { get; set; }

        [JsonProperty(PropertyName = "totalAmount")]
        public int TotalAmount { get; set; }

        [JsonProperty(PropertyName = "currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty(PropertyName = "item1")]
        public SplitItem Item1 { get; set; }

        [JsonProperty(PropertyName = "item2")]
        public SplitItem Item2 { get; set; }
        
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Split {\n");
            sb.Append("  Api: ").Append(Api).Append("\n");
            sb.Append("  NrOfItems: ").Append(NrOfItems).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Item1: ").Append(Item1).Append("\n");
            sb.Append("  Item2: ").Append(Item2).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}