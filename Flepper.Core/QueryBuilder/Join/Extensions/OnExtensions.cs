using Flepper.Core.QueryBuilder.Join.Operators;
using Flepper.Core.QueryBuilder.Operators.Comparison;
using Flepper.Core.QueryBuilder.Operators.Comparison.Interfaces;

namespace Flepper.Core.QueryBuilder.Join.Extensions
{
    public static class OnExtensions
    {
        public static IComparisonOperators Equal(this IIOnOperator onOperator, string column)
        {
            var comparisonOperator = ComparisonOperators.Create();
            comparisonOperator.Equal(column as object);
            return comparisonOperator;
        }

        public static IComparisonOperators NotEqual(this IIOnOperator onOperator, string column)
        {
            var comparisonOperator = ComparisonOperators.Create();
            comparisonOperator.NotEqual(column as object);
            return comparisonOperator;
        }
    }
}
