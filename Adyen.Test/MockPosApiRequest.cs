using System;
using System.Collections.Generic;
using Adyen.Model.Terminal;
using Adyen.Model.TerminalApi;

namespace Adyen.Test
{
    public class MockPosApiRequest
    {
        /// <summary>
        /// Plain POI Cloud api/terminal api message
        /// </summary>
        /// <param name="paymentType"></param>
        /// <returns></returns>
        public static TerminalApiRequest CreatePosPaymentRequest()
        {
            var terminalApiRequest = new TerminalApiRequest
            {
                SaleToPOIRequest = new SaleToPOIRequest
                {
                    MessageHeader = new MessageHeader
                    {
                        MessageType = MessageType.Request,
                        MessageClass = MessageClass.Service,
                        MessageCategory = MessageCategory.Payment,
                        SaleID = "POSSystemID12345",
                        POIID = "MX915-284251016",
                        ServiceID = DateTime.Now.ToString("ddHHmmss") //this should be unique
                    },
                    PaymentRequest = new PaymentRequest
                    {
                        SaleData = new SaleData
                        {
                            SaleTransactionID = new TransactionIDType
                            {
                                TransactionID = "PosAuth",
                                TimeStamp = DateTime.Now
                            },
                            TokenRequestedType = TokenRequestedType.Customer,
                        },
                        PaymentTransaction = new PaymentTransaction
                        {
                            AmountsReq = new AmountsReq
                            {
                                Currency = "EUR",
                                RequestedAmount = 10100
                            }
                        },
                        PaymentData = new PaymentData
                        {
                            PaymentType = PaymentType.Normal
                        }
                    },
                    SecurityTrailer = new SecurityTrailer()
                }
            };
            return terminalApiRequest;
        }
        
        public static TerminalApiRequest CreateSaleToPOIPrintRequestEscape()
        {
            return new TerminalApiRequest()
            {
                SaleToPOIRequest = new SaleToPOIRequest
                {
                    MessageHeader = new MessageHeader
                    {
                        MessageClass = MessageClass.Device,
                        MessageCategory = MessageCategory.Print,
                        MessageType = MessageType.Request,
                        SaleID = "1234567",
                        POIID = "VX680-12343454",
                        ServiceID = "1",
                        ProtocolVersion = "3.0"
                    },
                    PrintRequest = new PrintRequest
                    {
                        PrintOutput = new PrintOutput
                        {
                            DocumentQualifier = DocumentQualifier.Document,
                            ResponseMode = ResponseMode.PrintEnd,
                            OutputContent = new OutputContent
                            {
                                OutputFormat = OutputFormat.Text,
                                OutputText = new List<OutputText>() {new OutputText {Text = @"m\u006DÄ\u00C4"}},
                            },
                        },
                    },
                }
            };
        }
    
        /// <summary>
        /// Dummy Nexo json print request
        /// </summary>
        /// <returns></returns>
        public static string MockNexoJsonPrintRequest()
        {
            return
                "{\"SaleToPOIRequest\":{\"MessageHeader\":{\"MessageClass\":\"Device\",\"MessageCategory\":\"Print\",\"MessageType\":\"Request\",\"ServiceID\":\"1\",\"SaleID\":\"1234567\",\"POIID\":\"VX680-12343454\",\"ProtocolVersion\":\"3.0\"}," +
                "\"PrintRequest\":{\"PrintOutput\":{\"OutputContent\":{\"OutputText\":[{\"Color\":\"White\",\"CharacterWidth\":\"SingleWidth\",\"CharacterHeight\":\"SingleHeight\",\"CharacterStyle\":\"Normal\",\"Alignment\":\"Left\"," +
                "\"EndOfLineFlag\":true,\"Text\":\"m\\\\u006DÄ\\\\u00C4\"}],\"OutputFormat\":\"Text\"},\"DocumentQualifier\":\"Document\",\"ResponseMode\":\"PrintEnd\"}}}}";
        }

        /// <summary>
        /// Dummy Nexo json api/terminal api request
        /// </summary>
        /// <returns></returns>
        public static string MockNexoJsonRequest()
        {
            return
                "{\r\n\"SaleToPOIRequest\" : {\r\n      \"MessageHeader\" : {\r\n         \"MessageType\" : \"Request\",\r\n         \"MessageClass\" : \"Service\",\r\n      " +
                "   \"MessageCategory\" : \"Payment\",\r\n         \"SaleID\" : \"AppieBash-POSSystemID12345\",\r\n         \"POIID\" : \"MX925-260390740\",\r\n         \"ProtocolVersion\" : \"3.0\",\r\n      " +
                "   \"ServiceID\" : \"19681717\"\r\n      },\r\n      \"PaymentRequest\" : {\r\n         \"SaleData\" : {\r\n            \"SaleTransactionID\" : {\r\n               " +
                "\"TransactionID\" : \"TxId-2018-06-19T18:07:07+00:00\",\r\n               \"TimeStamp\" : \"2018-06-19T18:07:07+00:00\"\r\n            },\r\n\t\t\"TokenRequestedType\" : " +
                "\"Customer\",\r\n         \"PaymentTransaction\" : {\r\n            \"AmountsReq\" : {\r\n          " +
                "     \"Currency\" : \"EUR\",\r\n               \"RequestedAmount\" : 15.25 \r\n            },\r\n            \"TransactionConditions\" : {}\r\n         },\r\n      " +
                "   \"PaymentData\" : {\"PaymentType\" : \"Normal\"}\r\n      }\r\n   }\r\n}\r\n";
        }
        /// <summary>
        /// Dummy terminal api json api/terminal api request without security trailer set for test
        /// enviroment
        /// </summary>
        /// <returns></returns>
        public static TerminalApiRequest CreatePosPaymentRequestEmptySecurityTrailer()
        {
            var terminalApiRequest = new TerminalApiRequest
            {
                SaleToPOIRequest = new SaleToPOIRequest
                {
                    MessageHeader = new MessageHeader
                    {
                        MessageType = MessageType.Request,
                        MessageClass = MessageClass.Service,
                        MessageCategory = MessageCategory.Payment,
                        SaleID = "POSSystemID12345",
                        POIID = "MX915-284251016",
                        ServiceID = DateTime.Now.ToString("ddHHmmss") //this should be unique
                    },
                    PaymentRequest = new PaymentRequest
                    {
                        SaleData = new SaleData
                        {
                            SaleTransactionID = new TransactionIDType()
                            {
                                TransactionID = "PosAuth",
                                TimeStamp = DateTime.Now
                            },
                            TokenRequestedType = TokenRequestedType.Customer,
                        },
                        PaymentTransaction = new PaymentTransaction
                        {
                            AmountsReq = new AmountsReq
                            {
                                Currency = "EUR",
                                RequestedAmount = 10100
                            }
                        },
                        PaymentData = new PaymentData
                        {
                            PaymentType = PaymentType.Normal
                        }
                    },
                    SecurityTrailer = null
                }
            };
            return terminalApiRequest;
        }
    }
}
