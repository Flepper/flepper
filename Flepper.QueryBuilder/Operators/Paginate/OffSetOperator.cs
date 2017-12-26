namespace Flepper.QueryBuilder
{
    internal partial class QueryBuilder : IOffSetOperator
    {
        public IOffSetOperator OffSet(int ignoredRowsQuantity)
        {
            Command.AppendFormat(" OFFSET {0} ROWS ", ignoredRowsQuantity);
            return this;
        }
    }
}
