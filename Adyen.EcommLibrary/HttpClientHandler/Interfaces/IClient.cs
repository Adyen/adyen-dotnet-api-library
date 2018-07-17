using System.Collections.Generic;

namespace Adyen.EcommLibrary.HttpClientHandler.Interfaces
{
    public interface IClient
    {
        string Request(string endpoint, string json, Config config);
        string Post(string endpoint, Dictionary<string, string> postParameters, Config config);
     
    }
}