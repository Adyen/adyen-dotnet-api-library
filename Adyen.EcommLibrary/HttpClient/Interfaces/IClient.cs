using System.Collections.Generic;
using System.Threading.Tasks;
using Adyen.EcommLibrary;

namespace Adyen.EcommLibrary.HttpClient.Interfaces
{
    public interface IClient
    {
        string Request(string endpoint, string json, Config config);
        string Post(string endpoint, Dictionary<string, string> postParameters, Config config);
    }
}