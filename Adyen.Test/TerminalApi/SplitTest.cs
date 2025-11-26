using System.Collections.Generic;
using Adyen.Model.Terminal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace Adyen.Test.Terminal
{
    [TestClass]
    public class SplitTest
    {
        [TestMethod]
        public void SplitSerializationTest()
        {
            string splitJson =
                "{\"api\":1,\"nrOfItems\":3,\"totalAmount\":62000,\"currencyCode\":\"EUR\",\"items\":[{\"amount\":60000,\"type\":\"BalanceAccount\",\"account\":\"BA00000000000000000000001\",\"reference\":\"reference_split_1\",\"description\":\"description_split_1\"},{\"amount\":2000,\"type\":\"Commission\",\"account\":\"\",\"reference\":\"reference_commission\",\"description\":\"description_commission\"},{\"type\":\"PaymentFee\",\"account\":\"BA00000000000000000000001\",\"reference\":\"reference_PaymentFee\",\"description\":\"description_PaymentFee\"}]}";

            var splitItem1 = new SplitItem
            {
                Amount = 60000,
                Type = SplitItemType.BalanceAccount,
                Account = "BA00000000000000000000001",
                Reference = "reference_split_1",
                Description = "description_split_1"
            };

            var splitItem2 = new SplitItem
            {
                Amount = 2000,
                Type = SplitItemType.Commission,
                Account = "",
                Reference = "reference_commission",
                Description = "description_commission"
            };

            var splitItem3 = new SplitItem
            {
                Type = SplitItemType.PaymentFee,
                Account = "BA00000000000000000000001",
                Reference = "reference_PaymentFee",
                Description = "description_PaymentFee"
            };

            var split = new Split
            {
                Api = 1,
                TotalAmount = 62000,
                CurrencyCode = "EUR",
                NrOfItems = 3,
                Items = new List<SplitItem> { splitItem1, splitItem2, splitItem3 }
            };

            Split actual = JsonConvert.DeserializeObject<Split>(splitJson);

            Assert.AreEqual(split.Api, actual.Api);
            Assert.AreEqual(split.TotalAmount, actual.TotalAmount);
            Assert.AreEqual(split.CurrencyCode, actual.CurrencyCode);
            Assert.AreEqual(split.NrOfItems, actual.NrOfItems);
            Assert.AreEqual(split.Items.Count, actual.Items.Count);

            Assert.AreEqual(split.Items[0].Amount, actual.Items[0].Amount);
            Assert.AreEqual(split.Items[0].Type, actual.Items[0].Type);
            Assert.AreEqual(split.Items[0].Account, actual.Items[0].Account);
            Assert.AreEqual(split.Items[0].Reference, actual.Items[0].Reference);
            Assert.AreEqual(split.Items[0].Description, actual.Items[0].Description);

            Assert.AreEqual(split.Items[1].Amount, actual.Items[1].Amount);
            Assert.AreEqual(split.Items[1].Type, actual.Items[1].Type);
            Assert.AreEqual(split.Items[1].Account, actual.Items[1].Account);
            Assert.AreEqual(split.Items[1].Reference, actual.Items[1].Reference);
            Assert.AreEqual(split.Items[1].Description, actual.Items[1].Description);

            Assert.AreEqual(split.Items[2].Type, actual.Items[2].Type);
            Assert.AreEqual(split.Items[2].Account, actual.Items[2].Account);
            Assert.AreEqual(split.Items[2].Reference, actual.Items[2].Reference);
            Assert.AreEqual(split.Items[2].Description, actual.Items[2].Description);
        }
    }
}