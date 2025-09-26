namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class OutputBarcode
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        [System.ComponentModel.DefaultValueAttribute(BarcodeType.EAN13)]
        public BarcodeType BarcodeType;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute]
        public string BarcodeValue;
    }
}