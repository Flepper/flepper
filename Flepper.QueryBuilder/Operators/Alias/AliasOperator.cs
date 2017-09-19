namespace Flepper.QueryBuilder.Base
{
    internal partial class BaseQueryBuilder : IAliasOperator
    {
        public IAliasOperator As(string alias)
        {
            Command.AppendFormat("{0} ", alias);
            return this;
        }
    }
}