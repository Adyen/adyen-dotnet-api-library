namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class OutputBarcode
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(BarcodeType.EAN13)]
        public BarcodeType Barcode;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;

        public OutputBarcode()
        {
            this.Barcode = BarcodeType.EAN13;
        }
    }
}