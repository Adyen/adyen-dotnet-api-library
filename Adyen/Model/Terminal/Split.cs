using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Terminal
{
    /// <summary>
    /// To split a POS payment, you need to make a Terminal API call with this class..
    /// In the PaymentRequest you provide the split payment data in the SaleToAcquirerData, in key-value pair or Base64-encoded format.
    /// https://docs.adyen.com/classic-platforms/platforms-for-pos/#split-at-capture
    /// </summary>
    public class Split
    {
        [JsonProperty(PropertyName = "api")]
        public int Api { get; set; } = 1;
    
        [JsonProperty(PropertyName = "totalAmount")]
        public long TotalAmount { get; set; }
        
        [JsonProperty(PropertyName = "currencyCode")]
        public string CurrencyCode { get; set; }
        
        [JsonProperty(PropertyName = "nrOfItems")]
        public int NrOfItems { get; set; }
     
        [JsonProperty(PropertyName = "items")]
        public List<SplitItem> Items { get; set; }
        
        public static string ConvertToQueryString(Split split)
        {
            List<string> result = new List<string>();

            result.Add($"split.api={split.Api}");
            result.Add($"split.nrOfItems={split.NrOfItems}");
            result.Add($"split.totalAmount={split.TotalAmount}");
            result.Add($"split.currencyCode={split.CurrencyCode}");

            for (int i = 0; i < split.Items.Count; i++)
            {
                SplitItem item = split.Items[i];
                string itemPrefix = $"split.item{(i + 1)}";

                if (item.Amount.HasValue)
                {
                    result.Add($"{itemPrefix}.amount={item.Amount}");
                }

                result.Add($"{itemPrefix}.type={item.Type}");

                if (!string.IsNullOrEmpty(item.Account))
                {
                    result.Add($"{itemPrefix}.account={item.Account}");
                }

                if (!string.IsNullOrEmpty(item.Reference)) 
                {
                    result.Add($"{itemPrefix}.reference={item.Reference}");
                }

                if (!string.IsNullOrEmpty(item.Description)) 
                {
                    result.Add($"{itemPrefix}.description={item.Description}");
                }
            }

            return string.Join("&", result);
        }
        
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Split {\n");
            sb.Append("  Api: ").Append(Api).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  NrOfItems: ").Append(NrOfItems).Append("\n");
            sb.Append("  Items: [\n").Append(string.Join("\n", Items?.Select(item => " " + item) ?? Enumerable.Empty<string>()));
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}