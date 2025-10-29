namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class StoredValueRequest
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SaleData SaleData;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StoredValueData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public StoredValueData[] StoredValueData;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string CustomerLanguage;
    }
}