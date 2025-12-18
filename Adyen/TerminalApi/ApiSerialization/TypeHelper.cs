using System;

namespace Adyen.ApiSerialization
{
    internal static class TypeHelper
    {
        internal static Type CreateGenericTypeFromStringFullNamespace(Type genericType, string tFullNamespace)
        {
            Type[] typeArgs = { Type.GetType(tFullNamespace) };
            Type repositoryType = genericType.MakeGenericType(typeArgs);

            return repositoryType;
        }
    }
}
