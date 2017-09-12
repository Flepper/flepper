namespace Flepper.QueryBuilder
{
    public static class WhereFilterExtensions
    {
        public static IComparisonOperators EqualTo(this IWhereFilter whereFilter, string value)
            => whereFilter.To<ComparisonOperators>().EqualTo(value);

        public static IComparisonOperators EqualTo(this IWhereFilter whereFilter, int value)
            => whereFilter.To<ComparisonOperators>().EqualTo(value);

        public static IComparisonOperators GreaterThan(this IWhereFilter whereFilter, int value)
            => whereFilter.To<ComparisonOperators>().GreaterThan(value);

        public static IComparisonOperators LessThan(this IWhereFilter whereFilter, int value)
            => whereFilter.To<ComparisonOperators>().LessThan(value);

        public static IComparisonOperators GreaterThanOrEqualTo(this IWhereFilter whereFilter, int value)
            => whereFilter.To<ComparisonOperators>().GreaterThanOrEqualTo(value);

        public static IComparisonOperators LessThanOrEqualTo(this IWhereFilter whereFilter, int value)
            => whereFilter.To<ComparisonOperators>().LessThanOrEqualTo(value);

        public static IComparisonOperators NotEqualTo(this IWhereFilter whereFilter, int value)
            => whereFilter.To<ComparisonOperators>().NotEqualTo(value);

        public static IComparisonOperators NotEqualTo(this IWhereFilter whereFilter, string value)
            => whereFilter.To<ComparisonOperators>().NotEqualTo(value);
    }
}