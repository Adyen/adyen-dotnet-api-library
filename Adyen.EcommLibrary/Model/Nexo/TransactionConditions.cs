namespace Adyen.EcommLibrary.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TransactionConditions
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowedPaymentBrand", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] AllowedPaymentBrand;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AcquirerID", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] AcquirerID;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowedLoyaltyBrand", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] AllowedLoyaltyBrand;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ForceEntryMode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] ForceEntryMode;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool DebitPreferredFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("Forbidden")]
        public string LoyaltyHandling;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CustomerLanguage;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ForceOnlineFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MerchantCategoryCode;

        public TransactionConditions()
        {
            this.DebitPreferredFlag = false;
            this.LoyaltyHandling = "Forbidden";
            this.ForceOnlineFlag = false;
        }
    }
}