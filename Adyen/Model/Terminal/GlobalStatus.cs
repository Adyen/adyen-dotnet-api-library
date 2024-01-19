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
    /// Defines GlobalStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GlobalStatus
    {
        /// <summary>
        /// Enum Busy for value: Busy
        /// </summary>
        [EnumMember(Value = "Busy")]
        Busy = 1,

        /// <summary>
        /// Enum Maintenance for value: Maintenance
        /// </summary>
        [EnumMember(Value = "Maintenance")]
        Maintenance = 2,

        /// <summary>
        /// Enum OK for value: OK
        /// </summary>
        [EnumMember(Value = "OK")]
        OK = 3,

        /// <summary>
        /// Enum Unreachable for value: Unreachable
        /// </summary>
        [EnumMember(Value = "Unreachable")]
        Unreachable = 4

    }

}
