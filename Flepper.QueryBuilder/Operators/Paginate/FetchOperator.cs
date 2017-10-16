namespace Flepper.QueryBuilder
{
    internal partial class QueryBuilder : IFetchOperator
    {
        public IFetchOperator Fetch(int numberOfRows)
        {
            Command.AppendFormat("FETCH NEXT {0} ROWS ONLY ", numberOfRows);
            return this;
        }
    }
}
