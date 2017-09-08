using Flepper.Core.Base;

namespace Flepper.Core.QueryBuilder
{
    internal class AliasOperator : BaseQueryBuilder, IAliasOperator
    {
        public void As(string alias)
        {
            Command.AppendFormat("{0} ", alias);
        }
    }
}