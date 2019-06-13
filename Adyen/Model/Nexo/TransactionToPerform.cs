namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TransactionToPerform
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LoyaltyRequest", typeof(LoyaltyRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PaymentRequest", typeof(PaymentRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("ReversalRequest", typeof(ReversalRequest), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object MessagePayload;
    }
}