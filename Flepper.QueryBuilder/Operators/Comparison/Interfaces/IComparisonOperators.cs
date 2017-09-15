namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Comparison Operator Interface
    /// </summary>
    public interface IComparisonOperators : IQueryCommand
    {
        /// <summary>
        /// Equal Comparison Operator Contract
        /// </summary>
        /// <param name="value">Value</param>
        /// <returns></returns>
        IComparisonOperators EqualTo(object value);

        /// <summary>
        /// Greater Than Comparison Operator Contract
        /// </summary>
        /// <param name="value">Value</param>
        /// <returns></returns>
        IComparisonOperators GreaterThan(int value);

        /// <summary>
        /// Less Than Comparison Operator Contract
        /// </summary>
        /// <param name="value">Value</param>
        /// <returns></returns>
        IComparisonOperators LessThan(int value);

        /// <summary>
        /// Greater Than Or Equal Comparison Operator Contract
        /// </summary>
        /// <param name="value">Value</param>
        /// <returns></returns>
        IComparisonOperators GreaterThanOrEqualTo(int value);

        /// <summary>
        /// Less Than Or Equal Comparison Operator Contract
        /// </summary>
        /// <param name="value">Value</param>
        /// <returns></returns>
        IComparisonOperators LessThanOrEqualTo(int value);

        /// <summary>
        /// Not equal Comparison Operator Contract
        /// </summary>
        /// <param name="value">Value</param>
        /// <returns></returns>
        IComparisonOperators NotEqualTo(object value);
    }
}