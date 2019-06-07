namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CardAcquisitionTransaction
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowedPaymentBrand", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] AllowedPaymentBrand;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowedLoyaltyBrand", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] AllowedLoyaltyBrand;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ForceEntryMode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] ForceEntryMode;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(LoyaltyHandlingType.Allowed)]
        public LoyaltyHandlingType LoyaltyHandling;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CustomerLanguage;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ForceCustomerSelectionFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotalAmount;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PaymentType Payment;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CashBackFlag;

        public CardAcquisitionTransaction()
        {
            this.LoyaltyHandling = LoyaltyHandlingType.Allowed;
            this.ForceCustomerSelectionFlag = false;
        }
    }
}