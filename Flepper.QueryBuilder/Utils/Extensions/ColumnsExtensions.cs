using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Flepper.QueryBuilder.Utils.Extensions
{
    internal static class ColumnsExtensions
    {
        private const string ALIAS = " AS ";
        private static readonly string[] AliasSplitter = { ALIAS, " as " };

        public static string JoinColumns(this string[] columns)
            => string.Join(",", GetAllColumnsWithAlias(columns)) + " ";

        private static IEnumerable<string> GetAllColumnsWithAlias(string[] columns)
        {
            foreach (var column in columns)
            {
                if (string.IsNullOrWhiteSpace(column))
                    throw new ArgumentNullException(nameof(columns), "All columns names should not be null");
                if (ContainsAlias(column))
                    yield return GetColumnWithAlias(column);
                else
                    yield return $"[{column}]";
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static string GetColumnWithAlias(string column)
        {
            var (columnName, alias) = column.Split(AliasSplitter, StringSplitOptions.RemoveEmptyEntries);
            return $"[{columnName}]{ALIAS}{alias}";
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool ContainsAlias(string source)
            => source.IndexOf(ALIAS, StringComparison.OrdinalIgnoreCase) > 0;
    }
}