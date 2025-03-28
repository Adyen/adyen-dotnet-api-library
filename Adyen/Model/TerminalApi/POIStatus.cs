﻿namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class POIStatus
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CashHandlingDevice", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CashHandlingDevice[] CashHandlingDevice;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public GlobalStatusType GlobalStatus;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public bool? SecurityOKFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? SecurityOKFlagSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public bool? PEDOKFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? PEDOKFlagSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public bool? CardReaderOKFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? CardReaderOKFlagSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public PrinterStatusType? PrinterStatus;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? PrinterStatusSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public bool? CommunicationOKFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? CommunicationOKFlagSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public bool? FraudPreventionFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? FraudPreventionFlagSpecified;
    }
}