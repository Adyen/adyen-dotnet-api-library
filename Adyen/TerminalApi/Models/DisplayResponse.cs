using Adyen.ApiSerialization;

namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class DisplayResponse : IMessagePayload
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OutputResult", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public OutputResult[] OutputResult;
    }
}