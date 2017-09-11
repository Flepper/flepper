using System.Linq;

namespace Flepper.QueryBuilder.Utils.Extensions
{
    internal static class ColumnsExtensions
    {
        public static string JoinColumns(this string[] columns)
        {
            var fields = columns.Aggregate("", (current, column) => current + $"[{column}],");

            fields = fields.Remove(fields.Length - 1, 1) + " ";

            return fields;
        }
    }
}
