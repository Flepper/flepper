namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Where Extensions
    /// </summary>
    public static class WhereFilterExtensions
    {
        /// <summary>
        /// Add Equal to query
        /// </summary>
        /// <param name="whereFilter">Where Filter instance</param>
        /// <param name="value">Value to filter</param>
        /// <returns></returns>
        public static IComparisonOperators EqualTo(this IWhereFilter whereFilter, string value)
            => whereFilter.To<ComparisonOperators>().EqualTo(value);

        /// <summary>
        /// Add Equal to query
        /// </summary>
        /// <param name="whereFilter">Where Filter instance</param>
        /// <param name="value">Value to filter</param>
        /// <returns></returns>
        public static IComparisonOperators EqualTo(this IWhereFilter whereFilter, int value)
            => whereFilter.To<ComparisonOperators>().EqualTo(value);

        /// <summary>
        /// Add Greater Than to query
        /// </summary>
        /// <param name="whereFilter">Where Filter instance</param>
        /// <param name="value">Value to filter</param>
        /// <returns></returns>
        public static IComparisonOperators GreaterThan(this IWhereFilter whereFilter, int value)
            => whereFilter.To<ComparisonOperators>().GreaterThan(value);

        /// <summary>
        /// Add Less Than to query
        /// </summary>
        /// <param name="whereFilter">Where Filter instance</param>
        /// <param name="value">Value to filter</param>
        /// <returns></returns>
        public static IComparisonOperators LessThan(this IWhereFilter whereFilter, int value)
            => whereFilter.To<ComparisonOperators>().LessThan(value);

        /// <summary>
        /// Add Greater Than Or Equal to query
        /// </summary>
        /// <param name="whereFilter">Where Filter instance</param>
        /// <param name="value">Value to filter</param>
        /// <returns></returns>
        public static IComparisonOperators GreaterThanOrEqualTo(this IWhereFilter whereFilter, int value)
            => whereFilter.To<ComparisonOperators>().GreaterThanOrEqualTo(value);

        /// <summary>
        /// Add Less Than Or Equal to query
        /// </summary>
        /// <param name="whereFilter">Where Filter instance</param>
        /// <param name="value">Value to filter</param>
        /// <returns></returns>
        public static IComparisonOperators LessThanOrEqualTo(this IWhereFilter whereFilter, int value)
            => whereFilter.To<ComparisonOperators>().LessThanOrEqualTo(value);

        /// <summary>
        /// Add Not Equal to query
        /// </summary>
        /// <param name="whereFilter">Where Filter instance</param>
        /// <param name="value">Value to filter</param>
        /// <returns></returns>
        public static IComparisonOperators NotEqualTo(this IWhereFilter whereFilter, int value)
            => whereFilter.To<ComparisonOperators>().NotEqualTo(value);

        /// <summary>
        /// Add Not Equal to query
        /// </summary>
        /// <param name="whereFilter">Where Filter instance</param>
        /// <param name="value">Value to filter</param>
        /// <returns></returns>
        public static IComparisonOperators NotEqualTo(this IWhereFilter whereFilter, string value)
            => whereFilter.To<ComparisonOperators>().NotEqualTo(value);
    }
}