namespace Adyen.EcommLibrary.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MenuEntry
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PredefinedContent PredefinedContent;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OutputText", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public OutputText[] OutputText;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary")]
        public byte[] OutputXHTML;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("Selectable")]
        public string MenuEntryTag;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OutputFormat;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool DefaultSelectedFlag;

        public MenuEntry()
        {
            this.MenuEntryTag = "Selectable";
            this.DefaultSelectedFlag = false;
        }
    }
}