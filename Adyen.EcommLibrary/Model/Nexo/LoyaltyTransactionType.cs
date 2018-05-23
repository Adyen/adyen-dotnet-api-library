namespace Adyen.EcommLibrary.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoyaltyTransactionType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public OriginalPOITransactionType OriginalPOITransaction;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TransactionConditionsType TransactionConditions;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SaleItem", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SaleItemType[] SaleItem;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("LoyaltyTransactionType")]
        public string LoyaltyTransactionType1;
        
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