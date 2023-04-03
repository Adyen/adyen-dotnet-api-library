namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class LoyaltyRequest
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SaleData SaleData;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoyaltyTransaction LoyaltyTransaction;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LoyaltyData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoyaltyData[] LoyaltyData;
    }
}