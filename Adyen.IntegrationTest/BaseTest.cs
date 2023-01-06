using System;
using System.Collections.Generic;

using System.Threading.Tasks;
using Adyen.Model;
using Adyen.Model.BinLookup;
using Adyen.Model.Checkout;
using Adyen.Model.Payments;
using Adyen.Service;
using Amount = Adyen.Model.Amount;
using PaymentRequest = Adyen.Model.Payments.PaymentRequest;
using PaymentResult = Adyen.Model.Payments.PaymentResult;
using Environment = Adyen.Model.Enum.Environment;
using ExternalPlatform = Adyen.Model.ApplicationInformation.ExternalPlatform;
using Recurring = Adyen.Model.Payments.Recurring;

namespace Adyen.IntegrationTest
{
    public class BaseTest
    {
        public PaymentResult CreatePaymentResult()
        {
            var client = CreateApiKeyTestClient();
            var payment = new Payment(client);
            var paymentRequest = CreateFullPaymentRequest();
            var paymentResult = payment.Authorise(paymentRequest);

            return paymentResult;
        }

        public async Task<PaymentResult> CreatePaymentResultAsync()
        {
            var client = CreateApiKeyTestClient();
            var payment = new Payment(client);
            var paymentRequest = CreateFullPaymentRequest();
            var paymentResult = await payment.AuthoriseAsync(paymentRequest);

            return paymentResult;
        }

        public PaymentResult CreatePaymentResultWithApiKeyAuthentication()
        {
            var client = CreateApiKeyTestClient();
            var payment = new Payment(client);
            var paymentRequest = CreateFullPaymentRequest();
            var paymentResult = payment.Authorise(paymentRequest);

            return paymentResult;
        }

        public PaymentResult CreatePaymentResultWithIdempotency(string idempotency)
        {
            var client = CreateApiKeyTestClient();
            var payment = new Payment(client);
            var paymentRequest = CreateFullPaymentRequest();
            var paymentResult = payment.Authorise(paymentRequest, new RequestOptions{ IdempotencyKey=idempotency});

            return paymentResult;
        }

        public PaymentResult CreatePaymentResultWithRecurring(Recurring.ContractEnum contract)
        {
            var client = CreateApiKeyTestClient();
            var payment = new Payment(client);
            var paymentRequest = CreateFullPaymentRequestWithRecurring(contract);
            var paymentResult = payment.Authorise(paymentRequest);

            return paymentResult;
        }

       
        /// <summary>
        /// Creates a payment and returns the psp result
        /// </summary>
        /// <returns></returns>
        public string GetTestPspReference()
        {
            //Do test payment
            var paymentResult = CreatePaymentResult();
            //Get the psp referense 
            var paymentResultPspReference = paymentResult.PspReference;
            return paymentResultPspReference;
        }

        public string GetTestPspReferenceMocked()
        {
            return "8514836072314693";
        }


        #region Modification objects

        protected CaptureRequest CreateCaptureTestRequest(string pspReference)
        {
            var captureRequest = new CaptureRequest
            {
                MerchantAccount = ClientConstants.MerchantAccount,
                ModificationAmount = new Adyen.Model.Payments.Amount("EUR", 150),
                Reference = "capture - " + DateTime.Now.ToString("yyyyMMdd"),
                OriginalReference = pspReference
            };
            return captureRequest;
        }

        protected CancelOrRefundRequest CreateCancelOrRefundTestRequest(string pspReference)
        {
            var cancelOrRefundRequest = new CancelOrRefundRequest()
            {
                MerchantAccount = ClientConstants.MerchantAccount,
                Reference = "cancelOrRefund - " + DateTime.Now.ToString("yyyyMMdd"),
                OriginalReference = pspReference
            };
            return cancelOrRefundRequest;
        }

        protected RefundRequest CreateRefundTestRequest(string pspReference)
        {
            var refundRequest = new RefundRequest()
            {
                MerchantAccount = ClientConstants.MerchantAccount,
                ModificationAmount = new Adyen.Model.Payments.Amount("EUR", 150),
                Reference = "refund - " + DateTime.Now.ToString("yyyyMMdd"),
                OriginalReference = pspReference
            };
            return refundRequest;
        }

        protected CancelRequest CreateCancelTestRequest(string pspReference)
        {
            var cancelRequest = new CancelRequest()
            {
                MerchantAccount = ClientConstants.MerchantAccount,
                Reference = "cancel - " + DateTime.Now.ToString("yyyyMMdd"),
                OriginalReference = pspReference
            };
            return cancelRequest;
        }
        protected AdjustAuthorisationRequest CreateAdjustAuthorisationtestRequest(string pspReference)
        {
            var adjustAuthorisationRequest = new AdjustAuthorisationRequest()
            {
                MerchantAccount = ClientConstants.MerchantAccount,
                ModificationAmount = new Adyen.Model.Payments.Amount("EUR", 150),
                Reference = "adjust authorisation - " + DateTime.Now.ToString("yyyyMMdd"),
                OriginalReference = pspReference
            };
            return adjustAuthorisationRequest;
        }

        #endregion
        
        protected Client CreateApiKeyTestClient()
        {
            var config = new Config()
            {
                XApiKey = ClientConstants.Xapikey,
                Environment = Environment.Test
            };
            return new Client(config);        
        }
        
        private PaymentRequest CreateFullPaymentRequest()
        {
            PaymentRequest paymentRequest = new PaymentRequest
            {
                MerchantAccount = ClientConstants.MerchantAccount,
                Amount = new Model.Payments.Amount("EUR", 1500),
                Card = CreateTestCard(),
                Reference = "payment - " + DateTime.Now.ToString("yyyyMMdd"),
                AdditionalData = CreateAdditionalData(),
                ApplicationInfo = new ApplicationInfo()
                {
                    ExternalPlatform = new Model.Payments.ExternalPlatform()
                    {
                        Integrator = "test merchant",
                        Name = "merchant name",
                        Version = "2.8"
                    }
                }

            };
            paymentRequest.ApplicationInfo.ExternalPlatform = new Adyen.Model.ApplicationInformation.ExternalPlatform("test merchant", "merchant name", "2.8");
            return paymentRequest;
        }

        public PaymentRequest3D CreateFullPaymentRequest3D()
        {
            var paymentRequest = new PaymentRequest3D
            {
                MerchantAccount = ClientConstants.MerchantAccount,
                Md = "testtokenMd",
                PaResponse = "unique pa"
            };
            paymentRequest.ApplicationInfo.ExternalPlatform = new Adyen.Model.ApplicationInformation.ExternalPlatform("test merchant", "merchant name", "2.8");
            return paymentRequest;
        }

        private PaymentRequest CreateFullPaymentRequestWithRecurring(Recurring.ContractEnum contract)
        {
            var paymentRequest = new PaymentRequest
            {
                MerchantAccount = ClientConstants.MerchantAccount,
                Amount = new Model.Payments.Amount("EUR", 1500),
                Card = CreateTestCard(),
                Reference = "payment - " + DateTime.Now.ToString("yyyyMMdd"),
                ShopperReference = "test-1234",
                AdditionalData = CreateAdditionalData(),
                Recurring = new Model.Payments.Recurring { Contract = contract },
                ApplicationInfo = new ApplicationInfo()
                {
                    ExternalPlatform = new Model.Payments.ExternalPlatform()
                    {
                        Integrator = "test merchant",
                        Name = "merchant name",
                        Version = "2.8"
                    }
                }
            };

            paymentRequest.ApplicationInfo.ExternalPlatform = new Adyen.Model.ApplicationInformation.ExternalPlatform("test merchant", "merchant name", "2.8");
            return paymentRequest;
        }

        /// <summary>
        /// Check out payment request
        /// </summary>
        /// <param name="merchantAccount"></param>
        /// <returns></returns>
        public Model.Checkout.PaymentRequest CreatePaymentRequestCheckout()
        {
            var amount = new Model.Checkout.Amount("USD", 1000);
            var paymentsRequest = new Model.Checkout.PaymentRequest
            {
                Reference = "Your order number from e2e",
                Amount = amount,
                ReturnUrl = @"https://your-company.com/...",
                MerchantAccount = ClientConstants.MerchantAccount,
            };
            var cardDetails = new Model.Checkout.CardDetails()
            {
                Number = "4111111111111111",
                ExpiryMonth = "10",
                ExpiryYear = "2020",
                HolderName = "John Smith",
                Cvc = "737"
            };
            paymentsRequest.PaymentMethod = new PaymentDonationRequestPaymentMethod(cardDetails);
            return paymentsRequest;
        }

        /// <summary>
        /// Check out payment IDeal request
        /// </summary>
        /// <param name="merchantAccount"></param>
        /// <returns></returns>
        public Model.Checkout.PaymentRequest CreatePaymentRequestIDealCheckout()
        {
            var amount = new Model.Checkout.Amount("EUR", 1000);
            var paymentsRequest = new Model.Checkout.PaymentRequest
            {
                Reference = "Your order number from e2e",
                Amount = amount,
                PaymentMethod= new Model.Checkout.PaymentDonationRequestPaymentMethod(new IdealDetails(type: IdealDetails.TypeEnum.Ideal, issuer: "1121")),
                ReturnUrl = @"https://your-company.com/...",
                MerchantAccount = ClientConstants.MerchantAccount,
            };
          
            return paymentsRequest;
        }

        /// <summary>
        /// Checkout paymentMethodsRequest
        /// </summary>
        /// <returns></returns>
        public Model.Checkout.PaymentMethodsRequest CreatePaymentMethodRequest()
        {
            return new Model.Checkout.PaymentMethodsRequest(merchantAccount: ClientConstants.MerchantAccount);
        }

        /// <summary>
        ///Checkout Details request
        /// </summary>
        /// <returns>Returns a sample PaymentsDetailsRequest object with test data</returns>
        public Model.Checkout.DetailsRequest CreateDetailsRequest()
        {
            string paymentData = "Ab02b4c0!BQABAgCJN1wRZuGJmq8dMncmypvknj9s7l5Tj...";
            var details = new PaymentCompletionDetails()
            {
               MD="FDSAFASFHHRE1234...",
               PaRes = ""
            };
            var paymentsDetailsRequest = new Model.Checkout.DetailsRequest(details: details, paymentData: paymentData);

            return paymentsDetailsRequest;
        }

        protected Model.Checkout.PaymentSetupRequest CreatePaymentSessionRequest()
        {
            return new Model.Checkout.PaymentSetupRequest(merchantAccount: ClientConstants.MerchantAccount, reference: "MerchantReference", shopperLocale: "nl_NL",
                  channel: Model.Checkout.PaymentSetupRequest.ChannelEnum.Web, sdkVersion: "1.3.0",
                 amount: new Model.Checkout.Amount("EUR", 1200), returnUrl: @"https://www.yourshop.com/checkout/result", countryCode: "NL",shopperReference:"ShopperIdAlex");
        }

        protected Model.Checkout.PaymentVerificationRequest CreatePaymentDetailsRequest()
        {
            string payload = @"eyJjaGVja291dHNob3BwZXJCYXNlVXJsIjoiaHR0cHM6XC9cL2NoZWNrb3V0c2hvcHBlci10ZXN0LmFkeWVuLmNvbVwvY2hlY2tvdXRzaG9wcGVyXC8iLCJkaXNhYmxlUmVjdXJyaW5nRGV0YWlsVXJsIjoiaHR0cHM6XC9cL2NoZWNrb3V0c2hvcHBlci10ZXN0LmFkeWVuLmNvbVwvY2hlY2tvdXRzaG9wcGVyXC9zZXJ2aWNlc1wvUGF5bWVudEluaXRpYXRpb25cL3YxXC9kaXNhYmxlUmVjdXJyaW5nRGV0YWlsIiwiZ2VuZXJhdGlvbnRpbWUiOiIyMDE4LTEyLTA1VDExOjAzOjUzWiIsImluaXRpYXRpb25VcmwiOiJodHRwczpcL1wvY2hlY2tvdXRzaG9wcGVyLXRlc3QuYWR5ZW4uY29tXC9jaGVja291dHNob3BwZXJcL3NlcnZpY2VzXC9QYXltZW50SW5pdGlhdGlvblwvdjFcL2luaXRpYXRlIiwib3JpZ2luIjoiIiwicGF5bWVudCI6eyJhbW91bnQiOnsiY3VycmVuY3kiOiJFVVIiLCJ2YWx1ZSI6MTIwMH0sImNvdW50cnlDb2RlIjoiTkwiLCJyZWZlcmVuY2UiOiJNZXJjaGFudFJlZmVyZW5jZSIsInJldHVyblVybCI6Imh0dHBzOlwvXC93d3cueW91cnNob3AuY29tXC9jaGVja291dFwvcmVzdWx0Iiwic2Vzc2lvblZhbGlkaXR5IjoiMjAxOC0xMi0wNVQxMjowMzo1M1oiLCJzaG9wcGVyTG9jYWxlIjoibmxfTkwifSwicGF5bWVudERhdGEiOiJBYjAyYjRjMCFCUUFCQWdDU055Q2o1YkFZMzNKdGhFY0JDXC9HbjFSeEJQWDhNZmNHUUF1SnRoblFCXC9KUVFNdjlQTFJzdlRhbWw3S21WODZBOGpPbVd0RnZZeGlUc0ZcL1kxdmxWb2lkNjFXRzVHVkFod2dTeWV3U20yQkVYZmphNEsrNGhBRGVYd0tOa05LbGFhakNpNnljTWxsTTBsTjdCdFJ3MUVCd3pNZEgybU9qVThCOGxCejFGMWN2aEF3QVwvbUkxOHFZWFF1UGQxVTluVkRnWXBaN2l2blFjZEJZTVQrall1TENpY0FmelhOeFYya1RCNjg3eWNMc0RnajJrajRvZHBtd1NWYkNZeld1Sk1rSUJEUnJuY1hlaTBSYk1QbDdpUVwvRSt3TFRLMjA0b0ZuT0xQTDVGM1dNamFsRlFEZXMrR3plaWN6OVhzSll1S1NTR0o3bWZjZ2ZlbTF4cUxUNDRjZUo3NFZZQ3E5alRJXC9YOFFTYWJWUWtKcGNiTW1qXC83U2pMVlhxSUdBeXk5ekRVS0NXelRGS1wvd3QwanR4UGNcL25FTDJJWE1BU0dkT01KemJlVlZ6V3h6NTRzdTZaK2JjS2ZqclloS25PZ2hZZTZmVHlvRzVPNW51amRtNzRzN0R3WmwwdjBOOHFYbE1cL0dBUGZ6RmpwbExiYlBHcEhTV0V5YzI2YUZOdXdYXC9sbVpQb3pIa0R2WmRDSXNWbkVLWW1EcDAwZExKRWhBVHRqOHhqdHVjNzhvXC9iRTBDR2FjRm83NXNFdkI4Z2RkOEFaV2JPZnFFM2FrXC9VYjN6Qzk5OTFcL1JZTlBnK2Y1TFZmelRhWjBYMEVDK3JSdDZDME9BNm45RU9oNkFGWElHT2QwOTdaUUE5djZrRWZMcHpTNmh4dmM0QzU1ZXRwZmRQN3V1Y2RUTTBtUWVRaEM1M0EwTmJ3bFYxd1JVb0lka2NrTmhBRXA3SW10bGVTSTZJa0ZHTUVGQlFURXdNME5CTlRNM1JVRkZSRGczUXpJMFJFUTFNemt3T1VJNE1FRTNPRUU1TWpORk16Z3lNMFEyT0VSQlEwTTVORUk1UmtZNE16QTFSRU1pZlpHN0VhU2p5TkxKQVVlekx0dEFza3ozYmZJeEROZjB1V3lyY2lzZWxZR0ZFVFFqSXFQenZ5Q0NXQnFcLzRwTEhrQTdzR2tBMDE1ZUtFSVFtV254OFUrXC93QUdLU1RUYVBuK3FmeHNaXC90cVwvN3A4a0ZpYnowV012SFplZjhUR0ltaHZPSzRkZ3ozejVWWkRUZ3ZsbGpSRnBXUGloTGZNVXFoOE91WWUzRExZTUtvY1JGMXFwRDVuSjdcLysyMFFtUVRhSlEyMXNFNjUwVHFkUE9qd3hSeHdCVE1oTms5Q01FQkM2RDRRWE83eUtab3NLcGVNbEJtSXMxcUk1ZU10Z0g1UmFFMEROeDBNakJsamJnNjdpK0kzSjFFcUR2KzdZRmZsWWVQZzZwbkdoTEZjUXZBSmcraDlqOTBOSnFaU3EzVndXQ1B1YlZ1REZuWDhIRnRMRlZKa1lQT2pnMGVPdWYwNFBlejVFTFFUXC9SWDdmS0d2NzdaSTNaVys4eEM1MnVLT1puMkhHd1wvb1wvYmpEaDJVemcrYUZPalhCZkZaeGpMM0w4XC9qVmx2aDdNSDZZNEMrelwvXC9EYnQ5MVwvRGZrWlVSMENJcFpId29VSGJ6ZWtBRGJPUnQxWDFsWjZmczNpbnR2MmhZbitDZGdBaFZFT3ZKT2VOa0M1SkpIcEx2WHp0bUtyMmpoc21kVEpZUE15b0xiaFk5b2d0QWZhNzdXQnpJb2FtRXk0SjZHK0c1Qk1lQ3dlQUVCUGNJcHpESnlSZ2FLd2tYcVRiMTExbGVDR25UakVMdUhaWEt2RHM0MlpZTE9QcDhkVWZtaVA1ck1kam1Qb0xaWVFGU3lmRGNuQWdzXC8wYXZBV3AzYWZ0Skdua0diVjhtQitWZnI0ZFk1WURcL2FOUGcwMnRUMWNLZHJXQnQ4NTFRUUpUM2RoUWZteEZNTVpLTHN3WjJFditUMER4ckJGSjBrSENITWRUKzBTXC9nU2lkRWROXC9zT0NYcVBKT1o2c2cxR3Q5XC9ncm5YNGJqWFlkbmpyb2tYT09FV1dMQk9LTjAyWkpIRGdGditKeFRMMHB4N1JDSWZ2RjhqbHRtTis3aWV0anVQXC81WDE5N05RTlV2M3hKYUJMelhUK3llV3JTaGRoaDBQQnJKT09jQVN3bVZFd3hXS01mODg4TWxMVGY1S1RUNjRKXC9idGNBWklUWjVKK3ZkaXlLeEM4TGxiUVpnc2pvR3ZYYmtXWnJqeE5pUWlpVUdPeEZ4ek5BZnU0bTA1NExOUG9WVVFMQWN5cEdQd3E3YjkzeVM4T29LRlpFbXhhb1RxTXh3S292dHE4VVQyOFFRcG8xUXQrUVA4SURCY1wvbFE1RkdwWTZYM1d3Vk1GaWhiWTBaMFNZV3JFYlYrSHZLbFhiYU1CQUhnaEUiLCJwYXltZW50TWV0aG9kcyI6W3siY29uZmlndXJhdGlvbiI6eyJjYW5JZ25vcmVDb29raWVzIjoidHJ1ZSJ9LCJkZXRhaWxzIjpbeyJpdGVtcyI6W3siaWQiOiIxMTIxIiwibmFtZSI6IlRlc3QgSXNzdWVyIn0seyJpZCI6IjExNTQiLCJuYW1lIjoiVGVzdCBJc3N1ZXIgNSJ9LHsiaWQiOiIxMTUzIiwibmFtZSI6IlRlc3QgSXNzdWVyIDQifSx7ImlkIjoiMTE1MiIsIm5hbWUiOiJUZXN0IElzc3VlciAzIn0seyJpZCI6IjExNTEiLCJuYW1lIjoiVGVzdCBJc3N1ZXIgMiJ9LHsiaWQiOiIxMTYyIiwibmFtZSI6IlRlc3QgSXNzdWVyIENhbmNlbGxlZCJ9LHsiaWQiOiIxMTYxIiwibmFtZSI6IlRlc3QgSXNzdWVyIFBlbmRpbmcifSx7ImlkIjoiMTE2MCIsIm5hbWUiOiJUZXN0IElzc3VlciBSZWZ1c2VkIn0seyJpZCI6IjExNTkiLCJuYW1lIjoiVGVzdCBJc3N1ZXIgMTAifSx7ImlkIjoiMTE1OCIsIm5hbWUiOiJUZXN0IElzc3VlciA5In0seyJpZCI6IjExNTciLCJuYW1lIjoiVGVzdCBJc3N1ZXIgOCJ9LHsiaWQiOiIxMTU2IiwibmFtZSI6IlRlc3QgSXNzdWVyIDcifSx7ImlkIjoiMTE1NSIsIm5hbWUiOiJUZXN0IElzc3VlciA2In1dLCJrZXkiOiJpZGVhbElzc3VlciIsInR5cGUiOiJzZWxlY3QifV0sIm5hbWUiOiJpREVBTCIsInBheW1lbnRNZXRob2REYXRhIjoiQWIwMmI0YzAhQlFBQkFnQXNSS2IzMUZIYVdqRm1zcTZKQmRcL1wvSXpvdFwvQmJWV2Y0eHh6WXpMZWtsUGlTS3JRVDIxeDFUcFFobnpVeTNKS0l2N2VRaTdRbkRrOUduNHhtTHk0Wmxud3diRDJyc2xUWXlxVkZmTTM3c2JoOW9JMmRmU1FuQW9oMG9GK0JLR0RzTCt6aVpFUjE5Q2o0V0Fla2FKUWJ3Q0JmSHk2WEtHVEZrOHJYVWVEY0hCSmNzbnBoT1Q4Zm1ydXJiTlI4TEVnbWVcL2pDY0g0Q1Q0aTlOT0hUajlRcFZzZmdPTnA2bzJWYUN5QVlSS3BBbjgrem9vaDM3WmpVd3pKSzcxVjVrSDh4QlBuOVJFTDdLN3A4U0p2WkdwNytmNlVzbVwvYWd3dGtHOWt6ZFYxUWlVWGhvS2l4Z1gzdVE5cUEyemhiSkVuZVluekhUMkpabzZrV3pHMVwvcEg3eW9VY1ZpcG1BR204ZUo5MEd0VGt0dVczXC9yRjVKXC9pQWdSVzlSREFLT0JwMVB6VDdmUnBmME5LNTYybFhWSUZQM0owZ2t4Y01Ccmw4ZWNDS3FhR3JjTmhrb1BuTGhpSkYwQjIxTDBpRXFETnRKWGFDaVh4XC8renQyRDVhb2RpcHhPUEVQSk1pVUxwVnIxRkRsNjhJK0lFaENzSkIxUlVzMUNQZ2RZVEdCMHlLTXJnNTNtVHhsbkpoRkhVQ2pwNWFQbHNHdFozYjJjZXFLeGh5VFRJblFDcVlGancyQndQYXBXZUpvY29abjBiWnlTU05uV0xSRHg3RTl3d1E0QlBqaVZnd0drK2VTd1lwUGRxSTd6MnhnYXdLbmRKZVRUbFdsMWplZU9nUWFSOG9aWE9xdnVTRnZacnpZU2JDKzhHTFZjb3JVc1UwZWlQeHphZWRmenpQUW1MZlZCQm5la21xN21KNjZ4R2F2M3VUQ3JHZkFFcDdJbXRsZVNJNklrRkdNRUZCUVRFd00wTkJOVE0zUlVGRlJEZzNRekkwUkVRMU16a3dPVUk0TUVFM09FRTVNak5GTXpneU0wUTJPRVJCUTBNNU5FSTVSa1k0TXpBMVJFTWlmU3pXNGQza0k3UFYzK0pWSXRNWkM2UVdydElBakora0IzWUFuM29mZjdHeFRUdEo3R2I2ejZjY1B2aFZyYW4yVmpWbm93PT0iLCJ0eXBlIjoiaWRlYWwifSx7ImRldGFpbHMiOlt7ImtleSI6ImVuY3J5cHRlZENhcmROdW1iZXIiLCJ0eXBlIjoiY2FyZFRva2VuIn0seyJrZXkiOiJlbmNyeXB0ZWRTZWN1cml0eUNvZGUiLCJ0eXBlIjoiY2FyZFRva2VuIn0seyJrZXkiOiJlbmNyeXB0ZWRFeHBpcnlNb250aCIsInR5cGUiOiJjYXJkVG9rZW4ifSx7ImtleSI6ImVuY3J5cHRlZEV4cGlyeVllYXIiLCJ0eXBlIjoiY2FyZFRva2VuIn0seyJrZXkiOiJob2xkZXJOYW1lIiwib3B0aW9uYWwiOnRydWUsInR5cGUiOiJ0ZXh0In1dLCJncm91cCI6eyJuYW1lIjoiQ3JlZGl0IENhcmQiLCJwYXltZW50TWV0aG9kRGF0YSI6IkFiMDJiNGMwIUJRQUJBZ0FPQjNsQWdYWEg2UURjZnNVVDdkUzRrOUtcL2ZuSmRlWkUrd25BVno0bWh1SGxwZXlRU0ROeEQxSktZR0ZBekg4dlk5NFNYaThFOXY2VVMxbUNUUG9WdjRwTnpVUlBaNUtOa08xamRvSzRQTVJWNXl4bmRlUzkrbGliWHdtU0lVeHJKNGgxR1Z0RDNYZ2taQ25DOGs0YlN5UlRESDZHNDlJKzl0SnNrWE5DRXNTbCtmWEVkNldneDNweVNNbWJrM0htSmFONEE5RVlkK2hUYk8rSEtXYWlvelZGMHd3NmxcL0ZIYm9qZXhzSnFpNXJrNWxCTGpTYUJFVjAwRXk5RER5UHZueTgzUWxHTW80SWZrYlBlZERqdndFbGFmb2NSalwvOGFYb3N1S0kxWkxtOHlKT3RvTmRKbHFSN3lkS1VyMUo2eGQrN1BMNEg4eDdiTm9ON2t4d2lhVjJBQm8xTmFLeFVwWDRsMTBnWURBandhZ2hqOTVUQlM0azNqZlZRWEg2TExPS3BCXC9JNTRlakVwZEJMY1wvZlZtWHQ1R3FvU3FsUnJkWmhYalBxXC84UjV3YzhWM1wvdk9mNFwvYzhYbStDaFhSRWtKVEdJTWZrVmlYUnZ2YkVYYnRNcWNDQWVLcm5MVzN1WlpKa1ZzRnRoZm9vaEhSVlhSWHdsSXVZMXlTKzU5Q3JUYWtOOWxabk1ibnFkMFJCdFF5QXMxVENQMjdMbERPWEo0dnRTZ3k2OGk3QjBlYzlnN0NqU1RGaVZkYlhcL3ZYeVBFZ2V4aXpZN3k4XC9MV05PcWZDbjU3a1FOZk5JcURldHRaWkJXWFFtMnlVXC96NVhmYmNUYmZiY3NueEt5dnhUU3QyWnpoS1VDSVNvNFRSbytjdGtQY2FyS205U0szUHVGakNZNU5xZDJ3c3V4QSt0VDhSNEdMZ2JzRDZlTGc0TVErZ0FFcDdJbXRsZVNJNklrRkdNRUZCUVRFd00wTkJOVE0zUlVGRlJEZzNRekkwUkVRMU16a3dPVUk0TUVFM09FRTVNak5GTXpneU0wUTJPRVJCUTBNNU5FSTVSa1k0TXpBMVJFTWlmVk1lWWVnakdBSENYY0FOeEJVWmFuZ3RDWEhSaU1qMERSeEJBSmd6RStwTGE1NFwvQmxxWHkwXC83Sm5kOEJvM0s1ZzBqVmlzPSIsInR5cGUiOiJjYXJkIn0sIm5hbWUiOiJNYXN0ZXJDYXJkIiwicGF5bWVudE1ldGhvZERhdGEiOiJBYjAyYjRjMCFCUUFCQWdCTkppUER3cFRoM2tTQkF3QXFad0JrV3dJWGhZbEQzM09ZeXNRZ1crQ1VPWEdVNklUckhUK0pyQmEyMHJCdXJqU1UyNFhDYmFlQ1VxQ2xnZjFseU5nUmMyVnhlejk5WUFcL2lxMWRyVGxOdnJ6aThTSzUrVUpWTWU4Nytwa3lHYVpubzRjWDFkQXJweDBmVjNxMDcrWkdzSk9HeHlhZGlpQ1pNZ291UVZlSndMXC9OZGl3SERpOWxqcGdVZWlJTnZUamZDaTVKYjZxTFJIYTRpRm1FK0hZWGorMXdzUW1uRWVPTE1JNWpSK0FLbnNWVFlHVXJsT2lZSEhrXC9waW1lM05EbjlpVnd5Q3VMWmpVMm9VWURhNktva053Tmc5cGpLbnZYTzRTVktBYVBGbng5VkNlaHV2ZVErTXhBTm1xMUpISjlLUmdHdk9ITHNUeVVyTG9CTlZuMHd5eHJNQXA3UFNjV3ZsYWpHTkd3QzloNVJrVGFsZVJ6UWdlSDlGRWZqYkdyQklMR1ZNODBMNXRIdUhYXC8yNW41NDRPUHdDalY3VWxDbkJJT1NjSnk5VSsyQ0k5QjhMY0hoVVJpT1wvQmpxd2xLRHExM0w3SFdyYnhRdER1bGZDNFZHTTJWa0RHdjNsb09SdlNGS1wvQ0haSkhmSFdlczBzbEtFZHZPaGpQXC9VSzkrUHV6N2xMenI4VFJ4bUdXZHJmQXNtKzBkTG9JdVU5dGRvTXlzdWNSOWQyZitoYUJSajY1eTdINVwvdEFlYVlDVkpIQThialhudllSRFlCZnYwWmhhMTR0U1Y2M1pObCtJMk9qb3NBUnRSS0FMNHRHdTB0NnhBdUNtQ1wvUE8zb0FjUm4xMFAzSHFmZ21mU0dOcVFUbTNiczJCWXl5MUZxK0NTTFpJMEVIM2pVQkJDOVJSRWZxR1JJOG5uQWpydzRJTFcxQUVwN0ltdGxlU0k2SWtGR01FRkJRVEV3TTBOQk5UTTNSVUZGUkRnM1F6STBSRVExTXprd09VSTRNRUUzT0VFNU1qTkZNemd5TTBRMk9FUkJRME01TkVJNVJrWTRNekExUkVNaWZjQnNOaHRQSXhhU1wvK0dKekhYODdrRTRsOTdHU1lUbERWOW9qcHNHdDJTVGM3UER1TDV0U2VqaUIwQUxhMVFSOUE9PSIsInR5cGUiOiJtYyJ9LHsiZGV0YWlscyI6W3sia2V5IjoiZW5jcnlwdGVkQ2FyZE51bWJlciIsInR5cGUiOiJjYXJkVG9rZW4ifSx7ImtleSI6ImVuY3J5cHRlZFNlY3VyaXR5Q29kZSIsInR5cGUiOiJjYXJkVG9rZW4ifSx7ImtleSI6ImVuY3J5cHRlZEV4cGlyeU1vbnRoIiwidHlwZSI6ImNhcmRUb2tlbiJ9LHsia2V5IjoiZW5jcnlwdGVkRXhwaXJ5WWVhciIsInR5cGUiOiJjYXJkVG9rZW4ifSx7ImtleSI6ImhvbGRlck5hbWUiLCJvcHRpb25hbCI6dHJ1ZSwidHlwZSI6InRleHQifV0sImdyb3VwIjp7Im5hbWUiOiJDcmVkaXQgQ2FyZCIsInBheW1lbnRNZXRob2REYXRhIjoiQWIwMmI0YzAhQlFBQkFnQU9CM2xBZ1hYSDZRRGNmc1VUN2RTNGs5S1wvZm5KZGVaRSt3bkFWejRtaHVIbHBleVFTRE54RDFKS1lHRkF6SDh2WTk0U1hpOEU5djZVUzFtQ1RQb1Z2NHBOelVSUFo1S05rTzFqZG9LNFBNUlY1eXhuZGVTOStsaWJYd21TSVV4cko0aDFHVnREM1hna1pDbkM4azRiU3lSVERINkc0OUkrOXRKc2tYTkNFc1NsK2ZYRWQ2V2d4M3B5U01tYmszSG1KYU40QTlFWWQraFRiTytIS1dhaW96VkYwd3c2bFwvRkhib2pleHNKcWk1cms1bEJMalNhQkVWMDBFeTlERHlQdm55ODNRbEdNbzRJZmtiUGVkRGp2d0VsYWZvY1JqXC84YVhvc3VLSTFaTG04eUpPdG9OZEpscVI3eWRLVXIxSjZ4ZCs3UEw0SDh4N2JOb043a3h3aWFWMkFCbzFOYUt4VXBYNGwxMGdZREFqd2FnaGo5NVRCUzRrM2pmVlFYSDZMTE9LcEJcL0k1NGVqRXBkQkxjXC9mVm1YdDVHcW9TcWxScmRaaFhqUHFcLzhSNXdjOFYzXC92T2Y0XC9jOFhtK0NoWFJFa0pUR0lNZmtWaVhSdnZiRVhidE1xY0NBZUtybkxXM3VaWkprVnNGdGhmb29oSFJWWFJYd2xJdVkxeVMrNTlDclRha045bFpuTWJucWQwUkJ0UXlBczFUQ1AyN0xsRE9YSjR2dFNneTY4aTdCMGVjOWc3Q2pTVEZpVmRiWFwvdlh5UEVnZXhpelk3eThcL0xXTk9xZkNuNTdrUU5mTklxRGV0dFpaQldYUW0yeVVcL3o1WGZiY1RiZmJjc254S3l2eFRTdDJaemhLVUNJU280VFJvK2N0a1BjYXJLbTlTSzNQdUZqQ1k1TnFkMndzdXhBK3RUOFI0R0xnYnNENmVMZzRNUStnQUVwN0ltdGxlU0k2SWtGR01FRkJRVEV3TTBOQk5UTTNSVUZGUkRnM1F6STBSRVExTXprd09VSTRNRUUzT0VFNU1qTkZNemd5TTBRMk9FUkJRME01TkVJNVJrWTRNekExUkVNaWZWTWVZZWdqR0FIQ1hjQU54QlVaYW5ndENYSFJpTWowRFJ4QkFKZ3pFK3BMYTU0XC9CbHFYeTBcLzdKbmQ4Qm8zSzVnMGpWaXM9IiwidHlwZSI6ImNhcmQifSwibmFtZSI6IlZJU0EiLCJwYXltZW50TWV0aG9kRGF0YSI6IkFiMDJiNGMwIUJRQUJBZ0F3ZktJT0llbGtCSXN0dURqMStBMUFWWFRVV0RSRDZoK0RxZERlWnMrYzZcL0haRFwvTjBiTm1KV2x2XC9HVUhVTEY3ZDZVdzU1bDQ4OG1SQWRONjZ0UDFhd0ZkQTRUMVM1SXhjaWJqaXNCV2JrMmRldzhOYnd2QUVkc254aGxMbWVvUU5wYnJwU3RNaE1NUVVlUm1sNElvbG1BQ1VFbHFOZWhVNFBVRUhZQ2Q2QWdyQTFKWXFBMm5TZjl3V0ZjbU9nRjFzRm1xWnkwT0tGemI4QzZ4Q1RGT0ZcL1pzZG8yaWlPRXFzUk0yMmdnSnkyVW9MRVN6S292SUJCcnJiYXUzSXphSUx1QzdqN1hUNU9NME1JU00wdE1xZUdLUFdab0lwY3QrSWxNU1NHNDd3MmVIUjR3akpTMitYZG1EXC90TzlSSGlRbE9IZHFGbnR6M2RoY0hwSU8xOTlvT0p4eWRDb3VYQlc4czhaem1LRHBBRnUwQXNrRDBUendWVjhaUjBLckpLdzB4Mzd5QlVSMVpGSGJcL1ZSMTAzQ1l2XC8zQ1NZTUtCVmt0ZTYzbkhkaUMwd3ZVa3d5dHA4RkJOdXdMdVEwZGNmNndtVmt2dGlJRk9qeEpsb0U4XC9lZXpCYjJSTXFKVk54S0R1OHczWVZ5SnpFZWdIZVkyblFcL25vQ09JQzNPR0J2UFFDS3I1ZWs0ZkNqNFMwSWdSa0Z4ZDZidDNXdmVrSmFBR0RNaTZ6S28rVmRBUEo5U2NhTW5vcXdQeGNxYVlXRlhcL1VyMFdSdHFONkprKzZiQ3RuT1VBM1Nka2libXEyMUgxb1ZSS1R0ZGpYbGxxZnlRc0hIaHdhcTR6bTVtbTFMYmd5dFY4VXVRZ1lRSUFSRWFJRDlhXC9GZFFNZEpCM05VdVRyR09OY3pTdWRoQ1E3bVh3RnEwSE1XMWpKUDFYK3NSYUFFcDdJbXRsZVNJNklrRkdNRUZCUVRFd00wTkJOVE0zUlVGRlJEZzNRekkwUkVRMU16a3dPVUk0TUVFM09FRTVNak5GTXpneU0wUTJPRVJCUTBNNU5FSTVSa1k0TXpBMVJFTWlmV0VxU3BUeElEMVwvTVJBZjhXWndLVE01OW1tZVRMMlBxUVlKYjJYbVdnQ1FlUThseG12VFIwTmFsVDVcL2dsNGZVNDk3IiwidHlwZSI6InZpc2EifSx7ImRldGFpbHMiOlt7ImtleSI6ImVuY3J5cHRlZENhcmROdW1iZXIiLCJ0eXBlIjoiY2FyZFRva2VuIn0seyJrZXkiOiJlbmNyeXB0ZWRTZWN1cml0eUNvZGUiLCJ0eXBlIjoiY2FyZFRva2VuIn0seyJrZXkiOiJlbmNyeXB0ZWRFeHBpcnlNb250aCIsInR5cGUiOiJjYXJkVG9rZW4ifSx7ImtleSI6ImVuY3J5cHRlZEV4cGlyeVllYXIiLCJ0eXBlIjoiY2FyZFRva2VuIn0seyJrZXkiOiJob2xkZXJOYW1lIiwib3B0aW9uYWwiOnRydWUsInR5cGUiOiJ0ZXh0In1dLCJncm91cCI6eyJuYW1lIjoiQ3JlZGl0IENhcmQiLCJwYXltZW50TWV0aG9kRGF0YSI6IkFiMDJiNGMwIUJRQUJBZ0FPQjNsQWdYWEg2UURjZnNVVDdkUzRrOUtcL2ZuSmRlWkUrd25BVno0bWh1SGxwZXlRU0ROeEQxSktZR0ZBekg4dlk5NFNYaThFOXY2VVMxbUNUUG9WdjRwTnpVUlBaNUtOa08xamRvSzRQTVJWNXl4bmRlUzkrbGliWHdtU0lVeHJKNGgxR1Z0RDNYZ2taQ25DOGs0YlN5UlRESDZHNDlJKzl0SnNrWE5DRXNTbCtmWEVkNldneDNweVNNbWJrM0htSmFONEE5RVlkK2hUYk8rSEtXYWlvelZGMHd3NmxcL0ZIYm9qZXhzSnFpNXJrNWxCTGpTYUJFVjAwRXk5RER5UHZueTgzUWxHTW80SWZrYlBlZERqdndFbGFmb2NSalwvOGFYb3N1S0kxWkxtOHlKT3RvTmRKbHFSN3lkS1VyMUo2eGQrN1BMNEg4eDdiTm9ON2t4d2lhVjJBQm8xTmFLeFVwWDRsMTBnWURBandhZ2hqOTVUQlM0azNqZlZRWEg2TExPS3BCXC9JNTRlakVwZEJMY1wvZlZtWHQ1R3FvU3FsUnJkWmhYalBxXC84UjV3YzhWM1wvdk9mNFwvYzhYbStDaFhSRWtKVEdJTWZrVmlYUnZ2YkVYYnRNcWNDQWVLcm5MVzN1WlpKa1ZzRnRoZm9vaEhSVlhSWHdsSXVZMXlTKzU5Q3JUYWtOOWxabk1ibnFkMFJCdFF5QXMxVENQMjdMbERPWEo0dnRTZ3k2OGk3QjBlYzlnN0NqU1RGaVZkYlhcL3ZYeVBFZ2V4aXpZN3k4XC9MV05PcWZDbjU3a1FOZk5JcURldHRaWkJXWFFtMnlVXC96NVhmYmNUYmZiY3NueEt5dnhUU3QyWnpoS1VDSVNvNFRSbytjdGtQY2FyS205U0szUHVGakNZNU5xZDJ3c3V4QSt0VDhSNEdMZ2JzRDZlTGc0TVErZ0FFcDdJbXRsZVNJNklrRkdNRUZCUVRFd00wTkJOVE0zUlVGRlJEZzNRekkwUkVRMU16a3dPVUk0TUVFM09FRTVNak5GTXpneU0wUTJPRVJCUTBNNU5FSTVSa1k0TXpBMVJFTWlmVk1lWWVnakdBSENYY0FOeEJVWmFuZ3RDWEhSaU1qMERSeEJBSmd6RStwTGE1NFwvQmxxWHkwXC83Sm5kOEJvM0s1ZzBqVmlzPSIsInR5cGUiOiJjYXJkIn0sIm5hbWUiOiJBbWVyaWNhbiBFeHByZXNzIiwicGF5bWVudE1ldGhvZERhdGEiOiJBYjAyYjRjMCFCUUFCQWdBNnJTd3FmZkM5aDRcLzlUOFJpRTVTWVwvcTFFOEVFOEt4SEpxc2FaZ3VCSXFMaDVUVWxxbmJpUG54dmFVdjB3bFlFN3lJU2NnRXVQM3pIYVZRN3lRQW5CdjcyMFBCZ0ZZbzJXdXQ3akRHc01vYk9Md0xsRDA0czg3TTdJSlJMSTh4Zmd1XC9hKzcwRE15RnFhWnh1RDJjSUhkejNcL1U5NFRhWXUyYnlBdmdKc1YrVHltMnRVZHM3OG1QeGxRaENXQTQ4RDByWEk0NGNsQm9wTGFYbjRWdVlYM1p5SFVcL3VGVHlOaGlWZmRxUTJaTTNoTXpXMENwZzdUWHhZaTUwa3prM1YxWmQzNldcL2pKQmpwSnlPaXdiNVVHTXhhSkhvMzB3dU94QzN2RWt1YjFqRklFc01ZckZVWGNBc0lHb09OTTl0WmxlaldFK2ZPM2pkOTVCQjNXTlFqQnhjOVh5NlV3VzVjZ3ZlUlhqUmhMZU1PUXRPczdrQ3A1MCswNWRIMnhOcDM3SnBBeTBRS0diK0dRSEhwUm1ESmphT3VuYW4xcUVoZVBkV29RS3pIV2tkT2pyeXA4bXpnaWQrSVA5bGV0N3E0b05IN1wvRWpab2UyNjM5MGVKRUJ0VVJWaEFrNmhzcjBOUDA5bVRQTlp6N1NzUXhjTTlkUDRzSzVtRzUra29tRlJobHVLQmZoK0xKamlFRWhCMHo1VjFtUXJwNWk1aG8wZzdwT3lVSXpPZVwvMWZjQTh5MnFiXC9JTDRKTFpEMmRtZXoydWc2bmpucnNUcTMrenpnUjNJRW5Sbmh6QlpuRWt4SW1GdXh6XC92aUdhcTBWemdBMFpUZ0RuaHF5V2cwQUlIM0ptWnVkdkFiTnVRM0ppMHpkVVRRVUp0NndMNkluN3luZktPRW9cL2dDVXc3QkJqWFI2aDRrYko4cEZtTm1qUU1sWnBBRXA3SW10bGVTSTZJa0ZHTUVGQlFURXdNME5CTlRNM1JVRkZSRGczUXpJMFJFUTFNemt3T1VJNE1FRTNPRUU1TWpORk16Z3lNMFEyT0VSQlEwTTVORUk1UmtZNE16QTFSRU1pZlRTMG1ncmZLYVoyTmt1R2s1ZlcySTVSaVVya2pJMDJyTUN0ZnFYXC96SmJhS3RJOUJabWNmT2tSZzJwWlN5UjJwMUNNIiwidHlwZSI6ImFtZXgifSx7Im5hbWUiOiJTRVBBIERpcmVjdCBEZWJpdCIsInBheW1lbnRNZXRob2REYXRhIjoiQWIwMmI0YzAhQlFBQkFnQXhnNkYrdkkwbVpYZUZZMUFLS1hKZkk2ZEFWRzlGQlpMXC9RSFdoeHJxWHZRKzFONW1mOHBsNWVEVmNrZE1pNHpYNmx3XC9ibGJEblwvUGhwVlVFVDJISzdIYlpyTVBGalwvSDc0aVwvdjhKZTB1OHJjd0pTUlNEMVJyc1A4bjJvbDJiZFZDNm9TUURIcEJ5TGhaRVA3Tld3VkMwQmM2U3N6UkxrdnJCV1JqK0R4aXBCZUcrV3U0dW50MGFTUTdnb1FOY0FCTlNCaFwvU1dLUnIrbHBtcUJTSVgyQnhqZGhvTFRzUW9OUllzRlpZdGlcL3dFYmNjelhaeFhTdGVjXC8xUkdlUkM5SzlzUUdHV3daU0lXT3luYXpOc2N2OEtrRXRKTENDaEpqR040XC91Wm1QYVl6b3MzR1NmOURqdEVpcHhJeFM4NDhnRXBKR1YwRDc4blQ3VzFlelwvR1BkZU40TCsxbzhYeGEzTkIyVTB0TGkwRTNMbHhPWHhqSkJDT2ptYjBcL3llbytxU3NuMVwvRk9kV2VuUVk2N2tYc3o5NzhpZGFvUUFuTEFydkVtcjlHbHAwVW9aKzREVlhuUVwvN1pXM3NCeDIwdDJ4UEFGNEhxQUR5dHFGSWhBREplWDdrNnNzVFFTNE85eTZhdkg3OHZpRmRwVU44UXpaTEw2Sm1RKzl4dkRtYkQrRGFWcE5pRWN2RHEwbWEwVEsyTVl0NUpMUHFwVkxrc0VZNm5XTnBBSnRyMnBZOWxVdGtBRjlaNlA2MnFoRHhTa0x5WUhaWEdnbDhlckJncm1jRWNTUFB0R3BUbzBUQzF4OHNKQ1dRbkZUYzkxMW1xUENEMGhvbzg4VmNuekp3OVRFRW5GbHdwbmJCclpxYWpCdkxcL3JtSUQ4SzlVQ2ZuUTdINVNSak1aUUFqamhENVJteml4cjdVN2hCc080Z3hhZXhnQUVwN0ltdGxlU0k2SWtGR01FRkJRVEV3TTBOQk5UTTNSVUZGUkRnM1F6STBSRVExTXprd09VSTRNRUUzT0VFNU1qTkZNemd5TTBRMk9FUkJRME01TkVJNVJrWTRNekExUkVNaWZhaXB0YnBKSTZ6dUJIUTA2ZllhOTdjdnl2a3MrcG1BVU5WK1VkUFRhcHh3WnQ1bjdwaFc4SzR5alwvWlJsclJxUmRHcFQ1dVhIUUoyZEFnZzYzZz0iLCJ0eXBlIjoic2VwYWRpcmVjdGRlYml0In0seyJuYW1lIjoiUGF5c2FmZWNhcmQiLCJwYXltZW50TWV0aG9kRGF0YSI6IkFiMDJiNGMwIUJRQUJBZ0FWT282ZWFBNlJEcDlOY3lmK2NFMVU5XC9NQUNxMW5Ha3gzV1hIRmVMcEtSZ1hieTkwOVR0cCtkWTlFSFdMVHppV01scGhvdFRpZk92cUFoRlEwVHJZQWQ1VkFiYWpCallKdjArbEYxZlM5YnNzcm5cL0FjcXM2QUY5WlFKQXcrRmJqdE9CdXE0TFNDK0trV0lBWnRtWTBaeXJ6VktRRmtHUHBZV0h5anhYQStMS3d0SXc1K3p6elZKeDl3M203NGlqdWFTYXpiMjlhYk93VzNwXC9OV0d4TUwzSHNZMUNcLzB1V1prdjJ0RFwveWFNNnk2YjQrXC80RXBVcnIwMmhqakxXVmQzVlwvS3ZXWWgrN25XcVF0UTBkRXBEd0QxZWJmU0wweVJBYjRPSW9oOFBpTytuYTFteWdKaDBUZ2lUampCQ2dRcWNFUkM1bG1vcHdnbEJYUzJZUEZwNEZXZ0RidlhjTFZHeHh6b0hsbGk0dTFWYmVoNVcyU3RpWEw1anRQZk9cL1ZOano2Ukdud3RWWG1lRnRNeHFlSjAxY0hLdmVMXC9YejF4SWpRSTdBWHR4eFJFUVMyc2orc2krU0IzeFpcLzBzb21JQmVJTzVNVWhGcVwvanRJVERDQXNJbHI2NnBUcEdUMThCZ1JBXC9ROUFMV3VGV3p1bkNxOVNRT0V3M0lSOXNPQ0Zib1FvWEtWRGM2eGlWZWwwTjNyWHJjcEtrT1FRUHpQazU5REhPNGlvWlAzTThZTm81SUVoWkFINnI1RmJYdVRJdTUxQ1NXRWpLTTFRMUdJdDhnbjhLUThsOHFUQ2tkYURmNHhlUjFPQ1BpRFdHMCtTRGdTUnJuUmExMThvbmF1YmgzRFhSeW16WktXV3YyNWJKVDNjcVd3OHhuZTBCTDJFMlRvSllEK2dFeDdPUkIycGpNT0FvZTJjVzhaSW02SFFKSDNBRXA3SW10bGVTSTZJa0ZHTUVGQlFURXdNME5CTlRNM1JVRkZSRGczUXpJMFJFUTFNemt3T1VJNE1FRTNPRUU1TWpORk16Z3lNMFEyT0VSQlEwTTVORUk1UmtZNE16QTFSRU1pZlhveHA0d09BWEZMYmlvK1pcL2lvMHlaZzN5Q1JlVnZOYzViTTlVblA5S2I0Zmx4RXFCQW95UWZEU3VlZDdUMDNtNFVVUG0xZ1BHblZcL1E9PSIsInR5cGUiOiJwYXlzYWZlY2FyZCJ9LHsibmFtZSI6Ik92ZXJib2VraW5nIChOTCkiLCJwYXltZW50TWV0aG9kRGF0YSI6IkFiMDJiNGMwIUJRQUJBZ0FUR3dPaDh3Z3JraXpHUnJoeDNEZVg3VWVFUDVVWjF4V2RjeHdRWVlpR1wvM3VUdzFza2ZtQng5dEtTRDVCZzcxTzU0OGo5TmxlcThQSHFcL2JocnljZlBZU1ZRN0JpcURiN3R5MTBGWnFVNllsUzRqcURLSGlMOHNWeGVOXC9vZU13TkFqRUxNV2RSdXQ5UkNWMHRhaE5jUk03Nm0wT1dyVnhCTVhTSmJPM0tXMTRVMzRjT1pRbWRpY3p4emNQaVhtZGdHa0t4VUVZdHNqK0g3UWg3MTFLOUZBckdVeklIUlh5V1lLeVYyZ2p4dWRSTlFObDRcL2NXcjZNZWJtRnQyNW5WRkMzY01leFRrMk84bERzazlMSEFPOGdvMXZLaTQ2cE5CVnJsdHBcL1QxYlFTM085TGxmRW9lUHBlY3V0ZFlhKzRVd1dyczhcL2tYMXhpOWlXVUtzMXFVTWR5SWxPNGswYk1kVURxa3c1NG56Z1lSRmdRMWtBeERTRHFYbkFNcFRqR2Q2RDlzUHJ5Q05WdGhLT3FWdlErMUQ4aE55M2xYb0tcL2hJNnIwRnRrTkdDeDJHcEZ3Umh2UXJjV29udEJ6alJiTGdjY0R4RXVLd0Q0OGRVV3BLSFpBY1NBdWJKR21JMlhRNGVNK1l6Q3JreE9DaFB5b09HVzZtWm9Yc1NjcWIweVVMK0d2bWV1NUJ3dlFrMTJ5Z1JYZ1NERHo4ZlVrSEhqQzc0clQ5TUJTbXI2TDR6THp3V0RqekFCczRJMFRcLzZVUUhPV3FhSTlIZHlpUDJtN3pGZ1dDOGQyWHhNZzZCVThzUjVzY2pmV2YxaHFxRGZuTVVJc0J3c1NzazFNZ1BIWFBJSU92QlNrbGZQQnlIckhRMmZcLzBmMTk1SlI3UjNxWnlvc1hBZGoxZGVMeEFWczkzdWg4SnBYUUFkcnJIdWdtbjlBRXA3SW10bGVTSTZJa0ZHTUVGQlFURXdNME5CTlRNM1JVRkZSRGczUXpJMFJFUTFNemt3T1VJNE1FRTNPRUU1TWpORk16Z3lNMFEyT0VSQlEwTTVORUk1UmtZNE16QTFSRU1pZmRwYmJVMDYxcjd5UUJKNXpST1Q3ZHVSZXdMMEk0TEJKU2p4Sk4yRGt6UFloKzZDRW5sOEpNVGViNEZoNEFacHc4UlFDVVc5NDNFZ1FpVzciLCJ0eXBlIjoiYmFua1RyYW5zZmVyX05MIn0seyJkZXRhaWxzIjpbeyJrZXkiOiJlbmNyeXB0ZWRDYXJkTnVtYmVyIiwidHlwZSI6ImNhcmRUb2tlbiJ9LHsia2V5IjoiZW5jcnlwdGVkU2VjdXJpdHlDb2RlIiwib3B0aW9uYWwiOnRydWUsInR5cGUiOiJjYXJkVG9rZW4ifSx7ImtleSI6ImVuY3J5cHRlZEV4cGlyeU1vbnRoIiwidHlwZSI6ImNhcmRUb2tlbiJ9LHsia2V5IjoiZW5jcnlwdGVkRXhwaXJ5WWVhciIsInR5cGUiOiJjYXJkVG9rZW4ifSx7ImtleSI6ImhvbGRlck5hbWUiLCJvcHRpb25hbCI6dHJ1ZSwidHlwZSI6InRleHQifV0sImdyb3VwIjp7Im5hbWUiOiJDcmVkaXQgQ2FyZCIsInBheW1lbnRNZXRob2REYXRhIjoiQWIwMmI0YzAhQlFBQkFnQU9CM2xBZ1hYSDZRRGNmc1VUN2RTNGs5S1wvZm5KZGVaRSt3bkFWejRtaHVIbHBleVFTRE54RDFKS1lHRkF6SDh2WTk0U1hpOEU5djZVUzFtQ1RQb1Z2NHBOelVSUFo1S05rTzFqZG9LNFBNUlY1eXhuZGVTOStsaWJYd21TSVV4cko0aDFHVnREM1hna1pDbkM4azRiU3lSVERINkc0OUkrOXRKc2tYTkNFc1NsK2ZYRWQ2V2d4M3B5U01tYmszSG1KYU40QTlFWWQraFRiTytIS1dhaW96VkYwd3c2bFwvRkhib2pleHNKcWk1cms1bEJMalNhQkVWMDBFeTlERHlQdm55ODNRbEdNbzRJZmtiUGVkRGp2d0VsYWZvY1JqXC84YVhvc3VLSTFaTG04eUpPdG9OZEpscVI3eWRLVXIxSjZ4ZCs3UEw0SDh4N2JOb043a3h3aWFWMkFCbzFOYUt4VXBYNGwxMGdZREFqd2FnaGo5NVRCUzRrM2pmVlFYSDZMTE9LcEJcL0k1NGVqRXBkQkxjXC9mVm1YdDVHcW9TcWxScmRaaFhqUHFcLzhSNXdjOFYzXC92T2Y0XC9jOFhtK0NoWFJFa0pUR0lNZmtWaVhSdnZiRVhidE1xY0NBZUtybkxXM3VaWkprVnNGdGhmb29oSFJWWFJYd2xJdVkxeVMrNTlDclRha045bFpuTWJucWQwUkJ0UXlBczFUQ1AyN0xsRE9YSjR2dFNneTY4aTdCMGVjOWc3Q2pTVEZpVmRiWFwvdlh5UEVnZXhpelk3eThcL0xXTk9xZkNuNTdrUU5mTklxRGV0dFpaQldYUW0yeVVcL3o1WGZiY1RiZmJjc254S3l2eFRTdDJaemhLVUNJU280VFJvK2N0a1BjYXJLbTlTSzNQdUZqQ1k1TnFkMndzdXhBK3RUOFI0R0xnYnNENmVMZzRNUStnQUVwN0ltdGxlU0k2SWtGR01FRkJRVEV3TTBOQk5UTTNSVUZGUkRnM1F6STBSRVExTXprd09VSTRNRUUzT0VFNU1qTkZNemd5TTBRMk9FUkJRME01TkVJNVJrWTRNekExUkVNaWZWTWVZZWdqR0FIQ1hjQU54QlVaYW5ndENYSFJpTWowRFJ4QkFKZ3pFK3BMYTU0XC9CbHFYeTBcLzdKbmQ4Qm8zSzVnMGpWaXM9IiwidHlwZSI6ImNhcmQifSwibmFtZSI6Ik1hZXN0cm8iLCJwYXltZW50TWV0aG9kRGF0YSI6IkFiMDJiNGMwIUJRQUJBZ0JXRGlGckYxQmpBa3lOUGRCdXdBNnE2U0VFbXVZUTl2MmVBYnBUbFZpemlxTGRqMStEMDFkb3Eyem5rY0NvYjlYVGZqZkdacTdsSEJsRUptWHFuUlwvVmtGN3RLNGRwQnVRTnUwXC9DSmxEbmVFSmY1a2M1MVlpa0JaVE9HQ3U5WnN2ZFwvVHF5ZjBmV3llSHcrY0xnak9HV3RUYjg2WUp0RDdsU29GVFJmNlloQitISm1GK2xKVkxuT1wvQ0RSMGNpYUlLRjNmUGpBWFwvajlhNERLcEtnZTFHRGtmc2tzd3pnUStQRlNla0orMENkY2dUMjZKaGRcL3pnSGVsSHBDd0xCdVJhRWYrcFdBZk9cLzBVdG5CNW5OSFVncGZ0UGVKdHJTN0xVeWdhMmU4VFYyUHQweVZJQ2xoOWZLVUhuYlBncFZlSUJoZU5jKzZ6ZWlyUTcrMmFPUVE4OFp6bE5ySlNFSVcxRjR6N1JXTUJ5aGdhQTBkZE1WVUxzRW9YcTRrQnBVZ1BhaFwvZnk0NG1UcFRvb1NUcWRIbHpWb3ZVZU4rUCtja3FSTHQrQVJiNjh5U0NVWjlCUTY3bFNOeHdzUWNkNkV0dDlXUUtpdnZOQStYeXY1QXQ4YWVwcnhaVFVacnA1c3RZUXRKbWFSdXRIR2F2b3N4WU45dElGbEQ1MG9mNVowdXlsaTJmNnR4ekVPclRqMXRQd1psSGRvUWpaMm45Qmh6MTFmWlE3dTZFb2tiblJqUngwS1VFTDA0REVOYlV4T2QwWHlJTXp5NllvUXpKT2RKTnBcL2VMVzExR3RmcUxQOEtoR2hXdnhnUGdyWVVcL2ZpOVZhYlwvVFB5RlZpSGlaRnM2VHVFUWw1bUp1endaU1RHekxJRVFsYzJsZGQ4ZllXQ0dLRGplUFBtQTF2cUdCQ042XC9QUHE3OVlnZEkzNEdUaDlBMUNBRXA3SW10bGVTSTZJa0ZHTUVGQlFURXdNME5CTlRNM1JVRkZSRGczUXpJMFJFUTFNemt3T1VJNE1FRTNPRUU1TWpORk16Z3lNMFEyT0VSQlEwTTVORUk1UmtZNE16QTFSRU1pZlJwQzFrUVdxbGlQYXBwK29oYnhSUkZqN1FrM1RpOGdaRElxNmJmdTdLNGZEeHFnMGUrN3FEN3hEbjVsRzk0QWF5S3VPWWtUIiwidHlwZSI6Im1hZXN0cm8ifSx7Im5hbWUiOiJFZW5tYWxpZ2UgbWFjaHRpZ2luZyIsInBheW1lbnRNZXRob2REYXRhIjoiQWIwMmI0YzAhQlFBQkFnQ2xwNnA3T1pqd0VDclg1d2dHRzlQVUltUHJ0U2E5MmthQjZleDF1T09KN1VCZWRPeEN5dm9neWtNZGFCa2xcLzdzSGlGMVVWSVdIME9RT0MxS1pBVWd4cXhUeUxLa05rOFFcL1NxaTJUXC8yVVJrK1grV2xmaTJwTW02YUU0VE56MVlUb1pmOWtuRSttc25Ubnl5WnVwZzhVdGlKdjZZR1pmaktXRWJBRmFaT1VZemFjXC95NFZCd0FwUzI5TVwvZjNkRXRUUnZ1SHF1aU5LWXpsejRCdExhYnRsZWplcUtaOXA5SE5sZmRSY09UTTVhK2xkTDBaVDdSVDJqMGYyb21WVEJkXC8xZm4raUVLM2dMQkVVcHo1bmNnSXZBSlRjU0ZQS3lTY2IycGVTSFJkUHY4b2lVZHFDQU95SlVNR1hiNkJNZDFyMlZkeWhodm5HeHMrQzgrWmFtY1ZwUkJQQ1Y2YXRYbW5lNGdnSGplNFV1bVprYUpQTWlDbmJrRVZvS2QxU25pQXpNTE9cL2E4M0lFUWhjT0J4NjZYZFhsZjdLbUhqcm9PT1UxaE1VUkp2V1F4QnIweTVTN2tzRHJiWExMU1lsZXA2MXRrT2pDQVwvQzlqdzd5MXgyZ0ZJQnBTdEV4OVJad0s4a1ZoVVlcLzJBR2pqN1U5QXJUV25cLzhyODBsTStoaTV6dHlrSXU3NGtSUjJiRnpuRW1CTzVucloraElZZnk4U0x5UTJVY052djlucERZUG1VblZuNytWcEZRcm9UMjMyUGhhUzdSTXBLK1FzelprdDBNTUtRbnQxbkdcL1FRSnZlVjl6b216aTE5V0pwSkZcLzVWbEdCOEFMcDFlRHhyV0x2ZUJrT0t2c2xLbjVIMVwvb0cwQWdKT0dOdEZPbU4yeGJoOUxFYnp5MGs0cVQ0eEMrTXZBT29wVDRZRm9lUGFmSzJWcEdBRXA3SW10bGVTSTZJa0ZHTUVGQlFURXdNME5CTlRNM1JVRkZSRGczUXpJMFJFUTFNemt3T1VJNE1FRTNPRUU1TWpORk16Z3lNMFEyT0VSQlEwTTVORUk1UmtZNE16QTFSRU1pZmZkZmZLTlhSQklVUDJyXC9LNm9TK215R0FQUk5zdFh6d2hJYlgyeGU1bzE4RWpzWFNTXC9TYytna050S0hrXC91S1QxZ0pOMGl5RmN0K29HSjh6Zz09IiwidHlwZSI6ImRpcmVjdGRlYml0X05MIn0seyJuYW1lIjoiSW50ZXJuYXRpb25hbGUgT3ZlcmJvZWtpbmciLCJwYXltZW50TWV0aG9kRGF0YSI6IkFiMDJiNGMwIUJRQUJBZ0JrNzhQTjJ3R3lnRU9GMGwzTXFmM2txUllvN1pSQW9ZR0pXVUs1eEdwUStEditUZTNNZzVhOE11VmhmXC9laEpKdzkxemJJc2k5TWR0cUtVXC9cL2c2Y21EaFJIWE91akh3YWxOQmhLRlpRNG5sRjhXU3hmMnFTRTREemVKZUNwQ1ZkWkl2OVB3MnNCSkJFWDMxU2N6XC9JMGhxSDg1aWJ4NWt5ZkRzbTN4RmxtcHJYSXQreDFnZ0lWQ2FtdUJQdVJOWHFRYTZpM1M3UXdtVXZZMnBIWEVCN2VRUjBHM3c3RDcrd1JMcmpmS1MrWG1zYm5RYkpjZmNPTXJKdWQ5Nm9kNllnNG1qdXR6U2NEZ093WlQ2b21jRnhBdHk1N3IwQ2Z0d25UdzNDSitPUXd3U3VpUVhVbEg3a2pLcGRSV1pESG80WmUxK3k1Z3hMNFhFMkhPQjRiM0ZSTkhWanpvKzBROXhST1plWHg5aDFwNTBLNzNyVkU5RkI0QWNjOEtSU3ozYkN1eFU0Q25HelQ1SGpOSkwrU3BTR1RkVkFUMDRoN2RhNUhXSjZadktTYTU1OU5oNmtPSXdTaE9aVjhMb0hUS1BEQ1FsaHB6ellcL2dieHVJYzc2Wkx5RWs3VzlvdUh2NVNiYzJ3a3o1MlNVdzhoRGNRbFZVdzJ2cGJ4WnMwdk5Yazhnekk4aFEwY25ScHFMeUMzTGwwODdyQUN5QjVvcDIyZER5OVpkVFwvZVkxWjlYbU5ZcWxiWFYzZlU1NjNCRGtFMUR1cWpnNlIzeGhuOE5NK21IaXJ1THNYVHk2dUZYcUtKc2o5Smd4NmxURGVlM2lDSVdkVFF6RkFEY1hLbVdXVmlmdnZ0a0pselNMUTFXRzROeHFEZ0d0ckdqVCtiMnVNSURqZEdwK1dhTlRlUkRwVlB6V3dhT1JURHgxME1pVUpHQlhBRXA3SW10bGVTSTZJa0ZHTUVGQlFURXdNME5CTlRNM1JVRkZSRGczUXpJMFJFUTFNemt3T1VJNE1FRTNPRUU1TWpORk16Z3lNMFEyT0VSQlEwTTVORUk1UmtZNE16QTFSRU1pZmFHQlE1bnIrMDg3UkRSdWNHQTVRdDRlTzI2SU9CaWQ3YVc3RzJnbFwvSmFFdlhxYTU3U1FxeVpVNmRZdUs1dVdlWWVmZ3NBdGtwS3UxVDRpVUJZPSIsInR5cGUiOiJiYW5rVHJhbnNmZXJfSUJBTiJ9LHsibmFtZSI6IkNhc2gtVGlja2V0IiwicGF5bWVudE1ldGhvZERhdGEiOiJBYjAyYjRjMCFCUUFCQWdBT3NTY1c3Q0daUkxFTERuQktPbFUyQW50andwQTJlOUg5cHdyQ2E0cjd4K1NjTE5KK3VFKzd6dnU1TnJZOFVcL3ZBOENNZ21sZFQ2NWlKNlFyRHA5SFhSd1VRUlk5QU13QjJmZW9DSFVTZUVcL1dTMzZlZkF2Z3NXSDh0dW9DaVMrM1lXUzIwcTFwTGI4VFJsMDltMGdpQ2tGQVFcL1h5M2Q5QU1oSWZzaFI0a0ZiVDhcL2pJb1dCdmhuNm54XC9oR2JzRHNUZTk0SlB2NjFNWldXSFh3V2R4T1FxQlRRVUZSSzdhVTNzVjBZWjJjMG1VYXZSMVRMWHo3UEFpSGg2MExVdENibDZqcVJuRjJGaUpNXC9mZmRjZWxudHZWdTNVOEF6akc3bGJ0XC91Y1hjMVhqOFpHK3l0TzdTTUdmQWs4azZZMjhNWmNIUFNURUJsbTBCSTNyVXdrbVJQWUdOeEh4N2J6SFg3TWVuN1VyWkhsVnpEV2xCMEl6MlFUY2dmXC90bG5jN3hJdVRrcXJaWVcxYzQ3TnRyOTlmbTdwQjIyeW1YdEQ1NEhRUlwvUlwvdFVmdlA3ZThyWTJncE54SGRHMEtJMGNIQW1CVTRXY2RxcFZ2TDRHNmMzYzV1RnhBUVJKbVhEVjNHZjBVTkF4R0plYXcybExNQmNueVQrbzBjdHFFWm5ybzdmVG5WdHhpazZLMnFUenN4dWwwVnZjd1cxR01JZUZCVXU3c0pDYzdod2pRMStjNm1xXC8yaXdrTFNhdmEyc0JIWVJUeDUrRU1uRitETGJDMklWNDVsSnN3cWU1WW8rWmpDZ2JkVENDVlBZbCtqSVZYWW5iTGtmc013aFErMzZoZENCWnR0SkUrV0x4VFphdVwvREVyR2FmTHg0M3k0aHpwSnlzSWZzUWtvZHV1aEJBeFwvcWhCYng1cVZCRTREQmZSclpQUkFFcDdJbXRsZVNJNklrRkdNRUZCUVRFd00wTkJOVE0zUlVGRlJEZzNRekkwUkVRMU16a3dPVUk0TUVFM09FRTVNak5GTXpneU0wUTJPRVJCUTBNNU5FSTVSa1k0TXpBMVJFTWlmZHVWOEk2b3RDdFVyS0tVaFJ1MEFFQkpFODZDeTkxc1BZXC9vajNIaXZFZHExcFJpeHlXMEMwdzRpOTlSYTFrSVUwYVEzK2M4UG5zWiIsInR5cGUiOiJjYXNodGlja2V0In0seyJuYW1lIjoiTmF0aW9uYWxlIEVudGVydGFpbm1lbnQgQ2FyZCIsInBheW1lbnRNZXRob2REYXRhIjoiQWIwMmI0YzAhQlFBQkFnQTdLMW5DdGpkS1AyNmZrTHBoMWJGaStUaHNxTHdWME1mTkxiNEc1MEYrQ1JoaTlzcHAxSjhWNEQ2S1BxMzlzQUlnenJ3S1hLclBKbkNUZDRcL1BXVlh4aW9HZmRleVdMUk5cL09ZVk9wejBDemdWQU0zdThTYWpubUxnNjBHXC9LdkdIQ1lUSFZPMnA5RXpYZDQ2MkR1V1ZreVUxMDdqdXRaNWthZ1pWXC9OazMzSjJ6T1NLZTM0dVBnK2tYOW9pUE4zZHpBS0tGY0ViN3NuMkk5cUp5WW5wUDRIb3dDRnBQbVVUUTdJQ2tKblVUMG1aaTBHS3ZQMFRHelZ1RVUyNVlJWjc4M3ozcW1zbHViWTEyN3o4RjFUTXZXQ29sTWNFOE5iNG51WDN3N0JnUDVlc0MyNjBEVDNqaDNFbVM4SXRnbEVmNVJjXC9pTDJaVFRFRk5YZkZFUmZHa05teDNzWjJiZnV4VkZsWWNEeWs2enVJWFJEUlF5Ukw4dEtMUDR4R2V5RTNmUGV6cEVmdGlET0RUNGIrUG5SdG8ySXFsXC9TcHVoYXdDNUdHT1g1NWpvUFVBUzZINHRsT3dPUlZrWTJMYmt4RG5ONEVBakV0UG5Vc3RyM0ZvaDUzaStSeW5nTU0xdjFpUDlvYmRqQ3dycTlNdm5pN1VVTnhRcFJySXh1blRxdStBMzhPTVZGZExVdlNqdjZhN2Z4RG5nU3F0WmhKM1F6SjBCVVwvS0pheExySDNNYTdITWhJRkhPUXNSVXlMK1Z2VnFQeUZoekVaOHdVRUVCbFhDK2NmRW0weHM4YmJlRHZUYVdTYTZOQ2dUOVVtaXhOdXNtbUI2NFRHcXZ4YjIzZGVcL0tsWWcrb1ZkYWc4SWVGcXJXVWc4THVsemlEalRyUUU2UnlYaUxCdFRMQ2hBZGNRRmMxVzFMTEh0UE5zZVMxYU5yQUVwN0ltdGxlU0k2SWtGR01FRkJRVEV3TTBOQk5UTTNSVUZGUkRnM1F6STBSRVExTXprd09VSTRNRUUzT0VFNU1qTkZNemd5TTBRMk9FUkJRME01TkVJNVJrWTRNekExUkVNaWZjSWFMZUZvSnlnVDJCVEY4OG1sR1RDaUU5NzVncng4RWFtZUw0SXVXQnRrWlZVNkdHejhWVzg4aG9YU25iZElic2U0QmlWNlNzTkNzVktRV2xJPSIsInR5cGUiOiJlbnRlcnRhaW5tZW50Y2FyZCJ9LHsibmFtZSI6IlRlbGVmb25pc2NoIEJldGFsZW4iLCJwYXltZW50TWV0aG9kRGF0YSI6IkFiMDJiNGMwIUJRQUJBZ0FnbTkzdGcwNG82S1wvSEUxSFNCMVZmczRkeWZoVSt6KzNSNWxcL0Fma1dSdG1xc0tTUlpUZlZzVjlWd2hYMUlVOE9JMmlLcVV4aDN2dURXdXVtV1JhNFlTNlZsOUNkRkRudEZFakppSk1wVVd2dzVyMlNXdTh6T3BidWxPWnBWSDJjd3NGMHNEclRPbStQYUFkcHVtVFVMVmZSUW9BZkdGTStKXC9IZUlicVpaTlpIKzlnN2tYWVA0WXNiUWJ2NlowSWJ2Z25cL1lnNERabFM2eXhYV1hUQ2dFXC8zVjlwb3VVODJWTXUrb0V5eDRRR29mMnhDUkZsWnkwVXh6SVdRTTJEYlNJVFNqUEJIZWcyeUdCK2YrMzRwRjRDKzdUQ3hzZ3d6bWtkQWJSN3BqZ0pDVEUwY3IwS1Zoa2hRZ2Y4ZTQ5XC9ybjdrN055TFlsUkNzb2RRSFlSZFk5T1JLS3ZLOW5HN0RmeldNeCtRNktmSkt5b2FlRjB2V25OeXJVNlN4N3RzZldoTlpkaWFONkpwQlBYR1NyWVZibFwvZkdoSk5QMjJYQW5BNlhnUWp6UFNwajc5WnpLZXIyQ29jRjVHbUs2R0MwNG85dXUydURtWjBoOXM1ZnRkaU84WUxGTVU0VURKd0tuWE5JVlhpSWhjbzY1MVhja2orU3ZMN0tPQ29cLzNDb2lJMVMzWXBkS1prWTJcL0s0TDEwUGpNWDZGVjVBRlorVTVWbmRlTkRZYkJLaUQ4NXNlRnJpRnF4V1EyZXNEWllJMjRLcGZiWjljZkpIVTlSdUg0M1l0UjZKbXN1QXF3SGJXYTBDdkQ4eHUzaFZwdmcxNHF1a1wvZzRMRUJSRURBZzZXSElITWxJZ1hHM1RCa2dQSXdCa0M4d3RIemlla1VrMlpzQ3pya0NVQVhkUnhEYXpTT08wM1NObWpkU2o1bk0xRlZrQUVwN0ltdGxlU0k2SWtGR01FRkJRVEV3TTBOQk5UTTNSVUZGUkRnM1F6STBSRVExTXprd09VSTRNRUUzT0VFNU1qTkZNemd5TTBRMk9FUkJRME01TkVJNVJrWTRNekExUkVNaWZRVkdtWEhJODArR1VPU2xCMkM5MWpRN3pTaVhTVjRZYjZQMG1VRmpSRXNWNHNsZnU5Tm5mR29PM1JaVUZBS0hGWlk9IiwidHlwZSI6Iml2ciJ9LHsibmFtZSI6IlZhc3RlIFRlbGVmb29uIiwicGF5bWVudE1ldGhvZERhdGEiOiJBYjAyYjRjMCFCUUFCQWdCV0RNeWpVQm5hSmwyd2U0Mm1VcjdONnZVQVwvc0pnNVFxYmk5d0Z5dlpRU2N4TEZrdWdTclJmYUkxTndNWXhRYTRBRlA2VW85V2xnMVwvQ1dkMkNZWE9PbUVkRVltSU9zUzEwTkNVSzN3XC9aSzQ5UmRWQm5FbE1iQTZvTUZrMDlBYUF5VDFzUUVBaTZIY3J1bXRabUZiQnZDZUUrMGZ2d3h5cXl4dk9DRVlTXC9Xc0ROY2pPUTVQQ1pxZjU2Y2lMWGhPZkIrUTdZQ2Ria3JHOGZ3bjNNdTRuZmplZW9LbmZJXC8zTU1Ud2J5Q2RmTjNoRVZINGY2d25XU0xmaDRXUkh6OHBkdlFSdVZVV25xQWlpaFA5UEdHQ0FBSDRmSFNWbnFzT1dzTE1QMDZIZElkWkZ2bktRMnNIeFVZd09jZXZUTVMrbmk5MVFCS0ViRFcxRFJJamZOTmFFUzVUZEsyaGhhSHVaMTEyc3JYRFprUTZibGhuMDhUcVBsSjdaVGpjaUdZNExvM3lIVHlBWjV5YVF4YVhjWStpYXE2SXkxZkJlWVV2ZkRUTmdUc0RGSjBkOFNHcVB6MXdYanIrblF6WXB0ZGNiV3FFM0dwMTNORXpmTW82WTJuVTFEK2k3MEFEZFc1NW9ESkp4QmYyZVhZNmh2NlplNHNlYXJjNG83TE1XZmlQUDJjdlhnNnVCYVUrU1NhVEVLVVhxSDI0VHlwQ1FGamxzOGx3aVkxM2VJbEU3WTU2cHBKYzVuVHgwR3VvUjNHbXRWSk9KbEZhMzU0WmZ1VEMrWWZ6THVSM3BBSXhkNEFxTHZcL092SnRGcFhZaEZtN2p3SkliVXJNSGx6UHE2dnZFYnd3MTQ4ZzNRMTI3b0JuRFJMM2o1XC9LV3FkZDd0bUZUTGN5OGxKR0EzN0JSQzhMckc5WlVcL2xJVWRKY2FTcVJIbTVBRXA3SW10bGVTSTZJa0ZHTUVGQlFURXdNME5CTlRNM1JVRkZSRGczUXpJMFJFUTFNemt3T1VJNE1FRTNPRUU1TWpORk16Z3lNMFEyT0VSQlEwTTVORUk1UmtZNE16QTFSRU1pZlRjbEdleHV1R2JjNytXQXZCSFU5WksxYnR1UDh6YTF5MldxV25WaE9uaEY2XC9WQklKRkwyVFZxXC9JMnNGVXdiQnlOd2ZMdFNpb2M9IiwidHlwZSI6Iml2ckxhbmRsaW5lIn0seyJuYW1lIjoiTW9iaWVsZSBUZWxlZm9vbiIsInBheW1lbnRNZXRob2REYXRhIjoiQWIwMmI0YzAhQlFBQkFnQXFQQVNqWDRUSDkwcW9hZTFUVXZTeEhjNm1ob24wY05mRmoxbTRpSDVJYjlCVjlubkdGK1wvNXZaYWcxeGVQRkFXY3dodUd3TUVZQTZpZEpXNG5DNGRBc0FMbVJBT1liOW9QamhZM1BFcEpPXC9kbnJCZVwvZHQ0SjFOb0lZS01ZNXB5RlBVOGsyME5zdW5DZE56czJTVVJEVkhGc003QWtON3g3RkdmbWZVTTZZVjRiQU5lR2tcL1dnZkltakZ1OWVydHl2SHk3azd5R0pMQVFtYWVUYncxdWFFZmQ1c1R0TDk3SnB4b3JJc1BNRksxanQ0NzQ5cVNiYmpWTUg0WDFHcUVneFVEZkdmeDN3SVgwbjlTMFBXaFQyaE5IY25MSWdWdHBRc3ZwUmcwWWgrWXpMMFgrUHl6dXZtQ09YNHZqRlZkUGViNGk4TEtONFRLc1RaUkJVQmJmMVJtZ2RNcDZGbkx1MWFQSEdBMVpuXC9tTEhqb244MGpkVnhqajVcLytMUWhzU0F1eFRBOEUxT3Qza0ZKT3B1bDFOV3FhUHowemJOdGliN0U5NmxoVWk2M2NmRWdLNDZSRGdvbkRPc1ZKZmhUQ2J0MUFSXC9pK3FSMVhQMDZBaE0rVmx0Z1wvMDg3anJHVmRDZHU5MnR4Q0k2OTBCdVNLb3hOMHZSelJXRUM1ZjRoTEtZbFg2WlhqdmxtTkh4V2ZcLzgxQUhhYWI1UTdYZmlPWVwvY284dzV3TytISzJWZTFCanlSNVBhU0pBbVNlUjN4VTEybUtIZEhxb09RNHBZNnhRK1RYQUZXZkpNVHR3cUdWNFJEMEJZR0VuOTZpUWJqNEhIZlE0VVI4TGFiR2ZlTmNYRVhRR01tcUU1VzNmbmQ0djNFcUdmTm9iSjhqRmJibzhWbGpPRDdIMXQ5eEJVdkk1N2IzdEV3VDcrelNFc211ZnFBRXA3SW10bGVTSTZJa0ZHTUVGQlFURXdNME5CTlRNM1JVRkZSRGczUXpJMFJFUTFNemt3T1VJNE1FRTNPRUU1TWpORk16Z3lNMFEyT0VSQlEwTTVORUk1UmtZNE16QTFSRU1pZlc5emlFY0xuK2l2QWpQaU5udVo1MkFGUDZTXC8zK0VRVGM0RVp6dmN3SlBwc2x1a2cwUjd6SCsxTW9BVjV3d0pwN090a25XaE1kbz0iLCJ0eXBlIjoiaXZyTW9iaWxlIn0seyJuYW1lIjoiTW9uZXlib29rZXJzIiwicGF5bWVudE1ldGhvZERhdGEiOiJBYjAyYjRjMCFCUUFCQWdCT3p3cGlQOEFZMGZpWEJKVXRidjdaK0JKdVJXcTQ4dWNFSVRcL2pTXC9oaGI2UWxXclA3WnRoS0JxcFwvK0F1eFdPVm9GNytmVlpKRHFQN0VYSTB3bTRxVmhaNXpCaGJkM1JUXC9hdFBHMU1rK1ZNMnJoSzdKcndjTGZwS3lpSFBZZ1hyRWdcLzBjb1NKOHMyYng2RWRLY0lPYndwQk1HeWRvdElLK2F6N0JaclFmR2R6M1A1VG1PREhGZTRsd2lFUDY3T085V2FmRGJTa1ZEVlpJRGd2V2l1ZlIwVVZzRTdDd3Jnc3pkU0hxekxOZE92dHFpanM5WjFEU1NQanB2cWNEdDZ5VHBIeTdwMHlJbnRZWnY0SW1JM0VUSGZQcXIrb3JHYlYwa0RBVUV4a0tcL2tHa3J0Y3pNblwvY1hUREI2NlB3Y2RCVkNZZCtDUFlmYkFwREU3TDNCQW9JV29RT1B3bFFxV2kzcGxYc2NTQlgwUlwvZUgzd1wvSGlKXC9hUVR2VHdlXC9FblUrTEZpUFE2dERXRGNTU25nTktQUGh5Q01zd0JqeWJnaDlpNXJ2ZHRmRVZmRFVnRm5pZk12VExsNHRYVCtiS0p4VTJSblNsTjJYcit0Rks0RzJENVNMa3B5MGZlUHptV29adWJ0VHM4bnhNZ1BBNXZJdUJwRzFwajVHaDk1NndsMGFHY3VUVlhcL2xHanhxdzMrdlZLblBVeDFhZXlnZVNOd3hJQUwyQkVzN2IyUW1YaHBOZVRZQzVuQ3V5VnVuV1Y2dTB6cmZ3Z1lVZXdKR25QQjZ3dk5wWnYxbWJVQWwyU09QVGZseVJFRTlZUkRBdVFYWVlBVkR1WENcL0dQc1hNVGNLckhhaDFYWlZWTll4MUJwak16RUk0bVdOVjUyVE5aOFBYMjIxWFR2V3dSQzNrV1RzOWtrbDNBUEhjUmUwT0g1M0FFcDdJbXRsZVNJNklrRkdNRUZCUVRFd00wTkJOVE0zUlVGRlJEZzNRekkwUkVRMU16a3dPVUk0TUVFM09FRTVNak5GTXpneU0wUTJPRVJCUTBNNU5FSTVSa1k0TXpBMVJFTWlmYXN3TmdpSFI0ZVBpR0VOcTBJdlRxRFphZjVpTTdvZE5UTHlQd1E4XC9QOHBrbGsyMmpuYVUxY0NVOUdhTFFJaVdTRXN6K2pJXC83Y2t2Qmc9IiwidHlwZSI6Im1vbmV5Ym9va2VycyJ9LHsibmFtZSI6IlByZW1pdW0gU01TIiwicGF5bWVudE1ldGhvZERhdGEiOiJBYjAyYjRjMCFCUUFCQWdBVGdUd3hLRFwvajdmUElMZnJYcEtKMlIwdnpmUUxjMkp5dmxqUmQ2XC9vbjRSSGx5ZFEybHo0YmxoSlg3OEJpcTY2ZnU3TlRRMXA3WEQwZlVxY1JcL01JdUVhYnFBMFdsSDY5ZXdDeFhpTUZFbVlVTnBvSlFSbU1jcW1oMjhWV1k0ZEFBY2hrU0tcLzdGVU9oZGIyWWtqSTVIVG1QVGZFanQ4OXNHeE1lXC9hV1MraG5HQTB2cjJiNVF5c3grWXlPcDN4cU1iY0FmdTREb3ZweHdwT3JUWFhsQzFFVE43NVFLR0JBWCtWejdmQ1RPckpKRlVrRTBzTXdqb3lqVkRRVUJPR29tY0xicGh1K0NyZFZhRStLUm41SFNaQzV6MVhCa3l2NE5aKzZ3RUR1TkI0NU1KUlZ2dmxyYU1Wd1k0MHl5ZkpDczFKd0NrNDNFYnNtaVJSQkxQcmN0TUY0Q295ODA0VTVHaVk4c1J3dzRDQXdKYVwvM2ZPdVNETG0yK1g2NUZ2UXlKQVhsVHUybVo1K2VLbm5hUWh4OHU5WDNTTVBWemNUaE4zSU9wNTZEeHloaTNoRjhtZDZGTm9mZG91VG9od2RsbGVWaTdha2JKd01uaXJDT1o5cHBGRXVPUUFYOGZmMVlLQVRGQWtOWWpCcXYzWVpWTll1Y3RlR2hRSmdydDdPbVRZU3hxazE1WWVmMktlU1p1eVlNZjhqMTR6T0I3eXFOZVAwRlA5S1liZktSNVNvUCt6c2pTb1hQbjh4SU10RGpHbHkyR0kxRFJcL1NPS0xEOGQ2bHpCY2lBY1ZcL3p4YVRkWVZGS05TMFdUZWVHRWc5V3MyWHpKWWMrbDNnK2tHMjNheVI4UFN6ZHJvQ2tMV2h6WGhRUmpka2lFVVd2bTBRSm9Bd2RkNzlXcmN5aEFcL0VcL21kYXdRdmVUZGUwVVRyaTJFWUFFcDdJbXRsZVNJNklrRkdNRUZCUVRFd00wTkJOVE0zUlVGRlJEZzNRekkwUkVRMU16a3dPVUk0TUVFM09FRTVNak5GTXpneU0wUTJPRVJCUTBNNU5FSTVSa1k0TXpBMVJFTWlmUWhPNjkrOHMwbFVSaVpudmQ1YXN2aHBHRFlkNFlxcVZzbnFXdUQ4OEdMck1PZU02N1JLS29vNmNPNjVVdXZHdks0PSIsInR5cGUiOiJzbXMifSx7Im5hbWUiOiJZb3VyIEdpZnQiLCJwYXltZW50TWV0aG9kRGF0YSI6IkFiMDJiNGMwIUJRQUJBZ0N0SzEwNVhGNGQrZnBWdUtIcExvc2hGMTd0Tk9BYWhCQ2xiUzBjV0xDWVhTemJFN1dYb3FvejVRd3EyelJBdllJVEpFbmdcL1cxMXhTNXhcL0o3TmRveGdORkw0dmdsT2g0WEVTNnVPUUw2RWlGeUJtcFBHZjJ2U0pmZ0lZcUJmeUhOcFFYUVRYeUNrdWZjK3cwWXpncCszOUVDbXc3TnpMR0tFUWMxUE5GKzFWRHBoM3VXeXlMVzMwcTJ1YnRQQ0tscjRWWDJUSlV6bnFBWjBWVWJyVFVvT0l1NG5zNWFLSGVuMGRqZGJCblB4Z1RQeHM4b2FoZ211Nk5rXC83d2FiU21jSXNkMkd1MXBWYmFXaHFMclQ4eTc0U0l6aVhrWm1adFdVMGZLXC9ReUgzR1VXZzNXRWVzYVRFaDhlVnZCRERxQlRxNTdvODhMUG1BY2FYeUFlYmtzSUR5TEU3TlM5elZnSkJRbVcxSmtmVDRKcTRwam1naUxiZkFqWWozRUVhWXBld2ZhZDE0TWR2aEFlOHRGQklkakNrVXhWQlJ6eEZscnhvNStBOHZNdmRKTHBGTDJvdVVwYldhREpDa002WnRVTFJWRGludWU3XC8zRGI5WjZ4cUFScDlrQmpsT2VTRzl3akxLNlRJK2JQbmtZOGgreXNEVVcraHZtMm9BV1BVMGVBb2RhcUFXRisyWm5tcDhxTmxRblF4UmdZWitCS2tGVDF4TFwvbDRHWjFkeDVwZ0wrNTBGdlRRUGMwRU40U21Jb1J6YnFtQlF6bVRDVitKZGs1Zm5tdTlLUlJVRVVtNklCc3dGRFFYNkdGWmdyY0JZK3RzOXJVMGNJT3BqRUpxSWVzV2Npc2tEQ1lySWdXYlg1aVJTTlJvdTUrNFk3ZzFXSHJoa3RqUVVhaHdxUkI2Wm11NkhuelJHOXFWNEN1RWdicWpBRXA3SW10bGVTSTZJa0ZHTUVGQlFURXdNME5CTlRNM1JVRkZSRGczUXpJMFJFUTFNemt3T1VJNE1FRTNPRUU1TWpORk16Z3lNMFEyT0VSQlEwTTVORUk1UmtZNE16QTFSRU1pZlJuM095K0tETGFCZmI3V3RhODJvRVZ2V1RtMk5JQWxPQzJFRytLeElldEFkbmR6XC9WSlNtWjRcL2NuM0doa0NNVkZZSTZsMm1Fdz09IiwidHlwZSI6InlvdXJnaWZ0In1dLCJwdWJsaWNLZXkiOiIxMDAwMXxDOUIyOUI3OThBNzdGRTlEMzlFNTExOTM0QkJDQUE1MTE0MTE5Mjc2NkQ3QURDOEY3QUQ1NjBGRTk5RDEwRDkyRUY1MDgzMENCRTg4QkI0NzlBOTEwNzE2RDdGMDMzQjAzMTJCN0Y3NjEwMDg4Rjk0QTQ4ODYyNkRGOUVERUIwMUY5MTY0MUZCN0QzNjNCOTY2RjU5MjE2MTNDODM2MTE5RTZBOTdFQzM3QjM1QUFBOTRCRjAxODkzNDEwQzVGNDI4RTU3NjdGNkMwNkQ0NEZBRkFDMjc2ODdENkYyQjQzNDQxREMyN0UzMzM1QTJFRDRCNjIwQjJGMENBQkJCMjY3MDc1QTdBMjZDRjBEMDcyRTBDOEJBNEIzQTI0MkMzODhDRjM3ODQ3MTE3NjAxODExRTFFOUExNkUzMkVEOEEyMThBNjg2N0U2QTUwRjE1RDhFREJDODMyQUY0OTdDNjY5OUI1QzU4MTMxNUE3MUY3MjNFMjNBNkNCRUJCRDA5MzNDQjA5Q0VBOEJCOTUyN0Y3NDU4NkEwNzQ4MkY5MTJBQkY3RkEzM0U2NUMyNzAzOTk3MEM0MTAxREVBMkI4QzdDQUQwMDE5QkUwNzkxQ0U5RTE4NzAzOUE2QzQ3NjExRTczMDM4RDk0MjAxM0I5NjA1NjQwQzAwRkE4OEJEREMyRiIsInNka1ZlcnNpb24iOiIxLjMuMCJ9";
            return new Model.Checkout.PaymentVerificationRequest(payload:payload);
        }

        private Model.Checkout.BrowserInfo CreateMockBrowserInfo()
        {
            return new Model.Checkout.BrowserInfo
            {
                UserAgent =
                    "User-Agent:Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10_5) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.95 Safari/537.36",
                AcceptHeader = "*/*"
            };
        }

        protected Model.Payments.Card CreateTestCard()
        {
            return new Model.Payments.Card(number: "4111111111111111", expiryMonth: "03", expiryYear: "2030", cvc: "737",
                holderName: "John Smith");
        }

        protected Model.Checkout.Card CreateTestCardCheckout()
        {
            var card = new Model.Checkout.Card
            {
                Cvc = ("737"),
                ExpiryMonth = ("03"),
                ExpiryYear = ("2030"),
                HolderName = ("John Smith"),
                Number = ("4111111111111111")
            };
            return card;
        }

        protected Model.Checkout.Card CreateTestCard3D()
        {
            return new Model.Checkout.Card(number: "5212345678901234", expiryMonth: "08", expiryYear: "2018", cvc: "737",
                holderName: "John Smith");
        }

        protected static ThreeDSAvailabilityRequest CreateThreeDSAvailabilityRequest(string merchantAccount)
        {
            var threeDSAvailabilityRequest = new ThreeDSAvailabilityRequest
            {
                MerchantAccount = merchantAccount,
                CardNumber = "4111111111111111"
            };
            return threeDSAvailabilityRequest;
        }

        /*protected static CostEstimateRequest CreateCostEstimateRequest(string merchantAccount)
        {
            var costEstimateRequest = new CostEstimateRequest
            {
                MerchantAccount = merchantAccount,
                CardNumber = "4111111111111111",
                Amount = new Model.BinLookup.Amount()
            };
            costEstimateRequest.Amount.Currency = "EUR";
            costEstimateRequest.Amount.Value = 1L;
            costEstimateRequest.ShopperInteraction = CostEstimateRequest.ShopperInteractionEnum.Ecommerce;
            costEstimateRequest.ShopperReference = "ShopperReference";
            return costEstimateRequest;
        }*/

        /// <summary>
        /// Returns additional data object
        /// </summary>
        /// <returns></returns>
        private Dictionary<string, string> CreateAdditionalData()
        {
            return new Dictionary<string, string>
            {
                {"fraudOffset", "0"},
            };
        }

        /*private PaymentResult GetAdditionaData(PaymentResult paymentResult)
        {
            var paymentResultAdditionalData = paymentResult.AdditionalData;

            foreach (var additionalData in paymentResultAdditionalData)
            {
                switch (additionalData.Key)
                {
                    case AdditionalData.AvsResult:
                        paymentResult.AvsResult = additionalData.Value;
                        break;
                    case AdditionalData.PaymentMethod:
                        paymentResult.PaymentMethod = additionalData.Value;
                        break;
                    case AdditionalData.BoletoData:
                        paymentResult.BoletoData = additionalData.Value;
                        break;
                    case AdditionalData.CardBin:
                        paymentResult.CardBin = additionalData.Value;
                        break;
                    case AdditionalData.CardHolderName:
                        paymentResult.CardHolderName = additionalData.Value;
                        break;
                }
            }
            return paymentResult;
        }*/
    }
}
