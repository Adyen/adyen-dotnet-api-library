#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion
using Adyen.Model.ApplicationInformation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adyen.Model.Terminal
{
    public class SaleToAcquirerData
    {
        [JsonProperty(PropertyName = "metadata")]
        public SortedDictionary<string, string> Metadata { get; set; }
        [JsonProperty(PropertyName = "shopperEmail")]
        public string ShopperEmail { get; set; }
        [JsonProperty(PropertyName = "shopperReference")]
        public string ShopperReference { get; set; }
        [JsonProperty(PropertyName = "recurringProcessingModel")]
        public string RecurringProcessingModel { get; set; }
        [JsonProperty(PropertyName = "recurringContract")]
        public string RecurringContract { get; set; }
        [JsonProperty(PropertyName = "shopperStatement")]
        public string ShopperStatement { get; set; }
        [JsonProperty(PropertyName = "recurringDetailName")]
        public string RecurringDetailName { get; set; }
        [JsonProperty(PropertyName = "recurringTokenService")]
        public string RecurringTokenService { get; set; }
        [JsonProperty(PropertyName = "store")]
        public string Store { get; set; }
        [JsonProperty(PropertyName = "scc")]
        public string Ssc { get; set; }
        [JsonProperty(PropertyName = "merchantAccount")]
        public string MerchantAccount { get; set; }
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }
        [JsonProperty(PropertyName = "applicationInfo")]
        public ApplicationInfo ApplicationInfo { get; set; }
        [JsonProperty(PropertyName = "tenderOption")]
        public string TenderOption { get; set; }
        [JsonProperty(PropertyName = "authorisationType")]
        public string AuthorisationType { get; set; }
        [JsonProperty(PropertyName = "additionalData")]
        public Dictionary<string, string> AdditionalData { get; set; }

        public SaleToAcquirerData()
        {
            if (this.ApplicationInfo == null)
            {
                this.ApplicationInfo = new ApplicationInfo();
            }
        }

        public Dictionary<string, string> AddSplitToAdditionalData(Split split)
        {
            if (AdditionalData == null)
            {
                AdditionalData = new Dictionary<string, string>();
            }
            
            AdditionalData.Add($"split.api", split.Api.ToString());
            AdditionalData.Add($"split.nrOfItems", split.NrOfItems.ToString());
            AdditionalData.Add($"split.totalAmount", split.TotalAmount.ToString());
            AdditionalData.Add($"split.currencyCode", split.CurrencyCode);

            for (int i = 0; i < split.Items.Count; i++)
            {
                SplitItem item = split.Items[i];
                string itemPrefix = $"split.item{(i + 1)}";

                if (item.Amount.HasValue)
                {
                    AdditionalData.Add($"{itemPrefix}.amount", item.Amount.ToString());
                }

                AdditionalData.Add($"{itemPrefix}.type", item.Type);

                if (!string.IsNullOrEmpty(item.Account))
                {
                    AdditionalData.Add($"{itemPrefix}.account", item.Account);
                }

                if (!string.IsNullOrEmpty(item.Reference)) 
                {
                    AdditionalData.Add($"{itemPrefix}.reference", item.Reference);
                }

                if (!string.IsNullOrEmpty(item.Description)) 
                {
                    AdditionalData.Add($"{itemPrefix}.description", item.Description);
                }
            }

            return AdditionalData;
        }

        public string ToBase64()
        {
            var json = JsonConvert.SerializeObject(this);
            return Convert.ToBase64String(Encoding.UTF8.GetBytes((string)json));
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaleToAcquirerData {\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  ShopperEmail: ").Append(ShopperEmail).Append("\n");
            sb.Append("  ShopperReference: ").Append(ShopperReference).Append("\n");
            sb.Append("  RecurringContract: ").Append(RecurringContract).Append("\n");
            sb.Append("  RecurringProcessingModel: ").Append(RecurringProcessingModel).Append("\n");
            sb.Append("  ShopperStatement: ").Append(ShopperStatement).Append("\n");
            sb.Append("  RecurringDetailName: ").Append(RecurringDetailName).Append("\n");
            sb.Append("  RecurringTokenService: ").Append(RecurringTokenService).Append("\n");
            sb.Append("  Store: ").Append(Store).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  ApplicationInfo: ").Append(ApplicationInfo).Append("\n");
            sb.Append("  TenderOption: ").Append(TenderOption).Append("\n");
            sb.Append("  AuthorisationType: ").Append(AuthorisationType).Append("\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
