using Adyen.ApiSerialization;

namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class CardReaderInitResponse : IMessagePayload
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Response Response;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TrackData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TrackData[] TrackData;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ICCResetData ICCResetData;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public EntryModeType[] EntryMode;
    }
}