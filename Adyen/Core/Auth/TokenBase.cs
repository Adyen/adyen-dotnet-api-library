#nullable enable

using System;

namespace Adyen.Core.Auth
{
    /// <summary>
    /// The base class for all auth tokens.
    /// </summary>
    public abstract class TokenBase
    {
        /// <summary>
        /// The constructor for the TokenBase object, used by <see cref="ITokenProvider{TTokenBase}"/>.
        /// </summary>
        protected TokenBase()
        {
            
        }
    }
}