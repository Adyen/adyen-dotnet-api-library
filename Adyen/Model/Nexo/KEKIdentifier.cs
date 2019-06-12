namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class KEKIdentifier
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string KeyIdentifier;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string KeyVersion;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "base64Binary")]
        public byte[] DerivationIdentifier;
    }
}