namespace Adyen.EcommLibrary.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SaleData
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TransactionIdentification SaleTransactionID;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SaleTerminalData SaleTerminalData;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SponsoredMerchant", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SponsoredMerchant[] SponsoredMerchant;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SaleToPOIData;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SaleToAcquirerData;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SaleToIssuerData SaleToIssuerData;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OperatorID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OperatorLanguage;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ShiftNumber;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SaleReferenceID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TokenRequestedType TokenRequested;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CustomerOrderID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CustomerOrderReqType[] CustomerOrderReq;
    }
}