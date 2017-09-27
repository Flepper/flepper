using System.Collections.Generic;
using System.Text;
using Flepper.QueryBuilder.Base;

namespace Flepper.QueryBuilder
{
    internal class LogicalOperators : BaseQueryBuilder, ILogicalOperators
    {
        public LogicalOperators(StringBuilder command, IDictionary<string, object> parameters, SqlColumn[] columns) : base(command, parameters, columns)
        {
        }

        public ILogicalOperators And(string column)
        {
            Command.AppendFormat("AND [{0}] ", column);
            return this;
        }

        public ILogicalOperators Or(string column)
        {
            Command.AppendFormat("OR [{0}] ", column);
            return this;
        }
    }
}
