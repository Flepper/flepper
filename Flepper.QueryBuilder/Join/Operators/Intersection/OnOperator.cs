
using Flepper.QueryBuilder.Base;

namespace Flepper.QueryBuilder
{
    internal class OnOperator : BaseQueryBuilder, IIOnOperator
    {
        public void On(string tableAlias, string column)
        {
            Command.AppendFormat("ON {0}.[{1}] ", tableAlias, column);
        }
    }
}
