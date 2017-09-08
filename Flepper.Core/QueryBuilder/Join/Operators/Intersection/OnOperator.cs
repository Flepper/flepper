using Flepper.Core.Base;

namespace Flepper.Core.QueryBuilder
{
    internal class OnOperator : BaseQueryBuilder, IIOnOperator
    {
        public void On(string tableAlias, string column)
        {
            Command.AppendFormat("ON {0}.[{1}] ", tableAlias, column);
        }
    }
}
