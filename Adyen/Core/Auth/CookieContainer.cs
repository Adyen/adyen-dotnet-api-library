#nullable enable

using System.Linq;
using System.Collections.Generic;

namespace Adyen.Core.Auth
{
    /// <summary>
    /// A class containing a CookieContainer
    /// </summary>
    public sealed class CookieContainer
    {
        /// <summary>
        /// The collection of tokens
        /// </summary>
        public System.Net.CookieContainer Value { get; } = new System.Net.CookieContainer();
    }
}