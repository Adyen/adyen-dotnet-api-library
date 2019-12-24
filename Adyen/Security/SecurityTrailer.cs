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

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Adyen.Security
{
    ///<usage>
    ///It contains information related to the security of the message
    ///</usage>
    ///<definition>
    ///SecurityTrailer as used by Adyen
    ///</definition>
    public class SecurityTrailer
    {
        [Required]
        public int? AdyenCryptoVersion { get; set; }
        [Required]
        public string KeyIdentifier { get; set; }
        [Required]
        public int? KeyVersion { get; set; }
        [Required]
        public byte[] Nonce { get; set; }
        [Required]
        public byte[] Hmac { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new StringEnumConverter());
        }
    }
}