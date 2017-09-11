
using Flepper.QueryBuilder.Base;

namespace Flepper.QueryBuilder
{
    internal class AliasOperator : BaseQueryBuilder, IAliasOperator
    {
        public void As(string alias)
        {
            Command.AppendFormat("{0} ", alias);
        }
    }
}