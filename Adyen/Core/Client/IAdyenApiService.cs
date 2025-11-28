namespace Adyen.Core.Client
{
    /// <summary>
    /// Interface for interacting with any Adyen API using <see cref="HttpClient"/>.
    /// </summary>
    public interface IAdyenApiService
    {
        /// <summary>
        /// The <see cref="System.Net.Http.HttpClient"/> object, best practice: instantiate and manage <see cref="System.Net.Http.HttpClient"/> object using the <see cref="IHttpClientFactory"/>.
        /// </summary>
        System.Net.Http.HttpClient HttpClient { get; }
    }
}