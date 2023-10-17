﻿namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class HostStatus
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string AcquirerID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool? IsReachableFlag;

        public HostStatus()
        {
            IsReachableFlag = true;
        }
    }
}