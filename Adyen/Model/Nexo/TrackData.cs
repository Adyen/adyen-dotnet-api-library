namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TrackData
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        [System.ComponentModel.DefaultValueAttribute("2")]
        public int TrackNumb;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(TrackFormatType.ISO)]
        public TrackFormatType TrackFormat;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;

        public TrackData()
        {
            this.TrackNumb = 2;
            this.TrackFormat = TrackFormatType.ISO;
        }
    }
}