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

        public ISort OrderBy(string column)
        {
            Command.AppendFormat(Command.ToString().Contains("ORDER BY")
                ? ",[{0}]"
                : "ORDER BY [{0}]", column);

            return this;
        }

        public ISort OrderBy(string tableAlias, string column)
        {
            Command.AppendFormat(Command.ToString().Contains("ORDER BY")
               ? ",{0}.[{1}]"
               : "ORDER BY {0}.[{1}]", tableAlias, column);

            return this;
        }

        public ISort OrderByDescending(string column)
        {
            Command.AppendFormat(Command.ToString().Contains("ORDER BY")
                ? ",[{0}]"
                : "ORDER BY [{0}]", column);

            var findClause = Command.ToString()
                .LastIndexOf(" DESC");

            if (findClause > 0)
                Command.Remove(findClause, 5);

            Command.Append(" DESC");

            return this;
        }

        public ISort OrderByDescending(string tableAlias, string column)
        {
            Command.AppendFormat(Command.ToString().Contains("ORDER BY")
               ? ",{0}.[{1}]"
               : "ORDER BY {0}.[{1}]", tableAlias, column);

            var findClause = Command.ToString()
                .LastIndexOf(" DESC");

            if (findClause > 0)
                Command.Remove(findClause, 5);

            Command.Append(" DESC");

            return this;
        }
    }
}
