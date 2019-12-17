using Adyen.Model.ApplicationInformation;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace Adyen.Model.Terminal
{
    public class SaleToAcquirerData
    {
        public Dictionary<string, string> Metadata { get; set; }
        public string ShopperEmail { get; set; }
        public string ShopperReference { get; set; }
        public string RecurringContract { get; set; }
        public string ShopperStatement { get; set; }
        public string RecurringDetailName { get; set; }
        public string RecurringTokenService { get; set; }
        public string Store { get; set; }
        public string MerchantAccount { get; set; }
        public string Currency { get; set; }
        public ApplicationInfo ApplicationInfo { get; set; }

        public string TenderOption { get; set; }
        public Dictionary<string, string> AdditionalData { get; set; }


        public SaleToAcquirerData()
        {
            if (this.ApplicationInfo == null)
            {
                this.ApplicationInfo = new ApplicationInfo();
            }
        }

        public string ToBase64()
        {
            var json = this.ToJson();
            var bytes = System.Text.Encoding.UTF8.GetBytes(json);
            return System.Convert.ToBase64String(bytes);
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Company {\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  ShopperEmail: ").Append(ShopperEmail).Append("\n");
            sb.Append("  ShopperReference: ").Append(ShopperReference).Append("\n");
            sb.Append("  RecurringContract: ").Append(RecurringContract).Append("\n");
            sb.Append("  ShopperStatement: ").Append(ShopperStatement).Append("\n");
            sb.Append("  RecurringDetailName: ").Append(RecurringDetailName).Append("\n");
            sb.Append("  RecurringTokenService: ").Append(RecurringTokenService).Append("\n");
            sb.Append("  Store: ").Append(Store).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  ApplicationInfo: ").Append(ApplicationInfo).Append("\n");
            sb.Append("  TenderOption: ").Append(Currency).Append("\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SaleToAcquirerData);
        }
    }
}
