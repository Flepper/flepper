namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Off Set Operator Extension
    /// </summary>
    public static class OffSetOperatorExtension
    {
        /// <summary>
        /// Fetch Operator
        /// </summary>
        /// <param name="offSetOperator">offSetOperator instance</param>
        /// <param name="numberOfRows">Number of rows returned</param>
        /// <returns></returns>
        public static IFetchOperator Fetch(this IOffSetOperator offSetOperator, int numberOfRows)
            => offSetOperator is IFetchOperator command ? command.Fetch(numberOfRows) : null;
    }
}
