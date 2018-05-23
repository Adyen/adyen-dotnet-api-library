namespace Adyen.EcommLibrary.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TransactionToPerformType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LoyaltyRequest", typeof(LoyaltyRequestType), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PaymentRequest", typeof(PaymentRequestType), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("ReversalRequest", typeof(ReversalRequestType), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object Item;
    }
}