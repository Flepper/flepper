
using System.Text;
using Flepper.QueryBuilder.Base;

namespace Flepper.QueryBuilder
{
    internal class LogicalOperators : BaseQueryBuilder, ILogicalOperators
    {
        public LogicalOperators(StringBuilder command) : base(command)
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
