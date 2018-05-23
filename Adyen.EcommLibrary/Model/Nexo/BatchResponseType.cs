namespace Adyen.EcommLibrary.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BatchResponseType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ResponseType Response;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PerformedTransaction", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PerformedTransactionType[] PerformedTransaction;
    }
}