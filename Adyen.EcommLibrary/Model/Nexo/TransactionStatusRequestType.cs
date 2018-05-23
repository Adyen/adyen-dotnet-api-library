namespace Adyen.EcommLibrary.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TransactionStatusRequestType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MessageReferenceType MessageReference;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentQualifier", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] DocumentQualifier;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ReceiptReprintFlag;
        
        public TransactionStatusRequestType() {
            this.ReceiptReprintFlag = false;
        }
    }
}