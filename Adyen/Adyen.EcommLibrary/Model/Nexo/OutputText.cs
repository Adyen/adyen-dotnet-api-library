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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public int CharacterSet;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Font;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public int StartRow;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public int StartColumn;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ColorType Color;

       
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CharacterWidthType CharacterWidth;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CharacterHeightType CharacterHeight;

          /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CharacterStyleType CharacterStyle;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AlignmentType Alignment;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool EndOfLineFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;

        public OutputText()
        {
            this.EndOfLineFlag = true;
        }
    }
}