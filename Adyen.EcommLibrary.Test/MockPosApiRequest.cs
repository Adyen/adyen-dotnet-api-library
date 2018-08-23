using Adyen.EcommLibrary.Model.Nexo;
using System;

namespace Adyen.EcommLibrary.Test
{
    public class MockPosApiRequest
    {
        /// <summary>
        /// Plain POI Cloud api/terminal api message
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
                    SaleID = "POSSystemID12345",

                    POIID = "MX915-284251016",
                    ProtocolVersion = "3.0",
                    ServiceID = DateTime.Now.ToString("ddHHmmss")//this should be unique
                },
                Item = new PaymentRequest()
                {
                    SaleData = new SaleData()
                    {
                        SaleToAcquirerData = "shopperEmail=hola@gmail.com&shopperReference=fakeRef&recurringContract=RECURRING",
                        SaleTransactionID = new TransactionIdentification()
                        {
                            TransactionID = "PosAuth",
                            TimeStamp = DateTime.Now
                        },
                        TokenRequested = "Customer",
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
                },
                SecurityTrailer = new ContentInformationType()
                {

                }
            };
            return saleToPoiRequest;
        }
        //"SaleData":{
        //    "SaleToAcquirerData":"shopperEmail=hola@gmail.com&shopperReference=fakeRef&recurringContract=RECURRING",
        //    "TokenRequestedType":"Customer",
        //    "SaleTransactionID":{
        //        "TransactionID":"8377",
        //        "TimeStamp":"2017-11-13T15:24:52+00:00"
        //    }
        /// <summary>
        /// Dummy Nexo json Cloud api/terminal api request
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
