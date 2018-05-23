namespace Adyen.EcommLibrary.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CardAcquisitionResponseType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ResponseType Response;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SaleDataType SaleData;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public POIDataType POIData;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentBrand", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] PaymentBrand;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PaymentInstrumentDataType PaymentInstrumentData;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LoyaltyAccount", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoyaltyAccountType[] LoyaltyAccount;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CustomerOrder", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CustomerOrderType[] CustomerOrder;
    }
}