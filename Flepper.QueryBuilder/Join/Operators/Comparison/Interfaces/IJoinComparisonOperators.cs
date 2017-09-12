namespace Flepper.QueryBuilder
{
    public interface IJoinComparisonOperators : IQueryCommand
    {
        IJoinComparisonOperators Equal(string column, string tableAlias);
        IJoinComparisonOperators NotEqual(string column, string tableAlias);
    }
}