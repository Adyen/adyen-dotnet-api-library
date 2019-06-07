namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PrintOutput
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public OutputContent OutputContent;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary")]
        public byte[] OutputSignature;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DocumentQualifierType DocumentQualifier;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ResponseModeType ResponseMode;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool IntegratedPrintFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool RequiredSignatureFlag;

        public PrintOutput()
        {
            this.IntegratedPrintFlag = false;
            this.RequiredSignatureFlag = false;
        }
    }
}