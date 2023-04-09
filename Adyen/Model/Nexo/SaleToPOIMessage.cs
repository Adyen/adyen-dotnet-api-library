using System.Xml.Serialization;

namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class SaleToPOIMessage
    {

        /// <remarks/>
        [XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MessageHeader MessageHeader;

        /// <remarks/>
        [XmlElementAttribute("AbortRequest", typeof(AbortRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("AdminRequest", typeof(AdminRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("BalanceInquiryRequest", typeof(BalanceInquiryRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("BatchRequest", typeof(BatchRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("CardAcquisitionRequest", typeof(CardAcquisitionRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("CardReaderAPDURequest", typeof(CardReaderAPDURequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("CardReaderInitRequest", typeof(CardReaderInitRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("CardReaderPowerOffRequest", typeof(CardReaderPowerOffRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("DiagnosisRequest", typeof(DiagnosisRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("DisplayRequest", typeof(DisplayRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("EnableServiceRequest", typeof(EnableServiceRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("EventNotification", typeof(EventNotification), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("GetTotalsRequest", typeof(GetTotalsRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("InputRequest", typeof(InputRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("InputUpdate", typeof(InputUpdate), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("LoginRequest", typeof(LoginRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("LogoutRequest", typeof(LogoutRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("LoyaltyRequest", typeof(LoyaltyRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("PINRequest", typeof(PINRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("PaymentRequest", typeof(PaymentRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("PrintRequest", typeof(PrintRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("ReconciliationRequest", typeof(ReconciliationRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("ReversalRequest", typeof(ReversalRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("SoundRequest", typeof(SoundRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("StoredValueRequest", typeof(StoredValueRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("TransactionStatusRequest", typeof(TransactionStatusRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("TransmitRequest", typeof(TransmitRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object MessagePayload;

        /// <remarks/>
        [XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ContentInformation SecurityTrailer;
    }
}
