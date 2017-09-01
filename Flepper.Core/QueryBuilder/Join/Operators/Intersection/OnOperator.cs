using Flepper.Core.Base;

namespace Flepper.Core.QueryBuilder
{
    public class OnOperator : BaseFlepperQueryBuilder, IIOnOperator
    {
        public void On(string tableAlias, string column)
        {
            Command.AppendFormat("ON {0}.[{1}] ", tableAlias, column);
        }
    }
}
