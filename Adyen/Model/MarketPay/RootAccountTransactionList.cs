using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.Model.MarketPay
{
    [DataContract]
    public class RootAccountTransactionList
    {
        [JsonProperty]
        public AccountTransactionList AccountTransactionList { get; set; }
    }
}
