namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class StoredValueAccountStatus
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public StoredValueAccountID StoredValueAccountID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public decimal? CurrentBalance;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? CurrentBalanceSpecified;
    }
}