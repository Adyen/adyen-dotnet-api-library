#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using Adyen.Model.Nexo;
using System;
using Adyen.Model.Nexo.Message;

namespace Adyen.Test
{
    public class MockPosApiRequest
    {
        /// <summary>
        /// Plain POI Cloud api/terminal api message
        /// </summary>
        /// <param name="paymentType"></param>
        /// <returns></returns>
        public static SaleToPOIRequest CreatePosPaymentRequest()
        {
            var saleToPoiRequest = new SaleToPOIRequest()
            {
                MessageHeader = new MessageHeader
                {
                    MessageType = MessageType.Request,
                    MessageClass = MessageClassType.Service,
                    MessageCategory = MessageCategoryType.Payment,
                    SaleID = "POSSystemID12345",
                    POIID = "MX915-284251016",
                    ServiceID = DateTime.Now.ToString("ddHHmmss")//this should be unique
                },
                MessagePayload = new PaymentRequest()
                {
                    SaleData = new SaleData()
                    {
                        SaleTransactionID = new TransactionIdentification()
                        {
                            TransactionID = "PosAuth",
                            TimeStamp = DateTime.Now
                        },
                        TokenRequestedType = TokenRequestedType.Customer,
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
                        PaymentType = PaymentType.Normal
                    }
                },
                SecurityTrailer = new ContentInformation(){}
            };
            return saleToPoiRequest;
        }
       
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
                   "\"Customer\",\r\n         \"PaymentTransaction\" : {\r\n            \"AmountsReq\" : {\r\n          " +
                   "     \"Currency\" : \"EUR\",\r\n               \"RequestedAmount\" : 15.25 \r\n            },\r\n            \"TransactionConditions\" : {}\r\n         },\r\n      " +
                   "   \"PaymentData\" : {\"PaymentType\" : \"Normal\"}\r\n      }\r\n   }\r\n}\r\n";
        }

    }
}
