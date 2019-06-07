namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HostStatus
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AcquirerID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool IsReachableFlag;

        public HostStatus()
        {
            this.IsReachableFlag = true;
        }
    }
}