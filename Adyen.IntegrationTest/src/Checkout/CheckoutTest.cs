using Adyen.Checkout.Extensions;
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;
using Adyen.Core;
using Adyen.Core.Auth;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Hosting;
using System.Text.Json;

namespace Adyen.IntegrationTest.Checkout
{
    [TestClass]
    public class CheckoutTest
    {
        private readonly IPaymentsService _paymentsApiService;
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public CheckoutTest()
        {
          IHost host = Host.CreateDefaultBuilder()
            .ConfigureCheckout((context, services, config) =>
            {
                var apiKey = new ApiKeyToken(
                context.Configuration["ADYEN_API_KEY"],
                "",
                null
              );
              config.AddTokens(apiKey);
            })
            .Build();

          _paymentsApiService = host.Services.GetRequiredService<IPaymentsService>();
          _jsonSerializerOptionsProvider = host.Services.GetRequiredService<JsonSerializerOptionsProvider>();
        }

        [TestMethod]
        public async Task Given_Payments_When_CardDetails_Provided_Returns_OK()
        {
            // Arrange
            var request = new PaymentRequest(
                amount: new Amount("EUR", 1999),
                merchantAccount: "HeapUnderflowECOM",
                reference: "Your order number4",
                returnUrl: "https://adyen.com/",
                paymentMethod: new CheckoutPaymentMethod(
                    new CardDetails(
                        type: CardDetails.TypeEnum.Scheme,
                        encryptedCardNumber: "test_4111111111111111",
                        encryptedExpiryMonth: "test_03",
                        encryptedExpiryYear: "test_2030",
                        encryptedSecurityCode: "test_737",
                        holderName: "John Smith"
                    )
                )
            );
            var result = await _paymentsApiService.PaymentsAsync(Guid.NewGuid().ToString(), request);

            Assert.IsTrue(result.IsOk);
        }

        [TestMethod]
        public async Task DeserializePaymentMethodsTest()
        {
            string json = @"
{
  ""paymentMethods"": [
    {
      ""name"": ""AliPay"",
      ""type"": ""alipay""
    },
    {
      ""brands"": [
        ""cartebancaire"",
        ""amex"",
        ""mc"",
        ""visa""
      ],
      ""configuration"": {
        ""mcDpaId"": ""6d41d4d6-45b1-42c3-a5d0-a28c0e69d4b1_dpa2"",
        ""visaSrcInitiatorId"": ""B9SECVKIQX2SOBQ6J9X721dVBBKHhJJl1nxxVbemHGn5oB6S8"",
        ""mcSrcClientId"": ""6d41d4d6-45b1-42c3-a5d0-a28c0e69d4b1"",
        ""visaSrciDpaId"": ""8e6e347c-254e-863f-0e6a-196bf2d9df02""
      },
      ""name"": ""Cards"",
      ""type"": ""scheme""
    },
    {
      ""configuration"": {
        ""merchantId"": ""000000000202326"",
        ""merchantName"": ""TestMerchantAccount""
      },
      ""name"": ""Apple Pay"",
      ""type"": ""applepay""
    },
    {
      ""name"": ""Payconiq by Bancontact"",
      ""type"": ""bcmc_mobile""
    },
    {
      ""name"": ""Boleto Bancario"",
      ""type"": ""boletobancario""
    },
    {
      ""name"": ""Online bank transfer."",
      ""type"": ""directEbanking""
    },
    {
      ""name"": ""DOKU"",
      ""type"": ""doku""
    },
    {
      ""name"": ""DOKU wallet"",
      ""type"": ""doku_wallet""
    },
    {
      ""brand"": ""***************"",
      ""name"": ""Generic GiftCard"",
      ""type"": ""giftcard""
    },
    {
      ""brand"": ""*****"",
      ""name"": ""Givex"",
      ""type"": ""giftcard""
    },
    {
      ""name"": ""GoPay Wallet"",
      ""type"": ""gopay_wallet""
    },
    {
      ""name"": ""GrabPay"",
      ""type"": ""grabpay_SG""
    },
    {
      ""issuers"": [
        {
          ""id"": ""************"",
          ""name"": ""*****""
        }
      ],
      ""name"": ""iDEAL"",
      ""type"": ""ideal""
    },
    {
      ""name"": ""Korea–issued cards"",
      ""type"": ""kcp_creditcard""
    },
    {
      ""name"": ""Pay later with Klarna."",
      ""type"": ""klarna""
    },
    {
      ""name"": ""Pay over time with Klarna."",
      ""type"": ""klarna_account""
    },
    {
      ""name"": ""Pay now with Klarna."",
      ""type"": ""klarna_paynow""
    },
    {
      ""name"": ""MB WAY"",
      ""type"": ""mbway""
    },
    {
      ""name"": ""MobilePay"",
      ""type"": ""mobilepay""
    },
    {
      ""configuration"": {
        ""merchantId"": ""50"",
        ""gatewayMerchantId"": ""TestMerchantAccount""
      },
      ""name"": ""Google Pay"",
      ""type"": ""paywithgoogle""
    },
    {
      ""name"": ""pix"",
      ""type"": ""pix""
    },
    {
      ""name"": ""SEPA Direct Debit"",
      ""type"": ""sepadirectdebit""
    },
    {
      ""brand"": ""***"",
      ""name"": ""SVS"",
      ""type"": ""giftcard""
    },
    {
      ""name"": ""UPI Collect"",
      ""type"": ""upi_collect""
    },
    {
      ""name"": ""UPI Intent"",
      ""type"": ""upi_intent""
    },
    {
      ""name"": ""UPI QR"",
      ""type"": ""upi_qr""
    },
    {
      ""brand"": ""*********"",
      ""name"": ""Valuelink"",
      ""type"": ""giftcard""
    },
    {
      ""name"": ""Vipps"",
      ""type"": ""vipps""
    },
    {
      ""brand"": ""***********"",
      ""name"": ""VVV Giftcard"",
      ""type"": ""giftcard""
    }
  ]
}
";
            
            // Act
            var r = JsonSerializer.Deserialize<PaymentMethodsResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.IsNotNull(r);
        }
    }
}