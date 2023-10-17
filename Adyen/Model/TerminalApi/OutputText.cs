namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class OutputText
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public int? CharacterSet;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string Font;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public int? StartRow;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public int? StartColumn;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public ColorType Color;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? ColorSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public CharacterWidthType CharacterWidth;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? CharacterWidthSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public CharacterHeightType CharacterHeight;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? CharacterHeightSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public CharacterStyleType CharacterStyle;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? CharacterStyleSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public AlignmentType Alignment;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? AlignmentSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool? EndOfLineFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute]
        public string Text;

        public OutputText()
        {
            EndOfLineFlag = true;
        }
    }
}