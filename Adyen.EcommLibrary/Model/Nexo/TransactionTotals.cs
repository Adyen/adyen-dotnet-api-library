namespace Adyen.EcommLibrary.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TransactionTotals
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentTotals", Form =
            System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PaymentTotals[] PaymentTotals;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LoyaltyTotals", Form =
            System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoyaltyTotals[] LoyaltyTotals;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PaymentInstrument;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AcquirerID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ErrorCondition;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HostReconciliationID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CardBrand;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string POIID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SaleID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OperatorID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ShiftNumber;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TotalsGroupID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PaymentCurrency;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()] [System.ComponentModel.DefaultValueAttribute("Point")]
        public string LoyaltyUnit;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LoyaltyCurrency;

        public TransactionTotals()
        {
            LoyaltyUnit = "Point";
        }
    }
}