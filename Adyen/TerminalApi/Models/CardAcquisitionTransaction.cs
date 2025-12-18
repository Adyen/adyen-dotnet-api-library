namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class CardAcquisitionTransaction
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowedPaymentBrand", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] AllowedPaymentBrand;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowedLoyaltyBrand", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] AllowedLoyaltyBrand;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public ForceEntryModeType[] ForceEntryMode;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public LoyaltyHandlingType? LoyaltyHandling;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string CustomerLanguage;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool? ForceCustomerSelectionFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public decimal? TotalAmount;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? TotalAmountSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public PaymentType? PaymentType;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? PaymentTypeSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public bool? CashBackFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? CashBackFlagSpecified;
    }
}