#nullable enable

using System;

namespace Adyen.Core.Auth
{
    /// <summary>
    /// The base class for all tokens.
    /// </summary>
    public abstract class TokenBase
    {
        /// <summary>
        /// The constructor for the parent TokenBase object.
        /// Example usages: <see cref="ApiKeyToken"/> or <see cref="BasicToken"/>.
        /// </summary>
        internal TokenBase()
        {
        }
    }
}