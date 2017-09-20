using Flepper.QueryBuilder.Base;
using System.Collections.Generic;
using System.Text;

namespace Flepper.QueryBuilder
{
    internal class Sort : BaseQueryBuilder, ISort
    {
        public Sort(StringBuilder command, IDictionary<string, object> parameters) : base(command, parameters)
        {
        }

        public ISort OrderBy(string column, bool descending)
        {
            column = descending
               ? string.Concat($"[{column}]", " DESC")
               : $"[{column}]";

            Command.AppendFormat(Command.ToString().Contains("ORDER BY")
                ? ",{0}"
                : "ORDER BY {0}", column);

            return this;
        }

        public ISort OrderBy(string tableAlias, string column, bool descending)
        {
            column = descending
                ? string.Concat($"[{column}]", " DESC")
                : $"[{column}]";

            Command.AppendFormat(Command.ToString().Contains("ORDER BY")
               ? ",{0}.{1}"
               : "ORDER BY {0}.{1}", tableAlias, column);

            return this;
        }
    }
}
