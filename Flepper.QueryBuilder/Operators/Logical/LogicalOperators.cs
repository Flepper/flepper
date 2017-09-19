namespace Flepper.QueryBuilder.Base
{
    internal partial class BaseQueryBuilder : ILogicalOperators
    {
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
