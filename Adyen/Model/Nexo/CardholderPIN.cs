namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class CardholderPIN
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ContentInformation EncrPINBlock;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public PINFormatType PINFormat;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string AdditionalInput;
    }
}