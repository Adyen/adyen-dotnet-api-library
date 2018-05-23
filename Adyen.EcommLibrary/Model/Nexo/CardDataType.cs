namespace Adyen.EcommLibrary.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CardDataType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ContentInformationType ProtectedCardData;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SensitiveCardDataType SensitiveCardData;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowedProductCode", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] AllowedProductCode;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowedProduct", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AllowedProductType[] AllowedProduct;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PaymentTokenType PaymentToken;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CustomerOrder", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CustomerOrderType[] CustomerOrder;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PaymentBrand;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MaskedPAN;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PaymentAccountRef;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] EntryMode;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CardCountryCode;
    }
}