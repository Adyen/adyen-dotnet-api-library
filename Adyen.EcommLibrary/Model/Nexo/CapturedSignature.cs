namespace Adyen.EcommLibrary.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CapturedSignature
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AreaSize AreaSize;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SignaturePoint", Form =
            System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SignaturePoint[] SignaturePoint;
    }
}