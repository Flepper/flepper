namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Comparison Operator Interface
    /// </summary>
    public interface IComparisonOperators : IQueryCommand, ISortCommand
    {
        /// <summary>
        /// Equal Comparison Operator Contract
        /// </summary>
        /// <param name="value">Value used to compare</param>
        /// <returns></returns>
        IComparisonOperators EqualTo<T>(T value);

        /// <summary>
        /// Greater Than Comparison Operator Contract
        /// </summary>
        /// <param name="value">Value used to compare</param>
        /// <returns></returns>
        IComparisonOperators GreaterThan<T>(T value);

        /// <summary>
        /// Less Than Comparison Operator Contract
        /// </summary>
        /// <param name="value">Value used to compare</param>
        /// <returns></returns>
        IComparisonOperators LessThan<T>(T value);

        /// <summary>
        /// Greater Than Or Equal Comparison Operator Contract
        /// </summary>
        /// <param name="value">Value used to compare</param>
        /// <returns></returns>
        IComparisonOperators GreaterThanOrEqualTo<T>(T value);

        /// <summary>
        /// Less Than Or Equal Comparison Operator Contract
        /// </summary>
        /// <param name="value">Value used to compare</param>
        /// <returns></returns>
        IComparisonOperators LessThanOrEqualTo<T>(T value);

        /// <summary>
        /// Not equal Comparison Operator Contract
        /// </summary>
        /// <param name="value">Value used to compare</param>
        /// <returns></returns>
        IComparisonOperators NotEqualTo<T>(T value);

        /// <summary>
        /// Contains
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">Value used to compare</param>
        /// <returns></returns>
        IComparisonOperators Contains<T>(T value);

        /// <summary>
        /// StartsWith
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">Value used to compare</param>
        /// <returns></returns>
        IComparisonOperators StartsWith<T>(T value);

        /// <summary>
        /// EndsWith
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">Value used to compare</param>
        /// <returns></returns>
        IComparisonOperators EndsWith<T>(T value);
    }
}
