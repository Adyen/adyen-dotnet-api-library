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

namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    public enum AlgorithmType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("id-retail-cbc-mac")]
        idretailcbcmac,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("id-retail-cbc-mac-sha-256")]
        idretailcbcmacsha256,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("id-ukpt-wrap ")]
        idukptwrap,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("id-dukpt-wrap")]
        iddukptwrap,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("des-ede3-ecb")]
        desede3ecb,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("des-ede3-cbc")]
        desede3cbc,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("id-sha256")]
        idsha256,

        /// <remarks/>
        sha256WithRSAEncryption,

        /// <remarks/>
        rsaEncryption,
    }
}