namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class PaymentAcquirerData
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TransactionIdentification AcquirerTransactionID;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ApprovalCode;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string AcquirerID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string MerchantID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string AcquirerPOIID;
    }
}