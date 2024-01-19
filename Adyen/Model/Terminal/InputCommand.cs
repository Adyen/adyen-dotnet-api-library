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
    /// Defines InputCommand
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InputCommand
    {
        /// <summary>
        /// Enum DecimalString for value: DecimalString
        /// </summary>
        [EnumMember(Value = "DecimalString")]
        DecimalString = 1,

        /// <summary>
        /// Enum DigitString for value: DigitString
        /// </summary>
        [EnumMember(Value = "DigitString")]
        DigitString = 2,

        /// <summary>
        /// Enum GetAnyKey for value: GetAnyKey
        /// </summary>
        [EnumMember(Value = "GetAnyKey")]
        GetAnyKey = 3,

        /// <summary>
        /// Enum GetConfirmation for value: GetConfirmation
        /// </summary>
        [EnumMember(Value = "GetConfirmation")]
        GetConfirmation = 4,

        /// <summary>
        /// Enum GetFunctionKey for value: GetFunctionKey
        /// </summary>
        [EnumMember(Value = "GetFunctionKey")]
        GetFunctionKey = 5,

        /// <summary>
        /// Enum GetMenuEntry for value: GetMenuEntry
        /// </summary>
        [EnumMember(Value = "GetMenuEntry")]
        GetMenuEntry = 6,

        /// <summary>
        /// Enum Password for value: Password
        /// </summary>
        [EnumMember(Value = "Password")]
        Password = 7,

        /// <summary>
        /// Enum SiteManager for value: SiteManager
        /// </summary>
        [EnumMember(Value = "SiteManager")]
        SiteManager = 8,

        /// <summary>
        /// Enum TextString for value: TextString
        /// </summary>
        [EnumMember(Value = "TextString")]
        TextString = 9

    }

}
