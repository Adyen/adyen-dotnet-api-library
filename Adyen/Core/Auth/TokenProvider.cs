namespace Adyen.Core.Auth
{    
    /// <summary>
    /// An interface for providing <see cref="TTokenBase"/> tokens in a generic way.
    /// </summary>
    /// <typeparam name="TTokenBase"></typeparam>
    public interface ITokenProvider<TTokenBase> where TTokenBase : TokenBase
    {
        /// <summary>
        /// Retrieves the stored token.
        /// </summary>
        /// <returns><see cref="TTokenBase"/></returns>
        TTokenBase Get();
    }
    
    /// <summary>
    /// A class which will provide tokens from type <see cref="TTokenBase"/>.
    /// </summary>
    /// <typeparam name="TTokenBase"></typeparam>
    public class TokenProvider<TTokenBase> : ITokenProvider<TTokenBase> where TTokenBase : TokenBase
    {
        private readonly TTokenBase _token;

        /// <summary>
        /// Initializes a token with type <see cref="TTokenBase"/>.
        /// </summary>
        /// <param name="token"><see cref="TTokenBase"/></param>
        public TokenProvider(TTokenBase token)
        {
            _token = token;
        }
        
        /// <summary>
        /// Retrieves the stored token.
        /// </summary>
        /// <returns><see cref="TTokenBase"/></returns>
        public TTokenBase Get()
        {
            return _token;
        }
    }
}