namespace Adyen.EcommLibrary.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HostStatusType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AcquirerID;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool IsReachableFlag;
        
        public HostStatusType() {
            this.IsReachableFlag = true;
        }
    }
}