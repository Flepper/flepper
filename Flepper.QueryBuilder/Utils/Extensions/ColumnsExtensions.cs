using System.Collections.Generic;

namespace Flepper.QueryBuilder.Utils.Extensions
{
    internal static class ColumnsExtensions
    {
        private const string ALIAS = " AS ";
        private static readonly string[] AliasSplitter = { ALIAS, " as " };
        public static string JoinColumns(this IEnumerable<string> columns)
            => string.Join(",", columns) + " ";
    }
}