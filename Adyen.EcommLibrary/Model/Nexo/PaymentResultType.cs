namespace Adyen.EcommLibrary.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PaymentResultType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PaymentInstrumentDataType PaymentInstrumentData;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AmountsRespType AmountsResp;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InstalmentType Instalment;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CurrencyConversion", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CurrencyConversionType[] CurrencyConversion;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CapturedSignatureType CapturedSignature;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ContentInformationType ProtectedSignature;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PaymentAcquirerDataType PaymentAcquirerData;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("Normal")]
        public string PaymentType;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool MerchantOverrideFlag;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CustomerLanguage;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool OnlineFlag;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] AuthenticationMethod;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ValidityDate;
        
        public PaymentResultType() {
            this.PaymentType = "Normal";
            this.MerchantOverrideFlag = false;
            this.OnlineFlag = true;
        }
    }
}