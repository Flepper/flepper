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
            => whereFilter.To<ComparisonOperators>().EqualTo(value);

        /// <summary>
        /// Add Greater Than to query
        /// </summary>
        /// <param name="whereFilter">Where Filter instance</param>
        /// <param name="value">Value to filter</param>
        /// <returns></returns>
        public static IComparisonOperators GreaterThan<T>(this IWhereFilter whereFilter, T value)
            => whereFilter.To<ComparisonOperators>().GreaterThan(value);

        /// <summary>
        /// Add Less Than to query
        /// </summary>
        /// <param name="whereFilter">Where Filter instance</param>
        /// <param name="value">Value to filter</param>
        /// <returns></returns>
        public static IComparisonOperators LessThan<T>(this IWhereFilter whereFilter, T value)
            => whereFilter.To<ComparisonOperators>().LessThan(value);

        /// <summary>
        /// Add Greater Than Or Equal to query
        /// </summary>
        /// <param name="whereFilter">Where Filter instance</param>
        /// <param name="value">Value to filter</param>
        /// <returns></returns>
        public static IComparisonOperators GreaterThanOrEqualTo<T>(this IWhereFilter whereFilter, T value)
            => whereFilter.To<ComparisonOperators>().GreaterThanOrEqualTo(value);

        /// <summary>
        /// Add Less Than Or Equal to query
        /// </summary>
        /// <param name="whereFilter">Where Filter instance</param>
        /// <param name="value">Value to filter</param>
        /// <returns></returns>
        public static IComparisonOperators LessThanOrEqualTo<T>(this IWhereFilter whereFilter, T value)
            => whereFilter.To<ComparisonOperators>().LessThanOrEqualTo(value);

        /// <summary>
        /// Add Not Equal to query
        /// </summary>
        /// <param name="whereFilter">Where Filter instance</param>
        /// <param name="value">Value to filter</param>
        /// <returns></returns>
        public static IComparisonOperators NotEqualTo<T>(this IWhereFilter whereFilter, T value)
            => whereFilter.To<ComparisonOperators>().NotEqualTo(value);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="whereFilter"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IComparisonOperators Contains<T>(this IWhereFilter whereFilter, T value)
            => whereFilter.To<ComparisonOperators>().Contains(value);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="whereFilter"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IComparisonOperators StartsWith<T>(this IWhereFilter whereFilter, T value)
            => whereFilter.To<ComparisonOperators>().StartsWith(value);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="whereFilter"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IComparisonOperators EndsWith<T>(this IWhereFilter whereFilter, T value)
            => whereFilter.To<ComparisonOperators>().EndsWith(value);

    }
}