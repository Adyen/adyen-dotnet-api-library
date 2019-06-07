namespace Adyen.EcommLibrary.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ContentInformationType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AuthenticatedData", typeof(AuthenticatedDataType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("DigestedData", typeof(DigestedDataType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("EnvelopedData", typeof(EnvelopedDataType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("NamedKeyEncryptedData", typeof(NamedKeyEncryptedDataType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("SignedData", typeof(SignedDataType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object Item;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ContentType;
    }
}