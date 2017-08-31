using Flepper.Core.QueryBuilder.Filters.Interfaces;
using Flepper.Core.QueryBuilder.Operators.Comparison;

namespace Flepper.Core.QueryBuilder.Filters.Extensions
{
    public static class WhereFilterExtensions
    {
        public static EqualComparisonOperator Equal(this IWhereFilter whereFilter, string value)
        {
           var equalCompareOperator = new EqualComparisonOperator();
            equalCompareOperator.Equal(value);
            return equalCompareOperator;
        }

        public static EqualComparisonOperator Equal(this IWhereFilter whereFilter, int value)
        {
            var equalCompareOperator = new EqualComparisonOperator();
            equalCompareOperator.Equal(value);
            return equalCompareOperator;
        }
    }
}
