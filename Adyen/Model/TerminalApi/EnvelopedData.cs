namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class EnvelopedData
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("KEK", typeof(KEK), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("KeyTransport", typeof(KeyTransport), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object[] Items;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public EncryptedContent EncryptedContent;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        [System.ComponentModel.DefaultValueAttribute(VersionType.v0)]
        public VersionType Version;
        
    }
}