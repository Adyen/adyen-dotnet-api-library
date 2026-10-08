using System.Text.Json;

namespace Adyen.IntegrationTest
{
    public sealed class IntegrationTestConfiguration
    {
        public const string EnvironmentVariableName = "ADYEN_API_LIBRARIES_INTEGRATION_TEST_CONFIG";
        public string Company { get; }
        public string MerchantAccount { get; }
        public string BalancePlatform { get; }
        public string ApiKey { get; }
        public string LemApiKey { get; }
        public string BclApiKey { get; }
        public string GivingCampaignId { get; }
        public string LegalEntityId { get; }
        public string BusinessLineId { get; }
        public string DocumentId { get; }
        public string AccountHolderId { get; }
        public string BalanceAccountId { get; }

        private IntegrationTestConfiguration(JsonElement root)
        {
            var invalidFields = new List<string>();
            Company = RequiredString(root, "company", invalidFields);
            MerchantAccount = RequiredString(root, "merchantAccount", invalidFields);
            BalancePlatform = RequiredString(root, "balancePlatform", invalidFields);
            ApiKey = RequiredString(root, "apiKey", invalidFields);
            LemApiKey = RequiredString(root, "lemApiKey", invalidFields);
            BclApiKey = RequiredString(root, "bclApiKey", invalidFields);
            GivingCampaignId = RequiredString(root, "givingCampaignId", invalidFields);
            LegalEntityId = RequiredString(root, "legalEntityId", invalidFields);
            BusinessLineId = RequiredString(root, "businessLineId", invalidFields);
            DocumentId = RequiredString(root, "documentId", invalidFields);
            AccountHolderId = RequiredString(root, "accountHolderId", invalidFields);
            BalanceAccountId = RequiredString(root, "balanceAccountId", invalidFields);

            if (invalidFields.Count > 0)
                throw new InvalidOperationException(
                    $"Invalid integration test configuration: {string.Join(", ", invalidFields)} " +
                    "must be non-blank JSON strings.");
        }

        public static IntegrationTestConfiguration Load()
        {
            return Load(Environment.GetEnvironmentVariable(EnvironmentVariableName), () =>
            {
                string path = Path.Combine(AppContext.BaseDirectory, "test-config.json");
                if (!File.Exists(path))
                    throw new InvalidOperationException(
                        $"Integration test configuration not found. Set {EnvironmentVariableName}, or copy " +
                        "Adyen.IntegrationTest/test-config.example.json to Adyen.IntegrationTest/test-config.json " +
                        "and complete its values.");

                try
                {
                    return File.ReadAllText(path);
                }
                catch (IOException)
                {
                    throw new InvalidOperationException("Failed to read the integration test configuration file.");
                }
                catch (UnauthorizedAccessException)
                {
                    throw new InvalidOperationException("Failed to read the integration test configuration file.");
                }
            });
        }

        internal static IntegrationTestConfiguration Load(string environmentValue, Func<string> readLocalConfiguration)
        {
            return FromJson(string.IsNullOrWhiteSpace(environmentValue) ? readLocalConfiguration() : environmentValue);
        }

        internal static IntegrationTestConfiguration FromJson(string json)
        {
            JsonDocument document;
            try
            {
                document = JsonDocument.Parse(json);
            }
            catch (JsonException)
            {
                // Parser exceptions can include configuration values. Never retain or log them.
                throw new InvalidOperationException("Failed to parse the integration test configuration JSON.");
            }

            using (document)
            {
                if (document.RootElement.ValueKind != JsonValueKind.Object)
                    throw new InvalidOperationException(
                        "The integration test configuration must be a JSON object with string fields.");

                return new IntegrationTestConfiguration(document.RootElement);
            }
        }

        private static string RequiredString(JsonElement root, string name, List<string> invalidFields)
        {
            if (root.TryGetProperty(name, out JsonElement field) && field.ValueKind == JsonValueKind.String)
            {
                string value = field.GetString().Trim();
                if (value.Length > 0)
                    return value;
            }

            invalidFields.Add(name);
            return null;
        }
    }
}
