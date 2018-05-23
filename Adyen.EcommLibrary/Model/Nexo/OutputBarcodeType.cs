namespace Adyen.EcommLibrary.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class OutputBarcodeType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("EAN13")]
        public string BarcodeType;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
        
        public OutputBarcodeType() {
            this.BarcodeType = "EAN13";
        }
    }
}