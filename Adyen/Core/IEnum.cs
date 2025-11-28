namespace Adyen.Core
{
    /// <summary>
    /// Interface for defining enums.
    /// This interface is used to make enums forward-compatible.
    /// </summary>
    public interface IEnum
    {
        string? Value { get; set; }
    }
}