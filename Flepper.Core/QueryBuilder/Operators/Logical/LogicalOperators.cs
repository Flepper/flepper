using Flepper.Core.Base;

namespace Flepper.Core.QueryBuilder
{
    internal class LogicalOperators : BaseQueryBuilder, ILogicalOperators
    {
        public void And(string column)
        {
            Command.AppendFormat("AND [{0}] ", column);
        }

        public void Or(string column)
        {
            Command.AppendFormat("OR [{0}] ", column);
        }
    }
}
