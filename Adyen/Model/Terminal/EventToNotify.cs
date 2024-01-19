/*
* Adyen Terminal API
*
*
* The version of the OpenAPI document: 1
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.Terminal
{
    /// <summary>
    /// Event the POI notifies to the Sale System.
    /// </summary>
    /// <value>Event the POI notifies to the Sale System.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EventToNotify
    {
        /// <summary>
        /// Enum Abort for value: Abort
        /// </summary>
        [EnumMember(Value = "Abort")]
        Abort = 1,

        /// <summary>
        /// Enum BeginMaintenance for value: BeginMaintenance
        /// </summary>
        [EnumMember(Value = "BeginMaintenance")]
        BeginMaintenance = 2,

        /// <summary>
        /// Enum CardInserted for value: CardInserted
        /// </summary>
        [EnumMember(Value = "CardInserted")]
        CardInserted = 3,

        /// <summary>
        /// Enum CardRemoved for value: CardRemoved
        /// </summary>
        [EnumMember(Value = "CardRemoved")]
        CardRemoved = 4,

        /// <summary>
        /// Enum Completed for value: Completed
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed = 5,

        /// <summary>
        /// Enum CustomerLanguage for value: CustomerLanguage
        /// </summary>
        [EnumMember(Value = "CustomerLanguage")]
        CustomerLanguage = 6,

        /// <summary>
        /// Enum EndMaintenance for value: EndMaintenance
        /// </summary>
        [EnumMember(Value = "EndMaintenance")]
        EndMaintenance = 7,

        /// <summary>
        /// Enum Initialised for value: Initialised
        /// </summary>
        [EnumMember(Value = "Initialised")]
        Initialised = 8,

        /// <summary>
        /// Enum KeyPressed for value: KeyPressed
        /// </summary>
        [EnumMember(Value = "KeyPressed")]
        KeyPressed = 9,

        /// <summary>
        /// Enum OutOfOrder for value: OutOfOrder
        /// </summary>
        [EnumMember(Value = "OutOfOrder")]
        OutOfOrder = 10,

        /// <summary>
        /// Enum Reject for value: Reject
        /// </summary>
        [EnumMember(Value = "Reject")]
        Reject = 11,

        /// <summary>
        /// Enum SaleAdmin for value: SaleAdmin
        /// </summary>
        [EnumMember(Value = "SaleAdmin")]
        SaleAdmin = 12,

        /// <summary>
        /// Enum SaleWakeUp for value: SaleWakeUp
        /// </summary>
        [EnumMember(Value = "SaleWakeUp")]
        SaleWakeUp = 13,

        /// <summary>
        /// Enum SecurityAlarm for value: SecurityAlarm
        /// </summary>
        [EnumMember(Value = "SecurityAlarm")]
        SecurityAlarm = 14,

        /// <summary>
        /// Enum Shutdown for value: Shutdown
        /// </summary>
        [EnumMember(Value = "Shutdown")]
        Shutdown = 15,

        /// <summary>
        /// Enum StopAssistance for value: StopAssistance
        /// </summary>
        [EnumMember(Value = "StopAssistance")]
        StopAssistance = 16

    }

}
