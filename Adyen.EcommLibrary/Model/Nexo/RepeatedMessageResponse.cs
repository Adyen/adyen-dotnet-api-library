namespace Adyen.EcommLibrary.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RepeatedMessageResponse
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MessageHeader MessageHeader;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CardAcquisitionResponse", typeof(CardAcquisitionResponse), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("CardReaderAPDUResponse", typeof(CardReaderAPDUResponse), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("LoyaltyResponse", typeof(LoyaltyResponse), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PaymentResponse", typeof(PaymentResponse), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("ReversalResponse", typeof(ReversalResponse), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("StoredValueResponse", typeof(StoredValueResponse), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object Item;
    }
}