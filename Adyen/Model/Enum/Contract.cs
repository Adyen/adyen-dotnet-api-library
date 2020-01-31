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

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Adyen.Model.Enum
{
    /// <summary>
    /// The type of recurring contract to be used. Possible values: * &#x60;ONECLICK&#x60; – The shopper opts to store their card details for future use. The shopper is present for the subsequent transaction, for cards the security code (CVC/CVV) is required. * &#x60;RECURRING&#x60; – Payment details are stored for future use. For cards, the security code (CVC/CVV) is not required for subsequent payments. This is used for shopper not present transactions. * &#x60;ONECLICK, RECURRING&#x60; – Payment details are stored for future use. This allows the use of the stored payment details regardless of whether the shopper is on your site or not.
    /// </summary>
    /// <value>The type of recurring contract to be used. Possible values: * &#x60;ONECLICK&#x60; – The shopper opts to store their card details for future use. The shopper is present for the subsequent transaction, for cards the security code (CVC/CVV) is required. * &#x60;RECURRING&#x60; – Payment details are stored for future use. For cards, the security code (CVC/CVV) is not required for subsequent payments. This is used for shopper not present transactions. * &#x60;ONECLICK, RECURRING&#x60; – Payment details are stored for future use. This allows the use of the stored payment details regardless of whether the shopper is on your site or not.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Contract
    {

        /// <summary>
        /// Enum ONECLICK for "ONECLICK"
        /// </summary>
        [EnumMember(Value = "ONECLICK")]
        Oneclick,

        /// <summary>
        /// Enum RECURRING for "RECURRING"
        /// </summary>
        [EnumMember(Value = "RECURRING")]
        Recurring,

        /// <summary>
        /// Enum PAYOUT for "PAYOUT"
        /// </summary>
        [EnumMember(Value = "PAYOUT")]
        Payout
    }

}
