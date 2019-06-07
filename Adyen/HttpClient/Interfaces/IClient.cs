using System.Collections.Generic;
using System.Net.Security;
using System.Threading.Tasks;
using Adyen.Model;

namespace Adyen.HttpClient.Interfaces
{
    public interface IClient
    {
        string Request(string endpoint, string json, Config config);
        string Request(string endpoint, string json, Config config, bool isApiKeyRequired, RequestOptions requestOptions);
        string Request(string endpoint, string json, Config config, bool isApiKeyRequired, RequestOptions requestOptions, RemoteCertificateValidationCallback remoteCertificateValidationCallback);
        
        Task<string> RequestAsync(string endpoint, string json, Config config, bool isApiKeyRequired, RequestOptions requestOptions);
        string Post(string endpoint, Dictionary<string, string> postParameters, Config config);
    }
}