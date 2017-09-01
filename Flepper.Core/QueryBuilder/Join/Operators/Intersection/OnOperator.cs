using Flepper.Core.Base;
using Flepper.Core.QueryBuilder.Join.Operators.Intersection.Interfaces;

namespace Flepper.Core.QueryBuilder.Join.Operators.Intersection
{
    public class OnOperator : BaseFlepperQueryBuilder, IIOnOperator
    {
        public void On(string tableAlias, string column)
        {
            Command.AppendFormat("ON {0}.[{1}] ", tableAlias, column);
        }
    }
}
