﻿namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class ContentInformation
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AuthenticatedData", typeof(AuthenticatedData), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("DigestedData", typeof(DigestedData), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("EnvelopedData", typeof(EnvelopedData), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("NamedKeyEncryptedData", typeof(NamedKeyEncryptedData), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("SignedData", typeof(SignedData), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object MessagePayload;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public ContentType ContentType;
    }
}