using Adyen.EcommLibrary.Model.Nexo;
using System;

namespace Adyen.EcommLibrary.Test
{
    public class MockCloudApiPosRequest
    {
        /// <summary>
        /// Encrypted POI cloud api message
        /// </summary>
        /// <param name="transactionType"></param>
        /// <returns></returns>
        public static SaleToPOIRequest CreatePaymentRequestWithEncryption(string transactionType)
        {
            var saleToPoiRequest = new SaleToPOIRequest()
            {
                MessageHeader = new MessageHeader
                {
                    MessageType = "Request",
                    MessageClass = "Service",
                    MessageCategory = "Payment",
                    SaleID = "John",
                    POIID = "MX915-284251016",
                    ProtocolVersion = "3.0",
                    ServiceID = (new Random()).Next(1, 9999).ToString()
                },
                Item = new PaymentRequest()
                {
                    SaleData = new SaleData()
                    {
                        SaleTransactionID = new TransactionIdentification()
                        {
                            TransactionID = "PosAuth",
                            TimeStamp = DateTime.Now
                        },

                        TokenRequested = "Customer",
                        SaleReferenceID = "SalesRefABC",
                    },
                    PaymentTransaction = new PaymentTransaction()
                    {
                        AmountsReq = new AmountsReq()
                        {
                            Currency = "EUR",
                            RequestedAmount = 10100
                        }
                    },
                    PaymentData = new PaymentData()
                    {
                        Payment = transactionType
                    }
                },SecurityTrailer = new ContentInformationType()
                {
                    
                }
            };

            return saleToPoiRequest;
        }

        /// <summary>
        /// Plain POI cloud api message
        /// </summary>
        /// <param name="transactionType"></param>
        /// <returns></returns>
        public static SaleToPOIRequest CreatePosPaymentRequest(string transactionType)
        {
            var saleToPoiRequest = new SaleToPOIRequest()
            {
                MessageHeader = new MessageHeader
                {
                    MessageType = "Request",
                    MessageClass = "Service",
                    MessageCategory = "Payment",
                    SaleID = "John",
                    
                    POIID = "MX915-284251016",
                    ProtocolVersion = "3.0",
                    ServiceID = (new Random()).Next(1, 9999).ToString()
                },
                Item = new PaymentRequest()
                {
                    SaleData = new SaleData()
                    {
                        SaleTransactionID = new TransactionIdentification()
                        {
                            TransactionID = "PosAuth",
                            TimeStamp = DateTime.Now
                        },

                        TokenRequested = "Customer",
                        SaleReferenceID = "SalesRefABC",
                    },
                    PaymentTransaction = new PaymentTransaction()
                    {
                        AmountsReq = new AmountsReq()
                        {
                            Currency = "EUR",
                            RequestedAmount = 10100
                        }
                    },
                    PaymentData = new PaymentData()
                    {
                        Payment = transactionType
                    }
                }
            };
            return saleToPoiRequest;
        }

        /// <summary>
        /// Returns dummy Nexo json Cloud api request
        /// </summary>
        /// <returns></returns>
        public static string MockNexoJsonRequest()
        {
            return "{\r\n\"SaleToPOIRequest\" : {\r\n      \"MessageHeader\" : {\r\n         \"MessageType\" : \"Request\",\r\n         \"MessageClass\" : \"Service\",\r\n      " +
                   "   \"MessageCategory\" : \"Payment\",\r\n         \"SaleID\" : \"AppieBash-POSSystemID12345\",\r\n         \"POIID\" : \"MX925-260390740\",\r\n         \"ProtocolVersion\" : \"3.0\",\r\n      " +
                   "   \"ServiceID\" : \"19681717\"\r\n      },\r\n      \"PaymentRequest\" : {\r\n         \"SaleData\" : {\r\n            \"SaleTransactionID\" : {\r\n               " +
                   "\"TransactionID\" : \"TxId-2018-06-19T18:07:07+00:00\",\r\n               \"TimeStamp\" : \"2018-06-19T18:07:07+00:00\"\r\n            },\r\n\t\t\"TokenRequestedType\" : " +
                   "\"Customer\",\r\n\t\t\"SaleToAcquirerData\" : \"billingAddress.city=Amsterdam\"\r\n          },\r\n         \"PaymentTransaction\" : {\r\n            \"AmountsReq\" : {\r\n          " +
                   "     \"Currency\" : \"EUR\",\r\n               \"RequestedAmount\" : 15.25 \r\n            },\r\n            \"TransactionConditions\" : {}\r\n         },\r\n      " +
                   "   \"PaymentData\" : {\"PaymentType\" : \"Normal\"}\r\n      }\r\n   }\r\n}\r\n";
        }

    }
}
