namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class TransmitRequest
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary")]
        public byte[] Message;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool? WaitResponseFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public int? MaximumTransmitTime;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string DestinationAddress;
    }
}