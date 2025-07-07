using System.Net.Http;

namespace Adyen.Service.Checkout
{
    /// <summary>
    /// Any Api client
    /// </summary>
    public interface IApi
    {
        /// <summary>
        /// The HttpClient
        /// </summary>
        System.Net.Http.HttpClient HttpClient { get; }
    }
}