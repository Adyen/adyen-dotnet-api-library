﻿using System.Xml.Serialization;

namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class SaleToPOIMessage
    {

        /// <remarks/>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MessageHeader MessageHeader;

        /// <remarks/>
        [XmlElement("AbortRequest", typeof(AbortRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElement("AdminRequest", typeof(AdminRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElement("BalanceInquiryRequest", typeof(BalanceInquiryRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElement("BatchRequest", typeof(BatchRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElement("CardAcquisitionRequest", typeof(CardAcquisitionRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElement("CardReaderAPDURequest", typeof(CardReaderAPDURequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElement("CardReaderInitRequest", typeof(CardReaderInitRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElement("CardReaderPowerOffRequest", typeof(CardReaderPowerOffRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElement("DiagnosisRequest", typeof(DiagnosisRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElement("DisplayRequest", typeof(DisplayRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElement("EnableServiceRequest", typeof(EnableServiceRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElement("EventNotification", typeof(EventNotification), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElement("GetTotalsRequest", typeof(GetTotalsRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElement("InputRequest", typeof(InputRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElement("InputUpdate", typeof(InputUpdate), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElement("LoginRequest", typeof(LoginRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElement("LogoutRequest", typeof(LogoutRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElement("LoyaltyRequest", typeof(LoyaltyRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElement("PINRequest", typeof(PINRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElement("PaymentRequest", typeof(PaymentRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElement("PrintRequest", typeof(PrintRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElement("ReconciliationRequest", typeof(ReconciliationRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElement("ReversalRequest", typeof(ReversalRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElement("SoundRequest", typeof(SoundRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElement("StoredValueRequest", typeof(StoredValueRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElement("TransactionStatusRequest", typeof(TransactionStatusRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElement("TransmitRequest", typeof(TransmitRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object MessagePayload;

        /// <remarks/>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ContentInformation SecurityTrailer;
    }
}
