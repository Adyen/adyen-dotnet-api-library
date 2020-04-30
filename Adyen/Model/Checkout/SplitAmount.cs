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
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// SplitAmount
    /// </summary>
    [DataContract]
    [Obsolete("Keep for backwards compatibility, but Adyen.Model.SplitAmount should be used instead, as it is required outside of the Checkout namespace")]
    public partial class SplitAmount : Model.SplitAmount, IEquatable<SplitAmount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SplitAmount" /> class.
        /// </summary>
        [JsonConstructor]
        protected SplitAmount() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitAmount" /> class.
        /// </summary>
        /// <param name="Currency">The three-character [ISO currency code](https://docs.adyen.com/developers/development-resources/currency-codes).  If this value is not provided, the currency in which the payment is made will be used..</param>
        /// <param name="Value">The payable amount that can be charged for the transaction.  The transaction amount needs to be represented in minor units according to the [following table](https://docs.adyen.com/developers/development-resources/currency-codes). (required).</param>
        public SplitAmount(string Currency = default(string), long? Value = default(long?)) :base(Currency,Value)
        {
        }

        public bool Equals(SplitAmount other)
        {
            return base.Equals(other);
        }
    }
}
