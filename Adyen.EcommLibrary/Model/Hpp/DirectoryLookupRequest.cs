namespace Adyen.EcommLibrary.Model.Hpp
{
    public class DirectoryLookupRequest
    {
        public string CurrencyCode { get; set; }
        public string PaymentAmount { get; set; }
        public string SessionValidity { get; set; }
        public string MerchantReference { get; set; }
        public string CountryCode { get; set; }
        public string SkinCode { get; set; }
        public string MerchantAccount { get; set; }
        public string HmacKey { get; set; }
        public string ShopperLocale { get; set; }
    }
}
