namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class LoyaltyAcquirerData
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ApprovalCode;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TransactionIdentification LoyaltyTransactionID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string LoyaltyAcquirerID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string HostReconciliationID;
    }
}