namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class SaleTerminalData
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SaleCapabilities;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SaleProfile SaleProfile;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public TerminalEnvironmentType TerminalEnvironment;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? TerminalEnvironmentSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string TotalsGroupID;
    }
}