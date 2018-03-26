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
        /// <returns></returns>
        public static IComparisonOperators EqualNull(this IWhereFilter whereFilter)
            => whereFilter is IComparisonOperators command ? command.EqualNull() : null;

        /// <summary>
        /// Add Greater Than to query
        /// </summary>
        /// <param name="whereFilter">Where Filter instance</param>
        /// <param name="value">Value to filter</param>
        /// <returns></returns>
        public static IComparisonOperators GreaterThan<T>(this IWhereFilter whereFilter, T value)
            => whereFilter is IComparisonOperators command ? command.GreaterThan<T>(value) : null;

        /// <summary>
        /// Add Less Than to query
        /// </summary>
        /// <param name="whereFilter">Where Filter instance</param>
        /// <param name="value">Value to filter</param>
        /// <returns></returns>
        public static IComparisonOperators LessThan<T>(this IWhereFilter whereFilter, T value)
            => whereFilter is IComparisonOperators command ? command.LessThan<T>(value) : null;

        /// <summary>
        /// Add Greater Than Or Equal to query
        /// </summary>
        /// <param name="whereFilter">Where Filter instance</param>
        /// <param name="value">Value to filter</param>
        /// <returns></returns>
        public static IComparisonOperators GreaterThanOrEqualTo<T>(this IWhereFilter whereFilter, T value)
            => whereFilter is IComparisonOperators command ? command.GreaterThanOrEqualTo<T>(value) : null;

        /// <summary>
        /// Add Less Than Or Equal to query
        /// </summary>
        /// <param name="whereFilter">Where Filter instance</param>
        /// <param name="value">Value to filter</param>
        /// <returns></returns>
        public static IComparisonOperators LessThanOrEqualTo<T>(this IWhereFilter whereFilter, T value)
            => whereFilter is IComparisonOperators command ? command.LessThanOrEqualTo<T>(value) : null;

        /// <summary>
        /// Add Not Equal to query
        /// </summary>
        /// <param name="whereFilter">Where Filter instance</param>
        /// <param name="value">Value to filter</param>
        /// <returns></returns>
        public static IComparisonOperators NotEqualTo<T>(this IWhereFilter whereFilter, T value)
            => whereFilter is IComparisonOperators command ? command.NotEqualTo<T>(value) : null;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="whereFilter"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IComparisonOperators Contains<T>(this IWhereFilter whereFilter, T value)
            => whereFilter is IComparisonOperators command ? command.Contains(value) : null;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="whereFilter"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IComparisonOperators StartsWith<T>(this IWhereFilter whereFilter, T value)
            => whereFilter is IComparisonOperators command ? command.StartsWith(value) : null;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="whereFilter"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IComparisonOperators EndsWith<T>(this IWhereFilter whereFilter, T value)
            => whereFilter is IComparisonOperators command ? command.EndsWith(value) : null;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TFrom"></typeparam>
        /// <typeparam name="TTo"></typeparam>
        /// <param name="whereFilter"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static IComparisonOperators Between<TFrom, TTo>(this IWhereFilter whereFilter, TFrom from, TTo to)
            => whereFilter is IComparisonOperators command ? command.Between(from, to) : null;
    }
}