namespace Adyen.EcommLibrary.Security.Extension
{
    internal static class ArrayExtension
    {
        public static T[] Slice<T>(this T[] source, int start, int end)
        {
            if (end < 0) end = source.Length + end;
            var len = end - start;

            var res = new T[len];
            for (var i = 0; i < len; i++) res[i] = source[i + start];
            return res;
        }
    }
}