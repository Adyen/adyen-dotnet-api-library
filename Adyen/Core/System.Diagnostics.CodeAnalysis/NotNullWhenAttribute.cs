// This is a backport of the NotNullWhenAttribute for frameworks that do not provide it (for example, .NET Standard 2.0).
// The attribute is used by the C# compiler to improve nullable reference type flow analysis and has no effect at runtime.
#if NETSTANDARD2_0 || NET462
namespace System.Diagnostics.CodeAnalysis
{
    /// <summary>
    /// Specifies that when a method returns the specified <see cref="Boolean"/> value, the parameter, field, or property will not be null.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.Property, AllowMultiple = false)]
    internal sealed class NotNullWhenAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotNullWhenAttribute"/> class.
        /// </summary>
        /// <param name="returnValue">The return value condition. If the method returns this value,the associated parameter, field, or property is guaranteed to be non-null.</param>
        public NotNullWhenAttribute(bool returnValue)
        {
        }
    }
}
#endif