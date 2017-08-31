using Flepper.Core.Base;
using Flepper.Core.QueryBuilder.Operators.Comparison.Interfaces;

namespace Flepper.Core.QueryBuilder.Operators.Comparison
{
    public class EqualComparisonOperator : BaseFlepperQueryBuilder, IEqualComparisonOperator
    {
        public void Equal(string value)
        {
            Command.AppendFormat("= '{0}' ", value);
        }

        public void Equal(int value)
        {
            Command.AppendFormat("= {0} ", value);
        }
    }
}
