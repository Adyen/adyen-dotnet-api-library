﻿namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Response
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AdditionalResponse;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ResultType Result;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ErrorConditionType ErrorCondition;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool? ErrorConditionSpecified;
    }
}