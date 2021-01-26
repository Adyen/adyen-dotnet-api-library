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
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// Split
    /// </summary>
    [DataContract]
    [Obsolete("Keep for backwards compatibility, but Adyen.Model.Split should be used instead, as it is required outside of the Checkout namespace")]
    public class Split : Model.Split, IEquatable<Split>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Split" /> class.
        /// </summary>
        [JsonConstructor]
        protected Split() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Split" /> class.
        /// </summary>
        /// <param name="Account">The account to which this split applies.  &gt;Required if the type is &#x60;MarketPlace&#x60;..</param>
        /// <param name="Amount">The amount of this split. (required).</param>
        /// <param name="Description">A description of this split..</param>
        /// <param name="Reference">The reference of this split. Used to link other operations (e.g. captures and refunds) to this split.  &gt;Required if the type is &#x60;MarketPlace&#x60;..</param>
        /// <param name="Type">The type of this split.  &gt;Permitted values: &#x60;Default&#x60;, &#x60;PaymentFee&#x60;, &#x60;VAT&#x60;, &#x60;Commission&#x60;, &#x60;MarketPlace&#x60;, &#x60;Verification&#x60;. (required).</param>
        public Split(string Account = default(string), SplitAmount Amount = default(SplitAmount),
            string Description = default(string), string Reference = default(string), TypeEnum Type = default(TypeEnum)) : base(Account,Amount,Description,Reference,Type)
        {
        }


        public bool Equals(Split other)
        {
            return base.Equals(other);
        }
    }
}
