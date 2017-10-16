namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Sort Operator Extensions
    /// </summary>
    public static class SortOperatorExtensions
    {
        /// <summary>
        /// Off Set Operator
        /// </summary>
        /// <param name="sortThen">sortTheInstance</param>
        /// <param name="ignoredRowsQuantity">Number of ignored rows</param>
        /// <returns></returns>
        public static IOffSetOperator OffSet(this ISortThen sortThen, int ignoredRowsQuantity)
            => sortThen is IOffSetOperator command ? command.OffSet(ignoredRowsQuantity) : null;
    }
}
