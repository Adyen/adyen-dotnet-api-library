#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2019 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using Adyen.Constants;

namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MessageHeader
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProtocolVersion { private set; get; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MessageClassType MessageClass;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MessageCategoryType MessageCategory;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MessageType MessageType;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ServiceID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DeviceID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SaleID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string POIID;

        public MessageHeader()
        {
            ProtocolVersion = ClientConfig.NexoProtocolVersion;
        }
    }
}