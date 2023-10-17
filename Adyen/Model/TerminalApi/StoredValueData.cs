namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class StoredValueData
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public StoredValueAccountID StoredValueAccountID;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public OriginalPOITransaction OriginalPOITransaction;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string StoredValueProvider;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public StoredValueTransactionType StoredValueTransactionType;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string ProductCode;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string EanUpc;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public decimal? ItemAmount;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string Currency;
    }
}