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
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    public enum TrackFormatType
    {

        /// <remarks/>
        ISO,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("JIS-I")]
        JISI,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("JIS-II")]
        JISII,

        /// <remarks/>
        AAMVA,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("CMC-7")]
        CMC7,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("E-13B")]
        E13B,
    }
}