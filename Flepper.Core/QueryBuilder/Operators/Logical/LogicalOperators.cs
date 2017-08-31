using Flepper.Core.Base;
using Flepper.Core.QueryBuilder.Operators.Logical.Interfaces;

namespace Flepper.Core.QueryBuilder.Operators.Logical
{
    public class LogicalOperators : BaseFlepperQueryBuilder, ILogicalOperators
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
