using Flepper.Core.Base;

namespace Flepper.Core.QueryBuilder
{
    public class AliasOperator : BaseFlepperQueryBuilder, IAliasOperator
    {
        public void As(string alias)
        {
            Command.AppendFormat("{0} ", alias);
        }
    }
}