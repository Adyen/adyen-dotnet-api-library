namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class MenuEntry
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
        [System.Xml.Serialization.XmlAttributeAttribute]
        [System.ComponentModel.DefaultValueAttribute(MenuEntryTagType.Selectable)]
        public MenuEntryTagType MenuEntryTag;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public OutputFormatType OutputFormat;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool? DefaultSelectedFlag;

        public MenuEntry()
        {
            MenuEntryTag = MenuEntryTagType.Selectable;
            DefaultSelectedFlag = false;
        }
    }
}