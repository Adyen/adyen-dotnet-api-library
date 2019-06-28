using System;
using System.Collections.Generic;
using System.Text;

namespace Adyen
{
    internal class TypeHelper
    {
        internal static Type CreateGenericTypeFromStringFullNamespace(Type genericType, string tFullNamespace)
        {
            Type[] typeArgs = { Type.GetType(tFullNamespace) };
            Type repositoryType = genericType.MakeGenericType(typeArgs);

            return repositoryType;
        }
    }
}
