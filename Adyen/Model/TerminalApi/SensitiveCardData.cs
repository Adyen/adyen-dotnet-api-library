﻿namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class SensitiveCardData
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TrackData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TrackData[] TrackData;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string PAN;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string CardSeqNumb;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string ExpiryDate;
    }
}