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

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Enum
{
    /// <summary>
    /// The result of the payment.
    /// </summary>
    /// <value>The result of the payment.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResultCodeEnum
    {

        /// <summary>
        /// The payment was successfully authorised.	
        /// Inform the shopper that the payment was successful.
        /// </summary>
        [EnumMember(Value = "Authorised")]
        Authorised,

        /// <summary>
        /// Enum PartiallyAuthorised for "PartiallyAuthorised"
        /// </summary>
        [EnumMember(Value = "PartiallyAuthorised")]
        PartiallyAuthorised,

        /// <summary>
        /// The payment has been successfully authenticated with 3D Secure.
        /// This result code applies to standalone authentication-only integrations.
        /// Collect the 3D Secure 2 authentication data that you will need to authorise the payment.
        /// </summary>
        [EnumMember(Value = "AuthenticationFinished")]
        AuthenticationFinished,

        /// <summary>
        /// The payment was refused.
        /// You'll receive a refusalReason in the same response that indicates why it was refused. We do not recommend disclosing this refusal reason to the shopper.
        /// For more information, see Refusal reasons.
        /// Inform the shopper that their payment was refused and ask them to try the payment again, for example, using a different payment method or card.
        /// </summary>
        [EnumMember(Value = "Refused")]
        Refused,

        /// <summary>
        /// There was an error when the payment was being processed.
        /// You'll receive a refusalReason in the same response, indicating the cause of the error. We do not recommend disclosing this refusal reason to the shopper.
        /// For more information, see Refusal reasons.
        /// Inform the shopper that there was an error processing their payment.
        /// </summary>
        [EnumMember(Value = "Error")]
        Error,

        /// <summary>
        /// The payment was cancelled (by either the shopper or your own system) before processing was completed.	
        /// Inform the shopper that their payment was cancelled.
        /// Contact the shopper to check whether they want to continue with their order.
        /// </summary>
        [EnumMember(Value = "Cancelled")]
        Cancelled,

        /// <summary>
        /// This is part of the standard payment flow for methods such as SEPA Direct Debit, where it can take some time before the final status of the payment is known.
        /// Inform the shopper that you've received their order, and are waiting for the payment to clear.
        /// You will receive the final result of the payment in an AUTHORISATION notification.
        /// It can take minutes, hours, or even days for some payments to clear.
        /// </summary>
        [EnumMember(Value = "Received")]
        Received,

        /// <summary>
        /// The shopper needs to be redirected to an external web page or app to complete the payment.
        /// Redirect the shopper to complete the payment.
        /// </summary>
        [EnumMember(Value = "RedirectShopper")]
        RedirectShopper,

        /// <summary>
        /// The issuer requires the shopper's device fingerprint before the payment can be authenticated. Returned for 3D Secure 2 transactions.
        /// Initiate the 3D Secure 2 device fingerprinting process and submit the result to Adyen.
        /// </summary>
        [EnumMember(Value = "IdentifyShopper")]
        IdentifyShopper,

        /// <summary>
        /// The issuer requires further shopper interaction before the payment can be authenticated. Returned for 3D Secure 2 transactions.
        /// Present the challenge flow to the shopper and submit the result to Adyen.
        /// </summary>
        [EnumMember(Value = "ChallengeShopper")]
        ChallengeShopper,
        
        /// <summary>
        /// The transaction does not require 3D Secure authentication, for example, the issuing bank does not require authentication or the transaction is out of scope.
        /// Since authentication is not required for the transaction, you can already proceed to authorise the payment.
        /// Check the authenticationNotRequiredReason parameter to know why authentication was skipped.
        /// This result code applies to standalone authentication-only integrations.
        /// </summary>
        [EnumMember(Value = "AuthenticationNotRequired")]
        AuthenticationNotRequired,
        
        /// <summary>
        /// It's not possible to obtain the final status of the payment at this time.
        /// This is common for payments with an asynchronous flow, such as Boleto or iDEAL.
        /// Inform the shopper that you've received their order, and are waiting for the shopper to complete the payment.
        /// When the shopper has completed the payment you will receive a successful AUTHORISATION notification.
        /// It can take minutes, hours, or even days for some payments to be completed.
        /// </summary>
        [EnumMember(Value = "Pending")]
        Pending,
        
        /// <summary>
        /// Present the voucher or the QR code to the shopper.
        /// Inform the shopper that you've received their order, and are waiting for the payment to be completed.
        /// When the shopper has completed the payment you will receive a successful AUTHORISATION notification.
        /// </summary>
        [EnumMember(Value = "PresentToShopper")]
        PresentToShopper,
    }
}
