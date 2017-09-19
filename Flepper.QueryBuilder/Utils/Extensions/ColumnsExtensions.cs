using System;
using System.Collections.Generic;
using System.Linq;

namespace Flepper.QueryBuilder.Utils.Extensions
{
    internal static class ColumnsExtensions
    {
        private const string ALIAS = " AS ";

        public static string JoinColumns(this string[] columns)
        {
            var newColumns = GetAllColumnsWithAlias(columns);
            var fields = newColumns.Aggregate("", (current, column) => current + $"{column},");
            fields = fields.Remove(fields.Length - 1, 1) + " ";
            return fields;
        }

        private static List<string> GetAllColumnsWithAlias(string[] columns)
        {
            var newColumns = new List<string>(columns.Length);
            foreach (var column in columns)
            {
                if (ContainsIgnoreCase(column, ALIAS))
                    newColumns.Add(GetColumnWithAlias(column));
                else
                    newColumns.Add($"[{column}]");
            }

            return newColumns;
        }

        private static string GetColumnWithAlias(string column)
        {
            var indexOfAlias = column.IndexOf(ALIAS, StringComparison.OrdinalIgnoreCase);
            var columnName = column.Substring(0, indexOfAlias);
            var aliasName = column.Substring(indexOfAlias + ALIAS.Length);
            return $"[{columnName}]{ALIAS}{aliasName}";
        }

        private static bool ContainsIgnoreCase(string source, string value)
            => value != null && source?.IndexOf(value, StringComparison.OrdinalIgnoreCase) >= 0;
    }
}