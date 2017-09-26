using System.Collections.Generic;
using System.Text;
using Flepper.QueryBuilder.Base;

namespace Flepper.QueryBuilder
{
    internal class WhereFilter : BaseQueryBuilder, IWhereFilter
    {
        public WhereFilter(StringBuilder command, IDictionary<string, object> parameters, SqlColumn[] columns) : base(command, parameters, columns)
        {
        }

        public IWhereFilter Where(string field)
        {
            Command.AppendFormat("WHERE [{0}] ", field);
            return this;
        }

        public IWhereFilter Where(string tableAlias, string field)
        {
            Command.AppendFormat("WHERE {0}.[{1}] ", tableAlias, field);
            return this;
        }
    }
}
