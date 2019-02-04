using Adyen.EcommLibrary.Security;
using Adyen.EcommLibrary.Service;
using System;

namespace Adyen.EcommLibrary.ExampleApp.Pos
{
    /// <summary>
    /// More info for pos integration please refer https://docs.adyen.com/developers/point-of-sale
    /// </summary>
    class Program
    {
        private static string _messageCategory = "Payment";
        private static int _amount = 10;
        private static Client _client;
        private static PosPaymentCloudApi _posPaymentCloudApi;
        private static PosPaymentLocalApi _posPaymentLocalApi;
        private static SaleToPoiMessageSecuredEncryptor _messageSecuredEncryptor;
        private static EncryptionCredentialDetails _encryptionCredentialDetails;

        static void InitPosLibrary()
        {

            _client = new Client(Settings.XapiKey, EcommLibrary.Model.Enum.Environment.Test);
            _client.Config.Endpoint = @"https://127.0.0.1:8443/nexo/";
            _client.Config.SkipCertValidation = true;
            _posPaymentCloudApi = new PosPaymentCloudApi(_client);
            _posPaymentLocalApi = new PosPaymentLocalApi(_client);
            _client.LogCallback += Logger.PosClientOnLogCallback;
        }

        static void Main(string[] args)
        {
            Console.Write("Choose Operation Type:\n" +
                          "1 - Make a cloud syncronus api transaction\n" +
                          "2 - Make a cloud asyncronus api transaction\n" +
                          "3 - Make a terminal api transaction\n");
            InitPosLibrary();
            var operationType = Int16.Parse(Console.ReadLine());

            switch (operationType)
            {
                case 1:
                    var cloudApiPaymentSyncResponse = CreateCloudApiPaymentSyncRequest(_messageCategory, _amount);
                    break;
                case 2:
                    var cloudApiPaymentSAyncResponse = CreateCloudApiPaymentASyncRequest(_messageCategory, _amount);
                    break;
                case 3:
                    var localApiPaymenResponse = CreateTerminalApiPaymentRequest(_messageCategory, _amount);
                    break;
            }

            Console.WriteLine("End of application");
            Console.ReadKey();
        }

        private static Model.Nexo.SaleToPOIResponse CreateCloudApiPaymentSyncRequest(string requestType, int amount)
        {
            var paymentRequest = SaleToPOIRequestBuilder.CreateRequest(requestType, amount);
            return _posPaymentCloudApi.TerminalApiCloudSync(paymentRequest);
        }

        private static string CreateCloudApiPaymentASyncRequest(string requestType, int amount)
        {
            var paymentRequest = SaleToPOIRequestBuilder.CreateRequest(requestType, amount);
            return _posPaymentCloudApi.TerminalApiCloudAsync(paymentRequest);
        }

        private static Model.Nexo.SaleToPOIResponse CreateTerminalApiPaymentRequest(string requestType, int amount)
        {
            InitEncryption();
            var paymentRequest = SaleToPOIRequestBuilder.CreateRequest(requestType, amount);
            return _posPaymentLocalApi.TerminalApiLocal(paymentRequest, _encryptionCredentialDetails);
        }

        /// <summary>
        /// Initialize encryption
        /// </summary>
        private static void InitEncryption()
        {
            _messageSecuredEncryptor = new SaleToPoiMessageSecuredEncryptor();
            _encryptionCredentialDetails = new EncryptionCredentialDetails
            {

                AdyenCryptoVersion = Settings.AdyenCryptoVersion,
                KeyIdentifier = Settings.KeyIdentifier,
                Password = Settings.Password,
                KeyVersion = Settings.KeyVersion
            };
        }
    }
}
