namespace Adyen.EcommLibrary.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TrackDataType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        [System.ComponentModel.DefaultValueAttribute("2")]
        public string TrackNumb;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("ISO")]
        public string TrackFormat;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
        
        public TrackDataType() {
            this.TrackNumb = "2";
            this.TrackFormat = "ISO";
        }
    }
}