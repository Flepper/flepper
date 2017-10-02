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
        public static IComparisonOperators EqualTo<T>(this IWhereFilter whereFilter, T value)
            => whereFilter is IComparisonOperators command ? command.EqualTo<T>(value) : null;

        /// <summary>
        /// Add Equal to query
        /// </summary>
        /// <param name="whereFilter">Where Filter instance</param>
        /// <param name="value">Value to filter</param>
        /// <returns></returns>
        public static IComparisonOperators EqualTo(this IWhereFilter whereFilter, int value)
            => whereFilter is IComparisonOperators command ? command.EqualTo(value) : null;

        /// <summary>
        /// Add Greater Than to query
        /// </summary>
        /// <param name="whereFilter">Where Filter instance</param>
        /// <param name="value">Value to filter</param>
        /// <returns></returns>
        public static IComparisonOperators GreaterThan(this IWhereFilter whereFilter, int value)
            => whereFilter is IComparisonOperators command ? command.GreaterThan(value) : null;

        /// <summary>
        /// Add Less Than to query
        /// </summary>
        /// <param name="whereFilter">Where Filter instance</param>
        /// <param name="value">Value to filter</param>
        /// <returns></returns>
        public static IComparisonOperators LessThan(this IWhereFilter whereFilter, int value)
            => whereFilter is IComparisonOperators command ? command.LessThan(value) : null;

        /// <summary>
        /// Add Greater Than Or Equal to query
        /// </summary>
        /// <param name="whereFilter">Where Filter instance</param>
        /// <param name="value">Value to filter</param>
        /// <returns></returns>
        public static IComparisonOperators GreaterThanOrEqualTo(this IWhereFilter whereFilter, int value)
            => whereFilter is IComparisonOperators command ? command.GreaterThanOrEqualTo(value) : null;

        /// <summary>
        /// Add Less Than Or Equal to query
        /// </summary>
        /// <param name="whereFilter">Where Filter instance</param>
        /// <param name="value">Value to filter</param>
        /// <returns></returns>
        public static IComparisonOperators LessThanOrEqualTo(this IWhereFilter whereFilter, int value)
            => whereFilter is IComparisonOperators command ? command.LessThanOrEqualTo(value) : null;

        /// <summary>
        /// Add Not Equal to query
        /// </summary>
        /// <param name="whereFilter">Where Filter instance</param>
        /// <param name="value">Value to filter</param>
        /// <returns></returns>
        public static IComparisonOperators NotEqualTo<T>(this IWhereFilter whereFilter, T value)
            => whereFilter is IComparisonOperators command ? command.NotEqualTo<T>(value) : null;

        /// <summary>
        /// Add Not Equal to query
        /// </summary>
        /// <param name="whereFilter">Where Filter instance</param>
        /// <param name="value">Value to filter</param>
        /// <returns></returns>
        public static IComparisonOperators NotEqualTo(this IWhereFilter whereFilter, string value)
            => whereFilter is IComparisonOperators command ? command.NotEqualTo(value) : null;
    }
}