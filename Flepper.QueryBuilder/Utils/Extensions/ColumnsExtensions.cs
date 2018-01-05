using System.Collections.Generic;

namespace Flepper.QueryBuilder.Utils.Extensions
{
    internal static class ColumnsExtensions
    {
        public static string JoinColumns(this IEnumerable<string> columns)
            => string.Join(",", columns) + " ";
    }
}