namespace Adyen.EcommLibrary.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoyaltyTransaction
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public OriginalPOITransaction OriginalPOITransaction;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TransactionConditions TransactionConditions;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SaleItem", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SaleItem[] SaleItem;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("LoyaltyTransaction")]
        public string LoyaltyTransaction1;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotalAmount;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalAmountSpecified;
    }
}