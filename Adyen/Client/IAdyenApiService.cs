namespace Adyen.Client
{
    /// <summary>
    /// Interface for interacting with any Adyen API using <see cref="HttpClient"/>.
    /// </summary>
    public interface IAdyenApiService
    {
        /// <summary>
        /// The <see cref="HttpClient"/> object, preferably instantiated and managed using the <see cref="IHttpClientFactory"/>.
        /// </summary>
        System.Net.Http.HttpClient HttpClient { get; }
    }
}