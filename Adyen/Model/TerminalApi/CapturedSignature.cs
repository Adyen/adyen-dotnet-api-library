namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class CapturedSignature
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AreaSize AreaSize;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SignaturePoint?", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SignaturePoint[] SignaturePoint;
    }
}