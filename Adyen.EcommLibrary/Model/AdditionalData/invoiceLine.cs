using Adyen.EcommLibrary.Model.Enum;

namespace Adyen.EcommLibrary.Model.AdditionalData
{
    public class InvoiceLine
    {
        public long VatAmount { get; set; }
        public string CurrencyCode { get; set; }
        public string Description { get; set; }
        public long ItemAmount { get; set; }
        public long ItemVatAmount { get; set; }
        public long ItemVatPercentage { get; set; }
        public int NumberOfItems { get; set; }
        public VatCategory VatCategory { get; set; }
        public string ItemId { get; set; }
    }
}
