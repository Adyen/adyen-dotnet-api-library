namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SignedData
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DigestAlgorithm", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AlgorithmIdentifier[] DigestAlgorithm;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public EncapsulatedContent EncapsulatedContent;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Certificate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary")]
        public byte[][] Certificate;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Signer", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Signer[] Signer;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(VersionType.v1)]
        public VersionType Version;
    }
}