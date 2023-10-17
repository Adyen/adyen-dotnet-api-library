namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class DiagnosisRequest
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AcquirerID", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] AcquirerID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string POIID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool? HostDiagnosisFlag;

        public DiagnosisRequest()
        {
            HostDiagnosisFlag = false;
        }
    }
}