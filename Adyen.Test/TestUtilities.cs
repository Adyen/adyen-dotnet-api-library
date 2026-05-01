using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Adyen.Test
{
    internal static class TestUtilities
    {
        /// <summary>
        /// Utility function, used to read (mock json) files.
        /// </summary>
        /// <param name="relativePath">The relative file to the file.</param>
        /// <returns>The file contents in string.</returns>
        public static string GetTestFileContent(string relativePath)
        {
            string rootPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../../"));
            string absolutePath = Path.Combine(rootPath, relativePath);
            
            return File.ReadAllText(absolutePath);
        }
    }

    internal class MockDelegatingHandler : DelegatingHandler
    {
        private readonly Func<HttpRequestMessage, HttpResponseMessage> _handler;

        public MockDelegatingHandler(Func<HttpRequestMessage, HttpResponseMessage> handler)
        {
            _handler = handler;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_handler(request));
        }
    }
}