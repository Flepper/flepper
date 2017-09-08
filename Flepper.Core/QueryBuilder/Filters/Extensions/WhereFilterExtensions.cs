
namespace Flepper.Core.QueryBuilder
{
    public static class WhereFilterExtensions
    {
        private static readonly ComparisonOperators ComparisonOperators = ComparisonOperators.Create();

        public static IComparisonOperators EqualTo(this IWhereFilter whereFilter, string value)
        {
            ComparisonOperators.EqualTo(value);

            return ComparisonOperators;
        }

        public static IComparisonOperators EqualTo(this IWhereFilter whereFilter, int value)
        {
            ComparisonOperators.EqualTo(value);
            return ComparisonOperators;
        }

        public static IComparisonOperators GreaterThan(this IWhereFilter whereFilter, int value)
        {

            ComparisonOperators.GreaterThan(value);
            return ComparisonOperators;
        }

        public static IComparisonOperators LessThan(this IWhereFilter whereFilter, int value)
        {
            ComparisonOperators.LessThan(value);
            return ComparisonOperators;
        }

        public static IComparisonOperators GreaterThanOrEqualTo(this IWhereFilter whereFilter, int value)
        {
             ComparisonOperators.GreaterThanOrEqualTo(value);
            return ComparisonOperators;
        }

        public static IComparisonOperators LessThanOrEqualTo(this IWhereFilter whereFilter, int value)
        {
            ComparisonOperators.LessThanOrEqualTo(value);
            return ComparisonOperators;
        }

        public static IComparisonOperators NotEqualTo(this IWhereFilter whereFilter, int value)
        {
            ComparisonOperators.NotEqualTo(value);
            return ComparisonOperators;
        }

        public static IComparisonOperators NotEqualTo(this IWhereFilter whereFilter, string value)
        {
            ComparisonOperators.NotEqualTo(value);
            return ComparisonOperators;
        }
    }
}
