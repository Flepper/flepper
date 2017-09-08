using System.Linq;

namespace Flepper.Core.Utils.Extensions
{
    public static class ColumnsExtensions
    {
        public static string JoinColumns(this string[] columns)
        {
            var fields = columns.Aggregate("", (current, column) => current + $"[{column}],");

            fields = fields.Remove(fields.Length - 1, 1) + " ";

            return fields;
        }
    }
}
