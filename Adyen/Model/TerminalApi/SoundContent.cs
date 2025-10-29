namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class SoundContent
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public SoundFormatType SoundFormat;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? SoundFormatSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string Language;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string ReferenceID;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute]
        public string Text;
    }
}