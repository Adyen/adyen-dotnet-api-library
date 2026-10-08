namespace Adyen.IntegrationTest
{
    public abstract class BaseIntegrationTest
    {
        private static readonly Lazy<IntegrationTestConfiguration> SharedConfiguration =
            new Lazy<IntegrationTestConfiguration>(IntegrationTestConfiguration.Load);
        private readonly IntegrationTestConfiguration _configuration;

        protected BaseIntegrationTest() : this(SharedConfiguration.Value)
        {
        }

        protected BaseIntegrationTest(IntegrationTestConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        protected string Company => _configuration.Company;
        protected string MerchantAccount => _configuration.MerchantAccount;
        protected string BalancePlatformId => _configuration.BalancePlatform;
        protected string ApiKey => _configuration.ApiKey;
        protected string LemApiKey => _configuration.LemApiKey;
        protected string BclApiKey => _configuration.BclApiKey;
        protected string GivingCampaignId => _configuration.GivingCampaignId;
        protected string LegalEntityId => _configuration.LegalEntityId;
        protected string BusinessLineId => _configuration.BusinessLineId;
        protected string DocumentId => _configuration.DocumentId;
        protected string AccountHolderId => _configuration.AccountHolderId;
        protected string BalanceAccountId => _configuration.BalanceAccountId;
    }
}
