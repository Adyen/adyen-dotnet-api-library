namespace Adyen.Core.Options
{
    /// <summary>
    /// The Adyen Environment.
    /// Changing this value affects the ClientUtils.BASE_URL where your API requests are sent.
    /// </summary>
    public enum AdyenEnvironment
    {
        Test,
        Live
    }
}