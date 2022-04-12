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
    /// Indicates if the modification request has been received for processing.
    /// </summary>
    /// <value>Indicates if the modification request has been received for processing.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResponseEnum
    {
        /// <summary>
        /// Enum CaptureReceived for value: [capture-received]
        /// </summary>
        [EnumMember(Value = "[capture-received]")]
        CaptureReceived = 1,

        /// <summary>
        /// Enum CancelReceived for value: [cancel-received]
        /// </summary>
        [EnumMember(Value = "[cancel-received]")]
        CancelReceived = 2,

        /// <summary>
        /// Enum RefundReceived for value: [refund-received]
        /// </summary>
        [EnumMember(Value = "[refund-received]")]
        RefundReceived = 3,

        /// <summary>
        /// Enum CancelOrRefundReceived for value: [cancelOrRefund-received]
        /// </summary>
        [EnumMember(Value = "[cancelOrRefund-received]")]
        CancelOrRefundReceived = 4,

        /// <summary>
        /// Enum AdjustAuthorisationReceived for value: [adjustAuthorisation-received]
        /// </summary>
        [EnumMember(Value = "[adjustAuthorisation-received]")]
        AdjustAuthorisationReceived = 5,

        /// <summary>
        /// Enum DonationReceived for value: [donation-received]
        /// </summary>
        [EnumMember(Value = "[donation-received]")]
        DonationReceived = 6,

        /// <summary>
        /// Enum TechnicalCancelReceived for value: [technical-cancel-received]
        /// </summary>
        [EnumMember(Value = "[technical-cancel-received]")]
        TechnicalCancelReceived = 7,

        /// <summary>
        /// Enum VoidPendingRefundReceived for value: [voidPendingRefund-received]
        /// </summary>
        [EnumMember(Value = "[voidPendingRefund-received]")]
        VoidPendingRefundReceived = 8
    }
}