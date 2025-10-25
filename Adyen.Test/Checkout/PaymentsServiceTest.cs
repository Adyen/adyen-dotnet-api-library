using Adyen.Checkout.Extensions;
using Adyen.Checkout.Models;
using Adyen.Checkout.Services;
using Adyen.Checkout.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Hosting;
using System.Text.Json;
using Adyen.Core.Options;

namespace Adyen.Test.Checkout
{
    [TestClass]
    public class PaymentsServiceTest
    {
        [TestMethod]
        public async Task Given_PaymentMethodsResponse_When_Deserialized_Then_Result_Is_Not_Null()
        {
            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureCheckout((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                    });
                })
                .Build();
            
            var jsonSerializerOptionsProvider = testHost.Services.GetRequiredService<JsonSerializerOptionsProvider>();
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
            var result = JsonSerializer.Deserialize<PaymentMethodsResponse>(json, jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result.PaymentMethods);
            Assert.IsNull(result.StoredPaymentMethods);
            Assert.AreEqual(29, result.PaymentMethods.Count);
        }
        
        [TestMethod]
        public async Task Given_ConfigureCheckout_When_Environment_Is_Live_Then_HttpClient_BaseUrl_Is_Correct()
        {
            // Arrange
            IHost liveHost = Host.CreateDefaultBuilder()
                .ConfigureCheckout((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Live;
                        options.LiveEndpointUrlPrefix = "prefix";
                    });
                })
                .Build();
            
            // Act
            var paymentsApiService = liveHost.Services.GetRequiredService<IPaymentsService>();
            string baseAddress = paymentsApiService.HttpClient.BaseAddress!.ToString();
            
            // Assert
            Assert.IsTrue(baseAddress.Contains("live"));
            Assert.IsTrue(baseAddress.Contains("prefix"));
        }

        [TestMethod]
        public async Task Given_ConfigureCheckout_When_Environment_Is_Test_And_Prefix_Given_Then_HttpClient_BaseUrl_Does_Not_Contain_Prefix()
        {
            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureCheckout((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                        options.LiveEndpointUrlPrefix = "prefix";
                    });
                })
                .Build();
            
            // Act
            var paymentsApiService = testHost.Services.GetRequiredService<IPaymentsService>();
            string baseAddress = paymentsApiService.HttpClient.BaseAddress!.ToString();
            
            // Assert
            Assert.IsTrue(baseAddress.Contains("test"));
            Assert.IsFalse(baseAddress.Contains("prefix"));
        }
        
        
      [TestMethod]
      public async Task Given_ConfigureCheckout_When_No_Options_Provided_Then_HttpClient_Should_Contain_Test_Url_And_No_Prefix()
      {
          // Arrange
          IHost testHost = Host.CreateDefaultBuilder()
              .ConfigureCheckout((context, services, config) =>
              {
                  // Empty
              })
              .Build();
          
          // Act
          // Assert
          Assert.Throws<InvalidOperationException>(() =>
          {
              // No ApiKey provided, cannot instantiate the ApiKeyToken object
              testHost.Services.GetRequiredService<IPaymentsService>();
          });
      }
    }
}