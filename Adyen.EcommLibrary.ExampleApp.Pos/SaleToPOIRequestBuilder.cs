using Adyen.EcommLibrary.Model.Nexo;
using Adyen.EcommLibrary.Model.Nexo.Message;
using System;

namespace Adyen.EcommLibrary.ExampleApp.Pos
{
    internal class SaleToPOIRequestBuilder
    {
        /// <summary>
        /// Plain POI Cloud api/terminal api message
        /// </summary>
        /// <param name="transactionType"></param>
        /// <returns></returns>
        public static SaleToPOIRequest CreateRequest(string transactionType, int amount)
        {
            var saleToPoiRequest = new SaleToPOIRequest()
            {
                MessageHeader = new MessageHeader
                {
                    ProtocolVersion = "3.0",
                    MessageClass = "Service",
                    MessageCategory = transactionType,
                    MessageType = "Request",
                    ServiceID = DateTime.Now.ToString("ddHHmmss"),//this should be unique
                    SaleID = "POSSystemID12345",
                    POIID = Settings.TerminalId,
                },
                MessagePayload = new PaymentRequest()
                {
                    SaleData = new SaleData()
                    {
                        SaleTransactionID = new TransactionIdentification()
                        {
                            TransactionID = "27908",
                            TimeStamp = DateTime.Now,
                        },
                    },
                    PaymentTransaction = new PaymentTransaction()
                    {
                        AmountsReq = new AmountsReq()
                        {
                            Currency = "EUR",
                            RequestedAmount = amount
                        }
                    }
                },
                SecurityTrailer = new ContentInformationType() { }
            };
            return saleToPoiRequest;
        }
    }
}
