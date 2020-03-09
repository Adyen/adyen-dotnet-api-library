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

using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Enum
{
    /// <summary>
    /// Defines a recurring payment type. Allowed values: Subscription – A transaction for a fixed or variable amount, which follows a fixed schedule. CardOnFile – Card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction. UnscheduledCardOnFile – Transaction that occurs on a non-fixed schedule using stored card details. For example, automatic top-ups when the cardholder's balance drops below certain amount.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RecurringProcessingModelEnum
    {
        /// <summary>
        /// Enum CardOnFile for value: CardOnFile
        /// </summary>
        [EnumMember(Value = "CardOnFile")]
        CardOnFile = 1,

        /// <summary>
        /// Enum Subscription for value: Subscription
        /// </summary>
        [EnumMember(Value = "Subscription")]
        Subscription = 2,

        /// <summary>
        /// Enum Subscription for value: UnscheduledCardOnFile
        /// </summary>
        [EnumMember(Value = "UnscheduledCardOnFile")]
        UnscheduledCardOnFile = 3
    }
}

