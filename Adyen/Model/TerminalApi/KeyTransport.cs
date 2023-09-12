namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class KeyTransport
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RecipientIdentifier RecipientIdentifier;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AlgorithmIdentifier KeyEncryptionAlgorithm;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        [System.ComponentModel.DefaultValueAttribute(VersionType.v0)]
        public VersionType Version;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "base64Binary")]
        public byte[] EncryptedKey;
    }
}