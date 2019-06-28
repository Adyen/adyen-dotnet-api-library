namespace Adyen.EcommLibrary.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoyaltyAmount
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("Point")]
        public string LoyaltyUnit;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal? Value;

        public LoyaltyAmount()
        {
            this.LoyaltyUnit = "Point";
        }
    }
}