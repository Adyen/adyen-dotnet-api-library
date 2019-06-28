namespace Adyen.EcommLibrary.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class OutputText
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Text;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string CharacterSet;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Font;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string StartRow;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string StartColumn;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Color;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CharacterWidth;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CharacterHeight;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CharacterStyle;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Alignment;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool EndOfLineFlag;

        public OutputText()
        {
            this.EndOfLineFlag = true;
        }
    }
}