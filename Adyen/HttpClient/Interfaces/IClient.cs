using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Model;

namespace Adyen.HttpClient.Interfaces
{
    public interface IClient : IDisposable
    {
        /// <summary>
        /// Sends a synchronous request to the specified <paramref name="endpoint"/>.
        /// </summary>
        /// <param name="endpoint">URL of the endpoint.</param>
        /// <param name="json">Json request parameters for Post/Patch.</param>
        /// <param name="requestOptions">Optional parameter used to specify the options for the request.</param>
        /// <param name="httpMethod">Request Method.</param>
        /// <returns>A string response in json format.</returns>
        string Request(string endpoint, string json, RequestOptions requestOptions = null, HttpMethod httpMethod = null);
        
        /// <summary>
        /// Sends an asynchronous request to the specified <paramref name="endpoint"/>.
        /// </summary>
        /// <param name="endpoint">URL of the endpoint.</param>
        /// <param name="json">Json request parameters for Post/Patch.</param>
        /// <param name="requestOptions">Optional parameter used to specify the options for the request.</param>
        /// <param name="httpMethod">Request Method.</param>
        /// <param name="cancellationToken">Request Method.</param>
        /// <returns>A <see cref="Task"/> with string response in json format.</returns>
        Task<string> RequestAsync(string endpoint, string json, RequestOptions requestOptions = null, HttpMethod httpMethod = null, CancellationToken cancellationToken = default);
    }
}