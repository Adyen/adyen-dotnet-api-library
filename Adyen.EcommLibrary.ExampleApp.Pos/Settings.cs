namespace Adyen.EcommLibrary.ExampleApp.Pos
{
    internal class Settings
    {
        public static string MerchantAccount = "Your merchant account";
        public static string XapiKey = @"AQEshmf...Hsrujn88Z434Ae";
        public static string TerminalId = "P400Plus-123456789";

        //Local encryption details
        public static string KeyIdentifier = "KeyIdentifierSetInCA";
        public static string Password = "passwordSetInCA";
        public static int KeyVersion = 1;
        public static int AdyenCryptoVersion = 1;
    }
}
