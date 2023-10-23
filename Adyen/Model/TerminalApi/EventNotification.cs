using Adyen.ApiSerialization;

namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class EventNotification : IMessagePayload
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EventDetails;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary")]
        public byte[] RejectedMessage;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DisplayOutput DisplayOutput;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public System.DateTime TimeStamp;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public EventToNotifyType EventToNotify;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool? MaintenanceRequiredFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string CustomerLanguage;


    }
}