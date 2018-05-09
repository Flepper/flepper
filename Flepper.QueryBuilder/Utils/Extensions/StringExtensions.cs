using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

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