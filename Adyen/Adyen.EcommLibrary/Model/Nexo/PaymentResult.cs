namespace Adyen.EcommLibrary.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PaymentResult
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PaymentInstrumentData PaymentInstrumentData;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AmountsResp AmountsResp;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Instalment Instalment;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CurrencyConversion", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CurrencyConversion[] CurrencyConversion;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CapturedSignature CapturedSignature;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ContentInformationType ProtectedSignature;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PaymentAcquirerData PaymentAcquirerData;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(PaymentType.Normal)]
        public PaymentType Payment;

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
        public AuthenticationMethodType[] AuthenticationMethod;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ValidityDate;

        public PaymentResult()
        {
            this.Payment = PaymentType.Normal;
            this.MerchantOverrideFlag = false;
            this.OnlineFlag = true;
        }
    }
}