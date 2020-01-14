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
    public enum ContentType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("id-data")]
        iddata,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("id-signedData")]
        idsignedData,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("id-envelopedData")]
        idenvelopedData,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("id-digestedData")]
        iddigestedData,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("id-encryptedData")]
        idencryptedData,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("id-ct-authData")]
        idctauthData,
    }
}