#nullable enable

using System.Text.Json;

namespace Adyen.Core
{
    /// <summary>
    /// Provides the <see cref="System.Text.Json.JsonSerializerOptions"/>.
    /// </summary>
    public class JsonSerializerOptionsProvider
    {
        /// <summary>
        /// The <see cref="System.Text.Json.JsonSerializerOptions"/>.
        /// </summary>
        public JsonSerializerOptions Options { get; }

        /// <summary>
        /// Instantiates a JsonSerializerOptionsProvider to access <see cref="System.Text.Json.JsonSerializerOptions"/>.
        /// </summary>
        public JsonSerializerOptionsProvider(JsonSerializerOptions options)
        {
            Options = options;
        }
    }
}