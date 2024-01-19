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
    /// Defines MessageType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MessageType
    {
        /// <summary>
        /// Enum Notification for value: Notification
        /// </summary>
        [EnumMember(Value = "Notification")]
        Notification = 1,

        /// <summary>
        /// Enum Request for value: Request
        /// </summary>
        [EnumMember(Value = "Request")]
        Request = 2,

        /// <summary>
        /// Enum Response for value: Response
        /// </summary>
        [EnumMember(Value = "Response")]
        Response = 3

    }

}
