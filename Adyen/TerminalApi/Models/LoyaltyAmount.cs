namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class LoyaltyAmount
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        [System.ComponentModel.DefaultValueAttribute(LoyaltyUnitType.Point)]
        public LoyaltyUnitType LoyaltyUnit;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string Currency;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute]
        public decimal? Value;
    }
}