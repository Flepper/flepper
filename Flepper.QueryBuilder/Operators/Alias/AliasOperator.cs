namespace Flepper.QueryBuilder
{
    internal partial class QueryBuilder : IAliasOperator
    {
        public IAliasOperator As(string alias)
        {
            Command.AppendFormat("{0} ", alias);
            return this;
        }
    }
}