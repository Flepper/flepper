using System.Runtime.CompilerServices;

namespace Flepper.QueryBuilder.Utils.Extensions
{
    internal static class StringExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this string[] strs, out string column, out string alias)
        {
            column = strs[0];
            alias = strs[1];
        }
    }
}