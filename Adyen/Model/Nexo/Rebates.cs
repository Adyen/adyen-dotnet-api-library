namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class Rebates
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal? TotalRebate;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? TotalRebateSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RebateLabel;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SaleItemRebate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SaleItemRebate[] SaleItemRebate;
    }
}