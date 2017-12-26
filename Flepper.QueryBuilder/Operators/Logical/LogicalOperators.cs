namespace Flepper.QueryBuilder
{
    internal partial class QueryBuilder : ILogicalOperators
    {
        public ILogicalOperators And(string column)
        {
            Command.AppendFormat("AND [{0}] ", column);
            return this;
        }

        public ILogicalOperators And(string tableAlias, string column)
        {
            Command.AppendFormat("AND [{0}].[{1}] ", tableAlias, column);
            return this;
        }

        public ILogicalOperators Or(string column)
        {
            Command.AppendFormat("OR [{0}] ", column);
            return this;
        }

        public ILogicalOperators Or(string tableAlias, string column)
        {
            Command.AppendFormat("OR [{0}].[{1}] ", tableAlias, column);
            return this;
        }
    }
}
