using System;

namespace Adyen.EcommLibrary
{
    internal class TypeHelper
    {
        internal static Type CreateGenericTypeFromStringFullNamespace(Type genericType, string tFullNamespace)
        {
            Type[] typeArgs = {Type.GetType(tFullNamespace)};
            var repositoryType = genericType.MakeGenericType(typeArgs);

            return repositoryType;
        }
    }
}