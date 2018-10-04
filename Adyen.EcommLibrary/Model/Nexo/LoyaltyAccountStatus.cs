namespace Adyen.EcommLibrary.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoyaltyAccountStatus
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoyaltyAccount LoyaltyAccount;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal CurrentBalance;

       
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("Point")]
        public string LoyaltyUnit;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency;

        public LoyaltyAccountStatus()
        {
            this.LoyaltyUnit = "Point";
        }
    }
}