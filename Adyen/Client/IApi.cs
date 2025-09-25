namespace Adyen.Client
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