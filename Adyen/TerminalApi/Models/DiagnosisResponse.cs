using Adyen.ApiSerialization;

namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class DiagnosisResponse : IMessagePayload
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Response Response;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LoggedSaleID", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] LoggedSaleID;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public POIStatus POIStatus;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HostStatus", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public HostStatus[] HostStatus;
    }
}