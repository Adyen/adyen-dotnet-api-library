namespace Adyen.Model.Terminal
{
    public class SplitItemType
    {
        /// <summary>
        /// BalanceAccount: books the sale amount to the specified balance account.
        /// </summary>
        public static readonly string BalanceAccount = "BalanceAccount";
        
        /// <summary>
        /// Commission: books the amount to your liable balance account.
        /// </summary>
        public static readonly string Commission = "Commission";   
        
        /// <summary>
        /// Tip: books the tip to the specified balance account.
        /// https://docs.adyen.com/platforms/in-person-payments/tipping/
        /// </summary>
        public static readonly string Tip = "Tip";   
        
        /// <summary>
        /// Surcharge: books the surcharge to the specified balance account.
        /// https://docs.adyen.com/platforms/in-person-payments/surcharge/
        /// </summary>
        public static readonly string Surcharge = "Surcharge";

        
        /// <summary>
        /// MarketPlace: a type of MarketPlace books the amount to the account specified.
        /// </summary>
        public static readonly string MarketPlace = "MarketPlace";

        /// <summary>
        /// VAT: books the sale amount to the specified balance account.
        /// </summary>
        public static readonly string VAT = "VAT";

        /// <summary>
        /// Include at least one transaction fee type in your request: https://docs.adyen.com/platforms/in-person-payments/transaction-fees/.
        /// All undefined transaction fees are booked to your platform's liable balance account.
        /// AdyenCommission: the transaction fee due to Adyen under blended rates.
        /// </summary>
        public static readonly string AdyenCommission = "AdyenCommission";
        
        /// <summary>
        /// Include at least one transaction fee type in your request: https://docs.adyen.com/platforms/in-person-payments/transaction-fees/.
        /// All undefined transaction fees are booked to your platform's liable balance account.
        /// AdyenMarkup: the transaction fee due to Adyen under Interchange ++ pricing.
        /// </summary>
        public static readonly string AdyenMarkup = "AdyenMarkup";

        /// <summary>
        /// Include at least one transaction fee type in your request: https://docs.adyen.com/platforms/in-person-payments/transaction-fees/.
        /// All undefined transaction fees are booked to your platform's liable balance account.
        /// Interchange: the fee paid to the issuer for each payment made with the card network.
        /// </summary>
        public static readonly string Interchange = "Interchange";

        /// <summary>
        /// Include at least one transaction fee type in your request: https://docs.adyen.com/platforms/in-person-payments/transaction-fees/.
        /// All undefined transaction fees are booked to your platform's liable balance account.
        /// SchemeFee: the fee paid to the card scheme for using their network.
        /// </summary>
        public static readonly string SchemeFee = "SchemeFee";

        /// <summary>
        /// Include at least one transaction fee type in your request: https://docs.adyen.com/platforms/in-person-payments/transaction-fees/.
        /// All undefined transaction fees are booked to your platform's liable balance account.
        /// AdyenFees: the aggregated amount of Adyen's commission and markup fees.
        /// </summary>
        public static readonly string AdyenFees = "AdyenFees";

        /// <summary>
        /// Include at least one transaction fee type in your request: https://docs.adyen.com/platforms/in-person-payments/transaction-fees/.
        /// All undefined transaction fees are booked to your platform's liable balance account.
        /// AcquiringFees: the aggregated amount of the interchange and scheme fees.
        /// </summary>
        public static readonly string AcquiringFees = "AcquiringFees";

        /// <summary>
        /// Include at least one transaction fee type in your request: https://docs.adyen.com/platforms/in-person-payments/transaction-fees/.
        /// All undefined transaction fees are booked to your platform's liable balance account.
        /// PaymentFee: the aggregated amount of all transaction fees.
        /// </summary>
        public static readonly string PaymentFee = "PaymentFee";
    }
}