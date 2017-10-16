namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Offset Operator Interface
    /// </summary>
    public interface IOffSetOperator : IQueryCommand
    {
        /// <summary>
        /// Off Set Contract
        /// </summary>
        /// <param name="ignoredRowsQuantity">Number of ignored rows</param>
        /// <returns></returns>
        IOffSetOperator OffSet(int ignoredRowsQuantity);
    }
}