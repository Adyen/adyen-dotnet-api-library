namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class TransactionStatusRequest
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MessageReference MessageReference;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentQualifier", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DocumentQualifierType[] DocumentQualifier;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool? ReceiptReprintFlag;
    }
}