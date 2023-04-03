namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class PaymentInstrumentData
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CardData CardData;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CheckData CheckData;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MobileData MobileData;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public PaymentInstrumentType PaymentInstrumentType;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public StoredValueAccountID StoredValueAccountID;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ContentInformation ProtectedCardData;
    }
}