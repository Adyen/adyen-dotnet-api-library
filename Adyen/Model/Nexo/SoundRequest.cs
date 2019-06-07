namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SoundRequest
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SoundContent SoundContent;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ResponseModeType.NotRequired)]
        public ResponseModeType ResponseMode;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SoundActionType SoundAction;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public int SoundVolume;

        public SoundRequest()
        {
            this.ResponseMode = ResponseModeType.NotRequired;
        }
    }
}